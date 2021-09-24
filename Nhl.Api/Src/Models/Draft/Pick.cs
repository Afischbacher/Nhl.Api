using Newtonsoft.Json;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Models.Draft
{
	public class Pick
	{
		[JsonProperty("year")]
		public int Year { get; set; }

		[JsonProperty("round")]
		public string Round { get; set; }

		[JsonProperty("pickOverall")]
		public int PickOverall { get; set; }

		[JsonProperty("pickInRound")]
		public int PickInRound { get; set; }

		[JsonProperty("team")]
		public Team.Team Team { get; set; }

		[JsonProperty("prospect")]
		public Prospect Prospect { get; set; }
	}

}
