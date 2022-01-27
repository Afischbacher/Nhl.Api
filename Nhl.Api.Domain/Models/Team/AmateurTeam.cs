using Newtonsoft.Json;

namespace Nhl.Api.Models.Team
{
    /// <summary>
    /// The amateur team for an NHL prospect
    /// </summary>
    public class AmateurTeam
    {
        /// <summary>
        /// Name of the amateur team <br/>
        /// Example: STUPINO 2
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Nhl.Api link to the amateur team <br/>
        /// Example: /api/v1/teams/null
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
