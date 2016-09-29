using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin.Tabulation
{
    /// <summary>
    /// thead/tbody/tfoot
    /// </summary>
    public class TPart : IEnumerable<TRow>
    {
        /// <summary>
        /// 单元格填充状态
        /// </summary>
        internal List<List<bool>> cellStatus;

        /// <summary>
        /// 行集合
        /// </summary>
        public List<TRow> Rows { get; set; }

        /// <summary>
        /// table
        /// </summary>
        public Table Table { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="table"></param>
        internal TPart(Table table)
        {
            Table = table;
            Rows = new List<TRow>();
            cellStatus = new List<List<bool>>();
        }

        /// <summary>
        /// 添加tr
        /// </summary>
        /// <param name="cssClass">css类</param>
        /// <returns></returns>
        public TRow AddTr(string cssClass = null)
        {
            int index = Rows.Count;
            TRow tr = new TRow(this, index, cssClass);
            Rows.Add(tr);
            if (index == cellStatus.Count)
            {
                cellStatus.Add(new List<bool>());
            }
            return tr;
        }

        /// <summary>
        /// 填充单元格
        /// </summary>
        /// <param name="row">行</param>
        /// <param name="col">列</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        internal void Fill(int row, int col, int rowspan, int colspan)
        {
            while ((row + rowspan) > cellStatus.Count)
            {
                cellStatus.Add(new List<bool>());
            }
            for (int i = 0; i < rowspan; i++)
            {
                List<bool> status = cellStatus[row + i];
                while ((col + colspan) > status.Count)
                {
                    status.Add(true);
                }
                for (int j = 0; j < colspan; j++)
                {
                    status[col + j] = false;
                }
            }
        }

        /// <summary>
        /// 获取某行的可用列
        /// </summary>
        /// <param name="row">行</param>
        /// <returns></returns>
        internal int GetIndex(int row)
        {
            List<bool> status = cellStatus[row];
            int index = 0;
            if (status.Any())
            {
                bool full = true;
                for (int i = 0; i < status.Count; i++)
                {
                    if (status[i])
                    {
                        index = i;
                        full = false;
                        break;
                    }
                }
                if (full) index = status.Count;
            }
            return index;
        }

        /// <summary>
        /// 返回一个循环访问集合的枚举器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TRow> GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        /// <summary>
        /// 返回一个循环访问集合的枚举器
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Rows.GetEnumerator();
        }
    }
}
