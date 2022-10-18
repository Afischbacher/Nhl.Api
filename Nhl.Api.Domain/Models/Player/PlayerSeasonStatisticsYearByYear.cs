using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL player season statistics for each year of the players career
    /// </summary>
    public class PlayerSeasonStatisticsYearByYear
    {
        /// <summary>
        /// The player season statistics for an NHL player for a specific season
        /// </summary>
        [JsonProperty("stats")]
        public List<PlayerSeasonStatYearByYear> Statistics { get; set; }
    }
}
