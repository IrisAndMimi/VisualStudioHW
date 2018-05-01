using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw4StoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] food_inf = new string[] {
            "--請輸入品名--","黑松汽水","純粹喝咖啡","純喫茶紅茶","飲冰室綠奶茶","台灣啤酒"
        };
        string food = "";
        int[] cost_inf = new int[] {0,12,20,10,15,34};
        int[] pay_inf = new int[] {0,30,30,25,25,60};
        int cost = 0;
        int pay = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("品名未輸入(字串)", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbx_cost.Text == "")
            {
                MessageBox.Show("成本未輸入(正整數)", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    cost = Convert.ToInt32(tbx_cost.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("成本輸入格式不合(正整數)", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (tbx_pay.Text == "")
            {
                MessageBox.Show("售價未輸入(正整數)", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    pay = Convert.ToInt32(tbx_pay.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("售價輸入格式不合(正整數)", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (cost > pay)
            {
                MessageBox.Show("輸入過程出現問題" + "\n" + "成本:" + cost + ">" + "售價:" + pay, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < food_inf.Length; i++)
                {
                    if (food_inf[i].Equals(comboBox1.Text))
                    {
                        try
                        {
                            cost_inf[i] = Convert.ToInt32(tbx_cost.Text);
                        }
                        catch (Exception)
                        {
                            cost_inf[i] = 0;
                        }
                        try
                        {
                            pay_inf[i] = Convert.ToInt32(tbx_pay.Text);
                        }
                        catch (Exception)
                        {
                            pay_inf[i] = 0;
                        }
                        MessageBox.Show("資料修改成功!" + "\n" + "品名:" + food + "\n" + "成本:" + cost + "\n" + "售價:" + pay, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                        break;
                    };
                }
                if (flag == false)
                {
                    System.Array.Resize(ref food_inf, food_inf.Length + 1);
                    System.Array.Resize(ref cost_inf, cost_inf.Length + 1);
                    System.Array.Resize(ref pay_inf, pay_inf.Length + 1);
                    food_inf[food_inf.Length - 1] = comboBox1.Text;
                    food = comboBox1.Text;
                    cost_inf[cost_inf.Length - 1] = Convert.ToInt32(tbx_cost.Text);
                    pay_inf[pay_inf.Length - 1] = Convert.ToInt32(tbx_pay.Text);
                    MessageBox.Show("新增資料成功!" + "\n" + "品名:" + food + "\n" + "成本:" + cost + "\n" + "售價:" + pay, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(food_inf);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            food = food_inf[comboBox1.SelectedIndex];
            cost = cost_inf[comboBox1.SelectedIndex];
            pay = pay_inf[comboBox1.SelectedIndex];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(food_inf);
            comboBox1.SelectedIndex = 0;
        }

    }
}
