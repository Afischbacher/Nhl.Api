using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Nhl.Api.Http;
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standings;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;

namespace Nhl.Api
{

	public class NhlApi : INhlApi
	{
		public NhlApi()
		{

		}

		/// <summary>
		/// Returns all NHL franchises
		/// </summary>
		public async Task<List<Franchise>> GetAllFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises")).Franchises;
		}

		/// <summary>
		/// Returns all active NHL franchises
		/// </summary>
		public async Task<List<Franchise>> GetAllActiveFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
				.Franchises
				.Where(franchise => !franchise.LastSeasonId.HasValue)
				.ToList();
		}

		/// <summary>
		/// Returns all inactive NHL franchises
		/// </summary>
		public async Task<List<Franchise>> GetAllInactiveFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
				.Franchises
				.Where(franchise => franchise.LastSeasonId.HasValue)
				.ToList();
		}

		/// <summary>
		/// Returns a single NHL franchise by the franchise id
		/// </summary>
		/// <param name="id">The NHL franchise id, example: New York Rangers is the number 10</param>
		public async Task<Franchise> GetFranchiseByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>($"/franchises/{id}"))
				.Franchises
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL team by the team id
		/// </summary>
		/// <param name="id">The NHL team id, example: Toronto Maple Leafs - 10</param>
		public async Task<Team> GetTeamByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams/{id}"))
				.Teams
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all the NHL teams
		/// </summary>
		public async Task<List<Team>> GetAllTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams")).Teams;
		}

		/// <summary>
		/// Returns all the active NHL teams
		/// </summary>
		public async Task<List<Team>> GetAllActiveTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
				.Teams
				.Where(team => team.Active)
				.ToList();
		}

		/// <summary>
		/// Returns all the inactive NHL teams
		/// </summary>
		public async Task<List<Team>> GetAllInactiveTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
				.Teams
				.Where(team => !team.Active)
				.ToList();
		}

		/// <summary>
		/// Returns all of the NHL divisions
		/// </summary>
		public async Task<List<Division>> GetAllDivisionsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueDivisions>($"/divisions")).Divisions;
		}

		/// <summary>
		/// Returns an NHL division by the division id
		/// </summary>
		/// <param name="id">The NHL division id, example: Atlantic divison is the number 17</param>
		public async Task<Division> GetDivisionByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueDivisions>($"/divisions/{id}"))
				.Divisions
				.FirstOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		public async Task<List<Conference>> GetAllConferencesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueConferences>($"/conferences")).Conferences;
		}

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		/// <param name="id">The NHL conference id, example: Eastern Conference is the number 6</param>
		public async Task<Conference> GetConferenceByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueConferences>($"/conferences/{id}"))
				.Conferences
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL player based on a player id, see <see cref="Player"/> for more information
		/// </summary>
		/// <param name="id">An NHL player id, example: 8478402 is Connor McDavid </param>
		/// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
		public async Task<Player> GetPlayerByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeaguePlayers>($"/people/{id}"))
				.Players
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL game types within a season and within special events
		/// </summary>
		/// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
		public async Task<List<GameType>> GetGameTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameType>>($"/gameTypes");
		}

		/// <summary>
		/// Returns all of the valid NHL game statuses of an NHL game
		/// </summary>
		/// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
		public async Task<List<GameStatus>> GetGameStatusesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameStatus>>($"/gameStatus");
		}

		/// <summary>
		/// Returns a collection of all the play types within the duration of an NHL game
		/// </summary>
		/// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
		public async Task<List<PlayType>> GetPlayTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<PlayType>>($"/playTypes");
		}

		/// <summary>
		/// Returns a collection of all the different types of tournaments in the hockey
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
		public async Task<List<TournamentType>> GetTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<TournamentType>>($"/tournamentTypes");
		}

		/// <summary>
		/// Returns a collection of all the different types of playoff tournaments in the NHL 
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
		public async Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<PlayoffTournamentType>($"/tournaments/playoffs");
		}

		/// <summary>
		/// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
		/// </summary>
		/// <param name="date">The requested date for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public async Task<GameSchedule> GetGameScheduleByDateAsnyc(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/schedule?date={date.Value:yyyy-MM-dd}" : "/schedule";
			return await NhlApiHttpClient.GetAsync<GameSchedule>(httpRequestUri);
		}

		/// <summary>
		/// Return's the NHL game schedule based on the provided year, month and day
		/// </summary>
		/// <param name="date">The requested date for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public async Task<GameSchedule> GetGameScheduleByDateAsnyc(int year, int month, int day)
		{
			return await NhlApiHttpClient.GetAsync<GameSchedule>($"/schedule?date={year}-{month}-{day}");
		}
		
		/// <summary>
		/// Returns all of the NHL seasons since the inception of the league in 1917-1918
		/// </summary>
		/// <returns>A collection of seasons since the inception of the NHL</returns>
		public async Task<List<Season>> GetAllSeasonsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueSeasons>("/seasons")).Seasons;
		}

		/// <summary>
		/// Returns the NHL season information based on the provided season years
		/// </summary>
		/// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
		/// <returns>An NHL season based on the provided season year, example: '20172018'</returns>
		public async Task<Season> GetSeasonByYearAsync(string seasonYear)
		{
			if (string.IsNullOrEmpty(seasonYear))
			{
				throw new ArgumentNullException(nameof(seasonYear));
			}

			if (seasonYear.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			return (await NhlApiHttpClient.GetAsync<LeagueSeasons>($"/seasons/{seasonYear}"))
				.Seasons
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL league standing types, this includes playoff and preseason standings
		/// </summary>
		/// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
		public async Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<LeagueStandingType>>($"/standingsTypes");
		}

		/// <summary>
		/// Returns the standings of every team in the NHL for the provided <see cref="DateTime?"/>, if the date is null it will provide the current NHL league standings
		/// </summary>
		/// <param name="date">The NHL league standings date for the request NHL standings</param>
		/// <returns>A collection of all the leauge standings </returns>
		public async Task<List<Records>> GetLeagueStandingsAsync(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/standings?date={date.Value:yyyy-MM-dd}" : "/standings";
			return (await NhlApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri)).Records;
		}

		/// <summary>
		/// Returns all distinct types of NHL statistics types
		/// </summary>
		/// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
		public async Task<List<StatisticTypes>> GetStatisticTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<StatisticTypes>>("/statTypes");
		}

		/// <summary>
		/// Returns a specified NHL team's statistics for the the specified season, if no season year is specified, see <see cref="SeasonYear"/>, the most recent season statistics will be returned
		/// </summary>
		/// <param name="id">The NHL team id, example: Toronto Maple Leafs - 10</param>
		/// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
		/// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
		public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(int id, string seasonYear)
		{
			if (seasonYear?.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			var httpRequestUri = string.IsNullOrWhiteSpace(seasonYear) ? $"/teams/{id}/stats" : $"/teams/{id}/stats?season={seasonYear}";
			return await NhlApiHttpClient.GetAsync<TeamStatistics>(httpRequestUri);
		}

		/// <summary>
		/// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information
		/// </summary>
		/// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
		/// <returns></returns>
		public async Task<LeagueDraft> GetDraftByYear(string year)
		{
			if (string.IsNullOrEmpty(year))
			{
				throw new ArgumentNullException(nameof(year));
			}

			if (year.Length > 4)
			{
				throw new ArgumentException($"{nameof(year)} is not a valid draft year format");
			}

			return await NhlApiHttpClient.GetAsync<LeagueDraft>($"/draft/{year}");
		}

		public async Task<LeagueProspects> GetLeagueProspectsAsync()
		{
			return await NhlApiHttpClient.GetAsync<LeagueProspects>("/draft/prospects");
		}

		public async Task<ProspectProfile> GetLeagueProspectByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueProspects>($"/draft/prospects/{id}"))
				.Prospects
				.SingleOrDefault();
		}

		public async Task<LeagueAwards> GetLeagueAwardsAsync()
		{
			return await NhlApiHttpClient.GetAsync<LeagueAwards>("/awards");
		}

		public async Task<Award> GetLeagueAwardByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueAwards>($"/awards/{id}"))
				.Awards
				.SingleOrDefault();
		}

		public async Task<LeagueVenues> GetLeagueVenuesAsync()
		{
			return await NhlApiHttpClient.GetAsync<LeagueVenues>("/venues");
		}

		public async Task<LeagueVenue> GetLeagueVenueByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueVenues>($"/venues/{id}"))
				.Venues
				.SingleOrDefault();
		}

		public async Task<List<EventType>> GetEventTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<EventType>>("/eventTypes");
		}
	}
}
