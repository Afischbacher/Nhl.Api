using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Team
{
	public class Team : TeamInformation
	{

		[JsonProperty("venue")]
		public Venue.Venue Venue { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("teamName")]
		public string TeamName { get; set; }

		[JsonProperty("locationName")]
		public string LocationName { get; set; }

		[JsonProperty("firstYearOfPlay")]
		public string FirstYearOfPlay { get; set; }

		[JsonProperty("division")]
		public  Division.Division Division { get; set; }

		[JsonProperty("conference")]
		public Conference.Conference Conference { get; set; }

		[JsonProperty("franchise")]
		public Franchise.Franchise Franchise { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("officialSiteUrl")]
		public string OfficialSiteUrl { get; set; }

		[JsonProperty("franchiseId")]
		public int FranchiseId { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}
