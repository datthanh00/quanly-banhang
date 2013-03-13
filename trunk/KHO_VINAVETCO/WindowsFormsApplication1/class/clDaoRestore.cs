using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    class clDaoRestore:Provider
    {
        public void ReStore(clDTO DTO)
        {
            string SQL = "RESTORE DATABASE [XUAT_NHAPTON] FROM  DISK = N'"+DTO.TENFILE+"'";
            executeNonQuery(SQL);
        }
    }
}
