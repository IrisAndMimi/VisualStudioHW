using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw2CameraShop
{
    public partial class Form1 : Form
    {
        int on1 = 0;
        int on2 = 0;
        int ca5 = 0;
        int ca4 = 0;
        int ca2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_Checked(object sender, EventArgs e)
        {
            on1 = on1 + 1;
            if (on1 % 2 == 1)
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot + 599);
            }
            else
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot - 599);
            }
        }

        private void checkBox2_Checked(object sender, EventArgs e)
        {
            on2 = on2 + 1;
            if (on2 % 2 == 1)
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot + 499);
            }
            else
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot - 499);
            }
        }

        private void protect_CheckedChanged(object sender, EventArgs e)
        {
            
            gift.Text = Convert.ToString("保護貼");
        }

        private void prewet_CheckedChanged(object sender, EventArgs e)
        {
            gift.Text = Convert.ToString("防潮盒");
        }

        private void clean_CheckedChanged(object sender, EventArgs e)
        {
            gift.Text = Convert.ToString("清潔組");
        }

        private void radioButton1_Checked(object sender, EventArgs e)
        {
            ca5 = ca5 + 1;
            if (ca5 % 2 == 1)
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot + 5980);
            }
            else
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot - 5980);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ca4 = ca4 + 1;
            if (ca4 % 2 == 1)
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot + 4980);
            }
            else
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot - 4980);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ca2 = ca2 + 1;
            if (ca2 % 2 == 1)
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot + 2980);
            }
            else
            {
                int tot = Convert.ToInt32(total.Text);
                total.Text = Convert.ToString(tot - 2980);
            }
        }

       
        
    }
}
