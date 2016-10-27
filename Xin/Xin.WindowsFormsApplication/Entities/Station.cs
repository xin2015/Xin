using Common.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.WindowsFormsApplication.Entities
{
    public class Station
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string UniqueCode { get; set; }
    }

    public class StationRepository
    {
        private static ILog logger = LogManager.GetLogger<StationRepository>();
        public static List<Station> GetAllList(SqlHelper sh)
        {
            List<Station> list;
            try
            {
                string cmdText = string.Format("select StationCode Code,PositionName Name,UniqueCode from Station");
                list = sh.ExecuteList<Station>(cmdText);
            }
            catch (SqlException e)
            {
                list = new List<Station>();
                logger.Error("", e);
            }
            catch (Exception e)
            {
                list = new List<Station>();
                logger.Fatal("", e);
            }
            return list;
        }
    }
}
