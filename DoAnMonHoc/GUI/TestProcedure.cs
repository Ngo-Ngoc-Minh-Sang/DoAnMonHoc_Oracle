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
            string strCon = @"DATA SOURCE = DELL:1521/ORCL.LOCALDOMAIN; USER ID=MINHSANG;PASSWORD=21062002";
            OracleConnection con = new OracleConnection(strCon);
            con.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "get_employee_salary";
            command.Parameters.Add("employee_id", OracleDbType.Int32).Value = 3;
            command.Parameters.Add("p_salary", OracleDbType.Int32, ParameterDirection.Output);
            command.ExecuteNonQuery();
            string result = command.Parameters["p_salary"].Value.ToString();
            label1.Text = result;
            con.Close();
        }
    }
}
