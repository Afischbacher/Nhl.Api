using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Venue
{
    /// <summary>
    /// NHL venue
    /// </summary>
    public class Venue
    {
        /// <summary>
        /// The name of the NHL venue <br/>
        /// Example: T-Mobile Arena
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The NHL API link to more information about the venue <br/>
        /// Example: /api/v1/venues/5178
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The city where the NHL venue is located <br/>
        /// Example: Las Vegas
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The current time zone of the NHL venue
        /// </summary>
        [JsonProperty("timeZone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// The id of the NHL venue <br/>
        /// Example: 5178
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

}
