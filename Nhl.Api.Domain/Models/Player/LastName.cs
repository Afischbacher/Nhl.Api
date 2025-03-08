using Newtonsoft.Json;

namespace Nhl.Api.Models.Player;
/// <summary>
/// The last name of the NHL player
/// </summary>
public class LastName
{
    /// <summary>
    /// The default NHL player last name <br/>
    /// Example: Smith
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}
