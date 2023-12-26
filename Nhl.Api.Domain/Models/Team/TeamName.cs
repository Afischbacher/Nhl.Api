using Newtonsoft.Json;

namespace Nhl.Api.Models.Team
{

    /// <summary>
    /// The NHL team name
    /// </summary>
    public class TeamName
    {
        /// <summary>
        /// The NHL team name in English
        /// </summary>
        [JsonProperty("default")]
        public string Default { get; set; }

        /// <summary>
        /// The NHL team name in French
        /// </summary>
        [JsonProperty("fr")]
        public string Fr { get; set; }
    }
}
