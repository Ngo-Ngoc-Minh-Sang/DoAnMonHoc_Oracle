namespace DoAnMonHoc.GUI
{
    partial class frmChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loadDgv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgChucVu = new System.Windows.Forms.DataGridView();
            this.text_TenChucVu = new System.Windows.Forms.TextBox();
            this.text_maChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // loadDgv
            // 
            this.loadDgv.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loadDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDgv.ForeColor = System.Drawing.Color.Red;
            this.loadDgv.Location = new System.Drawing.Point(534, 228);
            this.loadDgv.Name = "loadDgv";
            this.loadDgv.Size = new System.Drawing.Size(128, 56);
            this.loadDgv.TabIndex = 38;
            this.loadDgv.Text = "Load";
            this.loadDgv.UseVisualStyleBackColor = false;
            this.loadDgv.Click += new System.EventHandler(this.loadDgv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(563, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nhập giá trị cần tìm";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Red;
            this.search.Location = new System.Drawing.Point(612, 137);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(119, 50);
            this.search.TabIndex = 36;
            this.search.Text = "Tìm Kiếm";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(543, 85);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(239, 35);
            this.txt_search.TabIndex = 35;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(720, 232);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 52);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.Location = new System.Drawing.Point(370, 232);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 52);
            this.btn_Sua.TabIndex = 32;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(193, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 52);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(18, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 52);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgChucVu
            // 
            this.dtgChucVu.AllowUserToAddRows = false;
            this.dtgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgChucVu.Location = new System.Drawing.Point(23, 290);
            this.dtgChucVu.Name = "dtgChucVu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgChucVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgChucVu.RowHeadersWidth = 51;
            this.dtgChucVu.RowTemplate.Height = 24;
            this.dtgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChucVu.Size = new System.Drawing.Size(808, 202);
            this.dtgChucVu.TabIndex = 29;
            this.dtgChucVu.SelectionChanged += new System.EventHandler(this.dtgChucVu_SelectionChanged);
            // 
            // text_TenChucVu
            // 
            this.text_TenChucVu.Location = new System.Drawing.Point(193, 148);
            this.text_TenChucVu.Name = "text_TenChucVu";
            this.text_TenChucVu.Size = new System.Drawing.Size(213, 22);
            this.text_TenChucVu.TabIndex = 28;
            // 
            // text_maChucVu
            // 
            this.text_maChucVu.Location = new System.Drawing.Point(193, 100);
            this.text_maChucVu.Name = "text_maChucVu";
            this.text_maChucVu.Size = new System.Drawing.Size(213, 22);
            this.text_maChucVu.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÔNG TIN CHỨC VỤ ";
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(862, 504);
            this.Controls.Add(this.loadDgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgChucVu);
            this.Controls.Add(this.text_TenChucVu);
            this.Controls.Add(this.text_maChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadDgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgChucVu;
        private System.Windows.Forms.TextBox text_TenChucVu;
        private System.Windows.Forms.TextBox text_maChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}