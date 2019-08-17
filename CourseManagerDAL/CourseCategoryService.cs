using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CourseManagerDAL.Helper;
using CourseManagerModel;

namespace CourseManagerDAL
{
    public class CourseCategoryService
    {
        /// <summary>
        /// 获取课程分类信息
        /// </summary>
        /// <returns></returns>
        public List<CourseCategory> GetCourseCategory()
        {
            string sql = "select * from CourseCategory";
            SqlDataReader reader = SqlHelper.GetReader(sql);
            List<CourseCategory> list = new List<CourseCategory>();
            while (reader.Read())
            {
                list.Add(new CourseCategory
                {
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    CategoryName = reader["CategoryName"].ToString()
                });
            }
            reader.Close();
            return list;
        }
    }
}
