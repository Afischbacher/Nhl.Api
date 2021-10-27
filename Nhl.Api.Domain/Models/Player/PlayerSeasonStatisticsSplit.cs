using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class PlayerSeasonStatisticsSplit
	{
		/// <summary>
		/// The specific season for the NHL player statistics
		/// Example: 20202021
		/// </summary>
		[JsonProperty("season")]
		public string Season { get; set; }

		/// <summary>
		/// The specific NHL player data including statistics such as points, shots, time on ice, goals and more
		/// </summary>
		[JsonProperty("stat")]
		public PlayerStatisticsData PlayerStatisticsData { get; set; }
	}
}
