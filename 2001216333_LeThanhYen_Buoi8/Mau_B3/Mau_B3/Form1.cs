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
namespace Mau_B3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS; Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        private void LoadLop_ComboBox()
        {
            conn.Open();
            string selectString = "select * from Lop";
            SqlCommand cmd = new SqlCommand(selectString, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cbMaLop.Items.Add(rd["MaLop"].ToString());
            }
            conn.Close();
        }
        public bool KT_KhoaChinh(string ma)
        {
            try
            {
                conn.Open();
                string selectString = "select count(*) from SinhVien where MaSinhVien = '" + ma + "'";
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
                if(txtMaSinhVien.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtNgaySinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if(KT_KhoaChinh(txtMaSinhVien.Text))
                {
                    conn.Open();
                    string insertString = "set dateformat dmy insert into SinhVien values ('" + txtMaSinhVien.Text + "',N'" + txtHoTen.Text + "','" + Convert.ToDateTime(txtNgaySinh.Text) + "','" + cbMaLop.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công!");
                    conn.Close();
                    txtMaSinhVien.Clear();
                    txtHoTen.Clear();
                    txtNgaySinh.Clear();
                    txtMaSinhVien.Focus();
                }
                else
                {
                    MessageBox.Show("Trùng Mã Sinh viên");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLop_ComboBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSinhVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã Sinh viên");
                    return;
                }
                conn.Open();
                string deleteString = "delete SinhVien where MaSinhVien = '" + txtMaSinhVien.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSinhVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên");
                    return;
                }
                conn.Open();
                string updateString = "set dateformat dmy update SinhVien set HoTen = N'" + txtHoTen.Text + "', MaLop = '" + cbMaLop.SelectedItem.ToString() + "', NgaySinh = '" + Convert.ToDateTime(txtNgaySinh.Text) + "' where MaSinhVien = '" + txtMaSinhVien.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Thất bại!");
            }
        }
    }
}
