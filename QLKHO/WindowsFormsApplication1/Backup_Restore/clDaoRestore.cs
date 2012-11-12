using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class clDaoRestore:clProviderRestore
    {
        public void ReStore(clDTO DTO)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@TENFILE", DTO.TENFILE));
            ChayProc("RESTORE_DATABASE", sqlpa);
        }
    }
}
