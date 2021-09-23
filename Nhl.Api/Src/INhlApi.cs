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

namespace Nhl.Api
{
	public interface INhlApi
	{
		public Task<List<Franchise>> GetFranchisesAsync();
		
		public Task<Franchise> GetFranchiseByIdAsync(int franchiseId);

		public Task<Team> GetTeamByIdAsync(int teamId);

		public Task<List<Team>> GetTeamsAsync();

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
	}
}
