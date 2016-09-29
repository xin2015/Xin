using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace Xin
{
    /// <summary>
    /// 内存缓存工具类
    /// </summary>
    public class MemoryCacheHelper
    {
        /// <summary>
        /// 添加或替换内存缓存（绝对过期）
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="dateTime">过期时间</param>
        public static void Set(string key, object value, DateTime dateTime)
        {
            MemoryCache.Default.Set(key, value, dateTime);
        }
        /// <summary>
        /// 添加或替换内存缓存（相对过期）
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="timeSpan">相对时长</param>
        public static void Set(string key, object value, TimeSpan timeSpan)
        {
            CacheItemPolicy cip = new CacheItemPolicy();
            cip.SlidingExpiration = timeSpan;
            MemoryCache.Default.Set(key, value, cip);
        }
        /// <summary>
        /// 判断缓存中是否存在
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static bool Contain(string key)
        {
            return MemoryCache.Default.Contains(key);
        }
        /// <summary>
        /// 根据键获取内存缓存中对应的缓存值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Get(string key)
        {
            return MemoryCache.Default.Get(key);
        }
    }
}
