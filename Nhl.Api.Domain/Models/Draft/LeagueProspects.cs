using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using System.Collections.Generic;

namespace Nhl.Api.Models.Draft
{
	public class LeagueProspects
	{
		[JsonProperty("prospects")]
		public List<ProspectProfile> Prospects { get; set; } = new List<ProspectProfile>();
	}
}
