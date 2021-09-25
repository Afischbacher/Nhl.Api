using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Team;
using System;

namespace Nhl.Api.Domain.Models.Player
{
	/// <summary>
	/// The profile and information of an NHL player
	/// </summary>
	public class Player
	{
		/// <summary>
		/// The identifier of the NHL player <br/>
		/// Example: 8471675 - Sidney Crosby
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Full name of the NHL player
		/// Example: Alexander Ovechkin
		/// </summary>
		[JsonProperty("fullName")]
		public string FullName { get; set; }

		/// <summary>
		/// A link to the NHL player profile in the NHL API <br/>
		/// Example: /api/v1/people/8479318
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// The first name of the NHL player <br/>
		/// Example: John
		/// </summary>
		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		/// <summary>
		/// The last name of the NHL player <br/>
		/// Example: Carlson
		/// </summary>
		[JsonProperty("lastName")]
		public string LastName { get; set; }

		/// <summary>
		/// The number of the NHL player <br/>
		/// Example: 97
		/// </summary>
		[JsonProperty("primaryNumber")]
		public string PrimaryNumber { get; set; }

		/// <summary>
		/// The birth date of the NHL player <br/>
		/// Example: 1985-05-10
		/// </summary>
		[JsonProperty("birthDate")]
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// The current age in years of the NHL player <br/>
		/// Example: 26
		/// </summary>
		[JsonProperty("currentAge")]
		public int CurrentAge { get; set; }

		/// <summary>
		/// The birth city of the NHL player <br/>
		/// Example: Regina
		/// </summary>
		[JsonProperty("birthCity")]
		public string BirthCity { get; set; }

		/// <summary>
		/// The birth state or province of the NHL player <br/>
		/// <strong>NOTE:</strong> This value is not always present <br/>
		/// Example: SK
		/// </summary>
		[JsonProperty("birthStateProvince")]
		public string BirthStateProvince { get; set; }

		/// <summary>
		/// The birth country of the NHL Player <br/>
		/// Example: USA
		/// </summary>
		[JsonProperty("birthCountry")]
		public string BirthCountry { get; set; }

		/// <summary>
		/// The nationality of the NHL player <br/>
		/// Example: CAN
		/// </summary>
		[JsonProperty("nationality")]
		public string Nationality { get; set; }

		/// <summary>
		/// The height in feet and inches of the NHL player <br/>
		/// Example: "6' 2\""
		/// </summary>
		[JsonProperty("height")]
		public string Height { get; set; }

		/// <summary>
		/// The weight in lbs of the NHL player <br/>
		/// Example: 195
		/// </summary>
		[JsonProperty("weight")]
		public int Weight { get; set; }

		/// <summary>
		/// Identifies if the NHL player is currently active
		/// </summary>
		[JsonProperty("active")]
		public bool Active { get; set; }

		/// <summary>
		/// Identifies if the player is an alternate captain
		/// </summary>
		[JsonProperty("alternateCaptain")]
		public bool AlternateCaptain { get; set; }

		/// <summary>
		/// Identifies if the player is the captain
		/// </summary>
		[JsonProperty("captain")]
		public bool Captain { get; set; }

		/// <summary>
		/// Identifies if the player is a rookie
		/// </summary>
		[JsonProperty("rookie")]
		public bool Rookie { get; set; }

		/// <summary>
		/// The hand or glove position of the NHL player or goalie <br/>
		/// Example: R
		/// </summary>
		[JsonProperty("shootsCatches")]
		public string ShootsCatches { get; set; }

		/// <summary>
		/// The roster status of the NHL player <br/>
		/// Example: N - No / Y - Yes
		/// </summary>
		[JsonProperty("rosterStatus")]
		public string RosterStatus { get; set; }

		/// <summary>
		/// The current team of the NHL player
		/// </summary>
		[JsonProperty("currentTeam")]
		public CurrentTeam CurrentTeam { get; set; }

		/// <summary>
		/// The primary position information of the NHL player
		/// </summary>
		[JsonProperty("primaryPosition")]
		public PrimaryPosition PrimaryPosition { get; set; }
	}
}

