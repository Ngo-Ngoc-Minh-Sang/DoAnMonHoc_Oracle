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
        DAL.DataHelper helper = new DAL.DataHelper();
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
            String maNVLogin = frmDangNhap.maNhanVien;
            DataTable table = helper.ExecuteQuery("select * from NHANVIEN nv, CHUCVU cv where nv.MACV = cv.MACV and MANV = '" + maNVLogin + "'");
            DataRow row = table.Rows[0];
            string chucVu = row["MACV"].ToString();
            phanQuyenHeThong(chucVu);
        }

        private void phanQuyenHeThong(string chucvu)
        {
            chucvu = chucvu.Trim();
            if (chucvu == "CV002" || chucvu == "CV004")
            {
                btnPost.Enabled = false;
                btnCustomer.Enabled = false;
                btnService.Enabled = false;
                btnEmployee.Enabled = false;
            }
            else 
            {
                if (chucvu == "CV003")
                    btnEmployee.Enabled = false;
            }
        }
    }
}
