using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin.Tabulation
{
    /// <summary>
    /// 单元格
    /// </summary>
    public class TCell
    {
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 跨行
        /// </summary>
        public int Rowspan { get; set; }
        /// <summary>
        /// 跨列
        /// </summary>
        public int Colspan { get; set; }
        /// <summary>
        /// 列
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 行
        /// </summary>
        public TRow Row { get; set; }
        /// <summary>
        /// HTML中的css类
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="tr">行</param>
        /// <param name="value">值</param>
        /// <param name="index">列</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="cssClass">css类</param>
        internal TCell(TRow tr, string value, int index, int rowspan, int colspan, string cssClass)
        {
            Row = tr;
            Value = value;
            Index = index;
            Rowspan = rowspan;
            Colspan = colspan;
            Class = cssClass;
        }
    }

    /// <summary>
    /// th
    /// </summary>
    public class Th : TCell
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="tr">行</param>
        /// <param name="value">值</param>
        /// <param name="index">列</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="cssClass">css类</param>
        internal Th(TRow tr, string value, int index, int rowspan, int colspan, string cssClass) : base(tr, value, index, rowspan, colspan, cssClass) { }
    }

    /// <summary>
    /// td
    /// </summary>
    public class Td : TCell
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="tr">行</param>
        /// <param name="value">值</param>
        /// <param name="index">列</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="cssClass">css类</param>
        internal Td(TRow tr, string value, int index, int rowspan, int colspan, string cssClass) : base(tr, value, index, rowspan, colspan, cssClass) { }
    }
}
