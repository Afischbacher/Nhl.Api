using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class Format
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("numberOfGames")]
		public int NumberOfGames { get; set; }

		[JsonProperty("numberOfWins")]
		public int NumberOfWins { get; set; }
	}
}
