using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Data;
using  MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    class Provider
    {
        MySqlConnection con;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataSet ds;

        public void thu(String sql, List<MySqlParameter> sqlParams)
        {
            connect();
            cmd = new MySqlCommand(sql, con);
            if (sqlParams != null)
            {
                foreach ( MySqlParameter param in sqlParams)
                {
                    cmd.Parameters.Add(param);
                }
            }
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public DataTable executeNonQuerya(String spName, List<MySqlParameter> sqlParams)
        {
           
            DataTable dt = new DataTable();
            try
            {
                connect();
                {
                    {

                        MySqlCommand command = con.CreateCommand();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        if (sqlParams != null)
                        {
                            foreach (MySqlParameter param in sqlParams)
                            {
                                command.Parameters.Add(param);
                            }
                        }
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
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
        public void ChayProc(String spName, List<MySqlParameter> sqlParams)
        {
        
            try
            {
                connect();
                MySqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;
                if (sqlParams != null)
                {
                    foreach (MySqlParameter param in sqlParams)
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
        
        protected static string strConnect;
        public static string sPass;
        public static string sUser;
        public static MySqlConnection get_Connect()
        {
            if (File.Exists("App.config"))
            {
                Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                //strConnect = "server=bigedu.vn;Port=3306; User ID=bigeduvn_us; password=dat12345; database=bigeduvn_db";
                strConnect = "server=tvdirect.com.vn;Port=3306; User ID=vdajio9f_thanh; password=dat12345; database=vdajio9f_qlkho; charset=utf8;Allow Zero Datetime=true";
                    
                //strConnect = "server=localhost;Port=3306; User ID=root; password=; database=xuat_nhapton;charset=utf8;Allow Zero Datetime=true";
                //strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true;uid=" + AppC.AppSettings.Settings["uid"].Value.ToString() + ",pwd=" + AppC.AppSettings.Settings["pwd"].Value.ToString() + "";
            }
            MySqlConnection cn = new MySqlConnection(strConnect);
            cn.Open();
            return cn;
        }

        public static MySqlConnection connect1()
        {

        tt:
            try
            {
                if (File.Exists("App.config"))
                {
                    Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                    //strConnect = "server=bigedu.vn;Port=3306; User ID=bigeduvn_us; password=dat12345; database=bigeduvn_db"
                    strConnect = "server=tvdirect.com.vn;Port=3306; User ID=vdajio9f_thanh; password=dat12345; database=vdajio9f_qlkho; charset=utf8;Allow Zero Datetime=true";
                    //vdajio9f_qlkho   'dC]|e#8#I3CDj39'
                    //strConnect = "server=localhost;Port=3306; User ID=root; password=; database=xuat_nhapton;charset=utf8;Allow Zero Datetime=true";
                    //strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true";
                }
                MySqlConnection cn = new MySqlConnection(strConnect);
                cn.Open();
                return cn;
            }
            catch
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Không tìm thấy server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCauHinhHeThong frm = new frmCauHinhHeThong();
                frm.ShowDialog();
                goto tt;
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
            da = new MySqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            disconnect();
            return ds;
        }
        public DataTable getdata(string sql)
        {
            connect();
            da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        public void executeNonQuery(string sql)
        {
            connect();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }
        public void executereader(string sql)
        {
            connect();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();

            cmd = new MySqlCommand(sql, con);

            MySqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                Console.WriteLine(DR.GetString(0)); 
            }
            DR.Close();
            disconnect();

        }

    }
    
}