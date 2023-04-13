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
    public partial class TestProcedure : Form
    {
        public TestProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            //OracleConnection con = new OracleConnection(strCon);
            //con.Open();
            //OracleCommand command = new OracleCommand();
            //command.Connection = con;
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "get_employee_salary";
            //command.Parameters.Add("employee_id", OracleDbType.Int32).Value = 3;
            //command.Parameters.Add("p_salary", OracleDbType.Int32, ParameterDirection.Output);
            //command.ExecuteNonQuery();
            //string result = command.Parameters["p_salary"].Value.ToString();
            //label1.Text = result;
            //con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // load dữ liệu procedure select
            //string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            //OracleConnection con = new OracleConnection(strCon);
            //string queryString = "proc_xuat_thongtin_nhanvien";
            //DataTable dataTable = new DataTable();
            //OracleCommand command = new OracleCommand(queryString, con);
            //command.CommandType = CommandType.StoredProcedure;
            //OracleParameter outCursorParam = new OracleParameter("out_cursor", OracleDbType.RefCursor);
            //outCursorParam.Direction = ParameterDirection.Output;
            //command.Parameters.Add(outCursorParam);
            //OracleDataAdapter adapter = new OracleDataAdapter(command);
            //con.Open();
            //adapter.Fill(dataTable);
            //con.Close();
            //dataGridView1.DataSource = dataTable;

            // thực hiện procedure insert
            //string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            //OracleConnection con = new OracleConnection(strCon);
            //OracleCommand cmd = con.CreateCommand();
            //con.Open();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "proc_insert_chucvu";
            //cmd.Parameters.Add("p_employee_id", OracleDbType.Char).Value = "CV005";
            //cmd.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = "Thu Ngân";
            //cmd.ExecuteNonQuery();
            //con.Close();

            // thực hiện procedure update
            //string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            //OracleConnection con = new OracleConnection(strCon);
            //OracleCommand cmd = con.CreateCommand();
            //con.Open();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "proc_update_chucvu";
            //cmd.Parameters.Add("p_employee_id", OracleDbType.Char).Value = "CV005";
            //cmd.Parametet_name", OracleDbType.Varchar2).Value = "Thu Phí";
            //cmd.ExecuteNonQuery();
            //con.Close();

            // thực hiện procedure delete
            //string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            //OracleConnection con = new OracleConnection(strCon);
            //OracleCommand cmd = con.CreateCommand();
            //con.Open();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "proc_delete_chucvu";
            //cmd.Parameters.Add("p_employee_id", OracleDbType.Char).Value = "CV005";
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
