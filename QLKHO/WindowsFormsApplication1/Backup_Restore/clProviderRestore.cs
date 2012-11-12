using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class clProviderRestore
    {
        protected static string strConnect;
        public static string sPass;
        public static string sUser;
        public static SqlConnection get_Connect()
        {
        tt:
            try
            {
                if (File.Exists("App.config"))
                {
                    Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                    //strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=master;" + "integrated security = true;uid=" + sUser + ",pwd=" + sPass + "";
                    strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=master" + ";uid=" + AppC.AppSettings.Settings["uid"].Value.ToString() + ";pwd=" + AppC.AppSettings.Settings["pwd"].Value.ToString() + "";
                }
                SqlConnection cn = new SqlConnection(strConnect);
                cn.Open();
                return cn;
            }
            catch
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Không tìm thấy server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto tt;
            }
        }

        public static SqlConnection connect1()
        {
        tt:
            try
            {
                if (File.Exists("App.config"))
                {
                    Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                    strConnect = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=master;integrated security = true";
                }
                SqlConnection cn = new SqlConnection(strConnect);
                cn.Open();
                return cn;
            }
            catch
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Không tìm thấy server1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto tt;
            }
        }
        SqlConnection con;
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
        public void ChayProc(String spName, List<SqlParameter> sqlParams)
        {
        tt:
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
                DevComponents.DotNetBar.MessageBoxEx.Show("Vui lòng chọn file cho chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }
    }
}
