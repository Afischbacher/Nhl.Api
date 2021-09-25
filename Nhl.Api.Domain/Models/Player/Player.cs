using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Team;

namespace Nhl.Api.Domain.Models.Player
{

	public class Player
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

		[JsonProperty("primaryNumber")]
		public string PrimaryNumber { get; set; }

		[JsonProperty("birthDate")]
		public string BirthDate { get; set; }

		[JsonProperty("currentAge")]
		public int CurrentAge { get; set; }

		[JsonProperty("birthCity")]
		public string BirthCity { get; set; }

		[JsonProperty("birthStateProvince")]
		public string BirthStateProvince { get; set; }

		[JsonProperty("birthCountry")]
		public string BirthCountry { get; set; }

		[JsonProperty("nationality")]
		public string Nationality { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("weight")]
		public int Weight { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("alternateCaptain")]
		public bool AlternateCaptain { get; set; }

		[JsonProperty("captain")]
		public bool Captain { get; set; }

		[JsonProperty("rookie")]
		public bool Rookie { get; set; }

		[JsonProperty("shootsCatches")]
		public string ShootsCatches { get; set; }

		[JsonProperty("rosterStatus")]
		public string RosterStatus { get; set; }

		[JsonProperty("currentTeam")]
		public CurrentTeam CurrentTeam { get; set; }

		[JsonProperty("primaryPosition")]
		public PrimaryPosition PrimaryPosition { get; set; }
	}
}

