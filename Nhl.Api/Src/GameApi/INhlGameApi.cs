using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;

namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
/// </summary>
public interface INhlGameApi
{

    /// <summary>
    /// Returns all of the individual shifts of each NHL player for a specific NHL game id
    /// </summary>
    /// <param name="gameId">The game id, Example: 2021020087</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
    public Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(int teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(TeamEnum team, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(int teamId, int month, int year, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(TeamEnum team, int month, int year, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="date">The date, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(int teamId, DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="date">The date, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(TeamEnum team, DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more
    /// </summary>
    /// <param name="date">The date, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more</returns>
    public Task<GameScore> GetGameScoresByDateAsync(DateOnly date, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the live NHL game scoreboard, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the live NHL game scoreboard, including the game information, game status, game venue and more</returns>
    public Task<GameScoreboard> GetGameScoreboardAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public Task<GameCenterPlayByPlay> GetGameCenterPlayByPlayByGameIdAsync(int gameId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public Task<GameCenterLanding> GetGameCenterLandingByGameIdAsync(int gameId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more</returns>
    public Task<GameCenterBoxScore> GetGameCenterBoxScoreByGameIdAsync(int gameId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL game meta data for the specified game id, including the teams, season states and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game meta data for the specified game id, including the teams, season states and more</returns>
    public Task<GameMetadata> GetGameMetadataByGameIdAsync(int gameId, CancellationToken cancellationToken = default);
}
