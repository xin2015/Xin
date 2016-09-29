using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin
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
    }
}
