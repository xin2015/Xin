using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin
{
    /// <summary>
    /// 分页
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int Pagination { get; set; }
        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="source">集合</param>
        /// <returns></returns>
        public List<T> DoPaging<T>(IEnumerable<T> source)
        {
            Count = source.Count();
            return source.Skip((Pagination - 1) * PageSize).Take(PageSize).ToList();
        }
    }

    /// <summary>
    /// 分页工具类
    /// </summary>
    public static class PagingHelper
    {
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="paging">分页</param>
        /// <param name="source">集合</param>
        /// <returns></returns>
        public static List<T> Paging<T>(this IEnumerable<T> source, Paging paging)
        {
            return paging.DoPaging<T>(source);
        }
    }
}
