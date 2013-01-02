using System;
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
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("MATHANG_getall", sqlpa);

            string SQL = "select 	MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN,MOTA,TINHTRANG from  MATHANG WHERE  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable GetAllTHUE()
        {
           // List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("THUE_getall", sqlpa);

            string SQL = "select 	MATH,SOTHUE from  THUE";
            return getdata(SQL);
        }
        public DataTable GetAllNhomHang()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("NHOMHANG_getall", sqlpa);

            string SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
        }
        public DataTable GetAllDonViTinh()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("DONVITINH_getall", sqlpa);
            string SQL = "select 	MADVT,DONVITINH from  DONVITINH";
            return getdata(SQL);
        }
        public DataTable GetAllCHITIETHDNHAP()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("CHITIETHDN_getall", sqlpa);

            string SQL = "select 	MAHDN,CHITIETHDN.MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG from  CHITIETHDN,MATHANG  WHERE MATHANG.MAMH=CHITIETHDN.MAMH AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
    }
}
