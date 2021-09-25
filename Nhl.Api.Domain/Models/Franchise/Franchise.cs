using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Franchise
{
	/// <summary>
	/// An NHL franchise
	/// </summary>
	public class Franchise
	{
		/// <summary>
		/// The unique identifier of the NHL franchise
		/// </summary>
		[JsonProperty("franchiseId")]
		public int FranchiseId { get; set; }

		/// <summary>
		/// The first season the franchise within the NHL <br/>
		/// Example: 19171918 <br/>
		/// See <see cref="Season.SeasonYear"/> for more information on seasons
		/// </summary>
		[JsonProperty("firstSeasonId")]
		public int FirstSeasonId { get; set; }

		/// <summary>
		/// The current team id that is associated with the franchise <br/>
		/// Example: Montréal Canadiens - 8
		/// </summary>
		[JsonProperty("mostRecentTeamId")]
		public int MostRecentTeamId { get; set; }

		/// <summary>
		/// The name of the NHL team <br/>
		/// Example: Maple Leafs
		/// </summary>
		[JsonProperty("teamName")]
		public string TeamName { get; set; }

		/// <summary>
		/// The geographic location of the NHL team <br/>
		/// Example: Toronto
		/// </summary>
		[JsonProperty("locationName")]
		public string LocationName { get; set; }

		/// <summary>
		/// A link within the api to the franchise information <br/>
		/// Example: /api/v1/franchises/6
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// The last season of the franchise within the NHL <br/>
		/// Example: 19341935 <br/>
		/// See <see cref="Season.SeasonYear"/> for more information on seasons
		/// </summary>
		[JsonProperty("lastSeasonId")]
		public int? LastSeasonId { get; set; }
	}
}
