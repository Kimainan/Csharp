using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show(this, "操作数不能为空", "提示信息",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                long i1 = Convert.ToInt64(textBox1.Text);
                long i2 = Convert.ToInt64(textBox2.Text);
                if (i1 > 0 && i2 > 0)
                {
                    i1++;
                    textBox3.Text = Convert.ToString(i1 + i2);
                }
                else if (i1 < 0 && i2 < 0)
                {
                    i1 -= 10;
                    textBox3.Text = Convert.ToString(i1 * i2);
                }
                else if (i1 == 0 || i2 == 0)
                {
                    MessageBox.Show("数据有错误");
                }
                else
                {
                    textBox3.Text = Convert.ToString(Math.Abs(i1 * i2));
                }
            }
            catch (Exception e1)
            {    //捕捉异常，例如：若输入字母，在转换成long类型时会引发异常
                MessageBox.Show(this, e1.Message, "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
