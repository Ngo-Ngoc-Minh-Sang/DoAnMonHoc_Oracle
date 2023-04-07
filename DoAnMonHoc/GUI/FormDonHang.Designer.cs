namespace DoAnMonHoc.GUI
{
    partial class FormDonHang
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxTenNV = new System.Windows.Forms.ComboBox();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.cbxTenDV = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpNgayDatHang = new System.Windows.Forms.DateTimePicker();
            this.btnHuyDH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDTNguoiGui = new System.Windows.Forms.TextBox();
            this.txtGiaDonHang = new System.Windows.Forms.TextBox();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.txtSDTNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtDiaChiGiao = new System.Windows.Forms.TextBox();
            this.txtTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 162;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTenNV
            // 
            this.cbxTenNV.FormattingEnabled = true;
            this.cbxTenNV.Location = new System.Drawing.Point(144, 167);
            this.cbxTenNV.Name = "cbxTenNV";
            this.cbxTenNV.Size = new System.Drawing.Size(210, 24);
            this.cbxTenNV.TabIndex = 161;
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(144, 115);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(210, 24);
            this.cbxTenKH.TabIndex = 160;
            this.cbxTenKH.SelectedIndexChanged += new System.EventHandler(this.cbxTenKH_SelectedIndexChanged);
            // 
            // cbxTenDV
            // 
            this.cbxTenDV.FormattingEnabled = true;
            this.cbxTenDV.Location = new System.Drawing.Point(144, 68);
            this.cbxTenDV.Name = "cbxTenDV";
            this.cbxTenDV.Size = new System.Drawing.Size(210, 24);
            this.cbxTenDV.TabIndex = 159;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 334);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1487, 350);
            this.dataGridView1.TabIndex = 158;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Enabled = false;
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Location = new System.Drawing.Point(533, 278);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(196, 24);
            this.cbxTrangThai.TabIndex = 157;
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatHang.Location = new System.Drawing.Point(534, 17);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(195, 22);
            this.dtpNgayDatHang.TabIndex = 156;
            this.dtpNgayDatHang.Leave += new System.EventHandler(this.dtpNgayDatHang_Leave);
            // 
            // btnHuyDH
            // 
            this.btnHuyDH.Location = new System.Drawing.Point(975, 131);
            this.btnHuyDH.Name = "btnHuyDH";
            this.btnHuyDH.Size = new System.Drawing.Size(108, 53);
            this.btnHuyDH.TabIndex = 155;
            this.btnHuyDH.Text = "Hủy ĐH";
            this.btnHuyDH.UseVisualStyleBackColor = true;
            this.btnHuyDH.Click += new System.EventHandler(this.btnHuyDH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1156, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 53);
            this.btnThoat.TabIndex = 154;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(975, 242);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 53);
            this.btnCapNhat.TabIndex = 153;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(809, 242);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 53);
            this.btnSua.TabIndex = 152;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(809, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 53);
            this.btnXoa.TabIndex = 151;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(975, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 53);
            this.btnThem.TabIndex = 150;
            this.btnThem.Text = "Thêm ĐH";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDTNguoiGui
            // 
            this.txtSDTNguoiGui.Enabled = false;
            this.txtSDTNguoiGui.Location = new System.Drawing.Point(534, 219);
            this.txtSDTNguoiGui.Name = "txtSDTNguoiGui";
            this.txtSDTNguoiGui.Size = new System.Drawing.Size(195, 22);
            this.txtSDTNguoiGui.TabIndex = 149;
            // 
            // txtGiaDonHang
            // 
            this.txtGiaDonHang.Enabled = false;
            this.txtGiaDonHang.Location = new System.Drawing.Point(144, 268);
            this.txtGiaDonHang.Name = "txtGiaDonHang";
            this.txtGiaDonHang.Size = new System.Drawing.Size(210, 22);
            this.txtGiaDonHang.TabIndex = 148;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(534, 170);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(195, 22);
            this.txtTrongLuong.TabIndex = 147;
            this.txtTrongLuong.Leave += new System.EventHandler(this.txtTrongLuong_Leave);
            // 
            // txtSDTNguoiNhan
            // 
            this.txtSDTNguoiNhan.Location = new System.Drawing.Point(534, 119);
            this.txtSDTNguoiNhan.Name = "txtSDTNguoiNhan";
            this.txtSDTNguoiNhan.Size = new System.Drawing.Size(195, 22);
            this.txtSDTNguoiNhan.TabIndex = 146;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(144, 15);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(210, 22);
            this.txtMaDH.TabIndex = 145;
            // 
            // txtDiaChiGiao
            // 
            this.txtDiaChiGiao.Location = new System.Drawing.Point(534, 68);
            this.txtDiaChiGiao.Name = "txtDiaChiGiao";
            this.txtDiaChiGiao.Size = new System.Drawing.Size(195, 22);
            this.txtDiaChiGiao.TabIndex = 144;
            // 
            // txtTenNguoiNhan
            // 
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(144, 219);
            this.txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            this.txtTenNguoiNhan.Size = new System.Drawing.Size(210, 22);
            this.txtTenNguoiNhan.TabIndex = 143;
            this.txtTenNguoiNhan.Leave += new System.EventHandler(this.txtTenNguoiNhan_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(406, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 141;
            this.label11.Text = "Trạng thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(406, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 140;
            this.label12.Text = "SĐT người gửi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 139;
            this.label10.Text = "Giá đơn hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 138;
            this.label9.Text = "Trọng lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 137;
            this.label8.Text = "SĐT người nhận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 135;
            this.label7.Text = "Địa chỉ giao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 134;
            this.label6.Text = "Ngày tạo đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 133;
            this.label5.Text = "Tên người nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 142;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 131;
            this.label2.Text = "Tên dịch vụ";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(12, 305);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(99, 23);
            this.btnRefesh.TabIndex = 163;
            this.btnRefesh.Text = "REFESH";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 747);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTenNV);
            this.Controls.Add(this.cbxTenKH);
            this.Controls.Add(this.cbxTenDV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxTrangThai);
            this.Controls.Add(this.dtpNgayDatHang);
            this.Controls.Add(this.btnHuyDH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDTNguoiGui);
            this.Controls.Add(this.txtGiaDonHang);
            this.Controls.Add(this.txtTrongLuong);
            this.Controls.Add(this.txtSDTNguoiNhan);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.txtDiaChiGiao);
            this.Controls.Add(this.txtTenNguoiNhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxTenNV;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.ComboBox cbxTenDV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayDatHang;
        private System.Windows.Forms.Button btnHuyDH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDTNguoiGui;
        private System.Windows.Forms.TextBox txtGiaDonHang;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.TextBox txtSDTNguoiNhan;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtDiaChiGiao;
        private System.Windows.Forms.TextBox txtTenNguoiNhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefesh;
    }
}