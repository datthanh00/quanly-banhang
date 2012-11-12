using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class Dataprovider
    {
        string strcon = "server=bambi-pc;database=XUAT_NHAPTON;integrated security=true;";
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public void connect()
        {
            if (con == null)
                con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        public DataSet get(string sql)
        {
            connect();
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            disconnect();
            return ds;
        }
        public void executeNonQuery(string sql)
        {
            connect();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public void ChayProc(String spName, List<SqlParameter> sqlParams)
        {
                connect();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;
                if (sqlParams != null)
                {
                    foreach (SqlParameter param in sqlParams)
                    {
                        command.Parameters.Add(param);
                    }
                }
                command.ExecuteNonQuery();
                disconnect();
            
        }
        
        public DataTable executeNonQuerya(String spName, List<SqlParameter> sqlParams)
        {
        tt:
            DataTable dt = new DataTable();
            
                connect();
                
                   

                        SqlCommand command = con.CreateCommand();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParams != null)
                        {
                            foreach (SqlParameter param in sqlParams)
                            {
                                command.Parameters.Add(param);
                            }
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dt);
                                                 
           
            return dt;
        }




       

        protected static SqlConnection get_Connect()
        {
            throw new NotImplementedException();
        }
    }
}
