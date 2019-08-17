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
    public partial class FrmAddCourse : Form
    {
        private CourseCategoryManager CourseCategoryManager = new CourseCategoryManager();
        private CourseManagerBLL.CourseManager courseManager = new CourseManagerBLL.CourseManager();
        private List<Course> addCourse = new List<Course>();

        public FrmAddCourse()
        {
            InitializeComponent();
            //this.btnSaveToDB.Enabled = false;
            this.cbbCategory.DataSource = CourseCategoryManager.GetCourseCategory();
            this.cbbCategory.DisplayMember = "CategoryName";
            this.cbbCategory.ValueMember = "CategoryId";
            this.dgvCourseList.AutoGenerateColumns = false;
        }

        private void BtnCloseCurrentWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加课程
        private void BtnSaveToDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCourseName.Text.Trim()))
            {
                MessageBox.Show("课程名称不能为空！", "提示信息");
                this.txtCourseName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtClassHour.Text.Trim()))
            {
                MessageBox.Show("课时不能为空！", "提示信息");
                this.txtClassHour.Focus();
                return;
            }

            var txtCredit = this.txtCredit.Text.Trim();
            if (string.IsNullOrEmpty(txtCredit))
            {
                MessageBox.Show("学分不能为空！", "提示信息");
                this.txtCredit.Focus();
                return;
            }

            try
            {
                var credit = int.Parse(txtCredit);
            }
            catch (Exception )
            {
                MessageBox.Show("学分只能为整数！", "提示信息");
                return;
            }

            if (string.IsNullOrEmpty(this.txtCourseContent.Text.Trim()))
            {
                MessageBox.Show("课程内容不能为空！", "提示信息");
                this.txtCourseContent.Focus();
                return;
            }

            Course course = new Course
            {
                CourseName = this.txtCourseName.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory.SelectedValue),
                TeacherId = Convert.ToInt32(Program.teacher.TeacherId),
                CategoryName = this.cbbCategory.Text
            };
            var result = courseManager.AddCourse(course);

            if (result != 1)
            {
                MessageBox.Show("课程添加失败！", "提示信息");
            }
            addCourse.Add(course);
            this.lblCount.Text = addCourse.Count.ToString();
            this.dgvCourseList.DataSource = null;//不清空不会同步显示
            this.dgvCourseList.DataSource = addCourse;
            //【5】自动清除文本
            if (this.ckbAutoClear.Checked)
            {
                this.txtCourseName.Text = null;
                this.txtCourseContent.Text = null;
                this.txtClassHour.Text = null;
                this.txtCredit.Text = null;
            }
        }
    }
}
