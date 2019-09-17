using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s6_1
{
    public partial class BankOperation : Form
    {
        double account = 0; //账户余额
        public BankOperation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double deposit, withdrawal, temp;
            try
            {
                deposit = Convert.ToDouble(textBox1.Text);
                withdrawal = Convert.ToDouble(textBox2.Text);
                account += deposit;
                temp = account - withdrawal;
                if (temp < 0)
                {
                    label3.Text = "当前账户余额：" + account;
                    throw new ExceptionClass("当前账户余额不足！");
                }
                else
                {
                    account = temp;
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                    label3.Text = "当前账户余额：" + account;
                }
            }
            catch (ExceptionClass ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
