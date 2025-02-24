using Newtonsoft.Json;

namespace Nhl.Api.Models.Team;
/// <summary>
/// Enables the type of NHL team logo type based on dark or light background
/// </summary>
public enum TeamLogoType
{
    /// <summary>
    /// Light background for NHL team logo
    /// </summary>
    Light,

    /// <summary>
    /// Dark background for NHL team logo
    /// </summary>
    Dark
}

/// <summary>
/// NHL team logo
/// </summary>
public class TeamLogo
{

    /// <summary>
    /// Returns the Uri for the NHL team logo <br/>
    /// Example: https://www-league.nhlstatic.com/images/logos/teams-current-primary-light/53.svg
    /// </summary>
    [JsonProperty("uri")]
    public required string Uri { get; set; }

    /// <summary>
    /// Returns the requested NHL team logo as a byte array
    /// </summary>
    [JsonProperty("imageAsByteArray")]
    public required byte[] ImageAsByteArray { get; set; }

    /// <summary>
    /// Returns the requested NHL team logo as a base 64 encoded string
    /// </summary>
    [JsonProperty("imageAsBase64String")]
    public required string ImageAsBase64String { get; set; }
}
