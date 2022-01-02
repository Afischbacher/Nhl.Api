using Nhl.Api.Common.Http;
using Nhl.Api.Common.Services;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Prospect;
using Nhl.Api.Models.League;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more
    /// </summary>
    public class NhlPlayerApi : INhlPlayerApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
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
        /// Returns every single NHL player to ever play
        /// </summary>
        /// <returns>Returns every single NHL player since the league inception</returns>
        public async Task<List<Player>> GetAllPlayersAsync()
        {
            // Retrieve all player identifiers known
            var playerIds = Enum.GetValues(typeof(PlayerEnum)).Cast<int>();


            // If values are cached, returned cached value
            var containsKey = await _cachingService.ContainsKeyAsync(nameof(GetAllPlayersAsync));
            if (containsKey)
            {
                return await _cachingService.TryGetAsync<List<Player>>(nameof(GetAllPlayersAsync));
            }

            // If cache is not set, return from NHL API
            var playerTasks = new List<Task<Player>>();
            var semaphore = new SemaphoreSlim(initialCount: 32);

            // Create Tasks with a parallelization limit of 32 when retrieving all players
            foreach (var playerId in playerIds)
            {
                await semaphore.WaitAsync();

                playerTasks.Add(
                    Task.Run(async () =>
                    {
                        try
                        {
                            return await GetPlayerByIdAsync(playerId);
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
            }

            // Cache values for future requests
            var players = (await Task.WhenAll(playerTasks)).ToList();
            await _cachingService.TryAddUpdateAsync(nameof(GetAllPlayersAsync), players);

            // Return all known NHL players
            return players;

        }

        /// <summary>
        /// Returns all the NHL league prospects <br/>
        /// <strong>Note:</strong> The NHL prospects response provides a very large JSON payload
        /// </summary>
        /// <returns>A collection of all the NHL prospects, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<List<ProspectProfile>> GetLeagueProspectsAsync()
        {
            var containsKey = await _cachingService.ContainsKeyAsync(nameof(GetLeagueProspectsAsync));
            if (containsKey)
            {
                return await _cachingService.TryGetAsync<List<ProspectProfile>>(nameof(GetLeagueProspectsAsync));
            }

            var prospectProfiles = (await _nhlStatsApiHttpClient.GetAsync<LeagueProspects>("/draft/prospects")).ProspectProfiles;
            await _cachingService.TryAddUpdateAsync(nameof(GetLeagueProspectsAsync), prospectProfiles);

            return prospectProfiles;
        }

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospectId">The NHL prospect id, Example: 86515 - Francesco Pinelli</param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<ProspectProfile> GetLeagueProspectByIdAsync(int prospectId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueProspects>($"/draft/prospects/{prospectId}"))
                .ProspectProfiles
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospect">The NHL prospect id, Example: 86515 - Francesco Pinelli, see <see cref="ProspectEnum"/> for more information</param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<ProspectProfile> GetLeagueProspectByIdAsync(ProspectEnum prospect)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueProspects>($"/draft/prospects/{(int)prospect}"))
                .ProspectProfiles
                .SingleOrDefault();
        }


        /// <summary>
        /// Returns all of the active NHL players
        /// </summary>
        /// <returns>A collection of all NHL players</returns>
        public async Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueRosters>("/teams?expand=team.roster"))
                .Teams
                .SelectMany(team => team.Roster.Roster)
                .ToList();
        }

        /// <summary>
        /// Returns all of the active NHL roster members by a season year 
        /// </summary>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all NHL players based on the season year provided</returns>
        public async Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersBySeasonYearAsync(string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            return (await _nhlStatsApiHttpClient.GetAsync<LeagueRosters>($"/teams?expand=team.roster&season={seasonYear}"))
                .Teams
                .SelectMany(team => team.Roster.Roster)
                .ToList();
        }

        /// <summary>
        /// Returns all of the active rostered NHL players based on the search query provided
        /// </summary>
        /// <param name="query">An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" </param>
        /// <returns>A collection of all rostered and active NHL players based on the search query provided</returns>
        public async Task<List<TeamRosterMember>> SearchLeagueTeamRosterMembersAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<TeamRosterMember>();
            }

            return (await _nhlStatsApiHttpClient.GetAsync<LeagueRosters>($"/teams?expand=team.roster"))
                .Teams
                .SelectMany(team => team.Roster.Roster)
                .Where(rosterMember => rosterMember.Person.FullName.ToLowerInvariant().Contains(query.ToLowerInvariant()))
                .ToList();
        }

        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 is Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<Player> GetPlayerByIdAsync(int playerId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeaguePlayers>($"/people/{playerId}"))
                .Players
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<Player> GetPlayerByIdAsync(PlayerEnum player)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeaguePlayers>($"/people/{((int)player)}"))
                .Players
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerIds">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<List<Player>> GetPlayersByIdAsync(IEnumerable<int> playerIds)
        {
            var playerTasks = playerIds.Select(playerId => GetPlayerByIdAsync(playerId)).ToArray();
            return (await Task.WhenAll(playerTasks)).ToList();

        }

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="players">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<List<Player>> GetPlayersByIdAsync(IEnumerable<PlayerEnum> players)
        {
            var playerTasks = players.Select(player => GetPlayerByIdAsync(player)).ToArray();
            return (await Task.WhenAll(playerTasks)).ToList();
        }

        /// <summary>
        /// Returns any active or inactive NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<PlayerSearchResult>();
            }

            var playerSearchResults = new List<PlayerSearchResult>();
            var rawPlayerSearchResults = await _nhlSuggestionApiHttpClient.GetAsync<PlayerSearchResponse>($"/minplayers/{query}");
            foreach (var rawPlayerSearchResult in rawPlayerSearchResults.Suggestions)
            {
                try
                {
                    var playerDataPoints = rawPlayerSearchResult.Split('|');

                    if (playerDataPoints.Count() < 15)
                    {
                        continue;
                    }

                    playerSearchResults.Add(new PlayerSearchResult
                    {
                        PlayerId = int.Parse(playerDataPoints[0]),
                        LastName = playerDataPoints[1],
                        FirstName = playerDataPoints[2],
                        IsActive = int.Parse(playerDataPoints[3]) == 1,
                        Height = playerDataPoints[5],
                        Weight = playerDataPoints[6],
                        BirthCity = playerDataPoints[7],
                        BirthProvinceState = playerDataPoints[8],
                        BirthCountry = playerDataPoints[9],
                        BirthDate = DateTime.Parse(playerDataPoints[10]),
                        LastTeamOfPlay = playerDataPoints[11],
                        Position = playerDataPoints[12],
                        PlayerNumber = int.Parse(playerDataPoints[13]),
                    });
                }
                catch
                {
                }
            }

            return playerSearchResults;
        }

        /// <summary>
        /// Returns only active NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<PlayerSearchResult>();
            }

            var playerSearchResults = new List<PlayerSearchResult>();
            var rawPlayerSearchResults = await _nhlSuggestionApiHttpClient.GetAsync<PlayerSearchResponse>($"/minactiveplayers/{query}");
            foreach (var rawPlayerSearchResult in rawPlayerSearchResults.Suggestions)
            {
                try
                {
                    var playerDataPoints = rawPlayerSearchResult.Split('|');

                    if (playerDataPoints.Count() < 15)
                    {
                        continue;
                    }

                    playerSearchResults.Add(new PlayerSearchResult
                    {
                        PlayerId = int.Parse(playerDataPoints[0]),
                        LastName = playerDataPoints[1],
                        FirstName = playerDataPoints[2],
                        IsActive = int.Parse(playerDataPoints[3]) == 1,
                        Height = playerDataPoints[5],
                        Weight = playerDataPoints[6],
                        BirthCity = playerDataPoints[7],
                        BirthProvinceState = playerDataPoints[8],
                        BirthCountry = playerDataPoints[9],
                        BirthDate = DateTime.Parse(playerDataPoints[10]),
                        LastTeamOfPlay = playerDataPoints[11],
                        Position = playerDataPoints[12],
                        PlayerNumber = int.Parse(playerDataPoints[13]),
                    });
                }
                catch
                {
                }
            }

            return playerSearchResults;
        }

        /// <summary>
        /// Disposes and releases all unneeded resources for the NHL player api
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose()
        {
            _cachingService?.Dispose();
        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
        public async Task<byte[]> DownloadPlayerHeadshotImageAsync(PlayerEnum player, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            switch (playerHeadshotImageSize)
            {
                case PlayerHeadshotImageSize.Small:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}.png");
                case PlayerHeadshotImageSize.Medium:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}@2x.png");
                case PlayerHeadshotImageSize.Large:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{(int)player}@3x.png");
            }

            return null;

        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
        public async Task<byte[]> DownloadPlayerHeadshotImageAsync(int playerId, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            switch (playerHeadshotImageSize)
            {
                case PlayerHeadshotImageSize.Small:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}.png");
                case PlayerHeadshotImageSize.Medium:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}@2x.png");
                case PlayerHeadshotImageSize.Large:
                    return await _nhlCmsHttpClient.GetByteArrayAsync($"images/headshots/current/168x168/{playerId}@3x.png");
            }

            return null;

        }
    }
}
