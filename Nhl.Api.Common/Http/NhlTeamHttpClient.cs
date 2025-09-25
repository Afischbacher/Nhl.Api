using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL HTTP client for the information about NHL teams
/// </summary>
public class NhlTeamHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
    private static HttpClient? _httpClient;

    /// <summary>
    /// The dedicated NHL HTTP API endpoint for information about NHL teams
    /// </summary>
    public const string ClientApiUrl = "https://api.nhle.com/stats/rest/en/team";

    /// <summary>
    /// The dedicated NHL HTTP client for the information about NHL teams
    /// </summary>
    public NhlTeamHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60)
    {
    }

    /// <summary>
    /// The NHL team HTTP client
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


