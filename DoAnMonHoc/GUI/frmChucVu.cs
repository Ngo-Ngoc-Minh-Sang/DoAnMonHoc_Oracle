using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc.GUI
{
    public partial class frmChucVu : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmChucVu()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            DataTable table = helper.ExecuteQuery("select * from CHUCVU");
            dtgChucVu.DataSource = table;

            // Xóa giá trị hiện tại về ""
            ClearTextform();
        }
        private void ClearTextform()
        {
            text_maChucVu.Text = "";
            text_TenChucVu.Text = "";
            txt_search.Text = "";
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macv = text_maChucVu.Text;
            string TENCV = text_TenChucVu.Text;

            // kiểm tra nếu không nhập gì thì không xử lý
            if (string.IsNullOrEmpty(macv) && string.IsNullOrEmpty(TENCV))
            {
                return;
            }

            // kiểm tra khóa chính không được nhập bỏ qua
            if (string.IsNullOrEmpty(macv))
            {
                MessageBox.Show("Vui lòng nhập: Mã Chức Vụ");
                return;
            }

            string sql = "INSERT INTO CHUCVU (MACV ,TENCV) VALUES ('" + macv + "', '" + TENCV + "')";
            try
            {
                helper.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgChucVu.SelectedRows.Count > 0) // Kiểm tra đã chọn dòng nào chưa
            {
                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy mã dịch cảu dòng được chọn
                        string macv = dtgChucVu.SelectedRows[0].Cells["MACV"].Value.ToString();
                        // Thực hiện xoa dòng dữ liệu
                        string sql = "DELETE FROM CHUCVU WHERE MACV = '" + macv + "'";
                        helper.ExecuteNonQuery(sql);
                        // Cập nhật lại dữ liệu
                        loadData();

                        // Thông báo đã xóa dữ liệu thành công
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi hệ thống phát sinh: Vui lòng thực hiện lại!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            try
            {
                string MACV = dtgChucVu.SelectedRows[0].Cells["MACV"].Value.ToString();
                string TENCV = text_TenChucVu.Text;

                string sql = "UPDATE  CHUCVU SET ";
                sql += " TENCV = '" + TENCV + "'";
                sql += " WHERE MACV = '" + MACV + "'";

                helper.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void loadDgv_Click(object sender, EventArgs e)
        {
            ClearTextform();


            // Set về trắng
            foreach (DataGridViewRow row in dtgChucVu.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Tô màu ô chứa giá trị tìm thấy
                }
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgChucVu.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Tô màu ô chứa giá trị tìm thấy
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            dtgChucVu.ClearSelection(); //Xóa ô màu trước khi thực hiện tìm kiếm
            string txtSearch = txt_search.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(txtSearch))
            {
                MessageBox.Show("Vui lòng nhập giá trị tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                foreach (DataGridViewRow row in dtgChucVu.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Trim().Equals(txtSearch))
                        {
                            cell.Style.BackColor = Color.Yellow; // Tô màu ô chứa giá trị tìm thấy
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgChucVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgChucVu.SelectedRows.Count > 0)
            {
                // Lấy giá trị các ô trong bản ghi được chọn
                DataGridViewRow row = dtgChucVu.SelectedRows[0];
                string MACV = row.Cells["MACV"].Value.ToString();
                string TENCV = row.Cells["TENCV"].Value.ToString();

                // Gán giá trị vào các TextBox trên Form
                text_maChucVu.Text = MACV;
                text_TenChucVu.Text = TENCV;
            }
        }
    }
}
    

