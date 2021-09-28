using Newtonsoft.Json;

namespace Nhl.Api.Models.Team
{
	/// <summary>
	/// An NHL team
	/// </summary>
	public class Team : TeamInformation
	{
		/// <summary>
		/// Information about the venue of the NHL team
		/// </summary>
		[JsonProperty("venue")]
		public Venue.Venue Venue { get; set; }

		/// <summary>
		/// The abbreviation of the NHL team <br/>
		/// Example: CGY - Calgary Flames
		/// </summary>
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		/// <summary>
		/// The name of the NHL team <br/>
		/// Example: Devils
		/// </summary>
		[JsonProperty("teamName")]
		public string TeamName { get; set; }

		/// <summary>
		/// The name of the team location <br/>
		/// Example: Pittsburgh
		/// </summary>
		[JsonProperty("locationName")]
		public string LocationName { get; set; }

		/// <summary>
		/// The first year of the team's play within the NHL <br/>
		/// Example: 1967
		/// </summary>
		[JsonProperty("firstYearOfPlay")]
		public string FirstYearOfPlay { get; set; }

		/// <summary>
		/// Information about the NHL teams division
		/// </summary>
		[JsonProperty("division")]
		public Division.Division Division { get; set; }

		/// <summary>
		/// Information about the NHL teams conference
		/// </summary>
		[JsonProperty("conference")]
		public Conference.Conference Conference { get; set; }

		/// <summary>
		/// Information about the NHL teams franchise
		/// </summary>
		[JsonProperty("franchise")]
		public Franchise.Franchise Franchise { get; set; }

		/// <summary>
		/// The short name of the NHL team <br/>
		/// Example: Ottawa
		/// </summary>
		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		/// <summary>
		/// The offical website of the NHL team <br/>
		/// Example: <a href="http://www.chicagoblackhawks.com/"></a>
		/// </summary>
		[JsonProperty("officialSiteUrl")]
		public string OfficialSiteUrl { get; set; }

		/// <summary>
		/// The identifier for the franchise <br/>
		/// Example: Washington Capitals - 24
		/// </summary>
		[JsonProperty("franchiseId")]
		public int FranchiseId { get; set; }

		/// <summary>
		/// Identifies if the NHL team is currently active
		/// </summary>
		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}
