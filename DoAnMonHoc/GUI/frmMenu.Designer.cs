
namespace DoAnMonHoc.GUI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInfoEmployee = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "MENU";
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Red;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.Location = new System.Drawing.Point(448, 265);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(538, 152);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "NHÂN VIÊN";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(720, 423);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(266, 163);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnInfoEmployee
            // 
            this.btnInfoEmployee.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInfoEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoEmployee.ForeColor = System.Drawing.Color.Red;
            this.btnInfoEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoEmployee.Image")));
            this.btnInfoEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfoEmployee.Location = new System.Drawing.Point(448, 423);
            this.btnInfoEmployee.Name = "btnInfoEmployee";
            this.btnInfoEmployee.Size = new System.Drawing.Size(266, 163);
            this.btnInfoEmployee.TabIndex = 5;
            this.btnInfoEmployee.Text = "THÔNG TIN CÁ NHÂN";
            this.btnInfoEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfoEmployee.UseVisualStyleBackColor = false;
            this.btnInfoEmployee.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.Red;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPost.Location = new System.Drawing.Point(22, 423);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(420, 163);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "CHỨC VỤ";
            this.btnPost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Red;
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnService.Location = new System.Drawing.Point(448, 107);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(538, 152);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "DỊCH VỤ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.Location = new System.Drawing.Point(235, 107);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(207, 310);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "ĐƠN HÀNG";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(22, 107);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(207, 310);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "KHÁCH HÀNG";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1019, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInfoEmployee);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCustomer);
            this.Name = "frmMenu";
            this.Text = "frmMenu2";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnInfoEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label1;
    }
}