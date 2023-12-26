using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// The NHL team prospects by position for an NHL team
    /// </summary>
    public class TeamProspects
    {
        /// <summary>
        /// The NHL team forward prospects for an NHL team
        /// </summary>
        [JsonProperty("forwards")]
        public List<TeamProspectForward> Forwards { get; set; }

        /// <summary>
        /// The NHL team defense prospects for an NHL team
        /// </summary>
        [JsonProperty("defensemen")]
        public List<TeamProspectDefenseman> Defensemen { get; set; }

        /// <summary>
        /// The NHL team goalie prospects for an NHL team
        /// </summary>
        [JsonProperty("goalies")]
        public List<TeamProspectGoalie> Goalies { get; set; }
    }

    /// <summary>
    /// An NHL team prospect defenseman for an NHL team
    /// </summary>
    public class TeamProspectDefenseman : TeamRosterPlayer
    {
        
    }

    /// <summary>
    /// An NHL team prospect forward for an NHL team
    /// </summary>
    public class TeamProspectForward : TeamRosterPlayer
    {
      
    }

    /// <summary>
    /// An NHL team prospect goalie for an NHL team
    /// </summary>
    public class TeamProspectGoalie : TeamRosterPlayer
    {
       
    }

}
