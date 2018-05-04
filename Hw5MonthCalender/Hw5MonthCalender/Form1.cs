using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw5MonthCalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            switch(monthCalendar1.SelectionStart.Month)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("冬.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("冬.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("春.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("春.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("春.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("夏.jpg");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile("夏.jpg");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile("夏.jpg");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile("秋.jpg");
                    break;
                case 10:
                    pictureBox1.Image = Image.FromFile("秋.jpg");
                    break;
                case 11:
                    pictureBox1.Image = Image.FromFile("秋.jpg");
                    break;
                case 12:
                    pictureBox1.Image = Image.FromFile("冬.jpg");
                    break;

            }
            
       
        }
    }
}
