using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    ///  NHL goalie season statistics split
    /// </summary>
    public class GoalieSeasonStatisticsSplit
    {
        /// <summary>
        /// The specific season for the NHL goalie statistics
        /// Example: 20202021
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; set; }

        /// <summary>
        /// The specific NHL goalie data including statistics such as saves, save percentage, shutouts and more
        /// </summary>
        [JsonProperty("stat")]
        public GoalieStatisticsData GoalieStatisticsData { get; set; }
    }
}
