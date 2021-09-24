﻿using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	public class Names
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }
	}
}
