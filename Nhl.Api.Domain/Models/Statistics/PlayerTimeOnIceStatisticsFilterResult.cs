using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics;
/// <summary>
/// The returned results of the NHL real time player statistics with search filters
/// </summary>
public class PlayerTimeOnIceStatisticsFilterResult
{
    /// <summary>
    /// The NHL player statistics result by summary of statistics for a player and season
    /// </summary>
    [JsonProperty("data")]
    public List<PlayerTimeOnIceStatisticsResult> PlayerTimeOnIceStatisticsResults { get; set; }

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
public class PlayerTimeOnIceStatisticsResult
{
    /// <summary>
    /// Even strength time on ice in seconds.
    /// </summary>
    [JsonProperty("evTimeOnIce")]
    public int EvTimeOnIce { get; set; }

    /// <summary>
    /// Even strength time on ice per game in seconds.
    /// </summary>
    [JsonProperty("evTimeOnIcePerGame")]
    public double EvTimeOnIcePerGame { get; set; }

    /// <summary>
    /// Number of games played.
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// Player's last name.
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Overtime time on ice in seconds.
    /// </summary>
    [JsonProperty("otTimeOnIce")]
    public int OtTimeOnIce { get; set; }

    /// <summary>
    /// Overtime time on ice per overtime game in seconds.
    /// </summary>
    [JsonProperty("otTimeOnIcePerOtGame")]
    public double OtTimeOnIcePerOtGame { get; set; }

    /// <summary>
    /// Player's ID.
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// Player's position code.
    /// </summary>
    [JsonProperty("positionCode")]
    public string PositionCode { get; set; }

    /// <summary>
    /// Power play time on ice in seconds.
    /// </summary>
    [JsonProperty("ppTimeOnIce")]
    public int PpTimeOnIce { get; set; }

    /// <summary>
    /// Power play time on ice per game in seconds.
    /// </summary>
    [JsonProperty("ppTimeOnIcePerGame")]
    public double PpTimeOnIcePerGame { get; set; }

    /// <summary>
    /// Season ID.
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// Short-handed time on ice in seconds.
    /// </summary>
    [JsonProperty("shTimeOnIce")]
    public int ShTimeOnIce { get; set; }

    /// <summary>
    /// Short-handed time on ice per game in seconds.
    /// </summary>
    [JsonProperty("shTimeOnIcePerGame")]
    public double ShTimeOnIcePerGame { get; set; }

    /// <summary>
    /// Number of shifts.
    /// </summary>
    [JsonProperty("shifts")]
    public int Shifts { get; set; }

    /// <summary>
    /// Shifts per game.
    /// </summary>
    [JsonProperty("shiftsPerGame")]
    public double ShiftsPerGame { get; set; }

    /// <summary>
    /// Player's shooting or catching hand.
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// Player's full name.
    /// </summary>
    [JsonProperty("skaterFullName")]
    public string SkaterFullName { get; set; }

    /// <summary>
    /// Team abbreviation.
    /// </summary>
    [JsonProperty("teamAbbrevs")]
    public string TeamAbbrevs { get; set; }

    /// <summary>
    /// Total time on ice in seconds.
    /// </summary>
    [JsonProperty("timeOnIce")]
    public int TimeOnIce { get; set; }

    /// <summary>
    /// Time on ice per game in seconds.
    /// </summary>
    [JsonProperty("timeOnIcePerGame")]
    public decimal? TimeOnIcePerGame { get; set; }

    /// <summary>
    /// Time on ice per shift in seconds.
    /// </summary>
    [JsonProperty("timeOnIcePerShift")]
    public decimal? TimeOnIcePerShift { get; set; }

}
