using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bi_A
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn =new DangNhap();
            dn.ShowDialog();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pMain.Controls.Add(childform);
            pMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Menu());
        }
    }
}
