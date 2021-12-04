using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;

namespace Nhl.Api.Common.Services
{

    public interface ICachingService : IDisposable
    {
        void TryAddUpdate<T>(string key, T value) where T : class;

        bool Remove(string key);

        T TryGet<T>(string key) where T : class;
    }

    public class CachingService : ICachingService
    {
        private readonly ConcurrentDictionary<string, string> _cacheStore = new ConcurrentDictionary<string, string>();

        public void Dispose()
        {
            _cacheStore?.Clear();
        }

        public bool Remove(string key)
        {
            return _cacheStore.TryRemove(key, out var value);
        }

        public void TryAddUpdate<T>(string key, T value) where T : class
        {
            _cacheStore.AddOrUpdate(key, JsonConvert.SerializeObject(value), (a, b) => JsonConvert.SerializeObject(value));
        }

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
