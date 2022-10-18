using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Season Statistics
    /// </summary>
    public class PlayerSeasonStatistics
    {
        /// <summary>
        /// The player season statistics for an NHL player for a specific season
        /// </summary>
        [JsonProperty("stats")]
        public List<PlayerSeasonStat> Statistics { get; set; }
    }
}
