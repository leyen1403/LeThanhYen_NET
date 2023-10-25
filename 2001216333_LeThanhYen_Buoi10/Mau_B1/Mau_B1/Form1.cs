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

namespace Mau_B1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter sqlDataAdapter;
        public Form1()
        {
            InitializeComponent();
        }
        public void load_Khoa()
        {
            string select = "select * from Khoa";
            sqlDataAdapter = new SqlDataAdapter(select, conn);
            sqlDataAdapter.Fill(ds, "Khoa");
            dgv_Khoa.DataSource = ds.Tables["Khoa"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Khoa"].Columns[0];
            ds.Tables["Khoa"].PrimaryKey = key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_Khoa();
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = true;
            btnLuu.Enabled = true;
            txtMaKhoa.Focus();
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }

        private void dgv_Khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Khoa_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKhoa.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã khoa");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên khoa");
                txtTenKhoa.Focus();
                return;
            }
            if(txtMaKhoa.Enabled == true)//thêm
            {
                DataRow insert_new = ds.Tables["Khoa"].NewRow();
                insert_new["MaKhoa"] = txtMaKhoa.Text;
                insert_new["TenKhoa"] = txtTenKhoa.Text;
                ds.Tables["Khoa"].Rows.Add(insert_new);
            }
            else//sửa
            {
                
                DataRow update_new = ds.Tables["Khoa"].Rows.Find(txtMaKhoa.Text);
                if(update_new != null)
                {
                    update_new["TenKhoa"] = txtTenKhoa.Text;
                }
            }
            SqlCommandBuilder cmd = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(ds, "Khoa");
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muôn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)== System.Windows.Forms.DialogResult.Yes)
            {
                DataTable dt_Lop = new DataTable();
                string select = "select * from Lop where makhoa = '"+txtMaKhoa.Text+"'";
                SqlDataAdapter da_Lop = new SqlDataAdapter(select, conn);
                da_Lop.Fill(dt_Lop);
                if(dt_Lop.Rows.Count > 0 )
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    return;
                }
                DataRow upd_new = ds.Tables["Khoa"].Rows.Find(txtMaKhoa.Text);
                if(upd_new != null)
                {
                    upd_new.Delete();
                }
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(ds, "Khoa");
                MessageBox.Show("Thành công");
            }
        }
    }
}
