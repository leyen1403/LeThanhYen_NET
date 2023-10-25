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
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS; Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        bool kt_makhoa(string ma)
        {
            try
            {
                conn.Open();   
                string selectString = "select count(*) from Khoa where MaKhoa = '" + ma + "'";
                SqlCommand cmd = new SqlCommand(selectString, conn);
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                if (count >= 1)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length == 0 || txtTenKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (kt_makhoa(txtMaKhoa.Text))
                {
                    conn.Open();
                    string insertString;
                    insertString = "insert into Khoa values ('"+txtMaKhoa.Text+"',N'"+txtTenKhoa.Text+"')";
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thành Công!");
                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();
                    txtMaKhoa.Focus();
                }
                else
                {
                    MessageBox.Show("trùng mã khoa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã khoa");
                    return;
                }
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString = "delete Khoa where MaKhoa = '" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành Công");
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
                if (txtMaKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Khoa!");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string updateString = "update Khoa set TenKhoa = N'" + txtTenKhoa.Text + "' where MaKhoa = '" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thành Công!");
            }
        }
    }
}
