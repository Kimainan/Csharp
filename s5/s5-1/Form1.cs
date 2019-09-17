using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i, j;
        public int count, num;
        public int clock;
        public string ans;
        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            num = 0;
            clock = 60;
            timer1.Interval = 1000;
            timer1.Start();
            label4.Text = "倒计时：" + Convert.ToString(clock);
            label5.Text = "题1";
            label6.Text = "得分：" + Convert.ToString(count);
            Random ran = new Random();
            i = ran.Next(100);
            textBox1.Text = Convert.ToString(i);
            j = ran.Next(100);
            textBox2.Text = Convert.ToString(j);
            ans = Convert.ToString(i + j);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            clock--;
            label4.Text = "倒计时：" + Convert.ToString(clock);
            if (clock == 0)
            {
                timer1.Stop();
                MessageBox.Show(num + "道题，您一共答对了" + count + "道题", "答案统计", MessageBoxButtons.OK);
            }
        }
        private void textBox3_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox3.Text == ans)
                {
                    count += 1;
                }
                textBox3.Text = "";
                label5.Text = "题" + Convert.ToString(num);
                label6.Text = "得分：" + Convert.ToString(count);
                Random ran = new Random();
                i = ran.Next(100);
                textBox1.Text = Convert.ToString(i);
                j = ran.Next(100);
                textBox2.Text = Convert.ToString(j);
                ans = Convert.ToString(i + j);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_Press);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//结束，关闭窗体
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num += 1;
        }

    }
}
