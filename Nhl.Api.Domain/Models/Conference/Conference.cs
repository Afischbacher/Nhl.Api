using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Conference
{
    public class Conference : INhlApiMetaData
    {
        /// <summary>
        /// The identifier for the NHL conference <br/>
        /// Example: 5
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name for the NHL conference <br/>
        /// Example: Eastern
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The NHL API link for the NHL division <br/>
        /// Example: /api/v1/conferences/6
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The abbreviation of the NHL conference <br/>
        /// Example: E - Eastern
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// The short name for the NHL conference <br/>
        /// Example: West - Western
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Identifies if the NHL conference is active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

    }
}
