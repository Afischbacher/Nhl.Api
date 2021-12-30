using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Season
{
    /// <summary>
    /// NHL League Seasons
    /// </summary>
    public class LeagueSeasons
    {
        /// <summary>
        /// A collection of the NHL seasons
        /// </summary>
        [JsonProperty("seasons")]
        public List<Season> Seasons { get; set; } = new List<Season>();
    }
}
