using System;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
	public class PlayerSearchResult
	{
		/// <summary>
		/// The NHL player id <br/>
		/// Example: 8447400
		/// </summary>
		public int PlayerId { get; set; }

		/// <summary>
		/// First name of NHL player <br/>
		/// Example: Wayne
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Last name of NHL player <br/>
		/// Example: Gretzky
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Height of the NHL player in feet and inches <br/>
		/// Example: 6\u0027 0\"
		/// </summary>
		public string Height { get; set; }

		/// <summary>
		/// Weight of the NHL player in pounds <br/>
		/// Example: 185
		/// </summary>
		public string Weight { get; set; }

		/// <summary>
		/// City of birth for the NHL player <br/>
		/// Example: Brantford
		/// </summary>
		public string BirthCity { get; set; }

		/// <summary>
		/// Province or state of birth for the NHL player <br/>
		/// Example: ON
		/// </summary>
		public string BirthProvinceState { get; set; }

		/// <summary>
		/// Country of birth for the NHL player <br/>
		/// Example: CAN
		/// </summary>
		public string BirthCountry { get; set; }

		/// <summary>
		/// Is the player currently active in the NHL
		/// </summary>
		public bool IsActive { get; set; }

		/// <summary>
		/// Date of birth for the NHL player <br/>
		/// Example: 1961-01-26
		/// </summary>
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// The 3 letter code for the NHL team the NHL player played with <br/>
		/// See <see cref="TeamCodes"/> for more information on 3 letter codes<br/>
		/// Example: NYR
		/// </summary>
		public string LastTeamOfPlay { get; set; }

		/// <summary>
		/// The position for the NHL player <br/>
		/// Example: C
		/// </summary>
		public string Position { get; set; }

		/// <summary>
		/// The jersey number for the NHL player <br/>
		/// Example: C
		/// </summary>
		public int PlayerNumber { get; set; }

	}
}
