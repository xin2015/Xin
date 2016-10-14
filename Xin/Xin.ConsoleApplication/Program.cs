using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xin.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = IPHelper.GetExtranetIPAddress();
            var b = IPHelper.GetHostIPAddress();
            string url = "http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201608/t20160809_1386477.html";
            DataTable dt = new DataTable();
            dt.Columns.Add("Code", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.TableName = "Division";
            JumonyParser jp = new JumonyParser();
            IHtmlDocument html = jp.LoadDocument(url, Encoding.UTF8);
            List<IHtmlElement> list = html.Find(".MsoNormal").ToList();
            foreach (IHtmlElement item in list)
            {
                DataRow dr = dt.NewRow();
                dr["Code"] = int.Parse(item.Elements().First().InnerText().Trim());
                dr["Name"] = item.Elements().Last().InnerText().Trim();
                dt.Rows.Add(dr);
            }
            SqlHelper.Default.Insert(dt);
        }
    }
}
