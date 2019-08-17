using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUserContorls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (this.verticalProcessBar.BarValue == 100) return;
            else
            {
                this.verticalProcessBar.BarValue += 2;
            }
        }

        private void BtnQS_Click(object sender, EventArgs e)
        {
            if (this.verticalProcessBar.BarValue == 0) return;
            else
            {
                this.verticalProcessBar.BarValue -= 2;
            }
        }
    }
}
