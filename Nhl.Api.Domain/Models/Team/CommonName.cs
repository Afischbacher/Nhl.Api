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
    public string Default { get; set; }
}
