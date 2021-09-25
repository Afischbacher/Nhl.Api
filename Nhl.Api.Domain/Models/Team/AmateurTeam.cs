using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Team
{
	public class AmateurTeam
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
