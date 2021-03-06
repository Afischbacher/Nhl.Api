using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
    /// <summary>
    /// NHL Time Zone
    /// </summary>
    public class TimeZone
    {
        /// <summary>
        /// The identifier for the time zone
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The offset for the time zone
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// The timezone
        /// </summary>
        [JsonProperty("tz")]
        public string Tz { get; set; }
    }

}
