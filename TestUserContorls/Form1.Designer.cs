namespace TestUserContorls
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQS = new System.Windows.Forms.Button();
            this.verticalProcessBar = new MyControls.VerticalProcessBar();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "点击增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnQS
            // 
            this.btnQS.Location = new System.Drawing.Point(414, 264);
            this.btnQS.Name = "btnQS";
            this.btnQS.Size = new System.Drawing.Size(75, 23);
            this.btnQS.TabIndex = 2;
            this.btnQS.Text = "点击减少";
            this.btnQS.UseVisualStyleBackColor = true;
            this.btnQS.Click += new System.EventHandler(this.BtnQS_Click);
            // 
            // verticalProcessBar
            // 
            this.verticalProcessBar.BarHeigth = 300;
            this.verticalProcessBar.BarValue = 0D;
            this.verticalProcessBar.BarWidth = 29;
            this.verticalProcessBar.Location = new System.Drawing.Point(229, 131);
            this.verticalProcessBar.Name = "verticalProcessBar";
            this.verticalProcessBar.Size = new System.Drawing.Size(30, 320);
            this.verticalProcessBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.verticalProcessBar);
            this.Controls.Add(this.btnQS);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "测试用户控件";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQS;
        private MyControls.VerticalProcessBar verticalProcessBar;
    }
}

