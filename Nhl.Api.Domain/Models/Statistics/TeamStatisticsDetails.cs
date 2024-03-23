namespace Nhl.Api.Models.Statistics;
using Newtonsoft.Json;

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
    public string Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("losses")]
    public string Losses { get; set; }

    /// <summary>
    /// The number of over time games in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("ot")]
    public string Ot { get; set; }

    /// <summary>
    /// The number of league points in the NHL in the current season by rank in place and by numerical value
    /// </summary> 
    [JsonProperty("pts")]
    public string Points { get; set; }

    /// <summary>
    /// The point percentage in the NHL in the current season by rank in place and by numerical value
    /// </summary>
    [JsonProperty("ptPctg")]
    public string PtPctg { get; set; }

    /// <summary>
    /// The number of goals per game both by rank in place and by numerical value as an average
    /// </summary>
    [JsonProperty("goalsPerGame")]
    public string GoalsPerGame { get; set; }

    /// <summary>
    /// The number of goals against per game both by rank in place and by numerical value
    /// </summary>
    [JsonProperty("goalsAgainstPerGame")]
    public string GoalsAgainstPerGame { get; set; }

    /// <summary>
    /// The number of goals against ratio per game both by rank in place and by numerical value
    /// </summary>
    [JsonProperty("evGGARatio")]
    public string EvGGARatio { get; set; }

    /// <summary>
    /// The power play percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayPercentage")]
    public string PowerPlayPercentage { get; set; }

    /// <summary>
    /// The power play goals by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public string PowerPlayGoals { get; set; }

    /// <summary>
    /// The power play goals against by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayGoalsAgainst")]
    public string PowerPlayGoalsAgainst { get; set; }

    /// <summary>
    /// The power play opportunities by rank in place and by numerical value
    /// </summary>
    [JsonProperty("powerPlayOpportunities")]
    public string PowerPlayOpportunities { get; set; }

    /// <summary>
    /// The penalty kill percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("penaltyKillPercentage")]
    public string PenaltyKillPercentage { get; set; }

    /// <summary>
    /// The shots per game by rank in place and by numerical value
    /// </summary>
    [JsonProperty("shotsPerGame")]
    public string ShotsPerGame { get; set; }

    /// <summary>
    /// The shots allowed per game by rank in place and by numerical value
    /// </summary>
    [JsonProperty("shotsAllowed")]
    public string ShotsAllowed { get; set; }

    /// <summary>
    /// The chance of winning based on who scores first by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winScoreFirst")]
    public string WinScoreFirst { get; set; }

    /// <summary>
    /// The chance of winning based on who scores first by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOppScoreFirst")]
    public string WinOppScoreFirst { get; set; }

    /// <summary>
    /// The chance of winning a lead first by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winLeadFirstPer")]
    public string WinLeadFirstPer { get; set; }

    /// <summary>
    /// The chance of winning a lead second by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winLeadSecondPer")]
    public string WinLeadSecondPer { get; set; }

    /// <summary>
    /// The winning of a shootout by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOutshootOpp")]
    public string WinOutshootOpp { get; set; }

    /// <summary>
    /// The winning of a shootout by the opposing team by rank in place and by numerical value
    /// </summary>
    [JsonProperty("winOutshotByOpp")]
    public string WinOutshotByOpp { get; set; }

    /// <summary>
    /// The amount of face-offs taken by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsTaken")]
    public string FaceOffsTaken { get; set; }

    /// <summary>
    /// The number of face-offs won by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsWon")]
    public string FaceOffsWon { get; set; }

    /// <summary>
    /// The number of face-offs lost by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffsLost")]
    public string FaceOffsLost { get; set; }

    /// <summary>
    /// The face-off win percentage by rank in place and by numerical value
    /// </summary>
    [JsonProperty("faceOffWinPercentage")]
    public string FaceOffWinPercentage { get; set; }

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
    public string PenaltyKillOpportunities { get; set; }

    /// <summary>
    /// The save percentage by rank
    /// </summary>
    [JsonProperty("savePctRank")]
    public string SavePctRank { get; set; }

    /// <summary>
    /// The shooting percentage rank by rank in place
    /// </summary>
    [JsonProperty("shootingPctRank")]
    public string ShootingPctRank { get; set; }
}
