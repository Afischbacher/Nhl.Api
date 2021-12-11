using Newtonsoft.Json;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Statistics
{
    public class Split
    {
        /// <summary>
        /// The NHL team statistics details
        /// </summary>
        [JsonProperty("stat")]
        public TeamStatisticsDetails TeamStatisticsDetails { get; set; }

        /// <summary>
        /// The information about the NHL team
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }
    }
}