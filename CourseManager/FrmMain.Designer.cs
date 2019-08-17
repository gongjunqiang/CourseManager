namespace CourseManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel_Top = new CCWin.SkinControl.SkinPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentAdmin = new System.Windows.Forms.Label();
            this.panel_Right = new CCWin.SkinControl.SkinPanel();
            this.panel_Left = new CCWin.SkinControl.SkinPanel();
            this.btnModifyPwd = new CCWin.SkinControl.SkinButton();
            this.btnTeacherManager = new CCWin.SkinControl.SkinButton();
            this.btnCourseManager = new CCWin.SkinControl.SkinButton();
            this.btnAddCourse = new CCWin.SkinControl.SkinButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel_Top.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Top.BackgroundImage")));
            this.panel_Top.Controls.Add(this.btnClose);
            this.panel_Top.Controls.Add(this.lblCurrentAdmin);
            this.panel_Top.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.DownBack = null;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.MouseBack = null;
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.NormlBack = null;
            this.panel_Top.Size = new System.Drawing.Size(920, 66);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(890, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblCurrentAdmin
            // 
            this.lblCurrentAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentAdmin.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrentAdmin.Image")));
            this.lblCurrentAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentAdmin.Location = new System.Drawing.Point(845, 30);
            this.lblCurrentAdmin.Name = "lblCurrentAdmin";
            this.lblCurrentAdmin.Size = new System.Drawing.Size(70, 23);
            this.lblCurrentAdmin.TabIndex = 6;
            this.lblCurrentAdmin.Text = "龚老师";
            this.lblCurrentAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.panel_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Right.BackgroundImage")));
            this.panel_Right.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Right.DownBack = null;
            this.panel_Right.Location = new System.Drawing.Point(233, 72);
            this.panel_Right.MouseBack = null;
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.NormlBack = null;
            this.panel_Right.Size = new System.Drawing.Size(680, 470);
            this.panel_Right.TabIndex = 1;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel_Left.Controls.Add(this.btnModifyPwd);
            this.panel_Left.Controls.Add(this.btnTeacherManager);
            this.panel_Left.Controls.Add(this.btnCourseManager);
            this.panel_Left.Controls.Add(this.btnAddCourse);
            this.panel_Left.Controls.Add(this.monthCalendar1);
            this.panel_Left.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Left.DownBack = null;
            this.panel_Left.Location = new System.Drawing.Point(7, 72);
            this.panel_Left.MouseBack = null;
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.NormlBack = null;
            this.panel_Left.Size = new System.Drawing.Size(220, 470);
            this.panel_Left.TabIndex = 1;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnModifyPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnModifyPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModifyPwd.DownBack = null;
            this.btnModifyPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(41, 413);
            this.btnModifyPwd.MouseBack = null;
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.NormlBack = null;
            this.btnModifyPwd.Size = new System.Drawing.Size(141, 30);
            this.btnModifyPwd.TabIndex = 4;
            this.btnModifyPwd.Text = "修 改 登 录 密 码";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = false;
            this.btnModifyPwd.Click += new System.EventHandler(this.BtnModifyPwd_Click);
            // 
            // btnTeacherManager
            // 
            this.btnTeacherManager.BackColor = System.Drawing.Color.Transparent;
            this.btnTeacherManager.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnTeacherManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnTeacherManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnTeacherManager.DownBack = null;
            this.btnTeacherManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManager.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManager.Image")));
            this.btnTeacherManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManager.Location = new System.Drawing.Point(41, 297);
            this.btnTeacherManager.MouseBack = null;
            this.btnTeacherManager.Name = "btnTeacherManager";
            this.btnTeacherManager.NormlBack = null;
            this.btnTeacherManager.Size = new System.Drawing.Size(141, 30);
            this.btnTeacherManager.TabIndex = 4;
            this.btnTeacherManager.Text = "讲 师 信 息 管 理";
            this.btnTeacherManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacherManager.UseVisualStyleBackColor = false;
            // 
            // btnCourseManager
            // 
            this.btnCourseManager.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseManager.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnCourseManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnCourseManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCourseManager.DownBack = null;
            this.btnCourseManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseManager.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseManager.Image")));
            this.btnCourseManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManager.Location = new System.Drawing.Point(41, 251);
            this.btnCourseManager.MouseBack = null;
            this.btnCourseManager.Name = "btnCourseManager";
            this.btnCourseManager.NormlBack = null;
            this.btnCourseManager.Size = new System.Drawing.Size(141, 30);
            this.btnCourseManager.TabIndex = 4;
            this.btnCourseManager.Text = "课 程 信 息 管 理";
            this.btnCourseManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourseManager.UseVisualStyleBackColor = false;
            this.btnCourseManager.Click += new System.EventHandler(this.BtnCourseManager_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCourse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnAddCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnAddCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddCourse.DownBack = null;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(41, 206);
            this.btnAddCourse.MouseBack = null;
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.NormlBack = null;
            this.btnAddCourse.Size = new System.Drawing.Size(141, 30);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "添 加 课 程 信 息";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel_Top.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel panel_Top;
        private CCWin.SkinControl.SkinPanel panel_Right;
        private CCWin.SkinControl.SkinPanel panel_Left;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private CCWin.SkinControl.SkinButton btnAddCourse;
        private CCWin.SkinControl.SkinButton btnModifyPwd;
        private CCWin.SkinControl.SkinButton btnTeacherManager;
        private CCWin.SkinControl.SkinButton btnCourseManager;
        private System.Windows.Forms.Label lblCurrentAdmin;
        private System.Windows.Forms.Button btnClose;
    }
}