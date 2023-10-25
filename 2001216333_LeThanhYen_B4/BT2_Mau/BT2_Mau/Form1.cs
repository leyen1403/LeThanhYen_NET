using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_Mau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ltitle.Font = new Font(ltitle.Font, FontStyle.Regular);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ltitle.Font = new Font(ltitle.Font, FontStyle.Bold);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ltitle.Font = new Font(ltitle.Font, FontStyle.Italic);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ltitle.Font = new Font(ltitle.Font, FontStyle.Italic | FontStyle.Bold);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ltitle.ForeColor = Color.AntiqueWhite;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ltitle.ForeColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ltitle.ForeColor = Color.Green;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ltitle.ForeColor = Color.Aqua;
            }
        }

    }
}
