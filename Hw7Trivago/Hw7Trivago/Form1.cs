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
        int t;

        int h1 = 2400;
        int h2 = 1600;
        int h3 = 3000;
        int h4 = 2600;
        int h5 = 3500;

        int n1;
        int n2;
        int n3;
        int n4;
        int n5;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = this.checkBox1.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = this.checkBox2.Checked;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = this.checkBox3.Checked;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = this.checkBox4.Checked;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = this.checkBox5.Checked;
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("頂級套房，蜜月專屬。");
        }
        private void checkBox2_4_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("普通套房，普通衛浴、電視。");
        }
        private void checkBox3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("小木屋，有客廳、按摩衛浴、SPA...");
        }
        private void checkBox5_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("兩層木屋，有客廳、按摩衛浴、SPA...");
        }
        private void checkBox_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("歡迎光臨 Visual 民宿");
        }
        
        private void t_chgd()
        {
            if (t == 0)
            {
                tot.Text = Convert.ToString("請勾選房型並輸入間數");
            }
            else
            {
                tot.Text = Convert.ToString("總金額: " + t);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                t = t + h1 * n1;
                tot.Text = Convert.ToString("總金額: " + t);
            }
            catch (Exception)
            {
                t = t - h1 * n1;
                t_chgd();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToInt32(textBox2.Text);
                t = t + h2 * n2;
                tot.Text = Convert.ToString("總金額: " + t);
            }
            catch (Exception)
            {
                t = t - h2 * n2;
                t_chgd();
            }
        }
        
       
    }
}
