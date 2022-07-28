using Newtonsoft.Json;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL player season statistics split for home and away games
    /// </summary>
    public class PlayerSeasonStatisticsSplitHomeAndAway : PlayerSeasonStatisticsSplit
    {

        /// <summary>
        /// Displays whether the statistics is for home or away for the NHL player
        /// </summary>
        [JsonProperty("isHome")]
        public bool IsHome { get; set; }
    }
}
