using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.TopshelfQuartz
{
    public class Configuration
    {
        public static string Description { get; set; }
        public static string DisplayName { get; set; }
        public static string ServiceName { get; set; }
        public static string SyncAQRPSDJobCronExpression { get; set; }
        public static string SyncAQRPCDJobCronExpression { get; set; }
        public static string SyncAQDPSDJobCronExpression { get; set; }
        public static string SyncAQDPCDJobCronExpression { get; set; }
        public static string FastRecoverRDJobCronExpression { get; set; }
        public static string FastRecoverDDJobCronExpression { get; set; }
        static Configuration()
        {
            Description = ConfigurationManager.AppSettings["Description"];
            DisplayName = ConfigurationManager.AppSettings["DisplayName"];
            ServiceName = ConfigurationManager.AppSettings["ServiceName"];
            SyncAQRPSDJobCronExpression = ConfigurationManager.AppSettings["SyncAQRPSDJobCronExpression"];
            SyncAQRPCDJobCronExpression = ConfigurationManager.AppSettings["SyncAQRPCDJobCronExpression"];
            SyncAQDPSDJobCronExpression = ConfigurationManager.AppSettings["SyncAQDPSDJobCronExpression"];
            SyncAQDPCDJobCronExpression = ConfigurationManager.AppSettings["SyncAQDPCDJobCronExpression"];
            FastRecoverRDJobCronExpression = ConfigurationManager.AppSettings["FastRecoverRDJobCronExpression"];
            FastRecoverDDJobCronExpression = ConfigurationManager.AppSettings["FastRecoverDDJobCronExpression"];

            string defaultService = "SyncService";
            Description = string.IsNullOrWhiteSpace(Description) ? defaultService : Description;
            DisplayName = string.IsNullOrWhiteSpace(DisplayName) ? defaultService : DisplayName;
            ServiceName = string.IsNullOrWhiteSpace(ServiceName) ? defaultService : ServiceName;
        }
    }
}
