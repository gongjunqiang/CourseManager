using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagerModel;
using CourseManagerDAL;


namespace CourseManagerBLL
{
    public class CourseManager
    {
        private CourseService courseService = new CourseService();

        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }

        /// <summary>
        /// 查询课程
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="courseName"></param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            return courseService.QueryCourse(categoryId, courseName);
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }

        public int ModifyCourse(Course course)
        {
            return courseService.ModifyCourse(course);
        }

    }
}
