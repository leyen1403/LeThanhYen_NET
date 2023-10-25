namespace BT1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CN = new System.Windows.Forms.Button();
            this.btn_Tong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_UocChan = new System.Windows.Forms.Button();
            this.btn_SNT = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_CN);
            this.groupBox1.Location = new System.Drawing.Point(26, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_CN
            // 
            this.btn_CN.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_CN.Location = new System.Drawing.Point(164, 19);
            this.btn_CN.Name = "btn_CN";
            this.btn_CN.Size = new System.Drawing.Size(65, 39);
            this.btn_CN.TabIndex = 1;
            this.btn_CN.Text = "Cập nhật";
            this.btn_CN.UseVisualStyleBackColor = true;
            this.btn_CN.Click += new System.EventHandler(this.btn_CN_Click);
            // 
            // btn_Tong
            // 
            this.btn_Tong.Location = new System.Drawing.Point(380, 242);
            this.btn_Tong.Name = "btn_Tong";
            this.btn_Tong.Size = new System.Drawing.Size(245, 39);
            this.btn_Tong.TabIndex = 1;
            this.btn_Tong.Text = "Tổng các ước số";
            this.btn_Tong.UseVisualStyleBackColor = true;
            this.btn_Tong.Click += new System.EventHandler(this.btn_Tong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(380, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 121);
            this.listBox1.TabIndex = 0;
            // 
            // btn_UocChan
            // 
            this.btn_UocChan.Location = new System.Drawing.Point(380, 287);
            this.btn_UocChan.Name = "btn_UocChan";
            this.btn_UocChan.Size = new System.Drawing.Size(245, 39);
            this.btn_UocChan.TabIndex = 1;
            this.btn_UocChan.Text = "Số lượng các ước số chẳn";
            this.btn_UocChan.UseVisualStyleBackColor = true;
            this.btn_UocChan.Click += new System.EventHandler(this.btn_UocChan_Click);
            // 
            // btn_SNT
            // 
            this.btn_SNT.Location = new System.Drawing.Point(380, 332);
            this.btn_SNT.Name = "btn_SNT";
            this.btn_SNT.Size = new System.Drawing.Size(245, 39);
            this.btn_SNT.TabIndex = 1;
            this.btn_SNT.Text = "Số lượng các ước số nguyên tố";
            this.btn_SNT.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(245, 332);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(95, 39);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SNT);
            this.Controls.Add(this.btn_UocChan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Tong);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Tong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_CN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_UocChan;
        private System.Windows.Forms.Button btn_SNT;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

