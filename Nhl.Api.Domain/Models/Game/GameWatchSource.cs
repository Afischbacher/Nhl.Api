using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// An NHL game watch source for watching NHL games in different markets
/// </summary>
/// <remarks>
/// This class represents a source for watching NHL games in various markets It provides information
/// about the streaming options and broadcast details for both primary and secondary broadcasts
/// </remarks>
public class GameWatchSource
{
    /// <summary>
    /// Gets or sets the unique identifier for the game watch source <br/>
    /// Example: TUN
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the game watch source is currently active <br/>
    /// Example: false
    /// </summary> 
    [JsonProperty("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the country code associated with the game watch source <br/>
    /// Example: CAN
    /// </summary>
    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the country associated with the game watch source <br/>
    /// Example: Canada
    /// </summary>
    [JsonProperty("countryName")]
    public string CountryName { get; set; }

    /// <summary>
    /// Gets or sets the name of the streaming service providing the NHL game broadcasts <br/>
    /// Example: NHL Live
    /// </summary>
    [JsonProperty("streamingName")]
    public string StreamingName { get; set; }

    /// <summary>
    /// Gets or sets the URL of the streaming site for accessing NHL game broadcasts <br/>
    /// Example: <a href="https://nhltv.nhl.com">https://nhltv.nhl.com</a>
    /// </summary>
    [JsonProperty("streamingSiteUrl")]
    public string StreamingSiteUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL of the logo representing the streaming service <br/>
    /// Example: <a href="https://assets.nhle.com/broadcast/nhltv_light_horiz.svg">https://assets.nhle.com/broadcast/nhltv_light_horiz.svg</a>
    /// </summary>
    [JsonProperty("streamingLogoUrl")]
    public string StreamingLogoUrl { get; set; }

    /// <summary>
    /// Gets or sets the name of the primary broadcast for NHL games <br/>
    /// Example: Sportsnet
    /// </summary>
    [JsonProperty("primaryBroadcastName")]
    public string PrimaryBroadcastName { get; set; }

    /// <summary>
    /// Gets or sets the URL of the primary broadcast site for accessing additional information <br/>
    /// Example: <a href="https://www.sportsnet.ca/hockey/nhl/">https://www.sportsnet.ca/hockey/nhl/</a>
    /// </summary>
    [JsonProperty("primaryBroadcastSiteUrl")]
    public string PrimaryBroadcastSiteUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL of the logo representing the primary broadcast <br/>
    /// Example: <a href="https://assets.nhle.com/broadcast/espn_light.svg">https://assets.nhle.com/broadcast/espn_light.svg</a>
    /// </summary>
    [JsonProperty("primaryBroadcastLogoUrl")]
    public string PrimaryBroadcastLogoUrl { get; set; }

    /// <summary>
    /// Gets or sets the name of the secondary broadcast for NHL games <br/>
    /// Example: TVA
    /// </summary>
    [JsonProperty("secondaryBroadcastName")]
    public string SecondaryBroadcastName { get; set; }

    /// <summary>
    /// Gets or sets the URL of the secondary broadcast site for accessing additional information <br/>
    /// Example: <a href="https://www.tvasports.ca/hockey/nhl">https://www.tvasports.ca/hockey/nhl</a>
    /// </summary>
    [JsonProperty("secondaryBroadcastSiteUrl")]
    public string SecondaryBroadcastSiteUrl { get; set; }

    /// <summary>
    /// Gets or sets the URL of the logo representing the secondary broadcast <br/>
    /// Example: <a href="https://assets.nhle.com/broadcast/pro_sieben_light.svg">https://assets.nhle.com/broadcast/pro_sieben_light.svg</a>
    /// </summary>
    [JsonProperty("secondaryBroadcastLogoUrl")]
    public string SecondaryBroadcastLogoUrl { get; set; }
}
