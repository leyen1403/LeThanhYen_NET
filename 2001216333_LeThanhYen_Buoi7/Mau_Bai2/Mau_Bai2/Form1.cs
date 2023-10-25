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

namespace Mau_Bai2
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
                if (txtMaMH.Text.Trim().Length == 0 || txtTenMH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã môn học hoặc tên môn học chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString = "insert into MonHoc values ('" + txtMaMH.Text + "', N'" + txtTenMH.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã môn học chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString = "delete MonHoc where MaMonHoc = '"+txtMaMH.Text+"'";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMH.Text.Trim().Length == 0 || txtTenMH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã môn học hoặc tên môn học chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString = "update MonHoc set TenMonHoc = N'"+txtTenMH.Text+"' where MaMonHoc = '"+txtMaMH.Text+"'";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }

    }
}
