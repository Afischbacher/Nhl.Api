using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player;

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
    /// The total number of results based on the search criteria
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
    /// The NHL player assists
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The NHL player even strength goals
    /// </summary>
    [JsonProperty("evGoals")]
    public int EvenStrengthGoals { get; set; }

    /// <summary>
    /// The NHL player even strength points
    /// </summary>
    [JsonProperty("evPoints")]
    public int EvenStrengthPoints { get; set; }

    /// <summary>
    /// The NHL player faceoff win percentage
    /// </summary>
    [JsonProperty("faceoffWinPct")]
    public decimal? FaceoffWinPercentage { get; set; }

    /// <summary>
    /// The NHL player game winning goals
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary>
    /// The NHL player games played
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The NHL player goals
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The NHL player last name
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The NHL overtime goals
    /// </summary>
    [JsonProperty("otGoals")]
    public int OvertimeGoals { get; set; }

    /// <summary>
    /// The NHL player penalty minutes
    /// </summary>
    [JsonProperty("penaltyMinutes")]
    public int PenaltyMinutes { get; set; }

    /// <summary>
    /// The NHL player player identifier
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL player plus minus
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The NHL player points
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL player points per game
    /// </summary>
    [JsonProperty("pointsPerGame")]
    public double PointsPerGame { get; set; }

    /// <summary>
    /// The NHL player position code
    /// </summary>
    [JsonProperty("positionCode")]
    public string PositionCode { get; set; }

    /// <summary>
    /// The NHL player power play goals
    /// </summary>
    [JsonProperty("ppGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The NHL player power play points
    /// </summary>
    [JsonProperty("ppPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The NHL player season identifier
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The NHL player short handed goals
    /// </summary>
    [JsonProperty("shGoals")]
    public int ShortHandedGoals { get; set; }

    /// <summary>
    /// The NHL player short handed points
    /// </summary>
    [JsonProperty("shPoints")]
    public int ShortHandedPoints { get; set; }

    /// <summary>
    /// The NHL player shooting percentage
    /// </summary>
    [JsonProperty("shootingPct")]
    public decimal? ShootingPercentage { get; set; }

    /// <summary>
    /// The NHL player shoots catches handedness
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The NHL player number of shots
    /// </summary>
    [JsonProperty("shots")]
    public int? Shots { get; set; }

    /// <summary>
    /// The NHL player skater full name
    /// </summary>
    [JsonProperty("skaterFullName")]
    public string SkaterFullName { get; set; }

    /// <summary>
    /// The NHL player team abbreviation    
    /// </summary>
    [JsonProperty("teamAbbrevs")]
    public string TeamAbbreviation { get; set; }

    /// <summary>
    /// The NHL player time on ice per game
    /// </summary>
    [JsonProperty("timeOnIcePerGame")]
    public decimal? TimeOnIcePerGame { get; set; }
}
