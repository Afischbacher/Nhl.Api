
using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http
{
    /// <summary>
    /// The dedicated NHL Api Web HTTP Client for the Nhl.Api
    /// </summary>
    public class NhlApiWebHttpClient : NhlApiHttpClient
    {
        private static readonly object _lock = new object();
        private static HttpClient _httpClient;

        /// <summary>
        /// The NHL web api for the NHL HTTP API Web NHL-e endpoint
        /// </summary>
        public const string ClientApiUrl = "https://api-web.nhle.com/";


        /// <summary>
        /// The dedicated NHL web api HTTP Client for the Nhl.Api
        /// </summary>
        public NhlApiWebHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: "v1", timeoutInSeconds: 30)
        {

        }

        /// <summary>
        /// The HTTP client for the Nhl.Api
        /// </summary>
        public override HttpClient HttpClient
        {
            get
            {
                lock (_lock)
                {
                    if (_httpClient == null)
                    {
                        _httpClient = new HttpClient()
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
