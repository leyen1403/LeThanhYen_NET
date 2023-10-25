namespace Mau_BT3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoapb = new System.Windows.Forms.Button();
            this.btn_Thempb = new System.Windows.Forms.Button();
            this.txt_phongBan = new System.Windows.Forms.TextBox();
            this.tv_DS = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cb_PhongBan = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xoapb);
            this.groupBox1.Controls.Add(this.btn_Thempb);
            this.groupBox1.Controls.Add(this.txt_phongBan);
            this.groupBox1.Controls.Add(this.tv_DS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(295, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // btn_Xoapb
            // 
            this.btn_Xoapb.Location = new System.Drawing.Point(111, 426);
            this.btn_Xoapb.Name = "btn_Xoapb";
            this.btn_Xoapb.Size = new System.Drawing.Size(149, 44);
            this.btn_Xoapb.TabIndex = 3;
            this.btn_Xoapb.Text = "Xóa phòng ban";
            this.btn_Xoapb.UseVisualStyleBackColor = true;
            this.btn_Xoapb.Click += new System.EventHandler(this.btn_Xoapb_Click);
            // 
            // btn_Thempb
            // 
            this.btn_Thempb.Location = new System.Drawing.Point(111, 376);
            this.btn_Thempb.Name = "btn_Thempb";
            this.btn_Thempb.Size = new System.Drawing.Size(149, 44);
            this.btn_Thempb.TabIndex = 3;
            this.btn_Thempb.Text = "Thêm phòng ban";
            this.btn_Thempb.UseVisualStyleBackColor = true;
            this.btn_Thempb.Click += new System.EventHandler(this.btn_Thempb_Click);
            // 
            // txt_phongBan
            // 
            this.txt_phongBan.Location = new System.Drawing.Point(111, 344);
            this.txt_phongBan.Name = "txt_phongBan";
            this.txt_phongBan.Size = new System.Drawing.Size(149, 26);
            this.txt_phongBan.TabIndex = 2;
            // 
            // tv_DS
            // 
            this.tv_DS.Location = new System.Drawing.Point(30, 27);
            this.tv_DS.Name = "tv_DS";
            this.tv_DS.Size = new System.Drawing.Size(230, 302);
            this.tv_DS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(354, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số";
            // 
            // txt_maSo
            // 
            this.txt_maSo.Location = new System.Drawing.Point(451, 97);
            this.txt_maSo.Name = "txt_maSo";
            this.txt_maSo.Size = new System.Drawing.Size(149, 26);
            this.txt_maSo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(720, 97);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(149, 26);
            this.txt_HoTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(451, 153);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(419, 26);
            this.txt_DiaChi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phòng ban";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(450, 272);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(149, 44);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(646, 272);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(149, 44);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cb_PhongBan
            // 
            this.cb_PhongBan.FormattingEnabled = true;
            this.cb_PhongBan.Location = new System.Drawing.Point(451, 207);
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(418, 26);
            this.cb_PhongBan.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 626);
            this.Controls.Add(this.cb_PhongBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoapb;
        private System.Windows.Forms.Button btn_Thempb;
        private System.Windows.Forms.TextBox txt_phongBan;
        private System.Windows.Forms.TreeView tv_DS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cb_PhongBan;
    }
}

