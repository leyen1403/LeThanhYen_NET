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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btngiai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn2);
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Location = new System.Drawing.Point(46, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(3, 39);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(123, 17);
            this.rbtn2.TabIndex = 2;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Phương trình bậc hai";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(3, 16);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(130, 17);
            this.rbtn1.TabIndex = 0;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Phương trình bậc nhất";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(91, 120);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 6;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(91, 152);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 7;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(91, 182);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 8;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(91, 216);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(194, 59);
            this.txtkq.TabIndex = 9;
            // 
            // btngiai
            // 
            this.btngiai.Location = new System.Drawing.Point(210, 120);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(75, 37);
            this.btngiai.TabIndex = 10;
            this.btngiai.Text = "Giải";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(210, 165);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 37);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btnthoat;
    }
}

