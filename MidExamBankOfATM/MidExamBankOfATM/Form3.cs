using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidExamBankOfATM
{
    public partial class Form3 : Form
    {
        int chsn = 0;
        int mon = 50000;
        public Form3()
        {
            InitializeComponent();
        }
        int swi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = Convert.ToString("確定[&C]");
            swi = 1;
            groupBox1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (swi==1)
            {
                string mes = "請點收金額! NT$"+ chsn + " \r\n" + "剩餘金額 NT$" +(mon - chsn)+ "."+" \r\n"+ "歡迎再度光臨!";
                MessageBox.Show(mes,"254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                Form4 form = new Form4();
                form.ShowDialog();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 2000;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 1000;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 5000;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 3000;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 8000;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chsn = 10000;
        }
    }
}
