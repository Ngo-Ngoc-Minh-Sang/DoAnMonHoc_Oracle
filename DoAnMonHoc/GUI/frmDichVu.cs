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
    public partial class frmDichVu : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataTable table = helper.ExecuteQuery("select * from DICHVU");
            dataGridView_DV.DataSource = table;
        }

        private void dataGridView_DV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_DV.SelectedRows.Count > 0)
            {
                // Lấy giá trị các ô trong bản ghi được chọn
                DataGridViewRow row = dataGridView_DV.SelectedRows[0];
                string MADV = row.Cells["MADV"].Value.ToString();
                string TENDV = row.Cells["TENDV"].Value.ToString();
                string GIA = row.Cells["GIA"].Value.ToString();

                // Gán giá trị vào các TextBox trên Form
                textMaDV.Text = MADV;
                textTenDV.Text = TENDV;
                textGia.Text = GIA;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            string maDV = textMaDV.Text;
            string tenDV = textTenDV.Text;
            int gia = int.Parse(textGia.Text);

            string sql = "INSERT INTO DICHVU (MADV, TENDV, GIA) VALUES ('" + maDV + "', '" + tenDV + "', " + gia + ")";
            try
            {
                helper.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_DV.SelectedRows.Count > 0) // Kiểm tra đã chọn dòng nào chưa
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy mã dịch cảu dòng được chọn
                    string maDV = dataGridView_DV.SelectedRows[0].Cells["MADV"].Value.ToString();
                    // Thực hiện xoa dòng dữ liệu
                    string sql = "DELETE FROM DICHVU WHERE MADV = '" + maDV + "'";
                    helper.ExecuteNonQuery(sql);
                    // Cập nhật lại dữ liệu
                    loadData();
                    // Thông báo đã xóa dữ liệu thành công
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            if (dataGridView_DV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDV = dataGridView_DV.SelectedRows[0].Cells["MADV"].Value.ToString();
            string tenDV = textTenDV.Text;
            int gia = int.Parse(textGia.Text);

            string sql = "UPDATE DICHVU SET TENDV = '"+tenDV+"',GIA = '"+gia+"' WHERE MADV = '"+ maDV+"'";

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
