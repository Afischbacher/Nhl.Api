using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Season;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// NHL Game API
    /// </summary>
    public class NhlGameApi : INhlGameApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();

        /// <summary>
        /// Returns the box score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, penalties, players, team statistics and more</returns>
        public async Task<Boxscore> GetBoxScoreByIdAsync(int gameId)
        {
            return await _nhlStatsApiHttpClient.GetAsync<Boxscore>($"/game/{gameId}/boxscore");
        }

        /// <summary>
        /// Return's today's the NHL game schedule and it will provide today's current NHL game schedule 
        /// </summary>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>("/schedule");
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
        /// </summary>
        /// <param name="date">The requested date for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(DateTime? date)
        {
            var httpRequestUri = date.HasValue ? $"/schedule?date={date.Value:yyyy-MM-dd}" : "/schedule";
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>(httpRequestUri);
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided year, month and day
        /// </summary>
        /// <param name="year">The requested year for the NHL game schedule</param>
        /// <param name="month">The requested month for the NHL game schedule</param>
        /// <param name="day">The requested day for the NHL game schedule</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more infGetGameScheduleByDateAsyncormation</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(int year, int month, int day)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?date={year}-{month}-{day}");
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(TeamEnum team, DateTime startDate, DateTime endDate)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?teamId={(int)team}&startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 1</param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(int teamId, DateTime startDate, DateTime endDate)
        {
            return await _nhlStatsApiHttpClient.GetAsync<GameSchedule>($"/schedule?teamId={teamId}&startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
        }

        /// <summary>
        /// Returns all of the valid NHL game statuses of an NHL game
        /// </summary>
        /// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
        public async Task<List<GameStatus>> GetGameStatusesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<GameStatus>>($"/gameStatus");
        }

        /// <summary>
        /// Returns all of the NHL game types within a season and within special events
        /// </summary>
        /// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
        public async Task<List<GameType>> GetGameTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<GameType>>($"/gameTypes");
        }

        /// <summary>
        /// Returns the line score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, strength of the play, time remaining, shots on goal and more</returns>
        public async Task<Linescore> GetLineScoreByIdAsync(int gameId)
        {
            return await _nhlStatsApiHttpClient.GetAsync<Linescore>($"/game/{gameId}/linescore");
        }

        /// <summary>
        /// Returns the live game feed content for an NHL game
        /// </summary>
        /// <param name="liveGameFeedId">The live game feed id, Example: 2021020087</param>
        /// <returns>A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more</returns>
        public async Task<LiveGameFeedResult> GetLiveGameFeedByIdAsync(int liveGameFeedId)
        {
            var liveGameFeed = await _nhlStatsApiHttpClient.GetAsync<LiveGameFeed>($"/game/{liveGameFeedId}/feed/live");

            return new LiveGameFeedResult
            {
                LiveGameFeed = liveGameFeed
            };
        }

        /// <summary>
        /// Returns a collection of all the different types of playoff tournaments in the NHL 
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
        public async Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<PlayoffTournamentType>($"/tournaments/playoffs");
        }

        /// <summary>
        /// Returns a collection of all the play types within the duration of an NHL game
        /// </summary>
        /// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
        public async Task<List<PlayType>> GetPlayTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<PlayType>>($"/playTypes");
        }

        /// <summary>
        /// Returns a collection of all the different types of tournaments in the hockey
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
        public async Task<List<TournamentType>> GetTournamentTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<TournamentType>>($"/tournamentTypes");
        }
    }
}
