using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw3GiveChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int r = Convert.ToInt32(textBox2.Text);
            int q = m - r;
            if (q < 0)
            {
                MessageBox.Show("收現金額不足!請注意!!!", "");
            }
            else
            {
                textBox3.Text = Convert.ToString(q);
                a.Text = Convert.ToString(q / 1000);
                    q = q - (q / 1000)*1000;
                b.Text = Convert.ToString(q / 500);
                    q = q - (q / 500)*500;
                c.Text = Convert.ToString(q / 100);
                    q = q - (q / 100) * 100;
                d.Text = Convert.ToString(q / 50);
                    q = q - (q / 50) * 50;
                ten.Text = Convert.ToString(q / 10);
                    q = q - (q / 10)*10;
                f.Text = Convert.ToString(q / 5);
                    q = q - (q / 5) * 5;
                g.Text = Convert.ToString(q / 1);
                    q = q - (q / 1) * 1;
            }
            
        }
    }
}
