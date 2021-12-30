using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Award
{
    /// <summary>
    /// NHL League Awards
    /// </summary>
    public class LeagueAwards
    {
        /// <summary>
        /// Collection of NHL awards
        /// </summary>
        [JsonProperty("awards")]
        public List<Award> Awards { get; set; } = new List<Award>();
    }
}
