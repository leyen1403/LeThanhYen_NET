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
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");

            InitializeComponent();
        }
        void Load_ComboBox()
        {
            //Khai bao DataSet
            DataSet ds = new DataSet();
            //Tao SqlDataAdapter
            string strselect = "select * from Khoa";
            SqlDataAdapter da = new SqlDataAdapter(strselect, conn);
            //cn la doi tuong SqlCOnnection da duoc khai bao
            //Do du lieu tu SqlDataAdapter vao DataSet
            da.Fill(ds, "Khoa");
            //gan du lieu nguon cho ComboBox
            cboKhoa.DataSource = ds.Tables[0];
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }
        bool KT_MaKhoa(string ma)
        {
            try
            {
                //mo ket noi
                conn.Open();
                //xay dung chuoi ket noi
                string selectString = "select count(*) from Lop where MaLop = '" + ma + "'";
                //Khai bao command voi chuoi truy van va bien ket noi
                SqlCommand cmd = new SqlCommand(selectString, conn);
                int count = (int)cmd.ExecuteScalar();
                //Dong ket noi
                conn.Close();
                //Xu ly truy van
                if (count > 1)
                {
                    return false;
                }
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
                //kiem tra khoa chinh
                if (KT_MaKhoa(txtMaLop.Text) == true)
                {
                    //mo ket noi
                    conn.Open();
                    //xay dung chuoi truy van
                    string insertString =
                        "insert into Lop values('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "', '"+cboKhoa.SelectedValue.ToString()+"')";
                    //khai bao command voi chuoi truy van va bien ket noi
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    //thuc thi cau truy van
                    cmd.ExecuteNonQuery();
                    //dong ket noi
                    conn.Close();
                    MessageBox.Show("Thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That Bai");
            }
            cleartext();
            Load_DgvLophoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
            Load_DgvLophoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string deleteString =
                    "delete from Lop where MaLop = '"+txtMaLop.Text+"'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That Bai");
            }
            cleartext();
            Load_DgvLophoc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (KT_MaKhoa(txtMaLop.Text) == false)
                {
                    conn.Open();
                    string EditString = "update Lop set MaKhoa = '" + cboKhoa.SelectedValue.ToString() +"', TenLop = N'" + txtTenLop.Text + "' where MaLop = '" + txtMaLop.Text + "'";
                    SqlCommand cmd = new SqlCommand(EditString, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thanh Cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
            cleartext();
            Load_DgvLophoc();
        }
        void Load_DgvLophoc()
        {
            //Khai bao dataset
            DataSet ds = new DataSet();
            //Tao sqlDataAdapter
            string sqlDataAdapter = 
                "select MaLop, TenLop, Khoa.MaKhoa, TenKhoa from Khoa, Lop where Lop.MaKhoa = Khoa.MaKhoa";
            SqlDataAdapter da = new SqlDataAdapter(sqlDataAdapter, conn);
            //do du lieu tu DataAdapter vao DataSet
            da.Fill(ds, "Lop_Khoa");
            //Gan du lieu nguon cho DataGridView
            dgvLop_Khoa.DataSource = ds.Tables["Lop_Khoa"];
        }
        void cleartext()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaLop.Focus();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Khai bao dataset
            DataSet ds = new DataSet();
            //Tao sqlDataAdapter
            string sqlDataAdapter =
                "select MaLop, TenLop, Khoa.MaKhoa, TenKhoa from Khoa, Lop where Lop.MaKhoa = Khoa.MaKhoa and Lop.MaKhoa = '"+cboKhoa.SelectedValue.ToString()+"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlDataAdapter, conn);
            da.Fill(ds, "Lop_Khoa");
            dgvLop_Khoa.DataSource = ds.Tables["Lop_Khoa"];
        }

    }
}
