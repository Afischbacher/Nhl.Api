using Newtonsoft.Json;
using Nhl.Api.Models.Common;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
    public class GameSchedule
    {
        /// <summary>
        /// Number of total NHL games in the schedule
        /// </summary>
        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        /// <summary>
        /// Number of events in the NHL schedule
        /// </summary>
        [JsonProperty("totalEvents")]
        public int TotalEvents { get; set; }

        /// <summary>
        /// The number of total games in the NHL schedule
        /// </summary>
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        /// <summary>
        /// Number of total matches in the NHL schedule
        /// </summary>
        [JsonProperty("totalMatches")]
        public int TotalMatches { get; set; }

        /// <summary>
        /// The metadata of the NHL game schedule
        /// </summary>
        [JsonProperty("metaData")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// The wait in the NHL schedule
        /// </summary>
        [JsonProperty("wait")]
        public int Wait { get; set; }

        /// <summary>
        /// The collection of the game dates for the NHL schedule, see <see cref="GameDate"/> for more information
        /// </summary>
        [JsonProperty("dates")]
        public List<GameDate> Dates { get; set; }
    }
}
