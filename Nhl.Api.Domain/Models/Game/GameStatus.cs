using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// NHL Game Status
    /// </summary>
    public class GameStatus
    {
        /// <summary>
        /// The code that identifies the NHL game status <br/>
        /// Example: 1 - Preview
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The abstract description for the NHL game state <br/>
        /// Example: Preview
        /// </summary>
        [JsonProperty("abstractGameState")]
        public string AbstractGameState { get; set; }

        /// <summary>
        /// The detailed state description for the NHL game state <br/>
        /// Example: In Progress
        /// </summary>
        [JsonProperty("detailedState")]
        public string DetailedState { get; set; }

        /// <summary>
        /// The baseball code associated with the NHL game state <br/>
        /// Example: S - Start / I - In Progress / F - Final / P - Pre Game / S - Scheduled
        /// </summary>
        [JsonProperty("baseballCode")]
        public string BaseballCode { get; set; }

        /// <summary>
        /// Determines if the start time of the NHL game is to determined
        /// </summary>
        [JsonProperty("startTimeTBD")]
        public bool StartTimeTBD { get; set; }
    }
}
