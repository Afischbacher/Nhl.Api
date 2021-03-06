using Newtonsoft.Json;
using Nhl.Api.Models.Team;

using System.Collections.Generic;

namespace Nhl.Api.Models.Standing
{
    /// <summary>
    /// The NHL records for standings
    /// </summary>
    public class Records
    {
        /// <summary>
        /// The description of the NHL standings type <br/>
        /// Example: regularSeason
        /// </summary>
        [JsonProperty("standingsType")]
        public string StandingsType { get; set; }

        /// <summary>
        /// The information about the NHL league
        /// </summary>
        [JsonProperty("league")]
        public League.League League { get; set; }

        /// <summary>
        /// The information about the NHL division
        /// </summary>
        [JsonProperty("division")]
        public Division.Division Division { get; set; }

        /// <summary>
        /// The information about the NHL conference
        /// </summary>
        [JsonProperty("conference")]
        public Conference.Conference Conference { get; set; }

        /// <summary>
        /// The information about the NHL team records
        /// </summary>
        [JsonProperty("teamRecords")]
        public List<TeamRecord> TeamRecords { get; set; }
    }
}
