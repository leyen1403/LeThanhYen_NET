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

namespace Mau_B4
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter ad;
        DataSet dtset;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS; Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        DataTable DSLop()
        {
            ad = new SqlDataAdapter("Select * from Lop", conn);
            dtset = new DataSet();
            ad.Fill(dtset);
            return dtset.Tables[0];
        }
        private void DSLop_ListView(DataTable tbhocsinh)
        {
            ListViewItem item;
            listView1.Items.Clear();
            for (int i = 0; i < tbhocsinh.Rows.Count; i++)
            {
                item = listView1.Items.Add(tbhocsinh.Rows[i][0].ToString());
                for (int j = 1; j < tbhocsinh.Columns.Count; j++)
                {
                    item.SubItems.Add(tbhocsinh.Rows[i][j].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dslop;
            dslop = DSLop();
            DSLop_ListView(dslop);
        }
    }
}
