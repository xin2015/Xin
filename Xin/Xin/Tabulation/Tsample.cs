using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Tabulation
{
    /// <summary>
    /// Table使用示例
    /// </summary>
    public class Tsample
    {
        /// <summary>
        /// 导出空气质量指数日报
        /// </summary>
        public static void ExportDayAQIReport()
        {
            Table table = new Table();
            #region thead
            TRow tr = table.Thead.AddTr();
            tr.AddTh(DateTime.Today.ToString("yyyy年MM月dd日"), 1, 21);
            tr = table.Thead.AddTr();
            tr.AddTh("城市名称", 4, 1);
            tr.AddTh("监测点位名称", 4, 1);
            tr.AddTh("污染物浓度及空气质量分指数（IAQI）", 1, 14);
            tr.AddTh("空气质量指数（AQI）", 4, 1);
            tr.AddTh("首要污染物", 4, 1);
            tr.AddTh("空气质量指数级别", 4, 1);
            tr.AddTh("空气质量指数类别", 2, 2);
            tr = table.Thead.AddTr();
            tr.AddTh("二氧化硫（SO2）24小时平均", 2, 2);
            tr.AddTh("二氧化氮（NO2）24小时平均", 2, 2);
            tr.AddTh("颗粒物（粒径小于等于10μm）24小时平均", 2, 2);
            tr.AddTh("一氧化碳（CO）24小时平均", 2, 2);
            tr.AddTh("臭氧（O3）最大1小时平均", 2, 2);
            tr.AddTh("臭氧（O3）最大8小时滑动平均", 2, 2);
            tr.AddTh("颗粒物（粒径小于等于2.5μm）24小时平均", 2, 2);
            tr = table.Thead.AddTr();
            tr.AddTh("类别", 2, 1);
            tr.AddTh("颜色", 2, 1);
            tr = table.Thead.AddTr();
            for (int i = 0; i < 7; i++)
            {
                if (i == 3) tr.AddTh("浓度/（mg/m³）");
                else tr.AddTh("浓度/（μg/m³）");
                tr.AddTh("分指数");
            }
            #endregion
            #region tfoot
            tr = table.Tfoot.AddTr();
            tr.AddTd("注：缺测指标的浓度及分指数均使用NA标识。");
            #endregion
            #region tbody
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                tr = table.Tbody.AddTr();
                tr.AddTd("广州");
                tr.AddTd("未知点位");
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(10).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(100).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd(rand.Next(50).ToString());
                tr.AddTd("NA");
                tr.AddTd("一级");
                tr.AddTd("优");
                tr.AddTd("绿色");
            }
            #endregion
            NPOIHelper.Export(table, "DayAQIReport.xlsx", 2);
        }
    }
}
