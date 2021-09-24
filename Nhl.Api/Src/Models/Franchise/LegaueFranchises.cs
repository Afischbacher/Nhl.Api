using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Franchise
{
	public class LegaueFranchises
	{
		[JsonProperty("franchises")]
		public List<Franchise> Franchises { get; set; } = new List<Franchise>();
	}
}
