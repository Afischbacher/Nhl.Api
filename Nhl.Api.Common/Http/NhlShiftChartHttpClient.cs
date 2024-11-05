using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL HTTP client for the shift charts for individual live game feeds
/// </summary>
public class NhlShiftChartHttpClient : NhlApiHttpClient
{
    private static readonly object _lock = new object();
    private static HttpClient _httpClient;

    /// <summary>
    /// The dedicated NHL HTTP API endpoint for the shift charts for individual live game feeds
    /// </summary>
    public const string ClientApiUrl = "https://api.nhle.com/stats/rest/en/shiftcharts";

    /// <summary>
    /// The dedicated NHL HTTP client for the shift charts for individual live game feeds
    /// </summary>
    public NhlShiftChartHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60)
    {
    }

    /// <summary>
    /// The NHL shift chart HTTP client
    /// </summary>
    public override HttpClient HttpClient
    {
        get
        {
            lock (_lock)
            {
                _httpClient ??= new HttpClient
                {
                    BaseAddress = new Uri($"{Client}{ClientVersion}"),
                    Timeout = Timeout
                };

                return _httpClient;
            }
        }
    }
}


