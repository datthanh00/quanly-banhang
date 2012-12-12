using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class DAO : Provider
    {
        public void insertKhachHang(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new MySqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_add", sqlpa);
        }
        public void updateKhachHang(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new MySqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_update", sqlpa);
        }
        public void INSERTKHUVUC(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_add", sqlpa);
        }
        public void INSERTNHOMHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
           
            ChayProc("NHOMHANG_add", sqlpa);
        }
        public void UPDATENHOMHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));

            ChayProc("NHOMHANG_update", sqlpa);
        }
        public void INSERTBOPHAN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new MySqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_add", sqlpa);
        }
        public void UPDATEBOPHAN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new MySqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_update", sqlpa);
        }
        public void UPDATEKHUVUC(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_update", sqlpa);
        }
        public void INSERTNHACC(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_add", sqlpa);
        }
        public void UPDATENHACC(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_update", sqlpa);
        }
        public void INSERTKHO(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new MySqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new MySqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));                        
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_add", sqlpa);
        }
        public void INSERTDVT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@DONVITINH", dto.DONVITINH));
            

            ChayProc("DONVITINH_add", sqlpa);
        }
        public void INSERTTHUE(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@SOTHUE", dto.SOTHUE));


            ChayProc("THUE_add", sqlpa);
        }
        public void UPDATETHUE(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@SOTHUE", dto.SOTHUE));


            ChayProc("THUE_update", sqlpa);
        }
        public void UPDATEDVT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@DONVITINH", dto.DONVITINH));


            ChayProc("DONVITINH_update", sqlpa);
        }
        public void UPDATENHANVIEN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            
            sqlpa.Add(new MySqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_update", sqlpa);
        }
        public void UPDATEQUANLY(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));
           
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.PASSWORD));
            
            sqlpa.Add(new MySqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_update", sqlpa);
        }
        public void INSERTQUANLY(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));

            sqlpa.Add(new MySqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.PASSWORD));

            sqlpa.Add(new MySqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_add", sqlpa);
        }
      
        public void addMatHang(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@TENMH", dto.TENMH));
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@SOLUONGMH", dto.SOLUONGMH));
            sqlpa.Add(new MySqlParameter("@HANSUDUNG", dto.HANSUDUNG));
            sqlpa.Add(new MySqlParameter("@GIAMUA", dto.GIAMUA));
            sqlpa.Add(new MySqlParameter("@GIABAN", dto.GIABAN));
           
            sqlpa.Add(new MySqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_add", sqlpa);
        }
        public void UPDATEMATHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@TENMH", dto.TENMH));
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@SOLUONGMH", dto.SOLUONGMH));
            sqlpa.Add(new MySqlParameter("@HANSUDUNG", dto.HANSUDUNG));
            sqlpa.Add(new MySqlParameter("@GIAMUA", dto.GIAMUA));
            sqlpa.Add(new MySqlParameter("@GIABAN", dto.GIABAN));
            sqlpa.Add(new MySqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_update", sqlpa);
        }
        public void DELELEKHACHHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));

            
            ChayProc("KHACHHANG_delete", sqlpa);
        }
        public void DELELEBOPHAN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));


            ChayProc("BOPHAN_delete", sqlpa);
        }
        public void DELELEMATHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));


            ChayProc("MATHANG_delete", sqlpa);
        }
        public void DELELENHOMHANG(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));


            ChayProc("NHOMHANG_delete", sqlpa);
        }
        public void DELELEQUANLY(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));


            ChayProc("QUANLY_delete", sqlpa);
        }
        public void DELELETHUE(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));


            ChayProc("THUE_delete", sqlpa);
        }
        public void DELELEKHO(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));


            ChayProc("KHO_delete", sqlpa);
        }
        public void DELELEKV(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));


            ChayProc("KHUVUC_delete", sqlpa);
        }
        public void DELELENCC(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));


            ChayProc("NHACUNGCAP_delete", sqlpa);
        }
        public void DELELENHANVIEN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));


            ChayProc("NHANVIEN_delete", sqlpa);
        }
        public void DELELEDVT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));


            ChayProc("DONVITINH_delete", sqlpa);
        }
        public void INSERTNHANVIEN(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
           
            sqlpa.Add(new MySqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_add", sqlpa);
        }
        public void UPDATEKHO(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new MySqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new MySqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_update", sqlpa);
        }
       
        
       
        public DataTable GETKV()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHUVUC_getall", sqlpa);
        }
        public DataTable GETDVT()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("DONVITINH_getall", sqlpa);
        }
        public DataTable GETMATHANG(string MAMH)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH='"+MAMH+"') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GETTHUE()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("THUE_getall", sqlpa);
        }
        public DataTable GETNHANVIEN()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHANVIEN_getall", sqlpa);
        }
        public DataTable GETQUANLY()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("QUANLY_getall", sqlpa);
        }
        public void deleteDVT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            ChayProc("DONVITINH_delete", sqlpa);
        }

        public DataTable GETBP()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("BOPHAN_getall", sqlpa);
        }
        public DataTable GETNHOMHANG()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHKH()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHKH(string MAKH)
        {
            string SQL = "SELECT * FROM KHACHHANG WHERE MAKH='" + MAKH + "'";
            return GET_DATA(SQL);
        }
        

        public DataTable GETDANHSACHKH1()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHNCC()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHACUNGCAP_getall", sqlpa);
        }
         public DataTable GETDANHSACHNCC(string MANCC)
        {
            string SQL="SELECT * FROM NHACUNGCAP WHERE MANCC='"+MANCC+"'";
            return GET_DATA(SQL);
        }

         public string GETMANCCfromMHDN(string MAHDN)
        {
            DataTable dt;
            string SQL = "SELECT MANCC FROM HOADONNHAP WHERE MAHDN='" + MAHDN + "'";
            dt= GET_DATA(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["MANCC"].ToString();
            return "";
            
        }
         public string GETMAKHfromMHDX(string MAHDX)
         {
             DataTable dt;
             string SQL = "SELECT MAKH FROM HOADONXUAT WHERE MAHDX='" + MAHDX + "'";
             dt = GET_DATA(SQL);
             if (dt.Rows.Count > 0)
                 return dt.Rows[0]["MAKH"].ToString();
             return "";
         }
        public DataTable GETKHO()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHO_getall", sqlpa);
        }
        public DataTable GETMH()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GETMMH()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG";
            return getdata(SQL);
        }
        public DataTable GETDATA()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG";
            return getdata(SQL);
        }
        public DataTable GET_DATA(string SQL)
        {
            return getdata(SQL);
        }

        public DataTable GETTINHTRANG()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public void INSERTHOADONNHAP(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAHDN", dto.MAHDN));
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            sqlpa.Add(new MySqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new MySqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("HOADONNHAP_add", sqlpa);
        }
        public bool isINSERTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT MAHDN FROM HOADONNHAP WHERE MAHDN='" + MAHDN + "'";
            DataTable DT = getdata(SQL);

            int count = DT.Rows.Count;
            if (count > 0)
                return false;
            return true;
        }
        public int maxrowCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT MAHDN FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "'";
            DataTable DT = getdata(SQL);
            return DT.Rows.Count;
        }
        public int maxrowCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT MAHDX FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "'";
            DataTable DT = getdata(SQL);
            return DT.Rows.Count;
        }
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "update HOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= '" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {
            string SQL = "INSERT INTO CHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.GIANHAP + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
        }
        public bool ISINSERTCTHOADONNHAP(string MAHDN, int ID)
        {
            string SQL = "SELECT MAHDN FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "' AND ID=" + ID.ToString();
            DataTable DT= getdata(SQL);
            int count = DT.Rows.Count;
            if(count>0)
                return false;
            return true;
        }
        public void UPDATECTHOADONNHAP(DTO dto)
        {
            string SQL = "update CHITIETHDN set MAMH='" + dto.MAMH + "', SOLUONGNHAP=" + dto.SOLUONGNHAP + " ,GIANHAP=" + dto.GIANHAP + ", TINHTRANG= 1 where (MAHDN='" + dto.MAHDN + "' AND ID=" + dto.ID + ")";
            executeNonQuery(SQL);
        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID)
        {
            string SQL = "DELETE FROM CHITIETHDN where MAHDN='" + MAHDN + "' AND ID="+ID.ToString();
            executeNonQuery(SQL);
        }

        public DataTable GETCTHOADONNHAP()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("CHITIETHDN_getall", sqlpa);
        }

        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGNHAP _SoLuong,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGXUAT _SoLuong,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETHOADONNHAP(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            return executeNonQuerya("HOADONNHAP_get", sqlpa);
        }
        public DataTable LAYTIENNO(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            return executeNonQuerya("LAYTIENNO", sqlpa);
        }
        public void INSERTHOADONXUAT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAHDX", dto.MAHDX));
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            sqlpa.Add(new MySqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new MySqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("HOADONXUAT_add", sqlpa);
        }
        public bool isINSERTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT MAHDX FROM HOADONXUAT WHERE MAHDX='" + MAHDX + "'";
            DataTable DT = getdata(SQL);
            int count = DT.Rows.Count;
            if (count > 0)
                return false;
            return true;
        }
        public void UPDATEHOADONXUAT(DTO dto)
        {
            string SQL = "update HOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= '" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void INSERTCTHOADONXUAT(DTO dto)
        {
            string SQL = "INSERT INTO CHITIETHDX (ID, MAHDX, MAMH,SOLUONGXUAT,GIATIEN,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "'," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
        }
        public bool ISINSERTCTHOADONXUAT(string MAHDX, int ID)
        {
            string SQL = "SELECT MAHDX FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "' AND ID=" +ID.ToString();
            DataTable DT = getdata(SQL);
            int count = DT.Rows.Count;
            if (count > 0)
                return false;
            return true;
        }
        public void UPDATECTHOADONXUAT(DTO dto)
        {
            string SQL = "update CHITIETHDX set MAMH='" + dto.MAMH + "',SOLUONGXUAT=" + dto.SOLUONGXUAT + " ,GIATIEN=" + dto.GIATIEN + ", TINHTRANG= 1 where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);
        }
        public void DELETECTHOADONXUAT(string MAHDX, int ID)
        {
            string SQL = "DELETE FROM CHITIETHDX where MAHDX='" + MAHDX + "' AND ID=" + ID.ToString();
            executeNonQuery(SQL);
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            return executeNonQuerya("HOADONXUAT_get", sqlpa);
        }






        
    }
}
