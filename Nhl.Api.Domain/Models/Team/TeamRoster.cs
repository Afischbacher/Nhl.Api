using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Team
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
