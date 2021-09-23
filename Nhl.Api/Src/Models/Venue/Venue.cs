using Newtonsoft.Json;

namespace Nhl.Api.Models.Venue
{
	public class Venue
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("timeZone")]
		public Api.Models.Common.TimeZone TimeZone { get; set; }

		[JsonProperty("id")]
		public int? Id { get; set; }
	}

}
