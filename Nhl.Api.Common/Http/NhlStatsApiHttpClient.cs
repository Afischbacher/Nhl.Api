using System;
using System.Net.Http;

namespace Nhl.Api.Common.Http;

/// <summary>
/// The dedicated NHL statistics HTTP Client for the Nhl.Api
/// </summary>
public class NhlStatsApiHttpClient : NhlApiHttpClient
{
    private static readonly object _lock = new object();
    private static HttpClient _httpClient;

    /// <summary>
    /// The NHL statistics NHL HTTP API endpoint
    /// </summary>
    public const string ClientApiUrl = "https://statsapi.web.nhl.com/api/";


    /// <summary>
    /// The dedicated NHL statistics HTTP Client for the Nhl.Api
    /// </summary>
    public NhlStatsApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: "v1", timeoutInSeconds: 30)
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
