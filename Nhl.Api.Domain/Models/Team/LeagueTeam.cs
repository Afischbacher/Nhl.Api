using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Team
{
    public class LeagueTeam
    {
        /// <summary>
        /// A collection of NHL teams
        /// </summary>
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
