using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mau_BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] s = { "K'Me", "Kinh", "Tày", "Mông", "Hoa" };
            foreach (string st in s)
            {
                comboBox1.Items.Add(st);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát????", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void btnht_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (comboBox1.SelectedIndex >= 0)
                lbkq.Text = s + comboBox1.SelectedItem.ToString();
            else lbkq.Text = "Bạn chưa chọn dân tộc";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn: " + comboBox1.SelectedItem.ToString());
        }

    }
}
