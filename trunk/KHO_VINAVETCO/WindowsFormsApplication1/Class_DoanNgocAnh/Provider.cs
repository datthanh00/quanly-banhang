using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Data;



namespace WindowsFormsApplication1
{
    class Provider
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        protected static string strConnect;

        public static SqlConnection get_Connect()
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App");
            if (!Directory.Exists(filePath))
            {
                filePath = AppDomain.CurrentDomain.BaseDirectory;
            }
            filePath = Path.Combine(filePath, Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            System.Configuration.Configuration AppC = ConfigurationManager.OpenExeConfiguration(filePath);

            //System.Configuration.Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
            if (File.Exists("App.config"))
            {
                //Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                if (PublicVariable.isUSELAN)
                {
                    strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true;uid=" + AppC.AppSettings.Settings["uid"].Value.ToString() + ",pwd=" + AppC.AppSettings.Settings["pwd"].Value.ToString() + "";
                }
                else
                {
                    if (PublicVariable.IS_VINAVETCO)
                    {
                        strConnect = " Data Source=mssql.nguyendatthanh.com;Network Library=DBMSSOCN;Initial Catalog=nguyendat_vinavetco;User ID=nguye_vinavetco;Password=Urt22!u6;";
                         //  strConnect = "server=MINHNAM;database=vinatuanhanh;integrated security = true;uid=sa,pwd=dat123;Integrated Security=True";
			            // user:nguye_datthanh    pass:  Minhnam123@

                    }
                    else
					
                    {
                        strConnect = " Data Source=mssql.nguyendatthanh.com;Network Library=DBMSSOCN;Initial Catalog=nguyendat_tuanhanh;User ID=nguye_tuanhanh;Password=diQn9#42;";

                        // strConnect = "server=MICROSOFT;database=KHO_TUANHANH6;integrated security = true;uid=sa,pwd=dat123;Integrated Security=True";
                    }
                }
            }
            SqlConnection cn = new SqlConnection(strConnect);
            try
            {
                cn.Open();
            }
            catch
            {
                MessageBox.Show("Kiểm Tra Lại Kết Nối InterNet nếu không được thì gọi cho Thành SĐT:0907093902");
            }
            return cn;
        }

        public void thu(String sql, List<SqlParameter> sqlParams)
        {
            connect();
            cmd = new SqlCommand(sql, con);
            if (sqlParams != null)
            {
                foreach (SqlParameter param in sqlParams)
                {
                    cmd.Parameters.Add(param);
                }
            }
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public DataTable executeNonQuerya(String spName, List<SqlParameter> sqlParams)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                {
                    {
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
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dt;
        }
        public void ChayProc(String spName, List<SqlParameter> sqlParams)
        {
            try
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
            catch (Exception ex)
            {
                 DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                 
            }
        }
        
       
        public void connect()
        {
            if (con == null)
                con = get_Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
                con.Close();
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
        public DataTable getdata(string sql)
        {
            connect();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        public void executeNonQuery(string sql)
        {
            connect();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }
         public void executeNonQuery2(string sql)
        {
            //connect();
            //ServerConnection svrConnection = new ServerConnection(con);
            //Server server = new Server(svrConnection);
            //server.ConnectionContext.ExecuteNonQuery(sql);
            //disconnect();

            connect();
            using (SqlCommand command = con.CreateCommand())
            {
                string script = sql;
                command.CommandText = script.Replace("GO", "");
               
                int affectedRows = command.ExecuteNonQuery();
            }
            disconnect();

        }

         
        public void executereader(string sql)
        {
            connect();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();

            cmd = new SqlCommand(sql, con);

            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                Console.WriteLine(DR.GetString(0)); 
            }
            DR.Close();
            disconnect();
           // ExecSql("");

        }

    }
    
}