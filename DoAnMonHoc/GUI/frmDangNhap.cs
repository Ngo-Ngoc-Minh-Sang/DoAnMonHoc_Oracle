using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DoAnMonHoc.GUI
{
    public partial class frmDangNhap : Form
    {
        DAL.DataHelper helper = new DAL.DataHelper();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string GetTenDangNhap()
        {
            return txtUserName.Text;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            DataTable table = helper.ExecuteQuery("select * from NHANVIEN where TENDANGNHAP='" + userName + "' and MATKHAU='" + passWord + "'");
            if (table.Rows.Count <= 0)
                MessageBox.Show("Sai mật khẩu hoặc tài khoản. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                frmMenu menu = new frmMenu();
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                this.Visible = false;
                menu.ShowDialog();
            }
        }
    }
}
