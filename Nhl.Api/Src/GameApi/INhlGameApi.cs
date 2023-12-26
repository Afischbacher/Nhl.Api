using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;
using System;
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

        /// <summary>
        /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
        /// </summary>
        /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
        /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
        Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(int teamId);

        /// <summary>
        /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
        /// </summary>
        /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
        /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
        Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(TeamEnum team);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and season year
        /// </summary>
        /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
        /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
        /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(int teamId, string seasonYear);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and season year
        /// </summary>
        /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
        /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
        /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(TeamEnum team, string seasonYear);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and season year and month
        /// </summary>
        /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
        /// <param name="year">The year, Example: 2020</param>
        /// <param name="month">The month, Example: 10</param>
        /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(int teamId, int month, int year);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and season year and month
        /// </summary>
        /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
        /// <param name="year">The year, Example: 2020</param>
        /// <param name="month">The month, Example: 10</param>
        /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(TeamEnum team, int month, int year);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and the specified date and time
        /// </summary>
        /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
        /// <param name="dateTime">The date and time, Example: 2020-10-02T00:00:00Z</param>
        /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleByDateTimeAsync(int teamId, DateTime dateTime);

        /// <summary>
        /// Returns the NHL team schedule for the specified team and the specified date and time
        /// </summary>
        /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
        /// <param name="dateTime">The date and time, Example: 2020-10-02T00:00:00Z</param>
        /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
        Task<TeamSeasonSchedule> GetTeamSeasonScheduleByDateTimeAsync(TeamEnum team, DateTime dateTime);
    }
}
