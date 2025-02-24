using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics;
/// <summary>
/// The NHL team statistic details
/// </summary>
public class TeamStatisticsDetails
{

    /// <summary>
    /// The number of games played in the NHL in the current season
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of wins in the NHL in the current season
    /// </summary>
    [JsonProperty("wins")]
    public required string Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("losses")]
    public required string Losses { get; set; }

    /// <summary>
    /// The number of over time games in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("ot")]
    public required string Ot { get; set; }

    /// <summary>
    /// The number of league points in the NHL in the current season by rank in place and by numerical value
    /// </summary> 
    [JsonProperty("pts")]
    public required string Points { get; set; }

    /// <summary>
    /// The point percentage in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("ptPctg")]
    public required string PtPctg { get; set; }

    /// <summary>
    /// The number of goals per game both by rank in place and by numerical value as an average
    /// </summary>
    [JsonProperty("goalsPerGame")]
    public required string GoalsPerGame { get; set; }

    /// <summary>
    /// The number of goals against per game both by rank in place and by numerical value
    /// </summary>
    [JsonProperty("goalsAgainstPerGame")]
    public required string GoalsAgainstPerGame { get; set; }

    /// <summary>
    /// The number of goals against ratio per game both by rank in place and by numerical value
    /// </summary>
    [JsonProperty("evGGARatio")]
    public required string EvGGARatio { get; set; }

    /// <summary>
    /// The power play percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayPercentage")]
    public required string PowerPlayPercentage { get; set; }

    /// <summary>
    /// The power play goals by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public required string PowerPlayGoals { get; set; }

    /// <summary>
    /// The power play goals against by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayGoalsAgainst")]
    public required string PowerPlayGoalsAgainst { get; set; }

    /// <summary>
    /// The power play opportunities by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayOpportunities")]
    public required string PowerPlayOpportunities { get; set; }

    /// <summary>
    /// The penalty kill percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("penaltyKillPercentage")]
    public required string PenaltyKillPercentage { get; set; }

    /// <summary>
    /// The shots per game by rank in place and by numerical value
    /// </summary>
    [JsonProperty("shotsPerGame")]
    public required string ShotsPerGame { get; set; }

    /// <summary>
    /// The shots allowed per game by rank in place and by numerical value
    /// </summary>
    [JsonProperty("shotsAllowed")]
    public required string ShotsAllowed { get; set; }

    /// <summary>
    /// The chance of winning based on who scores first by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winScoreFirst")]
    public required string WinScoreFirst { get; set; }

    /// <summary>
    /// The chance of winning based on who scores first by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOppScoreFirst")]
    public required string WinOppScoreFirst { get; set; }

    /// <summary>
    /// The chance of winning a lead first by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winLeadFirstPer")]
    public required string WinLeadFirstPer { get; set; }

    /// <summary>
    /// The chance of winning a lead second by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winLeadSecondPer")]
    public required string WinLeadSecondPer { get; set; }

    /// <summary>
    /// The winning of a shootout by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOutshootOpp")]
    public required string WinOutshootOpp { get; set; }

    /// <summary>
    /// The winning of a shootout by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOutshotByOpp")]
    public required string WinOutshotByOpp { get; set; }

    /// <summary>
    /// The amount of face-offs taken by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsTaken")]
    public required string FaceOffsTaken { get; set; }

    /// <summary>
    /// The number of face-offs won by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsWon")]
    public required string FaceOffsWon { get; set; }

    /// <summary>
    /// The number of face-offs lost by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsLost")]
    public required string FaceOffsLost { get; set; }

    /// <summary>
    /// The face-off win percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffWinPercentage")]
    public required string FaceOffWinPercentage { get; set; }

    /// <summary>
    /// The shooting percentage by numerical value
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal ShootingPctg { get; set; }

    /// <summary>
    /// The save percentage by numerical value
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The number of penalty kill opportunities by rank
    /// </summary>
    [JsonProperty("penaltyKillOpportunities")]
    public required string PenaltyKillOpportunities { get; set; }

    /// <summary>
    /// The save percentage by rank
    /// </summary>
    [JsonProperty("savePctRank")]
    public required string SavePctRank { get; set; }

    /// <summary>
    /// The shooting percentage rank by rank in place
    /// </summary>
    [JsonProperty("shootingPctRank")]
    public required string ShootingPctRank { get; set; }
}
