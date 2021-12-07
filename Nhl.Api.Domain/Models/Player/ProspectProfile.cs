using Newtonsoft.Json;
using Nhl.Api.Common.Helpers;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.League;
using Nhl.Api.Models.Team;
using System;

namespace Nhl.Api.Models.Player
{
	public class ProspectProfile
	{
		/// <summary>
		/// The identifier for the NHL draft prospect <br/>
		/// Example: 86515
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// The full name for the NHL draft prospect <br/>
		/// Example: Danila Klimovich
		/// </summary>
		[JsonProperty("fullName")]
		public string FullName { get; set; }

		/// <summary>
		/// The NHL API link for the NHL draft prospect <br/>
		/// Example: /api/v1/draft/prospects/89178
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// The first name for the NHL draft prospect <br/>
		/// Example: Danila 
		/// </summary>
		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		/// <summary>
		/// The last name for the NHL draft prospect <br/>
		/// Example: Klimovich 
		/// </summary>
		[JsonProperty("lastName")]
		public string LastName { get; set; }

		/// <summary>
		/// The date of birth for the NHL draft prospect <br/>
		/// Example: 2003-01-09
		/// </summary>
		[JsonProperty("birthDate")]
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// The birth city of the NHL draft prospect <br/>
		/// Example: Toronto
		/// </summary>
		[JsonProperty("birthCity")]
		public string BirthCity { get; set; }

		/// <summary>
		/// The birth state or province of the NHL draft prospect <br/>
		/// Example: Chelyabinsk
		/// </summary>
		[JsonProperty("birthStateProvince")]
		public string BirthStateProvince { get; set; }

		/// <summary>
		/// The birth country of the NHL draft prospect <br/>
		/// Example: RUS
		/// </summary>
		[JsonProperty("birthCountry")]
		public string BirthCountry { get; set; }

		/// <summary>
		/// The full name of the birth country of the NHL Player <br/>
		/// Example: Canada
		/// </summary>
		public string FullBirthCountry
		{
			get
			{
				return CountryCodeHelper.ConvertThreeDigitCountryCodeToFullCountryName(BirthCountry);
			}
		}

		/// <summary>
		/// The height in feet and inches of the NHL draft prospect <br/>
		/// Example: 5' 10\"
		/// </summary>
		[JsonProperty("height")]
		public string Height { get; set; }

		/// <summary>
		/// The weight in pounds of the NHL draft prospect <br/>
		/// Example: 195
		/// </summary>
		[JsonProperty("weight")]
		public int Weight { get; set; }

		/// <summary>
		/// The position of the NHL draft prospect player/goalie shooting or catching hand <br/>
		/// Example: R
		/// </summary>
		[JsonProperty("shootsCatches")]
		public string ShootsCatches { get; set; }

		/// <summary>
		/// The primary position of the NHL draft prospect
		/// </summary>
		[JsonProperty("primaryPosition")]
		public PrimaryPosition PrimaryPosition { get; set; }

		/// <summary>
		/// The NHL player identifier associated with NHL draft prospect
		/// </summary>
		[JsonProperty("nhlPlayerId")]
		public int NhlPlayerId { get; set; }

		/// <summary>
		/// The NHL draft player draft status <br/>
		/// Example: Elig - Eligible 
		/// </summary>
		[JsonProperty("draftStatus")]
		public string DraftStatus { get; set; }

		/// <summary>
		/// Information about the NHL draft prospects category
		/// </summary>
		[JsonProperty("prospectCategory")]
		public ProspectCategory ProspectCategory { get; set; }

		/// <summary>
		/// Information about the NHL draft prospects amateur team
		/// </summary>
		[JsonProperty("amateurTeam")]
		public AmateurTeam AmateurTeam { get; set; }

		/// <summary>
		/// Information about the NHL draft prospects amateur league
		/// </summary>
		[JsonProperty("amateurLeague")]
		public AmateurLeague AmateurLeague { get; set; }

		/// <summary>
		/// Information about the NHL draft prospects final draft ranking
		/// </summary>
		[JsonProperty("ranks")]
		public Ranks Ranks { get; set; }
	}
}
