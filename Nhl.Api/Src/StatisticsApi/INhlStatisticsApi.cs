using System.Collections.Generic;
using System.Threading.Tasks;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
    /// </summary>
    public interface INhlStatisticsApi
    {

        /// <summary>
        /// Returns all distinct types of NHL statistics types
        /// </summary>
        /// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
        Task<List<StatisticTypes>> GetStatisticTypesAsync();

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: Toronto Maple Leafs - 10</param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear);

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        Task<TeamStatistics> GetTeamStatisticsByIdAsync(TeamEnum team, string seasonYear);

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(int teamId, string seasonYear);

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/>, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="seasonYear">A season year for the all the NHL statistics, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(TeamEnum team, string seasonYear);

        /// <summary>
        /// Returns all of the NHL team's statistics for the specific NHL season
        /// </summary>
        /// <param name="seasonYear">A season year for the all the NHL statistics, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        Task<TeamSeasonStatistics> GetAllTeamsStatisticsBySeasonAsync(string seasonYear);

        /// <summary>
        /// Returns all of the NHL player statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(int playerId, string seasonYear);

        /// <summary>
        /// Returns all of the NHL player statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(PlayerEnum player, string seasonYear);

        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <returns>Returns the player profile with the top player statistic in the specified NHL season</returns>
        Task<PlayerStatisticResult> GetPlayerWithTopStatisticBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear);

        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>Returns the goalie profile with the top player statistic in the specified NHL season</returns>
        Task<GoalieStatisticResult> GetGoalieWithTopStatisticBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear);

        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(PlayerEnum player);

        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(int playerId);

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(int playerId, string seasonYear);

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(PlayerEnum player, string seasonYear);
    }
}
