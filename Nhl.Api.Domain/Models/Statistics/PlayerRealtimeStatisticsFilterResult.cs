using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics;
/// <summary>
/// The returned results of the NHL real time player statistics with search filters
/// </summary>
public class PlayerRealtimeStatisticsFilterResult
{
    /// <summary>
    /// The NHL player statistics result by summary of statistics for a player and season
    /// </summary>
    [JsonProperty("data")]
    public required List<PlayerRealtimeStatisticsResult> PlayerRealtimeStatisticsResults { get; set; }

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
public class PlayerRealtimeStatisticsResult
{
    /// <summary>
    /// Number of blocked shots.
    /// </summary>
    [JsonProperty("blockedShots")]
    public int? BlockedShots { get; set; }

    /// <summary>
    /// Blocked shots per 60 minutes.
    /// </summary>
    [JsonProperty("blockedShotsPer60")]
    public decimal? BlockedShotsPer60 { get; set; }

    /// <summary>
    /// Number of empty net assists.
    /// </summary>
    [JsonProperty("emptyNetAssists")]
    public int? EmptyNetAssists { get; set; }

    /// <summary>
    /// Number of empty net goals.
    /// </summary>
    [JsonProperty("emptyNetGoals")]
    public int? EmptyNetGoals { get; set; }

    /// <summary>
    /// Number of empty net points.
    /// </summary>
    [JsonProperty("emptyNetPoints")]
    public int? EmptyNetPoints { get; set; }

    /// <summary>
    /// Number of first goals.
    /// </summary>
    [JsonProperty("firstGoals")]
    public int? FirstGoals { get; set; }

    /// <summary>
    /// Number of games played.
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int? GamesPlayed { get; set; }

    /// <summary>
    /// Number of giveaways.
    /// </summary>
    [JsonProperty("giveaways")]
    public int? Giveaways { get; set; }

    /// <summary>
    /// Giveaways per 60 minutes.
    /// </summary>
    [JsonProperty("giveawaysPer60")]
    public double GiveawaysPer60 { get; set; }

    /// <summary>
    /// Number of hits.
    /// </summary>
    [JsonProperty("hits")]
    public int? Hits { get; set; }

    /// <summary>
    /// Hits per 60 minutes.
    /// </summary>
    [JsonProperty("hitsPer60")]
    public double? HitsPer60 { get; set; }

    /// <summary>
    /// Player's last name.
    /// </summary>
    [JsonProperty("lastName")]
    public required string LastName { get; set; }

    /// <summary>
    /// Number of missed shots that hit the crossbar.
    /// </summary>
    [JsonProperty("missedShotCrossbar")]
    public int? MissedShotCrossbar { get; set; }

    /// <summary>
    /// Number of missed shots that hit the goalpost.
    /// </summary>
    [JsonProperty("missedShotGoalpost")]
    public int? MissedShotGoalpost { get; set; }

    /// <summary>
    /// Number of missed shots that went over the net.
    /// </summary>
    [JsonProperty("missedShotOverNet")]
    public int? MissedShotOverNet { get; set; }

    /// <summary>
    /// Number of missed shots that were short.
    /// </summary>
    [JsonProperty("missedShotShort")]
    public int? MissedShotShort { get; set; }

    /// <summary>
    /// Number of missed shots that went wide of the net.
    /// </summary>
    [JsonProperty("missedShotWideOfNet")]
    public int? MissedShotWideOfNet { get; set; }

    /// <summary>
    /// Total number of missed shots.
    /// </summary>
    [JsonProperty("missedShots")]
    public int? MissedShots { get; set; }

    /// <summary>
    /// Number of overtime goals.
    /// </summary>
    [JsonProperty("otGoals")]
    public int? OvertimeGoals { get; set; }

    /// <summary>
    /// Player's ID.
    /// </summary>
    [JsonProperty("playerId")]
    public int? PlayerId { get; set; }

    /// <summary>
    /// Player's position code.
    /// </summary>
    [JsonProperty("positionCode")]
    public required string PositionCode { get; set; }

    /// <summary>
    /// Season ID.
    /// </summary>
    [JsonProperty("seasonId")]
    public int? SeasonId { get; set; }

    /// <summary>
    /// Player's shooting or catching hand.
    /// </summary>
    [JsonProperty("shootsCatches")]
    public required string ShootsCatches { get; set; }

    /// <summary>
    /// Number of shot attempts that were blocked.
    /// </summary>
    [JsonProperty("shotAttemptsBlocked")]
    public int? ShotAttemptsBlocked { get; set; }

    /// <summary>
    /// Player's full name.
    /// </summary>
    [JsonProperty("skaterFullName")]
    public required string SkaterFullName { get; set; }

    /// <summary>
    /// Number of takeaways.
    /// </summary>
    [JsonProperty("takeaways")]
    public int? Takeaways { get; set; }

    /// <summary>
    /// Takeaways per 60 minutes.
    /// </summary>
    [JsonProperty("takeawaysPer60")]
    public double? TakeawaysPer60 { get; set; }

    /// <summary>
    /// Team abbreviation.
    /// </summary>
    [JsonProperty("teamAbbrevs")]
    public required string TeamAbbrevs { get; set; }

    /// <summary>
    /// Time on ice per game in minutes.
    /// </summary>
    [JsonProperty("timeOnIcePerGame")]
    public decimal? TimeOnIcePerGame { get; set; }

}
