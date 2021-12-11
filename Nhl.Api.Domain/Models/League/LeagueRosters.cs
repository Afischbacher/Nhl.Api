using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.League
{
    public class LeagueRosters
    {
        [JsonProperty("teams")]
        public List<Api.Models.Team.Team> Teams { get; set; }
    }
}
