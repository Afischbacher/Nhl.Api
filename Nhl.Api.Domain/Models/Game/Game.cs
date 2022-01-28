using System;
using Newtonsoft.Json;
using Nhl.Api.Models.Common;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// NHL Game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The game live feed code <br/>
        /// Example: 2018020614
        /// </summary>
        [JsonProperty("gamePk")]
        public int GamePk { get; set; }

        /// <summary>
        /// The Nhl.Api link for the game live feed <br/>
        /// Example: /api/v1/game/2018020614/feed/live
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The NHL game type code <br/>
        /// Example: R - Regular Season
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        /// <summary>
        /// The season code for the NHL game <br/>
        /// Example: 20202021
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; set; }

        /// <summary>
        /// The date and time of the NHL game
        /// </summary>
        [JsonProperty("gameDate")]
        public DateTime GameDate { get; set; }

        /// <summary>
        /// The status of the NHL game
        /// </summary>
        [JsonProperty("status")]
        public GameStatus Status { get; set; }

        /// <summary>
        /// The NHL home and away teams partaking in the game
        /// </summary>
        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        /// <summary>
        /// The NHL venue for the game
        /// </summary>
        [JsonProperty("venue")]
        public Venue.Venue Venue { get; set; }

        /// <summary>
        /// The content for the NHL game
        /// </summary>
        [JsonProperty("content")]
        public Content Content { get; set; }
    }
}
