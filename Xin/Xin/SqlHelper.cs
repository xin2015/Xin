using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Xin
{
    /// <summary>
    /// 数据库工具类
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; private set; }
        /// <summary>
        /// 默认实例
        /// </summary>
        public static SqlHelper Default { get; private set; }

        static SqlHelper()
        {
            string connectionString = BasicConfiguration.DefaultConnection;
            Default = new SqlHelper(connectionString);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        public SqlHelper(string connectionString)
        {
            ConnectionString = connectionString;
        }

        #region SqlCommand
        public SqlCommand GetInitSqlCommand(SqlConnection conn, CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            if (cmdParameters.Any())
            {
                cmd.Parameters.AddRange(cmdParameters);
            }
            return cmd;
        }

        public SqlCommand GetInitSqlCommand(SqlConnection conn, string cmdText, params SqlParameter[] cmdParameters)
        {
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (cmdParameters.Any())
            {
                cmd.Parameters.AddRange(cmdParameters);
            }
            return cmd;
        }
        #endregion
        #region ExecuteNonQuery
        /// <summary>
        /// 执行无返回数据命令
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public int ExecuteNonQuery(CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = GetInitSqlCommand(conn, cmdType, cmdText, cmdParameters);
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// 执行无返回数据命令
        /// </summary>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string cmdText, params SqlParameter[] cmdParameters)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = GetInitSqlCommand(conn, cmdText, cmdParameters);
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }
        #endregion
        #region ExecuteScalar
        /// <summary>
        /// 执行返回单行单列数据命令
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public object ExecuteScalar(CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            object result;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = GetInitSqlCommand(conn, cmdType, cmdText, cmdParameters);
                result = cmd.ExecuteScalar();
            }
            return result;
        }

        /// <summary>
        /// 执行返回单行单列数据命令
        /// </summary>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public object ExecuteScalar(string cmdText, params SqlParameter[] cmdParameters)
        {
            object result;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = GetInitSqlCommand(conn, cmdText, cmdParameters);
                result = cmd.ExecuteScalar();
            }
            return result;
        }
        #endregion
        #region ExecuteDataTable
        /// <summary>
        /// 执行返回数据库表命令
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetInitSqlCommand(conn, cmdType, cmdText, cmdParameters));
                adapter.Fill(result);
            }
            return result;
        }

        /// <summary>
        /// 执行返回数据库表命令
        /// </summary>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string cmdText, params SqlParameter[] cmdParameters)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetInitSqlCommand(conn, cmdText, cmdParameters));
                adapter.Fill(result);
            }
            return result;
        }
        #endregion
        #region ExecuteList
        /// <summary>
        /// 执行返回List命令
        /// </summary>
        /// <typeparam name="T">数据元类型</typeparam>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public List<T> ExecuteList<T>(CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters) where T : class, new()
        {
            DataTable dt = ExecuteDataTable(cmdType, cmdText, cmdParameters);
            return dt.GetList<T>();
        }

        /// <summary>
        /// 执行返回List命令
        /// </summary>
        /// <typeparam name="T">数据元类型</typeparam>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdParameters">命令参数</param>
        /// <returns></returns>
        public List<T> ExecuteList<T>(string cmdText, params SqlParameter[] cmdParameters) where T : class, new()
        {
            DataTable dt = ExecuteDataTable(cmdText, cmdParameters);
            return dt.GetList<T>();
        }
        #endregion
        #region Insert by SqlBulkCopy
        /// <summary>
        /// 插入数据库表
        /// </summary>
        /// <param name="dt">数据库表</param>
        public void Insert(DataTable dt)
        {
            using (SqlBulkCopy sbc = new SqlBulkCopy(ConnectionString))
            {
                sbc.DestinationTableName = dt.TableName;
                sbc.BatchSize = 50000;
                foreach (DataColumn item in dt.Columns)
                {
                    sbc.ColumnMappings.Add(item.ColumnName, item.ColumnName);
                }
                sbc.WriteToServer(dt);
            }
        }
        #endregion
    }
}
