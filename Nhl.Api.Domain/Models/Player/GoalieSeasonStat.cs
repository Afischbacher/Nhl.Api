using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Goalie Season Statistics
    /// </summary>
    public class GoalieSeasonStat
    {
        /// <summary>
        /// The specific type for the NHL player statistics
        /// </summary>
        [JsonProperty("type")]
        public Api.Models.Statistics.Type Type { get; set; }

        /// <summary>
        /// The collection of splits for the NHL goalie statistics for the specific season
        /// </summary>
        [JsonProperty("splits")]
        public List<GoalieSeasonStatisticsSplit> Splits { get; set; }
    }
}
