using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL player season statistics for home and away games
    /// </summary>
    public class PlayerSeasonStatisticsHomeAndAway
    {
        /// <summary>
        /// The player season statistics for an NHL player for home and away games
        /// </summary>
        [JsonProperty("stats")]
        public List<PlayerSeasonStatHomeAndAway> Statistics { get; set; }
    }
}
