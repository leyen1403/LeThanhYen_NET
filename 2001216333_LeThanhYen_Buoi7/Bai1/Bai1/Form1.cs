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

namespace Bai1
{    
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=A207PC39; Initial Catalog=QLSinhVien;Integrated Security=True");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaLop.Text.Trim().Length == 0 || txtMaSV.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString = "SET DATEFORMAT dmy insert into SinhVien(MaLop, MaSinhVien, HoTen, NgaySinh) values ('" + txtMaLop.Text + "','" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" + Convert.ToDateTime(txtNgaySinh.Text) + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại"+ ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text.Trim().Length == 0 || txtMaSV.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString = "delete from sinhvien where Masinhvien='"+txtMaSV.Text+"'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text.Trim().Length == 0 || txtMaSV.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string updateString = "SET DATEFORMAT dmy update SinhVien set malop='" + txtMaLop.Text + "', hoten = N'" + txtHoTen.Text + "', ngaysinh = '" + Convert.ToDateTime(txtNgaySinh.Text) + "' where masinhvien = '" + txtMaSV.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex.Message);
            }
        }
    }
}
