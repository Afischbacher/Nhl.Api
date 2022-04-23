using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics for each year of the goalie's career
    /// </summary>
    public class GoalieSeasonStatYearByYear
    {
        /// <summary>
        /// The specific type for the NHL player statistics
        /// </summary>
        [JsonProperty("type")]
        public Statistics.Type Type { get; set; }

        /// <summary>
        /// The collection of splits for the NHL goalie statistics for each year of the goalie's career
        /// </summary>
        [JsonProperty("splits")]
        public List<GoalieSeasonStatisticsSplitYearByYear> Splits { get; set; }
    }
}
