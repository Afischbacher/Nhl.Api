using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http
{
	/// <summary>
	/// The dedicated NHL static assets HTTP Client for the NHL API
	/// </summary>
	public class NhlStaticAssetsApiHttpClient : NhlApiHttpClient
	{
		private static readonly object _lock = new object();
		private static HttpClient _httpClient;

		public static string ClientApiUrl;
		public NhlStaticAssetsApiHttpClient() : base(clientApiUri: "https://www-league.nhlstatic.com", clientVersion: string.Empty, timeoutInSeconds: 30)
		{
			ClientApiUrl = base.Client;
		}

		/// <summary>
		/// The HTTP client for the NHL static assets API
		/// </summary>
		public override HttpClient HttpClient
		{
			get
			{
				lock (_lock)
				{
					if (_httpClient == null)
					{
						_httpClient = new HttpClient
						{
							BaseAddress = new Uri($"{Client}{ClientVersion}"),
							Timeout = Timeout
						};
					}

					return _httpClient;
				}
			}
		}
	}
}
