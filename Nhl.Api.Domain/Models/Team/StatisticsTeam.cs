using Newtonsoft.Json;
using Nhl.Api.Models.Statistics;
using System.Collections.Generic;

namespace Nhl.Api.Models.Team
{
    /// <summary>
    /// The NHL team statistics
    /// </summary>
    public class StatisticsTeam : Team
    {
        /// <summary>
        /// The collection of NHL team statistics
        /// </summary>
        [JsonProperty("teamStats")]
        public List<Statistic> TeamStatistics { get; set; }
    }
}
