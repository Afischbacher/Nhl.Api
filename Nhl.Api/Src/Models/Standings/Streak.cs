using Newtonsoft.Json;

namespace Nhl.Api.Models.Standings
{
	public class Streak
	{
		[JsonProperty("streakType")]
		public string StreakType { get; set; }

		[JsonProperty("streakNumber")]
		public int StreakNumber { get; set; }

		[JsonProperty("streakCode")]
		public string StreakCode { get; set; }
	}
}
