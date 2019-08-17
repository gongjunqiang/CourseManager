using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManagerBLL;
using CourseManagerModel;

namespace CourseManager
{
    public partial class FrmCourseManager : Form
    {
        private CourseCategoryManager courseCategoryManager = new CourseCategoryManager();
        private CourseManagerBLL.CourseManager courseManager = new CourseManagerBLL.CourseManager();
        public ShowAddCourse showAddCourse = null;
        public ShowAddCourse1 showAddCourse1 = null;
        private List<Course> queryCourse = null;
        public FrmCourseManager()
        {
            InitializeComponent();
            List<CourseCategory> ListCourseCategory = courseCategoryManager.GetCourseCategory();
            ListCourseCategory.Insert(0,new CourseCategory{ CategoryId=-1,CategoryName="--请选择--"});
            this.cbbCategory.DataSource = ListCourseCategory;
            this.cbbCategory.DisplayMember = "CategoryName";
            this.cbbCategory.ValueMember = "CategoryId";

            //禁用编辑与删除按钮
            this.btnModifyCourse.Enabled = false;
            this.btnDeleteCourse.Enabled = false;

            //隐藏编辑页面
            this.panel_ModifyCourse.Visible = false;

            //设置课程分类选择为-1
            this.cbbCategory.SelectedIndex = -1;

            this.dgvCourseList.AutoGenerateColumns = false;

            this.cbbCategory_Modify.DataSource = courseCategoryManager.GetCourseCategory();
            this.cbbCategory_Modify.DisplayMember = "CategoryName";
            this.cbbCategory_Modify.ValueMember = "CategoryId";
        }
       

        private void BtnCloseCurrentWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var a = this.cbbCategory.BeginCheckEmpty();
            if (a == 0)
            {
                return;
            }

            if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0)
                 && this.txtCourseaName.Text.Trim().Length == 0)
            {
                MessageBox.Show("课程分类与课程名称至少有一个不能为空！", "提示信息");
                return;
            }
            int categoryId = 0;
            categoryId = this.cbbCategory.SelectedIndex == -1 ? -1 : Convert.ToInt32(this.cbbCategory.SelectedValue);
            queryCourse = courseManager.QueryCourse(categoryId, this.txtCourseaName.Text.Trim());
            this.dgvCourseList.DataSource = null;
            if (queryCourse.Count == 0)
            {
                this.lblCount.Text = "0";
                this.dgvCourseList.DataSource = null;
                this.btnModifyCourse.Enabled = false;
                this.btnDeleteCourse.Enabled = false;
                MessageBox.Show("查询结果为空！", "提示信息");
            }
            else
            {
                this.dgvCourseList.DataSource = queryCourse;
                this.lblCount.Text = dgvCourseList.RowCount.ToString();
                //启用编辑与删除按钮
                this.btnModifyCourse.Enabled = true;
                this.btnDeleteCourse.Enabled = true;
            }
        }

        //显示编辑界面
        private void BtnModifyCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请选择一行！", "提示信息");
            }
            this.panel_ModifyCourse.Visible = true;
            int courseId = Convert.ToInt32(this.dgvCourseList.CurrentRow.Cells["CourseId"].Value);

            Course course = queryCourse.Where(o=>o.CourseId== courseId).First();
            this.txtCourseName_Modify.Text = course.CourseName;
            this.txtClassHour_Modify.Text = course.ClassHour.ToString();
            this.txtCourseContent_Modify.Text = course.CourseContent;
            this.txtCredit_Modify.Text = course.Credit.ToString();
            this.lblCourseId.Text = course.CourseId.ToString();
            this.cbbCategory_Modify.SelectedValue = course.CategoryId;
        }

        //关闭编辑界面
        private void BtnCloseModify_Click(object sender, EventArgs e)
        {
            this.panel_ModifyCourse.Visible = false;
        }

        //提交修改
        private void BtnSaveToDB_Click(object sender, EventArgs e)
        {
            #region 数据校验
            if (string.IsNullOrEmpty(this.txtCourseName_Modify.Text.Trim()))
            {
                MessageBox.Show("课程名称不能为空！", "提示信息");
                this.txtCourseName_Modify.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtClassHour_Modify.Text.Trim()))
            {
                MessageBox.Show("课时不能为空！", "提示信息");
                this.txtClassHour_Modify.Focus();
                return;
            }

            var txtCredit = this.txtCredit_Modify.Text.Trim();
            if (string.IsNullOrEmpty(txtCredit))
            {
                MessageBox.Show("学分不能为空！", "提示信息");
                this.txtCredit_Modify.Focus();
                return;
            }

            try
            {
                var credit = int.Parse(txtCredit);
            }
            catch (Exception)
            {
                MessageBox.Show("学分只能为整数！", "提示信息");
                return;
            }

            if (string.IsNullOrEmpty(this.txtCourseContent_Modify.Text.Trim()))
            {
                MessageBox.Show("课程内容不能为空！", "提示信息");
                this.txtCourseContent_Modify.Focus();
                return;
            }
            #endregion
            Course course = new Course
            {
                CourseId = Convert.ToInt32(this.lblCourseId.Text.Trim()),
                CourseName = this.txtCourseName_Modify.Text.Trim(),
                CourseContent = this.txtCourseContent_Modify.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour_Modify.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit_Modify.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory.SelectedValue),
                TeacherId = Convert.ToInt32(Program.teacher.TeacherId),
                CategoryName = this.cbbCategory.Text
            };

            var result = courseManager.ModifyCourse(course);
            this.panel_ModifyCourse.Visible = false;
            //同步更新数据

            Course currentCourse = (from c in this.queryCourse where c.CourseId == course.CourseId select c).First();
                                   //(from c in queryCourse where c.CourseId == course.CourseId select c).First();
            currentCourse.CourseName = course.CourseName;
            currentCourse.CourseContent = course.CourseContent;
            currentCourse.ClassHour = course.ClassHour;
            currentCourse.Credit = course.Credit;
            currentCourse.CategoryName = course.CategoryName;
            currentCourse.CategoryId = course.CategoryId;
            this.dgvCourseList.Refresh();

        }


        //删除课程
        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请选择一行！", "提示信息");
            }

            int courseId = Convert.ToInt32(this.dgvCourseList.CurrentRow.Cells["CourseId"].Value);
            Course currentCourse = new Course { CourseId = courseId };
            DialogResult result = MessageBox.Show($"是否删除编号为{courseId}的课程？", "提示信息",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            var deleteCount = courseManager.DeleteCourse(currentCourse);
            if (deleteCount!=1)
            {
                MessageBox.Show("课程删除失败！", "提示信息");
            }
            currentCourse = (from c in queryCourse where c.CourseId == currentCourse.CourseId select c).First();
            queryCourse.Remove(currentCourse);
            this.dgvCourseList.DataSource = null;
            this.dgvCourseList.DataSource = queryCourse;
            this.lblCount.Text = this.dgvCourseList.RowCount.ToString();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            //showAddCourse1(new FrmAddCourse());
            //showAddCourse(null, null);
            showAddCourse1(this);

            //this.Close();
            //this.IsMdiContainer = true;
            //FrmAddCourse frmAddCourse = new FrmAddCourse();
            //frmAddCourse.MdiParent = this;
            //frmAddCourse.Parent = this;
            //frmAddCourse.WindowState = FormWindowState.Maximized;//就是这个嘛？
            //frmAddCourse.Show();
        }
    }
}
