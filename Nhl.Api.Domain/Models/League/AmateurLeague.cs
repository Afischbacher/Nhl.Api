using Newtonsoft.Json;

namespace Nhl.Api.Models.League
{
    /// <summary>
    /// Amateur League
    /// </summary>
    public class AmateurLeague
    {
        /// <summary>
        /// The name of the amateur league <br/>
        /// Example: QMJHL
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The link to the Nhl.Api for the amateur team <br/>
        /// Example: /api/v1/league/null
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
