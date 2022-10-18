using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{
    /// <summary>
    /// The NHL team statistics
    /// </summary>
    public class TeamStatistics
    {
        /// <summary>
        /// The collection of all the NHL team statistics
        /// </summary>
        [JsonProperty("stats")]
        public List<Statistic> Statistics { get; set; }
    }
}
