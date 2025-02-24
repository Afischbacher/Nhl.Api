using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL HTTP Client for the NHL suggestion API
/// </summary>
public class NhlSuggestionApiHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static HttpClient _httpClient;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    /// <summary>
    /// The NHL HTTP API endpoint for the NHL suggestion API
    /// </summary>
    public const string ClientApiUrl = "https://search.d3.nhle.com/api/";

    /// <summary>
    /// The dedicated NHL HTTP Client for the NHL suggestion API
    /// </summary>
    public NhlSuggestionApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: "v1", timeoutInSeconds: 60)
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
