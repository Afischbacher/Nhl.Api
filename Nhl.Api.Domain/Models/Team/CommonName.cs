using Newtonsoft.Json;

namespace Nhl.Api.Models.Team;
/// <summary>
/// A players team common name for the team a player plays for
/// </summary>
public class CommonName
{
    /// <summary>
    /// The default common name for the team a player plays for <br/>
    /// Example: "Oilers"
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French common name for the team a player plays for <br/>
    /// Example: "Oilers" or "Sénateurs"
    /// </summary>
    [JsonProperty("fr")]
    public string? Fr { get; set; }
}
