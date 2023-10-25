using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mau_BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] s = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach (string st in s)
            {
                tv_DS.Nodes.Add(st);
                cb_PhongBan.Items.Add(st);
            }
            cb_PhongBan.SelectedIndex = 0;
        }

        private void btn_Xoapb_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?" , "Xóa phòng ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                if (tv_DS.SelectedNode != null)
                {
                    cb_PhongBan.Items.Remove(tv_DS.SelectedNode.Text);
                    tv_DS.SelectedNode.Remove();
                }
            }
        }

        private void btn_Thempb_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (!string.IsNullOrEmpty(txt_phongBan.Text))
            {
                TreeNode Node = new TreeNode();
                Node.Text = txt_phongBan.Text;
                foreach (TreeNode node in tv_DS.Nodes)
                {
                    if (string.Equals(Node.Text, node.Text))
                    {
                        MessageBox.Show("Node đã tồn tại");
                        t = true;
                    }
                }
                if (t == false)
                {
                    tv_DS.Nodes.Add(Node);
                }
                cb_PhongBan.Items.Add(txt_phongBan.Text);
                txt_phongBan.Clear();
                txt_phongBan.Focus();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in tv_DS.Nodes)
            {
                if (node.Text == cb_PhongBan.Text)
                {
                    index = node.Index;
                    break;
                }
            }
                tv_DS.Nodes[index].Nodes.Add(txt_HoTen.Text + "(" + txt_maSo.Text + ")");
                tv_DS.ExpandAll();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
