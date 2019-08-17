using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class TxtBoxExt : TextBox
    {
        public TxtBoxExt()
        {
            InitializeComponent();
        }

        public TxtBoxExt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //扩展一个非空验证功能
        public int BeginCheckEmpty()
        {
            if (this.Text.Trim().Length == 0)
            {
                this.errorProvider.SetError(this, "必填项不能为空");
                return 0;//代表验证不通过
            }
            else
            {
                this.errorProvider.SetError(this, "");//清楚小圆点提示信息
                return 1;
            }
        }


        /// <summary>
        /// 通用正则表达式验证（可以实现非常复杂的数据格式验证）
        /// </summary>
        /// <param name="regularExpress"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public int BeginCommonValidate(string regularExpress,string errorMsg)
        {
            if (BeginCheckEmpty() == 0)
            {
                return 0;
            }
            //创建政正则表达式
            Regex regex = new Regex(regularExpress, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(this.Text))
            {
                this.errorProvider.SetError(this, errorMsg);
                return 0;//代表验证不通过
            }
            else
            {
                this.errorProvider.SetError(this, "");//清楚小圆点提示信息
                return 1;
            }

        }

        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="regularExpress"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public int BeginValidatePostive(string errorMsg)
        {
            return BeginCommonValidate(@"^[1-9]\d*$", errorMsg);
        }


        /// <summary>
        /// 验证纯数字
        /// </summary>
        /// <param name="regularExpress"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public int BeginValidateIsNumber(string errorMsg)
        {
            return BeginCommonValidate(@"^[0-9]*$", errorMsg);
        }

        /// <summary>
        /// 验证电子邮件
        /// </summary>
        /// <param name="regularExpress"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public int BeginValidateEmail(string errorMsg)
        {
            return BeginCommonValidate(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", errorMsg);
        }


        /// <summary>
        /// 范围验证
        /// </summary>
        /// <param name="regularExpress"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        public int BeginValidateRange(string errorMsg,int max,int min)
        {
            //验证是否位正整数
            if (BeginValidatePostive(errorMsg) == 0)
            {
                return 0;
            }

            //验证是否在某一个范围
            if (min < Convert.ToInt32(this.Text.Trim()) && Convert.ToInt32(this.Text.Trim()) < max)
            {
                this.errorProvider.SetError(this, "");
                return 1;
            }
            else
            {
                this.errorProvider.SetError(this, errorMsg);
                return 0;
            }
        }
    }
}
