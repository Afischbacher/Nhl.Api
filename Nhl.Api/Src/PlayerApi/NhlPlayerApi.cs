using Nhl.Api.Common.Http;
using Nhl.Api.Common.Services;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more
    /// </summary>
    public class NhlPlayerApi : INhlPlayerApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlApiHttpClient _nhlApiWebHttpClient = new NhlApiWebHttpClient();
        private static readonly INhlApiHttpClient _nhlSuggestionApiHttpClient = new NhlSuggestionApiHttpClient();
        private static readonly INhlApiHttpClient _nhlCmsHttpClient = new NhlCmsHttpClient();
        private static readonly ICachingService _cachingService = new CachingService();

        /// <summary>
        /// The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more
        /// </summary>
        public NhlPlayerApi()
        {

        }

        /// <summary>
        /// Returns any active or inactive NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
        /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query, int limit = 25)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<PlayerSearchResult>();
            }

            return await _nhlSuggestionApiHttpClient.GetAsync<List<PlayerSearchResult>>($"/search/player?culture=en-us&q={query}&limit={limit}");
        }

        /// <summary>
        /// Returns only active NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
        /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query, int limit = 25)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<PlayerSearchResult>();
            }

            return await _nhlSuggestionApiHttpClient.GetAsync<List<PlayerSearchResult>>($"/search/player?culture=en-us&q={query}&active=true&limit={limit}");
        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
        public async Task<byte[]> GetPlayerHeadshotImageAsync(PlayerEnum player, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            return playerHeadshotImageSize switch
            {
                PlayerHeadshotImageSize.Small => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}.png"),
                PlayerHeadshotImageSize.Medium => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}@2x.png"),
                PlayerHeadshotImageSize.Large => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}@3x.png"),
                _ => null,
            };
        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
        public async Task<byte[]> GetPlayerHeadshotImageAsync(int playerId, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            return playerHeadshotImageSize switch
            {
                PlayerHeadshotImageSize.Small => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}.png"),
                PlayerHeadshotImageSize.Medium => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}@2x.png"),
                PlayerHeadshotImageSize.Large => await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}@3x.png"),
                _ => null,
            };
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter is required", nameof(seasonYear));
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter must be in the format of yyyyyyyy, example: 20232024", nameof(seasonYear));
            }

            return await _nhlApiWebHttpClient.GetAsync<PlayerSeasonGameLog>($"/player/{(int)player}/game-log/{seasonYear}/{(int)gameType}");
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter is required", nameof(seasonYear));
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter must be in the format of yyyyyyyy, example: 20232024", nameof(seasonYear));
            }

            return await _nhlApiWebHttpClient.GetAsync<PlayerSeasonGameLog>($"/player/{playerId}/game-log/{seasonYear}/{(int)gameType}");
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter is required", nameof(seasonYear));
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter must be in the format of yyyyyyyy, example: 20232024", nameof(seasonYear));
            }

            return await _nhlApiWebHttpClient.GetAsync<GoalieSeasonGameLog>($"/player/{(int)player}/game-log/{seasonYear}/{(int)gameType}");
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter is required", nameof(seasonYear));
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException($"The {nameof(seasonYear)} parameter must be in the format of yyyyyyyy, example: 20232024", nameof(seasonYear));
            }

            return await _nhlApiWebHttpClient.GetAsync<GoalieSeasonGameLog>($"/player/{playerId}/game-log/{seasonYear}/{(int)gameType}");
        }

        /// <summary>
        /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8480313 - Logan Thompson</param>
        /// <returns>Returns the NHL player's profile information </returns>
        public async Task<GoalieProfile> GetGoalieInformationAsync(int playerId)
        {
            return await _nhlApiWebHttpClient.GetAsync<GoalieProfile>($"/player/{playerId}/landing");
        }

        /// <summary>
        /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8480313 - Logan Thompson, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>Returns the NHL player's profile information</returns>
        public async Task<GoalieProfile> GetGoalieInformationAsync(PlayerEnum player)
        {
            return await _nhlApiWebHttpClient.GetAsync<GoalieProfile>($"/player/{(int)player}/landing");
        }

        /// <summary>
        /// Disposes and releases all unneeded resources for the NHL player api
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose() => _cachingService?.Dispose();

    }
}
