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
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS; Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        private void LoadKhoa_ComboBox()
        {
            conn.Open();
            string selectString = "select * from khoa";
            SqlCommand cmd = new SqlCommand(selectString, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["MaKhoa"].ToString());
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhoa_ComboBox();
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }
        public bool KT_KhoaChinh(string ma)
        {
            try
            {
                conn.Open();
                string selectString = "select count(*) from Lop where MaLop = '" + ma + "'";
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
                if (txtMaLop.Text.Trim().Length == 0 || txtTenLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                
                if (KT_KhoaChinh(txtMaLop.Text))
                {
                    conn.Open();
                    string insertString = "insert into Lop(MaLop, TenLop, MaKhoa) values ('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "','" + comboBox1.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thành công");
                    txtMaLop.Clear();
                    txtTenLop.Clear();
                    txtMaLop.Focus();
                }
                else
                {
                    MessageBox.Show("Trùng mã lớp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã lớp!");
                    return;
                }
                conn.Open();
                string updateString = "update Lop set TenLop = N'" + txtTenLop.Text + "', MaKhoa = '" + comboBox1.SelectedItem.ToString() + "' where MaLop='"+txtMaLop.Text+"'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã lớp!");
                    return;
                }
                conn.Open();
                string deleteString = "delete Lop where MaLop = '"+txtMaLop.Text+"'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
            }
            catch
            {
                MessageBox.Show("Thất bại!");
            }
        }

    }
}