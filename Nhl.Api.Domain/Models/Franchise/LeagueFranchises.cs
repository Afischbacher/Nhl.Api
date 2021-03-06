using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Franchise
{
    /// <summary>
    /// NHL League Franchises
    /// </summary>
    public class LeagueFranchises
    {
        /// <summary>
        /// A collection of all the NHL franchises
        /// </summary>
        [JsonProperty("franchises")]
        public List<Franchise> Franchises { get; set; } = new List<Franchise>();
    }
}
