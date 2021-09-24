using Newtonsoft.Json;

namespace Nhl.Api.Models.Venue
{
	public class LeagueVenue
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("appEnabled")]
		public string AppEnabled { get; set; }
	}
}
