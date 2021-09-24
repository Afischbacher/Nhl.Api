using Newtonsoft.Json;

namespace Nhl.Api.Models.Standings
{
	public class LeagueStandingType
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
