using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Team;
/// <summary>
/// Response model for the all teams endpoint (/stats/rest/en/team)
/// </summary>
public class TeamsResponse
{
    /// <summary>
    /// The list of teams returned by the endpoint
    /// </summary>
    [JsonProperty("data")]
    public required List<TeamInformation> Data { get; set; } = [];

    /// <summary>
    /// The total number of teams returned by the endpoint
    /// </summary>
    [JsonProperty("total")]
    public required int Total { get; set; }
}
