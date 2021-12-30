using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{
    /// <summary>
    /// The NHL team season statistics
    /// </summary>
    public class TeamSeasonStatistics
    {
        /// <summary>
        /// The collection of NHL team statistics
        /// </summary>
        [JsonProperty("teams")]
        public List<StatisticsTeam> Teams { get; set; }
    }
}