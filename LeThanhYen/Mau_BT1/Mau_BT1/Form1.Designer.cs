namespace Mau_BT1
{
    partial class frmListBox
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
            this.lst_trai = new System.Windows.Forms.ListBox();
            this.lst_phai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuaPhaiAll = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_trai
            // 
            this.lst_trai.FormattingEnabled = true;
            this.lst_trai.ItemHeight = 18;
            this.lst_trai.Location = new System.Drawing.Point(127, 134);
            this.lst_trai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_trai.Name = "lst_trai";
            this.lst_trai.Size = new System.Drawing.Size(240, 454);
            this.lst_trai.TabIndex = 0;
            // 
            // lst_phai
            // 
            this.lst_phai.FormattingEnabled = true;
            this.lst_phai.ItemHeight = 18;
            this.lst_phai.Location = new System.Drawing.Point(660, 134);
            this.lst_phai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_phai.Name = "lst_phai";
            this.lst_phai.Size = new System.Drawing.Size(240, 454);
            this.lst_phai.TabIndex = 0;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(448, 134);
            this.btnQuaPhai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(100, 86);
            this.btnQuaPhai.TabIndex = 1;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnQuaPhaiAll
            // 
            this.btnQuaPhaiAll.Location = new System.Drawing.Point(448, 260);
            this.btnQuaPhaiAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            this.btnQuaPhaiAll.Size = new System.Drawing.Size(100, 86);
            this.btnQuaPhaiAll.TabIndex = 1;
            this.btnQuaPhaiAll.Text = ">>";
            this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
            this.btnQuaPhaiAll.Click += new System.EventHandler(this.btnQuaPhaiAll_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(448, 392);
            this.btnQuaTrai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(100, 86);
            this.btnQuaTrai.TabIndex = 1;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaTraiAll
            // 
            this.btnQuaTraiAll.Location = new System.Drawing.Point(448, 504);
            this.btnQuaTraiAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuaTraiAll.Name = "btnQuaTraiAll";
            this.btnQuaTraiAll.Size = new System.Drawing.Size(100, 86);
            this.btnQuaTraiAll.TabIndex = 1;
            this.btnQuaTraiAll.Text = "<<";
            this.btnQuaTraiAll.UseVisualStyleBackColor = true;
            this.btnQuaTraiAll.Click += new System.EventHandler(this.btnQuaTraiAll_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 763);
            this.Controls.Add(this.btnQuaTraiAll);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaPhaiAll);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.lst_phai);
            this.Controls.Add(this.lst_trai);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListBox";
            this.Text = "Sử dụng ListBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListBox_FormClosing);
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_trai;
        private System.Windows.Forms.ListBox lst_phai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuaPhaiAll;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiAll;

    }
}

