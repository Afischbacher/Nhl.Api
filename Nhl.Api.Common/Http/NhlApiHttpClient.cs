using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Http
{
    public interface INhlApiHttpClient
    {
        /// <summary>
        /// Performs a HTTP GET request
        /// </summary>
        /// <param name="route">The NHL  API endpoint</param>
        /// <returns>The deserialized JSON payload of the generic type</returns>
        Task<T> GetAsync<T>(string route) where T : class, new();

        /// <summary>
        /// Performs a HTTP GET request and returns a byte array
        /// </summary>
        /// <param name="route">The NHL API endpoint</param>
        /// <returns>A byte array payload from the HTTP GET request</returns>
        Task<byte[]> GetByteArrayAsync(string route);

        /// <summary>
        /// The HTTP Client for the NHL API
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// The official client for the NHL API
        /// </summary>
        string Client { get; }

        /// <summary>
        /// The client version for HTTP requests for the NHL API
        /// </summary>
        string ClientVersion { get; }
    }

    public abstract class NhlApiHttpClient : INhlApiHttpClient
    {
        public NhlApiHttpClient(string clientApiUri, string clientVersion, int timeoutInSeconds = 30)
        {
            ServicePointManager.ReusePort = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            Client = clientApiUri;
            ClientVersion = clientVersion;
            Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
        }

        /// <summary>
        /// The HTTP Client for the NHL API
        /// </summary>
        public virtual HttpClient HttpClient { get; }

        /// <summary>
        /// The timeout for HTTP requests for the NHL API
        /// </summary>
        public TimeSpan Timeout { get; private set; }

        /// <summary>
        /// The client version for HTTP requests for the NHL API
        /// </summary>
        public string ClientVersion { get; private set; }

        /// <summary>
        /// The official client for the NHL API
        /// </summary>
        public string Client { get; private set; }

        /// <summary>
        /// Performs a HTTP GET request with a generic argument as the model or type to be returned
        /// </summary>
        /// <param name="route">The NHL API endpoint</param>
        /// <returns>The deserialized JSON payload of the generic type</returns>
        public async Task<T> GetAsync<T>(string route) where T : class, new()
        {
            if (string.IsNullOrWhiteSpace(route))
            {
                throw new ArgumentNullException(nameof(route));
            }

            using (var httpResponseMessage = await HttpClient.GetAsync($"{HttpClient.BaseAddress}{route}"))
            {
                var contentResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(contentResponse);
            }
        }

        /// <summary>
        /// Performs a HTTP GET request and returns a byte array
        /// </summary>
        /// <param name="route">The NHL API endpoint</param>
        /// <returns>A byte array payload from the HTTP GET request</returns>
        public async Task<byte[]> GetByteArrayAsync(string route)
        {
            if (string.IsNullOrWhiteSpace(route))
            {
                throw new ArgumentNullException(nameof(route));
            }
            var endpoint = $"{HttpClient.BaseAddress}{route}";
            return await HttpClient.GetByteArrayAsync(endpoint);
        }
    }
}
