using DoAnMonHoc.DAL;
using Oracle.ManagedDataAccess.Client;
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
    public partial class frmNVDangNhap: Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmNVDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau kh = new frmDoiMatKhau();
            kh.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                //string tendangnhap = "tendangnhap_cua_nhan_vien_dang_dang_nhap";
                frmDangNhap frmDN = new frmDangNhap();
                string tendangnhap = frmDN.GetTenDangNhap();
                //string tenDangNhap = textTenDN  .Text; // Lấy mã nhân viên từ textbox

                string query = "SELECT TENNV, GMAIL, CCCD, SDT, DIACHI FROM NHANVIEN WHERE TENDANGNHAP = '" + tendangnhap + "'";

                DataTable table = helper.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    string manv = row["MANV"].ToString();
                    string tennv = row["TENNV"].ToString();
                    string gmail = row["GMAIL"].ToString();
                    string cccd = row["CCCD"].ToString();
                    string sdt = row["SDT"].ToString();
                    string diachi = row["DIACHI"].ToString();

                    textTenNV.Text = tennv;
                    textGmail.Text = gmail;
                    textCCCD.Text = cccd;
                    textSDT.Text = sdt;
                    textDC.Text = diachi;
                    textMaNV.Text = manv;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn CSDL: " + ex.Message);
            }
        }
        
        private void frmNVDangNhap_Load(object sender, EventArgs e)
        {
            textMaNV.Enabled = false;
            textTenNV.Enabled = false;
            textMaCV.Enabled = false;
            textGmail.Enabled = false;
            textCCCD.Enabled = false;
            textSDT.Enabled = false;
            textDC.Enabled = false;
            textTenDN.Enabled = false;
        }
        
    }
}
