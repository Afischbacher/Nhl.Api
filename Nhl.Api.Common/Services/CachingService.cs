using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;

namespace Nhl.Api.Common.Services
{

    /// <summary>
    /// A caching service for storing information for easy and quick access within the Nhl.Api
    /// </summary>
    public interface ICachingService : IDisposable
    {
        void TryAddUpdate<T>(string key, T value) where T : class;

        bool Remove(string key);

        T TryGet<T>(string key) where T : class;
    }

    public class CachingService : ICachingService
    {
        private static readonly ConcurrentDictionary<string, string> _cacheStore = new ConcurrentDictionary<string, string>();

        /// <summary>
        /// Clears all cached values
        /// </summary>
        public void Dispose()
        {
            _cacheStore?.Clear();
        }

        /// <summary>
        /// Removes the cached item by the key
        /// </summary>
        public bool Remove(string key)
        {
            return _cacheStore.TryRemove(key, out var value);
        }

        /// <summary>
        /// Add's or updates the cached value based on the provided key and value
        /// </summary>
        public void TryAddUpdate<T>(string key, T value) where T : class
        {
            _cacheStore.AddOrUpdate(key, JsonConvert.SerializeObject(value), (a, b) => JsonConvert.SerializeObject(value));
        }

        /// <summary>
        /// Attempts to retrieve the cached value based on the provided key and generic type
        /// </summary>
        public T TryGet<T>(string key) where T : class
        {
            var hasCachedValue = _cacheStore.TryGetValue(key, out var value);
            if (hasCachedValue)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }

            return null;
        }
    }
}
