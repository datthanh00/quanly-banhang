using System;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
	class Mysqlchange:Provider
	{
        public SqlConnection SQLConnection1;
        public SqlCommand SqlCommand1;
        public SqlDataReader SqlDataReader1;

        public SqlConnection sqlKetNoi;
        public SqlCommand sqlcmdLenhThucThi;
        public SqlDataReader sqldatareader;
        public SqlDataAdapter DA;

        public SqlCommand SqlCommand(string sqlstring,SqlConnection SqlCnn)
        {
            return new SqlCommand(sqlstring, SqlCnn);
        }

        public SqlDataAdapter SqlDataAdapter(string sqlstring, SqlConnection SqlCnn)
        {
            return new SqlDataAdapter(sqlstring, SqlCnn);
        }

        public SqlDataAdapter SqlDataAdapter(SqlCommand sqlcommand)
        {
            return new SqlDataAdapter(sqlcommand);
        }
    }
}
