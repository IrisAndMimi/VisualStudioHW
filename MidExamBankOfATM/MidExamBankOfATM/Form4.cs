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
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int mon = 50000;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("未輸入字串!!", "254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (m > 30000|| m>mon)
            {
                MessageBox.Show("輸入錯誤!請重新輸入!", "254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int chsn = Convert.ToInt32(textBox1.Text);
                string mes = "請點收金額! NT$" + chsn + " \r\n" + "剩餘金額 NT$" + (mon - chsn) + "." + " \r\n" + "歡迎再度光臨!";
                MessageBox.Show(mes, "254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
