namespace BT1_Mau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.cong = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.chia = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(104, 60);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(312, 60);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(104, 117);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(308, 20);
            this.txtkq.TabIndex = 5;
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Location = new System.Drawing.Point(98, 167);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(31, 17);
            this.cong.TabIndex = 6;
            this.cong.TabStop = true;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Location = new System.Drawing.Point(196, 167);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(28, 17);
            this.tru.TabIndex = 7;
            this.tru.TabStop = true;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Location = new System.Drawing.Point(290, 167);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(29, 17);
            this.nhan.TabIndex = 8;
            this.nhan.TabStop = true;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Location = new System.Drawing.Point(382, 167);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(30, 17);
            this.chia.TabIndex = 9;
            this.chia.TabStop = true;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

