﻿using System;
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
    /// NHL Statistics API
    /// </summary>
    public class NhlStatisticsApi : INhlStatisticsApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlPlayerApi _nhlPlayerApi = new NhlPlayerApi();

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
    }
}