using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Venue
{
	public class LeagueVenues
	{
		[JsonProperty("venues")]
		public List<LeagueVenue> Venues { get; set; } = new List<LeagueVenue>();
	}
}
