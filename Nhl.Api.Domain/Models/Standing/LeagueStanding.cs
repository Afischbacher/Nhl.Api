using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Standing
{
	public class LeagueStandings
	{
		[JsonProperty("records")]
		public List<Records> Records { get; set; } = new List<Records>();
	}
}
