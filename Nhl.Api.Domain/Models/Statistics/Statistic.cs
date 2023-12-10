using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{
    /// <summary>
    /// The NHL statistic
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// The splits of the NHL statistics, by place and by numerical value
        /// </summary>
        [JsonProperty("splits")]
        public List<Split> Splits { get; set; }
    }
}
