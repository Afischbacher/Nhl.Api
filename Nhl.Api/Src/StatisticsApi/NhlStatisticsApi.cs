using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Http;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Services;
using System;
using System.Threading.Tasks;

namespace Nhl.Api;

/// <summary>
/// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
/// </summary>
public class NhlStatisticsApi : INhlStatisticsApi
{
    private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
    private static readonly INhlPlayerApi _nhlPlayerApi = new NhlPlayerApi();
    private static readonly INhlTeamService _nhlTeamService = new NhlTeamService();
    private static readonly INhlApiHttpClient _nhlApiWebHttpClient = new NhlApiWebHttpClient();

    /// <summary>
    /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
    /// </summary>
    public NhlStatisticsApi()
    {

    }

    /// <summary>
    /// Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year 
    /// </summary>
    /// <param name="goalieStatisticsType">A player statistics type, <see cref="GoalieStatisticsType"/> for all the types of statisitics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player sta</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public async Task<GoalieStatisticLeaders> GetGoalieStatsisticsLeadersAsync(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit = 25)
    {
        if (string.IsNullOrEmpty(seasonYear))
        {
            throw new ArgumentException("A season year must be provided to retrieve the NHL player statistics leaders for");
        }

        if (seasonYear.Length != 8)
        {
            throw new ArgumentException("The season year must be 8 digits in length");
        }

        if (limit < 1)
        {
            throw new ArgumentException("The limit must be more than or equal to 1");
        }

        return await _nhlApiWebHttpClient.GetAsync<GoalieStatisticLeaders>($"/goalie-stats-leaders/{seasonYear}/{(int)gameType}?categories={goalieStatisticsType.GetEnumMemberValue()}&limit={limit}");
    }

    /// <summary>
    /// Returns the current NHL player statistics leaders in the NHL for a specific player statistic type
    /// </summary>
    /// <param name="playerStatisticsType">A player statistics type, <see cref="PlayerStatisticsType"/> for all the types of statisitics</param>
    /// <param name="seasonYear">The NHL season year to retrieve the player statistics leaders for, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the player statistics leaders for, see <see cref="GameType"/> for more information on valid game types</param>
    /// <param name="limit">The limit to the number of results returned when reviewing the NHL player sta</param>
    /// <returns> Returns the current NHL player statistics leaders in the NHL for a specific player statistic type </returns>
    public async Task<PlayerStatisticLeaders> GetSkaterStatsisticsLeadersAsync(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit = 25)
    {
        if (string.IsNullOrEmpty(seasonYear))
        {
            throw new ArgumentException("A season year must be provided to retrieve the NHL player statistics leaders for");
        }

        if (seasonYear.Length != 8)
        {
            throw new ArgumentException("The season year must be 8 digits in length");
        }

        if (limit < 1)
        {
            throw new ArgumentException("The limit must be more than or equal to 1");
        }

        return await _nhlApiWebHttpClient.GetAsync<PlayerStatisticLeaders>($"/skater-stats-leaders/{seasonYear}/{(int)gameType}?categories={playerStatisticsType.GetEnumMemberValue()}&limit={limit}");
    }

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public async Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(TeamEnum team, string seasonYear, GameType gameType)
    {
        var teamAbbreviaton = _nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team);
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonStatistics>($"/club-stats/{teamAbbreviaton}/{seasonYear}/{(int)gameType}");
    }

    /// <summary>
    /// Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <param name="seasonYear">The NHL season year to retrieve the team statistics, see <see cref="SeasonYear"/> for more information on valid season years</param>
    /// <param name="gameType">The NHL game type to retrieve the team statistics, see <see cref="GameType"/> for more information on valid game types</param>
    /// <returns>The NHL team season statistics for the specified season and game type</returns>
    public async Task<TeamSeasonStatistics> GetTeamStatisticsBySeasonAndGameTypeAsync(int teamId, string seasonYear, GameType gameType)
    {
        var teamAbbreviaton = _nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId);
        return await _nhlApiWebHttpClient.GetAsync<TeamSeasonStatistics>($"/club-stats/{teamAbbreviaton}/{seasonYear}/{(int)gameType}");
    }

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="team">The team enumeration identifier, specifying which the NHL team, <see cref="TeamEnum"/> for more information </param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public async Task<TeamStatisticsSeason> GetTeamStatisticsBySeasonAsync(TeamEnum team)
    {
        var teamAbbreviaton = _nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team);
        return await _nhlApiWebHttpClient.GetAsync<TeamStatisticsSeason>($"/club-stats-season/{teamAbbreviaton}");
    }

    /// <summary>
    /// Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team 
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns> Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team </returns>
    public async Task<TeamStatisticsSeason> GetTeamStatisticsBySeasonAsync(int teamId)
    {
        var teamAbbreviaton = _nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId);
        return await _nhlApiWebHttpClient.GetAsync<TeamStatisticsSeason>($"/club-stats-season/{teamAbbreviaton}");
    }
}
