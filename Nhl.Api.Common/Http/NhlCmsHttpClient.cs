using System;
using System.Net.Http;
using System.Threading;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The dedicated NHL HTTP client for NHL player images and content
/// </summary>
public class NhlCmsHttpClient : NhlApiHttpClient
{
    private static readonly Lock _lock = new();
    private static HttpClient? _httpClient;

    /// <summary>
    /// The dedicated NHL HTTP API endpoint for NHL player images and content
    /// </summary>
    public const string ClientApiUrl = "https://cms.nhl.bamgrid.com";

    /// <summary>
    /// The dedicated NHL HTTP client for NHL player images and content
    /// </summary>
    public NhlCmsHttpClient() : base(clientApiUri: ClientApiUrl, clientVersion: string.Empty, timeoutInSeconds: 60)
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
                    BaseAddress = new Uri($"{this.Client}{this.ClientVersion}"),
                    Timeout = this.Timeout
                };

                return _httpClient;
            }
        }
    }
}


