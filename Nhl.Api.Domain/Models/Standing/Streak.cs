using Newtonsoft.Json;

namespace Nhl.Api.Models.Standing
{
	public class Streak
	{
		/// <summary>
		/// The NHL streak type <br/>
		/// Example: wins
		/// </summary>
		[JsonProperty("streakType")]
		public string StreakType { get; set; }

		/// <summary>
		/// The NHL streak number <br/>
		/// Example: 5
		/// </summary>
		[JsonProperty("streakNumber")]
		public int StreakNumber { get; set; }

		/// <summary>
		/// The NHL streak code <br/>
		/// Example: W5
		/// </summary>
		[JsonProperty("streakCode")]
		public string StreakCode { get; set; }
	}
}
