using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics
    /// </summary>
    public class GoalieSeasonStatisticsHomeAndAway
    {
        /// <summary>
        /// The goalie season statistics for an NHL goalie for home and away games for a specific season
        /// </summary>
        [JsonProperty("stats")]
        public List<GoalieSeasonStatHomeAndAway> Statistics { get; set; }
    }
}
