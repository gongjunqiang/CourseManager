using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagerModel;
using CourseManagerDAL;
using CourseManagerDAL.Helper;
using System.Data.SqlClient;
using System.Data;

namespace CourseManagerDAL
{
    public class TeacherService
    {

        /// <summary>
        /// 讲师登录
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public Teacher AdminLogin(Teacher teacher)
        {
            string sql = $"select * from Teacher where loginAccount='{teacher.LoginAccount}' and loginPwd='{teacher.LoginPwd}'";
            SqlDataReader reader = SqlHelper.GetReader(sql);
            if (reader.Read())
            {
                teacher.TeacherId = Convert.ToInt32(reader["TeacherId"]);
                teacher.LoginAccount = reader["LoginAccount"].ToString();
                teacher.LoginPwd = reader["LoginPwd"].ToString();
                teacher.TeacherName = reader["TeacherName"].ToString();
                teacher.PhoneNumber = reader["PhoneNumber"].ToString();
                teacher.NowAddress = reader["NowAddress"].ToString();
                reader.Close();
                return teacher;
            }
            else
            {
                teacher = null;
            }
            return teacher;
        }

        /// <summary>
        /// 根据密码查找账户信息
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public Teacher QueryTeacherByPwd(Teacher teacher)
        {
            string sql = $"select * from Teacher where TeacherId={teacher.TeacherId} and LoginPwd={teacher.LoginPwd}";
          

            SqlDataReader reader = SqlHelper.GetReader(sql);
            while (reader.Read())
            {
                return teacher;
            }
            return null;
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int ChangePwd(Teacher teacher)
        {
            string sql = $"update Teacher set LoginPwd=@LoginPwd where TeacherId=@TeacherId";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@LoginPwd",teacher.LoginPwd),
                new SqlParameter("@TeacherId",teacher.TeacherId),
            };
                
            return SqlHelper.Update(sql,sqlParameter);
        }

    }
}
