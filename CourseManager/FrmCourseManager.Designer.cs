namespace CourseManager
{
    partial class FrmCourseManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnAddCourse = new CCWin.SkinControl.SkinButton();
            this.btnModifyCourse = new CCWin.SkinControl.SkinButton();
            this.btnDeleteCourse = new CCWin.SkinControl.SkinButton();
            this.btnCloseCurrentWindow = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.lblCount = new CCWin.SkinControl.SkinLabel();
            this.dgvCourseList = new CCWin.SkinControl.SkinDataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ModifyCourse = new CCWin.SkinControl.SkinPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.txtCourseContent_Modify = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.cbbCategory_Modify = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.txtCredit_Modify = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.txtClassHour_Modify = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtCourseName_Modify = new CCWin.SkinControl.SkinTextBox();
            this.lblCourseId = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.btnCloseModify = new CCWin.SkinControl.SkinButton();
            this.btnSaveToDB = new CCWin.SkinControl.SkinButton();
            this.txtCourseaName = new CCWin.SkinControl.SkinTextBox();
            this.cbbCategory = new MyControls.ComboxExtend(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.panel_ModifyCourse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(-2, 41);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(680, 13);
            this.skinLine1.TabIndex = 0;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(7, 19);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(135, 20);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "当前位置：课程管理";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddCourse.DownBack = null;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(247, 12);
            this.btnAddCourse.MouseBack = null;
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.NormlBack = null;
            this.btnAddCourse.Size = new System.Drawing.Size(102, 28);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "    添加课程";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // btnModifyCourse
            // 
            this.btnModifyCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModifyCourse.DownBack = null;
            this.btnModifyCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyCourse.Image")));
            this.btnModifyCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyCourse.Location = new System.Drawing.Point(354, 13);
            this.btnModifyCourse.MouseBack = null;
            this.btnModifyCourse.Name = "btnModifyCourse";
            this.btnModifyCourse.NormlBack = null;
            this.btnModifyCourse.Size = new System.Drawing.Size(102, 28);
            this.btnModifyCourse.TabIndex = 2;
            this.btnModifyCourse.Text = "    修改课程";
            this.btnModifyCourse.UseVisualStyleBackColor = false;
            this.btnModifyCourse.Click += new System.EventHandler(this.BtnModifyCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDeleteCourse.DownBack = null;
            this.btnDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCourse.Image")));
            this.btnDeleteCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCourse.Location = new System.Drawing.Point(461, 12);
            this.btnDeleteCourse.MouseBack = null;
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.NormlBack = null;
            this.btnDeleteCourse.Size = new System.Drawing.Size(102, 28);
            this.btnDeleteCourse.TabIndex = 2;
            this.btnDeleteCourse.Text = "    删除课程";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // btnCloseCurrentWindow
            // 
            this.btnCloseCurrentWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCurrentWindow.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseCurrentWindow.DownBack = null;
            this.btnCloseCurrentWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCurrentWindow.Image")));
            this.btnCloseCurrentWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCurrentWindow.Location = new System.Drawing.Point(568, 12);
            this.btnCloseCurrentWindow.MouseBack = null;
            this.btnCloseCurrentWindow.Name = "btnCloseCurrentWindow";
            this.btnCloseCurrentWindow.NormlBack = null;
            this.btnCloseCurrentWindow.Size = new System.Drawing.Size(102, 28);
            this.btnCloseCurrentWindow.TabIndex = 2;
            this.btnCloseCurrentWindow.Text = "    关闭窗口";
            this.btnCloseCurrentWindow.UseVisualStyleBackColor = false;
            this.btnCloseCurrentWindow.Click += new System.EventHandler(this.BtnCloseCurrentWindow_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(7, 62);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "课程分类：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(177, 62);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "课程名称：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(354, 59);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.Size = new System.Drawing.Size(102, 28);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "    提交查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(473, 62);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(92, 17);
            this.skinLabel4.TabIndex = 1;
            this.skinLabel4.Text = "查询结果总数：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.BorderColor = System.Drawing.Color.White;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(578, 62);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 19);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            this.dgvCourseList.AlternatingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCourseList.ColumnFont = null;
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourseList.ColumnHeadersHeight = 30;
            this.dgvCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseId,
            this.ClassHour,
            this.Credit,
            this.CourseContent,
            this.TeacherName});
            this.dgvCourseList.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCourseList.DefaultCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.dgvCourseList.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCourseList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCourseList.Location = new System.Drawing.Point(9, 92);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCourseList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.Size = new System.Drawing.Size(662, 366);
            this.dgvCourseList.SkinGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.dgvCourseList.TabIndex = 6;
            this.dgvCourseList.TitleBack = null;
            this.dgvCourseList.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvCourseList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            // 
            // ClassHour
            // 
            this.ClassHour.DataPropertyName = "ClassHour";
            this.ClassHour.HeaderText = " 课时";
            this.ClassHour.Name = "ClassHour";
            this.ClassHour.ReadOnly = true;
            this.ClassHour.Width = 60;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = " 学分";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 60;
            // 
            // CourseContent
            // 
            this.CourseContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseContent.DataPropertyName = "CourseContent";
            this.CourseContent.HeaderText = "内容概述";
            this.CourseContent.Name = "CourseContent";
            this.CourseContent.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "课程讲师";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // panel_ModifyCourse
            // 
            this.panel_ModifyCourse.BackColor = System.Drawing.Color.Transparent;
            this.panel_ModifyCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ModifyCourse.Controls.Add(this.groupBox1);
            this.panel_ModifyCourse.Controls.Add(this.lblCourseId);
            this.panel_ModifyCourse.Controls.Add(this.skinLabel6);
            this.panel_ModifyCourse.Controls.Add(this.btnCloseModify);
            this.panel_ModifyCourse.Controls.Add(this.btnSaveToDB);
            this.panel_ModifyCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_ModifyCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ModifyCourse.DownBack = null;
            this.panel_ModifyCourse.Location = new System.Drawing.Point(0, 287);
            this.panel_ModifyCourse.MouseBack = null;
            this.panel_ModifyCourse.Name = "panel_ModifyCourse";
            this.panel_ModifyCourse.NormlBack = null;
            this.panel_ModifyCourse.Size = new System.Drawing.Size(680, 183);
            this.panel_ModifyCourse.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skinLabel10);
            this.groupBox1.Controls.Add(this.txtCourseContent_Modify);
            this.groupBox1.Controls.Add(this.skinLabel12);
            this.groupBox1.Controls.Add(this.cbbCategory_Modify);
            this.groupBox1.Controls.Add(this.skinLabel11);
            this.groupBox1.Controls.Add(this.txtCredit_Modify);
            this.groupBox1.Controls.Add(this.skinLabel9);
            this.groupBox1.Controls.Add(this.txtClassHour_Modify);
            this.groupBox1.Controls.Add(this.skinLabel8);
            this.groupBox1.Controls.Add(this.txtCourseName_Modify);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[课程信息]";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(7, 78);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(68, 17);
            this.skinLabel10.TabIndex = 1;
            this.skinLabel10.Text = "课程名称：";
            // 
            // txtCourseContent_Modify
            // 
            this.txtCourseContent_Modify.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseContent_Modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseContent_Modify.DownBack = null;
            this.txtCourseContent_Modify.Icon = null;
            this.txtCourseContent_Modify.IconIsButton = false;
            this.txtCourseContent_Modify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseContent_Modify.IsPasswordChat = '\0';
            this.txtCourseContent_Modify.IsSystemPasswordChar = false;
            this.txtCourseContent_Modify.Lines = new string[0];
            this.txtCourseContent_Modify.Location = new System.Drawing.Point(75, 74);
            this.txtCourseContent_Modify.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourseContent_Modify.MaxLength = 32767;
            this.txtCourseContent_Modify.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCourseContent_Modify.MouseBack = null;
            this.txtCourseContent_Modify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseContent_Modify.Multiline = false;
            this.txtCourseContent_Modify.Name = "txtCourseContent_Modify";
            this.txtCourseContent_Modify.NormlBack = null;
            this.txtCourseContent_Modify.Padding = new System.Windows.Forms.Padding(5);
            this.txtCourseContent_Modify.ReadOnly = false;
            this.txtCourseContent_Modify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseContent_Modify.Size = new System.Drawing.Size(363, 25);
            // 
            // 
            // 
            this.txtCourseContent_Modify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseContent_Modify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseContent_Modify.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCourseContent_Modify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCourseContent_Modify.SkinTxt.Name = "BaseText";
            this.txtCourseContent_Modify.SkinTxt.Size = new System.Drawing.Size(351, 18);
            this.txtCourseContent_Modify.SkinTxt.TabIndex = 0;
            this.txtCourseContent_Modify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseContent_Modify.SkinTxt.WaterText = "";
            this.txtCourseContent_Modify.TabIndex = 5;
            this.txtCourseContent_Modify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseContent_Modify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseContent_Modify.WaterText = "";
            this.txtCourseContent_Modify.WordWrap = true;
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(445, 78);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(68, 17);
            this.skinLabel12.TabIndex = 1;
            this.skinLabel12.Text = "课程分类：";
            // 
            // cbbCategory_Modify
            // 
            this.cbbCategory_Modify.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCategory_Modify.FormattingEnabled = true;
            this.cbbCategory_Modify.Location = new System.Drawing.Point(513, 75);
            this.cbbCategory_Modify.Name = "cbbCategory_Modify";
            this.cbbCategory_Modify.Size = new System.Drawing.Size(122, 22);
            this.cbbCategory_Modify.TabIndex = 4;
            this.cbbCategory_Modify.WaterText = "";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(445, 35);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(68, 17);
            this.skinLabel11.TabIndex = 1;
            this.skinLabel11.Text = "课程学分：";
            // 
            // txtCredit_Modify
            // 
            this.txtCredit_Modify.BackColor = System.Drawing.Color.Transparent;
            this.txtCredit_Modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredit_Modify.DownBack = null;
            this.txtCredit_Modify.Icon = null;
            this.txtCredit_Modify.IconIsButton = false;
            this.txtCredit_Modify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCredit_Modify.IsPasswordChat = '\0';
            this.txtCredit_Modify.IsSystemPasswordChar = false;
            this.txtCredit_Modify.Lines = new string[0];
            this.txtCredit_Modify.Location = new System.Drawing.Point(513, 31);
            this.txtCredit_Modify.Margin = new System.Windows.Forms.Padding(0);
            this.txtCredit_Modify.MaxLength = 32767;
            this.txtCredit_Modify.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCredit_Modify.MouseBack = null;
            this.txtCredit_Modify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCredit_Modify.Multiline = false;
            this.txtCredit_Modify.Name = "txtCredit_Modify";
            this.txtCredit_Modify.NormlBack = null;
            this.txtCredit_Modify.Padding = new System.Windows.Forms.Padding(5);
            this.txtCredit_Modify.ReadOnly = false;
            this.txtCredit_Modify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCredit_Modify.Size = new System.Drawing.Size(122, 25);
            // 
            // 
            // 
            this.txtCredit_Modify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCredit_Modify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCredit_Modify.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCredit_Modify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCredit_Modify.SkinTxt.Name = "BaseText";
            this.txtCredit_Modify.SkinTxt.Size = new System.Drawing.Size(110, 18);
            this.txtCredit_Modify.SkinTxt.TabIndex = 0;
            this.txtCredit_Modify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCredit_Modify.SkinTxt.WaterText = "";
            this.txtCredit_Modify.TabIndex = 5;
            this.txtCredit_Modify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCredit_Modify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCredit_Modify.WaterText = "";
            this.txtCredit_Modify.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(293, 35);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(68, 17);
            this.skinLabel9.TabIndex = 1;
            this.skinLabel9.Text = "课时总数：";
            // 
            // txtClassHour_Modify
            // 
            this.txtClassHour_Modify.BackColor = System.Drawing.Color.Transparent;
            this.txtClassHour_Modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassHour_Modify.DownBack = null;
            this.txtClassHour_Modify.Icon = null;
            this.txtClassHour_Modify.IconIsButton = false;
            this.txtClassHour_Modify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtClassHour_Modify.IsPasswordChat = '\0';
            this.txtClassHour_Modify.IsSystemPasswordChar = false;
            this.txtClassHour_Modify.Lines = new string[0];
            this.txtClassHour_Modify.Location = new System.Drawing.Point(361, 31);
            this.txtClassHour_Modify.Margin = new System.Windows.Forms.Padding(0);
            this.txtClassHour_Modify.MaxLength = 32767;
            this.txtClassHour_Modify.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtClassHour_Modify.MouseBack = null;
            this.txtClassHour_Modify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtClassHour_Modify.Multiline = false;
            this.txtClassHour_Modify.Name = "txtClassHour_Modify";
            this.txtClassHour_Modify.NormlBack = null;
            this.txtClassHour_Modify.Padding = new System.Windows.Forms.Padding(5);
            this.txtClassHour_Modify.ReadOnly = false;
            this.txtClassHour_Modify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassHour_Modify.Size = new System.Drawing.Size(77, 25);
            // 
            // 
            // 
            this.txtClassHour_Modify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassHour_Modify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassHour_Modify.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtClassHour_Modify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtClassHour_Modify.SkinTxt.Name = "BaseText";
            this.txtClassHour_Modify.SkinTxt.Size = new System.Drawing.Size(65, 18);
            this.txtClassHour_Modify.SkinTxt.TabIndex = 0;
            this.txtClassHour_Modify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtClassHour_Modify.SkinTxt.WaterText = "";
            this.txtClassHour_Modify.TabIndex = 5;
            this.txtClassHour_Modify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassHour_Modify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtClassHour_Modify.WaterText = "";
            this.txtClassHour_Modify.WordWrap = true;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(6, 35);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(68, 17);
            this.skinLabel8.TabIndex = 1;
            this.skinLabel8.Text = "课程名称：";
            // 
            // txtCourseName_Modify
            // 
            this.txtCourseName_Modify.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseName_Modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseName_Modify.DownBack = null;
            this.txtCourseName_Modify.Icon = null;
            this.txtCourseName_Modify.IconIsButton = false;
            this.txtCourseName_Modify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseName_Modify.IsPasswordChat = '\0';
            this.txtCourseName_Modify.IsSystemPasswordChar = false;
            this.txtCourseName_Modify.Lines = new string[0];
            this.txtCourseName_Modify.Location = new System.Drawing.Point(74, 31);
            this.txtCourseName_Modify.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourseName_Modify.MaxLength = 32767;
            this.txtCourseName_Modify.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCourseName_Modify.MouseBack = null;
            this.txtCourseName_Modify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseName_Modify.Multiline = false;
            this.txtCourseName_Modify.Name = "txtCourseName_Modify";
            this.txtCourseName_Modify.NormlBack = null;
            this.txtCourseName_Modify.Padding = new System.Windows.Forms.Padding(5);
            this.txtCourseName_Modify.ReadOnly = false;
            this.txtCourseName_Modify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName_Modify.Size = new System.Drawing.Size(207, 25);
            // 
            // 
            // 
            this.txtCourseName_Modify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName_Modify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseName_Modify.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCourseName_Modify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCourseName_Modify.SkinTxt.Name = "BaseText";
            this.txtCourseName_Modify.SkinTxt.Size = new System.Drawing.Size(195, 18);
            this.txtCourseName_Modify.SkinTxt.TabIndex = 0;
            this.txtCourseName_Modify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseName_Modify.SkinTxt.WaterText = "";
            this.txtCourseName_Modify.TabIndex = 5;
            this.txtCourseName_Modify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseName_Modify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseName_Modify.WaterText = "";
            this.txtCourseName_Modify.WordWrap = true;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseId.BorderColor = System.Drawing.Color.White;
            this.lblCourseId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourseId.Location = new System.Drawing.Point(86, 16);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(36, 17);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "0000";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(19, 16);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(68, 17);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "课程编号：";
            // 
            // btnCloseModify
            // 
            this.btnCloseModify.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseModify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseModify.DownBack = null;
            this.btnCloseModify.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseModify.Image")));
            this.btnCloseModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseModify.Location = new System.Drawing.Point(567, 10);
            this.btnCloseModify.MouseBack = null;
            this.btnCloseModify.Name = "btnCloseModify";
            this.btnCloseModify.NormlBack = null;
            this.btnCloseModify.Size = new System.Drawing.Size(102, 28);
            this.btnCloseModify.TabIndex = 2;
            this.btnCloseModify.Text = "    关闭修改";
            this.btnCloseModify.UseVisualStyleBackColor = false;
            this.btnCloseModify.Click += new System.EventHandler(this.BtnCloseModify_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveToDB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.btnSaveToDB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.btnSaveToDB.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSaveToDB.DownBack = null;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(460, 10);
            this.btnSaveToDB.MouseBack = null;
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.NormlBack = null;
            this.btnSaveToDB.Size = new System.Drawing.Size(102, 28);
            this.btnSaveToDB.TabIndex = 2;
            this.btnSaveToDB.Text = "    提交修改";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.BtnSaveToDB_Click);
            // 
            // txtCourseaName
            // 
            this.txtCourseaName.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseaName.DownBack = null;
            this.txtCourseaName.Icon = null;
            this.txtCourseaName.IconIsButton = false;
            this.txtCourseaName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseaName.IsPasswordChat = '\0';
            this.txtCourseaName.IsSystemPasswordChar = false;
            this.txtCourseaName.Lines = new string[0];
            this.txtCourseaName.Location = new System.Drawing.Point(242, 59);
            this.txtCourseaName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourseaName.MaxLength = 32767;
            this.txtCourseaName.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCourseaName.MouseBack = null;
            this.txtCourseaName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseaName.Multiline = false;
            this.txtCourseaName.Name = "txtCourseaName";
            this.txtCourseaName.NormlBack = null;
            this.txtCourseaName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCourseaName.ReadOnly = false;
            this.txtCourseaName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseaName.Size = new System.Drawing.Size(99, 25);
            // 
            // 
            // 
            this.txtCourseaName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseaName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseaName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCourseaName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCourseaName.SkinTxt.Name = "BaseText";
            this.txtCourseaName.SkinTxt.Size = new System.Drawing.Size(87, 18);
            this.txtCourseaName.SkinTxt.TabIndex = 0;
            this.txtCourseaName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseaName.SkinTxt.WaterText = "";
            this.txtCourseaName.TabIndex = 5;
            this.txtCourseaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseaName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseaName.WaterText = "";
            this.txtCourseaName.WordWrap = true;
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(66, 60);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbCategory.TabIndex = 8;
            // 
            // FrmCourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 470);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.panel_ModifyCourse);
            this.Controls.Add(this.txtCourseaName);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.btnCloseCurrentWindow);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnModifyCourse);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCourseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.panel_ModifyCourse.ResumeLayout(false);
            this.panel_ModifyCourse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnAddCourse;
        private CCWin.SkinControl.SkinButton btnModifyCourse;
        private CCWin.SkinControl.SkinButton btnDeleteCourse;
        private CCWin.SkinControl.SkinButton btnCloseCurrentWindow;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btnQuery;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel lblCount;
        private CCWin.SkinControl.SkinDataGridView dgvCourseList;
        private CCWin.SkinControl.SkinPanel panel_ModifyCourse;
        private CCWin.SkinControl.SkinLabel lblCourseId;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinTextBox txtCourseContent_Modify;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinComboBox cbbCategory_Modify;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinTextBox txtCredit_Modify;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinTextBox txtClassHour_Modify;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinTextBox txtCourseName_Modify;
        private CCWin.SkinControl.SkinButton btnCloseModify;
        private CCWin.SkinControl.SkinButton btnSaveToDB;
        private CCWin.SkinControl.SkinTextBox txtCourseaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private MyControls.ComboxExtend cbbCategory;
    }
}