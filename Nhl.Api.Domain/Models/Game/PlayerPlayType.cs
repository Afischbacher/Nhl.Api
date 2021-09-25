using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class PlayerPlayType
	{
		[JsonProperty("playerType")]
		public string PlayerType { get; set; }
	}
}
