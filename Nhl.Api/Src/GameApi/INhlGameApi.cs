using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Season;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
    /// </summary>
    public interface INhlGameApi
    {

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
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        Task<GameSchedule> GetGameScheduleForTeamByDateAsync(TeamEnum team, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 1</param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        Task<GameSchedule> GetGameScheduleForTeamByDateAsync(int teamId, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Returns the live game feed content for an NHL game
        /// </summary>
        /// <param name="gameId">The live game feed id, Example: 2021020087</param>
        /// <returns>A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more</returns>
        Task<LiveGameFeedResult> GetLiveGameFeedByIdAsync(int gameId);

        /// <summary>
        /// Returns the line score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, strength of the play, time remaining, shots on goal and more</returns>
        Task<Linescore> GetLineScoreByIdAsync(int gameId);

        /// <summary>
        /// Returns the box score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, penalties, players, team statistics and more</returns>
        Task<Boxscore> GetBoxScoreByIdAsync(int gameId);

        /// <summary>
        /// Return's the entire collection of NHL game schedules for the specified season
        /// </summary>
        /// <param name="seasonYear">The NHL season year, Example: 19992000, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="includePlayoffGames">Includes the NHL playoff games if set to true, default value is false</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected NHL season</returns>
        Task<GameSchedule> GetGameSchedulesBySeasonAsync(string seasonYear, bool includePlayoffGames = false);
    }
}
