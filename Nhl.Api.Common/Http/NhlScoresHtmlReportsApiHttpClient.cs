using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The NHL endpoint for HTML reports
/// </summary>
public class NhlScoresHtmlReportsApiHttpClient : NhlApiHttpClient
{
    private static readonly object _lock = new object();
    private static HttpClient _httpClient;

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
                    BaseAddress = new Uri($"{Client}{ClientVersion}"),
                    Timeout = Timeout
                };

                return _httpClient;
            }
        }
    }
}
