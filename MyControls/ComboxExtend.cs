using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class ComboxExtend : ComboBox
    {
        public ComboxExtend()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FlatStyle = FlatStyle.Flat;

        }

        public ComboxExtend(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        //扩展一个非空验证功能
        public int BeginCheckEmpty()
        {
            if (this.SelectedIndex == -1 || this.Text.Trim().Contains("请选择"))
            {
                this.errorProvider.SetError(this,"您还未选择");
                return 0;
            }
            else
            {
                this.errorProvider.SetError(this, "");//清楚小圆点提示信息
                return 1;
            }
        }
    }
}
