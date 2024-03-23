namespace Nhl.Api.Common.Http;
using System;
using System.Net.Http;


/// <summary>
/// The dedicated NHL HTTP client for NHL player images and content
/// </summary>
public class NhlCmsHttpClient : NhlApiHttpClient
{
    private static readonly object _lock = new object();
    private static HttpClient _httpClient;

    /// <summary>
    /// The dedicated NHL HTTP API endpoint for NHL player images and content
    /// </summary>
    public const string ClientApiUrl = "https://cms.nhl.bamgrid.com";

    /// <summary>
    /// The dedicated NHL HTTP client for NHL player images and content
    /// </summary>
    public NhlCmsHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 30)
    {
    }

    /// <summary>
    /// The NHL CMS images and content HTTP client
    /// </summary>
    public override HttpClient HttpClient
    {
        get
        {
            lock (_lock)
            {
                _httpClient ??= new HttpClient
                {
                    BaseAddress = new Uri($"{Client}{ClientVersion}"),
                    Timeout = Timeout
                };

                return _httpClient;
            }
        }
    }
}


