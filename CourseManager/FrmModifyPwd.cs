using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManagerModel;
using CourseManagerBLL;


namespace CourseManager
{
    public partial class FrmModifyPwd : Form
    {
        private TeacherManager teacherManager = new TeacherManager();
        public FrmModifyPwd()
        {
            InitializeComponent();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveToDB_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("原密码不能为空！", "提示信息");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空！", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtConfirmNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("确认密码不能为空！", "提示信息");
                this.txtConfirmNewPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim() != this.txtConfirmNewPwd.Text.Trim())
            {
                MessageBox.Show("新密码不一致！", "提示信息");
                return;
            }

            Program.teacher.LoginPwd = this.txtOldPwd.Text.Trim();
            Teacher teacher = teacherManager.QueryTeacherByPwd(Program.teacher);
            if (teacher == null)
            {
                MessageBox.Show("原密码错误！", "提示信息");
                return;
            }
            Program.teacher.LoginPwd = this.txtNewPwd.Text.Trim();
            var changeRow =  teacherManager.ChangePwd(Program.teacher);
            if (changeRow == 1)
            {
                MessageBox.Show("密码修改成功！", "提示信息");
            }
            else
            {
                MessageBox.Show("密码修改失败！", "提示信息");
            }
        }
    }
}
