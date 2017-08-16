using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xin.Tabulation;

namespace Xin
{
    /// <summary>
    /// NPOI Word 封装
    /// </summary>
    public class NPOIWordHelper
    {
        private static XWPFDocument GetDocument(Table table)
        {
            int headRowCount = table.Thead.cellStatus.Count, bodyRowCount = table.Tbody.cellStatus.Count, footRowCount = table.Tfoot.cellStatus.Count;
            int colCount = 0, rowCount = headRowCount + bodyRowCount + footRowCount;
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
            XWPFDocument doc = new XWPFDocument();
            XWPFTable xt = doc.CreateTable(rowCount, colCount);
            for(int row = 0; row < headRowCount; row++)
            {
                XWPFTableRow xr;
                TRow tr = table.Thead.FirstOrDefault(o => o.Index == row);
                if (tr == null)
                {
                    XWPFTableCell cell = xr.CreateCell();
                    CT_Tc cttc = cell.GetCTTc();
                    CT_TcPr tcpr = cttc.AddNewTcPr();
                    tcpr.AddNewVMerge().val = ST_Merge.@continue;
                }
                else
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        TCell cell = tr.FirstOrDefault(o => o.Index == col);
                        if (cell == null)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }
            #region 填充thead
            int row = 0, col = 0;
            foreach (TRow tr in table.Thead)
            {
                XWPFTableRow xr;
                if (row < tr.Index)
                {
                    while (row++ < tr.Index)
                    {
                        xr = xt.CreateRow();
                        XWPFTableCell cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                    }
                }
                xr = xt.CreateRow();
                foreach (TCell th in tr)
                {
                    XWPFTableCell cell;
                    if (col < th.Index)
                    {
                        cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                        col = th.Index;
                    }
                    cell = xr.CreateCell();
                    cell.SetText(th.Value);
                    if (th.Colspan > 1)
                    {
                        xr.MergeCells(th.Index + 1, th.Index + th.Colspan);
                        col += th.Colspan - 1;
                    }
                    if (th.Rowspan > 1)
                    {
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.restart;
                        tcpr.AddNewVAlign().val = ST_VerticalJc.center;
                    }
                    col++;
                }
                row++;
            }
            #endregion
            #region 填充tbody
            foreach (TRow tr in table.Tbody)
            {
                XWPFTableRow xr;
                if (row < tr.Index)
                {
                    while (row++ < tr.Index)
                    {
                        xr = xt.CreateRow();
                        XWPFTableCell cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                    }
                }
                xr = xt.CreateRow();
                foreach (TCell td in tr)
                {
                    XWPFTableCell cell;
                    if (col < td.Index)
                    {
                        cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                        col = td.Index;
                    }
                    cell = xr.CreateCell();
                    cell.SetText(td.Value);
                    if (td.Colspan > 1)
                    {
                        xr.MergeCells(td.Index + 1, td.Index + td.Colspan);
                        col += td.Colspan - 1;
                    }
                    if (td.Rowspan > 1)
                    {
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.restart;
                        tcpr.AddNewVAlign().val = ST_VerticalJc.center;
                    }
                }
            }
            #endregion
            #region 填充tfoot
            foreach (TRow tr in table.Tfoot)
            {
                XWPFTableRow xr;
                if (row < tr.Index)
                {
                    while (row++ < tr.Index)
                    {
                        xr = xt.CreateRow();
                        XWPFTableCell cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                    }
                }
                xr = xt.CreateRow();
                foreach (TCell td in tr)
                {
                    XWPFTableCell cell;
                    if (col < td.Index)
                    {
                        cell = xr.CreateCell();
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.@continue;
                        col = td.Index;
                    }
                    cell = xr.CreateCell();
                    cell.SetText(td.Value);
                    if (td.Colspan > 1)
                    {
                        xr.MergeCells(td.Index + 1, td.Index + td.Colspan);
                        col += td.Colspan - 1;
                    }
                    if (td.Rowspan > 1)
                    {
                        CT_Tc cttc = cell.GetCTTc();
                        CT_TcPr tcpr = cttc.AddNewTcPr();
                        tcpr.AddNewVMerge().val = ST_Merge.restart;
                        tcpr.AddNewVAlign().val = ST_VerticalJc.center;
                    }
                }
            }
            #endregion
            return doc;
        }

        public static MemoryStream Export(Table table)
        {
            XWPFDocument doc = GetDocument(table);
            MemoryStream ms = new MemoryStream();
            doc.Write(ms);
            return ms;
        }

        public static void Export(Table table, string fileName)
        {
            XWPFDocument doc = GetDocument(table);
            FileStream fs = File.Create(fileName);
            doc.Write(fs);
            fs.Close();
        }
    }
}
