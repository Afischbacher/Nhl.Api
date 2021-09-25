using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Conference
{
	public class LeagueConferences
	{
		public List<Conference> Conferences { get; set; } = new List<Conference>();
	}
}
