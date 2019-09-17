using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(textBox1.Text);
            int month = Int32.Parse(textBox2.Text);
            int day = Int32.Parse(textBox3.Text);
            DateTime d = new DateTime(year, month, day);
            label2.Text = "这一天是这一年的第" + Convert.ToString(d.DayOfYear) + "天";
        }
    }
}
