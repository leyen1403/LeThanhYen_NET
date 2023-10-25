using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }
        int n = 0, i, tam;
        int[] a = new int[100];
        string s, s1;
        public static int TongMang(int[] a, int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s = s + a[i];
            }
                return s;
        }
        public static int TongChan(int[] a, int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    s = s + a[i];
                }
            }
            return s;
        }
        public static int TongLe(int[] a, int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    s = s + a[i];
                }
            }
            return s;
        }
        public static int TimGiaTri(int[] a, int n, int s)
        {
            for(int i = 0; i< a.Length; i++)
            {
                if (a[i] == s)
                    return s;
            }
            return -99;
        }
        public static int TimViTri(int[] a, int n, int s)
        {
            return a[s];
        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rTimGiaTri_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rTimGiaTri_Click(object sender, EventArgs e)
        {
            string inputText = txtTimGiaTri.Text;
            int number = Convert.ToInt32(inputText);
            int kq = TimGiaTri(a, n, number);
            if (kq != -99)
            {
                txtKqTim.Text = kq.ToString();
            }
            else
            {
                txtKqTim.Text = "null";
            }
        }

        private void rTimViTri_Click(object sender, EventArgs e)
        {
            string inputText = txtTimViTri.Text;
            int number = Convert.ToInt32(inputText);
            int kq = TimViTri(a, n, number);
            if (kq != -99)
            {
                txtKqTim.Text = kq.ToString();
            }
            else
            {
                txtKqTim.Text = "null";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtnhap.Clear();
            txtkq.Clear();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            txtTongMang.Text = TongMang(a, n).ToString();
            txtTongChan.Text = TongChan(a, n).ToString();
            txtTongLe.Text = TongLe(a, n).ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //lấy giá trị từ hộp text box
            string inputText = txtnhap.Text;

            // Tách chuỗi thành các chuỗi con bằng dấu cách và loại bỏ các khoảng trắng thừa
            string[] numberStrings = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Khởi tạo mảng số kiểu int
            a = new int[numberStrings.Length];
            n = numberStrings.Length;

            // Chuyển đổi từng chuỗi con thành số kiểu int
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int number))
                {
                    a[i] = number;
                }
                else
                {
                    MessageBox.Show("Không thể chuyển đổi chuỗi thành số nguyên: " + numberStrings[i]);
                    return; // Thoát khỏi xử lý nếu có lỗi
                }
            }

            // Hiển thị mảng số kiểu int 
            string result = string.Join(" ", a);
            txtkq.Text = result;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rSapxeptang.Checked)
            {
                for(int i=0;i<n-1;i++)
                {
                    for (int j = i+1; j < n; j++)
                    {
                        if(a[i] > a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;
                        }
                    }
                }
                string result = string.Join(" ", a);
                txtkq.Text = result;
            }
            if (rSapXepGiam.Checked)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i+1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;
                        }
                    }
                }
                string result = string.Join(" ", a);
                txtkq.Text = result;
            }
            if (rTimGiaTri.Checked)
            {
                int x = Convert.ToInt32(txtTimGiaTri.Text);
                
            }
        }

    }
}
