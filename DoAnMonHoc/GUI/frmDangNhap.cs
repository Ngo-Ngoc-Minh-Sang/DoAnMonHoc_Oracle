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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            //DataTable table = helper.ExecuteQuery("select * from NHANVIEN where TENDANGNHAP='" + userName + "' and MATKHAU='" + passWord + "'");
            //if (table.Rows.Count <= 0)
            //    MessageBox.Show("Sai mật khẩu hoặc tài khoản. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            //else
            //{
            //    frmMenu menu = new frmMenu();
            //    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
            //    this.Visible = false;
            //    menu.ShowDialog();
            //}

            string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            OracleConnection con = new OracleConnection(strCon);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "func_kiemtradangnhap";
            cmd.Parameters.Add("tendangnhap", OracleDbType.Char).Value = userName;
            cmd.Parameters.Add("matkhau", OracleDbType.Char).Value = passWord;
            cmd.Parameters.Add("check", OracleDbType.Boolean).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Boolean check = Convert.ToBoolean(cmd.Parameters["check"].Value);
            if (check == false)
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
