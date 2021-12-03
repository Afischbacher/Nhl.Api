using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Services
{

    public interface ICachingService : IDisposable
    {
        Task TryAdd<T>(string key, T value) where T : class;

        Task<bool> Remove(string key);

        Task<T> TryGet<T>(string key) where T : class;
    }

    public class CachingService : ICachingService
    {
        private readonly ConcurrentDictionary<string, string> _cacheStore = new ConcurrentDictionary<string, string>();

        public void Dispose()
        {
            _cacheStore?.Clear();
        }

        public async Task<bool> Remove(string key)
        {
            return _cacheStore.TryRemove(key, out var value);
        }

        public async Task TryAdd<T>(string key, T value) where T : class
        {
            _cacheStore.TryAdd(key, JsonConvert.SerializeObject(value));
        }

        public async Task<T> TryGet<T>(string key) where T : class
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
