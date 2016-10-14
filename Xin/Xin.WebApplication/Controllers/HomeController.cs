using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Xin.AQS.AQE;
using Xin.Tabulation;

namespace Xin.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string encryptedString = CryptogramHelper.Encrypt(string.Format("EnvQFWS_MZ$admin${0}", DateTime.Now));

            ViewData.Model = encryptedString;
            //ViewData.Model = HttpUtility.UrlEncode(encryptedString);
            return View();
        }

        public JsonResult GetIPAddress()
        {
            string ip = Request.UserHostAddress;
            return Json(ip, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Test(string encryptedString)
        {
            string originalString = CryptogramHelper.Decrypt(encryptedString);
            return Json(originalString, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionName("联系方式")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DayAQIReport()
        {
            Random rand = new Random();
            List<DayAQIReport> list = new List<DayAQIReport>();
            for (int i = 0; i < 100; i++)
            {
                DayAQIReport data = new DayAQIReport();
                data.SO2 = rand.Next(300);
                data.NO2 = rand.Next(150);
                data.PM10 = rand.Next(250);
                data.CO = rand.Next(10);
                data.O3 = rand.Next(200);
                data.PM25 = rand.Next(100);
                data.CalculateAQIReport();
                list.Add(data);
            }
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
            tr.AddTd("注：缺测指标的浓度及分指数均使用NA标识。", 1, 21);
            #endregion
            #region tbody
            list.ForEach(o =>
            {
                tr = table.Tbody.AddTr();
                tr.AddTd("广州");
                tr.AddTd("未知点位");
                tr.AddTd(o.SO2.ToString());
                tr.AddTd(o.ISO2.ToString());
                tr.AddTd(o.NO2.ToString());
                tr.AddTd(o.INO2.ToString());
                tr.AddTd(o.PM10.ToString());
                tr.AddTd(o.IPM10.ToString());
                tr.AddTd(o.CO.ToString());
                tr.AddTd(o.ICO.ToString());
                tr.AddTd(o.O3.ToString());
                tr.AddTd(o.IO3.ToString());
                tr.AddTd(o.O3.ToString());
                tr.AddTd(o.IO3.ToString());
                tr.AddTd(o.PM25.ToString());
                tr.AddTd(o.IPM25.ToString());
                tr.AddTd(o.AQI.ToString());
                tr.AddTd(o.PrimaryPollutant);
                tr.AddTd(o.Level);
                tr.AddTd(o.Type);
                tr.AddTd(o.Color);
            });
            #endregion
            ViewData.Model = table;
            return View();
        }

        public FileResult ExportDayAQIReport(int count)
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
            for (int i = 0; i < count; i++)
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
            return File(NPOIHelper.Export(table, 2).ToArray(), "application / vnd.ms - excel", "空气质量指数日报.xlsx");
        }

        public ActionResult My97DatePicker(DateTime? beginTime, DateTime? endTime)
        {
            beginTime = beginTime ?? DateTime.Today;
            endTime = endTime ?? DateTime.Now;
            ViewData["beginTime"] = beginTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            ViewData["endTime"] = endTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            return View();
        }
    }
}