namespace MyControls
{
    partial class VerticalProcessBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLong = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLong
            // 
            this.lblLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLong.Location = new System.Drawing.Point(1, 1);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(28, 300);
            this.lblLong.TabIndex = 0;
            // 
            // lblShort
            // 
            this.lblShort.BackColor = System.Drawing.SystemColors.Control;
            this.lblShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShort.Location = new System.Drawing.Point(1, 1);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(27, 0);
            this.lblShort.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(23, 12);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "10%";
            // 
            // VerticalProcessBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblLong);
            this.Name = "VerticalProcessBar";
            this.Size = new System.Drawing.Size(30, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lbl;
    }
}
