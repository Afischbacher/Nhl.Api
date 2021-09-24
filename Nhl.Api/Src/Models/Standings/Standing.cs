﻿using Newtonsoft.Json;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Standings
{
	public class Records
	{
		[JsonProperty("standingsType")]
		public string StandingsType { get; set; }

		[JsonProperty("league")]
		public League.League League { get; set; }

		[JsonProperty("division")]
		public Division.Division Division { get; set; }

		[JsonProperty("conference")]
		public Conference.Conference Conference { get; set; }

		[JsonProperty("teamRecords")]
		public List<TeamRecord> TeamRecords { get; set; }
	}
}
