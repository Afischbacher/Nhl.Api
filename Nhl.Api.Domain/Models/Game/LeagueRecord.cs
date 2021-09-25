using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class LeagueRecord
	{
		[JsonProperty("wins")]
		public int Wins { get; set; }

		[JsonProperty("losses")]
		public int Losses { get; set; }

		[JsonProperty("ot")]
		public int Ot { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

}
