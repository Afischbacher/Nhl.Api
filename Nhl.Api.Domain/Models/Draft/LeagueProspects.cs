using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using System.Collections.Generic;

namespace Nhl.Api.Models.Draft
{
	public class LeagueProspects
	{
		/// <summary>
		/// A collection of league prospect profiles within the NHL
		/// </summary>
		[JsonProperty("prospects")]
		public List<ProspectProfile> ProspectProfiles { get; set; } = new List<ProspectProfile>();
	}
}
