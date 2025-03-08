using Nhl.Api.Models.Draft;

namespace Nhl.Api;

/// <summary>
/// The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more
/// </summary>
public class NhlApi : INhlApi
{
    private static readonly NhlLeagueApi _nhlLeagueApi = new();
    private static readonly NhlGameApi _nhlGameApi = new();
    private static readonly NhlPlayerApi _nhlPlayerApi = new();
    private static readonly NhlStatisticsApi _nhlStatisticsApi = new();

    /// <summary>
    /// The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more
    /// </summary>
    public NhlApi()
    {

    }

    /// <summary>
    /// Returns an the NHL team logo based a dark or light preference using the NHL team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
    public async Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamLogoAsync(teamId, teamLogoType, cancellationToken);

    /// <summary>
    /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
    public async Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light, CancellationToken cancellationToken = default) =>

           await _nhlLeagueApi.GetTeamLogoAsync(team, teamLogoType, cancellationToken);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public async Task<TeamColors> GetTeamColorsAsync(TeamEnum team, CancellationToken cancellationToken = default) =>

           await _nhlLeagueApi.GetTeamColorsAsync(team, cancellationToken);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public async Task<TeamColors> GetTeamColorsAsync(int teamId, CancellationToken cancellationToken = default) =>

           await _nhlLeagueApi.GetTeamColorsAsync(teamId, cancellationToken);


    /// <summary>
    /// Returns the NHL player's head shot image by season year
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A URI endpoint with the image of an NHL player head shot image</returns>
    public async Task<byte[]> GetPlayerHeadshotImageAsync(PlayerEnum player, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerHeadshotImageAsync(player, seasonYear, cancellationToken);

    /// <summary>
    /// Returns the NHL player's head shot image by the selected size
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array content of an NHL player head shot image</returns>
    public async Task<byte[]> GetPlayerHeadshotImageAsync(int playerId, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerHeadshotImageAsync(playerId, seasonYear, cancellationToken);

    /// <summary>
    /// Returns any active or inactive NHL players based on the search query provided
    /// </summary>
    /// <param name="query">A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
    /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all NHL players based on the search query provided</returns>
    public async Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query, int limit = 25, CancellationToken cancellationToken = default) =>

           await _nhlPlayerApi.SearchAllPlayersAsync(query, limit, cancellationToken);

    /// <summary>
    /// Returns only active NHL players based on the search query provided
    /// </summary>
    /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
    /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all NHL players based on the search query provided</returns>
    public async Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query, int limit = 25, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.SearchAllActivePlayersAsync(query, limit, cancellationToken);

    /// <summary>
    /// Returns all of the individual shifts of each NHL player for a specific NHL game id
    /// </summary>
    /// <param name="gameId">The game id, Example: 2021020087</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
    public async Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetLiveGameFeedPlayerShiftsAsync(gameId, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for a specific date using the <see cref="DateOnly"/>
    /// </summary>
    /// <param name="date">A <see cref="DateOnly"/> for the specific date for the NHL schedule</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A result of the current NHL schedule by the specified date</returns>
    public async Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueGameWeekScheduleByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns the true or false if the NHL playoff pre season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
    public async Task<bool> IsPreSeasonActiveAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.IsPreSeasonActiveAsync(cancellationToken);

    /// <summary>
    /// Returns the true or false if the NHL regular season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
    public async Task<bool> IsRegularSeasonActiveAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.IsRegularSeasonActiveAsync(cancellationToken);

    /// <summary>
    /// Returns the true or false if the NHL playoff season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
    public async Task<bool> IsPlayoffSeasonActiveAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.IsPlayoffSeasonActiveAsync(cancellationToken);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington Capitals</param>
    /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public async Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamScheduleBySeasonAsync(teamAbbreviation, seasonYear, cancellationToken);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington Capitals</param>
    /// <param name="date">The date in which the request schedule for the team and for the week is request for</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public async Task<TeamWeekSchedule> GetTeamWeekScheduleByDateAsync(string teamAbbreviation, DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamWeekScheduleByDateAsync(teamAbbreviation, date, cancellationToken);

    /// <summary>
    /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics </returns>
    public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics </returns>
    public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Joseph Woll, see <see cref="PlayerEnum"/> for more information on NHL goalies </param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8479361 - Joseph Woll</param>
    /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
    /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
    public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8480313 - Logan Thompson</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information </returns>
    public async Task<GoalieProfile> GetGoalieInformationAsync(int playerId, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetGoalieInformationAsync(playerId, cancellationToken);

    /// <summary>
    /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8480313 - Logan Thompson, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information</returns>
    public async Task<GoalieProfile> GetGoalieInformationAsync(PlayerEnum player, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetGoalieInformationAsync((int)player, cancellationToken);

    /// <summary>
    /// Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information </returns>
    public async Task<PlayerProfile> GetPlayerInformationAsync(int playerId, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerInformationAsync(playerId, cancellationToken);

    /// <summary>
    /// Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more
    /// </summary>
    /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL player's profile information</returns>
    public async Task<PlayerProfile> GetPlayerInformationAsync(PlayerEnum player, CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerInformationAsync((int)player, cancellationToken);

    /// <summary>
    /// Returns the current NHL player statistics leaders in the NHL for a specific player statistic type
    /// </summary>
    /// <param name="playerStatisticsType">A player statistics type, <see cref="PlayerStatisticsType"/> for all the types of statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public async Task<PlayerStatisticLeaders> GetSkaterStatisticsLeadersAsync(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit = 25, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetSkaterStatisticsLeadersAsync(playerStatisticsType, gameType, seasonYear, limit, cancellationToken);

    /// <summary>
    /// Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year 
    /// </summary>
    /// <param name="goalieStatisticsType">A player statistics type, <see cref="GoalieStatisticsType"/> for all the types of statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public async Task<GoalieStatisticLeaders> GetGoalieStatisticsLeadersAsync(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit = 25, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetGoalieStatisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit, cancellationToken);

    /// <summary>
    /// Returns the NHL player's in the spotlight based on their recent performances 
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of players and their information for players in the NHL spotlight</returns>
    public async Task<List<PlayerSpotlight>> GetPlayerSpotlightAsync(CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetPlayerSpotlightAsync(cancellationToken);

    /// <summary>
    /// Returns the NHL league standings for the current NHL season by the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL season standing</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Return the NHL league standings for the specified date with specific team information</returns>
    public async Task<LeagueStanding> GetLeagueStandingsByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueStandingsByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns the NHL league standings for the all NHL seasons with specific league season information
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league standings information for each season since 1917-1918 </returns>
    public async Task<LeagueStandingsSeasonInformation> GetLeagueStandingsSeasonInformationAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueStandingsSeasonInformationAsync(cancellationToken);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public async Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(TeamEnum team, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTeamStatisticsBySeasonAndGameTypeAsync(team, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public async Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(int teamId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTeamStatisticsBySeasonAndGameTypeAsync(teamId, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public async Task<List<TeamStatisticsSeason>> GetTeamStatisticsBySeasonAsync(TeamEnum team, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTeamStatisticsBySeasonAsync(team, cancellationToken);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public async Task<List<TeamStatisticsSeason>> GetTeamStatisticsBySeasonAsync(int teamId, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTeamStatisticsBySeasonAsync(teamId, cancellationToken);

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(int teamId, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetCurrentTeamScoreboardAsync(teamId, cancellationToken);

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(TeamEnum team, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetCurrentTeamScoreboardAsync(team, cancellationToken);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team identifier and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamRosterBySeasonYearAsync(teamId, seasonYear, cancellationToken);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team identifier and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 8 - Montreal Canadiens </param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamRosterBySeasonYearAsync(team, seasonYear, cancellationToken);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(int teamId, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetAllRosterSeasonsByTeamAsync(teamId, cancellationToken);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetAllRosterSeasonsByTeamAsync(team, cancellationToken);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public async Task<TeamProspects> GetTeamProspectsByTeamAsync(int teamId, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamProspectsByTeamAsync(teamId, cancellationToken);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 10 - Toronto Maple Leafs </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public async Task<TeamProspects> GetTeamProspectsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTeamProspectsByTeamAsync(team, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamSeasonScheduleBySeasonYearAsync(teamId, seasonYear, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamSeasonScheduleBySeasonYearAsync(team, seasonYear, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(int teamId, int month, int year, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamSeasonScheduleByYearAndMonthAsync(teamId, month, year, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(TeamEnum team, int month, int year, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamSeasonScheduleByYearAndMonthAsync(team, month, year, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="date">The date and time, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(int teamId, DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamWeekScheduleByDateAsync(teamId, date, cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="date">The date and time, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(TeamEnum team, DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetTeamWeekScheduleByDateAsync(team, date, cancellationToken);

    /// <summary>
    /// Returns the NHL league schedule for the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league schedule for the specified date</returns>
    public async Task<LeagueSchedule> GetLeagueWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueWeekScheduleByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns the NHL league calendar schedule for the specified date and all applicable teams
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league calendar schedule for the specified date and all applicable teams</returns>
    public async Task<LeagueScheduleCalendar> GetLeagueScheduleCalendarByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueScheduleCalendarByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more
    /// </summary>
    /// <param name="date">The date and time, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more</returns>
    public async Task<GameScore> GetGameScoresByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameScoresByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns the collection of countries and where you can watch NHL games with links and more
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the collection of countries and where you can watch NHL games with links and more</returns>
    public async Task<List<GameWatchSource>> GetSourcesToWatchGamesAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetSourcesToWatchGamesAsync(cancellationToken);

    /// <summary>
    /// Returns the live NHL game scoreboard, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the live NHL game scoreboard, including the game information, game status, game venue and more</returns>
    public async Task<GameScoreboard> GetGameScoreboardAsync(CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameScoreboardAsync(cancellationToken);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <param name="includeEventDateTime"> A flag to include the event date and time for the NHL game center play by play feed</param>
    /// <returns>Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterPlayByPlay> GetGameCenterPlayByPlayByGameIdAsync(int gameId, bool includeEventDateTime = false, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameCenterPlayByPlayByGameIdAsync(gameId, includeEventDateTime, cancellationToken);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterLanding> GetGameCenterLandingByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameCenterLandingByGameIdAsync(gameId, cancellationToken);

    /// <summary>
    /// Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterBoxScore> GetGameCenterBoxScoreByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameCenterBoxScoreByGameIdAsync(gameId, cancellationToken);

    /// <summary>
    /// Returns the NHL TV broadcasts for the specified date with information about the broadcasts
    /// </summary>
    /// <param name="date">The date requested for the NHL TV broadcasts, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL TV broadcasts for the specified date with information about the broadcasts</returns>
    public async Task<TvScheduleBroadcast> GetTvScheduleBroadcastByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetTvScheduleBroadcastByDateAsync(date, cancellationToken);

    /// <summary>
    /// Returns all the NHL seasons for the NHL league
    /// </summary>
    /// <returns>Returns all the NHL seasons for the NHL league</returns>
    public async Task<List<int>> GetAllSeasonsAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetAllSeasonsAsync(cancellationToken);

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="playerIds">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teamIds">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public async Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<int> playerIds, List<string> teamIds, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueMetadataInformationAsync(playerIds, teamIds, cancellationToken);

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="players">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teams">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public async Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<PlayerEnum> players, List<TeamEnum> teams, CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.GetLeagueMetadataInformationAsync(players, teams, cancellationToken);

    /// <summary>
    /// Returns the NHL game meta data for the specified game id, including the teams, season states and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game meta data for the specified game id, including the teams, season states and more</returns>
    public async Task<GameMetadata> GetGameMetadataByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
           await _nhlGameApi.GetGameMetadataByGameIdAsync(gameId, cancellationToken);

    /// <summary>
    /// Determines if the NHL league is active or inactive based on the current date and time
    /// </summary>
    /// <returns>Returns true or false based on the current time and date</returns>
    public async Task<bool> IsLeagueActiveAsync(CancellationToken cancellationToken = default) =>
           await _nhlLeagueApi.IsLeagueActiveAsync(cancellationToken);

    /// <summary>
    /// Returns the number of total number of a player statistics for a player for a specific season
    /// </summary>
    /// <param name="playerEnum">The player enumeration identifier, specifying which the NHL player, <see cref="PlayerEnum"/> for more information </param>
    /// <param name="playerGameCenterStatistic">The NHL player game center statistic type, <see cref="PlayerGameCenterStatistic"/> for more information on valid game center statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the number of total number of a player statistics for a player for a specific season</returns>
    public async Task<int> GetTotalPlayerStatisticValueByTypeAndSeasonAsync(PlayerEnum playerEnum, PlayerGameCenterStatistic playerGameCenterStatistic, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTotalPlayerStatisticValueByTypeAndSeasonAsync(playerEnum, playerGameCenterStatistic, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns the number of total number of a player statistics for a player for a specific season 
    /// </summary>
    /// <param name="playerId">The NHL player identifier, Example: 8478402 - Connor McDavid</param>
    /// <param name="playerGameCenterStatistic">The NHL player game center statistic type, <see cref="PlayerGameCenterStatistic"/> for more information on valid game center statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the number of total number of a player statistics for a player for a specific season</returns>
    public async Task<int> GetTotalPlayerStatisticValueByTypeAndSeasonAsync(int playerId, PlayerGameCenterStatistic playerGameCenterStatistic, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetTotalPlayerStatisticValueByTypeAndSeasonAsync(playerId, playerGameCenterStatistic, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL players to ever play in the NHL
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL players to ever play in the NHL</returns>
    public async Task<List<PlayerDataSearchResult>> GetAllPlayersAsync(CancellationToken cancellationToken = default) =>
           await _nhlPlayerApi.GetAllPlayersAsync(cancellationToken);

    /// <summary>
    /// Returns the all the NHL player game center statistics for a specific player for a specific season and game type
    /// </summary>
    /// <param name="playerId">The NHL player identifier, specifying which the NHL player, Example: 8478402 - Connor McDavid </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the all the NHL player game center statistics for a specific player for a specific season and game type</returns>
    public async Task<(PlayerProfile PlayerProfile, Dictionary<PlayerGameCenterStatistic, int> StatisticsTotals)> GetAllTotalPlayerStatisticValuesBySeasonAsync(int playerId, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerId, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns the all the NHL player game center statistics for a specific player for a specific season and game type
    /// </summary>
    /// <param name="playerEnum">The player enumeration identifier, specifying which the NHL player, <see cref="PlayerEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the all the NHL player game center statistics for a specific player for a specific season and game type</returns>
    public async Task<(PlayerProfile PlayerProfile, Dictionary<PlayerGameCenterStatistic, int> StatisticsTotals)> GetAllTotalPlayerStatisticValuesBySeasonAsync(PlayerEnum playerEnum, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerEnum, seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns the all the NHL players game center statistics for the entire NHL league for a specific season and game type
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the all the NHL players game center statistics for the entire NHL league for a specific season and game type</returns>
    public async Task<Dictionary<PlayerProfile, Dictionary<PlayerGameCenterStatistic, int>>> GetAllPlayersStatisticValuesBySeasonAsync(string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetAllPlayersStatisticValuesBySeasonAsync(seasonYear, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL real-time player game center statistics for players matching the provided filter expression for a specific season, including face-off percentage, points per game, overtime goals, shorthanded points, power-play points, shooting percentage, shots, time on ice per game, and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionPlayerFilter">The expression player filter to filter the player statistics by, see <see cref="PlayerFilterExpressionBuilder"/> for more information on valid player filters</param>
    /// <param name="playerRealtimeStatisticsFilterToSortBy">The player real-time statistics filter to sort the player statistics by, see <see cref="PlayerRealtimeStatisticsFilter"/> for more information on valid player statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL player statistics</param>
    /// <param name="gameType"> The game type for the NHL season for the player statistics </param> 
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns all the NHL real-time player game center statistics for players matching the filter expression for the specified season.</returns>
    public async Task<PlayerRealtimeStatisticsFilterResult> GetRealtimePlayerStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionPlayerFilter expressionPlayerFilter, PlayerRealtimeStatisticsFilter playerRealtimeStatisticsFilterToSortBy = PlayerRealtimeStatisticsFilter.OvertimeGoals, int limit = -1, int offsetStart = 0, GameType gameType = GameType.RegularSeason, CancellationToken cancellationToken = default) =>
            await _nhlStatisticsApi.GetRealtimePlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerRealtimeStatisticsFilterToSortBy, limit, offsetStart, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL time-on-ice player game center statistics for players matching the provided filter expression for a specified season, including even-strength time on ice, overtime time on ice, time on ice per game, and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionPlayerFilter">The expression player filter to filter the player statistics by, see <see cref="PlayerFilterExpressionBuilder"/> for more information on valid player filters</param>
    /// <param name="playerTimeOnIceStatisticsFilterToSortBy">The player time-on-ice statistics filter to sort the player statistics by, see <see cref="PlayerTimeOnIceStatisticsFilter"/> for more information on valid player statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL player statistics</param>
    /// <param name="gameType"> The game type for the NHL season for the player statistics </param> 
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns all the NHL time-on-ice player game center statistics for players matching the filter expression for the specified season.</returns>
    public async Task<PlayerTimeOnIceStatisticsFilterResult> GetTimeOnIcePlayerStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionPlayerFilter expressionPlayerFilter, PlayerTimeOnIceStatisticsFilter playerTimeOnIceStatisticsFilterToSortBy = PlayerTimeOnIceStatisticsFilter.TimeOnIce, int limit = -1, int offsetStart = 0, GameType gameType = GameType.RegularSeason, CancellationToken cancellationToken = default) =>
            await _nhlStatisticsApi.GetTimeOnIcePlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerTimeOnIceStatisticsFilterToSortBy, limit, offsetStart, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL player game center statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionPlayerFilter">The expression player filter to filter the player statistics by, see <see cref="PlayerFilterExpressionBuilder"/> for more information on valid player filters</param>
    /// <param name="playerStatisticsFilterToSortBy">The player statistics filter to sort the player statistics by, see <see cref="PlayerStatisticsFilter"/> for more information on valid player statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL player statistics</param>
    /// <param name="gameType"> The game type for the NHL season for the player statistics </param> 
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns> Returns all the NHL player game center statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more </returns>
    public async Task<PlayerStatisticsFilterResult> GetPlayerStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionPlayerFilter expressionPlayerFilter, PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points, int limit = -1, int offsetStart = 0, GameType gameType = GameType.RegularSeason, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, gameType, cancellationToken);

    /// <summary>
    /// Returns all the NHL goalie statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionGoalieFilter">The expression goalie filter to filter the goalie statistics by, see <see cref="GoalieFilterExpressionBuilder"/> for more information on valid goalie filters</param>
    /// <param name="goalieStatisticsFilterToSortBy">The goalie statistics filter to sort the goalie statistics by, see <see cref="GoalieStatisticsFilter"/> for more information on valid goalie statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL goalie statistics</param>
    /// <param name="gameType"> The game type for the NHL season for the player statistics </param> 
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns> Returns all the NHL goalie statistics for a specific goalie for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more </returns>
    /// <returns> Returns all the NHL goalie statistics for goalies matching the filter expression for the specified season, including various performance metrics. </returns>
    public async Task<GoalieStatisticsFilterResult> GetGoalieStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionGoalieFilter expressionGoalieFilter, GoalieStatisticsFilter goalieStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins, int limit = -1, int offsetStart = 0, GameType gameType = GameType.RegularSeason, CancellationToken cancellationToken = default) =>
           await _nhlStatisticsApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionGoalieFilter, goalieStatisticsFilterToSortBy, limit, offsetStart, gameType, cancellationToken);

    /// <summary>
    /// Returns the NHL game direct box score including information such as summaries, linescores, shots by period and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game direct box score including information such as summaries, linescores, shots by period and more</returns>
    public async Task<Boxscore> GetBoxscoreByGameIdAsync(int gameId, CancellationToken cancellationToken = default) => await _nhlGameApi.GetBoxscoreByGameIdAsync(gameId, cancellationToken);


    /// <summary>
    /// Returns the NHL draft ranking by the specified year and starting position for the draft year 
    /// </summary>
    /// <param name="seasonYear"> The NHL draft year </param>
    /// <param name="startingPosition"> The starting position of the NHL draft by the year </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the NHL draft ranking by the specified year and starting position for the draft year </returns>
    public async Task<PlayerDraftYear> GetPlayerDraftRankingByYearAsync(string seasonYear, int startingPosition = 1, CancellationToken cancellationToken = default) =>
        await _nhlPlayerApi.GetPlayerDraftRankingByYearAsync(seasonYear, startingPosition, cancellationToken);

    /// <summary>
    /// Releases and disposes all unused or garbage collected resources for the Nhl.Api
    /// </summary>
    public void Dispose()
    {
        _nhlPlayerApi.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases and disposes all unused or garbage collected resources for the Nhl.Api asynchronously
    /// </summary>
    /// <returns>The await-able result of the asynchronous operation</returns>
    public async ValueTask DisposeAsync()
    {
        _nhlPlayerApi.Dispose();
        await Task.Run(() => GC.SuppressFinalize(this));
    }

    /// <summary>
    /// Returns the current NHL playofff schedule for the current season
    /// </summary>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a collection of playoff series match ups by year</returns>
    public async Task<PlayoffSeriesSchedule> GetPlayoffSeriesBySeasonYearAsync(string seasonYear, CancellationToken cancellationToken = default) =>
        await _nhlLeagueApi.GetPlayoffSeriesBySeasonYearAsync(seasonYear, cancellationToken);
}
