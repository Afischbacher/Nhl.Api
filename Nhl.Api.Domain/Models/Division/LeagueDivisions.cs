using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Domain.Models.Division
{
	public class LeagueDivisions
	{
		[JsonProperty("divisions")]
		public List<Division> Divisions { get; set; } = new List<Division>();
	}
}
