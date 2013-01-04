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
            string SQL = "	insert into KHACHHANG(MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG)"
            + " values('" + dto.MAKH + "','" + dto.MAKV + "',N'" + dto.TENKH + "','" + dto.SOTAIKHOAN + "',N'" + dto.NGANHANG + "','" + dto.MASOTHUE + "',N'" + dto.DIACHI + "','" + dto.SDT + "','" + dto.FAX + "','" + dto.WEBSITE + "','" + dto.YAHOO + "','" + dto.SKYPE + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

        }
        public void updateKhachHang(DTO dto)
        {
            string SQL = "update KHACHHANG set MAKH='"+ dto.MAKH +"' ,MAKV='"+ dto.MAKV +"',TENKH=N'"+ dto.TENKH +"',SOTAIKHOAN='"+ dto.SOTAIKHOAN +"',NGANHANG=N'"+ dto.NGANHANG +"',MASOTHUE='"+ dto.MASOTHUE +"',DIACHI=N'"+ dto.DIACHI +"',SDT='"+ dto.SDT +"',FAX='"+ dto.FAX +"',WEBSITE='"+ dto.WEBSITE +"',YAHOO='"+ dto.YAHOO +"',SKYPE='"+ dto.SKYPE +"',TINHTRANG='"+ dto.TINHTRANG +"' where 	(MAKH='"+dto.MAKH +"')";
            executeNonQuery(SQL);
        }
        public void INSERTKHUVUC(DTO dto)
        {
            string SQL = "insert into KHUVUC(MAKV,TENKV,GHICHU,TINHTRANG)"
            +" values('"+dto.MAKV+"',N'"+dto.TENKV+"',N'"+dto.GHICHU+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void INSERTNHOMHANG(DTO dto)
        {
            string SQL = "insert into NHOMHANG(MANH,TENNHOMHANG,GHICHU)"
            +" values('"+dto.MANH+"',N'"+dto.TENNHOMHANG+"','"+dto.GHICHU+"')";
            executeNonQuery(SQL);
        }
        public void UPDATENHOMHANG(DTO dto)
        {
            string SQL = "update NHOMHANG set MANH='"+dto.MANH +"' ,TENNHOMHANG=N'"+dto.TENNHOMHANG+"',GHICHU=N'"+dto.GHICHU+"' where MANH='"+dto.MANH+"'";
            executeNonQuery(SQL);
        }
        public void INSERTBOPHAN(DTO dto)
        {
            string SQL = "insert into BOPHAN(MABP,TENBOPHAN,TINHTRANG)"
            +" values('"+dto.MABP+"',N'"+dto.TENBOPHAN+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);

            //PHAN KHO

            SQL = "insert into PHANKHO(MABP,MAKHO) SELECT '" + dto.MABP + "' AS MABP,MAKHO FROM KHO";
            executeNonQuery(SQL);
            //PHAN QUYEN
            SQL = "insert into PHANQUYEN(MABP,MACN) SELECT '" + dto.MABP + "' AS MABP,MACN FROM CHUCNANG";
            executeNonQuery(SQL);

        }
        public void UPDATEBOPHAN(DTO dto)
        {
            string SQL = "update BOPHAN set MABP= '"+dto.MABP+"',TENBOPHAN= N'"+dto.TENBOPHAN+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MABP='"+dto.MABP+"'";
            executeNonQuery(SQL);

        }
        public void UPDATEKHUVUC(DTO dto)
        {
            string SQL = "update KHUVUC set MAKV= '"+dto.MAKV+"',TENKV= N'"+dto.TENKV+"',GHICHU= N'"+dto.GHICHU+"',TINHTRANG= '"+dto.TINHTRANG+"' where MAKV='"+dto.MAKV+"'";
            executeNonQuery(SQL);
        }
        public void INSERTNHACC(DTO dto)
        {
            string SQL = "insert into NHACUNGCAP(MANCC,MAKV,MAKHO,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG)"
            +" values('"+dto.MANCC+"','"+dto.MAKV+"','"+PublicVariable.MAKHO+"',N'"+dto.TENNCC+"',N'"+dto.DIACHI+"','"+dto.MASOTHUE+"','"+dto.SOTAIKHOAN+"',N'"+dto.NGANHANG+"','"+dto.SDT+"','"+dto.EMAIL+"','"+dto.FAX+"','"+dto.WEBSITE+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATENHACC(DTO dto)
        {
            string SQL = "update NHACUNGCAP set MANCC= '"+dto.MANCC+"',MAKV= '"+dto.MAKV+"',TENNCC= N'"+dto.TENNCC+"',DIACHI= N'"+dto.DIACHI+"',MASOTHUE= '"+dto.MASOTHUE+"',SOTAIKHOAN= '"+dto.SOTAIKHOAN+"',NGANHANG= N'"+dto.NGANHANG+"',SDT= '"+dto.SDT+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"', WEBSITE= '"+dto.WEBSITE+"',TINHTRANG= '"+dto.TINHTRANG+"' where MANCC='"+dto.MANCC+"'";
            executeNonQuery(SQL);
        }
        public void INSERTKHO(DTO dto)
        {
            string SQL = "insert into KHO(MAKHO,MANV,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG)"
            + " values('" + dto.MAKHO + "','" + dto.MANV + "',N'" + dto.TENKHO + "',N'" + dto.DIACHI + "','" + dto.SDTB + "','" + dto.DTDD + "',N'" + dto.NGUOILH + "','" + dto.FAX + "','" + dto.GHICHU + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

            SQL = "insert into PHANKHO(MABP,MAKHO) SELECT  MABP,'" + dto.MAKHO + "' AS MAKHO FROM BOPHAN";
            executeNonQuery(SQL);
        }
        public void INSERTDVT(DTO dto)
        {
            string SQL = "insert into DONVITINH(MADVT,DONVITINH) values('"+dto.MADVT+"','"+dto.DONVITINH+"')";
            executeNonQuery(SQL);
        }
        public void INSERTTHUE(DTO dto)
        {
            string SQL = "insert into THUE(MATH,SOTHUE) values('"+dto.MATH+"','"+dto.SOTHUE+"')";
            executeNonQuery(SQL);
        }
        public void UPDATETHUE(DTO dto)
        {
            string SQL = "update THUE set MATH= '"+dto.MATH+"',SOTHUE= '"+dto.SOTHUE+"' where 	MATH='"+dto.MATH+"'";
            executeNonQuery(SQL);
        }
        public void UPDATEDVT(DTO dto)
        {
            string SQL = "update DONVITINH set MADVT= '"+dto.MADVT+"',DONVITINH= '"+dto.DONVITINH+"' where 	MADVT='"+dto.MADVT+"'";
            executeNonQuery(SQL);
        }
        public void UPDATENHANVIEN(DTO dto)
        {
            string SQL = "update NHANVIEN set MANV= '" + dto.MANV + "',TENNV= N'" + dto.TENNV + "',DIACHI= N'" + dto.DIACHI + "',NGAYSINH= '" + dto.NGAYSINH + "',SCMND= '" + dto.SCMND + "',SDT= '" + dto.SDT + "',TINHTRANG= '" + dto.TINHTRANG + "' where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
        public void UPDATEQUANLY(DTO dto)
        {
            string SQL = "update QUANLY set MAQL= '"+dto.MAQL+"',USERNAME= '"+dto.USERNAME+"',PASSWORD= '"+dto.PASSWORD+"',TENQL= '"+dto.TENQL+"',DIACHI= '"+dto.DIACHI+"',NGAYSINH= '"+ dto.NGAYSINH+"',SCMND= '"+dto.SCMND+"',SDT= '"+dto.SDT+"',TINHTRANG= '"+dto.TINHTRANG+"' where MAQL='"+dto.MAQL+"'";
            executeNonQuery(SQL);
        }
        public void INSERTQUANLY(DTO dto)
        {
            string SQL = "insert into QUANLY(MAQL,USERNAME,PASSWORD,TENQL,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG)"
            +" values('"+dto.MAQL+"','"+dto.USERNAME+"','"+dto.PASSWORD+"',N'"+dto.TENQL+"',N'"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
      
        public void addMatHang(DTO dto)
        {
            string SQL = "insert into MATHANG(MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN, MOTA,TINHTRANG)"
            +" values('"+dto.MAMH+"','"+dto.MATH+"','"+dto.MANH+"','"+dto.MAKHO+"',N'"+dto.TENMH+"','"+dto.MADVT+"',"+dto.SOLUONGMH+",'"+dto.HANSUDUNG+"',"+dto.GIAMUA+","+dto.GIABAN+", N'"+dto.MOTA+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);

            SQL = "INSERT TONKHO(NGAY,MAMH,TONDAU,NHAP,XUAT,MAID)" + " VALUES (convert(varchar,getDate(),101),'" + dto.MAMH + "','" + dto.SOLUONGMH + "', 0,0,0)";
            executeNonQuery(SQL);
        }
        public void UPDATEMATHANG(DTO dto)
        {

            string SQL = "update MATHANG set MAMH= '"+dto.MAMH+"',MATH= '"+dto.MATH+"',MANH= '"+dto.MANH+"',MAKHO= '"+dto.MAKHO+"',TENMH= N'"+dto.TENMH+"',MADVT= '"+dto.MADVT+"',SOLUONGMH= "+dto.SOLUONGMH+",HANSUDUNG= '"+dto.HANSUDUNG+"',GIAMUA= "+dto.GIAMUA+",GIABAN= "+dto.GIABAN+", MOTA= N'"+dto.MOTA+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAMH='"+dto.MAMH+"'";
            executeNonQuery(SQL);
        }
        public void DELELEKHACHHANG(DTO dto)
        {

            string SQL = "delete from KHACHHANG where 	MAKH='"+dto.MAKH+"'";
            executeNonQuery(SQL);
        }

        public Boolean isDELELEKHACHHANG(DTO dto)
        {
            string SQL = "select TOP 1 makh from hoadonxuat where 	MAKH='" + dto.MAKH + "'";
            DataTable dt= getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;
            SQL = "select TOP 1 makh from trahoadonxuat where 	MAKH='" + dto.MAKH + "'";
            dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        public void DELELEBOPHAN(DTO dto)
        {
            string SQL = "delete from BOPHAN where 	MABP='" + dto.MABP + "'";
            executeNonQuery(SQL);
        }
        public Boolean isDELELEBOPHAN(DTO dto)
        {
            string SQL = "select TOP 1 mabp from nhanvien where 	MABP='" + dto.MABP + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELEMATHANG(DTO dto)
        {
            string SQL = "delete from MATHANG where 	MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
        }
        public Boolean isDELELEMATHANG(DTO dto)
        {
            string SQL = "select TOP 1 mamh from chitiethdn where 	MAMH='" + dto.MAMH + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            SQL = "select TOP 1 mamh from chitiethdx where 	MAMH='" + dto.MAMH + "' ";
            dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            SQL = "select TOP 1 mamh from trachitiethdn where 	MAMH='" + dto.MAMH + "'";
             dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            SQL = "select TOP 1 mamh from trachitiethdx where 	MAMH='" + dto.MAMH + "' ";
            dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELENHOMHANG(DTO dto)
        {
            string SQL = "delete from NHOMHANG where 	MANH='" + dto.MANH + "'";
            executeNonQuery(SQL);
        }
        public Boolean isDELELENHOMHANG(DTO dto)
        {
            string SQL = "select TOP 1 manh from mathang where 	MANH='" + dto.MANH + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELEQUANLY(DTO dto)
        {
            string SQL = "delete from QUANLY where 	MAQL='" + dto.MAQL + "'";
            executeNonQuery(SQL);
        }
        public void DELELETHUE(DTO dto)
        {
            string SQL = "delete from THUE where 	MATH='" + dto.MATH + "'";
            executeNonQuery(SQL);
        }
        public Boolean isDELELETHUE(DTO dto)
        {
            string SQL = "select TOP 1 math from mathang where 	MATH='" + dto.MATH + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }

        public void DELELEKHO(DTO dto)
        {
            string SQL = "delete from KHO where 	MAKHO='" + dto.MAKHO + "'";
            executeNonQuery(SQL);
            SQL = "delete from PHANKHO where 	MAKHO='" + dto.MAKHO + "'";
            executeNonQuery(SQL);
        }

        public Boolean isDELELEKHO(DTO dto)
        {
            string SQL = "select TOP 1 makho from mathang where 	MAKHO='" + dto.MAKHO + "' ";
            DataTable dt=getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELEKV(DTO dto)
        {
            string SQL = "delete from KHUVUC where 	MAKV='" + dto.MAKV + "'";
            executeNonQuery(SQL);
        }

        public Boolean isDELELEKV(DTO dto)
        {
            string SQL = "select TOP 1 makv from  khachhang where 	MAKV='" + dto.MAKV + "' ";
            DataTable dt=getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;
            SQL = "select TOP 1 makv from  nhacungcap where 	MAKV='" + dto.MAKV + "' ";
            dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELENCC(DTO dto)
        {
            string SQL = "delete from NHACUNGCAP where 	MANCC='" + dto.MANCC + "'";
            executeNonQuery(SQL); 
        }
        public Boolean isDELELENCC(DTO dto)
        {
            string SQL = "select TOP 1 mancc from hoadonnhap where 	MANCC='" + dto.MANCC + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;
            SQL = "select TOP 1 mancc from trahoadonnhap where 	MANCC='" + dto.MANCC + "' ";
            dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELENHANVIEN(DTO dto)
        {
            string SQL = "delete from NHANVIEN where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL); 
        }
        public Boolean isDELELENHANVIEN(DTO dto)
        {
            string SQL = "select TOP 1 manv from hoadonnhap where 	MANV='" + dto.MANV + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

             SQL = "select TOP 1 manv from hoadonxuat where 	MANV='" + dto.MANV + "' ";
             dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

             SQL = "select TOP 1 manv from trahoadonnhap where 	MANV='" + dto.MANV + "' ";
             dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

             SQL = "select TOP 1 manv from trahoadonxuat where 	MANV='" + dto.MANV + "' ";
             dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void DELELEDVT(DTO dto)
        {
            string SQL = "delete from DONVITINH where 	MADVT='" + dto.MADVT + "'";
            executeNonQuery(SQL);
        }
        public Boolean isDELELEDVT(DTO dto)
        {
            string SQL = "select  TOP 1 madvt from mathang where 	MADVT='" + dto.MADVT + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            return true;
        }
        public void INSERTNHANVIEN(DTO dto)
        {
            string SQL = "insert into NHANVIEN(MANV,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG)"
            +" values('"+dto.MANV+"','"+dto.TENNV+"','"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATEKHO(DTO dto)
        {
            string SQL = "update KHO set MAKHO= '"+dto.MAKHO+"',MANV= '"+dto.MANV+"',TENKHO= N'"+dto.TENKHO+"',DIACHI= N'"+dto.DIACHI+"',SDTB= '"+dto.SDTB+"',DTDD= '"+dto.DTDD+"',NGUOILH= N'"+dto.NGUOILH+"',FAX= '"+dto.FAX+"',GHICHU= '"+dto.GHICHU+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAKHO='"+dto.MAKHO+"'";
            executeNonQuery(SQL);
        }
       
        
       
        public DataTable GETKV()
        {
            string SQL = "select 	MAKV,TENKV,GHICHU,TINHTRANG from  KHUVUC";
            return GET_DATA(SQL);
        }

        public string GETTENKHUVUC(string MAKV)
        {
            string SQL = "select TENKV from  KHUVUC where MAKV='" + MAKV + "'";
            DataTable dt= getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TENKV"].ToString();
            return "";
        }
        public DataTable GETDVT()
        {
            string SQL = "select 	MADVT,DONVITINH from  DONVITINH";
            return GET_DATA(SQL);
        }
        public DataTable GETMATHANG(string MAMH)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH='"+MAMH+"') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG()
        {
            string SQL = "select 	MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,convert(varchar,HANSUDUNG,103),GIAMUA,GIABAN,MOTA,TINHTRANG from  MATHANG WHERE MAKHO='"+PublicVariable.MAKHO+"' ";
            return GET_DATA(SQL);
        }
        public DataTable GETTHUE()
        {
            string SQL = "select 	MATH,SOTHUE from  THUE";
            return GET_DATA(SQL);
        }
        public DataTable GETNHANVIEN()
        {
            string SQL = "select 	MANV,TENNV,DIACHI,convert(varchar,NGAYSINH,103)as NGAYSINH ,SCMND,SDT,TINHTRANG from  NHANVIEN";
            return GET_DATA(SQL);
        }
        public DataTable GETQUANLY()
        {
            string SQL = "select 	MAQL,USERNAME,PASSWORD,TENQL,DIACHI,convert(varchar,NGAYSINH,103),SCMND,SDT,TINHTRANG from  QUANLY";
            return GET_DATA(SQL);
        }

        public DataTable GETBP()
        {
            string SQL = "select 	MABP,TENBOPHAN,TINHTRANG from  BOPHAN";
            return GET_DATA(SQL);
        }
        public DataTable GETNHOMHANG()
        {
            string SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH()
        {
            string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH(string MAKH)
        {
            string SQL = "SELECT * FROM KHACHHANG WHERE MAKH='" + MAKH + "'";
            return GET_DATA(SQL);

        }
        

        public DataTable GETDANHSACHKH1()
        {

            string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHNCC()
        {
            string SQL = "select 	MANCC,MAKV,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG from  NHACUNGCAP";
            return GET_DATA(SQL);

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
         public string GETMANCCfromtraMHDN(string MAHDN)
         {
             DataTable dt;
             string SQL = "SELECT MANCC FROM traHOADONNHAP WHERE MAHDN='" + MAHDN + "'";
             dt = GET_DATA(SQL);
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
         public string GETMAKHfromtraMHDX(string MAHDX)
         {
             DataTable dt;
             string SQL = "SELECT MAKH FROM traHOADONXUAT WHERE MAHDX='" + MAHDX + "'";
             dt = GET_DATA(SQL);
             if (dt.Rows.Count > 0)
                 return dt.Rows[0]["MAKH"].ToString();
             return "";
         }
        public DataTable GETKHO()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHO_getall", sqlpa);
             */
            string SQL = "select 	MAKHO,MANV,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG from  KHO";
            return GET_DATA(SQL);

        }

        public DataTable GETMMH()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG where MAKHO='"+PublicVariable.MAKHO+"'";
            return getdata(SQL);
        }
        public DataTable GETMMHN(String MAHDN)
        {
            string SQL = "SELECT mathang.MAMH,TENMH,SOLUONGNHAP FROM MATHANG, chitiethdn where mathang.mamh=chitiethdn.mamh  and MAHDN='" + MAHDN + "' and MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable GETMMHX(String MAHDX)
        {
            string SQL = "SELECT mathang.MAMH,TENMH,SOLUONGXUAT FROM MATHANG, chitiethdx where mathang.mamh=chitiethdx.mamh and MAHDX='" + MAHDX + "'  and MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }

        public DataTable GET_DATA(string SQL)
        {
            return getdata(SQL);
        }

        public DataTable GETTINHTRANG()
        {
             string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG";
            return GET_DATA(SQL);
        }
        public void INSERTtraHOADONNHAP(DTO dto)
        {
            string SQL = "insert into traHOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "',convert(varchar,getDate(),101)," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
        }
        public void INSERTHOADONNHAP(DTO dto)
        {
            string SQL = "insert into HOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "',convert(varchar,getDate(),101)," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
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
        public bool isINSERTtraHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT MAHDN FROM TRAHOADONNHAP WHERE MAHDN='" + MAHDN + "'";
            DataTable DT = getdata(SQL);

            int count = DT.Rows.Count;
            if (count > 0)
                return false;
            return true;
        }
        public int maxrowtraCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT MAHDN FROM traCHITIETHDN WHERE MAHDN='" + MAHDN + "'";
            DataTable DT = getdata(SQL);
            return DT.Rows.Count;
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
        public int maxrowtraCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT MAHDX FROM traCHITIETHDX WHERE MAHDX='" + MAHDX + "'";
            DataTable DT = getdata(SQL);
            return DT.Rows.Count;
        }
        public void UPDATEtraHOADONNHAP(DTO dto)
        {
            string SQL = "update traHOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "update HOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {

            string  SQL = "INSERT INTO CHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.GIANHAP + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

            SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            int tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =" + dto.SOLUONGNHAP.ToString() + " + SOLUONGMH WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
			//ymd
            SQL = "SELECT convert(varchar,NGAYNHAP,101) FROM HOADONNHAP where MAHDN = '" + dto.MAHDN + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();

            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDN, dto.MAMH, ngay, dto.SOLUONGNHAP.ToString(), "0");
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, ngay, tondau, dto.SOLUONGNHAP.ToString(), "0");
            }
        }


        public void INSERTtraCTHOADONNHAP(DTO dto)
        {

            String SQL = "INSERT INTO traCHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.GIANHAP + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

           /* SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            int tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH -" + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYNHAP,101) FROM traHOADONNHAP where MAHDN = '" + dto.MAHDN + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();
            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDN, dto.MAMH, ngay, "0", dto.SOLUONGNHAP.ToString());
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, ngay, tondau, "0", dto.SOLUONGNHAP.ToString());
            }
            */
        
        }

        public void INSERT_TONKHO(string ID,string MAHD, string MAMH,string NGAY,int TONDAU, string NHAP, string XUAT)
        {
           string SQL = "select  TOP 1 STT from tonkho where MAHD='" + MAHD + "' ";
           DataTable dt = getdata(SQL);
           string STT = "0";
           if (dt.Rows.Count > 0)
           {
               STT = dt.Rows[0][0].ToString();
           }
           else
           {
               SQL = "select MAX(STT) from tonkho";
               dt = getdata(SQL);
               if (dt.Rows[0][0].ToString() != "")
               {
                   STT = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
               }
               else
               {
                   STT = "1";
               }
           }
           int toncuoi = TONDAU + Convert.ToInt32(NHAP) - Convert.ToInt32(XUAT);
           SQL = "INSERT TONKHO(STT,ID,MAHD,MAMH,NGAY,TONDAU,NHAP,XUAT,TONCUOI)"
                  + " VALUES (" + STT + "," + ID + ",'" + MAHD + "','" + MAMH + "','" + NGAY + "', " + TONDAU.ToString() + "," + NHAP + "," + XUAT + "," + toncuoi.ToString() + ")";
           executeNonQuery(SQL);
            
        }
        public void INSERT_TONKHO2(string ID, string MAHD, string MAMH, string NGAY, string NHAP, string XUAT)
        {
            string SQL = "select TOP 1 STT from tonkho where MAHD='" + MAHD + "' ";
            DataTable dt = getdata(SQL);
            string STT = "0";
            if (dt.Rows.Count > 0)
            {
                STT = dt.Rows[0][0].ToString();

                SQL = "select * from tonkho where STT=(select max(STT) from tonkho where MAMH='" + MAMH + "' AND (STT<" + STT + " OR  STT=" + STT + ")) ORDER BY ID DESC ";
                dt = getdata(SQL);
                string TONDAU = "0";
                if (dt.Rows.Count > 0)
                {
                    TONDAU = dt.Rows[0]["toncuoi"].ToString();
                }
                else
                {
                    SQL = "select * from tonkho where STT=(select MIN(STT) from tonkho where MAMH='" + MAMH + "') ORDER BY ID DESC  ";
                    dt = getdata(SQL);
                    if (dt.Rows.Count > 0)
                    {
                        TONDAU = dt.Rows[0]["tondau"].ToString();
                    }
                    else
                    {
                        SQL = "select soluongmh from mathang  where MAMH='" + MAMH + "'";
                        dt = getdata(SQL);
                        if (dt.Rows.Count > 0)
                        {
                            TONDAU = dt.Rows[0]["soluongmh"].ToString();
                        }
                    }

                }

                int toncuoi = Convert.ToInt32(TONDAU) + Convert.ToInt32(NHAP) - Convert.ToInt32(XUAT);
                SQL = "INSERT TONKHO(STT,ID,MAHD,MAMH,NGAY,TONDAU,NHAP,XUAT,TONCUOI)"
                       + " VALUES (" + STT + "," + ID + ",'" + MAHD + "','" + MAMH + "','" + NGAY + "', " + TONDAU + "," + NHAP + "," + XUAT + "," + toncuoi.ToString() + ")";
                executeNonQuery(SQL);


                //update cac dong sau
                SQL = "UPDATE TONKHO SET  tondau=tondau+" + NHAP + "-" + XUAT + ",  toncuoi=toncuoi+" + NHAP + "-" + XUAT + "  WHERE STT>" + STT + " and MAMH='" + MAMH + "'";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  tondau=tondau+" + NHAP + "-" + XUAT + ",  toncuoi=toncuoi+" + NHAP + "-" + XUAT + "  WHERE STT=" + STT + " and MAMH='" + MAMH + "' and ID>" + ID;
                executeNonQuery(SQL);
            }
            
            

        }
        public void UPDATE_TONKHO(string ID, string MAHD, string MAMH, string NHAP, string XUAT)
        {
            string SQL = "select nhap,xuat,STT from tonkho where MAHD='" + MAHD + "' AND ID='" + ID + "' ";
            DataTable dt = getdata(SQL);
            string STT = "1";
            string SUANHAP = "0";
            string SUAXUAT = "0";
            if (dt.Rows.Count > 0)
            {
                STT = dt.Rows[0]["STT"].ToString();
                SUANHAP = (Convert.ToInt32(NHAP)- Convert.ToInt32(dt.Rows[0]["nhap"].ToString())).ToString();
                SUAXUAT = (Convert.ToInt32(XUAT)- Convert.ToInt32(dt.Rows[0]["xuat"].ToString())).ToString();
                if (SUANHAP != "0")
                {
                    SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + MAMH + "'," + SUANHAP + ",'THEM','')";
                    executeNonQuery(SQL);
                }
                else
                {
                    SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + MAMH + "'," + SUAXUAT + ",'GIAM','')";
                    executeNonQuery(SQL);
                }
            }

            SQL = "UPDATE TONKHO SET  toncuoi=toncuoi+" + SUANHAP + "-" + SUAXUAT + " ,NHAP=" + NHAP + ",XUAT=" + XUAT + "  WHERE STT=" + STT + " and id= " + ID ;
            executeNonQuery(SQL);

    
            SQL = "UPDATE TONKHO SET  tondau=tondau+" + SUANHAP + "-" + SUAXUAT + ",  toncuoi=toncuoi+" + SUANHAP + "-" + SUAXUAT + "  WHERE STT>" + STT + " and MAMH='" + MAMH + "'";
            executeNonQuery(SQL);

            SQL = "UPDATE TONKHO SET  tondau=tondau+" + SUANHAP + "-" + SUAXUAT + ",  toncuoi=toncuoi+" + SUANHAP + "-" + SUAXUAT + "  WHERE STT=" + STT + " and MAMH='" + MAMH + "' and ID>" + ID;
            executeNonQuery(SQL);
        }

        public void DELETE_TONKHO(string ID, string MAHD)
        {
            string SQL = "select nhap,xuat,STT,mamh from tonkho where mahd='"+MAHD+"' and id="+ID;
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
            {
                

                SQL = "delete from tonkho where STT=" + dt.Rows[0]["STT"].ToString()+" and ID="+ID;
                executeNonQuery(SQL);

                string CHENHLECH = (Convert.ToInt32(dt.Rows[0]["NHAP"].ToString()) - Convert.ToInt32(dt.Rows[0]["XUAT"].ToString())).ToString();

                SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + dt.Rows[0]["MAMH"].ToString() + "',"+CHENHLECH+",'DELETE','')";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  TONDAU=TONDAU- " + CHENHLECH + ", toncuoi=toncuoi-" + CHENHLECH + "  WHERE STT>" + dt.Rows[0]["STT"].ToString() + " and MAMH='" + dt.Rows[0]["MAMH"].ToString() + "' ";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  TONDAU=TONDAU- " + CHENHLECH + ", toncuoi=toncuoi-" + CHENHLECH + "  WHERE STT=" + dt.Rows[0]["STT"].ToString() + " and MAMH='" + dt.Rows[0]["MAMH"].ToString() + "' and ID>" + ID;
                executeNonQuery(SQL);

                SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH -" + CHENHLECH + "  WHERE MAMH='" + dt.Rows[0]["MAMH"].ToString() + "'";
                executeNonQuery(SQL);

            }
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
        public void UPDATEtraCTHOADONNHAP(DTO dto)
        {

            string SQL = "select SOLUONGNHAP from traCHITIETHDN where (MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "')";
            DataTable dt = getdata(SQL);
            int sluongnhapcu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongnhapcu = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            SQL = "update traCHITIETHDN set SOLUONGNHAP=" + dto.SOLUONGNHAP + ",GIANHAP=" + dto.GIANHAP + ", TINHTRANG= 1 where (MAHDN='" + dto.MAHDN + "' AND ID=" + dto.ID + ")";
            executeNonQuery(SQL);

          

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH-" + (dto.SOLUONGNHAP - sluongnhapcu).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            int chinhsuanhap = dto.SOLUONGNHAP - sluongnhapcu;

            if (chinhsuanhap != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, "0", dto.SOLUONGNHAP.ToString());
            }

        }

        public void UPDATECTHOADONNHAP(DTO dto)
        {

            string  SQL = "select SOLUONGNHAP from CHITIETHDN where (MAHDN='" + dto.MAHDN + "' AND ID='" + dto.ID + "')";
            DataTable dt = getdata(SQL);
            int sluongnhapcu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongnhapcu = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
          

            SQL = "update CHITIETHDN set SOLUONGNHAP=" + dto.SOLUONGNHAP + "  ,GIANHAP=" + dto.GIANHAP + " where (MAHDN='" + dto.MAHDN + "' AND ID=" + dto.ID + ")";
            executeNonQuery(SQL);

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =" + (dto.SOLUONGNHAP- sluongnhapcu).ToString() + " + SOLUONGMH WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            int chinhsuanhap = dto.SOLUONGNHAP - sluongnhapcu;

            if (chinhsuanhap != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, dto.SOLUONGNHAP.ToString(), "0");
            }

        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID)
        {
            DELETE_TONKHO(ID.ToString(),MAHDN);


            string SQL = "DELETE FROM CHITIETHDN where MAHDN='" + MAHDN + "' AND ID="+ID.ToString();
            executeNonQuery(SQL);

            
        }
        public void DELETEtraCTHOADONNHAP(string MAHDN, int ID)
        {
            DELETE_TONKHO(ID.ToString(), MAHDN);
            string SQL = "DELETE FROM traCHITIETHDN where MAHDN='" + MAHDN + "' AND ID=" + ID.ToString();
            executeNonQuery(SQL);
        }
 

        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT ID,T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGNHAP _SoLuong,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETtraCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT ID,T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGNHAP _SoLuong,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM traCHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from traCHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT ID,T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGXUAT _SoLuong,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETtraCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT ID,T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGXUAT _SoLuong,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM traCHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from traCHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETHOADONNHAP(DTO dto)
        {
            string SQL = "select MAHDN,MANCC,MANV,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  HOADONNHAP where NGAYNHAP='" + dto.NGAYNHAP + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable GETtraHOADONNHAP(DTO dto)
        {
            string SQL = "select MAHDN,MANCC,MANV,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  traHOADONNHAP where NGAYNHAP='" + dto.NGAYNHAP + "'  AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable LAYTIENNO(DTO dto)
        {
            string SQL = "SELECT * FROM(select (sum(TIENPHAITRA) - sum(TIENDATRA))as 'TIENNO' from HOADONNHAP where MANCC ='" + dto.MANCC + "')AS T1";
            return getdata(SQL);

        }
        public DataTable LAYTIENNOKH(DTO dto)
        {
            string SQL = "SELECT * FROM(select (sum(TIENPHAITRA) - sum(TIENDATRA))as 'TIENNO' from HOADONXUAT where MAKH ='" + dto.MAKH + "')AS T1";
            return getdata(SQL);

        }
        public void INSERTHOADONXUAT(DTO dto)
        {
            string SQL = "insert into HOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            + " values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','"+PublicVariable.MAKHO+"',convert(varchar,getDate(),101),'" + dto.TIENPHAITRA + "','" + dto.TIENDATRA + "','" + dto.GHICHU + "',N'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
        }
        public void INSERTtraHOADONXUAT(DTO dto)
        {
            string SQL = "insert into traHOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            + " values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "',convert(varchar,getDate(),101),'" + dto.TIENPHAITRA + "','" + dto.TIENDATRA + "','" + dto.GHICHU + "',N'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
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
        public bool isINSERTtraHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT MAHDX FROM traHOADONXUAT WHERE MAHDX='" + MAHDX + "'";
            DataTable DT = getdata(SQL);
            int count = DT.Rows.Count;
            if (count > 0)
                return false;
            return true;
        }
        public void UPDATEHOADONXUAT(DTO dto)
        {
            string SQL = "update HOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void UPDATEtraHOADONXUAT(DTO dto)
        {
            string SQL = "update traHOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void INSERTCTHOADONXUAT(DTO dto)
        {
            string SQL = "select soluongmh from mathang where MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);

            if (dt.Rows.Count > 0)
            {
                int slton = Convert.ToInt32(dt.Rows[0]["soluongmh"].ToString());
                if (slton < dto.SOLUONGXUAT)
                {
                    System.Windows.Forms.MessageBox.Show("Không đủ số lượng để xuất");
                    return;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Chưa có mã hàng này");
                return;
            }
            


            SQL = "INSERT INTO CHITIETHDX (ID, MAHDX, MAMH,SOLUONGXUAT,GIATIEN,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "'," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

            SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            dt = getdata(SQL);
            int tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH-" + dto.SOLUONGXUAT + " WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYXUAT,101) FROM HOADONXUAT where MAHDX = '" + dto.MAHDX + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();

            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDX, dto.MAMH, ngay, "0", dto.SOLUONGXUAT.ToString());
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, ngay, tondau, "0", dto.SOLUONGXUAT.ToString());
            }
        
        
        }
        public void INSERTtraCTHOADONXUAT(DTO dto)
        {
            string SQL = "select soluongmh from mathang where MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);

            if (dt.Rows.Count > 0)
            {
                int slton = Convert.ToInt32(dt.Rows[0]["soluongmh"].ToString());
                if (slton < dto.SOLUONGXUAT)
                {
                    System.Windows.Forms.MessageBox.Show("Không đủ số lượng để xuất");
                    return;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Chưa có mã hàng này");
                return;
            }

            

            SQL = "INSERT INTO traCHITIETHDX (ID, MAHDX, MAMH,SOLUONGXUAT,GIATIEN,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "'," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

          /*  SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            dt = getdata(SQL);
            int tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
   

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH+" + dto.SOLUONGXUAT + " WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYXUAT,101) FROM traHOADONXUAT where MAHDX = '" + dto.MAHDX + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();

            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDX, dto.MAMH, ngay, dto.SOLUONGXUAT.ToString(), "0");
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, ngay, tondau, dto.SOLUONGXUAT.ToString(), "0");
            }
        */

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
            string SQL = "select soluongmh from mathang where MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);

            if (dt.Rows.Count > 0)
            {
                int slton = Convert.ToInt32(dt.Rows[0]["soluongmh"].ToString());
                SQL = "select SOLUONGXUAT from CHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
                dt = getdata(SQL);
                int slxuatcu = 0;
                
                if (dt.Rows.Count > 0)
                {
                    slxuatcu = Convert.ToInt32(dt.Rows[0]["SOLUONGXUAT"].ToString());
                    
                }

                if (slton < (dto.SOLUONGXUAT - slxuatcu))
                {
                    System.Windows.Forms.MessageBox.Show("Không đủ số lượng để xuất");
                    return;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Chưa có mã hàng này");
                return;
            }


            SQL = "select SOLUONGXUAT from CHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "')";
            dt = getdata(SQL);
            int sluongxuatcu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongxuatcu = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
           
            SQL = "update CHITIETHDX set SOLUONGXUAT=" + dto.SOLUONGXUAT + "   ,GIATIEN=" + dto.GIATIEN + " where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);

    

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH -" + (dto.SOLUONGXUAT - sluongxuatcu).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            int chinhsuaxuat = dto.SOLUONGXUAT - sluongxuatcu;

            if (chinhsuaxuat != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, "0", dto.SOLUONGXUAT.ToString());
            }
        }
        public void UPDATEtraCTHOADONXUAT(DTO dto)
        {
            string SQL = "select soluongmh from mathang where MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);

            if (dt.Rows.Count > 0)
            {
                int slton = Convert.ToInt32(dt.Rows[0]["soluongmh"].ToString());
                SQL = "select SOLUONGXUAT from traCHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
                dt = getdata(SQL);
                int slxuatcu = 0;
                if (dt.Rows.Count > 0)
                {
                    slxuatcu = Convert.ToInt32(dt.Rows[0]["SOLUONGXUAT"].ToString());
                }

                if (slton < (dto.SOLUONGXUAT - slxuatcu))
                {
                    System.Windows.Forms.MessageBox.Show("Không đủ số lượng để xuất");
                    return;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Chưa có mã hàng này");
                return;
            }

            SQL = "select SOLUONGXUAT from traCHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "')";
            dt = getdata(SQL);
            int sluongxuatcu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongxuatcu = Convert.ToInt32(dt.Rows[0][0].ToString());
            }

            SQL = "update traCHITIETHDX set SOLUONGXUAT=" + dto.SOLUONGXUAT + "   ,GIATIEN=" + dto.GIATIEN + " where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);



            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH -" + (dto.SOLUONGXUAT - sluongxuatcu).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            int chinhsuaxuat = dto.SOLUONGXUAT - sluongxuatcu;

            if (chinhsuaxuat != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.SOLUONGXUAT.ToString(), "0");
            }
        }
        public void DELETECTHOADONXUAT(string MAHDX, int ID)
        {
            DELETE_TONKHO(ID.ToString(), MAHDX);

            string SQL = "DELETE FROM CHITIETHDX where MAHDX='" + MAHDX + "' AND ID=" + ID.ToString();
            executeNonQuery(SQL);
        }
        public void DELETEtraCTHOADONXUAT(string MAHDX, int ID)
        {
            DELETE_TONKHO(ID.ToString(), MAHDX);
            string SQL = "DELETE FROM traCHITIETHDX where MAHDX='" + MAHDX + "' AND ID=" + ID.ToString();
            executeNonQuery(SQL);
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
            string SQL = "select 	MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  HOADONXUAT where NGAYXUAT='" + dto.NGAYXUAT + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }

        public DataTable GETtraHOADONXUAT(DTO dto)
        {
            string SQL = "select 	MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  traHOADONXUAT where NGAYXUAT='" + dto.NGAYXUAT + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }




        
    }
}
