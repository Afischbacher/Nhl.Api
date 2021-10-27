using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Team
{
	public class TeamRoster
	{
		/// <summary>
		/// A collection of all the team players of the NHL roster
		/// </summary>
		[JsonProperty("roster")]
		public List<TeamRosterMember> Roster { get; set; }
	}
}
