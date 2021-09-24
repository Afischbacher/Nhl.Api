using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics
{
	public class Split
	{
		[JsonProperty("stat")]
		public TeamStatisticsDetails TeamStatisticsDetails { get; set; }

		[JsonProperty("team")]
		public Team.Team Team { get; set; }
	}
}