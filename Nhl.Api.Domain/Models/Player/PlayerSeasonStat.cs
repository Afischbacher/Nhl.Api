using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Season Statistic
    /// </summary>
    public class PlayerSeasonStat
    {
        /// <summary>
        /// The specific type for the NHL player statistics
        /// </summary>
        [JsonProperty("type")]
        public Api.Models.Statistics.Type Type { get; set; }

        /// <summary>
        /// The collection of splits for the NHL player statistics for the specific season
        /// </summary>
        [JsonProperty("splits")]
        public List<PlayerSeasonStatisticsSplit> Splits { get; set; }
    }
}
