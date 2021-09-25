using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Draft;
using Nhl.Api.Domain.Models.League;
using Nhl.Api.Domain.Models.Team;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Domain.Models.Player
{
	public class ProspectProfile
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("fullName")]
		public string FullName { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("birthDate")]
		public string BirthDate { get; set; }

		[JsonProperty("birthCity")]
		public string BirthCity { get; set; }

		[JsonProperty("birthStateProvince")]
		public string BirthStateProvince { get; set; }

		[JsonProperty("birthCountry")]
		public string BirthCountry { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("weight")]
		public int Weight { get; set; }

		[JsonProperty("shootsCatches")]
		public string ShootsCatches { get; set; }

		[JsonProperty("primaryPosition")]
		public PrimaryPosition PrimaryPosition { get; set; }

		[JsonProperty("nhlPlayerId")]
		public int NhlPlayerId { get; set; }

		[JsonProperty("draftStatus")]
		public string DraftStatus { get; set; }

		[JsonProperty("prospectCategory")]
		public ProspectCategory ProspectCategory { get; set; }

		[JsonProperty("amateurTeam")]
		public AmateurTeam AmateurTeam { get; set; }

		[JsonProperty("amateurLeague")]
		public AmateurLeague AmateurLeague { get; set; }

		[JsonProperty("ranks")]
		public Ranks Ranks { get; set; }
	}
}
