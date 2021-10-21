using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Http
{
	/// <summary>
	/// The dedicated NHL HTTP Client for the NHL suggestion API
	/// </summary>
	public static class NhlSuggestionApiHttpClient
	{
		private static readonly object _lock = new object();
		private static HttpClient _httpClient;

		private static HttpClient HttpClient
		{
			get
			{
				lock (_lock)
				{
					if (_httpClient == null)
					{
						_httpClient = new HttpClient
						{
							BaseAddress = new Uri($"{Client}/svc/suggest/{ClientVersion}"),
							Timeout = Timeout
						};
					}

					return _httpClient;
				}
			}
		}

		/// <summary>
		/// The timeout for HTTP requests for the NHL suggestion API, default value is 30 seconds
		/// </summary>
		public static TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);

		/// <summary>
		/// The client version for HTTP requests for the NHL suggestion API, default value is v1
		/// </summary>
		public static string ClientVersion { get; } = "v1";

		/// <summary>
		/// The official client for the NHL suggestion API
		/// </summary>
		public static string Client { get; } = "https://suggest.svc.nhl.com";

		/// <summary>
		/// Performs a HTTP GET request
		/// </summary>
		/// <param name="route">The NHL suggestion API endpoint</param>
		/// <returns>The deserialized JSON payload of the generic type</returns>
		public static async Task<T> GetAsync<T>(string route) where T : class, new()
		{
			if (string.IsNullOrWhiteSpace(route))
			{
				throw new ArgumentNullException(nameof(route));
			}

			var httpResponseMessage = await HttpClient.GetAsync($"{HttpClient.BaseAddress}{route}");

			var contentResponse = await httpResponseMessage.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<T>(contentResponse);

		}
	}
}
