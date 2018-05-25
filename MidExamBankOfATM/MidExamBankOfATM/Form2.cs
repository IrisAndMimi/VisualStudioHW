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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int wrg = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("未輸入字串!!", "254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Convert.ToString(textBox1.Text) == "a")
            {
                Close();
                Form3 form = new Form3();
                form.ShowDialog();
            }
            else
            {

                if (wrg > 0)
                {
                    label1.Text = Convert.ToString("您只剩" + wrg + "次的機會喔!");
                    wrg = wrg - 1;
                    return;
                }
                else
                {
                    MessageBox.Show("密碼錯誤!!", "254's ATM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
