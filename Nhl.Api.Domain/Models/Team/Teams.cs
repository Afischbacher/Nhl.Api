using Newtonsoft.Json;
namespace Nhl.Api.Domain.Models.Team
{
	public class Teams
	{
		[JsonProperty("away")]
		public AwayTeam AwayTeam { get; set; }

		[JsonProperty("home")]
		public HomeTeam HomeTeam { get; set; }
	}

}
