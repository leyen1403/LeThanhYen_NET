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
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_DgvKhoa();
        }
        void Load_DgvKhoa()
        {
            //Khai bao dataset
            DataSet ds = new DataSet();
            //Tao sqlDataAdapter
            string sqlDataAdapter =
                "select MaKhoa 'Mã khoa', TenKhoa 'Tên khoa' from Khoa";
            SqlDataAdapter da = new SqlDataAdapter(sqlDataAdapter, conn);
            //do du lieu tu DataAdapter vao DataSet
            da.Fill(ds, "Table");
            //Gan du lieu nguon cho DataGridView
            dgvKhoa.DataSource = ds.Tables["Table"];
        }
        bool KT_KhoaChinh(string ma)
        {
            try
            {
                string selectString = "select count(*) from khoa where MaKhoa = '" + ma + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectString, conn);
                cmd.ExecuteScalar();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                if (count > 1)
                {
                    return false;
                }
                return true;
            }catch { return false;}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length <= 0 || txtTenKhoa.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                    return; 
                }
                if(KT_KhoaChinh(txtMaKhoa.Text))
                {
                    conn.Open();
                    string insertString = "insert into Khoa values ('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thanh Cong");
                }
            }catch (Exception ex)
            {
                if(conn.State == ConnectionState.Open)
                { conn.Close(); }
                MessageBox.Show("Thất bại");
            }
            Load_DgvKhoa();
            clearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length <=0)
                {
                    MessageBox.Show("Vui lòng nhập mã khoa");
                    return;
                }    
                conn.Open();
                string deleteString = "delete from Khoa where MaKhoa='" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công");
            }
            catch
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thất bại");
            }
            Load_DgvKhoa();
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập vào mã khoa");
                    return;
                }
                conn.Open();
                string editString = "update Khoa set TenKhoa = '"+txtTenKhoa.Text+"' where MaKhoa = '"+txtMaKhoa.Text+"'";
                SqlCommand cmd = new SqlCommand(editString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công");
            }
            catch
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Thất bại");
            }
            Load_DgvKhoa();
            clearText();
        }
        void clearText()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Focus();
        }
    }
}
