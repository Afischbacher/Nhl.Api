using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class Prospect
	{
		/// <summary>
		/// The identifier for the NHL draft prospect <br/>
		/// Example: 86515
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// The full name for the NHL draft prospect <br/>
		/// Example: Francesco Pinelli
		/// </summary>
		[JsonProperty("fullName")]
		public string FullName { get; set; }

		/// <summary>
		/// The link to the NHL API for the NHL draft prospect <br/>
		/// Example: /api/v1/draft/prospects/81711
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
