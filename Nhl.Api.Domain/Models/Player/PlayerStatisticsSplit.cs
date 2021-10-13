using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Player
{
	public class PlayerStatisticsSplit
	{
		[JsonProperty("season")]
		public string Season { get; set; }

		[JsonProperty("stat")]
		public PlayerStatisticsData PlayerStatisticsData { get; set; }
	}
}
