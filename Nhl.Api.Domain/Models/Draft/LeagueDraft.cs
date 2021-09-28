using Newtonsoft.Json;
using System.Collections.Generic;


namespace Nhl.Api.Models.Draft
{
	public class LeagueDraft
	{
		/// <summary>
		/// The collection of the NHL league drafts, see <see cref="Draft"/> for more information
		/// </summary>
		[JsonProperty("drafts")]
		public List<Draft> Drafts { get; set; }
	}
}
