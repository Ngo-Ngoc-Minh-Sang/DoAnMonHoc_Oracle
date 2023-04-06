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
            try
            {
                String query = "delete from NHANVIEN where manv='NV001'";
                helper.ExecuteNonQuery(query);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO NHANVIEN(MANV, TENNV, MACV, GMAIL, CCCD, SDT, DIACHI) " +
                    "VALUES('NV001', N'Trần Văn Ái', 'CV001', 'tranvanai@gmail.com', '235621458', '0253125258', N'12 Nguyễn Văn Khởi, Quận 5, TP HCM')";
                helper.ExecuteNonQuery(query);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "UPDATE NHANVIEN " +
                    "SET TENNV = 'Ngô Ngọc Minh Sang', " +
                    "SDT = '0000000000', " +
                    "DIACHI = '140 Lê Trọng Tấn, Quận Tân Phú, TP HCM' " +
                    "WHERE MANV = 'NV001'";
                helper.ExecuteNonQuery(query);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
