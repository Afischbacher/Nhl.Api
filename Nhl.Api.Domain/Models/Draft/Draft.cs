using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Draft
{
    /// <summary>
    /// NHL Draft
    /// </summary>
    public class Draft
    {
        /// <summary>
        /// The draft year for the NHL league <br/>
        /// Example: 2021
        /// </summary>
        [JsonProperty("draftYear")]
        public int DraftYear { get; set; }

        /// <summary>
        /// The collection of all the NHL draft rounds
        /// </summary>
        [JsonProperty("rounds")]
        public List<Round> Rounds { get; set; }
    }
}
