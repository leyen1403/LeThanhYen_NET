using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Double a, b, c, data, x1, x2;

        private void btnthoat_Click(object sender, EventArgs e, FormClosingEventArgs a)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtkq.Clear();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                if (a == 0)
                    if (b == 0)
                        txtkq.Text = "Phương trình có vô số nghiệm";
                    else txtkq.Text = "Phương trình vô nghiệm";
                else
                    txtkq.Text = "Phương trình có nghiệm :" + ((-b) / a).ToString();
            }
            if(rbtn2.Checked)
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                if(a==0)
                {
                    if (b == 0)
                    {
                        if(c==0)
                        {
                            txtkq.Text = "Phương trình có vô số nghiệm";
                        }
                        else txtkq.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        txtkq.Text = "Phương trình có nghiệm " + ((-c) / b).ToString();
                    }
                }
                else
                {
                    data = ((b * b) - (4 * a * c));
                    if(data < 0)
                    {
                        txtkq.Text = "Phương trình vô nghiệm";
                    }
                    if(data == 0)
                    {
                        txtkq.Text = "Phương trình có nghiệm kép: " + ((-b) / (2 * a)).ToString();
                    }
                    if(data>0)
                    {
                        x1 = ((-b + Math.Sqrt((data))) / (2 * a));
                        x2 = ((-b - Math.Sqrt((data)) / (2 * a)));
                        txtkq.Text = "Phương trình có 2 nghiệm phân biệt: " + "x1 = " + String.Format("{0:0.00}", x1) + "; x2 = " + String.Format("{0:0.00}", x2);
                    }
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = false;
            this.txta.ResetText();
            this.txtb.ResetText();
            this.txtc.ResetText();
            this.txtkq.ResetText();
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = true;
            this.txta.ResetText();
            this.txtb.ResetText();
            this.txtc.ResetText();
            this.txtkq.ResetText();
        }

    }
}
