using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Team
{
	public class CurrentTeam
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
