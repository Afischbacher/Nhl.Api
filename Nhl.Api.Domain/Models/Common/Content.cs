using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
    /// <summary>
    /// Content
    /// </summary>
    public class Content
    {
        /// <summary>
        /// The link for the NHL content <br/>
        /// Example: /api/v1/game/2018020614/content
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
