using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// NHL Game Date
    /// </summary>
    public class GameDate
    {
        /// <summary>
        /// The date of the NHL game within the game schedule
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The total number of items in the game date
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
        /// The collection of games in the NHL schedule
        /// </summary>
        [JsonProperty("games")]
        public List<Game> Games { get; set; }

        /// <summary>
        /// The events in the NHL schedule
        /// </summary>
        [JsonProperty("events")]
        public List<object> Events { get; set; }

        /// <summary>
        /// The matches in the NHL schedule
        /// </summary>
        [JsonProperty("matches")]
        public List<object> Matches { get; set; }
    }
}
