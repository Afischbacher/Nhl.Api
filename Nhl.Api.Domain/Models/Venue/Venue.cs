using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;

namespace Nhl.Api.Domain.Models.Venue
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
		public TimeZone TimeZone { get; set; }

		[JsonProperty("id")]
		public int? Id { get; set; }
	}

}
