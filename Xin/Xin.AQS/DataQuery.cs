using Common.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS
{
    public static class DataQuery
    {
        static ILog logger;
        static string liveFormat;
        static string historyFormat;
        static string liveTimeFormat;

        static DataQuery()
        {
            logger = LogManager.GetLogger("DataQuery");
            liveFormat = "select * from {0}";
            historyFormat = "select * from {0} where Time between @BeginTime and @EndTime";
            liveTimeFormat = "select top 1 {1} from {0}";
        }

        #region Station
        #region Hour
        public static List<AQRPD> GetAQRPSDFromLive()
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3_24h = '—' then null else O3_24h end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from AQIDataPublishLive a join StationConfig b on a.StationCode = b.StationCode";
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPSDFromLive failed.", e);
            }
            return list;
        }

        public static List<AQRPD> GetAQRPSDFromHistory(DateTime time)
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3_24h = '—' then null else O3_24h end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint = @TimePoint";
                SqlParameter param = new SqlParameter("@TimePoint", time);
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText, param);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPSDFromHistory failed.", e);
            }
            return list;
        }

        public static List<AQRPD> GetAQRPSDFromHistory(DateTime beginTime, DateTime endTime)
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3_24h = '—' then null else O3_24h end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint between @BeginTime and @EndTime";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText, parameters);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPSDFromHistory failed.", e);
            }
            return list;
        }
        #endregion
        #region Slide
        public static List<AQDPD> GetAQSPSDFromLive()
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishLive a join StationConfig b on a.StationCode = b.StationCode";
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQSPSDFromLive failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQSPSDFromHistory(DateTime time)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint = @TimePoint";
                SqlParameter param = new SqlParameter("@TimePoint", time);
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, param);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQSPSDFromHistory failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQSPSDFromHistory(DateTime beginTime, DateTime endTime)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint between @BeginTime and @EndTime";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, parameters);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQSPSDFromHistory failed.", e);
            }
            return list;
        }
        #endregion
        #region Day
        public static List<AQDPD> GetAQDPSDFromLive()
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,dateadd(day, -1, TimePoint) Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishLive a join StationConfig b on a.StationCode = b.StationCode";
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPSDFromLive failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQDPSDFromHistory(DateTime time)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,dateadd(day, -1, TimePoint) Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint = @TimePoint";
                SqlParameter param = new SqlParameter("@TimePoint", time);
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, param);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPSDFromHistory failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQDPSDFromHistory(DateTime beginTime, DateTime endTime)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select UniqueCode Code,dateadd(day, -1, TimePoint) Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h = '—' then null else O3_8h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from AQIDataPublishHistory a join StationConfig b on a.StationCode = b.StationCode where TimePoint between @BeginTime and @EndTime and datepart(Hour,TimePoint) = 0";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, parameters);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPSDFromHistory failed.", e);
            }
            return list;
        }
        #endregion
        #endregion

        #region City
        #region Hour
        public static List<AQRPD> GetAQRPCDFromLive()
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3 = '—' then null else O3 end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from CityAQIPublishLive";
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPCDFromLive failed.", e);
            }
            return list;
        }

        public static List<AQRPD> GetAQRPCDFromHistory(DateTime time)
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3 = '—' then null else O3 end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from CityAQIPublishHistory where TimePoint = @TimePoint";
                SqlParameter param = new SqlParameter("@TimePoint", time);
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText, param);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPCDFromHistory failed.", e);
            }
            return list;
        }

        public static List<AQRPD> GetAQRPCDFromHistory(DateTime beginTime, DateTime endTime)
        {
            List<AQRPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2 = '—' then null else SO2 end) SO2,(case when NO2 = '—' then null else NO2 end) NO2,(case when PM10 = '—' then null else PM10 end) PM10,(case when CO = '—' then null else CO end) CO,(case when O3 = '—' then null else O3 end) O3,(case when PM2_5 = '—' then null else PM2_5 end) PM25 from CityAQIPublishHistory where TimePoint between @BeginTime and @EndTime";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<AQRPD>(cmdText, parameters);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQRPD>();
                logger.Error("GetAQRPCDFromHistory failed.", e);
            }
            return list;
        }
        #endregion
        #region Day
        public static List<AQDPD> GetAQDPCDFromLive()
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h_24h = '—' then null else O3_8h_24h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from CityDayAQIPublishLive";
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPCDFromLive failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQDPCDFromHistory(DateTime time)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h_24h = '—' then null else O3_8h_24h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from CityDayAQIPublishHistory where TimePoint = @TimePoint";
                SqlParameter param = new SqlParameter("@TimePoint", time);
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, param);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPCDFromHistory failed.", e);
            }
            return list;
        }

        public static List<AQDPD> GetAQDPCDFromHistory(DateTime beginTime, DateTime endTime)
        {
            List<AQDPD> list;
            try
            {
                string cmdText = "select CityCode Code,TimePoint Time,(case when SO2_24h = '—' then null else SO2_24h end) SO2,(case when NO2_24h = '—' then null else NO2_24h end) NO2,(case when PM10_24h = '—' then null else PM10_24h end) PM10,(case when CO_24h = '—' then null else CO_24h end) CO,(case when O3_8h_24h = '—' then null else O3_8h_24h end) O3,(case when PM2_5_24h = '—' then null else PM2_5_24h end) PM25 from CityDayAQIPublishHistory where TimePoint between @BeginTime and @EndTime";
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<AQDPD>(cmdText, parameters);
                list.ForEach(o => o.CalculateAQI());
            }
            catch (Exception e)
            {
                list = new List<AQDPD>();
                logger.Error("GetAQDPCDFromHistory failed.", e);
            }
            return list;
        }
        #endregion
        #endregion

        public static List<T> GetLive<T>(string tableName) where T : class, new()
        {
            List<T> list;
            try
            {
                string cmdText = string.Format(liveFormat, tableName);
                list = SqlHelper.Default.ExecuteList<T>(cmdText);
            }
            catch (Exception e)
            {
                list = new List<T>();
                logger.Error(string.Format("GetLive for {0} failed.", tableName), e);
            }
            return list;
        }

        public static DateTime GetLiveTime(string tableName, string propertyName = "Time")
        {
            DateTime time;
            try
            {
                string cmdText = string.Format(liveTimeFormat, tableName, propertyName);
                object temp = SqlHelper.Default.ExecuteScalar(cmdText);
                if (!Convert.IsDBNull(temp)) time = (DateTime)temp;
                else time = DateTime.MinValue;
            }
            catch (Exception e)
            {
                time = DateTime.MinValue;
                logger.Error(string.Format("GetLiveTime for {0} failed.", tableName), e);
            }
            return time;
        }

        public static List<T> GetHistory<T>(string tableName, DateTime beginTime, DateTime endTime) where T : class, new()
        {
            List<T> list;
            try
            {
                string cmdText = string.Format(historyFormat, tableName);
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@BeginTime",beginTime),
                    new SqlParameter("@EndTime",endTime)
                };
                list = SqlHelper.Default.ExecuteList<T>(cmdText, parameters);
            }
            catch (Exception e)
            {
                list = new List<T>();
                logger.Error(string.Format("GetHistory for {0} failed.", tableName), e);
            }
            return list;
        }
    }
}
