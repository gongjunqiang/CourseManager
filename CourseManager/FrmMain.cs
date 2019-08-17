using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.lblCurrentAdmin.Text = Program.teacher.LoginAccount;
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


        #region 嵌入子窗体

        private void OpenFrom(Form childForm)
        {
            //遍历容器，关闭当前已经嵌入的窗体
            foreach (Control item in this.panel_Right.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            childForm.TopLevel = false;//将子窗体设置成非顶级控件
            childForm.Parent = this.panel_Right;//指定当前子窗体的容器
            childForm.Dock = DockStyle.Fill;//随着容器大小自动调整窗体大小（目前没有效果，因为我们是固定窗体）
            childForm.Show();
        }

        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            OpenFrom(new FrmAddCourse());
        }

        private void BtnCourseManager_Click(object sender, EventArgs e)
        {
            FrmCourseManager frmCourseManager = new FrmCourseManager();
            frmCourseManager.showAddCourse = BtnAddCourse_Click;
            frmCourseManager.showAddCourse1 = OpenFrom;
            OpenFrom(frmCourseManager);
        }

        private void BtnModifyPwd_Click(object sender, EventArgs e)
        {
            OpenFrom(new FrmModifyPwd());
        }
    }

    public delegate void ShowAddCourse(object sender, EventArgs e);

    public delegate void ShowAddCourse1(Form childForm);
}
