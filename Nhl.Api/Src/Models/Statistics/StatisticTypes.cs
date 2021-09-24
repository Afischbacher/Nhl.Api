using Newtonsoft.Json;
using Nhl.Api.Models.Game;

namespace Nhl.Api.Models.Statistics
{
	public class StatisticTypes
	{
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("gameType")]
		public GameType GameType { get; set; }
	}
}

