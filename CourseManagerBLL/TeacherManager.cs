using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagerModel;
using CourseManagerDAL;

namespace CourseManagerBLL
{
    public class TeacherManager
    {
        private TeacherService teacherService = new TeacherService();

        public Teacher AdminLogin(Teacher teacher)
        {
            teacher = teacherService.AdminLogin(teacher);
            return teacher;
        }

        public Teacher QueryTeacherByPwd(Teacher teacher)
        {
            return teacherService.QueryTeacherByPwd(teacher);
        }

        public int ChangePwd(Teacher teacher)
        {
            return teacherService.ChangePwd(teacher);
        }

       
    }
}
