using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Standing
{
    public class LeagueStandings
    {
        /// <summary>
        /// A collection of all the league record standings
        /// </summary>
        [JsonProperty("records")]
        public List<Records> Records { get; set; } = new List<Records>();
    }
}
