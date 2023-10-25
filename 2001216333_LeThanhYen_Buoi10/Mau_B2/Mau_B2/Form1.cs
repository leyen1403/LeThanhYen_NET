using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mau_B2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter sqlDataAdapter;
        public Form1()
        {
            InitializeComponent();
        }
        public void loadCbKhoa()
        {

        }
        public void formLoad()
        {

        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}