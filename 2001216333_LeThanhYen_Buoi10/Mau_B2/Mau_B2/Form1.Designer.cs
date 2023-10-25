namespace Mau_B2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnThoat = new Button();
            btnXemIn = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            cb_Lop = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            panel9 = new Panel();
            txtHoTen = new TextBox();
            label4 = new Label();
            panel10 = new Panel();
            txtMaSV = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            btnSearch = new Button();
            panel4 = new Panel();
            cb_Khoa = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            dgv_SinhVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SinhVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXemIn);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 45);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.icons8_remove_301;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(408, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 36);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXemIn
            // 
            btnXemIn.Image = Properties.Resources.icons8_print_30;
            btnXemIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemIn.Location = new Point(327, 3);
            btnXemIn.Name = "btnXemIn";
            btnXemIn.Size = new Size(80, 36);
            btnXemIn.TabIndex = 4;
            btnXemIn.Text = "Xem In";
            btnXemIn.TextAlign = ContentAlignment.MiddleRight;
            btnXemIn.UseVisualStyleBackColor = true;
            btnXemIn.Click += btnXemIn_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.icons8_save_30;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(246, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 36);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(165, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 36);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_remove_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(84, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 36);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 36);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 186);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(cb_Lop);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(501, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 71);
            panel5.TabIndex = 5;
            // 
            // cb_Lop
            // 
            cb_Lop.FormattingEnabled = true;
            cb_Lop.Location = new Point(43, 8);
            cb_Lop.Name = "cb_Lop";
            cb_Lop.Size = new Size(196, 23);
            cb_Lop.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Lớp";
            // 
            // panel7
            // 
            panel7.Controls.Add(maskedTextBox1);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(751, 102);
            panel7.Name = "panel7";
            panel7.Size = new Size(242, 71);
            panel7.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(69, 3);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(170, 23);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtHoTen);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(255, 102);
            panel9.Name = "panel9";
            panel9.Size = new Size(488, 71);
            panel9.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(102, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(383, 23);
            txtHoTen.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 0;
            label4.Text = "Họ tên sinh viên";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtMaSV);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(7, 102);
            panel10.Name = "panel10";
            panel10.Size = new Size(242, 71);
            panel10.TabIndex = 7;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(84, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(155, 23);
            txtMaSV.TabIndex = 0;
            txtMaSV.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã sinh viên";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(btnSearch);
            panel6.Location = new Point(749, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 71);
            panel6.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.icons8_find_40;
            btnSearch.Location = new Point(13, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 65);
            btnSearch.TabIndex = 0;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cb_Khoa);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(253, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 71);
            panel4.TabIndex = 4;
            // 
            // cb_Khoa
            // 
            cb_Khoa.FormattingEnabled = true;
            cb_Khoa.Location = new Point(43, 8);
            cb_Khoa.Name = "cb_Khoa";
            cb_Khoa.Size = new Size(196, 23);
            cb_Khoa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Khoa";
            // 
            // panel3
            // 
            panel3.Location = new Point(5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 71);
            panel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgv_SinhVien);
            panel8.Location = new Point(12, 272);
            panel8.Name = "panel8";
            panel8.Size = new Size(1000, 281);
            panel8.TabIndex = 10;
            // 
            // dgv_SinhVien
            // 
            dgv_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SinhVien.Location = new Point(3, 3);
            dgv_SinhVien.Name = "dgv_SinhVien";
            dgv_SinhVien.RowTemplate.Height = 25;
            dgv_SinhVien.Size = new Size(994, 275);
            dgv_SinhVien.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 573);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Danh sách sinh viên";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXemIn;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel2;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private ComboBox cb_Lop;
        private Label label2;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private ComboBox cb_Khoa;
        private Label label1;
        private Button btnSearch;
        private TextBox txtMaSV;
        private Label label3;
        private TextBox txtHoTen;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Panel panel8;
        private DataGridView dgv_SinhVien;
    }
}