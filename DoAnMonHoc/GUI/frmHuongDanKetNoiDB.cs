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
    public partial class frmHuongDanKetNoiDB : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmHuongDanKetNoiDB()
        {
            InitializeComponent();
        }

        private void frmHuongDanKetNoiDB_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable table = helper.ExecuteQuery("select * from NHANVIEN");
            dtgNhanVien.DataSource = table;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count > 0) // Kiểm tra đã chọn dòng nào chưa
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy mã dịch cảu dòng được chọn
                    string maNV = dtgNhanVien.SelectedRows[0].Cells["MANV"].Value.ToString();
                    // Thực hiện xoa dòng dữ liệu
                    string sql = "DELETE FROM NHANVIEN WHERE MANV = '" + maNV + "'";
                    helper.ExecuteNonQuery(sql);
                    // Cập nhật lại dữ liệu
                    loadData();
                    // Thông báo đã xóa dữ liệu thành công
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txt_manv.Text;
            string tenNV = txt_tennv.Text;
            string maCV = txt_macv.Text;
            string gmail = txt_gmail.Text;
            string cccd = txt_cccd.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;

            string sql = "INSERT INTO NHANVIEN (MANV, TENNV, MACV, GMAIL, CCCD, SDT, DIACHI) VALUES ('" + maNV + "', '" + tenNV + "', '" + maCV + "', '" + gmail + "', '" + cccd + "', '" + sdt + "', '" + diachi + "')";
            try
            {
                helper.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = dtgNhanVien.SelectedRows[0].Cells["MANV"].Value.ToString();
            string tenNV = txt_tennv.Text;
            string maCV = txt_macv.Text;
            string gmail = txt_gmail.Text;
            string cccd = txt_cccd.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            string sql = "UPDATE NHANVIEN SET TENNV = '" + tenNV + "',MACV = '" + maCV + "',GMAIL = '" + gmail + "',CCCD = '" + cccd + "',SDT = '" + sdt + "',DIACHI = '" + diachi + "' WHERE MANV = '" + maNV + "'";

            try
            {
                helper.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát Khỏi Bảng Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
