using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL static assets HTTP Client for the Nhl.Api
/// </summary>
public class NhlStaticAssetsApiHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static HttpClient _httpClient;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    /// <summary>
    /// The dedicated NHL static assets NHL HTTP API endpoint
    /// </summary>
    public const string ClientApiUrl = "https://assets.nhle.com";

    /// <summary>
    /// The dedicated NHL static assets HTTP Client for the Nhl.Api
    /// </summary>
    public NhlStaticAssetsApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60)
    {
    }

    /// <summary>
    /// The HTTP client for the NHL static assets API
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
