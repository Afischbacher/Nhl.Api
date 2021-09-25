using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Standing
{
	public class LeagueStandingType
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
