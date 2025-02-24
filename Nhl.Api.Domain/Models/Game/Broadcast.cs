using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// Provides information about the home and away NHL broadcasts televised
/// </summary>
public class Broadcast
{
    /// <summary>
    /// The identifier for the broadcast channel <br/>
    /// Example: 28
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name for the broadcast channel <br/>
    /// Example: MSG-B
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The type for the broadcast channel <br/>
    /// Example: home
    /// </summary>
    [JsonProperty("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The website for the broadcast channel <br/>
    /// Example: nhl
    /// </summary>
    [JsonProperty("site")]
    public required string Site { get; set; }

    /// <summary>
    /// The language for the broadcast channel <br/>
    /// Example: en
    /// </summary>
    [JsonProperty("language")]
    public required string Language { get; set; }
}
