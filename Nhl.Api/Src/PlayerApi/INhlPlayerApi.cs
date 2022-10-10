using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Prospect;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more
    /// </summary>
    public interface INhlPlayerApi : IDisposable
    {
        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        Task<Player> GetPlayerByIdAsync(int playerId);

        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        Task<Player> GetPlayerByIdAsync(PlayerEnum player);

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerIds">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        Task<List<Player>> GetPlayersByIdAsync(IEnumerable<int> playerIds);

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="players">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        Task<List<Player>> GetPlayersByIdAsync(IEnumerable<PlayerEnum> players);

        /// <summary>
        /// Returns all of the active NHL roster members 
        /// </summary>
        /// <returns>A collection of all NHL players</returns>
        Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersAsync();

        /// <summary>
        /// Returns all of the active NHL roster members by a season year 
        /// </summary>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all NHL players based on the season year provided</returns>
        Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersBySeasonYearAsync(string seasonYear);

        /// <summary>
        /// Returns all of the active rostered NHL players based on the search query provided+
        /// </summary>
        /// <param name="query">An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" </param>
        /// <returns>A collection of all rostered and active NHL players based on the search query provided</returns>
        Task<List<TeamRosterMember>> SearchLeagueTeamRosterMembersAsync(string query);

        /// <summary>
        /// Returns any active or inactive NHL players based on the search query provided
        /// </summary>
        /// <param name="query">An search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query);

        /// <summary>
        /// Returns only active NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query);

        /// <summary>
        /// Returns NHL player since the league inception in 1917-1918
        /// </summary>
        /// <returns>Returns all NHL players since the league inception</returns>
        Task<List<Player>> GetAllPlayersAsync();

        /// <summary>
        /// Returns all the NHL league prospects <br/>
        /// <strong>Note:</strong> The NHL prospects response provides a very large JSON payload
        /// </summary>
        /// <returns>A collection of all the NHL prospects, see <see cref="ProspectProfile"/> for more information </returns>
        Task<List<ProspectProfile>> GetLeagueProspectsAsync();

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospectId">The NHL prospect id, Example: 86515 - Francesco Pinelli</param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        Task<ProspectProfile> GetLeagueProspectByIdAsync(int prospectId);

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospect">The NHL prospect id, Example: 86515 - Francesco Pinelli, see <see cref="ProspectEnum"/> for more information </param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        Task<ProspectProfile> GetLeagueProspectByIdAsync(ProspectEnum prospect);

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A byte array content of an NHL player head shot image</returns>
        Task<byte[]> GetPlayerHeadshotImageAsync(PlayerEnum player, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small);

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A byte array content of an NHL player head shot image</returns>
        Task<byte[]> GetPlayerHeadshotImageAsync(int playerId, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small);
    }
}
