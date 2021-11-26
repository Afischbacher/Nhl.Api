using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{
    public class TeamSeasonStatistics
    {
        [JsonProperty("teams")]
        public List<StatisticsTeam> Teams { get; set; }
    }
}