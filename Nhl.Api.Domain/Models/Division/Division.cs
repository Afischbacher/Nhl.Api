using Newtonsoft.Json;
using Nhl.Api.Models.Common;


namespace Nhl.Api.Models.Division
{
    /// <summary>
    /// NHL Division
    /// </summary>
    public class Division : INhlApiMetaData
    {
        /// <summary>
        /// The short name for the NHL division <br/>
        /// Example: ATL - Atlantic
        /// </summary>
        [JsonProperty("nameShort")]
        public string NameShort { get; set; }

        /// <summary>
        /// The abbreviation for the NHL division <br/>
        /// Example: M - Metropolitan
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// The identifier for the NHL division <br/>
        /// Example: 17
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name for the NHL division <br/>
        /// Example: Metropolitan
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// The NHL API link for the NHL division <br/>
        /// Example: /api/v1/divisions/18
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
