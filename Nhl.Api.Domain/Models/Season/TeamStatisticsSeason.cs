using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Season;
/// <summary>
/// Represents all the season entries for a team statistics season by team and game type <br/>
/// Example: <br/>
/// <code>
/// [
///   {
///      "season": 20222023,
///      "gameTypes": [ 
///         2,
///         3
///       ]
///   }
/// ]
/// </code>
/// </summary>
public class TeamStatisticsSeason
{
    /// <summary>
    /// The NHL team name for the team statistics season
    /// </summary>
    [JsonProperty("teamName")]
    public string TeamName { get; set; }

    /// <summary>
    /// Gets or sets the season year
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// Gets or sets the list of game types
    /// </summary>
    [JsonProperty("gameTypes")]
    public List<int> GameTypes { get; set; } = new();
}
