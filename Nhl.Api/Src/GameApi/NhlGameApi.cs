using Nhl.Api.Common.Exceptions;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
    /// </summary>
    public class NhlGameApi : INhlGameApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlApiHttpClient _nhlShiftChartHttpClient = new NhlShiftChartHttpClient();
        private static readonly INhlLeagueApi _nhlLeagueApi = new NhlLeagueApi();
        private static readonly INhlGameService _nhlGameService = new NhlGameService();

        /// <summary>
        /// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
        /// </summary>
        public NhlGameApi()
        {

        }

        /// <summary>
        /// Returns all of the individual shifts of each NHL player for a specific NHL game id
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
        public async Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId)
        {
            return await _nhlShiftChartHttpClient.GetAsync<LiveGameFeedPlayerShifts>($"?cayenneExp=gameId={gameId}");
        }
    }
}
