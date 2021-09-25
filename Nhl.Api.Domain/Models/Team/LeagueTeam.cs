using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Team
{ 
	public class LeagueTeam
	{
		[JsonProperty("teams")]
		public List<Team> Teams { get; set; } = new List<Team>();
	}
}
