using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using System.Threading.Tasks;

namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
/// </summary>
public interface INhlStatisticsApi
{
    /// <summary>
    /// Returns the NHL player statistics leaders in the NHL for a specific player statistic type based on the game type and season year 
    /// </summary>
    /// <param name="playerStatisticsType">A player statistics type, <see cref="PlayerStatisticsType"/> for all the types of statisitics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player sta</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    Task<PlayerStatisticLeaders> GetSkaterStatsisticsLeadersAsync(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit = 25);

    /// <summary>
    /// Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year 
    /// </summary>
    /// <param name="goalieStatisticsType">A player statistics type, <see cref="GoalieStatisticsType"/> for all the types of statisitics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player sta</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    Task<GoalieStatisticLeaders> GetGoalieStatsisticsLeadersAsync(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit = 25);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(TeamEnum team, string seasonYear, GameType gameType);

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(int teamId, string seasonYear, GameType gameType);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    Task<TeamStatisticsSeason> GetTeamStatisticsBySeasonAsync(TeamEnum team);

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    Task<TeamStatisticsSeason> GetTeamStatisticsBySeasonAsync(int teamId);
}
