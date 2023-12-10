using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Season Statistic for each year of the players career
    /// </summary>
    public class PlayerSeasonStatYearByYear
    {

        /// <summary>
        /// The collection of splits for the NHL player statistics for the each year of the players career
        /// </summary>
        [JsonProperty("splits")]
        public List<PlayerSeasonStatisticsSplitYearByYear> Splits { get; set; }
    }
}
