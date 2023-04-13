using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.DAL
{
    internal class XuLyDuLieu
    {
        OracleConnection connection;
        OracleDataAdapter adapter;

        public XuLyDuLieu()
        {
            //connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=Company)));User Id=C##hdaz;Password=123;");
            //connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=Company)));User Id=C##hdaz;Password=123;");<<<<<<< HEAD
            //connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=C##hdaz;Password=123;");
            //connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=systtem;Password=vulong12345;");
            //connection = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=C##hdaz;Password=123;");


        }

        public DataTable LayDuLieu(string lenhsql)
        {
            adapter = new OracleDataAdapter(lenhsql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);   
            return dt;
        }

        public int THEMXOASUA(string lenhsql)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            OracleCommand command = new OracleCommand(lenhsql, connection);
            return command.ExecuteNonQuery();
            connection.Close();
        }

        public int CAPNHAT(string lenhsql, DataTable tablename)
        {
            adapter = new OracleDataAdapter(lenhsql, connection);
            OracleCommandBuilder commandBuilder = new OracleCommandBuilder(adapter);
            return adapter.Update(tablename);
        }
    }
}
