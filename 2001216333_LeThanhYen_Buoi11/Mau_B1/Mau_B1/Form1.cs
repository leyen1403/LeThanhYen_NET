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

namespace Mau_B1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");
        DataSet ds_QLSV = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadDuLieuLop()
        {
            string strsel = "select MaLop, TenLop from lop";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(strsel, conn);
            da_Khoa.Fill(ds_QLSV, "Lop");
            cbbLop.DataSource = ds_QLSV.Tables["Lop"];
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }
        public void LoadDuLieuDataGridView()
        {
            string strsel = "select MaSinhVien, HoTen, NgaySinh, Lop.MaLop, TenLop from SinhVien, Lop where SinhVien.MaLop = Lop.MaLop";
            SqlDataAdapter da_Khoa = new SqlDataAdapter(strsel, conn);
            da_Khoa.Fill(ds_QLSV, "SinhVien");
            dataGridView1.DataSource = ds_QLSV.Tables["SinhVien"];
            dataGridView1.Columns["TenLop"].Visible = false;
            //dataGridView1.DataSource = ds_QLSV.Tables["SinhVien"].DefaultView.ToTable(false, "MaSinhVien", "HoTen", "NgaySinh", "MaLop");
        }
        public void Databingding(DataTable pDT)
        {
            cbbLop.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtMaSV.DataBindings.Clear();
            txtNgaySinh.DataBindings.Clear();

            //string strsel = "select MaLop, TenLop from lop";
            //SqlDataAdapter da_Khoa = new SqlDataAdapter(strsel, conn);
            //da_Khoa.Fill(ds_QLSV, "Lop");
            //cbbLop.DataSource = ds_QLSV.Tables["Lop"];
            //cbbLop.DisplayMember = "TenLop";
            //cbbLop.ValueMember = "MaLop";
            //string s = "select SinhVien." + cbbLop.DataBindings.Add("Text", pDT, "MaLop").ToString() + "'TenLop' from SinhVien, Lop where SinhVien.MaLop = Lop.MaLop";
            //DataTable temp = new DataTable();
            //SqlDataAdapter da_temp = new SqlDataAdapter(s, conn);
            //da_temp.Fill(temp);

            cbbLop.DataBindings.Add("Text", pDT, "TenLop");
            txtHoTen.DataBindings.Add("Text", pDT, "HoTen");
            txtMaSV.DataBindings.Add("Text", pDT, "MaSinhVien");
            txtNgaySinh.DataBindings.Add("Text", pDT, "NgaySinh");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Click += btnXoa_Click;
            LoadDuLieuLop();
            LoadDuLieuDataGridView();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox) || item.GetType() == typeof(MaskedTextBox))
                {
                    item.Enabled = false;
                }
            }
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
            Databingding(ds_QLSV.Tables["SinhVien"]);
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtNgaySinh.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
            }
            catch
            {
                txtNgaySinh.Text = string.Empty;
            }
            
            btnSua.Enabled = btnXoa.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].ReadOnly = false;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strsel = "select MaSinhVien, HoTen, NgaySinh, MaLop from SinhVien";
            SqlDataAdapter da_SinhVien = new SqlDataAdapter(strsel, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da_SinhVien);
            da_SinhVien.Update(ds_QLSV, "SinhVien");
            Databingding(ds_QLSV.Tables["SinhVien"]);
            MessageBox.Show("Thanh cong");
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                SqlDataAdapter da_SinhVien = new SqlDataAdapter("select * from Diem D, SinhVien S where D.MaSinhVien = S.MaSinhVien and S.MaSinhVien = '" + txtMaSV.Text + "'", conn);
                DataSet temp = new DataSet();
                da_SinhVien.Fill(temp, "temp");
                if (temp.Tables["temp"].Rows.Count==0)
                {
                    // Xóa dòng được chọn khỏi DataGridView
                    dataGridView1.Rows.Remove(selectedRow);
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sinh viên này đang được dùng trong bảng điểm");
                }
            }
        }
                
    }
}
