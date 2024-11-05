using System;
using System.Net;
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
    Task<T> GetAsync<T>(string route, CancellationToken cancellationToken = default) where T : class, new();

    /// <summary>
    /// Performs a HTTP GET request and returns a byte array
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    Task<byte[]> GetByteArrayAsync(string route, CancellationToken cancellationToken = default);

    /// <summary>
    /// Performs a HTTP GET request and returns a string 
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A byte array payload from the HTTP GET request</returns>
    Task<string> GetStringAsync(string route, CancellationToken cancellationToken = default);

    /// <summary>
    /// The HTTP Client for the Nhl.Api
    /// </summary>
    HttpClient HttpClient { get; }

    /// <summary>
    /// The official client for the Nhl.Api
    /// </summary>
    string Client { get; }

    /// <summary>
    /// The client version for HTTP requests for the Nhl.Api
    /// </summary>
    string ClientVersion { get; }
}

/// <summary>
/// The Nhl.Api HTTP Client
/// </summary>
public abstract class NhlApiHttpClient : INhlApiHttpClient
{
    /// <summary>
    /// The Nhl.Api HTTP Client
    /// </summary>
    public NhlApiHttpClient(string clientApiUri, string clientVersion, int timeoutInSeconds = 60)
    {
        ServicePointManager.ReusePort = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13 | SecurityProtocolType.Tls12;
        Client = clientApiUri;
        ClientVersion = clientVersion;
        Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
    }

    /// <summary>
    /// The HTTP Client for the Nhl.Api
    /// </summary>
    public virtual HttpClient HttpClient { get; }

    /// <summary>
    /// The timeout for HTTP requests for the Nhl.Api
    /// </summary>
    public TimeSpan Timeout { get; private set; }

    /// <summary>
    /// The client version for HTTP requests for the Nhl.Api
    /// </summary>
    public string ClientVersion { get; private set; }

    /// <summary>
    /// The official client for the Nhl.Api
    /// </summary>
    public string Client { get; private set; }

    /// <summary>
    /// Performs a HTTP GET request with a generic argument as the model or type to be returned
    /// </summary>
    /// <param name="route">The Nhl.Api endpoint</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>The deserialized JSON payload of the generic type</returns>
    public async Task<T> GetAsync<T>(string route, CancellationToken cancellationToken = default) where T : class, new()
    {
        if (string.IsNullOrWhiteSpace(route))
        {
            throw new ArgumentNullException(nameof(route));
        }

        using var httpResponseMessage = await HttpClient.GetAsync(requestUri: $"{HttpClient.BaseAddress}{route}", cancellationToken: cancellationToken);
        var contentResponse = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<T>(contentResponse);
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
        var endpoint = $"{HttpClient.BaseAddress}{route}";
        return await HttpClient.GetByteArrayAsync(endpoint, cancellationToken);
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
        var endpoint = $"{HttpClient.BaseAddress}{route}";
        return await (await HttpClient.GetAsync(endpoint, cancellationToken)).Content.ReadAsStringAsync(cancellationToken);
    }
}
