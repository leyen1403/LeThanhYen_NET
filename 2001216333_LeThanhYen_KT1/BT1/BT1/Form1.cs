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
        public int CongSNT(int n, int m)
        {
            int total = 0;
            for (int num = Math.Max(2, n); num <= m; num++)
            {
                if (ktsnt(num) == true)
                    total += num;
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            textBox3.Text = CongSNT(n, m).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát????", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải là ký tự Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }
    }
}
