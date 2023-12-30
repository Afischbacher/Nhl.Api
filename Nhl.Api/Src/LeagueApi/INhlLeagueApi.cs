using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.League;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Team;

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
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint</returns>
    Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light);

    /// <summary>
    /// Returns an the NHL team logo based using the NHL team enumeration
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint</returns>
    Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    Task<TeamColors> GetTeamColorsAsync(TeamEnum team);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    Task<TeamColors> GetTeamColorsAsync(int teamId);

    /// <summary>
    /// Returns the NHL team schedule for a specific date using the DateTimeOffset
    /// </summary>
    /// <param name="dateTimeOffset">A <see cref="DateTimeOffset"/> for the specific date for the NHL schedule</param>
    /// <returns>A result of the current NHL schedule by the specified date</returns>
    Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateTimeAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="dateTimeOffset">The date in which the request schedule for the team and for the week is request for</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    Task<TeamWeekSchedule> GetTeamWeekScheduleByDateTimeOffsetAsync(string teamAbbreviation, DateTimeOffset dateTimeOffset);

    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, string seasonYear);

    /// <summary>
    /// Returns the true or false if the NHL playoff pre season is active or inactive
    /// </summary>
    /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
    Task<bool> IsPreSeasonActiveAsync();
    /// <summary>
    /// Returns the true or false if the NHL regular season is active or inactive
    /// </summary>
    /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
    Task<bool> IsRegularSeasonActiveAsync();

    /// <summary>
    /// Returns the true or false if the NHL playoff season is active or inactive
    /// </summary>
    /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
    Task<bool> IsPlayoffSeasonActiveAsync();

    /// <summary>
    /// Returns the NHL league standings for the current NHL season by the specified date
    /// </summary>
    /// <param name="dateTimeOffset">The date requested for the NHL season standing</param>
    /// <returns>Return the NHL league standings for the specified date with specific team information</returns>
    Task<LeagueStanding> GetLeagueStandingsByDateTimeOffsetAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns the NHL league standings for the all NHL seasons with specific league season information
    /// </summary>
    /// <returns>Returns the NHL league standings information for each saeson since 1917-1918 </returns>
    Task<LeagueStandingsSeasonInformation> GetLeagueStandingsSeasonInformationAsync();

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team identifier and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(int teamId, string seasonYear);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team and season year
    /// </summary>
    /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(TeamEnum team, string seasonYear);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    Task<List<int>> GetAllRosterSeasonsByTeamAsync(int teamId);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    Task<List<int>> GetAllRosterSeasonsByTeamAsync(TeamEnum team);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies
    /// </summary>
    /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
    /// <returns></returns>
    Task<TeamProspects> GetTeamProspectsByTeamAsync(int teamId);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies
    /// </summary>
    /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 10 - Toronto Maple Leafs </param>
    /// <returns></returns>
    Task<TeamProspects> GetTeamProspectsByTeamAsync(TeamEnum team);

    /// <summary>
    /// Returns the NHL league schedule for the specified date
    /// </summary>
    /// <param name="dateTimeOffset">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <returns>Returns the NHL league schedule for the specified date</returns>
    Task<LeagueSchedule> GetLeagueWeekScheduleByDateTimeAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns the NHL league calendar schedule for the specified date and all applicable teams
    /// </summary>
    /// <param name="dateTimeOffset">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <returns>Returns the NHL league calendar schedule for the specified date and all applicable teams</returns>
    Task<LeagueScheduleCalendar> GetLeagueScheduleCalendarAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns the collection of countries and where you can watch NHL games with links and more
    /// </summary>
    /// <returns>Returns the collection of countries and where you can watch NHL games with links and more</returns>
    Task<List<GameWatchSource>> GetSourcesToWatchGamesAsync();

    /// <summary>
    /// Returns the NHL TV broadcasts for the specified date with information about the broadcasts
    /// </summary>
    /// <param name="dateTimeOffset">The date requested for the NHL TV broadcasts, Example: 2024-02-10</param>
    /// <returns>Returns the NHL TV broadcasts for the specified date with information about the broadcasts</returns>
    Task<TvScheduleBroadcast> GetTvScheduleBroadcastAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns all the NHL seasons for the NHL league
    /// </summary>
    /// <returns>Returns all the NHL seasons for the NHL league</returns>
    Task<List<int>> GetAllSeasonsAsync();

    /// <summary>
    /// Returns the metadata information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="playerIds">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teamIds">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <returns>Returns the metadata information about the NHL league including players, teams and season states</returns>
    Task<LeagueMetadataInformation> GetLeagueMetadataInformation(List<int> playerIds, List<string> teamIds);

    /// <summary>
    /// Returns the metadata information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="players">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teams">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <returns>Returns the metadata information about the NHL league including players, teams and season states</returns>
    Task<LeagueMetadataInformation> GetLeagueMetadataInformation(List<PlayerEnum> players, List<TeamEnum> teams);
    
    /// <summary>
    /// Determines if the NHL league is active or inactive based on the current date and time
    /// </summary>
    /// <returns>Returns true or false based on the current time and date</returns>
    Task<bool> IsLeagueActiveAsync();

}
