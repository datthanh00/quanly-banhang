using System;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
	class Mysqlchange:Provider
	{
        public MySqlConnection SQLConnection1;
        public MySqlCommand SqlCommand1;
        public MySqlDataReader SqlDataReader1;

        public MySqlConnection sqlKetNoi;
        public MySqlCommand sqlcmdLenhThucThi;
        public MySqlDataReader sqldatareader;
        public MySqlDataAdapter DA;
        //public SqlParameter

        public MySqlCommand SqlCommand(string sqlstring, MySqlConnection SqlCnn)
        {
            
            return new MySqlCommand(sqlstring, SqlCnn);
        }

        public MySqlDataAdapter SqlDataAdapter(string sqlstring, MySqlConnection SqlCnn)
        {
            return new MySqlDataAdapter(sqlstring, SqlCnn);
        }

        public MySqlDataAdapter SqlDataAdapter(MySqlCommand sqlcommand)
        {
            return new MySqlDataAdapter(sqlcommand);
        }
    }
}
