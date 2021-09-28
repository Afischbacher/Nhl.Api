using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Game;

namespace Nhl.Api.Domain.Models.Statistics
{ 	
	public class StatisticTypes
	{
		/// <summary>
		/// The display name for the statistic types within the NHL
		/// Example: vsDivisionPlayoffs
		/// </summary>
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The game type for the NHL statistic types
		/// </summary>
		[JsonProperty("gameType")]
		public GameType GameType { get; set; }
	}
}

