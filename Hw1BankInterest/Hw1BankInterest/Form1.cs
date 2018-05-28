using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw1BankInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            interest.Text = "0";

        }
        private void interest_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                
            }
            catch
            {
                MessageBox.Show("年利率請輸入數值!", "");

            }
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(money.Text);
                int r = Convert.ToInt32(rate.Text);
                interest.Text = Convert.ToString(m * r / 100);
            }
            catch
            {
                MessageBox.Show("本金請輸入數值!", "");

            }
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(money.Text);
                int r = Convert.ToInt32(rate.Text);
                interest.Text = Convert.ToString(m * r / 100);
            }
            catch
            {
                MessageBox.Show("年利率請輸入數值!", "");

            }
          
        }

        private void endBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
