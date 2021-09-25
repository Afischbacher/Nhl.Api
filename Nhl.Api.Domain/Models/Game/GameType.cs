using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class GameType
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("postseason")]
		public bool Postseason { get; set; }

	}
}
