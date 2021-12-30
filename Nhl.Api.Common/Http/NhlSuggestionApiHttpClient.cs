using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http
{
    /// <summary>
    /// The dedicated NHL HTTP Client for the NHL suggestion API
    /// </summary>
    public class NhlSuggestionApiHttpClient : NhlApiHttpClient
    {
        private static readonly object _lock = new object();
        private static HttpClient _httpClient;

        /// <summary>
        /// The NHL HTTP API endpoint for the NHL suggestion API
        /// </summary>
        public const string ClientApiUrl = "https://suggest.svc.nhl.com/svc/suggest/";

        /// <summary>
        /// The dedicated NHL HTTP Client for the NHL suggestion API
        /// </summary>
        public NhlSuggestionApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: "v1", timeoutInSeconds: 30)
        {
        }

        /// <summary>
        /// The NHL Suggestion API HTTP Client
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
