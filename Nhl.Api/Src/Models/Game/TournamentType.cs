using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	public class TournamentType
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("gameTypeEnum")]
		public GameTypeEnum GameTypeEnum { get; set; }

		[JsonProperty("parameter")]
		public string Parameter { get; set; }
	}
}
