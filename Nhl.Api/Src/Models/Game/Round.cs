using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	public class Round
	{
		[JsonProperty("number")]
		public int Number { get; set; }

		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("names")]
		public Names Names { get; set; }

		[JsonProperty("format")]
		public Format Format { get; set; }
	}
}
