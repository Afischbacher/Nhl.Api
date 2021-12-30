using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Standing
{
    /// <summary>
    /// The NHL league standings
    /// </summary>
    public class LeagueStandings
    {
        /// <summary>
        /// A collection of all the league record standings
        /// </summary>
        [JsonProperty("records")]
        public List<Records> Records { get; set; } = new List<Records>();
    }
}
