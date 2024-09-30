using Nhl.Api.Services;

namespace Nhl.Api;
/// <summary>
/// The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more
/// </summary>
public class NhlGameApi : INhlGameApi
{
    private static readonly NhlShiftChartHttpClient _nhlShiftChartHttpClient = new();
    private static readonly NhlApiWebHttpClient _nhlApiWebHttpClient = new();
    private static readonly NhlTeamService _nhlTeamService = new();

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
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(TeamEnum team, CancellationToken cancellationToken = default)
    {
        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team);
        return await _nhlApiWebHttpClient.GetAsync<TeamScoreboard>($"/scoreboard/{teamAbbreviation}/now", cancellationToken);
    }

    /// <summary>
    /// Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores</returns>
    public async Task<TeamScoreboard> GetCurrentTeamScoreboardAsync(int teamId, CancellationToken cancellationToken = default)
    {
        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId);
        return await _nhlApiWebHttpClient.GetAsync<TeamScoreboard>($"/scoreboard/{teamAbbreviation}/now", cancellationToken);
    }

    /// <summary>
    /// Returns all of the individual shifts of each NHL player for a specific NHL game id
    /// </summary>
    /// <param name="gameId">The game id, Example: 2021020087</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
    public async Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId, CancellationToken cancellationToken = default) =>
         await _nhlShiftChartHttpClient.GetAsync<LiveGameFeedPlayerShifts>($"?cayenneExp=gameId={gameId}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="date">The date and time, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(int teamId, DateOnly date, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}/week/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and the specified date and time
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="date">The date and time, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and the specified date and time</returns>
    public async Task<TeamSeasonSchedule> GetTeamWeekScheduleByDateAsync(TeamEnum team, DateOnly date, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team)}/week/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule-season/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}/{seasonYear}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="seasonYear">The season year, see <see cref="SeasonYear"/> for more information, Example: 20202021</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule-season/{_nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team)}/{seasonYear}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="teamId">The team identifier, Example: 10 - Toronto Maples Leafs</param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(int teamId, int month, int year, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}/month/{year}-{month}", cancellationToken);

    /// <summary>
    /// Returns the NHL team schedule for the specified team and season year and month
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 54 - Vegas Golden Knights </param>
    /// <param name="year">The year, Example: 2020</param>
    /// <param name="month">The month, Example: 10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team schedule for the specified team and season year and month</returns>
    public async Task<TeamSeasonSchedule> GetTeamSeasonScheduleByYearAndMonthAsync(TeamEnum team, int month, int year, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<TeamSeasonSchedule>($"/club-schedule/{_nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team)}/month/{year}-{month}", cancellationToken);

    /// <summary>
    /// Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more
    /// </summary>
    /// <param name="date">The date for the requested game scores, Example: 2020-10-02</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more</returns>
    public async Task<GameScore> GetGameScoresByDateAsync(DateOnly date, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<GameScore>($"/score/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the live NHL game scoreboard, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the live NHL game scoreboard, including the game information, game status, game venue and more</returns>
    public async Task<GameScoreboard> GetGameScoreboardAsync(CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<GameScoreboard>("/scoreboard/now", cancellationToken);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterPlayByPlay> GetGameCenterPlayByPlayByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<GameCenterPlayByPlay>($"/gamecenter/{gameId}/play-by-play", cancellationToken);

    /// <summary>
    /// Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterLanding> GetGameCenterLandingByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<GameCenterLanding>($"/gamecenter/{gameId}/landing", cancellationToken);

    /// <summary>
    /// Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more</returns>
    public async Task<GameCenterBoxScore> GetGameCenterBoxScoreByGameIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var boxScoreTask = _nhlApiWebHttpClient.GetAsync<Boxscore>($"/gamecenter/{gameId}/right-rail", cancellationToken);
        var gameCenterBoxScoreTask = _nhlApiWebHttpClient.GetAsync<GameCenterBoxScore>($"/gamecenter/{gameId}/boxscore", cancellationToken);

        await Task.WhenAll(gameCenterBoxScoreTask, boxScoreTask);

        var gameCenterBoxScore = await gameCenterBoxScoreTask;

        // We manually assign the boxscore to the object as the NHL API has moved the boxscore to a different endpoint
        gameCenterBoxScore.Boxscore = await boxScoreTask;

        return gameCenterBoxScore;
    }

    /// <summary>
    /// Returns the NHL game direct box score including information such as summaries, linescores, shots by period and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game direct box score including information such as summaries, linescores, shots by period and more</returns>
    public async Task<Boxscore> GetBoxscoreByGameIdAsync(int gameId, CancellationToken cancellationToken = default) => await _nhlApiWebHttpClient.GetAsync<Boxscore>($"/gamecenter/{gameId}/right-rail", cancellationToken);

    /// <summary>
    /// Returns the NHL game meta data for the specified game id, including the teams, season states and more
    /// </summary>
    /// <param name="gameId">The NHL game identifier, Example: 2023020204 </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL game meta data for the specified game id, including the teams, season states and more</returns>
    public async Task<GameMetadata> GetGameMetadataByGameIdAsync(int gameId, CancellationToken cancellationToken = default) =>
         await _nhlApiWebHttpClient.GetAsync<GameMetadata>($"/meta/game/{gameId}", cancellationToken);
}
