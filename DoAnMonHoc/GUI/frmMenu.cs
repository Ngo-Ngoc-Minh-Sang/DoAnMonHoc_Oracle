using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc.GUI
{
    public partial class frmMenu : Form
    {
        public int IdRole { get; set; }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDonHang dh = new frmDonHang();
            dh.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDichVu dv = new frmDichVu();
            dv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChucVu cv = new frmChucVu();
            cv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien ttnv = new frmThongTinNhanVien();
            ttnv.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (IdRole == 3)
            {
                btnPost.Visible = false;
                btnCustomer.Visible = false;
                btnService.Visible = false;
                btnEmployee.Visible = false;
            }
        }
    }
}
