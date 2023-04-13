namespace DoAnMonHoc.GUI
{
    partial class frmDoiMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMKCu = new System.Windows.Forms.TextBox();
            this.textMKMoi = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textTenDN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // textMKCu
            // 
            this.textMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMKCu.Location = new System.Drawing.Point(265, 154);
            this.textMKCu.Name = "textMKCu";
            this.textMKCu.Size = new System.Drawing.Size(248, 32);
            this.textMKCu.TabIndex = 3;
            // 
            // textMKMoi
            // 
            this.textMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMKMoi.Location = new System.Drawing.Point(753, 157);
            this.textMKMoi.Name = "textMKMoi";
            this.textMKMoi.Size = new System.Drawing.Size(248, 32);
            this.textMKMoi.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(211, 337);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(131, 67);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(523, 337);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 67);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên đăng nhập";
            // 
            // textTenDN
            // 
            this.textTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDN.Location = new System.Drawing.Point(487, 239);
            this.textTenDN.Name = "textTenDN";
            this.textTenDN.Size = new System.Drawing.Size(248, 32);
            this.textTenDN.TabIndex = 9;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 531);
            this.Controls.Add(this.textTenDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.textMKMoi);
            this.Controls.Add(this.textMKCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMKCu;
        private System.Windows.Forms.TextBox textMKMoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTenDN;
    }
}