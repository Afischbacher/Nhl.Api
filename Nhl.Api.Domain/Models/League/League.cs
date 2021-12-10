using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.League
{
    public class League : INhlApiMetaData
    {
        /// <summary>
        /// The identifier for the NHL league <br/>
        /// Example: 133
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the NHL league <br/>
        /// Example: National Hockey League
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The NHL API link to the league <br/>
        /// Example: /api/v1/league/133
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
