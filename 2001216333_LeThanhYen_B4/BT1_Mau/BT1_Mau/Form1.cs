using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_Mau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Kết quả là: \n";
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            TinhToan dt = new TinhToan(a, b);
            if (cong.Checked)
            {
                MessageBox.Show(s + a + "+" + b + "=" + dt.Cong());
                txtkq.Text = dt.Cong().ToString();
            }
            else if (tru.Checked)
            {
                MessageBox.Show(s + a + "-" + b + "=" + dt.Tru());
                txtkq.Text = dt.Tru().ToString();
            }
            else if (tru.Checked)
            {
                MessageBox.Show(s + a + "*" + b + "=" + dt.Nhan());
                txtkq.Text = dt.Nhan().ToString();
            }
            else if (b != 0)
            {
                MessageBox.Show(s + a + "/" + b + "=" + dt.Chia());
                txtkq.Text = dt.Chia().ToString();
            }
            else
                MessageBox.Show("Phép chia bị lỗi");
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txta, "Không phải số");
            else this.errorProvider1.Clear();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số, nhập lại";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtb, "Không phải số");
            else this.errorProvider1.Clear();
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Không phải số, nhập lại";
                String title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }
    }
    public class TinhToan
    {
        float _a, _b;
        public float b
        {
            get { return _b; }
            set { _b = value; }
        }
        public float a
        {
            get { return _a; }
            set { _a = value; }
        }
        public TinhToan()
        {
            a = b = 0;
        }
        public TinhToan(float a, float b)
        {
            _a = a;
            _b = b;
        }
        public float Cong() { return _a + b; }
        public float Tru() { return _a - b; }
        public float Nhan() { return _a * b; }
        public float Chia() { return _a / b; }
    }
}
