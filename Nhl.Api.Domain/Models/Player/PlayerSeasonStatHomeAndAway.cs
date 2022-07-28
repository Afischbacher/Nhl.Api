using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL player season statistics for home and away games in a season
    /// </summary>
    public class PlayerSeasonStatHomeAndAway
    {
        /// <summary>
        /// The specific type for the NHL player statistics
        /// </summary>
        [JsonProperty("type")]
        public Statistics.Type Type { get; set; }

        /// <summary>
        /// The collection of splits for the NHL player statistics for home and away games in a season
        /// </summary>
        [JsonProperty("splits")]
        public List<PlayerSeasonStatisticsSplitHomeAndAway> Splits { get; set; }
    }
}
