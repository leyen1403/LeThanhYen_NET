using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool ktsnt(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt((double)n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private String[] timuocso(int value)
        {
            int item = 1, i = 0;
            string[] a = new string[100];
            while (item < value)
            {
                if (value % item == 0)
                {
                    a[i] = item.ToString();
                    i++;
                }
                item++;
            }
            a[i] = value.ToString();
            string[] us = new string[i + 1];
            for (int j = 0; j <= i; j++)
            {
                us[j] = a[j];
            }
            return us;
        }

        private void btn_CN_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            comboBox1.Items.Add(s);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(comboBox1.SelectedItem);
            String[] st = timuocso(s);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(st);
        }

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(comboBox1.SelectedItem);
            string[] st = timuocso(s);
            int tong = 0;
            foreach (string St in st)
            {
                int i = Convert.ToInt32(St);
                tong += i;
            }
            MessageBox.Show("Tổng các ước số là: " + tong);
        }

        private void btn_UocChan_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(comboBox1.SelectedItem);
            string[] st = timuocso(s);
            int tong = 0;
            foreach (string St in st)
            {
                int i = Convert.ToInt32(St);
                if(i%2==0)
                    tong += i;
            }
            MessageBox.Show("Tổng các ước số là: " + tong);
        }

        
    }
}
