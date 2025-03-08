using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The NHL endpoint for HTML reports
/// </summary>
public class NhlScoresHtmlReportsApiHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private static HttpClient _httpClient;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    /// <summary>
    /// The NHL endpoint for HTML reports
    /// </summary>
    public const string ClientApiUrl = "https://www.nhl.com/scores/htmlreports/";


    /// <summary>
    /// The dedicated NHL endpoint for HTML reports
    /// </summary>
    public NhlScoresHtmlReportsApiHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60)
    {

    }

    /// <summary>
    /// The HTTP Client dedicated NHL endpoint for HTML reports
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
