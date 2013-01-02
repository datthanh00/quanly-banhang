using System;
using System.Collections.Generic;
using System.Linq;
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
        
        protected static string strConnect;
        public static string sPass;
        public static string sUser;
        public static SqlConnection get_Connect()
        {
            if (File.Exists("App.config"))
            {
                Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                //strConnect = "server=bigedu.vn;Port=3306; User ID=bigeduvn_us; password=dat12345; database=bigeduvn_db";
                //strConnect = "server=tvdirect.com.vn;Port=3306; User ID=vdajio9f_thanh; password=dat12345; database=vdajio9f_qlkho; charset=utf8;Allow Zero Datetime=true";
                    
                //strConnect = "server=localhost;Port=3306; User ID=root; password=; database=xuat_nhapton;charset=utf8;Allow Zero Datetime=true";
                strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true;uid=" + AppC.AppSettings.Settings["uid"].Value.ToString() + ",pwd=" + AppC.AppSettings.Settings["pwd"].Value.ToString() + "";
            }
                SqlConnection cn = new SqlConnection(strConnect);
            cn.Open();
            return cn;
        }

        public static SqlConnection connect1()
        {

        tt:
            try
            {
                if (File.Exists("App.config"))
                {
                    Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                    //strConnect = "server=bigedu.vn;Port=3306; User ID=bigeduvn_us; password=dat12345; database=bigeduvn_db"
                    //strConnect = "server=tvdirect.com.vn;Port=3306; User ID=vdajio9f_thanh; password=dat12345; database=vdajio9f_qlkho; charset=utf8;Allow Zero Datetime=true";
                    //vdajio9f_qlkho   'dC]|e#8#I3CDj39'
                    //strConnect = "server=localhost;Port=3306; User ID=root; password=; database=xuat_nhapton;charset=utf8;Allow Zero Datetime=true";
                    strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true";
                }
                SqlConnection cn = new SqlConnection(strConnect);
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

        }

    }
    
}