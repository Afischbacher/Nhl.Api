using System.Collections.Generic;

namespace Nhl.Api.Models.Conference
{
	public class LeagueConferences
	{
		/// <summary>
		/// A collection of all the NHL conferences
		/// </summary>
		public List<Conference> Conferences { get; set; } = new List<Conference>();
	}
}
