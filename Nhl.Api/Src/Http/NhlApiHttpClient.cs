using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Http
{
	public static class NhlApiHttpClient
	{
		private static HttpClient _httpClient;

		static NhlApiHttpClient()
		{
			if (_httpClient == null)
			{
				_httpClient = new HttpClient
				{
					BaseAddress = new Uri("https://statsapi.web.nhl.com/api/v1"),
					Timeout = TimeSpan.FromSeconds(30)
				};
			}
		}

		public static async Task<T> GetAsync<T>(string route) where T : class, new()
		{
			if (string.IsNullOrWhiteSpace(route))
			{
				throw new ArgumentNullException(nameof(route));
			}

			var httpResponseMessage = await _httpClient.GetAsync($"{_httpClient.BaseAddress}{route}");
			var contentResponse = await httpResponseMessage.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(contentResponse);
		}
	}
}
