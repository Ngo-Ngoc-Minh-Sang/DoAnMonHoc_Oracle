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
    public partial class frmThongTinNhanVien : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        string tmpPass;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            String maNVLogin = frmDangNhap.maNhanVien;
            DataTable table = helper.ExecuteQuery("select * from NHANVIEN nv, CHUCVU cv where nv.MACV = cv.MACV and MANV = '" + maNVLogin + "'");
            DataRow row = table.Rows[0];
            lbMaNV.Text = row["MaNV"].ToString();
            lbTenNV.Text = row["TenNV"].ToString();
            lbChucVu.Text = row["TenCV"].ToString();
            lbGmail.Text = row["Gmail"].ToString();
            lbCCCD.Text = row["CCCD"].ToString();
            lbSDT.Text = row["SDT"].ToString();
            lbDiaChi.Text = row["DiaChi"].ToString();
            lbTenDangNhap.Text = row["TenDangNhap"].ToString();
            lbMatKhau.Text = changeTextToPass(row["MatKhau"].ToString().Trim());
            tmpPass = row["MatKhau"].ToString().Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(String.Compare(this.button4.Image.Tag.ToString(), "unhide") == 0)
            {
                this.button4.Image = global::DoAnMonHoc.Properties.Resources.hide;
                this.button4.Image.Tag = "hide";
                lbMatKhau.Text = tmpPass;
            }
            else
            {
                this.button4.Image = global::DoAnMonHoc.Properties.Resources.unhide;
                this.button4.Image.Tag = "unhide";
                lbMatKhau.Text = changeTextToPass(tmpPass);
            }
                
        }
        public string changeTextToPass(string s)
        {
            string pass = "";
            for(int i = 0; i < s.Length; i++)
            {
                pass += "*";
            }
            return pass;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
