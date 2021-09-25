using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Draft
{
	public class Draft
	{
		[JsonProperty("draftYear")]
		public int DraftYear { get; set; }

		[JsonProperty("rounds")]
		public List<Round> Rounds { get; set; }
	}
}
