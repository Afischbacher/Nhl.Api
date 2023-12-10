using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
    /// </summary>
    public interface INhlGameApi
    {
       
        /// <summary>
        /// Returns all of the individual shifts of each NHL player for a specific NHL game id
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
        Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId);

    }
}
