namespace Nhl.Api.Models.Player;

using Newtonsoft.Json;

/// <summary>
/// NHL Player Constants
/// </summary>
public class PlayerConstants
{
    /// <summary>
    /// NHL Player Headshot Image Link
    /// </summary>
    [JsonProperty("playerHeadshotImageLink")]
    public const string PlayerHeadshotImageLink = "https://cms.nhl.bamgrid.com/images/headshots/current/168x168/";
}
