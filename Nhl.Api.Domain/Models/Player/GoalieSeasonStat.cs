using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics
    /// </summary>
    public class GoalieSeasonStat
    {

        /// <summary>
        /// The collection of splits for the NHL goalie statistics for the specific season
        /// </summary>
        [JsonProperty("splits")]
        public List<GoalieSeasonStatisticsSplit> Splits { get; set; }
    }
}
