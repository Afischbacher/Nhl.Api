using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standings;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Venue;
using Nhl.Api.Models.Event;

namespace Nhl.Api
{
	public interface INhlApi
	{
		public Task<List<Franchise>> GetAllFranchisesAsync();
		
		public Task<Franchise> GetFranchiseByIdAsync(int franchiseId);

		public Task<List<Franchise>> GetAllActiveFranchisesAsync();

		public Task<List<Franchise>> GetAllInactiveFranchisesAsync();

		public Task<Team> GetTeamByIdAsync(int teamId);

		public Task<List<Team>> GetAllTeamsAsync();

		public Task<List<Team>> GetAllActiveTeamsAsync();

		public Task<List<Division>> GetDivisionsAsync();

		public Task<Division> GetDivisionByIdAsync(int divisioIid);

		public Task<List<Conference>> GetConferencesAsync();

		public Task<Conference> GetConferenceByIdAsync(int conferenceId);

		public Task<Player> GetPlayerByIdAsync(int playerId);

		public Task<List<GameType>> GetGameTypesAsync();

		public Task<List<GameStatus>> GetGameStatusesAsync();

		public Task<List<PlayType>> GetPlayTypesAsync();

		public Task<List<TournamentType>> GetTournamentTypesAsync();

		public Task<List<PlayoffTournamentType>> GetPlayoffTournamentTypesAsync();

		public Task<GameSchedule> GetGameScheduleByDateAsnyc(DateTime? date);

		public Task<List<Season>> GetAllSeasonsAsync();

		public Task<Season> GetSeasonByYearAsync(string seasonYear);

		public Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync();

		public Task<LeagueStandings> GetLeagueStandingsAsync(DateTime? date);

		public Task<StatisticTypes> GetStatisticTypesAsync();

		public Task<TeamStatistics> GetTeamStatisticsByIdAsync(int id);

		public Task<LeagueDraft> GetDraftByYear(string year);

		public Task<LeagueProspects> GetLeagueProspectsAsync();

		public Task<ProspectProfile> GetLeagueProspectByIdAsync(int id);

		public Task<LeagueAwards> GetLeagueAwardsAsync();

		public Task<Award> GetLeagueAwardByIdAsync(int id);

		public Task<LeagueVenues> GetLeagueVenuesAsync();

		public Task<LeagueVenue> GetLeagueVenueByIdAsync(int id);

		public Task<List<EventType>> GetEventTypesAsync();
	}
}
