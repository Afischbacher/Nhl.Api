using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Venue
{
    /// <summary>
    /// An NHL League Venue
    /// </summary>
    public class LeagueVenue : INhlApiMetaData
    {
        /// <summary>
        /// The identifier of the NHL venue <br/>
        /// Example: 5076 - Enterprise Center
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the NHL venue <br/>
        /// Example: American Airlines Center
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// The Nhl.Api link to the NHL venue <br/>
        /// Example: /api/v1/venues/310
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Identifies if the NHL venue app enabled
        /// </summary>
        [JsonProperty("appEnabled")]
        public string AppEnabled { get; set; }
    }
}
