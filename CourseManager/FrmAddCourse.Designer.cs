namespace CourseManager
{
    partial class FrmAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCourse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCloseCurrentWindow = new CCWin.SkinControl.SkinButton();
            this.btnSaveToDB = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.groupBoxCourseInfo = new System.Windows.Forms.GroupBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.txtCourseContent = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.cbbCategory = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.txtCredit = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.txtClassHour = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtCourseName = new CCWin.SkinControl.SkinTextBox();
            this.ckbAutoClear = new CCWin.SkinControl.SkinCheckBox();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseCurrentWindow
            // 
            this.btnCloseCurrentWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCurrentWindow.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCloseCurrentWindow.DownBack = null;
            this.btnCloseCurrentWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCurrentWindow.Image")));
            this.btnCloseCurrentWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCurrentWindow.Location = new System.Drawing.Point(570, 10);
            this.btnCloseCurrentWindow.MouseBack = null;
            this.btnCloseCurrentWindow.Name = "btnCloseCurrentWindow";
            this.btnCloseCurrentWindow.NormlBack = null;
            this.btnCloseCurrentWindow.Size = new System.Drawing.Size(102, 28);
            this.btnCloseCurrentWindow.TabIndex = 5;
            this.btnCloseCurrentWindow.Text = "    关闭窗口";
            this.btnCloseCurrentWindow.UseVisualStyleBackColor = false;
            this.btnCloseCurrentWindow.Click += new System.EventHandler(this.BtnCloseCurrentWindow_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveToDB.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSaveToDB.DownBack = null;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(440, 10);
            this.btnSaveToDB.MouseBack = null;
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.NormlBack = null;
            this.btnSaveToDB.Size = new System.Drawing.Size(125, 28);
            this.btnSaveToDB.TabIndex = 6;
            this.btnSaveToDB.Text = "    保存到数据库";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.BtnSaveToDB_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(9, 17);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(135, 20);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "当前位置：添加课程";
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(0, 39);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(680, 13);
            this.skinLine1.TabIndex = 3;
            this.skinLine1.Text = "skinLine1";
            // 
            // groupBoxCourseInfo
            // 
            this.groupBoxCourseInfo.Controls.Add(this.skinLabel10);
            this.groupBoxCourseInfo.Controls.Add(this.txtCourseContent);
            this.groupBoxCourseInfo.Controls.Add(this.skinLabel12);
            this.groupBoxCourseInfo.Controls.Add(this.cbbCategory);
            this.groupBoxCourseInfo.Controls.Add(this.skinLabel11);
            this.groupBoxCourseInfo.Controls.Add(this.txtCredit);
            this.groupBoxCourseInfo.Controls.Add(this.skinLabel9);
            this.groupBoxCourseInfo.Controls.Add(this.txtClassHour);
            this.groupBoxCourseInfo.Controls.Add(this.skinLabel8);
            this.groupBoxCourseInfo.Controls.Add(this.txtCourseName);
            this.groupBoxCourseInfo.Location = new System.Drawing.Point(13, 57);
            this.groupBoxCourseInfo.Name = "groupBoxCourseInfo";
            this.groupBoxCourseInfo.Size = new System.Drawing.Size(655, 117);
            this.groupBoxCourseInfo.TabIndex = 9;
            this.groupBoxCourseInfo.TabStop = false;
            this.groupBoxCourseInfo.Text = "[课程信息]";
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
            this.skinLabel10.Text = "课程内容：";
            // 
            // txtCourseContent
            // 
            this.txtCourseContent.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseContent.DownBack = null;
            this.txtCourseContent.Icon = null;
            this.txtCourseContent.IconIsButton = false;
            this.txtCourseContent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseContent.IsPasswordChat = '\0';
            this.txtCourseContent.IsSystemPasswordChar = false;
            this.txtCourseContent.Lines = new string[] {
        "C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF"};
            this.txtCourseContent.Location = new System.Drawing.Point(75, 74);
            this.txtCourseContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourseContent.MaxLength = 32767;
            this.txtCourseContent.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCourseContent.MouseBack = null;
            this.txtCourseContent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseContent.Multiline = false;
            this.txtCourseContent.Name = "txtCourseContent";
            this.txtCourseContent.NormlBack = null;
            this.txtCourseContent.Padding = new System.Windows.Forms.Padding(5);
            this.txtCourseContent.ReadOnly = false;
            this.txtCourseContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseContent.Size = new System.Drawing.Size(363, 25);
            // 
            // 
            // 
            this.txtCourseContent.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseContent.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseContent.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCourseContent.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCourseContent.SkinTxt.Name = "BaseText";
            this.txtCourseContent.SkinTxt.Size = new System.Drawing.Size(351, 18);
            this.txtCourseContent.SkinTxt.TabIndex = 0;
            this.txtCourseContent.SkinTxt.Text = "C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF";
            this.txtCourseContent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseContent.SkinTxt.WaterText = "";
            this.txtCourseContent.TabIndex = 5;
            this.txtCourseContent.Text = "C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF";
            this.txtCourseContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseContent.WaterText = "";
            this.txtCourseContent.WordWrap = true;
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
            // cbbCategory
            // 
            this.cbbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(513, 75);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(122, 22);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.WaterText = "";
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
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.Color.Transparent;
            this.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredit.DownBack = null;
            this.txtCredit.Icon = null;
            this.txtCredit.IconIsButton = false;
            this.txtCredit.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCredit.IsPasswordChat = '\0';
            this.txtCredit.IsSystemPasswordChar = false;
            this.txtCredit.Lines = new string[] {
        "20"};
            this.txtCredit.Location = new System.Drawing.Point(513, 31);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(0);
            this.txtCredit.MaxLength = 32767;
            this.txtCredit.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCredit.MouseBack = null;
            this.txtCredit.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCredit.Multiline = false;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.NormlBack = null;
            this.txtCredit.Padding = new System.Windows.Forms.Padding(5);
            this.txtCredit.ReadOnly = false;
            this.txtCredit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCredit.Size = new System.Drawing.Size(122, 25);
            // 
            // 
            // 
            this.txtCredit.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCredit.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCredit.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCredit.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCredit.SkinTxt.Name = "BaseText";
            this.txtCredit.SkinTxt.Size = new System.Drawing.Size(110, 18);
            this.txtCredit.SkinTxt.TabIndex = 0;
            this.txtCredit.SkinTxt.Text = "20";
            this.txtCredit.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCredit.SkinTxt.WaterText = "";
            this.txtCredit.TabIndex = 5;
            this.txtCredit.Text = "20";
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCredit.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCredit.WaterText = "";
            this.txtCredit.WordWrap = true;
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
            // txtClassHour
            // 
            this.txtClassHour.BackColor = System.Drawing.Color.Transparent;
            this.txtClassHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassHour.DownBack = null;
            this.txtClassHour.Icon = null;
            this.txtClassHour.IconIsButton = false;
            this.txtClassHour.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtClassHour.IsPasswordChat = '\0';
            this.txtClassHour.IsSystemPasswordChar = false;
            this.txtClassHour.Lines = new string[] {
        "500"};
            this.txtClassHour.Location = new System.Drawing.Point(361, 31);
            this.txtClassHour.Margin = new System.Windows.Forms.Padding(0);
            this.txtClassHour.MaxLength = 32767;
            this.txtClassHour.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtClassHour.MouseBack = null;
            this.txtClassHour.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtClassHour.Multiline = false;
            this.txtClassHour.Name = "txtClassHour";
            this.txtClassHour.NormlBack = null;
            this.txtClassHour.Padding = new System.Windows.Forms.Padding(5);
            this.txtClassHour.ReadOnly = false;
            this.txtClassHour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassHour.Size = new System.Drawing.Size(77, 25);
            // 
            // 
            // 
            this.txtClassHour.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassHour.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClassHour.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtClassHour.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtClassHour.SkinTxt.Name = "BaseText";
            this.txtClassHour.SkinTxt.Size = new System.Drawing.Size(65, 18);
            this.txtClassHour.SkinTxt.TabIndex = 0;
            this.txtClassHour.SkinTxt.Text = "500";
            this.txtClassHour.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtClassHour.SkinTxt.WaterText = "";
            this.txtClassHour.TabIndex = 5;
            this.txtClassHour.Text = "500";
            this.txtClassHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassHour.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtClassHour.WaterText = "";
            this.txtClassHour.WordWrap = true;
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
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseName.DownBack = null;
            this.txtCourseName.Icon = null;
            this.txtCourseName.IconIsButton = false;
            this.txtCourseName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseName.IsPasswordChat = '\0';
            this.txtCourseName.IsSystemPasswordChar = false;
            this.txtCourseName.Lines = new string[] {
        ".Net/C#上位机开发VIP课程06"};
            this.txtCourseName.Location = new System.Drawing.Point(74, 31);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.MinimumSize = new System.Drawing.Size(28, 25);
            this.txtCourseName.MouseBack = null;
            this.txtCourseName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCourseName.Multiline = false;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.NormlBack = null;
            this.txtCourseName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCourseName.ReadOnly = false;
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.Size = new System.Drawing.Size(207, 25);
            // 
            // 
            // 
            this.txtCourseName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCourseName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCourseName.SkinTxt.Name = "BaseText";
            this.txtCourseName.SkinTxt.Size = new System.Drawing.Size(195, 18);
            this.txtCourseName.SkinTxt.TabIndex = 0;
            this.txtCourseName.SkinTxt.Text = ".Net/C#上位机开发VIP课程06";
            this.txtCourseName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseName.SkinTxt.WaterText = "";
            this.txtCourseName.TabIndex = 5;
            this.txtCourseName.Text = ".Net/C#上位机开发VIP课程06";
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCourseName.WaterText = "";
            this.txtCourseName.WordWrap = true;
            // 
            // ckbAutoClear
            // 
            this.ckbAutoClear.AutoSize = true;
            this.ckbAutoClear.BackColor = System.Drawing.Color.Transparent;
            this.ckbAutoClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ckbAutoClear.DownBack = null;
            this.ckbAutoClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbAutoClear.Location = new System.Drawing.Point(88, 53);
            this.ckbAutoClear.MouseBack = null;
            this.ckbAutoClear.Name = "ckbAutoClear";
            this.ckbAutoClear.NormlBack = null;
            this.ckbAutoClear.SelectedDownBack = null;
            this.ckbAutoClear.SelectedMouseBack = null;
            this.ckbAutoClear.SelectedNormlBack = null;
            this.ckbAutoClear.Size = new System.Drawing.Size(135, 21);
            this.ckbAutoClear.TabIndex = 6;
            this.ckbAutoClear.Text = "添加后自动清除文本";
            this.ckbAutoClear.UseVisualStyleBackColor = false;
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourseList.ColumnHeadersHeight = 30;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.ClassHour,
            this.Credit,
            this.CourseContent,
            this.CategoryName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(168)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dgvCourseList.Location = new System.Drawing.Point(13, 180);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvCourseList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.Size = new System.Drawing.Size(655, 278);
            this.dgvCourseList.TabIndex = 10;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // ClassHour
            // 
            this.ClassHour.DataPropertyName = "ClassHour";
            this.ClassHour.HeaderText = "课时";
            this.ClassHour.Name = "ClassHour";
            this.ClassHour.ReadOnly = true;
            this.ClassHour.Width = 60;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "学分";
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
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "课程分类";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(300, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 19);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(173, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "已添加课程总数：";
            // 
            // FrmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 470);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.ckbAutoClear);
            this.Controls.Add(this.groupBoxCourseInfo);
            this.Controls.Add(this.btnCloseCurrentWindow);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCourse";
            this.Text = "添加课程";
            this.groupBoxCourseInfo.ResumeLayout(false);
            this.groupBoxCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnCloseCurrentWindow;
        private CCWin.SkinControl.SkinButton btnSaveToDB;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLine skinLine1;
        private System.Windows.Forms.GroupBox groupBoxCourseInfo;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinTextBox txtCourseContent;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinComboBox cbbCategory;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinTextBox txtCredit;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinTextBox txtClassHour;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinTextBox txtCourseName;
        private CCWin.SkinControl.SkinCheckBox ckbAutoClear;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}