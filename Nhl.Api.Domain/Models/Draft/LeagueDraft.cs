using Newtonsoft.Json;
using System.Collections.Generic;


namespace Nhl.Api.Domain.Models.Draft
{
	public class LeagueDraft
	{
		[JsonProperty("copyright")]
		public string Copyright { get; set; }

		[JsonProperty("drafts")]
		public List<Draft> Drafts { get; set; }
	}
}
