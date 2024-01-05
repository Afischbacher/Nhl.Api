using Newtonsoft.Json;

namespace Nhl.Api.Models.Standing;

/// <summary>
/// The NHL league standing type
/// </summary>
public class LeagueStandingType
{
    /// <summary>
    /// The name of the NHL league standing type <br/>
    /// Example: postseason
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the NHL league standing type <br/>
    /// Example: Postseason Standings
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}
