using Newtonsoft.Json;


namespace Nhl.Api.Models.League
{
	public class AmateurLeague
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
