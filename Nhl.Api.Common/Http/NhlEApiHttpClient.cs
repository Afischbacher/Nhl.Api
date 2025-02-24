using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHLe Api client for the Nhl.Api
/// </summary>
public class NhlEApiHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static HttpClient _httpClient;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    /// <summary>
    /// The NHLe Api for the NHLe Api HTTP API Web NHL-e endpoint for statistics
    /// </summary>
    public const string ClientApiUrl = "https://api.nhle.com/stats/rest/en";

    /// <summary>
    /// The dedicated NHLe Api web api HTTP Client for the Nhl.Api
    /// </summary>
    public NhlEApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60) => _httpClient ??= new HttpClient()
    {
        BaseAddress = new Uri($"{this.Client}{this.ClientVersion}"),
        Timeout = this.Timeout
    };

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
                    BaseAddress = new Uri($"{this.Client}{this.ClientVersion}"),
                    Timeout = this.Timeout
                };

                return _httpClient;
            }
        }
    }
}
