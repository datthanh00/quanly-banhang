using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class clDaoRestore:Provider
    {
        public void ReStore(clDTO DTO)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@TENFILE", DTO.TENFILE));
            ChayProc("RESTORE_DATABASE", sqlpa);
        }
    }
}
