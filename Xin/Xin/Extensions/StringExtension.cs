using System;
using System.Text;

namespace Xin.Extensions
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 字符串截取，前闭后开
        /// </summary>
        /// <param name="source">字符串</param>
        /// <param name="startIndex">开始索引</param>
        /// <param name="endIndex">结束索引</param>
        /// <returns></returns>
        public static string Substr(this String source, int startIndex, int endIndex)
        {
            return source.Substring(startIndex, endIndex - startIndex);
        }

        /// <summary>
        /// 将Base64格式的字符串转换为字节数组
        /// </summary>
        /// <param name="text">字符串</param>
        /// <returns></returns>
        public static byte[] FromBase64String(this string text)
        {
            return Convert.FromBase64String(text);
        }

        /// <summary>
        /// 将UTF8格式的字符串转换为字节数组
        /// </summary>
        /// <param name="text">字符串</param>
        /// <returns></returns>
        public static byte[] FromUTF8String(this string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }
    }
}
