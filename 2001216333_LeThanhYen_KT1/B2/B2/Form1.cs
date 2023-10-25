using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool ktsnt(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            string inputText = textBox1.Text;
            string[] numberStrings = inputText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out n))
                {
                    numbers[i] = n;
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ:");
                    return;
                }
            }
            textBox2.Text = string.Join(", ", numbers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            string inputText = textBox1.Text;
            string[] numberStrings = inputText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out n))
                {
                    numbers[i] = n;
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ:");
                    return;
                }
            }
            int tong = 0;
            foreach (int i in numbers)
            {
                if (ktsnt(i))
                    tong += i;
            }
            textBox4.Text = tong.ToString();
            int sum = numbers.Sum();
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 0;
            string inputText = textBox1.Text;
            string[] numberStrings = inputText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out n))
                {
                    numbers[i] = n;
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ:");
                    return;
                }
            }
            Array.Sort(numbers);
            //string str = string.Join(", ", numbers);
            textBox2.Text = string.Join(", ", numbers);
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát????", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
