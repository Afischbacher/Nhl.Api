using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics
    /// </summary>
    public class GoalieSeasonStatisticsYearByYear
    {
        /// <summary>
        /// The goalie season statistics for an NHL goalie for a specific season
        /// </summary>
        [JsonProperty("stats")]
        public List<GoalieSeasonStatYearByYear> Statistics { get; set; }
    }
}
