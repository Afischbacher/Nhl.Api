using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Player;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Draft
{
	public class LeagueProspects
	{
		[JsonProperty("prospects")]
		public List<ProspectProfile> Prospects { get; set; } = new List<ProspectProfile>();
	}
}
