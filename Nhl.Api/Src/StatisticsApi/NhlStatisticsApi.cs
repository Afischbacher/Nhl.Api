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
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the collection of player profiles with the selected player statistic in the specified NHL season</returns>
        public async Task<List<PlayerStatisticResult>> GetPlayersByStatisticTypeBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, bool isDescending = true, int numberOfPlayers = 10)
        {
            return await GetPlayerStatisticResultsAsync(playerStatisticEnum, seasonYear, isDescending, numberOfPlayers);
        }

        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="numberOfGoalies">The argument for the number of goalies to retrieve, default value is 10 </param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns a collection goalie profiles with the selected statistic in the specified NHL season</returns>
        public async Task<List<GoalieStatisticResult>> GetGoaliesByStatisticTypeBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, bool isDescending = true, int numberOfGoalies = 10)
        {
            return await GetGoalieStatisticResultsAsync(goalieStatisticEnum, seasonYear, isDescending, numberOfGoalies);
        }

        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the player profile with the selected statistic in the specified NHL season</returns>
        public async Task<PlayerStatisticResult> GetPlayerByStatisticTypeBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, bool isDescending = true)
        {
            return (await GetPlayerStatisticResultsAsync(playerStatisticEnum, seasonYear, isDescending, count: 1)).FirstOrDefault();
        }


        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the goalie profile with the selected statistic in the specified NHL season</returns>
        public async Task<GoalieStatisticResult> GetGoalieByStatisticTypeBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, bool isDescending = true)
        {
            return (await GetGoalieStatisticResultsAsync(goalieStatisticEnum, seasonYear, isDescending, count: 1)).FirstOrDefault();
        }


        private async Task<List<GoalieStatisticResult>> GetGoalieStatisticResultsAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, bool isDescending, int count)
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
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.SavePercentage, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Shutouts:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Shutouts, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Ties:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Ties, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.Wins:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Wins, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.OvertimeWins:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Ot, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Losses:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Losses, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.Saves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Saves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.PowerPlaySaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlaySaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.PowerPlayShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlayShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenSaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenSaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedSaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedSaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.GoalAgainstAverage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.GoalAgainstAverage, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.GoalsAgainst:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.GoalsAgainst, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenStrengthSavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenStrengthSavePercentage, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedSavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedSavePercentage, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.PowerPlaySavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlaySavePercentage, isDescending)
                        .Take(count)
                        .ToList();
                default:
                    return null;
            }
        }

        private async Task<List<PlayerStatisticResult>> GetPlayerStatisticResultsAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, bool isDescending, int count)
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
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Assists, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Points:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Points, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Shots:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Shots, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.ShotsBlocked:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Blocked, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShotPercentage:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShotPct, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Hits:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Hits, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.FaceOffPercentage:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.FaceOffPct, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.PenaltyMinutes:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Pim, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PlusMinus:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PlusMinus, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PowerPlayGoals, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayPoints:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PowerPlayPoints, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.OverTimeGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.OverTimeGoals, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.Shifts:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Shifts, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.ShortHandedGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShortHandedGoals, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShortHandedPoints:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShortHandedPoints, isDescending)
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
                    var sortedByProperty = isDescending
                        ? playerStatisticResults.OrderByDescending(orderedStatisticType)
                        : playerStatisticResults.OrderBy(orderedStatisticType);

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
                        return isDescending
                          ?
                             new[] { firstPlayer, secondPlayer }
                             .OrderByDescending(secondOrderedStatisticType)
                             .Take(numberOfPlayers)
                             .ToList()

                         : new[] { firstPlayer, secondPlayer }
                             .OrderBy(secondOrderedStatisticType)
                             .Take(numberOfPlayers)
                             .ToList();
                    }
                    else
                    {
                        return new List<PlayerStatisticResult> { firstPlayer };
                    }
                }
                else
                {
                    return isDescending
                         ? validPlayerStatistics.OrderByDescending(orderedStatisticType).Take(numberOfPlayers).ToList()
                         : validPlayerStatistics.OrderBy(orderedStatisticType).Take(numberOfPlayers).ToList();
                }
            }
        }

        private IOrderedEnumerable<T> GetOrderEnumerableByKeySelector<T>(IEnumerable<T> collection, Func<T, object> keySelector, bool isDescending, bool isThenBy = false)
        {
            return isDescending
               ? collection.OrderByDescending(keySelector)
               : collection.OrderBy(keySelector);
        }
    }
}
