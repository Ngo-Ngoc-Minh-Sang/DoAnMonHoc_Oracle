﻿namespace DoAnMonHoc.GUI
{
    partial class frmDichVu
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
            this.label4 = new System.Windows.Forms.Label();
            this.textMaDV = new System.Windows.Forms.TextBox();
            this.textTenDV = new System.Windows.Forms.TextBox();
            this.textGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView_DV = new System.Windows.Forms.DataGridView();
            this.Sửa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(41, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // textMaDV
            // 
            this.textMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaDV.Location = new System.Drawing.Point(223, 107);
            this.textMaDV.Name = "textMaDV";
            this.textMaDV.Size = new System.Drawing.Size(317, 32);
            this.textMaDV.TabIndex = 4;
            // 
            // textTenDV
            // 
            this.textTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDV.Location = new System.Drawing.Point(223, 171);
            this.textTenDV.Name = "textTenDV";
            this.textTenDV.Size = new System.Drawing.Size(317, 32);
            this.textTenDV.TabIndex = 5;
            // 
            // textGia
            // 
            this.textGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGia.Location = new System.Drawing.Point(223, 227);
            this.textGia.Name = "textGia";
            this.textGia.Size = new System.Drawing.Size(317, 32);
            this.textGia.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(47, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 52);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(277, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(713, 311);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView_DV
            // 
            this.dataGridView_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DV.Location = new System.Drawing.Point(46, 404);
            this.dataGridView_DV.Name = "dataGridView_DV";
            this.dataGridView_DV.RowHeadersWidth = 51;
            this.dataGridView_DV.RowTemplate.Height = 24;
            this.dataGridView_DV.Size = new System.Drawing.Size(862, 149);
            this.dataGridView_DV.TabIndex = 12;
            this.dataGridView_DV.SelectionChanged += new System.EventHandler(this.dataGridView_DV_SelectionChanged);
            // 
            // Sửa
            // 
            this.Sửa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Sửa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sửa.ForeColor = System.Drawing.Color.Red;
            this.Sửa.Location = new System.Drawing.Point(504, 311);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(111, 52);
            this.Sửa.TabIndex = 10;
            this.Sửa.Text = "Sửa";
            this.Sửa.UseVisualStyleBackColor = false;
            this.Sửa.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimKiem.Location = new System.Drawing.Point(699, 200);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 52);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // textTimKiem
            // 
            this.textTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimKiem.Location = new System.Drawing.Point(602, 152);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(317, 32);
            this.textTimKiem.TabIndex = 14;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(951, 606);
            this.Controls.Add(this.textTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView_DV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textGia);
            this.Controls.Add(this.textTenDV);
            this.Controls.Add(this.textMaDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaDV;
        private System.Windows.Forms.TextBox textTenDV;
        private System.Windows.Forms.TextBox textGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView_DV;
        private System.Windows.Forms.Button Sửa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textTimKiem;
    }
}