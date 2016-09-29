using Common.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.TopshelfQuartz
{
    public class MissingData
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }
        public int MissTimes { get; set; }
        public bool Status { get; set; }
        public string Exception { get; set; }
        public string MCode { get; set; }
        public string PCode { get; set; }
        public DateTime CTime { get; set; }

        public MissingData()
        {
            MCode = string.Empty;
            PCode = string.Empty;
        }
    }

    public class MissingDataHelper
    {
        static ILog logger;
        static string selectByCode;
        static string selectByTime;
        static string selectForFastRecover;
        static string insertOne;
        static string updateOne;
        static int maxMissTimes;

        static MissingDataHelper()
        {
            logger = LogManager.GetLogger<MissingDataHelper>();
            string tableName = "MissingData";
            selectByCode = string.Format("select * from {0} where Code = @Code and Status = 0", tableName);
            selectByTime = string.Format("select * from {0} where CTime = @CTime and Status = 0", tableName);
            selectForFastRecover = string.Format("select * from {0} where Status = 0 and MissTimes = 0", tableName);
            insertOne = string.Format("insert into {0} (Code,Time,MissTimes,Status,Exception,MCode,PCode,CTime) values (@Code,@Time,@MissTimes,@Status,@Exception,@MCode,@PCode,@CTime)", tableName);
            updateOne = string.Format("update {0} set Time = @Time,MissTimes = @MissTimes,Status = @Status,Exception = @Exception where Code = @Code and CTime = @CTime", tableName);
            maxMissTimes = 30;
        }

        public static List<MissingData> GetList()
        {
            List<MissingData> list;
            try
            {
                list = SqlHelper.Default.ExecuteList<MissingData>(selectForFastRecover);
            }
            catch (Exception e)
            {
                list = new List<MissingData>();
                logger.Error("GetList failed.", e);
            }
            return list;
        }

        public static List<MissingData> GetList(string code)
        {
            return GetList(code, maxMissTimes);
        }

        public static List<MissingData> GetList(string code, int maxMissTimes)
        {
            List<MissingData> list;
            try
            {
                SqlParameter param = new SqlParameter("@Code", code);
                list = SqlHelper.Default.ExecuteList<MissingData>(selectByCode, param);
            }
            catch (Exception e)
            {
                list = new List<MissingData>();
                logger.Error("GetList failed.", e);
            }
            return list;
        }

        public static List<MissingData> GetList(DateTime time)
        {
            List<MissingData> list;
            try
            {
                SqlParameter param = new SqlParameter("@CTime", time);
                list = SqlHelper.Default.ExecuteList<MissingData>(selectByTime, param);
            }
            catch (Exception e)
            {
                list = new List<MissingData>();
                logger.Error("GetList failed.", e);
            }
            return list;
        }

        public static void Insert(MissingData missingData)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Code",missingData.Code),
                    new SqlParameter("@Time",missingData.Time),
                    new SqlParameter("@MissTimes",missingData.MissTimes),
                    new SqlParameter("@Status",missingData.Status),
                    new SqlParameter("@Exception",missingData.Exception),
                    new SqlParameter("@MCode",missingData.MCode),
                    new SqlParameter("@PCode",missingData.PCode),
                    new SqlParameter("@CTime",missingData.CTime)
                };
                SqlHelper.Default.ExecuteNonQuery(insertOne, parameters);
            }
            catch (Exception e)
            {
                logger.Error("Insert failed.", e);
            }
        }

        public static void Update(MissingData missingData)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Code",missingData.Code),
                    new SqlParameter("@Time",missingData.Time),
                    new SqlParameter("@MissTimes",missingData.MissTimes),
                    new SqlParameter("@Status",missingData.Status),
                    new SqlParameter("@Exception",missingData.Exception),
                    new SqlParameter("@CTime",missingData.CTime)
                };
                SqlHelper.Default.ExecuteNonQuery(updateOne, parameters);
            }
            catch (Exception e)
            {
                logger.Error("Update failed.", e);
            }
        }

        public static void Update(List<MissingData> list)
        {
            list.ForEach(o => Update(o));
        }
    }
}
