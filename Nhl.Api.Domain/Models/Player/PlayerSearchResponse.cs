using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Search Response
    /// </summary>
    public class PlayerSearchResponse
    {
        /// <summary>
        /// A collection of suggestions for NHL player search
        /// </summary>
        [JsonProperty("suggestions")]
        public List<string> Suggestions { get; set; }
    }
}
