
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
            int m = monthCalendar1.SelectionStart.Month;
            if (m == 12 || (m < 2.5 && m > 0.5))
            {
                pictureBox1.Image = Image.FromFile("../../Resources/冬.jpg");
            }
            else if (m < 5.5 && m > 2.5)
            {
                pictureBox1.Image = Image.FromFile("../../Resources/春.jpg");
            }
            else if (m < 8.5 && m > 5.5)
            {
                pictureBox1.Image = Image.FromFile("../../Resources/夏.jpg");
            }
            else if (m < 11.5 && m > 8.5)
            {
                pictureBox1.Image = Image.FromFile("../../Resources/秋.jpg");
            }

        }
    }
}
