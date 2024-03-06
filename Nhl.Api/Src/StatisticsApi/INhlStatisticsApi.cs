using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;

namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
/// </summary>
public interface INhlStatisticsApi
{
    /// <summary>
    /// Returns the NHL player statistics leaders in the NHL for a specific player statistic type based on the game type and season year 
    /// </summary>
    /// <param name="playerStatisticsType">A player statistics type, <see cref="PlayerStatisticsType"/> for all the types of statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public Task<PlayerStatisticLeaders> GetSkaterStatisticsLeadersAsync(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit = 25, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year 
    /// </summary>
    /// <param name="goalieStatisticsType">A player statistics type, <see cref="GoalieStatisticsType"/> for all the types of statistics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public Task<GoalieStatisticLeaders> GetGoalieStatisticsLeadersAsync(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit = 25, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(TeamEnum team, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(int teamId, string seasonYear, GameType gameType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public Task<List<TeamStatisticsSeason>> GetTeamStatisticsBySeasonAsync(TeamEnum team, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public Task<List<TeamStatisticsSeason>> GetTeamStatisticsBySeasonAsync(int teamId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the total value of a statistic type for a player for a specific season, including face offs won, hits, shots on goal, missed shots, blocked shots, giveaways, penalties and takeaways
    /// </summary>
    /// <param name="playerEnum">The player enumeration identifier, specifying which the NHL player, <see cref="PlayerEnum"/> for more information </param>
    /// <param name="playerGameCenterStatistic">The player game center statistic type, <see cref="PlayerGameCenterStatistic"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>.
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the total value of a statistic type for a player for a specific season, including face offs won, hits, shots on goal, missed shots, blocked shots, giveaways, penalties and takeaways</returns>
    public Task<int> GetTotalPlayerStatisticValueByTypeAndSeasonAsync(PlayerEnum playerEnum, PlayerGameCenterStatistic playerGameCenterStatistic, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the total value of a statistic type for a player for a specific season, including face offs won, hits, shots on goal, missed shots, blocked shots, giveaways, penalties and takeaways
    /// </summary>
    /// <param name="playerId">The NHL player identifier, specifying which the NHL player, Example: 8478402 - Connor McDavid </param>
    /// <param name="playerGameCenterStatistic">The player game center statistic type, <see cref="PlayerGameCenterStatistic"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the total value of a statistic type for a player for a specific season, including face offs won, hits, shots on goal, missed shots, blocked shots, giveaways, penalties and takeaways</returns>
    public Task<int> GetTotalPlayerStatisticValueByTypeAndSeasonAsync(int playerId, PlayerGameCenterStatistic playerGameCenterStatistic, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the all the NHL player game center statistics for a specific player for a specific season
    /// </summary>
    /// <param name="playerId">The NHL player identifier, specifying which the NHL player, Example: 8478402 - Connor McDavid </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the number of total number of a player statistics for a player for a specific season</returns>
    public Task<(PlayerProfile PlayerProfile, Dictionary<PlayerGameCenterStatistic, int> StatisticsTotals)> GetAllTotalPlayerStatisticValuesBySeasonAsync(int playerId, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the all the NHL player game center statistics for a specific player for a specific season
    /// </summary>
    /// <param name="playerEnum">The player enumeration identifier, specifying which the NHL player, <see cref="PlayerEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the number of total number of a player statistics for a player for a specific season</returns>
    public Task<(PlayerProfile PlayerProfile, Dictionary<PlayerGameCenterStatistic, int> StatisticsTotals)> GetAllTotalPlayerStatisticValuesBySeasonAsync(PlayerEnum playerEnum, string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the all the NHL players game center statistics for the entire NHL league for a specific season and game type
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns>Returns the all the NHL player statistics for all of a players for a specific season</returns>
    public Task<Dictionary<PlayerProfile, Dictionary<PlayerGameCenterStatistic, int>>> GetAllPlayersStatisticValuesBySeasonAsync(string seasonYear, GameType? gameType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL player game center statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionPlayerFilter">The expression player filter to filter the player statistics by, see <see cref="PlayerFilterExpressionBuilder"/> for more information on valid player filters</param>
    /// <param name="playerStatisticsFilterToSortBy">The player statistics filter to sort the player statistics by, see <see cref="PlayerStatisticsFilter"/> for more information on valid player statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL player statistics</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns> Returns all the NHL player game center statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more </returns>
    public Task<PlayerStatisticsFilterResult> GetPlayerStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionPlayerFilter expressionPlayerFilter, PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points, int limit = -1, int offsetStart = 0, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all the NHL goalie statistics for a specific player for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more
    /// </summary>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="expressionGoalieFilter">The expression goalie filter to filter the goalie statistics by, see <see cref="GoalieFilterExpressionBuilder"/> for more information on valid goalie filters</param>
    /// <param name="goalieStatisticsFilterToSortBy">The goalie statistics filter to sort the goalie statistics by, see <see cref="GoalieStatisticsFilter"/> for more information on valid goalie statistics filters</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player statistics, by default -1 represents no limit applied to results</param>
    /// <param name="offsetStart">The offset to start the results from when reviewing the NHL goalie statistics</param>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation</param>
    /// <returns> Returns all the NHL goalie statistics for a specific goalie for a specific season including face off percentage, points per game, overtime goals, short handed points , power play points, shooting percentage, shots, time on ice per game and more </returns>
    public Task<GoalieStatisticsFilterResult> GetGoalieStatisticsBySeasonAndFilterExpressionAsync(string seasonYear, ExpressionGoalieFilter expressionGoalieFilter, GoalieStatisticsFilter goalieStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins, int limit = -1, int offsetStart = 0, CancellationToken cancellationToken = default);

}
