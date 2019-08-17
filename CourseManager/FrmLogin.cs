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
    public partial class FrmLogin : Form
    {
        private TeacherManager teacherManager = new TeacherManager();

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 窗体移动代码
        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//鼠标是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);//获取移动变量的值
                leftFlag = true;//点击左键按下时标注为true
            }
        }

        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后leftFalg为false
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);//设置移动的位置
                Location = mouseSet;
            }
        }



        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAdminAccount.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空！", "提示信息");
                this.txtAdminAccount.Focus();
            }
            if (this.txtAdminPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("密码不能为空！", "提示信息");
                this.txtAdminPwd.Focus();
            }
            Teacher teacher = new Teacher
            {
                LoginAccount = this.txtAdminAccount.Text.Trim(),
                LoginPwd = this.txtAdminPwd.Text.Trim()
            };
            teacher = teacherManager.AdminLogin(teacher);

            if (teacher == null)
            {
                MessageBox.Show("用户名或密码错误！", "提示信息");
            }
            else
            {
                Program.teacher = teacher;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
