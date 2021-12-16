using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http
{

    /// <summary>
    /// The dedicated NHL HTTP client for the shift charts for individual live game feeds
    /// </summary>
    public class NhlShiftChartHttpClient : NhlApiHttpClient
    {
        private static readonly object _lock = new object();
        private static HttpClient _httpClient;
        public NhlShiftChartHttpClient() : base(clientApiUri: "https://api.nhle.com/stats/rest/en/shiftcharts", clientVersion: string.Empty, timeoutInSeconds: 30)
        {
        }

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


