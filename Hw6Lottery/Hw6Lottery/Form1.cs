using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw6Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] randomArray = new int[6];
            Random rdm = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomArray[i] = rdm.Next(1, 43);   //亂數產生，亂數產生的範圍是1~43

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rdm.Next(1, 43);   //重新產生，存回陣列，亂數產生的範圍是1~43
                    }
                }
            }
            
            pictureBox1.Image = Image.FromFile(randomArray[0] + ".gif");
            pictureBox2.Image = Image.FromFile(randomArray[1] + ".gif");
            pictureBox3.Image = Image.FromFile(randomArray[2] + ".gif");
            pictureBox4.Image = Image.FromFile(randomArray[3] + ".gif");
            pictureBox5.Image = Image.FromFile(randomArray[4] + ".gif");
            pictureBox6.Image = Image.FromFile(randomArray[5] + ".gif");
        }
    }
}
