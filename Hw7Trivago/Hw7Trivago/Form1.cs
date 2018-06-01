using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw7Trivago
{
    public partial class Form1 : Form
    {
        int on1 = 0;
        int on2 = 0;
        int on3 = 0;
        int on4 = 0;
        int on5 = 0;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            on1 = on1 + 1;
            if (on1 % 2 == 1)
            {
                int h1 = 2400;
                textBox1.Enabled = true;
            }
            else
            {
                tot.Text = Convert.ToString("請勾選房型並輸入間數");
                textBox1.Enabled = false;
            }
        }
       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            on2 = on2 + 1;
            if (on2 % 2 == 1)
            {
                tot.Text = Convert.ToString("總金額:" + (t + 2400));
            }
            else
            {
                tot.Text = Convert.ToString("請勾選房型並輸入間數");
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            on3 = on3 + 1;
            if (on3 % 2 == 1)
            {
                tot.Text = Convert.ToString("總金額:" + (t + 2400));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            on4 = on4 + 1;
            if (on4 % 2 == 1)
            {
                tot.Text = Convert.ToString("總金額:" + (t + 2400));
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            on5 = on5 + 1;
            if (on5 % 2 == 1)
            {
                tot.Text = Convert.ToString("總金額:" + (t + 2400));
            }
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("請勾選");
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("歡迎光臨 Visual 民宿");
        }
    }
}
