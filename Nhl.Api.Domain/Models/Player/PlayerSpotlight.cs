using Newtonsoft.Json;

namespace Nhl.Api.Models.Player;
/// <summary>
/// The name of the NHL player in the spotlight
/// </summary>
public class PlayerSpotlightName
{
    /// <summary>
    /// The NHL player's name in English <br/>
    /// Example: Connor McDavid
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

}

/// <summary>
/// The model for the NHL player spotlight
/// </summary>
public class PlayerSpotlight
{
    /// <summary>
    /// The NHL player's id <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL player's name <br/>
    /// Example: Nathan MacKinnon
    /// </summary>
    [JsonProperty("name")]
    public required PlayerSpotlightName Name { get; set; }

    /// <summary>
    /// The NHL players url to their profile <br/>
    /// Example: <a href="https://www.nhl.com/lightning/player/nikita-kucherov-8476453">https://www.nhl.com/lightning/player/nikita-kucherov-8476453</a>
    /// </summary>
    [JsonProperty("playerSlug")]
    public required string PlayerSlug { get; set; }

    /// <summary>
    /// The position of the NHL player <br/>
    /// Example: R - Right Wing
    /// </summary>
    [JsonProperty("position")]
    public required string Position { get; set; }

    /// <summary>
    /// The NHL players jersey number <br/>
    /// Example: 29
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The NHL players current team id <br/>
    /// Example: 14 - Tampa Bay Lightning
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }

    /// <summary>
    /// The NHL players headshot image url <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/EDM/8477934.png">https://assets.nhle.com/mugs/nhl/20232024/EDM/8477934.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public required string Headshot { get; set; }

    /// <summary>
    /// The NHL players team tri code <br/>
    /// Example: EDM
    /// </summary>
    [JsonProperty("teamTriCode")]
    public required string TeamTriCode { get; set; }

    /// <summary>
    /// The NHL players team logo url <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/BOS_light.svg">https://assets.nhle.com/logos/nhl/svg/BOS_light.svg</a>
    /// </summary>
    [JsonProperty("teamLogo")]
    public required string TeamLogo { get; set; }

    /// <summary>
    /// The identifier to sort the players for the NHL player spotlight <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("sortId")]
    public int SortId { get; set; }
}
