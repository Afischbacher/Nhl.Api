#region System
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
#endregion

#region Nhl.Api
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;
#endregion

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more
    /// </summary>
    public interface INhlApi
    {

        #region Franchises

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

        #endregion

        #region Teams

        /// <summary>
        /// Returns an NHL team by the team id
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 10 - Toronto Maple Leafs</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        Task<Team> GetTeamByIdAsync(int teamId);

        /// <summary>
        /// Returns an NHL team by the team enumeration <br/>
        /// Example: <see cref="TeamEnum.SeattleKraken"/>
        /// </summary>
        /// <param name="team">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information on teams</returns>
        Task<Team> GetTeamByIdAsync(TeamEnum team);

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

        #endregion

        #region Divisions

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

        #endregion

        #region Conferences

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

        #endregion

        #region Players

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
        /// Returns all of the NHL player statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(int playerId, string seasonYear);

        /// <summary>
        /// Returns all of the NHL player statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(PlayerEnum player, string seasonYear);

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(int playerId, string seasonYear);

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(PlayerEnum player, string seasonYear);


        #endregion

        #region Games

        /// <summary>
        /// Returns all of the NHL game types within a season and within special events
        /// </summary>
        /// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
        Task<List<GameType>> GetGameTypesAsync();

        /// <summary>
        /// Returns all of the valid NHL game statuses of an NHL game
        /// </summary>
        /// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
        Task<List<GameStatus>> GetGameStatusesAsync();

        /// <summary>
        /// Returns a collection of all the play types within the duration of an NHL game
        /// </summary>
        /// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
        Task<List<PlayType>> GetPlayTypesAsync();

        /// <summary>
        /// Returns a collection of all the different types of tournaments in the hockey
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
        Task<List<TournamentType>> GetTournamentTypesAsync();

        /// <summary>
        /// Returns a collection of all the different types of playoff tournaments in the NHL 
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
        Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync();

        /// <summary>
        /// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
        /// </summary>
        /// <param name="date">The requested date for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        Task<GameSchedule> GetGameScheduleByDateAsync(DateTime? date);

        /// <summary>
        /// Return's today's the NHL game schedule and it will provide today's current NHL game schedule 
        /// </summary>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        Task<GameSchedule> GetGameScheduleAsync();

        /// <summary>
        /// Return's the NHL game schedule based on the provided year, month and day
        /// </summary>
        /// <param name="year">The requested year for the NHL game schedule</param>
        /// <param name="month">The requested month for the NHL game schedule</param>
        /// <param name="day">The requested day for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        Task<GameSchedule> GetGameScheduleByDateAsync(int year, int month, int day);

        /// <summary>
        /// Returns the live game feed content for an NHL game
        /// </summary>
        /// <param name="liveFeedGameId">The live game feed id, example: 2021020087</param>
        /// <returns>A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more</returns>
        Task<LiveGameFeedResult> GetLiveGameFeedById(int liveFeedGameId);

        #endregion

        #region Seasons

        /// <summary>
        /// Returns all of the NHL seasons since the inception of the league in 1917-1918
        /// </summary>
        /// <returns>A collection of seasons since the inception of the NHL</returns>
        Task<List<Season>> GetSeasonsAsync();

        /// <summary>
        /// Returns the NHL season information based on the provided season years
        /// </summary>
        /// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
        /// <returns>An NHL season based on the provided season year, Example - "20172018"</returns>
        Task<Season> GetSeasonByYearAsync(string seasonYear);

        #endregion

        #region Leagues

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

        #endregion

        #region Statistics

        /// <summary>
        /// Returns all distinct types of NHL statistics types
        /// </summary>
        /// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
        Task<List<StatisticTypes>> GetStatisticTypesAsync();

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="teamId">The NHL team id, example: Toronto Maple Leafs - 10</param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear);

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="team">The NHL team id, example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        Task<TeamStatistics> GetTeamStatisticsByIdAsync(TeamEnum team, string seasonYear);

        #endregion

        #region Drafts

        /// <summary>
        /// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information. <br/>
        /// <strong>Note:</strong> Some NHL draft years responses provide very large JSON payloads
        /// </summary>
        /// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
        /// <returns>The NHL league draft, which includes draft rounds, player information and more, see <see cref="LeagueDraft"/> for more information</returns>
        Task<LeagueDraft> GetDraftByYear(string year);

        #endregion

        #region Prospects

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

        #endregion

        #region Awards

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

        #endregion

        #region Venues

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

        #endregion

        #region Event Types

        /// <summary>
        /// Return's all the event types within the NHL
        /// </summary>
        /// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
        Task<List<EventType>> GetEventTypesAsync();
        #endregion
    }
}
