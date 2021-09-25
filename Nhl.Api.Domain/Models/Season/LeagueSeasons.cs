using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Season
{ 
	public class LeagueSeasons
	{
		[JsonProperty("seasons")]
		public List<Season> Seasons { get; set; } = new List<Season>();
	}
}
