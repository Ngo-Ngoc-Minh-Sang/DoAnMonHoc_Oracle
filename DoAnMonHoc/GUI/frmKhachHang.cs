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

          

            
            string sql = "UPDATE INTO KHACHHANG (MAKH, TENKH, SDT,GMAIL,DIACHI) VALUES ('" + MAKH + "', '" + TENKH + "', " + SDT + ",'" + GMAIL + "','" + DIACHI + "')";

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
    }
}
