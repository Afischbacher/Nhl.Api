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
		/// <param name="id">The NHL team id, example: Toronto Maple Leafs is the number 10</param>
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
		/// <returns></returns>
		public async Task<Player> GetPlayerByIdAsync(int id)
		{
			return (await NhlApiHttpClient.GetAsync<LeaguePlayers>($"/people/{id}"))
				.Players
				.SingleOrDefault();
		}


		public async Task<List<GameType>> GetGameTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameType>>($"/gameTypes");
		}

		public async Task<List<GameStatus>> GetGameStatusesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameStatus>>($"/gameStatus");
		}

		public async Task<List<PlayType>> GetPlayTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<PlayType>>($"/playTypes");
		}

		public async Task<List<TournamentType>> GetTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<TournamentType>>($"/tournamentTypes");
		}

		public async Task<List<PlayoffTournamentType>> GetPlayoffTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<PlayoffTournamentType>>($"/tournaments/playoffs");
		}

		/// <summary>
		/// Return's the NHL game schedule based on the provided date. If the date is null, it will provide today's current NHL game schedule 
		/// </summary>
		/// <param name="date">The requested date for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public async Task<GameSchedule> GetGameScheduleByDateAsnyc(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/schedule?date={date.Value:yyyy-mm-dd}" : "/schedule";
			return await NhlApiHttpClient.GetAsync<GameSchedule>(httpRequestUri);
		}

		public async Task<List<Season>> GetAllSeasonsAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<Season>>("/seasons");
		}

		/// <summary>
		/// 
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

			return await NhlApiHttpClient.GetAsync<Season>($"/seasons/{seasonYear}");
		}

		public async Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<LeagueStandingType>>($"/standingsTypes");
		}

		public async Task<LeagueStandings> GetLeagueStandingsAsync(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/standings?season={date.Value:yyyy-mm-dd}" : "/standings";
			return await NhlApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri);
		}

		public async Task<StatisticTypes> GetStatisticTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<StatisticTypes>("/statTypes");
		}

		public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<TeamStatistics>($"/teams/{id}/stats");
		}

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
