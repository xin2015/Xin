using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Cache
{
    public static class MemoryCacheExtension
    {
        public static bool Add(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            return cache.Add(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }

        public static object AddOrGetExisting(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            return cache.AddOrGetExisting(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }

        public static void Set(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            cache.Set(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }
    }
}
