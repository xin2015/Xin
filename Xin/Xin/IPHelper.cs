using DotNet4.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Xin.Extensions;

namespace Xin
{
    /// <summary>
    /// IP工具类
    /// </summary>
    public class IPHelper
    {
        /// <summary>
        /// 通过访问IP地址查询网站获取外网IP
        /// </summary>
        /// <returns>外网IP</returns>
        public static string GetExtranetIPAddress()
        {
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem()
            {
                URL = "http://www.whatismyip.com.tw/"   //备用地址：http://www.ip138.com/
            };
            HttpResult hr = hh.GetHtml(hi);
            int a = hr.Html.IndexOf("<h2>") + 4;
            int b = hr.Html.IndexOf("</h2>");
            return hr.Html.Substr(a, b);
        }

        /// <summary>
        /// 获取本机IPv4地址
        /// </summary>
        /// <returns>本机IPv4地址</returns>
        public static List<string> GetHostInterNetworkAddresses()
        {
            return Dns.GetHostAddresses(Dns.GetHostName()).Where(o => o.AddressFamily == AddressFamily.InterNetwork).Select(o => o.ToString()).ToList();
        }

        /// <summary>
        /// 获取IPv4、IPv6地址
        /// </summary>
        /// <returns>本机IP地址</returns>
        public static List<string> GetHostAddresses()
        {
            return Dns.GetHostAddresses(Dns.GetHostName()).Select(o => o.ToString()).ToList();
        }
    }
}
