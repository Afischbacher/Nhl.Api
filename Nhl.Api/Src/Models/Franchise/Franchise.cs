using Newtonsoft.Json;

namespace Nhl.Api.Models.Franchise
{
	public class Franchise
	{
		[JsonProperty("franchiseId")]
		public int FranchiseId { get; set; }

		[JsonProperty("firstSeasonId")]
		public int FirstSeasonId { get; set; }

		[JsonProperty("mostRecentTeamId")]
		public int MostRecentTeamId { get; set; }

		[JsonProperty("teamName")]
		public string TeamName { get; set; }

		[JsonProperty("locationName")]
		public string LocationName { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("lastSeasonId")]
		public int? LastSeasonId { get; set; }
	}
}
