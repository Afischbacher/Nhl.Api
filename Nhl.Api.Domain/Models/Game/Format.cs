using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// NHL Playoff Game Format
    /// </summary>
    public class Format
    {
        /// <summary>
        /// Name of the format for the NHL playoff round <br/>
        /// Example: BO7 (Best of 7)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the format for the NHL playoff round <br/>
        /// Example: Best of 7
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The number of games in the NHL playoff round <br/>
        /// Example: 7
        /// </summary>
        [JsonProperty("numberOfGames")]
        public int NumberOfGames { get; set; }

        /// <summary>
        /// The number of games to win in the NHL playoff round <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("numberOfWins")]
        public int NumberOfWins { get; set; }
    }
}
