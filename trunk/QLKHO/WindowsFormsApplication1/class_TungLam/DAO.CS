using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DAO : Provider
    {
        public void insertKhachHang(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new SqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new SqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new SqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new SqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new SqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_add", sqlpa);
        }
        public void updateKhachHang(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new SqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new SqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new SqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new SqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new SqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_update", sqlpa);
        }
        public void INSERTKHUVUC(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_add", sqlpa);
        }
        public void INSERTNHOMHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new SqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
           
            ChayProc("NHOMHANG_add", sqlpa);
        }
        public void UPDATENHOMHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new SqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));

            ChayProc("NHOMHANG_update", sqlpa);
        }
        public void INSERTBOPHAN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new SqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_add", sqlpa);
        }
        public void UPDATEBOPHAN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new SqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_update", sqlpa);
        }
        public void UPDATEKHUVUC(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_update", sqlpa);
        }
        public void INSERTNHACC(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new SqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new SqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_add", sqlpa);
        }
        public void UPDATENHACC(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new SqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new SqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new SqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_update", sqlpa);
        }
        public void INSERTKHO(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new SqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new SqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));                        
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_add", sqlpa);
        }
        public void INSERTDVT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new SqlParameter("@DONVITINH", dto.DONVITINH));
            

            ChayProc("DONVITINH_add", sqlpa);
        }
        public void INSERTTHUE(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new SqlParameter("@SOTHUE", dto.SOTHUE));


            ChayProc("THUE_add", sqlpa);
        }
        public void UPDATETHUE(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new SqlParameter("@SOTHUE", dto.SOTHUE));


            ChayProc("THUE_update", sqlpa);
        }
        public void UPDATEDVT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new SqlParameter("@DONVITINH", dto.DONVITINH));


            ChayProc("DONVITINH_update", sqlpa);
        }
        public void UPDATENHANVIEN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            
            sqlpa.Add(new SqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new SqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_update", sqlpa);
        }
        public void UPDATEQUANLY(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAQL", dto.MAQL));
           
            sqlpa.Add(new SqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new SqlParameter("@PASSWORD", dto.PASSWORD));
            
            sqlpa.Add(new SqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new SqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_update", sqlpa);
        }
        public void INSERTQUANLY(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAQL", dto.MAQL));

            sqlpa.Add(new SqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new SqlParameter("@PASSWORD", dto.PASSWORD));

            sqlpa.Add(new SqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new SqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_add", sqlpa);
        }
      
        public void addMatHang(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@TENMH", dto.TENMH));
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new SqlParameter("@SOLUONGMH", dto.SOLUONGMH));
            sqlpa.Add(new SqlParameter("@HANSUDUNG", dto.HANSUDUNG));
            sqlpa.Add(new SqlParameter("@GIAMUA", dto.GIAMUA));
            sqlpa.Add(new SqlParameter("@GIABAN", dto.GIABAN));
           
            sqlpa.Add(new SqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_add", sqlpa);
        }
        public void UPDATEMATHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@TENMH", dto.TENMH));
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new SqlParameter("@SOLUONGMH", dto.SOLUONGMH));
            sqlpa.Add(new SqlParameter("@HANSUDUNG", dto.HANSUDUNG));
            sqlpa.Add(new SqlParameter("@GIAMUA", dto.GIAMUA));
            sqlpa.Add(new SqlParameter("@GIABAN", dto.GIABAN));
            sqlpa.Add(new SqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_update", sqlpa);
        }
        public void DELELEKHACHHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKH", dto.MAKH));

            
            ChayProc("KHACHHANG_delete", sqlpa);
        }
        public void DELELEBOPHAN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MABP", dto.MABP));


            ChayProc("BOPHAN_delete", sqlpa);
        }
        public void DELELEMATHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));


            ChayProc("MATHANG_delete", sqlpa);
        }
        public void DELELENHOMHANG(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));


            ChayProc("NHOMHANG_delete", sqlpa);
        }
        public void DELELEQUANLY(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAQL", dto.MAQL));


            ChayProc("QUANLY_delete", sqlpa);
        }
        public void DELELETHUE(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));


            ChayProc("THUE_delete", sqlpa);
        }
        public void DELELEKHO(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));


            ChayProc("KHO_delete", sqlpa);
        }
        public void DELELEKV(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKV", dto.MAKV));


            ChayProc("KHUVUC_delete", sqlpa);
        }
        public void DELELENCC(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));


            ChayProc("NHACUNGCAP_delete", sqlpa);
        }
        public void DELELENHANVIEN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));


            ChayProc("NHANVIEN_delete", sqlpa);
        }
        public void DELELEDVT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));


            ChayProc("DONVITINH_delete", sqlpa);
        }
        public void INSERTNHANVIEN(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
           
            sqlpa.Add(new SqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new SqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_add", sqlpa);
        }
        public void UPDATEKHO(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new SqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new SqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_update", sqlpa);
        }
       
        

        //KHO_add
        //SqlConnection cn = new SqlConnection();
       
        public DataTable GETKV()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHUVUC_getall", sqlpa);
        }
        public DataTable GETDVT()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("DONVITINH_getall", sqlpa);
        }
        public DataTable GETMATHANG(string MAMH)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MATH,T3.SOTHUE,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MATH,T2.SOTHUE,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH='"+MAMH+"') AS T1 INNER JOIN THUE AS T2 ON T1.MATH =T2.MATH) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GETTHUE()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("THUE_getall", sqlpa);
        }
        public DataTable GETNHANVIEN()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("NHANVIEN_getall", sqlpa);
        }
        public DataTable GETQUANLY()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("QUANLY_getall", sqlpa);
        }
        public void deleteDVT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            ChayProc("DONVITINH_delete", sqlpa);
        }
        //public void deleteDVT(DTO DTO)
        //{
        //    using (SqlConnection cn = Dataprovider.get_Connect())
        //    {
        //        SqlCommand cmd = new SqlCommand("DONVITINH_delete", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@MADVT", DTO.MADVT);
        //        cmd.ExecuteNonQuery();
        //        cn.Close();
        //    }
        //}
        public DataTable GETBP()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("BOPHAN_getall", sqlpa);
        }
        public DataTable GETNHOMHANG()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHKH()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHKH1()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public DataTable GETDANHSACHNCC()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("NHACUNGCAP_getall", sqlpa);
        }
        public DataTable GETKHO()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHO_getall", sqlpa);
        }
        public DataTable GETMH()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("MATHANG_getall", sqlpa);
        }
        public DataTable GETMMH()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG";
            return getdata(SQL);
        }
        public DataTable GETTINHTRANG()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
        }
        public void INSERTHOADONNHAP(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAHDN", dto.MAHDN));
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            sqlpa.Add(new SqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new SqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

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
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "update HOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= '" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";

            executeNonQuery(SQL);
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAHDN", dto.MAHDN));
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new SqlParameter("@SOLUONGNHAP", dto.SOLUONGNHAP));
            sqlpa.Add(new SqlParameter("@GIANHAP", dto.GIANHAP));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("CHITIETHDN_add", sqlpa);
        }
        public bool ISINSERTCTHOADONNHAP(string MAHDN, string MAMH)
        {
            string SQL = "SELECT MAHDN FROM CHITIETHDN WHERE MAHDN='"+MAHDN+"' AND MAMH='"+MAMH+"'";
            DataTable DT= getdata(SQL);

            int count = DT.Rows.Count;
            if(count>0)
                return false;
            return true;
        }
        public void UPDATECTHOADONNHAP(DTO dto)
        {
            string SQL = "update CHITIETHDN set SOLUONGNHAP=" + dto.SOLUONGNHAP + " ,GIANHAP=" + dto.GIANHAP + ", TINHTRANG= 1 where (MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "')";

            executeNonQuery(SQL);
        }

        public DataTable GETCTHOADONNHAP()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("CHITIETHDN_getall", sqlpa);
        }
        public DataTable GETHOADONNHAP(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            sqlpa.Add(new SqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            return executeNonQuerya("HOADONNHAP_get", sqlpa);
        }
        public DataTable LAYTIENNO(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            sqlpa.Add(new SqlParameter("@MANCC", dto.MANCC));
            return executeNonQuerya("LAYTIENNO", sqlpa);
        }
        public void INSERTHOADONXUAT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAHDX", dto.MAHDX));
            sqlpa.Add(new SqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            sqlpa.Add(new SqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new SqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new SqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("HOADONXUAT_add", sqlpa);
        }
        public void INSERTCTHOADONXUAT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAHDX", dto.MAHDX));
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new SqlParameter("@SOLUONGXUAT", dto.SOLUONGXUAT));
            sqlpa.Add(new SqlParameter("@GIATIEN", dto.GIATIEN));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("CHITIETHDX_add", sqlpa);
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            sqlpa.Add(new SqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            return executeNonQuerya("HOADONXUAT_get", sqlpa);
        }






        
    }
}
