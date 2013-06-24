using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
    class clDaoRestore:Provider
    {
        public void ReStore(clDTO DTO)
        {
            string DATABASENAME = "XUAT_NHAPTON";
            string SQL = "RESTORE FILELISTONLY FROM DISK = '" + DTO.TENFILE + "'";
            //executeNonQuery2(SQL);
            DataTable DT= getdata(SQL);

            SQL = "ALTER DATABASE "+DATABASENAME+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            executeNonQuery2(SQL);


            SQL = "RESTORE DATABASE "+DATABASENAME+" FROM DISK = '" + DTO.TENFILE + "'"
            + " WITH MOVE '" + DT.Rows[0]["LogicalName"].ToString() + "' TO '" + DT.Rows[0]["PhysicalName"].ToString() + "',"
            + " MOVE '" + DT.Rows[1]["LogicalName"].ToString() + "' TO '" + DT.Rows[1]["PhysicalName"].ToString() + "'";

            executeNonQuery2(SQL);

            SQL = "ALTER DATABASE " + DATABASENAME + " SET MULTI_USER ";
            executeNonQuery2(SQL);

        }
    }
}
