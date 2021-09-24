using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Standings
{
	public class LeagueStandings
	{
		[JsonProperty("records")]
		public List<Records> Records { get; set; }
	}
}
