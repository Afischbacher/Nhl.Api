namespace Nhl.Api.Models.Player;
using Newtonsoft.Json;

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
    public string Default { get; set; }
}
