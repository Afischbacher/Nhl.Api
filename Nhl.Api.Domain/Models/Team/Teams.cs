using Newtonsoft.Json;
namespace Nhl.Api.Models.Team
{
	public class Teams
	{
		/// <summary>
		/// The NHL away team
		/// </summary>
		[JsonProperty("away")]
		public AwayTeam AwayTeam { get; set; }

		/// <summary>
		/// The NHL home team
		/// </summary>
		[JsonProperty("home")]
		public HomeTeam HomeTeam { get; set; }
	}

}
