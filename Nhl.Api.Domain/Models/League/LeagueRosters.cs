using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.League
{
    /// <summary>
    /// NHL League Rosters
    /// </summary>
    public class LeagueRosters
    {
        /// <summary>
        /// A collection of NHL teams
        /// </summary>
        [JsonProperty("teams")]
        public List<Team.Team> Teams { get; set; }
    }
}
