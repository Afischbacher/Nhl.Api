using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Game;

namespace Nhl.Api.Domain.Models.Team
{
	public abstract class TeamWithLeagueRecord 
	{
		[JsonProperty("leagueRecord")]
		public LeagueRecord LeagueRecord { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("team")]
		public CurrentTeam Team { get; set; }
	}
}
