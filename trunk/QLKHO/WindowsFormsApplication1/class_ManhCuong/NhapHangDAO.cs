﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Class_ManhCuong
{
    class NhapHangDAO : Provider
    {
        public DataTable GetOneNhaCungCap(NhapHangDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            return executeNonQuerya("NHACUNGCAP_get", sqlpa);
        }
        public DataTable GetAllMatHang()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GetAllTHUE()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("THUE_getall", sqlpa);
        }
        public DataTable GetAllNhomHang()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
        }
        public DataTable GetAllDonViTinh()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("DONVITINH_getall", sqlpa);
        }
        public DataTable GetAllCHITIETHDNHAP()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("CHITIETHDN_getall", sqlpa);
        }
    }
}
