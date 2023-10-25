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

namespace Mau_Bai1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=A207PC39; Initial Catalog=QLSinhVien;Integrated Security=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length == 0 || txtTenKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã khoa hoặc tên khoa ban chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString;
                insertString = "insert into Khoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text.Trim().Length == 0 || txtTenKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã khoa hoặc tên khoa ban chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string updateString;
                updateString = "update Khoa set TenKhoa = N'"+ txtTenKhoa.Text+"' where MaKhoa = '"+txtMaKhoa.Text+"'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã khoa bạn chưa nhập kìa! Nhập lại", "Thông báo");
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString;
                deleteString = "delete Khoa where MaKhoa = '" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại");
            }
        }
    }
}
