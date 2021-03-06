using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics for both home and away games within the season
    /// </summary>
    public class GoalieSeasonStatHomeAndAway
    {
        /// <summary>
        /// The specific type for the NHL player statistics
        /// </summary>
        [JsonProperty("type")]
        public Statistics.Type Type { get; set; }

        /// <summary>
        /// The collection of splits for the NHL goalie statistics for both home and away games within the season
        /// </summary>
        [JsonProperty("splits")]
        public List<GoalieSeasonStatisticsSplitHomeAndAway> Splits { get; set; }
    }
}
