using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics;
/// <summary>
/// The returned results of the NHL player statistics summary search with filters
/// </summary>
public class PlayerStatisticsFilterResult
{
    /// <summary>
    /// The NHL player statistics result by summary of statistics for a player and season
    /// </summary>
    [JsonProperty("data")]
    public List<PlayerStatisticsResult> PlayerStatisticsResults { get; set; }

    /// <summary>
    /// The total number of results based on the search criteria <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}

/// <summary>
/// The NHL player statistics result by summary of statistics for a player and season
/// </summary>
public class PlayerStatisticsResult
{
    /// <summary>
    /// The NHL player assists <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The NHL player even strength goals <br/>
    /// Example: 5 or null
    /// </summary>
    [JsonProperty("evGoals")]
    public int? EvenStrengthGoals { get; set; }

    /// <summary>
    /// The NHL player even strength points <br/>
    /// Example: 6 or null
    /// </summary>
    [JsonProperty("evPoints")]
    public int? EvenStrengthPoints { get; set; }

    /// <summary>
    /// The NHL player faceoff win percentage <br/>
    /// Example: 0.543012
    /// </summary>
    [JsonProperty("faceoffWinPct")]
    public decimal? FaceoffWinPercentage { get; set; }

    /// <summary>
    /// The NHL player game winning goals <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary> 
    /// The NHL player games played <br/>
    /// Example: 78
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The NHL player goals <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The NHL player last name <br/>
    /// Example: "Smith"
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The NHL overtime goals <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("otGoals")]
    public int OvertimeGoals { get; set; }

    /// <summary>
    /// The NHL player penalty minutes <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("penaltyMinutes")]
    public int PenaltyMinutes { get; set; }

    /// <summary>
    /// The NHL player player identifier <br/>
    /// Example: 8471234
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL player plus minus <br/>
    /// Example: 5 or null
    /// </summary>
    [JsonProperty("plusMinus")]
    public int? PlusMinus { get; set; }

    /// <summary>
    /// The NHL player points <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL player points per game <br/>
    /// Example: 0.356732
    /// </summary>
    [JsonProperty("pointsPerGame")]
    public decimal PointsPerGame { get; set; }

    /// <summary>
    /// The NHL player position code <br/>
    /// Example: "C"
    /// </summary>
    [JsonProperty("positionCode")]
    public string PositionCode { get; set; }

    /// <summary>
    /// The NHL player power play goals <br/>
    /// Example: 3 or null
    /// </summary>
    [JsonProperty("ppGoals")]
    public int? PowerPlayGoals { get; set; }

    /// <summary>
    /// The NHL player power play points <br/>
    /// Example: 4 or null
    /// </summary>
    [JsonProperty("ppPoints")]
    public int? PowerPlayPoints { get; set; }

    /// <summary>
    /// The NHL player season identifier <br/>
    /// Example: 20202021
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The NHL player short handed goals <br/>
    /// Example: 1 or null
    /// </summary>
    [JsonProperty("shGoals")]
    public int? ShortHandedGoals { get; set; }

    /// <summary>
    /// The NHL player short handed points <br/>
    /// Example: 2 or null
    /// </summary>
    [JsonProperty("shPoints")]
    public int? ShortHandedPoints { get; set; }

    /// <summary>
    /// The NHL player shooting percentage <br/>
    /// Example: 0.1234561 or null
    /// </summary>
    [JsonProperty("shootingPct")]
    public decimal? ShootingPercentage { get; set; }

    /// <summary>
    /// The NHL player shoots catches handedness <br/>
    /// Example: "L"
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The NHL player number of shots <br/>
    /// Example: 100
    /// </summary>
    [JsonProperty("shots")]
    public int? Shots { get; set; }

    /// <summary>
    /// The NHL player skater full name <br/>
    /// Example: "John Smith"
    /// </summary>
    [JsonProperty("skaterFullName")]
    public string SkaterFullName { get; set; }

    /// <summary>
    /// The NHL player team abbreviations <br/>
    /// Example: "TOR"
    /// </summary>
    [JsonProperty("teamAbbrevs")]
    public string TeamAbbreviations { get; set; }

    /// <summary>
    /// The NHL player time on ice per game <br/>
    /// Example: 1234.45
    /// </summary>
    [JsonProperty("timeOnIcePerGame")]
    public decimal? TimeOnIcePerGame { get; set; }


}
