using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Team;
/// <summary>
/// Response model for team by id endpoint
/// </summary>
public class LeagueTeam
{
    /// <summary>
    /// The list of teams returned by the endpoint
    /// </summary>
    [JsonProperty("data")]
    public required List<TeamInformation> Teams { get; set; } = [];
}

/// <summary>
/// Represents information about a single NHL team
/// </summary>
public class TeamInformation
{
    /// <summary>
    /// The NHL team identifier
    /// Example: 10 for Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public required int Id { get; set; }

    /// <summary>
    /// The franchise identifier associated with the team
    /// Example: 6 for Toronto Maple Leafs
    /// </summary>
    [JsonProperty("franchiseId")]
    public required int? FranchiseId { get; set; }

    /// <summary>
    /// The full team name
    /// Example: "Toronto Maple Leafs"
    /// </summary>
    [JsonProperty("fullName")]
    public required string FullName { get; set; }

    /// <summary>
    /// The league identifier for the team
    /// Example: 133 for NHL
    /// </summary>
    [JsonProperty("leagueId")]
    public required int? LeagueId { get; set; }

    /// <summary>
    /// The raw three-character tricode for the team
    /// Example: "TOR"
    /// </summary>
    [JsonProperty("rawTricode")]
    public required string RawTricode { get; set; }

    /// <summary>
    /// The normalized three-character tri-code for the team
    /// Example: "TOR"
    /// </summary>
    [JsonProperty("triCode")]
    public required string TriCode { get; set; }
}
