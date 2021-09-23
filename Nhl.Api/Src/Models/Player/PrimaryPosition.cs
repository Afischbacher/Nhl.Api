using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class PrimaryPosition
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }
	}
}
