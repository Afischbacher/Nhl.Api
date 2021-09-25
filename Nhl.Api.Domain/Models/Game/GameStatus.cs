using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class GameStatus
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("abstractGameState")]
		public string AbstractGameState { get; set; }

		[JsonProperty("detailedState")]
		public string DetailedState { get; set; }

		[JsonProperty("baseballCode")]
		public string BaseballCode { get; set; }

		[JsonProperty("startTimeTBD")]
		public bool StartTimeTBD { get; set; }
	}
}
