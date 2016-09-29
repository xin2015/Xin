using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin.Tabulation
{
    /// <summary>
    /// tr
    /// </summary>
    public class TRow : IEnumerable<TCell>
    {
        /// <summary>
        /// 单元格集合
        /// </summary>
        public List<TCell> Cells { get; set; }

        /// <summary>
        /// 行
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// thead/tbody/tfoot
        /// </summary>
        public TPart Part { get; set; }

        /// <summary>
        /// HTML中的类
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="part">thead/tbody/tfoot</param>
        /// <param name="index">行</param>
        /// <param name="cssClass">css类</param>
        internal TRow(TPart part, int index, string cssClass)
        {
            Part = part;
            Cells = new List<TCell>();
            Index = index;
            Class = cssClass;
        }

        /// <summary>
        /// 添加th
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="cssClass">css类</param>
        /// <returns></returns>
        public Th AddTh(string value, int rowspan = 1, int colspan = 1, string cssClass = null)
        {
            int index = Part.GetIndex(Index);
            Th th = new Th(this, value, index, rowspan, colspan, cssClass);
            Cells.Add(th);
            Part.Fill(Index, th.Index, th.Rowspan, th.Colspan);
            return th;
        }

        /// <summary>
        /// 添加td
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="cssClass">css类</param>
        /// <returns></returns>
        public Td AddTd(string value, int rowspan = 1, int colspan = 1, string cssClass = null)
        {
            int index = Part.GetIndex(Index);
            Td td = new Td(this, value, index, rowspan, colspan, cssClass);
            Cells.Add(td);
            Part.Fill(Index, td.Index, td.Rowspan, td.Colspan);
            return td;
        }

        /// <summary>
        /// 返回一个循环访问集合的枚举器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TCell> GetEnumerator()
        {
            return Cells.GetEnumerator();
        }

        /// <summary>
        /// 返回一个循环访问集合的枚举器
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cells.GetEnumerator();
        }
    }
}
