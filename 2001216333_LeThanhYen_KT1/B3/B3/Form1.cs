using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public class TongTien
        {
            public int GiaThucUong { get; set; }
            public int SoLuong { get; set; }
            public bool SanVuon { get; set; }

            public TongTien(int giaThucUong, int soLuong, bool sanVuon)
            {
                GiaThucUong = giaThucUong;
                SoLuong = soLuong;
                SanVuon = sanVuon;
            }

            public double TinhTongTien()
            {
                double tongTien = GiaThucUong * SoLuong;

                if (SanVuon)
                {
                    // Giảm giá 15% nếu khách hàng chọn sân vườn
                    tongTien *= 0.85;
                }

                return tongTien;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát????", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = radioButton1.Checked;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                int n = 0;
                if (!int.TryParse(textBox1.Text, out n) || n < 0)
                {
                    errorProvider1.SetError(textBox1, "Số lượng không hợp lệ");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = radioButton2.Checked;
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int n = 0;
                if (!int.TryParse(textBox2.Text, out n) || n < 0)
                {
                    errorProvider1.SetError(textBox2, "Số lượng không hợp lệ");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = radioButton3.Checked;
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                int n = 0;
                if (!int.TryParse(textBox3.Text, out n) || n < 0)
                {
                    errorProvider1.SetError(textBox3, "Số lượng không hợp lệ");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int giaCafeSua = 25000;
            int giaCafeDa = 20000;
            int giaCafeDen = 15000;


            if (radioButton1.Checked)
            {
                TongTien cafesua = new TongTien(giaCafeSua, Convert.ToInt32(textBox1.Text), checkBox1.Checked);

                textBox4.Text = Convert.ToString(cafesua.TinhTongTien());
            }
            if (radioButton2.Checked)
            {
                TongTien cafeda = new TongTien(giaCafeDa, Convert.ToInt32(textBox2.Text), checkBox1.Checked);

                textBox4.Text = Convert.ToString(cafeda.TinhTongTien());
            }
            if (radioButton3.Checked)
            {
                TongTien cafeden = new TongTien(giaCafeDen, Convert.ToInt32(textBox3.Text), checkBox1.Checked);

                textBox4.Text = Convert.ToString(cafeden.TinhTongTien());
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox4.Clear();
        }
    }
}
