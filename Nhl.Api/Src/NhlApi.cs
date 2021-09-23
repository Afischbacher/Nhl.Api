using Nhl.Api.Http;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
	public class NhlApi : INhlApi
	{
		public async Task<List<Franchise>> GetFranchisesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<Franchise>>("/franchises");
		}

		public async Task<Franchise> GetFranchiseByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<Franchise>($"/franchises/{id}");
		}

		public async Task<Team> GetTeamByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<Team>($"/teams/{id}");
		}

		public async Task<List<Team>> GetTeamsAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<Team>>($"/teams");
		}

		public async Task<List<Division>> GetDivisionsAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<Division>>($"/divisions");
		}

		public async Task<Division> GetDivisionByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<Division>($"/divisions/{id}");
		}

		public async Task<List<Conference>> GetConferencesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<Conference>>($"/conferences");
		}

		public async Task<Conference> GetConferenceByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<Conference>($"/conferences/{id}");
		}

		public async Task<Player> GetPlayerByIdAsync(int id)
		{
			return await NhlApiHttpClient.GetAsync<Player>($"/people/{id}");
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
		/// Return's the NHL game schedule based on the provided date. If the date is null, it will provide today's current schedule 
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
			if(seasonYear.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			return await NhlApiHttpClient.GetAsync<Season>($"/seasons/{seasonYear}");
		}
	}
}
