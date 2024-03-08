using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics;

/// <summary>
/// The returned results of the NHL goalie statistics summary search with filters
/// </summary>
public class GoalieStatisticsFilterResult
{
    /// <summary>
    /// The NHL goalie statistics result by summary of statistics for a goalie and season
    /// </summary>
    [JsonProperty("data")]
    public List<GoalieStatisticsResult> GoalieStatisticsResults { get; set; }

    /// <summary>
    /// The total number of results based on the search criteria <br/>
    /// Example: 42
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}

/// <summary>
/// The NHL goalie statistics result by summary of statistics for a goalie and season
/// </summary>
public class GoalieStatisticsResult
{
    /// <summary>
    /// The number of assists made by the NHL goalie in the season. <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of games played by the NHL goalie in the season. <br/>
    /// Example: 42
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of games started by the NHL goalie in the season. <br/>
    /// Example: 42
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int GamesStarted { get; set; }

    /// <summary>
    /// The full name of the NHL goalie. <br/>
    /// Example: "Connor Hellebuyck"
    /// </summary>
    [JsonProperty("goalieFullName")]
    public string GoalieFullName { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL goalie in the season. <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of goals scored against the NHL goalie in the season. <br/>
    /// Example: 102
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary> 
    /// The average number of goals scored against the NHL goalie per game in the season. <br/>
    /// Example: 2.21119
    /// </summary>
    [JsonProperty("goalsAgainstAverage")]
    public double GoalsAgainstAverage { get; set; }

    /// <summary>
    /// The last name of the NHL goalie <br/>
    /// Example: "Hellebuyck"
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The number of losses by the NHL goalie in the season <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The number of losses in overtime by the NHL goalie in the season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("otLosses")]
    public int OvertimeLosses { get; set; }

    /// <summary>
    /// The total number of penalty minutes served by the NHL goalie in the season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("penaltyMinutes")]
    public int PenaltyMinutes { get; set; }

    /// <summary>
    /// The unique identifier of the NHL goalie <br/>
    /// Example: 8479973
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The total number of points earned by the NHL goalie in the season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The percentage of shots saved by the NHL goalie in the season <br/>
    /// Example: 0.91711
    /// </summary>
    [JsonProperty("savePct")]
    public double SavePercentage { get; set; }

    /// <summary>
    /// The total number of saves made by the NHL goalie in the season <br/>
    /// Example: 102
    /// </summary>
    [JsonProperty("saves")]
    public int Saves { get; set; }

    /// <summary>
    /// The identifier of the season for which the statistics are recorded <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// Indicates whether the NHL goalie catches with the left or right hand <br/>
    /// Example: "L"
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The total number of shots faced by the NHL goalie in the season <br/>
    /// Example: 1342
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int ShotsAgainst { get; set; }

    /// <summary>
    /// The total number of shutouts recorded by the NHL goalie in the season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The abbreviated name of the team the NHL goalie plays for <br/>
    /// Example: "TOR, CGY"
    /// </summary>
    [JsonProperty("teamAbbrevs")]
    public string TeamAbbreviations { get; set; }

    /// <summary>
    /// The number of ties recorded by the NHL goalie in the season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("ties")]
    public object? Ties { get; set; }

    /// <summary>
    /// The total time on ice for the NHL goalie in the season, in seconds <br/>
    /// Example: 50591
    /// </summary>
    [JsonProperty("timeOnIce")]
    public int TimeOnIce { get; set; }

    /// <summary>
    /// The number of wins recorded by the NHL goalie in the season <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }
}
