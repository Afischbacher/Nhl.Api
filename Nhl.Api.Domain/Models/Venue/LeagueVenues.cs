using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Venue
{    /// <summary>
     /// A collection of NHL venues
     /// </summary>
    public class LeagueVenues
    {
        /// <summary>
        /// A collection of NHL venues
        /// </summary>
        [JsonProperty("venues")]
        public List<LeagueVenue> Venues { get; set; } = new List<LeagueVenue>();
    }
}
