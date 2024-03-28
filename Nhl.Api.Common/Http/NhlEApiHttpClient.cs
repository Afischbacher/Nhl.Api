using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHLe Api client for the Nhl.Api
/// </summary>
public class NhlEApiHttpClient : NhlApiHttpClient
{
    private static readonly object _lock = new object();
    private static HttpClient _httpClient;

    /// <summary>
    /// The NHLe Api for the NHLe Api HTTP API Web NHL-e endpoint for statistics
    /// </summary>
    public const string ClientApiUrl = "https://api.nhle.com/stats/rest/en";


    /// <summary>
    /// The dedicated NHLe Api web api HTTP Client for the Nhl.Api
    /// </summary>
    public NhlEApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 30)
    {

    }

    /// <summary>
    /// The NHLe Api HTTP client for the Nhl.Api
    /// </summary>
    public override HttpClient HttpClient
    {
        get
        {
            lock (_lock)
            {
                _httpClient ??= new HttpClient()
                {
                    BaseAddress = new Uri($"{Client}{ClientVersion}"),
                    Timeout = Timeout
                };

                return _httpClient;
            }
        }
    }
}
