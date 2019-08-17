using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class VerticalProcessBar : UserControl
    {
        public VerticalProcessBar()
        {
            InitializeComponent();
            this.lbl.Location = new System.Drawing.Point(0, 305);   
        }

        /// <summary>
        /// 进度条长度
        /// </summary>
        private int barHeigth = 300;
        public int BarHeigth
        {
            get { return barHeigth; }
            set
            {
                if (value < 100 || value > 300)
                {
                    MessageBox.Show("value必须在100-300之间", "提示信息！");
                }
                else
                {
                    this.lblShort.Height = value;
                    this.lblLong.Height =  value;
                    this.barHeigth = value;
                    this.Size = new Size(this.Size.Width+1, value + 30);
                    this.lbl.Location = new Point(0, value+10);
                }
            }
        }

        /// <summary>
        /// 进度条宽度
        /// </summary>
        private int barWidth = 29;
        public int BarWidth
        {
            get { return barWidth; }
            set
            {
                if (value < 25 || value > 40)
                {
                    MessageBox.Show("value必须在25-40之间", "提示信息！");
                }
                else
                {
                    this.lblShort.Width = value;
                    this.lblLong.Width = value;
                    this.barWidth = value;
                    this.Size = new Size(value+1, BarHeigth + 30);
                    this.lbl.Location = new Point(value/2-12, BarHeigth + 10);
                }
            }
        }

        /// <summary>
        /// 进度值
        /// </summary>
        private double barValue = 0;
        public double BarValue
        {
            get { return barValue; }
            set
            {
                if (value < 0 | value > 100.00)
                {
                    MessageBox.Show("value必须在0-100之间", "提示信息！");
                }
                else
                {
                    double processValue = (this.BarHeigth / 100) * value;
                    this.lblShort.Height = this.lblLong.Height - Convert.ToInt32(processValue);
                    //this.lblLong.Width = value;
                    this.barValue = value;
                    //this.Size = new Size(value + 2, BarHeigth + 30);
                    //this.lbl.Location = new Point(value / 2 - 12, BarHeigth + 10);
                    this.lbl.Text = value.ToString() + "%";
                }
            }
        }

    }
}
