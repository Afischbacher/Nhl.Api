﻿using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Services
{

    /// <summary>
    /// A caching service for storing information for easy and quick access within the Nhl.Api
    /// </summary>
    public interface ICachingService : IDisposable
    {
        Task TryAddUpdateAsync<T>(string key, T value) where T : class;

        Task<bool> RemoveAsync(string key);

        Task<T> TryGetAsync<T>(string key) where T : class;
    }

    public class CachingService : ICachingService
    {
        private static readonly ConcurrentDictionary<string, byte[]> _cacheStore = new ConcurrentDictionary<string, byte[]>();

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
        public async Task<bool> RemoveAsync(string key)
        {
            return await Task.Run(() => _cacheStore.TryRemove(key, out var value));
        }

        /// <summary>
        /// Add's or updates the cached value based on the provided key and value
        /// </summary>
        public async Task TryAddUpdateAsync<T>(string key, T value) where T : class
        {
            _cacheStore.AddOrUpdate(key, await Compress(JsonConvert.SerializeObject(value)), (a, b) => Compress(JsonConvert.SerializeObject(value)).Result);
        }

        /// <summary>
        /// Attempts to retrieve the cached value based on the provided key and generic type
        /// </summary>
        public async Task<T> TryGetAsync<T>(string key) where T : class
        {
            var hasCachedValue = _cacheStore.TryGetValue(key, out var value);
            if (hasCachedValue)
            {
                var stringValue = await Decompress(value);
                return JsonConvert.DeserializeObject<T>(stringValue);
            }

            return null;
        }

        /// <summary>
        /// Copies from source to destination stream
        /// </summary>
        private static async Task CopyTo(Stream src, Stream dest)
        {
            var bytes = new byte[4096];
            int count;

            while ((count = await src.ReadAsync(bytes, 0, bytes.Length)) != 0)
            {
                await dest.WriteAsync(bytes, 0, count);
            }
        }

        /// <summary>
        /// Compresses a string value into a GZip stream
        /// </summary>
        private static async Task<byte[]> Compress(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var sourceMemoryStream = new MemoryStream(bytes))
            using (var destinationMemoryStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(destinationMemoryStream, CompressionMode.Compress))
                {
                    await CopyTo(sourceMemoryStream, gzipStream);
                }

                return destinationMemoryStream.ToArray();
            }
        }

        /// <summary>
        /// Decompresses a GZip stream into a string
        /// </summary>
        private static async Task<string> Decompress(byte[] bytes)
        {
            using (var sourceMemoryStream = new MemoryStream(bytes))
            using (var destinationMemoryStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(sourceMemoryStream, CompressionMode.Decompress))
                {
                    await CopyTo(gzipStream, destinationMemoryStream);
                }

                return Encoding.UTF8.GetString(destinationMemoryStream.ToArray());
            }
        }
    }
}
