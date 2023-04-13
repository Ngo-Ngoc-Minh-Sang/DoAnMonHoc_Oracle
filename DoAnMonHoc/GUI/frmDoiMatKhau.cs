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
    public partial class frmDoiMatKhau : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đầy đủ thông tin cần thiết để đổi mật khẩu chưa
            if (string.IsNullOrEmpty(textMKCu.Text) || string.IsNullOrEmpty(textMKMoi.Text) || string.IsNullOrEmpty(textMKMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem mật khẩu hiện tại có đúng không
            if (textMKCu.Text.Trim() != GetMatKhauHienTai().Trim())
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            // Kiểm tra xem mật khẩu mới và xác nhận mật khẩu mới có khớp nhau không
            // CẨN THẬN LỖI
            if (textMKMoi.Text.Trim() != txtNhapLaiMK.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không khớp nhau! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị thông báo xác nhận cho người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Thực hiện đổi mật khẩu nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                // Thực hiện cập nhật mật khẩu mới vào CSDL ở đây
                UpdateMatKhauMoi(textMKMoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string GetMatKhauHienTai()
        {
            try
            {
                string query = "SELECT * FROM NHANVIEN WHERE MANV = '" + frmDangNhap.maNhanVien + "'";
                DataTable dt = helper.ExecuteQuery(query);
                DataRow row = dt.Rows[0];
                string a = row["MATKHAU"].ToString();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        private void UpdateMatKhauMoi(string matKhauMoi)
        {
            try
            {
                string query = "UPDATE NHANVIEN SET MATKHAU = '" + matKhauMoi.Trim() + "' WHERE MANV = '" + frmDangNhap.maNhanVien + "'";
                helper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
