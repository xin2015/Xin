using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin.Tabulation
{
    /// <summary>
    /// 表格
    /// </summary>
    public class Table
    {
        /// <summary>
        /// thead
        /// </summary>
        public TPart Thead { get; set; }
        /// <summary>
        /// tbody
        /// </summary>
        public TPart Tbody { get; set; }
        /// <summary>
        /// tfoot
        /// </summary>
        public TPart Tfoot { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Table()
        {
            Thead = new TPart(this);
            Tbody = new TPart(this);
            Tfoot = new TPart(this);
        }
    }
}
