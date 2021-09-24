using Newtonsoft.Json;
using Nhl.Api.Models.Game;
namespace Nhl.Api.Models.Statistics
{
	public class Type
	{
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("gameType")]
		public GameType GameType { get; set; }
	}
}
