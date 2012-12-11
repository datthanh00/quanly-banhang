using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Class_ManhCuong
{
    class NhapHangDAO : Provider
    {
        public DataTable GetOneNhaCungCap(NhapHangDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            return executeNonQuerya("NHACUNGCAP_get", sqlpa);
        }
        public DataTable GetAllMatHang()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GetAllTHUE()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("THUE_getall", sqlpa);
        }
        public DataTable GetAllNhomHang()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
        }
        public DataTable GetAllDonViTinh()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("DONVITINH_getall", sqlpa);
        }
        public DataTable GetAllCHITIETHDNHAP()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("CHITIETHDN_getall", sqlpa);
        }
    }
}
