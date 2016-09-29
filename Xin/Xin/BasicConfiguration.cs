using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class BasicConfiguration
    {
        /// <summary>
        /// 默认数据库连接
        /// </summary>
        public static string DefaultConnection { get; set; }
        /// <summary>
        /// 邮件服务器
        /// </summary>
        public static string MailHost { get; set; }
        /// <summary>
        /// 邮箱用户名
        /// </summary>
        public static string MailUsername { get; set; }
        /// <summary>
        /// 邮箱密码
        /// </summary>
        public static string MailPassword { get; set; }

        static BasicConfiguration()
        {
            DefaultConnection = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MailHost = System.Configuration.ConfigurationManager.AppSettings["MailHost"];
            MailUsername = System.Configuration.ConfigurationManager.AppSettings["MailUsername"];
            MailPassword = System.Configuration.ConfigurationManager.AppSettings["MailPassword"];

            MailHost = string.IsNullOrWhiteSpace(MailHost) ? "smtp.126.com" : MailHost;
            MailUsername = string.IsNullOrWhiteSpace(MailUsername) ? "zzfxdhz@126.com" : MailUsername;
            MailPassword = string.IsNullOrWhiteSpace(MailPassword) ? "ms5lmxin" : MailPassword;
        }
    }
}
