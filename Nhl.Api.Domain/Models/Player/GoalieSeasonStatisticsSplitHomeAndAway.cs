using Newtonsoft.Json;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics split for each season year by year
    /// </summary>
    public class GoalieSeasonStatisticsSplitHomeAndAway : GoalieSeasonStatisticsSplit
    {
        /// <summary>
        /// Displays whether the statistics is for home or away for the NHL goalie
        /// </summary>
        [JsonProperty("isHome")]
        public bool IsHome { get; set; }
    }
}
