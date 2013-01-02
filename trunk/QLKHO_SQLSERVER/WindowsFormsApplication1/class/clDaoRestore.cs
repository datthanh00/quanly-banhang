using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    class clDaoRestore:Provider
    {
        public void ReStore(clDTO DTO)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@TENFILE", DTO.TENFILE));
            ChayProc("RESTORE_DATABASE", sqlpa);
        }
    }
}
