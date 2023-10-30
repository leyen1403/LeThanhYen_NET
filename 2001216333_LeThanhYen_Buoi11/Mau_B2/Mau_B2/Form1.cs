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
        SqlConnection conn = new SqlConnection("Data Source=A207PC39;Initial Catalog=QLSinhVien;Integrated Security=True");
        DataSet ds_QLSV = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadTenSinhVien()
        {
            string strsel = "select * from SinhVien";
            SqlDataAdapter da_SinhVien = new SqlDataAdapter(strsel, conn);
            da_SinhVien.Fill(ds_QLSV, "SinhVien");
            txtHoTen.DataSource = ds_QLSV.Tables["SinhVien"];
            txtHoTen.DisplayMember = "HoTen";
        }
        public void LoadTenMonHoc()
        {
            string strsel = "select * from MonHoc";
            SqlDataAdapter da_MonHoc = new SqlDataAdapter(strsel, conn);
            da_MonHoc.Fill(ds_QLSV, "MonHoc");
            txtMonHoc.DataSource = ds_QLSV.Tables["MonHoc"];
            txtMonHoc.DisplayMember = "TenMonHoc";
            txtMonHoc.ValueMember = "MaMonHoc";
        }
        public void LoadDataGridView()
        {
            string select = "select Diem.MaSinhVien, Diem.MaMonHoc, Diem, HoTen, TenMonHoc from Diem, SinhVien, MonHoc where Diem.MaSinhVien = SinhVien.MaSinhVien and Diem.MaMonHoc = MonHoc.MaMonHoc";
            SqlDataAdapter da_Diem = new SqlDataAdapter(select, conn);
            da_Diem.Fill(ds_QLSV, "Diem");
            dataGridView1.DataSource = ds_QLSV.Tables["Diem"];
            dataGridView1.Columns["HoTen"].Visible = false;
            dataGridView1.Columns["TenMonHoc"].Visible = false;
        }
        public void Databingding(DataTable pDT)
        {
            txtDiem.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtMonHoc.DataBindings.Clear();

            txtDiem.DataBindings.Add("Text", pDT, "Diem");
            txtHoTen.DataBindings.Add("Text", pDT, "HoTen");
            txtMonHoc.DataBindings.Add("Text", pDT, "TenMonHoc");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTenSinhVien();
            LoadTenMonHoc();
            LoadDataGridView();
            dataGridView1.AllowUserToAddRows = false;
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox) || item.GetType() == typeof(MaskedTextBox))
                {
                    item.Enabled = false;
                }
            }
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;            
            Databingding(ds_QLSV.Tables["Diem"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = true;

            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }
    }
}
