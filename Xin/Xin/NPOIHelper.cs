using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using Xin.Tabulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Xin
{
    /// <summary>
    /// NPOI封装
    /// </summary>
    public class NPOIHelper
    {
        private static IWorkbook GetWorkbook(Table table, int colSplit = 0)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");
            #region 样式
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            IFont font = workbook.CreateFont();
            font.FontHeight = 14;
            font.FontName = "宋体";
            style.SetFont(font);
            ICellStyle thStyle = workbook.CreateCellStyle();
            thStyle.CloneStyleFrom(style);
            IFont thFont = workbook.CreateFont();
            thFont.FontHeight = 14;
            thFont.FontName = "宋体";
            thFont.IsBold = true;
            thStyle.SetFont(thFont);
            #endregion
            #region 填充thead
            foreach (TRow tr in table.Thead)
            {
                IRow row = sheet.CreateRow(tr.Index);
                foreach (TCell th in tr)
                {
                    ICell cell = row.CreateCell(th.Index);
                    cell.SetCellValue(th.Value);
                    cell.CellStyle = thStyle;
                    if (th.Rowspan > 1 || th.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + th.Rowspan - 1, th.Index, th.Index + th.Colspan - 1));
                    }
                }
            }
            #endregion
            #region 填充tbody
            int rowNum = table.Thead.Rows.Count;
            foreach (TRow tr in table.Tbody)
            {
                tr.Index += rowNum;
                IRow row = sheet.CreateRow(tr.Index);
                foreach (TCell td in tr)
                {
                    ICell cell = row.CreateCell(td.Index);
                    cell.SetCellValue(td.Value);
                    cell.CellStyle = style;
                    if (td.Rowspan > 1 || td.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + td.Rowspan - 1, td.Index, td.Index + td.Colspan - 1));
                    }
                }
            }
            #endregion
            #region 填充tfoot
            rowNum += table.Tbody.Rows.Count;
            foreach (TRow tr in table.Tfoot)
            {
                tr.Index += rowNum;
                IRow row = sheet.CreateRow(tr.Index);
                foreach (TCell td in tr)
                {
                    ICell cell = row.CreateCell(td.Index);
                    cell.SetCellValue(td.Value);
                    cell.CellStyle = style;
                    if (td.Rowspan > 1 || td.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + td.Rowspan - 1, td.Index, td.Index + td.Colspan - 1));
                    }
                }
            }
            #endregion
            #region 计算ColCount
            int colCount = 0;
            foreach (var status in table.Thead.cellStatus)
            {
                if (status.Count > colCount) colCount = status.Count;
            }
            foreach (var status in table.Tbody.cellStatus)
            {
                if (status.Count > colCount) colCount = status.Count;
            }
            foreach (var status in table.Tfoot.cellStatus)
            {
                if (status.Count > colCount) colCount = status.Count;
            }
            #endregion
            #region 宽度自适应
            for (int colNum = 0; colNum < colCount; colNum++)
            {
                int width = sheet.GetColumnWidth(colNum) / 256;
                foreach (IRow row in sheet)
                {
                    ICell cell = row.GetCell(colNum);
                    if (cell != null)
                    {
                        int length = Encoding.UTF8.GetBytes(cell.StringCellValue).Length;
                        if (length > width)
                        {
                            width = length;
                        }
                    }
                }
                sheet.SetColumnWidth(colNum, width * 256);
            }
            #endregion
            #region 冻结窗口
            sheet.CreateFreezePane(colSplit, table.Thead.Rows.Count);
            #endregion
            return workbook;
        }

        /// <summary>
        /// 导出Table到Excel
        /// </summary>
        /// <param name="table">table</param>
        /// <param name="colSplit">冻结列</param>
        /// <returns></returns>
        public static MemoryStream Export(Table table, int colSplit = 0)
        {
            IWorkbook workbook = GetWorkbook(table, colSplit);
            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);
            return ms;
        }

        /// <summary>
        /// 导出Table到Excel
        /// </summary>
        /// <param name="table">table</param>
        /// <param name="fileName">文件名</param>
        /// <param name="colSplit">冻结列</param>
        public static void Export(Table table, string fileName, int colSplit = 0)
        {
            IWorkbook workbook = GetWorkbook(table, colSplit);
            FileStream fs = File.Create(fileName);
            workbook.Write(fs);
            fs.Close();
        }
    }
}
