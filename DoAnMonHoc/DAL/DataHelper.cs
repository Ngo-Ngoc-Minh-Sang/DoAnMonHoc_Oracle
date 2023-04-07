﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DoAnMonHoc.DAL
{
    class DataHelper
    {
        public static OracleConnection con = null;
        public DataHelper()
        {
            string strCon = @"DATA SOURCE = DESKTOP-BR9DJSA:1521/ORCL; USER ID=System;PASSWORD=Nhieu2001";
            con = new OracleConnection(strCon);
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader rd = cmd.ExecuteReader();
                table.Load(rd);
            }
            catch (Exception ex)
            {
                throw new Exception("Execute query erorr: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return table;
        }

        public void ExecuteNonQuery(string query)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query erorr: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}
