using Newtonsoft.Json;

namespace Nhl.Api.Models.Draft
{
	public class Ranks
	{
		[JsonProperty("finalRank")]
		public int FinalRank { get; set; }

		[JsonProperty("draftYear")]
		public int DraftYear { get; set; }
	}

}
