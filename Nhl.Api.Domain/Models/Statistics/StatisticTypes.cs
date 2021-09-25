using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Game;

namespace Nhl.Api.Domain.Models.Statistics
{ 	
	public class StatisticTypes
	{
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("gameType")]
		public GameType GameType { get; set; }
	}
}

