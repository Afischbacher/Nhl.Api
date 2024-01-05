
using Newtonsoft.Json;

namespace Nhl.Api.Models.Player;

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
