using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            int a = Convert.ToInt32(DateTime.Now.Year);
            int b = Convert.ToInt32(textBox1.Text.Substring(6, 4));
            if ((a - b + 1) > 18)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("年龄太小，无法显示图片！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
