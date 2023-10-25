using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mau_BT1
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void frmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát????", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            lst_phai.Items.Add(lst_trai.SelectedItem);
            lst_trai.Items.Remove(lst_trai.SelectedItem);
        }

        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            lst_phai.Items.AddRange(lst_trai.Items);
            lst_trai.Items.Clear();
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {
            string[] s = { "Cóc", "Me", "Xoài", "Chanh", "Bưởi", "Cam" };
            foreach (string st in s)
            {
                lst_trai.Items.Add(st);
            }
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            lst_trai.Items.Add(lst_phai.SelectedItem);
            lst_phai.Items.Remove(lst_phai.SelectedItem);
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            lst_trai.Items.AddRange(lst_phai.Items);
            lst_phai.Items.Clear();
        }
    }
}
