using Newtonsoft.Json;

namespace Nhl.Api.Models.Award;
/// <summary>
/// NHL Award
/// </summary>
public class Award
{
    /// <summary>
    /// The name for an NHL award <br/>
    /// Example: Stanley Cup
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The short name for an NHL award <br/>
    /// Example: The Cup
    /// </summary>
    [JsonProperty("shortName")]
    public required string ShortName { get; set; }

    /// <summary>
    /// The description of the NHL award <br/>
    /// Example: The Stanley Cup, the oldest trophy competed for by professional athletes in North America...
    /// </summary>
    [JsonProperty("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The recipient type for the NHL award <br/>
    /// Example: Player
    /// </summary>
    [JsonProperty("recipientType")]
    public required string RecipientType { get; set; }

    /// <summary>
    /// The history of the NHL award <br/>
    /// Example: The Jack Adams Award is named in honor of Jack Adams...
    /// </summary>
    [JsonProperty("history")]
    public required string History { get; set; }

    /// <summary>
    /// A link to an image of the NHL award <br/>
    /// Example: http://3.cdn.nhle.com/nhl/images/upload/2017/09/Lady-Byng-Memorial-Trophy.jpg
    /// </summary>
    [JsonProperty("imageUrl")]
    public required string ImageUrl { get; set; }

    /// <summary>
    /// A link to an the home page of the NHL award <br/>
    /// Example: http://www.nhl.com/trophies/calder.html
    /// </summary>
    [JsonProperty("homePageUrl")]
    public required string HomePageUrl { get; set; }

    /// <summary>
    /// The link to the Nhl.Api for the NHL award <br/>
    /// Example: /api/v1/awards/4
    /// </summary>
    [JsonProperty("link")]
    public required string Link { get; set; }
}
