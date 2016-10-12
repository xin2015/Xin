using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Cache
{
    /// <summary>
    /// MemoryCache扩展类
    /// </summary>
    public static class MemoryCacheExtension
    {
        /// <summary>
        /// 向缓存中插入缓存项，而不会覆盖任何现有的缓存项。
        /// </summary>
        /// <param name="cache">缓存</param>
        /// <param name="key">要添加的缓存项的唯一标识符。</param>
        /// <param name="value">该缓存项的数据。</param>
        /// <param name="absoluteExpiration">缓存项的固定的过期时长。</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域。不要为该参数传递值。默认情况下，此参数为 null，因为 System.Runtime.Caching.MemoryCache类未实现区域。</param>
        /// <returns>如果插入成功，则为 true；如果缓存中已存在具有与 key 相同的键的项，则为 false。</returns>
        /// <exception cref="NotSupportedException">regionName不为 null。</exception>
        /// <exception cref="ArgumentNullException">key为null。-或-value为null</exception> 
        public static bool Add(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            return cache.Add(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }

        /// <summary>
        /// 通过使用指定的键、值和绝对过期时长，将某个缓存项添加到缓存中。
        /// </summary>
        /// <param name="cache">缓存</param>
        /// <param name="key">要添加的缓存项的唯一标识符。</param>
        /// <param name="value">该缓存项的数据。</param>
        /// <param name="absoluteExpiration">缓存项的固定的过期时长。</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域。不要为该参数传递值。默认情况下，此参数为 null，因为 System.Runtime.Caching.MemoryCache类未实现区域。</param>
        /// <returns>如果存在具有相同键的缓存项，则为现有的缓存项；否则为 null。</returns>
        /// <exception cref="NotSupportedException">regionName不为 null。</exception>
        /// <exception cref="ArgumentNullException">key为null。-或-value为null</exception> 
        public static object AddOrGetExisting(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            return cache.AddOrGetExisting(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }

        /// <summary>
        /// 使用键和值将某个缓存项插入缓存中，并指定基于时长的过期详细信息。
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="key">要添加的缓存项的唯一标识符。</param>
        /// <param name="value">该缓存项的数据。</param>
        /// <param name="absoluteExpiration">缓存项的固定的过期时长。</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域。不要为该参数传递值。默认情况下，此参数为 null，因为 System.Runtime.Caching.MemoryCache类未实现区域。</param>
        /// <exception cref="NotSupportedException">regionName不为 null。</exception>
        /// <exception cref="ArgumentNullException">key为null。-或-value为null</exception> 
        public static void Set(this MemoryCache cache, string key, object value, TimeSpan absoluteExpiration, string regionName = null)
        {
            cache.Set(key, value, DateTimeOffset.Now + absoluteExpiration, regionName);
        }
    }
}
