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
using System.Data.Common;

namespace Mau_B3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");

            InitializeComponent();
        }
        void Load_ComboBox()
        {
            //Khai báo DataSet
            DataSet ds = new DataSet();
            //Tạo SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter("select * from Lop", conn);
            //đổ dữ liệu từ da vào ds
            da.Fill(ds, "Lop");
            cboMaLop.DataSource = ds.Tables[0];
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
        }
        void Load_dgv()
        {
            //Khai báo dataset
            DataSet ds = new DataSet();
            //Khai báo DataAdaper
            string selectString = "select MaSinhVien N'Mã sinh viên', HoTen N'Tên sinh viên', NgaySinh N'Ngày sinh', TenLop N'Tên lớp' from SinhVien, Lop where SinhVien.MaLop = Lop.MaLop";
            SqlDataAdapter da = new SqlDataAdapter(selectString, conn);
            //đổ dữ liệu
            da.Fill(ds, "SinhVien_Lop");
            dgvSinhVien_Lop.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
            Load_dgv();
        }
        bool KT_KhoaChinh(string key)
        {
            conn.Open();
            string selectString = "select count(*) from SinhVien where MaSinhVien = '" + key + "'";
            SqlCommand cmd = new SqlCommand(selectString, conn);
            cmd.ExecuteScalar();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if(count == 0)
            {
                return true;
            }
            return false;
        }
        void textClear()
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtMaSinhVien.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSinhVien.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }    
                if(KT_KhoaChinh(txtMaSinhVien.Text) == true)
                {
                    conn.Open();
                    string insertString = "set dateformat dmy insert into SinhVien values ('"+txtMaSinhVien.Text+"', N'"+txtHoTen.Text+"', '"+Convert.ToString(txtNgaySinh.Text)+"', '"+cboMaLop.SelectedValue.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thành công");
                }
            }
            catch
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thất bại");
            }
            Load_dgv();
            textClear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSinhVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên");
                    return;
                }
                string deleteString = "delete from SinhVien where MaSinhVien = '" + txtMaSinhVien.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công");
            }
            catch
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thất bại");
            }
            Load_dgv();
            textClear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSinhVien.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
                if (KT_KhoaChinh(txtMaSinhVien.Text) == false)
                {
                    conn.Open();
                    string editString = "set dateformat dmy update SinhVien set HoTen = N'" + txtHoTen.Text + "', NgaySinh = '" + Convert.ToString(txtNgaySinh.Text) + "', MaLop ='" + cboMaLop.SelectedValue.ToString() +"' where MaSinhVien = '"+txtMaSinhVien.Text+"'";
                    SqlCommand cmd = new SqlCommand(editString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thành công");
                }
            }
            catch
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thất bại");
            }
            Load_dgv();
            textClear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
