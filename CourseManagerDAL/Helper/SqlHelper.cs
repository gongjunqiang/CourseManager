using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CourseManagerDAL.Helper
{
    /// <summary>
    /// 通用数据库访问类
    /// </summary>
    public class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

   
        /// <summary>
        /// 执行insert、update、delete等sel语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int Update(string sql,SqlParameter[] parameters=null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("方法public static int Update(string sql)异常，异常信息："+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        public static object GetSignleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("方法public static object GetSignleResult(string sql)异常，异常信息：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("方法public static SqlDataReader GetReader(string sql)异常，异常信息：" + ex.Message);
            }
        }

    }
}
