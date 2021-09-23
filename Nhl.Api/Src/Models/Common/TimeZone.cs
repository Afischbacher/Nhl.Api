using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Common
{
	public class TimeZone
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("tz")]
		public string Tz { get; set; }
	}

}
