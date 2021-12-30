using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Common
{
    /// <summary>
    /// NHL Record
    /// </summary>
    public class Record
    {
        /// <summary>
        /// The type of NHL standings
        /// </summary>
        [JsonProperty("standingsType")]
        public string StandingsType { get; set; }

        /// <summary>
        /// The information about the of NHL league
        /// </summary>
        [JsonProperty("league")]
        public League.League League { get; set; }

        /// <summary>
        /// The information about the of NHL division
        /// </summary>
        [JsonProperty("division")]
        public Division.Division Division { get; set; }

        /// <summary>
        /// The information about the of NHL conference
        /// </summary>
        [JsonProperty("conference")]
        public Conference.Conference Conference { get; set; }

        /// <summary>
        /// The information about the of NHL team records
        /// </summary>
        [JsonProperty("teamRecords")]
        public List<TeamRecord> TeamRecords { get; set; }
    }

}
