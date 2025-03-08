
using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL Api Web HTTP Client for the Nhl.Api
/// </summary>
public class NhlApiWebHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static HttpClient _httpClient;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    /// <summary>
    /// The NHL web api for the NHL HTTP API Web NHL-e endpoint
    /// </summary>
    public const string ClientApiUrl = "https://api-web.nhle.com/";


    /// <summary>
    /// The dedicated NHL web api HTTP Client for the Nhl.Api
    /// </summary>
    public NhlApiWebHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: "v1", timeoutInSeconds: 60)
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
