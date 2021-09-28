using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;

namespace Nhl.Api
{
	/// <summary>
	/// The Unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more
	/// </summary>
	public interface INhlApi
	{

		#region Franchises

		/// <summary>
		/// Returns all NHL franchises, including information such as team name, location and more
		/// </summary>
		/// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public Task<List<Franchise>> GetFranchisesAsync();

		/// <summary>
		/// Returns an NHL franchise by the franchise id
		/// </summary>
		/// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
		public Task<Franchise> GetFranchiseByIdAsync(int franchiseId);

		/// <summary>
		/// Returns all active NHL franchises
		/// </summary>
		/// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public Task<List<Franchise>> GetActiveFranchisesAsync();

		/// <summary>
		/// Returns all inactive NHL franchises
		/// </summary>
		/// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public Task<List<Franchise>> GetInactiveFranchisesAsync();

		#endregion

		#region Teams

		/// <summary>
		/// Returns an NHL team by the team id
		/// </summary>
		/// <param name="teamId">The NHL team id, Example: 10 - Toronto Maple Leafs</param>
		/// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
		public Task<Team> GetTeamByIdAsync(int teamId);

		/// <summary>
		/// Returns all active and inactive NHL teams
		/// </summary>
		/// <returns>A collection of all NHL teams, see <see cref="Team"/> for more information</returns>
		public Task<List<Team>> GetTeamsAsync();

		/// <summary>
		/// Returns all active NHL teams
		/// </summary>
		/// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
		public Task<List<Team>> GetActiveTeamsAsync();

		/// <summary>
		/// Returns all inactive NHL teams
		/// </summary>
		/// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
		public Task<List<Team>> GetInactiveTeamsAsync();

		#endregion

		#region Divisions

		/// <summary>
		/// Returns all of the NHL divisions
		/// </summary>
		/// <returns>A collection of all the NHL divisions, see <see cref="Division"/> for more information</returns>
		public Task<List<Division>> GetDivisionsAsync();

		/// <summary>
		/// Returns an NHL division by the division id
		/// </summary>
		/// <param name="divisionId">The NHL division id, Example: 17 - Atlantic divison </param>
		/// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
		public Task<Division> GetDivisionByIdAsync(int divisionId);

		#endregion

		#region Conferences

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		/// <returns>A collection of all the NHL conferences, see <see cref="Conference"/> for more information</returns>
		public Task<List<Conference>> GetConferencesAsync();

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		/// <param name="conferenceId">The NHL conference id, Example: 6 - Eastern Conference </param>
		/// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
		public Task<Conference> GetConferenceByIdAsync(int conferenceId);

		#endregion

		#region Players

		/// <summary>
		/// Returns an NHL player by their player id, includes information such as age, weight, position and more
		/// </summary>
		/// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid </param>
		/// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
		public Task<Player> GetPlayerByIdAsync(int playerId);

		#endregion

		#region Games

		/// <summary>
		/// Returns all of the NHL game types within a season and within special events
		/// </summary>
		/// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
		public Task<List<GameType>> GetGameTypesAsync();

		/// <summary>
		/// Returns all of the valid NHL game statuses of an NHL game
		/// </summary>
		/// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
		public Task<List<GameStatus>> GetGameStatusesAsync();

		/// <summary>
		/// Returns a collection of all the play types within the duration of an NHL game
		/// </summary>
		/// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
		public Task<List<PlayType>> GetPlayTypesAsync();

		/// <summary>
		/// Returns a collection of all the different types of tournaments in the hockey
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</retur
		public Task<List<TournamentType>> GetTournamentTypesAsync();

		/// <summary>
		/// Returns a collection of all the different types of playoff tournaments in the NHL 
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
		public Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync();

		/// <summary>
		/// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
		/// </summary>
		/// <param name="date">The requested date for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public Task<GameSchedule> GetGameScheduleByDateAsnyc(DateTime? date);

		/// <summary>
		/// Return's the NHL game schedule based on the provided year, month and day
		/// </summary>
		/// <param name="year">The requested year for the NHL game schedule</param>
		/// <param name="month">The requested month for the NHL game schedule</param>
		/// <param name="day">The requested day for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public Task<GameSchedule> GetGameScheduleByDateAsnyc(int year, int month, int day);

		#endregion

		#region Seasons

		/// <summary>
		/// Returns all of the NHL seasons since the inception of the league in 1917-1918
		/// </summary>
		/// <returns>A collection of seasons since the inception of the NHL</returns>
		public Task<List<Season>> GetSeasonsAsync();

		/// <summary>
		/// Returns the NHL season information based on the provided season years
		/// </summary>
		/// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
		/// <returns>An NHL season based on the provided season year, Example - "20172018"</returns>
		public Task<Season> GetSeasonByYearAsync(string seasonYear);

		#endregion

		#region Leagues

		/// <summary>
		/// Returns all of the NHL league standing types, this includes playoff and preseason standings
		/// </summary>
		/// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
		public Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync();

		/// <summary>
		/// Returns the standings of every team in the NHL for the provided <see cref="DateTime?"/>, if the date is null it will provide the current NHL league standings
		/// </summary>
		/// <param name="date">The NHL league standings date for the request NHL standings</param>
		/// <returns>A collection of all the leauge standings </returns>
		public Task<List<Records>> GetLeagueStandingsAsync(DateTime? date);

		#endregion

		#region Statistics

		/// <summary>
		/// Returns all distinct types of NHL statistics types
		/// </summary>
		/// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
		public Task<List<StatisticTypes>> GetStatisticTypesAsync();

		/// <summary>
		/// Returns a specified NHL team's statistics for the the specified season, the most recent season statistics will be returned
		/// </summary>
		/// <param name="teamId">The NHL team id, example: Toronto Maple Leafs - 10</param>
		/// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
		/// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
		public Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear);

		#endregion

		#region Drafts

		/// <summary>
		/// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information. <br/>
		/// <strong>Note:</strong> Some NHL draft years responses provide very large JSON payloads
		/// </summary>
		/// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
		/// <returns>The NHL league draft, which includes draft rounds, player information and more, see <see cref="LeagueDraft"/> for more information</returns>
		public Task<LeagueDraft> GetDraftByYear(string year);

		#endregion

		#region Prospects

		/// <summary>
		/// Returns all the NHL league prospects <br/>
		/// <strong>Note:</strong> The NHL prospects response provides a very large JSON payload
		/// </summary>
		/// <returns>A collection of all the NHL prospects, see <see cref="ProspectProfile"/> for more information </returns>
		public Task<List<ProspectProfile>> GetLeagueProspectsAsync();

		/// <summary>
		/// Returns an NHL prospect profile by their prospect id
		/// </summary>
		/// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
		public Task<ProspectProfile> GetLeagueProspectByIdAsync(int prospectId);

		#endregion

		#region Awards

		/// <summary>
		/// Returns all of the NHL awards, including the description, history, and images
		/// </summary>
		/// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
		public Task<List<Award>> GetLeagueAwardsAsync();

		/// <summary>
		/// Returns an NHL award by the award id <br/>
		/// Example: 1 - Stanley Cup 
		/// </summary>
		/// <param name="leagueAwardId">The NHL league award identifier </param>
		/// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
		public Task<Award> GetLeagueAwardByIdAsync(int leagueAwardId);

		#endregion

		#region Venues

		/// <summary>
		/// Returns all of the NHL venue's, including arenas and stadiums <br/>
		/// <strong>NOTE:</strong> This is not a comprehnsive list of all NHL stadiums and arenas
		/// </summary>
		/// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
		public Task<List<LeagueVenue>> GetLeagueVenuesAsync();

		/// <summary>
		/// Returns an NHL venue by the venue id <br/>
		///  Example: 5058 - Canada Life Centre
		/// </summary>
		/// <param name="venueId">The specified id of an NHL venue, </param>
		/// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
		public Task<LeagueVenue> GetLeagueVenueByIdAsync(int venueId);

		#endregion

		#region Event Types

		/// <summary>
		/// Return's all the event types within the NHL
		/// </summary>
		/// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
		public Task<List<EventType>> GetEventTypesAsync();
		#endregion
	}
}
