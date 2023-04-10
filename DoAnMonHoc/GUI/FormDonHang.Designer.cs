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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonHang));
            this.label13 = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.txtMaDH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(685, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 39);
            this.label13.TabIndex = 198;
            this.label13.Text = "Đơn Hàng";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefesh
            // 
            this.btnRefesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefesh.ImageKey = "Reload-Icon-SVG-03kmldg.png";
            this.btnRefesh.ImageList = this.imageList1;
            this.btnRefesh.Location = new System.Drawing.Point(34, 383);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(105, 42);
            this.btnRefesh.TabIndex = 197;
            this.btnRefesh.Text = "REFESH";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Instagram-Add-Icon-09i3c.png");
            this.imageList1.Images.SetKeyName(1, "bookmark-Icon-SVG-56789.png");
            this.imageList1.Images.SetKeyName(2, "Delete-Icon_SVG_o3nfkdfed.png");
            this.imageList1.Images.SetKeyName(3, "Edit-Icon-94rtghj.png");
            this.imageList1.Images.SetKeyName(4, "Exit-Icon-SVG-0987678.png");
            this.imageList1.Images.SetKeyName(5, "Shopping-Bag-93dscwd.png");
            this.imageList1.Images.SetKeyName(6, "Cloud-upload-Icon-SVG-okjdfdf.png");
            this.imageList1.Images.SetKeyName(7, "Remove-Shopping-Bag-93dscwd.png");
            this.imageList1.Images.SetKeyName(8, "Reload-Icon-SVG-03kmldg.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(823, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 60);
            this.button1.TabIndex = 196;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbxTenNV
            // 
            this.cbxTenNV.FormattingEnabled = true;
            this.cbxTenNV.Location = new System.Drawing.Point(158, 245);
            this.cbxTenNV.Name = "cbxTenNV";
            this.cbxTenNV.Size = new System.Drawing.Size(210, 24);
            this.cbxTenNV.TabIndex = 195;
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(158, 193);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(210, 24);
            this.cbxTenKH.TabIndex = 194;
            // 
            // cbxTenDV
            // 
            this.cbxTenDV.FormattingEnabled = true;
            this.cbxTenDV.Location = new System.Drawing.Point(158, 146);
            this.cbxTenDV.Name = "cbxTenDV";
            this.cbxTenDV.Size = new System.Drawing.Size(210, 24);
            this.cbxTenDV.TabIndex = 193;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 431);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1487, 260);
            this.dataGridView1.TabIndex = 192;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Enabled = false;
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Location = new System.Drawing.Point(547, 356);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(196, 24);
            this.cbxTrangThai.TabIndex = 191;
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatHang.Location = new System.Drawing.Point(548, 95);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(195, 22);
            this.dtpNgayDatHang.TabIndex = 190;
            // 
            // btnHuyDH
            // 
            this.btnHuyDH.BackColor = System.Drawing.Color.Ivory;
            this.btnHuyDH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyDH.ImageIndex = 7;
            this.btnHuyDH.ImageList = this.imageList1;
            this.btnHuyDH.Location = new System.Drawing.Point(975, 202);
            this.btnHuyDH.Name = "btnHuyDH";
            this.btnHuyDH.Size = new System.Drawing.Size(97, 60);
            this.btnHuyDH.TabIndex = 189;
            this.btnHuyDH.Text = "Hủy ĐH";
            this.btnHuyDH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyDH.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.ImageKey = "Exit-Icon-SVG-0987678.png";
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(1420, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 60);
            this.btnThoat.TabIndex = 188;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Ivory;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapNhat.ImageIndex = 6;
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(975, 297);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 60);
            this.btnCapNhat.TabIndex = 187;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Ivory;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.ImageIndex = 3;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(823, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 60);
            this.btnSua.TabIndex = 186;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Ivory;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.ImageIndex = 2;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(823, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 60);
            this.btnXoa.TabIndex = 185;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Ivory;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageIndex = 5;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(975, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 60);
            this.btnThem.TabIndex = 184;
            this.btnThem.Text = "Thêm ĐH";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtSDTNguoiGui
            // 
            this.txtSDTNguoiGui.Enabled = false;
            this.txtSDTNguoiGui.Location = new System.Drawing.Point(548, 297);
            this.txtSDTNguoiGui.Name = "txtSDTNguoiGui";
            this.txtSDTNguoiGui.Size = new System.Drawing.Size(195, 22);
            this.txtSDTNguoiGui.TabIndex = 183;
            // 
            // txtGiaDonHang
            // 
            this.txtGiaDonHang.Enabled = false;
            this.txtGiaDonHang.Location = new System.Drawing.Point(158, 346);
            this.txtGiaDonHang.Name = "txtGiaDonHang";
            this.txtGiaDonHang.Size = new System.Drawing.Size(210, 22);
            this.txtGiaDonHang.TabIndex = 182;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(548, 248);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(195, 22);
            this.txtTrongLuong.TabIndex = 181;
            // 
            // txtSDTNguoiNhan
            // 
            this.txtSDTNguoiNhan.Location = new System.Drawing.Point(548, 197);
            this.txtSDTNguoiNhan.Name = "txtSDTNguoiNhan";
            this.txtSDTNguoiNhan.Size = new System.Drawing.Size(195, 22);
            this.txtSDTNguoiNhan.TabIndex = 180;
            // 
            // txtDiaChiGiao
            // 
            this.txtDiaChiGiao.Location = new System.Drawing.Point(548, 146);
            this.txtDiaChiGiao.Name = "txtDiaChiGiao";
            this.txtDiaChiGiao.Size = new System.Drawing.Size(195, 22);
            this.txtDiaChiGiao.TabIndex = 178;
            // 
            // txtTenNguoiNhan
            // 
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(158, 297);
            this.txtTenNguoiNhan.Name = "txtTenNguoiNhan";
            this.txtTenNguoiNhan.Size = new System.Drawing.Size(210, 22);
            this.txtTenNguoiNhan.TabIndex = 177;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(420, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 175;
            this.label11.Text = "Trạng thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(420, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 174;
            this.label12.Text = "SĐT người gửi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(31, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 173;
            this.label10.Text = "Giá đơn hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(420, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 172;
            this.label9.Text = "Trọng lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 170;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(420, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 171;
            this.label8.Text = "SĐT người nhận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(420, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 169;
            this.label7.Text = "Địa chỉ giao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(420, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 168;
            this.label6.Text = "Ngày tạo đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(31, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 167;
            this.label5.Text = "Tên người nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(31, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 166;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(31, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 176;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 165;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(158, 93);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(210, 22);
            this.txtMaDH.TabIndex = 179;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1660, 747);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.txtMaDH);
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.TextBox txtMaDH;
    }
}