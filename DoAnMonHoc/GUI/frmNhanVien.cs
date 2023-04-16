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
    public partial class frmNhanVien : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtTenNhanVien.Text;
            string chucVu = "";
            string mail = txtGmail.Text;
            string cccd = txtCCCD.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string tenDN = txtTenDN.Text;
            string matKhau = txtMatKhau.Text;
            OracleConnection con = DAL.DataHelper.con;
            OracleCommand cmd = con.CreateCommand();
            string query = "select * from CHUCVU where UPPER(TENCV) = '" + txtChucVu.Text.ToUpper() + "'";
            DataTable tb = helper.ExecuteQuery(query);
            DataRow row = tb.Rows[0];
            chucVu = row["MACV"].ToString();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_insert_nhanvien";
            cmd.Parameters.Add("manv", OracleDbType.Char).Value = maNV;
            cmd.Parameters.Add("tennv", OracleDbType.Varchar2).Value = tenNV;
            cmd.Parameters.Add("tendangnhap", OracleDbType.Char).Value = tenDN;
            cmd.Parameters.Add("matkhau", OracleDbType.Char).Value = matKhau;
            cmd.Parameters.Add("chucvu", OracleDbType.Char).Value = chucVu;
            cmd.Parameters.Add("gmail", OracleDbType.Varchar2).Value = mail;
            cmd.Parameters.Add("cccd", OracleDbType.Char).Value = cccd;
            cmd.Parameters.Add("sdt", OracleDbType.Char).Value = sdt;
            cmd.Parameters.Add("diachi", OracleDbType.Varchar2).Value = diaChi;
            cmd.ExecuteNonQuery();
            con.Close();
            loadData();
        }

        private void loadData()
        {
            OracleConnection con = DAL.DataHelper.con;
            string queryString = "proc_xuat_thongtin_nhanvien";
            DataTable dataTable = new DataTable();
            OracleCommand command = new OracleCommand(queryString, con);
            command.CommandType = CommandType.StoredProcedure;
            OracleParameter outCursorParam = new OracleParameter("out_cursor", OracleDbType.RefCursor);
            outCursorParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(outCursorParam);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            con.Open();
            adapter.Fill(dataTable);
            con.Close();
            dgvTTNhanVien.DataSource = dataTable;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            OracleConnection con = DAL.DataHelper.con;
            OracleCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_delete_nhanvien";
            cmd.Parameters.Add("p_manv", OracleDbType.Char).Value = maNV;
            cmd.ExecuteNonQuery();
            con.Close();
            loadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtTenNhanVien.Text;
            string chucVu = "";
            string mail = txtGmail.Text;
            string cccd = txtCCCD.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string tenDN = txtTenDN.Text;
            string matKhau = txtMatKhau.Text;
            OracleConnection con = DAL.DataHelper.con;
            OracleCommand cmd = con.CreateCommand();
            string query = "select * from CHUCVU where UPPER(TENCV) = '" + txtChucVu.Text.ToUpper() + "'";
            DataTable tb = helper.ExecuteQuery(query);
            DataRow row = tb.Rows[0];
            chucVu = row["MACV"].ToString();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_update_nhanvien";
            cmd.Parameters.Add("manv", OracleDbType.Char).Value = maNV;
            cmd.Parameters.Add("tennv", OracleDbType.Varchar2).Value = tenNV;
            cmd.Parameters.Add("tendangnhap", OracleDbType.Char).Value = tenDN;
            cmd.Parameters.Add("matkhau", OracleDbType.Char).Value = matKhau;
            cmd.Parameters.Add("chucvu", OracleDbType.Char).Value = chucVu;
            cmd.Parameters.Add("gmail", OracleDbType.Varchar2).Value = mail;
            cmd.Parameters.Add("cccd", OracleDbType.Char).Value = cccd;
            cmd.Parameters.Add("sdt", OracleDbType.Char).Value = sdt;
            cmd.Parameters.Add("diachi", OracleDbType.Varchar2).Value = diaChi;
            cmd.ExecuteNonQuery();
            con.Close();
            loadData();
        }

        private void dgvTTNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTTNhanVien.SelectedRows.Count > 0)
            {
                // Lấy giá trị các ô trong bản ghi được chọn
                DataGridViewRow row = dgvTTNhanVien.SelectedRows[0];
                string MANV = row.Cells["MANV"].Value.ToString();
                string TENNV = row.Cells["TENNV"].Value.ToString();
                string CHUCVU = row.Cells["MACV"].Value.ToString();
                string GMAIL = row.Cells["GMAIL"].Value.ToString();
                string CCCD = row.Cells["CCCD"].Value.ToString();
                string SDT = row.Cells["SDT"].Value.ToString();
                string DIACHI = row.Cells["DIACHI"].Value.ToString();
                string TENDANGNHAP = row.Cells["TENDANGNHAP"].Value.ToString();
                string MATKHAU = row.Cells["MATKHAU"].Value.ToString();

                // Gán giá trị vào các TextBox trên Form
                txtMaNhanVien.Text = MANV;
                txtTenNhanVien.Text = TENNV;
                txtChucVu.Text = CHUCVU;
                txtGmail.Text = GMAIL;
                txtCCCD.Text = CCCD;
                txtSDT.Text = SDT;
                txtDiaChi.Text = DIACHI;
                txtTenDN.Text = TENDANGNHAP;
                txtMatKhau.Text = MATKHAU;
            }
        }
    }
}
