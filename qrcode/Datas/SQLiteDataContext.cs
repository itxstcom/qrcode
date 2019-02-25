/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data.SQLite;
using System.Reflection;
using System.Data; 

namespace QRCode.Datas
{
 
   
    /// <summary>
    /// SQLite数据库帮助类
    /// </summary>
    public class SQLiteHelper
    {
        /// <summary>
        /// 数据库路径
        /// </summary>
        //private static readonly string m_DataSource = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// ConnectionString样例：Data Source=Test.db;Pooling=true;FailIfMissing=false
        /// </summary>
        private static readonly string m_DataSource = "Data Source="+AppDomain.CurrentDomain.BaseDirectory+"qrcode.db;Pooling=true;FailIfMissing=false";
        private static readonly string m_ConnectionString = "";
        /// <summary>
        /// 静态构造函数，初始化连接字符串，检查数据库连接
        /// </summary>
        static SQLiteHelper()
        {
            try
            {
                

                //SQLiteConnectionStringBuilder connectionStringBuilder = new SQLiteConnectionStringBuilder
                //{
                //    Version = 3,
                //    Pooling = true,
                //    FailIfMissing = false 
                //};
                //  m_ConnectionString = connectionStringBuilder.ConnectionString;
                //using (SQLiteConnection conn = new SQLiteConnection(m_ConnectionString))
                //{
                //    conn.Open();
                //}
            }
            catch { }
        }

        #region basic method

        /// <summary>
        /// 获得连接对象
        /// </summary>
        /// <returns></returns>
        private static SQLiteConnection GetSQLiteConnection()
        {
             

            return new SQLiteConnection(m_DataSource);
        }

        /// <summary>
        /// 预备命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandParameters"></param>
        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string cmdText, params object[] commandParameters)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Parameters.Clear();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            if (commandParameters != null)
            {
                foreach (object parm in commandParameters)
                    cmd.Parameters.AddWithValue(string.Empty, parm);

                //for (int i = 0; i < p.Length; i++)
                //    cmd.Parameters[i].Value = p[i];
            }
        }

        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecuteNonQuery(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand command = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 返回表集合
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(string cmdText, params object[] commandParameters)
        {
            DataSet ds = new DataSet();
            SQLiteCommand command = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 返回SqlDataReader对象
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回SQLiteDataReader</returns>
        public static SQLiteDataReader ExecuteReader(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand command = new SQLiteCommand();
            SQLiteConnection connection = GetSQLiteConnection();
            try
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                SQLiteDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            {
                connection.Close();
                throw;
            }
        }

        /// <summary>
        /// 返回表第一行
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回：第一行</returns>
        public static DataRow ExecuteDataRow(string cmdText, params object[] commandParameters)
        {
            DataSet ds = ExecuteDataset(cmdText, commandParameters);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0];
            return null;
        }

        /// <summary>
        /// 返回结果集中的第一行第一列，忽略其他行或列
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回：第一行第一列</returns>
        public static object ExecuteScalar(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(cmd, connection, cmdText, commandParameters);
                return cmd.ExecuteScalar();
            }
        }

        #endregion


        #region advanced method

        ///// <summary>
        ///// 获取表所有数据
        ///// </summary>
        ///// <typeparam name="T">实体类型</typeparam>
        ///// <param name="tableName">表名</param>
        ///// <returns>表所有数据</returns>
        //public static List<T> GetTableData<T>(string tableName) where T : class
        //{
        //    List<T> dataList = new List<T>();
        //    try
        //    {
        //        using (SqliteDataContext context = new SqliteDataContext(new SQLiteConnection(m_ConnectionString)))
        //        {
        //            string sql = "select * from " + tableName;
        //            dataList = context.ExecuteQuery<T>(sql).ToList();
        //            context.SubmitChanges();
        //        }
        //    }
        //    catch { }
        //    return dataList;
        //}

        ///// <summary>
        ///// 获取表数据
        ///// </summary>
        ///// <typeparam name="T">实体类型</typeparam>
        ///// <param name="cmdText">sql语句</param>
        ///// <param name="parameter">参数</param>
        ///// <returns>表所有数据</returns>
        //public static List<T> GetTableData<T>(string cmdText, params object[] parameter) where T : class
        //{
        //    List<T> dataList = new List<T>();
        //    try
        //    {
        //        using (SqliteDataContext context = new SqliteDataContext(new SQLiteConnection(m_ConnectionString)))
        //        {
        //            dataList = context.ExecuteQuery<T>(cmdText, parameter).ToList();
        //        }
        //    }
        //    catch { }
        //    return dataList;
        //}

        /// <summary>
        /// 插入表数据
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="dataList">数据集合</param>
        /// <returns>true或false</returns>
        public static bool BatchInsert<T>(string tableName, List<T> dataList)
        {
            try
            {
                if (dataList != null && dataList.Count > 0)
                {
                    var temp = dataList[0];
                    PropertyInfo[] propertyInfos = temp.GetType().GetProperties();
                    List<string> propertyStrs = new List<string>();
                    string propertyStr = "";
                    foreach (var propertyInfo in propertyInfos)
                    {
                        propertyStrs.Add(propertyInfo.Name);
                        propertyStr = propertyStr + "@" + propertyInfo.Name + ",";
                    }
                    propertyStr = propertyStr.Remove(propertyStr.Length - 1);

                    using (SQLiteConnection conn = new SQLiteConnection(m_ConnectionString))
                    {
                        using (SQLiteCommand command = new SQLiteCommand(conn))
                        {
                            command.Connection.Open();
                            using (SQLiteTransaction transaction = conn.BeginTransaction())
                            {
                                command.Transaction = transaction;
                                command.CommandText = "insert into " + tableName + " values(" + propertyStr + ")";
                                foreach (var needInsertData in dataList)
                                {
                                    command.Parameters.Clear();
                                    for (int i = 0; i < propertyStrs.Count; i++)
                                    {
                                        command.Parameters.AddWithValue("@" + propertyStrs[i], propertyInfos[i].GetValue(needInsertData, null));
                                    }
                                    command.ExecuteNonQuery();
                                }
                                transaction.Commit();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 删除表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>true或false</returns>
        public static bool DeleteTableData(string tableName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(m_ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        command.Connection.Open();
                        command.CommandText = "delete from " + tableName;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
 


}
