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
                    await Task.Delay(2000, cancellationToken); // Default to 2 seconds if no delta value
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

        async Task<HttpResponseMessage> GetRequest() => await this.HttpClient!.GetAsync(requestUri: $"{this.HttpClient?.BaseAddress}{route}", cancellationToken: cancellationToken)
                ?? throw new HttpRequestException($"The HTTP request exception thrown for HTTP resource {this.HttpClient?.BaseAddress}{route}");
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
        return await (await this.HttpClient!.GetAsync(endpoint, cancellationToken)).Content.ReadAsStringAsync(cancellationToken);
    }
}
