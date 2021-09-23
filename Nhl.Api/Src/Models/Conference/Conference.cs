using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Conference
{
	public class Conference
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

	}
}
