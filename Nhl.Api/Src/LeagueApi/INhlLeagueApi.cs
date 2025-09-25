namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
/// </summary>
public interface INhlLeagueApi
{
    /// <summary>
    /// Returns an the NHL team logo using the NHL team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <param name="teamLogoType">A season year for the all the NHL statistics, based on the background of light or dark</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024, Note: This only applies to the Utah Mammoth and Utah Hockey Club for the 2024-2025 NHL season</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the URI endpoint</returns>
    public Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light, string? seasonYear = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024, Note: This only applies to the Utah Mammoth and Utah Hockey Club for the 2024-2025 NHL season</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
    public Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light, string? seasonYear = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public Task<TeamColors> GetTeamColorsAsync(TeamEnum team, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public Task<TeamColors> GetTeamColorsAsync(int teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for a specific date using the date
    /// </summary>
    /// <param name="date">A <see cref="DateOnly"/> for the specific date for the NHL schedule</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A result of the current NHL schedule by the specified date</returns>
    public Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="date">The date in which the request schedule for the team and for the week is request for</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public Task<TeamWeekSchedule> GetTeamWeekScheduleByDateAsync(string teamAbbreviation, DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the true or false if the NHL playoff pre season is active or inactive
    /// </summary>
    /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
    public Task<bool> IsPreSeasonActiveAsync(CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns the true or false if the NHL regular season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
    public Task<bool> IsRegularSeasonActiveAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the true or false if the NHL playoff season is active or inactive
    /// </summary>
    /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
    public Task<bool> IsPlayoffSeasonActiveAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL league standings for the current NHL season by the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL season standing</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Return the NHL league standings for the specified date with specific team information</returns>
    public Task<LeagueStanding> GetLeagueStandingsByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL league standings for the all NHL seasons with specific league season information
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league standings information for each season since 1917-1918 </returns>
    public Task<LeagueStandingsSeasonInformation> GetLeagueStandingsSeasonInformationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team identifier and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public Task<List<int>> GetAllRosterSeasonsByTeamAsync(int teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public Task<List<int>> GetAllRosterSeasonsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public Task<TeamProspects> GetTeamProspectsByTeamAsync(int teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 10 - Toronto Maple Leafs </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public Task<TeamProspects> GetTeamProspectsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL league schedule for the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league schedule for the specified date</returns>
    public Task<LeagueSchedule> GetLeagueWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL league calendar schedule for the specified date and all applicable teams
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league calendar schedule for the specified date and all applicable teams</returns>
    public Task<LeagueScheduleCalendar> GetLeagueScheduleCalendarByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the collection of countries and where you can watch NHL games with links and more
    /// </summary>
    /// <returns>Returns the collection of countries and where you can watch NHL games with links and more</returns>
    public Task<List<GameWatchSource>> GetSourcesToWatchGamesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL TV broadcasts for the specified date with information about the broadcasts
    /// </summary>
    /// <param name="date">The date requested for the NHL TV broadcasts, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL TV broadcasts for the specified date with information about the broadcasts</returns>
    public Task<TvScheduleBroadcast> GetTvScheduleBroadcastByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL seasons for the NHL league
    /// </summary>
    /// <returns>Returns all the NHL seasons for the NHL league</returns>
    public Task<List<int>> GetAllSeasonsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="playerIds">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teamIds">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<int> playerIds, List<string> teamIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="players">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teams">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<PlayerEnum> players, List<TeamEnum> teams, CancellationToken cancellationToken = default);

    /// <summary>
    /// Determines if the NHL league is active or inactive based on the current date and time
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns true or false based on the current time and date</returns>
    public Task<bool> IsLeagueActiveAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the current NHL playofff schedule for the current season
    /// </summary>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a collection of playoff series match ups by year </returns>
    public Task<PlayoffSeriesSchedule> GetPlayoffSeriesBySeasonYearAsync(string seasonYear, CancellationToken cancellationToken = default);

}
