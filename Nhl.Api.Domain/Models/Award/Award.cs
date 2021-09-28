using Newtonsoft.Json;

namespace Nhl.Api.Models.Award
{
	public class Award
	{
		/// <summary>
		/// The name for an NHL award <br/>
		/// Example: Stanley Cup
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The short name for an NHL award <br/>
		/// Example: The Cup
		/// </summary>
		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		/// <summary>
		/// The description of the NHL award <br/>
		/// Example: The Stanley Cup, the oldest trophy competed for by professional athletes in North America...
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The recipient type for the NHL award <br/>
		/// Example: Player
		/// </summary>
		[JsonProperty("recipientType")]
		public string RecipientType { get; set; }

		/// <summary>
		/// The history of the NHL award <br/>
		/// Example: The Jack Adams Award is named in honour of Jack Adams...
		/// </summary>
		[JsonProperty("history")]
		public string History { get; set; }

		/// <summary>
		/// A link to an image of the NHL award <br/>
		/// Example: http://3.cdn.nhle.com/nhl/images/upload/2017/09/Lady-Byng-Memorial-Trophy.jpg
		/// </summary>
		[JsonProperty("imageUrl")]
		public string ImageUrl { get; set; }

		/// <summary>
		/// A link to an the home page of the NHL award <br/>
		/// Example: http://www.nhl.com/trophies/calder.html
		/// </summary>
		[JsonProperty("homePageUrl")]
		public string HomePageUrl { get; set; }

		/// <summary>
		/// The link to the NHL API for the NHL award <br/>
		/// Example: /api/v1/awards/4
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
