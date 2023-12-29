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
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateTimeAsync(int teamId, DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateTimeAsync(TeamEnum team, DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more
    /// </summary>
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more</returns>
    Task<GameScore> GetGameScoresByDateTimeAsync(DateTimeOffset dateTimeOffset);

    /// <summary>
    /// Returns the live NHL game scoreboard, including the game information, game status, game venue and more
    /// </summary>
    /// <returns>Returns the live NHL game scoreboard, including the game information, game status, game venue and more</returns>
    Task<GameScoreboard> GetGameScoreboardAsync();

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    Task<GameCenterPlayByPlay> GetGameCenterPlayByPlayByGameIdAsync(int gameId);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns> Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    Task<GameCenterLanding> GetGameCenterLandingByGameIdAsync(int gameId);

    /// <summary>
    /// Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more</returns>
    Task<GameCenterBoxScore> GetGameCenterBoxScoreByGameIdAsync(int gameId);

    /// <summary>
    /// Returns the NHL game metadata for the specified game id, including the teams, season states and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game metadata for the specified game id, including the teams, season states and more</returns>
    Task<GameMetadata> GetGameMetadataByGameIdAsync(int gameId);
}
