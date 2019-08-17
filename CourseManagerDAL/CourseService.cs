using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagerDAL.Helper;
using CourseManagerModel;
using System.Data;
using System.Data.SqlClient;

namespace CourseManagerDAL
{
    public class CourseService
    {
        /// <summary>
        /// 新增课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            string sql = "insert into Course (CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql +=$" values(@CourseName,@CourseContent,@ClassHour,@Credit,@CategoryId,@TeacherId)";
            SqlParameter[] sqlParameters = new SqlParameter[] 
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@CourseContent",course.CourseContent),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@TeacherId",course.TeacherId),
            };
            int result = SqlHelper.Update(sql, sqlParameters);
            return result;
        }

        /// <summary>
        /// 动态组合查询课程结果集
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="courseName"></param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId,string courseName)
        {
            
            string sql = "select * from Course inner join Teacher on Course.TeacherId=Teacher.TeacherId where";
            string sqlString = string.Empty;
            if (categoryId !=-1)
            {
                sqlString += $" and categoryId={categoryId}";
            }

            if (!string.IsNullOrEmpty(courseName))
            {
                sqlString += $" and CourseName like '%{courseName}%'";
            }

            SqlDataReader reader = SqlHelper.GetReader(sql + sqlString.Substring(4));
            List<Course> listCourse = new List<Course>();
            while (reader.Read())
            {
                listCourse.Add(new Course
                {
                    CourseId = (int)reader["CourseId"],
                    CourseName = reader["CourseName"].ToString(),
                    CourseContent = reader["CourseContent"].ToString(),
                    ClassHour = (int)reader["ClassHour"],
                    Credit = (int)reader["Credit"],
                    CategoryId = (int)reader["CategoryId"],
                    TeacherId = (int)reader["TeacherId"],
                    TeacherName = reader["TeacherName"].ToString(),
                }); ;
            }
            reader.Close();
            return listCourse;
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = $"delete from Course where CourseId={course.CourseId}";
            return SqlHelper.Update(sql);
        }



        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int ModifyCourse(Course course)
        {
            string sql = $"update Course set CourseName=@CourseName,CourseContent=@CourseContent,ClassHour=@ClassHour,Credit=@Credit,CategoryId=@CategoryId";
            sql += " where CourseId=@CourseId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@CourseContent",course.CourseContent),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@CourseId",course.CourseId),
            };
            return SqlHelper.Update(sql, sqlParameters);
        }
    }
}
