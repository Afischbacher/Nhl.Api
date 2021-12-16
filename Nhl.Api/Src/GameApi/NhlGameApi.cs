using Nhl.Api.Common.Exceptions;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// NHL Game API
    /// </summary>
    public class NhlGameApi : INhlGameApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlLeagueApi _nhlLeagueApi = new NhlLeagueApi();
        private static readonly INhlApiHttpClient _nhlShiftChartHttpClient = new NhlShiftChartHttpClient();

        /// <summary>
        /// Returns the box score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, penalties, players, team statistics and more</returns>
        public async Task<Boxscore> GetBoxScoreByIdAsync(int gameId)
        {
            return await _nhlStatsApiHttpClient.GetAsync<Boxscore>($"/game/{gameId}/boxscore");
        }

        /// <summary>
        /// Return's today's the NHL game schedule and it will provide today's current NHL game schedule 
        /// </summary>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>("/schedule");
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
        /// </summary>
        /// <param name="date">The requested date for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(DateTime? date)
        {
            var httpRequestUri = date.HasValue ? $"/schedule?date={date.Value:yyyy-MM-dd}" : "/schedule";
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>(httpRequestUri);
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided year, month and day
        /// </summary>
        /// <param name="year">The requested year for the NHL game schedule</param>
        /// <param name="month">The requested month for the NHL game schedule</param>
        /// <param name="day">The requested day for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more infGetGameScheduleByDateAsyncormation</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(int year, int month, int day)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?date={year}-{month}-{day}");
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(TeamEnum team, DateTime startDate, DateTime endDate)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?teamId={(int)team}&startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 1</param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(int teamId, DateTime startDate, DateTime endDate)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?teamId={teamId}&startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        }

        /// <summary>
        /// Return's the entire collection of NHL game schedules for the specified season
        /// </summary>
        /// <param name="seasonYear">The NHL season year, Example: 19992000, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="includePlayoffGames">Includes all of the NHL playoff games, default value is false</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected NHL season</returns>
        public async Task<GameSchedule> GetGameSchedulesBySeasonAsync(string seasonYear, bool includePlayoffGames = false)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var selectedSeason = await _nhlLeagueApi.GetSeasonByYearAsync(seasonYear);
            if (selectedSeason == null)
            {
                throw new InvalidSeasonException($"{seasonYear} is not a valid NHL season");
            }

            var startDate = selectedSeason.RegularSeasonStartDate;
            var endDate = includePlayoffGames ? selectedSeason.SeasonEndDate : selectedSeason.RegularSeasonEndDate;

            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?&startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        }


        /// <summary>
        /// Returns all of the valid NHL game statuses of an NHL game
        /// </summary>
        /// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
        public async Task<List<GameStatus>> GetGameStatusesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<GameStatus>>($"/gameStatus");
        }

        /// <summary>
        /// Returns all of the NHL game types within a season and within special events
        /// </summary>
        /// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
        public async Task<List<GameType>> GetGameTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<GameType>>($"/gameTypes");
        }

        /// <summary>
        /// Returns the line score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, strength of the play, time remaining, shots on goal and more</returns>
        public async Task<Linescore> GetLineScoreByIdAsync(int gameId)
        {
            return await _nhlStatsApiHttpClient.GetAsync<Linescore>($"/game/{gameId}/linescore");
        }

        /// <summary>
        /// Returns the live game feed content for an NHL game
        /// </summary>
        /// <param name="liveGameFeedId">The live game feed id, Example: 2021020087</param>
        /// <returns>A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more</returns>
        public async Task<LiveGameFeedResult> GetLiveGameFeedByIdAsync(int liveGameFeedId)
        {
            var liveGameFeed = await _nhlStatsApiHttpClient.GetAsync<LiveGameFeed>($"/game/{liveGameFeedId}/feed/live");

            // Enrich Live Feed Data
            SetCorrectedRinkSideLiveGameFeed(liveGameFeed);
            await SetActivePlayersOnIceForAllPlays(liveGameFeed);

            return new LiveGameFeedResult
            {
                LiveGameFeed = liveGameFeed
            };
        }

        /// <summary>
        /// Returns a collection of all the different types of playoff tournaments in the NHL 
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
        public async Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<PlayoffTournamentType>($"/tournaments/playoffs");
        }

        /// <summary>
        /// Returns a collection of all the play types within the duration of an NHL game
        /// </summary>
        /// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
        public async Task<List<PlayType>> GetPlayTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<PlayType>>($"/playTypes");
        }

        /// <summary>
        /// Returns a collection of all the different types of tournaments in the hockey
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
        public async Task<List<TournamentType>> GetTournamentTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<TournamentType>>($"/tournamentTypes");
        }

        /// <summary>
        /// Sets the correct rink side for both the NHL home and away team
        /// </summary>
        private void SetCorrectedRinkSideLiveGameFeed(LiveGameFeed liveGameFeed)
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

                // What if the shot is before the center line? Then in the case of 2010020405 game id 
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
                // If there is any error, catch and continue
            }
        }

        /// <summary>
        /// Set's and add's the active players on each live game feed play
        /// </summary>
        private async Task SetActivePlayersOnIceForAllPlays(LiveGameFeed liveGameFeed)
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
                    && liveGameFeed.LiveData.Boxscore.Teams.Home.Player != null
                    && liveGameFeed.LiveData.Boxscore.Teams.Away.Player != null;

                // If the live game feed is invalid, return and continue
                if (!isValidLiveGameFeed)
                {
                    return;
                }

                var homeTeamId = liveGameFeed.LiveData.Boxscore.Teams.Home.TeamInformation.Id;
                var awayTeamId = liveGameFeed.LiveData.Boxscore.Teams.Away.TeamInformation.Id;

                // Iterate through each play for the live game feed
                foreach (var gamePlay in liveGameFeed.LiveData.Plays.AllPlays)
                {
                    var playersByTeam = new Dictionary<int, List<int>>();

                    // Determine the players on the ice for the specific game play
                    var playersOnIceForGamePlay = allPlayerShifts.PlayerShifts
                        .Where(playerShift => TimeSpan.Parse($"00:{gamePlay.About.PeriodTime}") >= TimeSpan.Parse($"00:{playerShift.StartTime}")
                                && TimeSpan.Parse($"00:{gamePlay.About.PeriodTime}") <= TimeSpan.Parse($"00:{playerShift.EndTime}")
                                && playerShift.Period == gamePlay.About.Period).ToList();

                    // Categorize each player by home or away team and organize them
                    foreach (var playerOnIce in playersOnIceForGamePlay)
                    {
                        if (liveGameFeed.LiveData.Boxscore.Teams.Home.Player.ContainsKey($"ID{playerOnIce.PlayerId}"))
                        {
                            if (!playersByTeam.ContainsKey(homeTeamId))
                            {
                                playersByTeam.Add(homeTeamId, new List<int> { playerOnIce.PlayerId });
                                continue;
                            }

                            playersByTeam[homeTeamId].Add(playerOnIce.PlayerId);
                        }

                        if (liveGameFeed.LiveData.Boxscore.Teams.Away.Player.ContainsKey($"ID{playerOnIce.PlayerId}"))
                        {
                            if (!playersByTeam.ContainsKey(awayTeamId))
                            {
                                playersByTeam.Add(awayTeamId, new List<int> { playerOnIce.PlayerId });
                                continue;
                            }

                            playersByTeam[awayTeamId].Add(playerOnIce.PlayerId);
                        }

                    }

                    // Note: There are cases where players are changing shifts
                    // and you may see more than 6 players on each home/away team

                    // Add player id's to each play
                    gamePlay.ActivePlayersOnIce = new ActivePlayersOnIce
                    {
                        AwayPlayers = playersByTeam[awayTeamId],
                        HomePlayers = playersByTeam[homeTeamId]
                    };
                }
            }
            catch
            {
                // If there is any error, catch and continue
            }
        }
    }
}
