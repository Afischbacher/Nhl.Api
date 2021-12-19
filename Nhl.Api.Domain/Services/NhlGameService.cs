using Nhl.Api.Common.Http;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Services
{
    /// <summary>
    /// The NHL game service, enabling data enrichment and functionality to the NHL API
    /// </summary>
    public interface INhlGameService
    {
        /// <summary>
        /// Set's and add's the active players on each live game feed play
        /// </summary>
        Task SetActivePlayersOnIceForAllPlaysAsync(LiveGameFeed liveGameFeed);

        /// <summary>
        /// Sets the correct rink side for both the NHL home and away team
        /// </summary>
        void SetCorrectedRinkSideLiveGameFeed(LiveGameFeed liveGameFeed);
    }

    /// <summary>
    /// The NHL game service, enabling data enrichment and functionality to the NHL API
    /// </summary>
    public class NhlGameService : INhlGameService
    {
        private static readonly INhlApiHttpClient _nhlShiftChartHttpClient = new NhlShiftChartHttpClient();

        /// <summary>
        /// Set's and add's the active players on each live game feed play
        /// </summary>
        public async Task SetActivePlayersOnIceForAllPlaysAsync(LiveGameFeed liveGameFeed)
        {
            try
            {
                // Get all player shifts for the specified game id
                var allPlayerShifts = await _nhlShiftChartHttpClient.GetAsync<LiveGameFeedPlayerShifts>($"?cayenneExp=gameId={liveGameFeed.GamePk}");
                if (!allPlayerShifts.PlayerShifts.Any())
                {
                    return;
                }

                var isValidLiveGameFeed = liveGameFeed.LiveData != null
                    && liveGameFeed.LiveData.Boxscore != null
                    && liveGameFeed.LiveData.Boxscore.Teams != null
                    && liveGameFeed.LiveData.Boxscore.Teams.Home.Players != null
                    && liveGameFeed.LiveData.Boxscore.Teams.Away.Players != null;

                // If the live game feed is invalid, return and continue
                if (!isValidLiveGameFeed)
                {
                    return;
                }

                var homeTeam = liveGameFeed?.LiveData?.Boxscore?.Teams?.Home?.TeamInformation;
                var awayTeam = liveGameFeed?.LiveData?.Boxscore?.Teams?.Away?.TeamInformation;

                if (homeTeam == null || awayTeam == null)
                {
                    return;
                }

                // Iterate through each play for the live game feed
                foreach (var gamePlay in liveGameFeed.LiveData.Plays.AllPlays)
                {
                    var playersByTeam = new Dictionary<int, List<int>>
                    {
                        { homeTeam.Id, new List<int>() },
                        { awayTeam.Id, new List<int>() }
                    };

                    // The current time of the period
                    var periodTime = TimeSpan.Parse($"00:{gamePlay.About.PeriodTime}");
                    var period = gamePlay.About.Period;

                    // Determine the players on the ice for the specific game play
                    var playersOnIceForGamePlay = allPlayerShifts.PlayerShifts
                        .Where(playerShift => periodTime >= TimeSpan.Parse($"00:{playerShift.StartTime}")
                                && periodTime <= TimeSpan.Parse($"00:{playerShift.EndTime}")
                                && playerShift.Period == period).ToList();

                    // Categorize each player by home or away team and organize them
                    foreach (var playerOnIce in playersOnIceForGamePlay)
                    {
                        if (liveGameFeed.LiveData.Boxscore.Teams.Home.Players.ContainsKey($"ID{playerOnIce.PlayerId}"))
                        {
                            playersByTeam[homeTeam.Id].Add(playerOnIce.PlayerId);
                        }

                        if (liveGameFeed.LiveData.Boxscore.Teams.Away.Players.ContainsKey($"ID{playerOnIce.PlayerId}"))
                        {
                            playersByTeam[awayTeam.Id].Add(playerOnIce.PlayerId);
                        }
                    }

                    // There are cases where players are changing shifts or taking a penalty shot and you may see more or less 6 players on each team
                    playersByTeam.TryGetValue(homeTeam.Id, out var homeTeamPlayers);
                    playersByTeam.TryGetValue(awayTeam.Id, out var awayTeamPlayers);

                    // Add player id's to each play
                    gamePlay.ActivePlayersOnIce = new PlayersOnIce
                    {
                        HomeTeam = homeTeamPlayers,
                        AwayTeam = awayTeamPlayers
                    };
                }
            }
            catch
            {
                // If there is any error, catch and ignore
            }
        }

        /// <summary>
        /// Sets the correct rink side for both the NHL home and away team
        /// </summary>
        public void SetCorrectedRinkSideLiveGameFeed(LiveGameFeed liveGameFeed)
        {

            // Ensure live game feed is valid
            var isValidLiveGameFeed = liveGameFeed != null
                && liveGameFeed.LiveData != null
                && liveGameFeed.LiveData.Linescore != null
                && liveGameFeed.LiveData.Plays.AllPlays.Any();

            if (!isValidLiveGameFeed)
            {
                return;
            }

            // Home and Away Teams
            var homeTeam = liveGameFeed?.GameData?.Teams?.Home;
            var awayTeam = liveGameFeed?.GameData?.Teams?.Away;

            if (homeTeam == null || awayTeam == null)
            {
                return;
            }

            // Use 1st period plays
            var startRange = liveGameFeed.LiveData.Plays.PlaysByPeriod.FirstOrDefault()?.StartIndex ?? 0;
            var endRange = liveGameFeed.LiveData.Plays.PlaysByPeriod.FirstOrDefault()?.EndIndex ?? 0;

            // Categorize shots from home and away teams to determine correct rink side for each team for each regular period
            var numberOfShotsFromFirstPeriod = new Dictionary<string, int>()
            {
                { "homeTeamLeftTeamShot", 0 },
                { "awayTeamLeftTeamShot", 0 },
                { "awayTeamRightTeamShot", 0 },
                { "homeTeamRightTeamShot", 0 }
            };

            // Filter out and get shot plays for 1st period
            var shotPlays = liveGameFeed.LiveData.Plays.AllPlays
            .GetRange(startRange, endRange)
            .Where(periodPlay => periodPlay.Team != null
            && periodPlay.Coordinates.X != null
            && periodPlay.Coordinates.Y != null
            && periodPlay.Result.Event.ToLower() == "shot")
            .ToList();

            // Iterate through each shot play and categorize shot type
            foreach (var shotPlay in shotPlays)
            {

                // Left side is away team if X < 0 and shot result event is the team id of the home team
                if (shotPlay.Team.Id == homeTeam.Id && shotPlay.Coordinates.X < 0)
                {
                    numberOfShotsFromFirstPeriod["homeTeamLeftTeamShot"] += 1;
                }

                else if (shotPlay.Team.Id != homeTeam.Id && shotPlay.Coordinates.X < 0)
                {
                    numberOfShotsFromFirstPeriod["awayTeamLeftTeamShot"] += 1;
                }

                else if (shotPlay.Team.Id != homeTeam.Id && shotPlay.Coordinates.X > 0)
                {
                    numberOfShotsFromFirstPeriod["awayTeamRightTeamShot"] += 1;
                }

                else if (shotPlay.Team.Id == homeTeam.Id && shotPlay.Coordinates.X > 0)
                {
                    numberOfShotsFromFirstPeriod["homeTeamRightTeamShot"] += 1;
                }
            }

            try
            {

                // Determine correct side of the rink for each home and away team for the regular period
                var numberOfShotsFromFirstPeriodMax = numberOfShotsFromFirstPeriod.OrderByDescending(x => x.Value).First();
                if (numberOfShotsFromFirstPeriodMax.Key == "homeTeamLeftTeamShot" || numberOfShotsFromFirstPeriodMax.Key == "awayTeamRightTeamShot")
                {
                    for (var i = 0; i < liveGameFeed.LiveData.Linescore.Periods.Count; i++)
                    {
                        if (liveGameFeed.LiveData.Linescore.Periods[i].PeriodType == "REGULAR")
                        {
                            liveGameFeed.LiveData.Linescore.Periods[i].Home.CorrectedRinkSide = i % 2 == 0 ? "right" : "left";
                            liveGameFeed.LiveData.Linescore.Periods[i].Away.CorrectedRinkSide = i % 2 == 0 ? "left" : "right";
                        }
                    }
                }

                if (numberOfShotsFromFirstPeriodMax.Key == "homeTeamRightTeamShot" || numberOfShotsFromFirstPeriodMax.Key == "awayTeamLeftTeamShot")
                {
                    for (var i = 0; i < liveGameFeed.LiveData.Linescore.Periods.Count; i++)
                    {
                        if (liveGameFeed.LiveData.Linescore.Periods[i].PeriodType == "REGULAR")
                        {
                            liveGameFeed.LiveData.Linescore.Periods[i].Home.CorrectedRinkSide = i % 2 == 0 ? "left" : "right";
                            liveGameFeed.LiveData.Linescore.Periods[i].Away.CorrectedRinkSide = i % 2 == 0 ? "right" : "left";
                        }
                    }
                }
            }
            catch
            {
                // If there is any error, catch and ignore
            }
        }
    }
}
