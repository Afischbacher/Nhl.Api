using Newtonsoft.Json;
using Nhl.Api.Models.Statistics;
using System.Collections.Generic;

namespace Nhl.Api.Models.Team
{
    public  class StatisticsTeam : Team
    {
        [JsonProperty("teamStats")]
        public List<Statistic> TeamStatistics { get; set; }
    }
}
