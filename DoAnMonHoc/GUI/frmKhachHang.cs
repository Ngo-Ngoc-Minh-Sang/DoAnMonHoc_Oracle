using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc.GUI
{
    public partial class frmKhachHang : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmKhachHang()
        {
            InitializeComponent();

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadData();        
        }
        private void loadData()
        {
            DataTable table = helper.ExecuteQuery("select * from KHACHHANG");
            dtgKhachhang.DataSource = table;

            // Xóa giá trị hiện tại về ""
            ClearTextform();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = text_makh.Text;
            string TENKH = text_ten.Text;
            string SDT = text_sdt.Text;
            string GMAIL = text_gmail.Text;
            string DIACHI = text_diachi.Text;
            
            string sql = "INSERT INTO KHACHHANG (MAKH, TENKH, SDT,GMAIL,DIACHI) VALUES ('" + makh + "', '" + TENKH + "', " + SDT + ",'"+GMAIL+"','"+DIACHI+"')";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgKhachhang.SelectedRows.Count > 0) // Kiểm tra đã chọn dòng nào chưa
            {
                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy mã dịch cảu dòng được chọn
                        string makh = dtgKhachhang.SelectedRows[0].Cells["MAKH"].Value.ToString();
                        // Thực hiện xoa dòng dữ liệu
                        string sql = "DELETE FROM KHACHHANG WHERE MAKH = '" + makh + "'";
                        helper.ExecuteNonQuery(sql);
                        // Cập nhật lại dữ liệu
                        loadData();

                        // Thông báo đã xóa dữ liệu thành công
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgKhachhang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MAKH = dtgKhachhang.SelectedRows[0].Cells["MAKH"].Value.ToString();
            string TENKH = text_ten.Text;
            string SDT = text_sdt.Text;
            string GMAIL = text_gmail.Text;
            string DIACHI = text_diachi.Text;

            try
            {
                string sql = "UPDATE KHACHHANG SET ";
                sql += " TENKH = '" + TENKH + "',";
                sql += " SDT = '" + SDT + "',";
                sql += " GMAIL = '" + GMAIL + "',";
                sql += "DIACHI = '" + DIACHI + "'";
                sql += " WHERE MAKH = '" + MAKH + "'";

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

        private void text_sdt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dtgKhachhang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgKhachhang.SelectedRows.Count > 0)
            {
                // Lấy giá trị các ô trong bản ghi được chọn
                DataGridViewRow row = dtgKhachhang.SelectedRows[0];
                string MAKH = row.Cells["MAKH"].Value.ToString();
                string TENKH = row.Cells["TENKH"].Value.ToString();
                string SDT = row.Cells["SDT"].Value.ToString();
                string GMAIL = row.Cells["GMAIL"].Value.ToString();
                string DIACHI = row.Cells["DIACHI"].Value.ToString();

                // Gán giá trị vào các TextBox trên Form
                text_makh.Text = MAKH;
                text_ten.Text = TENKH;
                text_sdt.Text = SDT;
                text_gmail.Text = GMAIL;
                text_diachi.Text = DIACHI;
            }
        }

        private void ClearTextform()
        {
            text_makh.Text = "";
            text_ten.Text = "";
            text_sdt.Text = "";
            text_gmail.Text = "";
            text_diachi.Text = "";
            txt_search.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_search.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(txtSearch))
            {
                MessageBox.Show("Vui lòng nhập giá trị tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dtgKhachhang.Rows)
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

        private void txt_search_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgKhachhang.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Tô màu ô chứa giá trị tìm thấy
                }
            }
        }

        private void loadDgv_Click(object sender, EventArgs e)
        {
            loadData();
            foreach (DataGridViewRow row in dtgKhachhang.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Tô màu ô chứa giá trị tìm thấy
                }
            }
        }
    }
}
