using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Draft
{
    /// <summary>
    /// NHL Draft Pick
    /// </summary>
    public class Pick
    {
        /// <summary>
        /// The NHL draft year for the pick <br/>
        /// Example: 2021
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// The NHL draft round for the pick <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("round")]
        public string Round { get; set; }

        /// <summary>
        /// The NHL draft round for the overall pick in the NHL draft <br/>
        /// Example: 43
        /// </summary>
        [JsonProperty("pickOverall")]
        public int PickOverall { get; set; }

        /// <summary>
        /// The NHL draft round for the overall pick in the NHL draft round <br/>
        /// Example: 18
        /// </summary>
        [JsonProperty("pickInRound")]
        public int PickInRound { get; set; }

        /// <summary>
        /// Information on the NHL team for the NHL draft prospect
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }

        /// <summary>
        /// Information about the NHL draft prospect
        /// </summary>
        [JsonProperty("prospect")]
        public Prospect Prospect { get; set; }
    }

}
