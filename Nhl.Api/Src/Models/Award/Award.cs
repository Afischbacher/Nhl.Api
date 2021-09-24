using Newtonsoft.Json;

namespace Nhl.Api.Models.Award
{
	public class Award
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("recipientType")]
		public string RecipientType { get; set; }

		[JsonProperty("history")]
		public string History { get; set; }

		[JsonProperty("imageUrl")]
		public string ImageUrl { get; set; }

		[JsonProperty("homePageUrl")]
		public string HomePageUrl { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
