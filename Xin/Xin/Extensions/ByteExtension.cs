using System;
using System.Text;

namespace Xin.Extensions
{
    /// <summary>
    /// Byte扩展类
    /// </summary>
    public static class ByteExtension
    {
        /// <summary>
        /// 将字节数组转换为Base64格式的字符串
        /// </summary>
        /// <param name="array">字节数组</param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }

        /// <summary>
        /// 将字节数组转换为UTF8格式的字符串
        /// </summary>
        /// <param name="array">字节数组</param>
        /// <returns></returns>
        public static string ToUTF8String(this byte[] array)
        {
            return Encoding.UTF8.GetString(array);
        }
    }
}
