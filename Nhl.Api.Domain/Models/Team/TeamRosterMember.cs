using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Player;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Domain.Models.Team
{
	public class TeamRosterMember
	{
		/// <summary>
		/// Information about the team member such as name, NHL API link and player id
		/// </summary>
		[JsonProperty("person")]
		public Person Person { get; set; }

		/// <summary>
		/// The team roster member jersey number <br/>
		/// Example: "97"
		/// </summary>
		[JsonProperty("jerseyNumber")]
		public string JerseyNumber { get; set; }

		/// <summary>
		/// The information about the primary position of the player
		/// </summary>
		[JsonProperty("position")]
		public PrimaryPosition Position { get; set; }

		public string PlayerHeadshotImageLink
		{
			get
			{
				return $"{PlayerConstants.PlayerImageLink}{Person?.Id}.png";
			}
		}
	}
}
