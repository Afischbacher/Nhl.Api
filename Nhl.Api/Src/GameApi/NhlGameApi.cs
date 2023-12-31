using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;
using Nhl.Api.Services;

namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
/// </summary>
public class NhlGameApi : INhlGameApi
{
    private static readonly INhlApiHttpClient _nhlShiftChartHttpClient = new NhlShiftChartHttpClient();
    private static readonly INhlApiHttpClient _nhlApiWebHttpClient = new NhlApiWebHttpClient();
    private static readonly INhlTeamService _nhlTeamService = new NhlTeamService();
    /// <summary>
    /// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
    /// </summary>
    public NhlGameApi()
    {

    }

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(TeamEnum team)
    {
        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team);
        return await _nhlApiWebHttpClient.GetAsync<TeamScoreboard>($"/scoreboard/{teamAbbreviation}/now");
    }

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(int teamId)
    {
        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId);
        return await _nhlApiWebHttpClient.GetAsync<TeamScoreboard>($"/scoreboard/{teamAbbreviation}/now");
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

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateTimeAsync(int teamId, DateTimeOffset dateTimeOffset)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}/week/{dateTimeOffset:yyyy-MM-dd}");
    }

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateTimeAsync(TeamEnum team, DateTimeOffset dateTimeOffset)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team)}/week/{dateTimeOffset:yyyy-MM-dd}");
    }

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(int teamId, string seasonYear)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule-season/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}/{seasonYear}");
    }

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(TeamEnum team, string seasonYear)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule-season/{_nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team)}/{seasonYear}");
    }

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(int teamId, int month, int year)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}/month/{year}-{month}");
    }

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(TeamEnum team, int month, int year)
    {
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team)}/month/{year}-{month}");
    }

    /// <summary>
    /// Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more
    /// </summary>
    /// <param name="dateTimeOffset">The date and time, Example: 2020-10-02T00:00:00Z</param>
    /// <returns>Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more</returns>
    public async Task<GameScore> GetGameScoresByDateTimeAsync(DateTimeOffset dateTimeOffset)
    {
        return await _nhlApiWebHttpClient.GetAsync<GameScore>($"/score/{dateTimeOffset:yyyy-MM-dd}");
    }

    /// <summary>
    /// Returns the live NHL game scoreboard, including the game information, game status, game venue and more
    /// </summary>
    /// <returns>Returns the live NHL game scoreboard, including the game information, game status, game venue and more</returns>
    public async Task<GameScoreboard> GetGameScoreboardAsync()
    {
        return await _nhlApiWebHttpClient.GetAsync<GameScoreboard>("/scoreboard/now");
    }

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterPlayByPlay> GetGameCenterPlayByPlayByGameIdAsync(int gameId)
    {
        return await _nhlApiWebHttpClient.GetAsync<GameCenterPlayByPlay>($"/gamecenter/{gameId}/play-by-play");
    }

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns> Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterLanding> GetGameCenterLandingByGameIdAsync(int gameId)
    {
        return await _nhlApiWebHttpClient.GetAsync<GameCenterLanding>($"/gamecenter/{gameId}/landing");
    }

    /// <summary>
    /// Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterBoxScore> GetGameCenterBoxScoreByGameIdAsync(int gameId)
    {
        return await _nhlApiWebHttpClient.GetAsync<GameCenterBoxScore>($"/gamecenter/{gameId}/boxscore");
    }

    /// <summary>
    /// Returns the NHL game metadata for the specified game id, including the teams, season states and more
    /// </summary>
    /// <param name="gameId">The NHL game identfier, Example: 2023020204 </param>
    /// <returns>Returns the NHL game metadata for the specified game id, including the teams, season states and more</returns>
    public async Task<GameMetadata> GetGameMetadataByGameIdAsync(int gameId)
    {
        return await _nhlApiWebHttpClient.GetAsync<GameMetadata>($"/meta/game/{gameId}");
    }
}
