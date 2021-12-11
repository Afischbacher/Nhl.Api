using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
    /// </summary>
    public interface INhlLeagueApi
    {
        /// <summary>
        /// Returns all NHL franchises, including information such as team name, location and more
        /// </summary>
        /// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
        Task<List<Franchise>> GetFranchisesAsync();

        /// <summary>
        /// Returns an NHL franchise by the franchise id <br/>
        /// Example: <see cref="FranchiseEnum.LosAngelesKings"/>
        /// </summary>
        /// <param name="franchise">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="FranchiseEnum"/> for more information on NHL franchises</param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        Task<Franchise> GetFranchiseByIdAsync(FranchiseEnum franchise);

        /// <summary>
        /// Returns an NHL franchise by the franchise id
        /// </summary>
        /// <param name="franchiseId">The NHL team id, Example: 10 - Toronto Maple Leafs</param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        Task<Franchise> GetFranchiseByIdAsync(int franchiseId);

        /// <summary>
        /// Returns all active NHL franchises
        /// </summary>
        /// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
        Task<List<Franchise>> GetActiveFranchisesAsync();

        /// <summary>
        /// Returns all inactive NHL franchises
        /// </summary>
        /// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
        Task<List<Franchise>> GetInactiveFranchisesAsync();

        /// <summary>
        /// Returns an NHL team by the team id
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 10 - Toronto Maple Leafs</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        Task<Team> GetTeamByIdAsync(int teamId);

        /// <summary>
        /// Returns a collection of NHL team by the team id's
        /// </summary>
        /// <param name="teamIds">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<int> teamIds);

        /// <summary>
        /// Returns an NHL team by the team enumeration <br/>
        /// Example: <see cref="TeamEnum.SeattleKraken"/>
        /// </summary>
        /// <param name="team">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information on teams</returns>
        Task<Team> GetTeamByIdAsync(TeamEnum team);

        /// <summary>
        /// Returns a collection of NHL team's by the team enumeration values
        /// </summary>
        /// <param name="teams">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<TeamEnum> teams);

        /// <summary>
        /// Returns all active and inactive NHL teams
        /// </summary>
        /// <returns>A collection of all NHL teams, see <see cref="Team"/> for more information</returns>
        Task<List<Team>> GetTeamsAsync();

        /// <summary>
        /// Returns all active NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        Task<List<Team>> GetActiveTeamsAsync();

        /// <summary>
        /// Returns all inactive NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        Task<List<Team>> GetInactiveTeamsAsync();

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
        /// Returns all of the NHL divisions
        /// </summary>
        /// <returns>A collection of all the NHL divisions, see <see cref="Division"/> for more information</returns>
        Task<List<Division>> GetDivisionsAsync();

        /// <summary>
        /// Returns an NHL division by the division id
        /// </summary>
        /// <param name="divisionId">The NHL division id, Example: 17 - Atlantic division </param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        Task<Division> GetDivisionByIdAsync(int divisionId);

        /// <summary>
        /// Returns an NHL division by the division enumeration <br/>
        /// Example: <see cref="DivisionEnum.Atlantic"/>
        /// </summary>
        /// <param name="division">The NHL division id, Example: 17 - Atlantic division, see <see cref="DivisionEnum"/> for more information on NHL divisions </param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        Task<Division> GetDivisionByIdAsync(DivisionEnum division);

        /// <summary>
        /// Returns all of the NHL conferences
        /// </summary>
        /// <returns>A collection of all the NHL conferences, see <see cref="Conference"/> for more information</returns>
        Task<List<Conference>> GetConferencesAsync();

        /// <summary>
        /// Returns the NHL conference by id
        /// </summary>
        /// <param name="conferenceId">The NHL conference id, Example: 6 - Eastern Conference </param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        Task<Conference> GetConferenceByIdAsync(int conferenceId);

        /// <summary>
        /// Returns the NHL conference by the conference enumeration <br/>
        /// Example: <see cref="ConferenceEnum.Eastern"/>
        /// </summary>
        /// <param name="conference">The NHL conference id, Example: 6 - Eastern Conference, see <see cref="ConferenceEnum"/> for more information on NHL conferences</param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        Task<Conference> GetConferenceByIdAsync(ConferenceEnum conference);

        /// <summary>
        /// Returns all of the NHL seasons since the inception of the league in 1917-1918
        /// </summary>
        /// <returns>A collection of seasons since the inception of the NHL</returns>
        Task<List<Season>> GetSeasonsAsync();

        /// <summary>
        /// Determines whether the NHL season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL season is active (true) or inactive (false)</returns>
        Task<bool> IsSeasonActiveAsync();

        /// <summary>
        /// Determines whether the NHL regular season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL regular season is active (true) or inactive (false)</returns>
        Task<bool> IsRegularSeasonActiveAsync();

        /// <summary>
        /// Determines whether the NHL playoff season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL playoff season is active (true) or inactive (false)</returns>
        Task<bool> IsPlayoffsActiveAsync();

        /// <summary>
        /// Returns the NHL season information based on the provided season years
        /// </summary>
        /// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
        /// <returns>An NHL season based on the provided season year, Example - "20172018"</returns>
        Task<Season> GetSeasonByYearAsync(string seasonYear);

        /// <summary>
        /// Return the current and most recent NHL season
        /// </summary>
        /// <returns>The most recent NHL season</returns>
        Task<Season> GetCurrentSeasonAsync();

        /// <summary>
        /// Returns all of the NHL league standing types, this includes playoff and preseason standings
        /// </summary>
        /// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
        Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync();

        /// <summary>
        /// Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings</param>
        /// <returns>A collection of all the league standings </returns>
        Task<List<Records>> GetLeagueStandingsAsync(DateTime? date);

        /// <summary>
        /// Returns the standings of every team in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings </returns>
        Task<List<Records>> GetLeagueStandingsAsync();

        /// <summary>
        /// Returns the standings of every team by conference in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by conference</returns>
        Task<List<Records>> GetLeagueStandingsByConferenceAsync();

        /// <summary>
        /// Returns the standings of every team by division in the NHL by date, if the date is null it will provide the current NHL league standings by division
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by division</param>
        /// <returns>A collection of all the league standings by division for the selected date</returns>
        Task<List<Records>> GetLeagueStandingsByDivisionAsync(DateTime? date);

        /// <summary>
        /// Returns the standings of every team in the NHL by conference for the current date, if the date is null it will provide the current NHL league standings by conference
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by conference</param>
        /// <returns>A collection of all the league standings by conference for the selected date</returns>
        Task<List<Records>> GetLeagueStandingsByConferenceAsync(DateTime? date);

        /// <summary>
        /// Returns the standings of every team by division in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by division</returns>
        Task<List<Records>> GetLeagueStandingsByDivisionAsync();

        /// <summary>
        /// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information. <br/>
        /// <strong>Note:</strong> Some NHL draft years responses provide very large JSON payloads
        /// </summary>
        /// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
        /// <returns>The NHL league draft, which includes draft rounds, player information and more, see <see cref="LeagueDraft"/> for more information</returns>
        Task<LeagueDraft> GetDraftByYearAsync(string year);

        /// <summary>
        /// Returns all of the NHL awards, including the description, history, and images
        /// </summary>
        /// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
        Task<List<Award>> GetLeagueAwardsAsync();

        /// <summary>
        /// Returns an NHL award by the award id <br/>
        /// Example: 1 - Stanley Cup 
        /// </summary>
        /// <param name="leagueAwardId">The NHL league award identifier </param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        Task<Award> GetLeagueAwardByIdAsync(int leagueAwardId);

        /// <summary>
        /// Returns an NHL award by the award id <br/>
        /// Example: <see cref="AwardEnum.StanleyCup"/>
        /// </summary>
        /// <param name="leagueAward">The NHL league award identifier, see <see cref="AwardEnum"/> for more information on NHL awards </param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        Task<Award> GetLeagueAwardByIdAsync(AwardEnum leagueAward);

        /// <summary>
        /// Returns all of the NHL venue's, including arenas and stadiums <br/>
        /// <strong>NOTE:</strong> This is not a comprehensive list of all NHL stadiums and arenas
        /// </summary>
        /// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
        Task<List<LeagueVenue>> GetLeagueVenuesAsync();

        /// <summary>
        /// Returns an NHL venue by the venue id <br/>
        ///  Example: 5058 - Canada Life Centre
        /// </summary>
        /// <param name="venueId">The specified id of an NHL venue, </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        Task<LeagueVenue> GetLeagueVenueByIdAsync(int venueId);

        /// <summary>
        /// Returns an NHL venue by the venue enumeration <br/>
        ///  Example: <see cref="VenueEnum.EnterpriseCenter"/>
        /// </summary>
        /// <param name="venue">The specified NHL venue, see <see cref="VenueEnum"/> for more information on NHL venues </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        Task<LeagueVenue> GetLeagueVenueByIdAsync(VenueEnum venue);

        /// <summary>
        /// Return's all the event types within the NHL
        /// </summary>
        /// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
        Task<List<EventType>> GetEventTypesAsync();
    }
}
