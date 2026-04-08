using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nhl.Api.Common.Http;
/// <summary>
/// The Nhl.Api HTTP Client
/// </summary>
public interface INhlApiHttpClient
{
    /// <summary>
    /// Performs a HTTP GET request
    /// </summary>
    /// <param name="route">The NHL  API endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The deserialized JSON payload of the generic type</returns>
    public Task<T> GetAsync<T>(string route, CancellationToken cancellationToken = default) where T : class;

    /// <summary>
    /// Performs a HTTP GET request and returns a byte array
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    public Task<byte[]> GetByteArrayAsync(string route, CancellationToken cancellationToken = default);

    /// <summary>
    /// Performs a HTTP GET request and returns a string 
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    public Task<string> GetStringAsync(string route, CancellationToken cancellationToken = default);

    /// <summary>
    /// The HTTP Client for the Nhl.Api
    /// </summary>
    public HttpClient? HttpClient { get; }

    /// <summary>
    /// The official client for the Nhl.Api
    /// </summary>
    public string Client { get; }

    /// <summary>
    /// The client version for HTTP requests for the Nhl.Api
    /// </summary>
    public string ClientVersion { get; }
}

/// <summary>
/// The Nhl.Api HTTP Client
/// </summary>
/// <remarks>
/// The Nhl.Api HTTP Client
/// </remarks>
public abstract class NhlApiHttpClient(string clientApiUri, string clientVersion, int timeoutInSeconds = 60) : INhlApiHttpClient
{

    private const int DefaultTimeoutInMilliseconds = 2000;
    // A collection of common User-Agent and Accept-Language header profiles to randomize HTTP requests and mimic real-world traffic patterns
    private static readonly (string UserAgent, string AcceptLanguage)[] HeaderProfiles =
    [
        ("Mozilla/5.0 (Windows NT 11.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 13_6_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.6367.91 Safari/537.36", "en-GB,en;q=0.8"),
        ("Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.6261.128 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Brave/1.65.122 Chrome/124.0.6367.91 Safari/537.36", "en-CA,en;q=0.9"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 12_7_4) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.3 Safari/605.1.15", "en-AU,en;q=0.8"),

        ("Mozilla/5.0 (iPhone; CPU iPhone OS 16_7_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.7 Mobile/15E148 Safari/604.1", "en-US,en;q=0.8"),
        ("Mozilla/5.0 (iPad; CPU OS 17_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.2 Mobile/15E148 Safari/604.1", "en-CA,en;q=0.8"),
        ("Mozilla/5.0 (Linux; Android 14; SM-S918B) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.6367.91 Mobile Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Linux; Android 13; Pixel 7 Pro) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.6312.105 Mobile Safari/537.36", "en-GB,en;q=0.9"),
        ("Mozilla/5.0 (Linux; Android 12; OnePlus 10 Pro) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.6261.128 Mobile Safari/537.36", "en-IN,en;q=0.8"),

        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:125.0) Gecko/20100101 Firefox/125.0", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 13.5; rv:124.0) Gecko/20100101 Firefox/124.0", "en-CA,en;q=0.8"),
        ("Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:123.0) Gecko/20100101 Firefox/123.0", "en-GB,en;q=0.8"),
        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:122.0) Gecko/20100101 Firefox/122.0", "fr-CA,fr;q=0.9,en;q=0.7"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 12.6; rv:121.0) Gecko/20100101 Firefox/121.0", "de-DE,de;q=0.9,en;q=0.7"),

        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Edg/123.0.2420.97 Chrome/123.0.6312.105 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Edg/122.0.2365.80 Chrome/122.0.6261.128 Safari/537.36", "en-CA,en;q=0.8"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 13_4_1) AppleWebKit/537.36 (KHTML, like Gecko) Edg/124.0.2478.51 Chrome/124.0.6367.91 Safari/537.36", "en-GB,en;q=0.8"),
        ("Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Edg/121.0.2277.128 Chrome/121.0.6167.160 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Windows NT 10.0; ARM64) AppleWebKit/537.36 (KHTML, like Gecko) Edg/124.0.2478.51 Chrome/124.0.6367.91 Safari/537.36", "en-AU,en;q=0.8"),

        ("Mozilla/5.0 (Linux; Android 14; Pixel Tablet) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.6367.91 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Linux; Android 13; Samsung Galaxy Tab S8) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.6312.105 Safari/537.36", "en-CA,en;q=0.8"),
        ("Mozilla/5.0 (Macintosh; Intel Mac OS X 14_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36", "en-US,en;q=0.9"),
        ("Mozilla/5.0 (Windows NT 10.0; Win64; x64; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.6312.105 Safari/537.36", "es-ES,es;q=0.9,en;q=0.7"),
        ("Mozilla/5.0 (X11; Linux x86_64; Fedora) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.6367.91 Safari/537.36", "en-US,en;q=0.9")
    ];

    /// <summary>
    /// The HTTP Client for the Nhl.Api
    /// </summary>
    public virtual HttpClient? HttpClient { get; }

    /// <summary>
    /// The timeout for HTTP requests for the Nhl.Api
    /// </summary>
    public TimeSpan Timeout { get; private set; } = TimeSpan.FromSeconds(timeoutInSeconds);

    /// <summary>
    /// The client version for HTTP requests for the Nhl.Api
    /// </summary>
    public string ClientVersion { get; private set; } = clientVersion;

    /// <summary>
    /// The official client for the Nhl.Api
    /// </summary>
    public string Client { get; private set; } = clientApiUri;

    /// <summary>
    /// The maximum number of retries for HTTP requests
    /// </summary>
    public int MaxRetries { get; private set; } = 10;

    /// <summary>
    /// Randomizes the default request headers used by the HTTP client.
    /// </summary>
    public virtual void RandomizeDefaultRequestHeaders(HttpRequestMessage httpRequestMessage)
    {
        if (this.HttpClient is null)
        {
            return;
        }

        var (userAgent, acceptLanguage) = HeaderProfiles[Random.Shared.Next(HeaderProfiles.Length)];

        httpRequestMessage.Headers.Clear();
        httpRequestMessage.Headers.TryAddWithoutValidation("Accept", "application/json, text/plain, */*");
        httpRequestMessage.Headers.TryAddWithoutValidation("User-Agent", userAgent);
        httpRequestMessage.Headers.TryAddWithoutValidation("Accept-Language", acceptLanguage);
    }

    /// <summary>
    /// Performs a HTTP GET request with a generic argument as the model or type to be returned
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The deserialized JSON payload of the generic type</returns>
    public async Task<T> GetAsync<T>(string route, CancellationToken cancellationToken = default) where T : class
    {
        var maxRetries = this.MaxRetries;
        var retryCount = 0;
        var httpResponseMessage = await GetRequest();

        if (httpResponseMessage.Headers.RetryAfter != null)
        {
            while (httpResponseMessage.Headers.RetryAfter != null && httpResponseMessage.Headers.RetryAfter.Delta.HasValue)
            {
                if (retryCount >= maxRetries)
                {
                    throw new HttpRequestException($"The HTTP request exceeded the maximum retry attempts of {maxRetries} for HTTP resource {this.HttpClient?.BaseAddress}{route}");
                }

                if (httpResponseMessage.Headers.RetryAfter.Delta.Value.TotalSeconds <= 0)
                {
                    await Task.Delay(DefaultTimeoutInMilliseconds, cancellationToken); // Default to 2 seconds if no delta value
                }
                else
                {
                    await Task.Delay(httpResponseMessage.Headers.RetryAfter.Delta.Value, cancellationToken);
                }

                var previousResponse = httpResponseMessage;
                httpResponseMessage = await GetRequest();
                previousResponse?.Dispose();
                retryCount++;
            }
        }

        var contentResponse = await httpResponseMessage!.Content.ReadAsStringAsync(cancellationToken);
        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"The HTTP request failed with status code {httpResponseMessage.StatusCode} and reason {httpResponseMessage.ReasonPhrase}");
        }

        if (string.IsNullOrWhiteSpace(contentResponse))
        {
            throw new HttpRequestException("The content response is empty");
        }

        httpResponseMessage?.Dispose();
        return JsonConvert.DeserializeObject<T>(contentResponse)!;

        async Task<HttpResponseMessage> GetRequest()
        {
            var endpoint = $"{this.HttpClient?.BaseAddress}{route}";
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, endpoint);
            this.RandomizeDefaultRequestHeaders(httpRequest);

            return await this.HttpClient!.SendAsync(httpRequest, cancellationToken)
                ?? throw new HttpRequestException($"The HTTP request exception thrown for HTTP resource {this.HttpClient?.BaseAddress}{route}");
        }
    }

    /// <summary>
    /// Performs a HTTP GET request and returns a byte array
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    public async Task<byte[]> GetByteArrayAsync(string route, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(route))
        {
            throw new ArgumentNullException(nameof(route));
        }
        var endpoint = $"{this.HttpClient?.BaseAddress}{route}";
        return await this.HttpClient!.GetByteArrayAsync(endpoint, cancellationToken);
    }

    /// <summary>
    /// Performs a HTTP GET request and returns a string 
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    public async Task<string> GetStringAsync(string route, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(route))
        {
            throw new ArgumentNullException(nameof(route));
        }

        var endpoint = $"{this.HttpClient?.BaseAddress}{route}";
        var httpRequest = new HttpRequestMessage(HttpMethod.Get, endpoint);
        this.RandomizeDefaultRequestHeaders(httpRequest);
        return await (await this.HttpClient!.SendAsync(httpRequest, cancellationToken)).Content.ReadAsStringAsync(cancellationToken);
    }
}
