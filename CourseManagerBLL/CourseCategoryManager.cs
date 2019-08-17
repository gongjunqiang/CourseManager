using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagerModel;
using CourseManagerDAL;


namespace CourseManagerBLL
{

    public class CourseCategoryManager
    {
        private CourseCategoryService CourseCategoryService = new CourseCategoryService();

        /// <summary>
        /// 获取课程分类信息
        /// </summary>
        /// <returns></returns>
        public List<CourseCategory> GetCourseCategory()
        {
            List<CourseCategory> list = CourseCategoryService.GetCourseCategory();
            return list;
        }
    }
}
