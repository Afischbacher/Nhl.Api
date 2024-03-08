namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more
/// </summary>
public interface INhlPlayerApi : IDisposable
{

    /// <summary>
    /// Returns any active or inactive NHL players based on the search query provided
    /// </summary>
    /// <param name="query">An search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
    /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all NHL players based on the search query provided</returns>
    public Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query, int limit = 25, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns only active NHL players based on the search query provided
    /// </summary>
    /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
    /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all NHL players based on the search query provided</returns>
    public Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query, int limit = 25, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL player's head shot image by season year
    /// </summary>
    /// <param name="player">An NHL player, Example: 8478402 - Connor McDavid</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
    public Task<byte[]> GetPlayerHeadshotImageAsync(PlayerEnum player, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL player's head shot image by season year
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
    public Task<byte[]> GetPlayerHeadshotImageAsync(int playerId, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the </param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the </param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Joseph Woll, see <see cref="PlayerEnum"/> for more information on NHL goalies </param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8479361 - Joseph Woll</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8480313 - Logan Thompson</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more </returns>
    public Task<GoalieProfile> GetGoalieInformationAsync(int playerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8480313 - Logan Thompson, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more</returns>
    public Task<GoalieProfile> GetGoalieInformationAsync(PlayerEnum player, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information </returns>
    public Task<PlayerProfile> GetPlayerInformationAsync(int playerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information</returns>
    public Task<PlayerProfile> GetPlayerInformationAsync(PlayerEnum player, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL player's in the spotlight based on their recent performances 
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of players and their information for players in the NHL spotlight</returns>
    public Task<List<PlayerSpotlight>> GetPlayerSpotlightAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL players to ever play in the NHL
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL players to ever play in the NHL</returns>
    public Task<List<PlayerDataSearchResult>> GetAllPlayersAsync(CancellationToken cancellationToken = default);

}
