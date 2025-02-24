using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL HTTP client for the shift charts for individual live game feeds
/// </summary>
public class NhlShiftChartHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
    private static HttpClient? _httpClient;

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
                    BaseAddress = new Uri($"{this.Client}{this.ClientVersion}"),
                    Timeout = this.Timeout
                };

                return _httpClient;
            }
        }
    }
}


