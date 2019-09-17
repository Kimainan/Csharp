using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace s6_2
{
    public partial class EMailCheck : Form
    {   
        //E-Mail地址格式的正则表达式
        string emailPattern = @"^([A-Za-z0-9]{1}[A-Za-z0-9_]*)@([A-Za-z0-9_]+)[.]([A-Za-z0-9_]*)$";
        bool emailCheckResult;
        public EMailCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            emailCheckResult = Regex.IsMatch(textBox1.Text, emailPattern);
            try
            {
                if (!emailCheckResult)
                {
                    label2.Text = "不是一个合法的Email地址";
                    throw new EmailCheckException("Email地址格式不符合规范！");
                }
                else
                {
                    label2.Text = "是一个合法的Email地址";
                }

            }
            catch (EmailCheckException ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
