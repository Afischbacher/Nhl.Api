using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Schedule;
/// <summary>
/// A team's schedule for a specific season
/// </summary>
public class TeamSchedule
{
    /// <summary>
    /// The start and end year for the previous season for the team's schedule
    /// <returns>20202021</returns>
    /// </summary>
    [JsonProperty("previousSeason")]
    public int PreviousSeason { get; set; }

    /// <summary>
    /// The current season for the team's schedule <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("currentSeason")]
    public int CurrentSeason { get; set; }

    /// <summary>
    /// This returns the NHL team's time zone <br/>
    /// Example: US/Eastern
    /// </summary>
    [JsonProperty("clubTimezone")]
    public required string ClubTimezone { get; set; }

    /// <summary>
    /// This returns the NHL team's time zone offset in hours <br/>
    ///  Example: -05:00
    /// </summary>
    [JsonProperty("clubUTCOffset")]
    public required string ClubUTCOffset { get; set; }

    /// <summary>
    /// The NHL team's schedule for the season in a list of games
    /// </summary>
    [JsonProperty("games")]
    public List<Game> Games { get; set; } = [];
}
