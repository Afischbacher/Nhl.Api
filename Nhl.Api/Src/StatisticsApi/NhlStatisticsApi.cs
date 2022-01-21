using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Nhl.Api.Common.Exceptions;
using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
    /// </summary>
    public class NhlStatisticsApi : INhlStatisticsApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlPlayerApi _nhlPlayerApi = new NhlPlayerApi();

        /// <summary>
        /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
        /// </summary>
        public NhlStatisticsApi()
        {

        }

        /// <summary>
        /// Returns all of the NHL team's statistics for the specific NHL season
        /// </summary>
        /// <param name="seasonYear">A season year for the all the NHL statistics, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<TeamSeasonStatistics> GetAllTeamsStatisticsBySeasonAsync(string seasonYear)
        {

            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            return (await _nhlStatsApiHttpClient.GetAsync<TeamSeasonStatistics>($"/teams?expand=team.stats&season={seasonYear}"));

        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        public async Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(int playerId, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var nhlPlayer = await _nhlPlayerApi.GetPlayerByIdAsync(playerId);
            var isPlayerPositionNotGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation != PlayerPositionEnum.G.ToString();
            if (isPlayerPositionNotGoalie)
            {
                throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not have his statistics retrieved");
            }

            return await _nhlStatsApiHttpClient.GetAsync<GoalieSeasonStatistics>($"/people/{playerId}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");

        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        public async Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var nhlPlayer = await _nhlPlayerApi.GetPlayerByIdAsync((int)player);
            var isPlayerPositionNotGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation != PlayerPositionEnum.G.ToString();
            if (isPlayerPositionNotGoalie)
            {
                throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not have his statistics retrieved");
            }

            return await _nhlStatsApiHttpClient.GetAsync<GoalieSeasonStatistics>($"/people/{((int)player)}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");
        }

        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(PlayerEnum player)
        {
            return await _nhlStatsApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{((int)player)}/stats?stats={nameof(PlayerStatisticsTypeEnum.OnPaceRegularSeason).ToCamelCase()}");
        }
        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(int playerId)
        {
            return await _nhlStatsApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{playerId}/stats?stats={nameof(PlayerStatisticsTypeEnum.OnPaceRegularSeason).ToCamelCase()}");
        }

        /// <summary>
        /// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(int playerId, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var nhlPlayer = await _nhlPlayerApi.GetPlayerByIdAsync(playerId);
            var isPlayerPositionGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation == PlayerPositionEnum.G.ToString();
            if (isPlayerPositionGoalie)
            {
                throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not his have statistics retrieved");
            }

            return await _nhlStatsApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{playerId}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");
        }

        /// <summary>
        /// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var nhlPlayer = await _nhlPlayerApi.GetPlayerByIdAsync((int)player);
            var isPlayerPositionGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation == PlayerPositionEnum.G.ToString();
            if (isPlayerPositionGoalie)
            {
                throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not have his statistics retrieved");
            }

            return await _nhlStatsApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{((int)player)}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");
        }

        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <returns>Returns the player profile with the top player statistic in the specified NHL season</returns>
        public async Task<PlayerStatisticResult> GetPlayerWithTopStatisticBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear)
        {
            return (await GetPlayerStatisticResultsAsync(playerStatisticEnum, seasonYear, 1)).FirstOrDefault();
        }


        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>Returns the goalie profile with the top player statistic in the specified NHL season</returns>
        public async Task<GoalieStatisticResult> GetGoalieWithTopStatisticBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear)
        {
            return (await GetGoalieStatisticResultsAsync(goalieStatisticEnum, seasonYear, 1)).FirstOrDefault();
        }


        /// <summary>
        /// Returns all distinct types of NHL statistics types
        /// </summary>
        /// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
        public async Task<List<StatisticTypes>> GetStatisticTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<StatisticTypes>>("/statTypes");
        }

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: Toronto Maple Leafs - 10</param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear)
        {
            if (seasonYear?.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var httpRequestUri = string.IsNullOrWhiteSpace(seasonYear) ? $"/teams/{teamId}/stats" : $"/teams/{teamId}/stats?season={seasonYear}";
            return await _nhlStatsApiHttpClient.GetAsync<TeamStatistics>(httpRequestUri);
        }

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(TeamEnum team, string seasonYear)
        {
            if (seasonYear?.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var httpRequestUri = string.IsNullOrWhiteSpace(seasonYear) ? $"/teams/{((int)team)}/stats" : $"/teams/{((int)team)}/stats?season={seasonYear}";
            return await _nhlStatsApiHttpClient.GetAsync<TeamStatistics>(httpRequestUri);
        }

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(int teamId, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            return (await _nhlStatsApiHttpClient.GetAsync<TeamSeasonStatistics>($"/teams/{teamId}?expand=team.stats&season={seasonYear}"))
                .Teams
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/>, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(TeamEnum team, string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            return (await _nhlStatsApiHttpClient.GetAsync<TeamSeasonStatistics>($"/teams/{(int)team}?expand=team.stats&season={seasonYear}"))
                .Teams
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="numberOfPlayers">The argument for the number of players to retrieve, default value is 10 </param>
        /// <returns>Returns the player profile with the top player statistic in the specified NHL season</returns>
        public async Task<List<PlayerStatisticResult>> GetPlayersWithTopStatisticBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, int numberOfPlayers = 10)
        {
            return await GetPlayerStatisticResultsAsync(playerStatisticEnum, seasonYear, numberOfPlayers);
        }

        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="numberOfGoalies">The argument for the number of goalies to retrieve, default value is 10</param>
        /// <returns>Returns the goalie profile with the top player statistic in the specified NHL season</returns>
        public async Task<List<GoalieStatisticResult>> GetGoaliesWithTopStatisticBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, int numberOfGoalies = 10)
        {
            return await GetGoalieStatisticResultsAsync(goalieStatisticEnum, seasonYear, numberOfGoalies);
        }

        private async Task<List<GoalieStatisticResult>> GetGoalieStatisticResultsAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, int count)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var goalieIds = (await _nhlPlayerApi.GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear)).Select(player => player.Person.Id);
            var goalies = await _nhlPlayerApi.GetPlayersByIdAsync(goalieIds);

            var goalieStatisticsTasks = goalies.Where(player => player.IsGoalie).Select(async player =>
            {
                return new
                {
                    Player = player,
                    GoalieStatistics = await GetGoalieStatisticsBySeasonAsync(player.Id, seasonYear)
                };
            });

            var goalieStatistics = await Task.WhenAll(goalieStatisticsTasks);

            var validGoalieStatistics = goalieStatistics.Select(playerStatistic =>
            {
                return new GoalieStatisticResult
                {
                    Player = playerStatistic.Player,
                    GoalieStatisticsData = playerStatistic.GoalieStatistics.Statistics.FirstOrDefault()?.Splits.FirstOrDefault()?.GoalieStatisticsData
                };

            }).Where(playerStatistic => playerStatistic.GoalieStatisticsData != null);

            switch (goalieStatisticEnum)
            {
                case GoalieStatisticEnum.SavePercentage:
                    return validGoalieStatistics
                       .OrderByDescending(ps => ps.GoalieStatisticsData.SavePercentage)
                       .Take(count).ToList();

                case GoalieStatisticEnum.Shutouts:
                    return validGoalieStatistics
                       .OrderByDescending(ps => ps.GoalieStatisticsData.Shutouts)
                       .Take(count).ToList();

                case GoalieStatisticEnum.Ties:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.Ties)
                        .Take(count).ToList();

                case GoalieStatisticEnum.Wins:
                    return validGoalieStatistics
                       .OrderByDescending(ps => ps.GoalieStatisticsData.Wins)
                       .ThenByDescending(ps => ps.GoalieStatisticsData.GamesStarted)
                       .Take(count).ToList();

                case GoalieStatisticEnum.OvertimeWins:
                    return validGoalieStatistics
                       .OrderByDescending(ps => ps.GoalieStatisticsData.Ot)
                       .Take(count).ToList();

                case GoalieStatisticEnum.MostLosses:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.Losses)
                        .Take(count).ToList();

                case GoalieStatisticEnum.LeastLosses:
                    return validGoalieStatistics
                        .OrderBy(ps => ps.GoalieStatisticsData.Losses)
                        .Take(count).ToList();

                case GoalieStatisticEnum.Saves:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.Saves)
                        .Take(count).ToList();

                case GoalieStatisticEnum.PowerPlaySaves:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.PowerPlaySaves)
                        .Take(count).ToList();

                case GoalieStatisticEnum.PowerPlayShots:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.PowerPlayShots)
                        .Take(count).ToList();

                case GoalieStatisticEnum.EvenShots:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.EvenShots)
                        .Take(count).ToList();

                case GoalieStatisticEnum.ShortHandedShots:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.ShortHandedShots)
                        .Take(count).ToList(); ;

                case GoalieStatisticEnum.EvenSaves:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.EvenSaves)
                        .Take(count).ToList();

                case GoalieStatisticEnum.ShortHandedSaves:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.ShortHandedSaves)
                        .Take(count).ToList();

                case GoalieStatisticEnum.HighestGoalAgainstAverage:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.GoalAgainstAverage)
                        .Take(count).ToList();

                case GoalieStatisticEnum.LowestGoalAgainstAverage:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.GoalAgainstAverage)
                       .Take(count).ToList();

                case GoalieStatisticEnum.GoalsAgainst:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.GoalsAgainst)
                        .Take(count).ToList();

                case GoalieStatisticEnum.EvenStrengthSavePercentage:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.EvenStrengthSavePercentage)
                        .Take(count).ToList();

                case GoalieStatisticEnum.ShortHandedSavePercentage:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.ShortHandedSavePercentage)
                       .Take(count).ToList();

                case GoalieStatisticEnum.PowerPlaySavePercentage:
                    return validGoalieStatistics
                        .OrderByDescending(ps => ps.GoalieStatisticsData.PowerPlaySavePercentage)
                        .Take(count).ToList();
                default:
                    return null;
            }
        }

        private async Task<List<PlayerStatisticResult>> GetPlayerStatisticResultsAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, int count)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            var playerIds = (await _nhlPlayerApi.GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear)).Select(player => player.Person.Id);
            var players = await _nhlPlayerApi.GetPlayersByIdAsync(playerIds);

            var playerStatisticsTasks = players.Where(player => !player.IsGoalie).Select(async player =>
            {
                return new
                {
                    Player = player,
                    PlayerStatistics = await GetPlayerStatisticsBySeasonAsync(player.Id, seasonYear)
                };
            });

            var playerStatistics = await Task.WhenAll(playerStatisticsTasks);

            var validPlayerStatistics = playerStatistics.Select(playerStatistic =>
            {
                return new PlayerStatisticResult
                {
                    Player = playerStatistic.Player,
                    PlayerStatisticsData = playerStatistic.PlayerStatistics.Statistics.FirstOrDefault()?.Splits.FirstOrDefault()?.PlayerStatisticsData
                };

            }).Where(playerStatistic => playerStatistic.PlayerStatisticsData != null);

            switch (playerStatisticEnum)
            {
                case PlayerStatisticEnum.Goals:

                    return GetTopPlayersByStatistic
                    (
                        validPlayerStatistics,
                        x => x.PlayerStatisticsData.Goals,
                        x => x.PlayerStatisticsData.Shots,
                        nameof(PlayerStatisticEnum.Goals),
                        typeof(int),
                        count
                    );

                case PlayerStatisticEnum.Assists:
                    return validPlayerStatistics
                      .OrderByDescending(ps => ps.PlayerStatisticsData.Assists)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Points:
                    return validPlayerStatistics
                      .OrderByDescending(ps => ps.PlayerStatisticsData.Points)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Shots:
                    return validPlayerStatistics
                      .OrderByDescending(ps => ps.PlayerStatisticsData.Shots)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.ShotsBlocked:
                    return validPlayerStatistics
                       .OrderByDescending(ps => ps.PlayerStatisticsData.Blocked)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShotPercentage:
                    return validPlayerStatistics
                      .OrderByDescending(ps => ps.PlayerStatisticsData.ShotPct)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Hits:
                    return validPlayerStatistics
                       .OrderByDescending(ps => ps.PlayerStatisticsData.Hits)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.FaceOffPercentage:
                    return validPlayerStatistics
                       .OrderByDescending(ps => ps.PlayerStatisticsData.FaceOffPct)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.PenaltyMinutes:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.Pim)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PlusMinus:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.PlusMinus)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayGoals:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.PowerPlayGoals)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayPoints:
                    return validPlayerStatistics
                       .OrderByDescending(ps => ps.PlayerStatisticsData.PowerPlayPoints)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.OverTimeGoals:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.OverTimeGoals)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.Shifts:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.Shifts)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.ShortHandedGoals:
                    return validPlayerStatistics
                       .OrderByDescending(ps => ps.PlayerStatisticsData.ShortHandedGoals)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShortHandedPoints:
                    return validPlayerStatistics
                        .OrderByDescending(ps => ps.PlayerStatisticsData.ShortHandedPoints)
                        .Take(count)
                        .ToList();

                default:
                    return null;

            }

            List<PlayerStatisticResult> GetTopPlayersByStatistic<T1, T2>
            (
                IEnumerable<PlayerStatisticResult> playerStatisticResults,
                Func<PlayerStatisticResult, T1> orderedStatisticType,
                Func<PlayerStatisticResult, T2> secondOrderedStatisticType,
                string firstStatisticTypePropertyName,
                System.Type firstStatisticPropertyType,
                int numberOfPlayers
            )
            {
                if (numberOfPlayers <= 0)
                {
                    return new List<PlayerStatisticResult>();
                }

                if (numberOfPlayers == 1)
                {
                    var sortedByProperty = validPlayerStatistics
                    .OrderByDescending(orderedStatisticType);

                    var firstPlayer = sortedByProperty.First();
                    var secondPlayer = sortedByProperty.Skip(1).First();

                    var firstPlayerFirstProperty = firstPlayer.PlayerStatisticsData.GetType()
                        .GetProperties()
                        .Single(x => x.Name == firstStatisticTypePropertyName)
                        .GetValue(firstPlayer.PlayerStatisticsData, null);

                    var secondPlayerFirstProperty = secondPlayer.PlayerStatisticsData.GetType()
                        .GetProperties()
                        .Single(x => x.Name == firstStatisticTypePropertyName)
                        .GetValue(secondPlayer.PlayerStatisticsData, null);

                    if (firstPlayerFirstProperty.Equals(secondPlayerFirstProperty))
                    {
                        return new[] { firstPlayer, secondPlayer }.OrderByDescending(secondOrderedStatisticType).Take(numberOfPlayers).ToList();
                    }
                    else
                    {
                        return new List<PlayerStatisticResult> { firstPlayer };
                    }
                }
                else
                {
                    var sortedByProperty = validPlayerStatistics
                  .OrderByDescending(orderedStatisticType)
                  .Take(numberOfPlayers)
                  .ToList();
                }

                return new List<PlayerStatisticResult>();
            }
        }
    }
}
