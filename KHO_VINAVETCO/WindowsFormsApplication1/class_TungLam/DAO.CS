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
            string SQL = "	insert into KHACHHANG(MAKH,MAKV,MANV,MABG,MAKHO,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG)"
            + " values('" + dto.MAKH + "','" + dto.MAKV + "','" + dto.MANV + "','" + dto.MABG + "','" + PublicVariable.MAKHO + "',N'" + dto.TENKH + "','" + dto.SOTAIKHOAN + "',N'" + dto.NGANHANG + "','" + dto.MASOTHUE + "',N'" + dto.DIACHI + "','" + dto.SDT + "','" + dto.FAX + "','" + dto.WEBSITE + "','" + dto.YAHOO + "','" + dto.SKYPE + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

        }
        public void updateKhachHang(DTO dto)
        {
            string SQL = "update KHACHHANG set MAKH='" + dto.MAKH + "' ,MABG='" + dto.MABG + "',MANV='" + dto.MANV + "',MAKV='" + dto.MAKV + "',TENKH=N'" + dto.TENKH + "',SOTAIKHOAN='" + dto.SOTAIKHOAN + "',NGANHANG=N'" + dto.NGANHANG + "',MASOTHUE='" + dto.MASOTHUE + "',DIACHI=N'" + dto.DIACHI + "',SDT='" + dto.SDT + "',FAX='" + dto.FAX + "',WEBSITE='" + dto.WEBSITE + "',YAHOO='" + dto.YAHOO + "',SKYPE='" + dto.SKYPE + "',TINHTRANG='" + dto.TINHTRANG + "' where 	(MAKH='" + dto.MAKH + "')";
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
            +" values('"+dto.MANH+"',N'"+dto.TENNHOMHANG+"',N'"+dto.GHICHU+"')";
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


        public void addlohangtondau(DTO dto)
        {
            string SQL = "INSERT INTO TONDAUKHOHANG([MAMH],[LOHANG],[GIAMUA],[GIABAN],[TONKHO],[NGAYNHAP],[HSD])VALUES('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIAMUA + "," + dto.GIABAN + "," + dto.SOLUONGMH + ",convert(varchar,getDate(),101),'" + dto.HSD + "')  GO "
                           + " INSERT INTO KHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO],[NHAPKHO],[XUATKHO],[TRANHAPKHO],[TRAXUATKHO],[NGAYNHAP],[HSD]) VALUES ('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIAMUA + "," + dto.SOLUONGMH + ",0,0,0,0,convert(varchar,getDate(),101),'" + dto.HSD + "') GO ";
                       
            executeNonQuery(SQL);

        }


        public void addMatHang(DTO dto)
        {
            string SQL = "insert into MATHANG(MAMH,MATH,MANH,MAKHO,MANCC,TENMH,MADVT,KLDVT,SOLUONGMH,GIAMUA, MOTA,TINHTRANG)"
            + " values('" + dto.MAMH + "','" + dto.MATH + "','NH00001','" + dto.MAKHO + "','" + dto.MANCC + "',N'" + dto.TENMH + "','" + dto.MADVT + "','" + dto.KLDVT + "'," + dto.SOLUONGMH + ",0, N'" + dto.MOTA + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
            SQL = "INSERT INTO [TONKHOTT]([NGAY],[MAMH],[MAKHO],[TONTT],[TONKHONGAY])  VALUES(convert(varchar,getDate(),101) ,'"+dto.MAMH+"','"+PublicVariable.MAKHO+"',0,0)";
            executeNonQuery(SQL);

            SQL = "INSERT INTO [BANGGIAMATHANG]([MABG],[MAMH],[GIABAN])  SELECT MABG,'" + dto .MAMH+ "' AS MAMH,0 AS GIABAN FROM BANGGIA WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            executeNonQuery(SQL);

        }
        public void UPDATEMATHANG(DTO dto)
        {
           String SQL = "update MATHANG set MANCC= '"+dto.MANCC+"',MATH= '"+dto.MATH+"',MAKHO= '"+dto.MAKHO+"',TENMH= N'"+dto.TENMH+"',MADVT= '"+dto.MADVT+"',KLDVT= '"+dto.KLDVT+"', MOTA= N'"+dto.MOTA+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAMH='"+dto.MAMH+"'";
            executeNonQuery(SQL);

        }

        public void addBanggia(DTO dto)
        {
            string SQL = "insert into BANGGIA(MABG,TENBG,MAKHO,GHICHU)"
            + " values('" + dto.MABG + "',N'" + dto.TENBG + "','" + PublicVariable.MAKHO + "',N'" + dto.GHICHU + "')";
            executeNonQuery(SQL);

            SQL = "insert into BANGGIAMATHANG(MABG,MAMH,GIABAN) SELECT '"+dto.MABG+"' AS MABG, MAMH, 0 AS GIABAN FROM MATHANG  WHERE TINHTRANG='TRUE' AND MAKHO='" + PublicVariable.MAKHO + "'";
            executeNonQuery(SQL);
        }

        public void updateBanggia(DTO dto)
        {
            String SQL = "update BANGGIA set TENBG= N'" + dto.TENBG + "',MAKHO= '" + PublicVariable.MAKHO + "',GHICHU= N'" + dto.GHICHU + "' WHERE MABG='" + dto.MABG + "'";
            executeNonQuery(SQL);
        }
        public void deleteBanggia(String MABG)
        {
            string SQL = "delete from BANGGIA where 	MABG='"+MABG+"'";
            executeNonQuery(SQL);
            SQL = "delete from BANGGIAMATHANG where 	MABG='" + MABG + "'";
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

            SQL = "delete from TONKHOTT where 	MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            SQL = "delete from BANGGIAMATHANG where 	MAMH='" + dto.MAMH + "'";
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


        public Boolean isDELETEBANGGIA(String MABG)
        {
            string SQL = "select TOP 1 MABG from KHACHHANG where 	MABG='" + MABG + "' ";
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
            {
                return false;
            }

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
        public DataTable GETMATHANG_FULL(string MAMH)
        {
           string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE MAMH='" + MAMH + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
           
        }
        public DataTable GETMATHANG_MUA(string MAMH)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIAMUA,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIAMUA,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE MAMH='" + MAMH + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG(string MAMH)
        {

            string SQL = "SELECT MAMH,TENMH,SOLUONGMH,GIABAN,MATHANG.MADVT,DONVITINH FROM MATHANG,DONVITINH WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH='" + MAMH + "'";
            return getdata(SQL);
        }
        public DataTable GETMATHANG(string MAMH, String LOHANG)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH,LOHANG,HSD,GIANHAP FROM (SELECT LOHANG,T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD,GIANHAP FROM (SELECT MATHANG.*,LOHANG,KHOHANG.HSD,KHOHANG.GIAMUA AS GIANHAP FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.MAMH='" + MAMH + "' AND KHOHANG.LOHANG='" + LOHANG + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG()
        {
            string SQL = "select 	mathang.MAMH,DONVITINH,TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,GIAMUA,MOTA,mathang.TINHTRANG, GIAMUA*SOLUONGMH AS THANHTIEN from  MATHANG,NHACUNGCAP,DONVITINH WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETBANGGIA(string MABG)
        {
            string SQL = "select 	mathang.MAMH,DONVITINH,TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,BANGGIAMATHANG.GIABAN,MOTA,mathang.TINHTRANG, BANGGIAMATHANG.GIABAN*SOLUONGMH AS THANHTIEN from  MATHANG,NHACUNGCAP,DONVITINH,BANGGIAMATHANG WHERE BANGGIAMATHANG.MABG='" + MABG + "' AND MATHANG.MAMH=BANGGIAMATHANG.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETMATHANG1()
        {
            string SQL = "select 	MAMH,TENMH,SOLUONGMH FROM MATHANG where MAKHO='" + PublicVariable.MAKHO + "' ";
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
        public DataTable GETBG()
        {
            string SQL = "select MABG,TENBG from  BANGGIA WHERE MAKHO='"+PublicVariable.MAKHO+"'";
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
        public DataTable GETNCC()
        {
            string SQL = "select 	MANCC,TENNCC from  NHACUNGCAP where MAKHO='"+PublicVariable.MAKHO+"'";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH()
        {
            string SQL = "select 	MAKH,TENKV,KHACHHANG.MAKV,KHACHHANG.MANV,TENNV,BANGGIA.MABG,TENBG,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,KHACHHANG.DIACHI,KHACHHANG.SDT,KHACHHANG.FAX,KHACHHANG.WEBSITE,KHACHHANG.YAHOO,KHACHHANG.SKYPE,KHACHHANG.TINHTRANG from  KHACHHANG,KHUVUC,NHANVIEN,BANGGIA where KHACHHANG.MABG=BANGGIA.MABG AND KHACHHANG.MAKV=KHUVUC.MAKV AND KHACHHANG.MANV=NHANVIEN.MANV AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH(string MAKH)
        {
            string SQL = "SELECT * FROM KHACHHANG WHERE MAKH='" + MAKH + "'";
            return GET_DATA(SQL);

        }
        

        public DataTable GETDANHSACHKH1()
        {

            string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG where makho='"+PublicVariable.MAKHO+"'";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHNCC()
        {
            string SQL = "select 	MANCC,MAKV,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG from  NHACUNGCAP where makho='" + PublicVariable.MAKHO + "'";
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
        public DataTable GETMMH2()
        {
            string SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC FROM MATHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable GETMMH()
        {
            string SQL = "";
            
                if (PublicVariable.isHSD)
                {
                    SQL = "SELECT  MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
                }
                else
                {
                    SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
                }
            
            return getdata(SQL);
        }

        public DataTable GETMMH_BG(string MAKH)
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            }

            return getdata(SQL);
        }
        public DataTable GETMMH(string MANCC)
        {
            string SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC FROM MATHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }

        public DataTable GETMMH2(string MANCC)
        {
            string SQL = "";
            if (PublicVariable.isHSD)
            {
                SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            }
            return getdata(SQL);
        }

        public DataTable GETMMHN(String MAHDN)
        {
            string SQL = "SELECT mathang.MAMH,TENMH,TENNCC,SOLUONGNHAP-SOLUONGTRANHAP AS SOLUONGNHAP FROM MATHANG, chitiethdn,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.mamh=chitiethdn.mamh  and MAHDN='" + MAHDN + "'and soluongnhap-SOLUONGTRANHAP>0  and mathang.MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable GETMMHX(String MAHDX)
        {
            string SQL = "SELECT mathang.MAMH,TENMH,TENNCC,soluongxuat-SOLUONGTRAXUAT AS SOLUONGXUAT FROM MATHANG, chitiethdx,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.mamh=chitiethdx.mamh and MAHDX='" + MAHDX + "'  and soluongxuat-soluongtraxuat>0 and mathang.MAKHO='" + PublicVariable.MAKHO + "'";
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
            string NGAYNHAP = "convert(varchar,getDate(),101)";
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            }

            string SQL = "insert into traHOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + NGAYNHAP + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "','" + dto.TINHTRANG + "'," + dto.CKTIEN + ")";
            executeNonQuery(SQL);
        }
        public void INSERTHOADONNHAP(DTO dto)
        {
            PublicVariable.SQL_NHAP= PublicVariable.SQL_NHAP + "\r\nGO\r\n insert into HOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + dto.NGAYNHAP + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "','" + dto.TINHTRANG + "'," + dto.CKTIEN + ")";
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
            string SQL = "update traHOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "update HOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {
            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO CHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,KMAI,GIANHAP,HSD,LOHANG,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.KMAI + "," + dto.GIANHAP + ",'" + dto.HSD + "','" + dto.LOHANG + "','" + dto.TINHTRANG + "')";
            

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE MATHANG  SET 	SOLUONGMH =" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + " + SOLUONGMH WHERE MAMH='" + dto.MAMH + "'";
            
            //////////// BEGIN  INSERT KHOHANG/////////////
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO KHOHANG (MAMH,LOHANG, GIAMUA,TONKHO,NHAPKHO,XUATKHO, TRANHAPKHO,TRAXUATKHO,NGAYNHAP,HSD,TINHTRANG) VALUES ('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIANHAP + "," + dto.SOLUONGNHAP + "+" + dto.KMAI + "," + dto.SOLUONGNHAP + " + " + dto.KMAI + ",0,0,0," + dto.NGAYNHAP + ",'" + dto.HSD + "',1)";
            }
            else
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ", NHAPKHO =NHAPKHO+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            }
            
            //////////  END INSERT KHOHANG //////////

            //////////// BEGIN  INSERT TONKHO/////////////
            string SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            Double tondau = 0;
            if (dt.Rows.Count > 0)
            {
                tondau = (Double)Convert.ToDouble(dt.Rows[0][0].ToString());
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO TONKHO (MAHD,ID, MANHAPXUAT,MAMH,MAKHO,MANV, MADOITUONG,NGAY,TONDAU,NHAPXUAT,TONCUOI,GIATIEN) VALUES ('" + dto.MAHDN + "','" + dto.ID + "','N','" + dto.MAMH + "','" + PublicVariable.MAKHO + "','" + dto.MANV + "','" + dto.MANCC + "'," + dto.NGAYNHAP + "," + tondau + "," + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "," + tondau.ToString() +" + "+ dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ","+dto.GIANHAP+")";
            //////////  END INSERT TONKHO //////////

        }


        public void INSERTtraCTHOADONNHAP(DTO dto)
        {

            String SQL = "INSERT INTO traCHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG,LOHANG,GIATRANHAP,HSD) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.GIANHAP + ",'" + dto.TINHTRANG + "','" + dto.LOHANG + "'," + dto.GIATRANHAP + ",'" + dto.HSD + "')";
            executeNonQuery(SQL);

           SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            Double tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = (Double)Convert.ToDouble(dt.Rows[0][0].ToString());
            }
        

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH +" + (-dto.SOLUONGNHAP).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYNHAP,101) FROM traHOADONNHAP where MAHDN = '" + dto.MAHDN + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();
            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDN, dto.MAMH, dto.MANV, dto.MANCC, ngay, "0", dto.SOLUONGNHAP.ToString(), dto.GIANHAP.ToString());
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, dto.MANV, dto.MANCC, ngay, tondau, "0", dto.SOLUONGNHAP.ToString(), dto.GIANHAP.ToString());
            }

            UPDATE_KHOHANG_NX(dto.MAMH, dto.LOHANG, "0", dto.SOLUONGNHAP.ToString(), "0", "0");
        }
        public void INSERT_KHOHANG(string MAMH, string LOHANG, string GIAMUA, string SOLUONGNHAP, string HSD)
        {
            string SQL = "select mamh from khohang where mamh='" + MAMH + "' and lohang='" + LOHANG + "'";
            DataTable dt = GET_DATA(SQL);

            if (dt.Rows.Count > 0)
            {
                UPDATE_KHOHANG(MAMH, LOHANG, GIAMUA, SOLUONGNHAP, "0", "0", "0", HSD);
            }
            else
            {
                string NGAYNHAP = "convert(varchar,getDate(),101)";
                if (PublicVariable.isUSE_COMPUTERDATE)
                {
                    NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
                }

                SQL = "INSERT INTO KHOHANG ([MAMH],[LOHANG],[GIAMUA] ,[TONKHO],[NHAPKHO] ,[XUATKHO] ,[TRANHAPKHO],[TRAXUATKHO],[NGAYNHAP] ,[HSD])"
                          + " VALUES ('" + MAMH + "','" + LOHANG + "'," + GIAMUA + "," + SOLUONGNHAP + "," + SOLUONGNHAP + ",0, 0,0,"+NGAYNHAP+",'" + HSD + "')";
                executeNonQuery(SQL);

                SQL = "UPDATE MATHANG SET  GIAMUA=" + GIAMUA + " , GIABAN=GIABAN+" + GIAMUA + "- GIAMUA WHERE MAMH='" + MAMH + "' ";
                executeNonQuery(SQL);
            }
                
        }
        public void DELETE_KHOHANG(string MAMH, string LOHANG)
        {
            string SQL = "DELETE FROM KHOHANG where LOHANG='" + LOHANG + "' AND MAMH='" + MAMH + "'";
            executeNonQuery(SQL);
        }
        public void EXCUTE_SQL2(string SQL)
        {
            executeNonQuery2(SQL);
        }

        public void UPDATE_KHOHANG(string MAMH, string LOHANG, string GIAMUA, string NHAP,string TRANHAP, string XUAT, string TRAXUAT, string HSD)
        {
            string TONKHO = (Convert.ToDouble(NHAP) + Convert.ToDouble(TRAXUAT) - Convert.ToDouble(XUAT) - Convert.ToDouble(TRANHAP)).ToString();

            string SQL = "UPDATE KHOHANG SET  GIAMUA=" + GIAMUA + ", TONKHO=TONKHO+" + TONKHO + ", NHAPKHO=NHAPKHO+" + NHAP + ",XUATKHO=XUATKHO+" + XUAT + ",TRANHAPKHO=TRANHAPKHO+" + TRANHAP + ",TRAXUATKHO=TRAXUATKHO+" + TRAXUAT + ",HSD='" + HSD + "'  WHERE MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            executeNonQuery(SQL);

            SQL = "UPDATE MATHANG SET  GIAMUA=" + GIAMUA + " , GIABAN=GIABAN+" + GIAMUA + "-GIAMUA WHERE MAMH='" + MAMH + "' ";
            executeNonQuery(SQL);
        }

        public void UPDATE_KHOHANG_NX(string MAMH, string LOHANG, string NHAP, string TRANHAP, string XUAT, string TRAXUAT)
        {
            string TONKHO = (Convert.ToDouble(NHAP) + Convert.ToDouble(TRAXUAT) - Convert.ToDouble(XUAT) - Convert.ToDouble(TRANHAP)).ToString();

            string SQL = "UPDATE KHOHANG SET  TONKHO=TONKHO+" + TONKHO + ", NHAPKHO=NHAPKHO+" + NHAP + ",XUATKHO=XUATKHO+" + XUAT + ",TRANHAPKHO=TRANHAPKHO+" + TRANHAP + ",TRAXUATKHO=TRAXUATKHO+" + TRAXUAT + "  WHERE MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            executeNonQuery(SQL);
        }

        public void INSERT_TONKHO(string ID, string MAHD, string MAMH,String MANV, string MADOITUONG, string NGAY, Double TONDAU, string NHAP, string XUAT, string GIA)
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
           double toncuoi = TONDAU + Convert.ToDouble(NHAP) - Convert.ToDouble(XUAT);
           string TRANHAP = "0", TRAXUAT = "0";
           string GIAMUA = "0", GIABAN = "0";
           SQL = "select GIAMUA,GIABAN FROM MATHANG WHERE MAMH='" + MAMH + "'";
           dt = getdata(SQL);

           if (MAHD.Substring(0, 6) == "MATHDN")
           {
               TRANHAP = XUAT;
               XUAT = "0";
               GIAMUA = dt.Rows[0]["GIAMUA"].ToString();
               GIABAN = GIA;
           }
           else if (MAHD.Substring(0, 5) == "MAHDN")
           {
               GIAMUA = GIA;
               GIABAN = dt.Rows[0]["GIABAN"].ToString();
           }
           else if (MAHD.Substring(0, 6) == "MATHDX")
           {
               TRAXUAT = NHAP;
               NHAP = "0";
               GIAMUA = GIA;
               GIABAN = dt.Rows[0]["GIABAN"].ToString();
           }
           else if (MAHD.Substring(0, 5) == "MAHDX")
           {
               GIAMUA = dt.Rows[0]["GIAMUA"].ToString();
               GIABAN = GIA;
           }

           SQL = "INSERT TONKHO(STT,ID,MAHD,MAMH,MAKHO,MANV,MADOITUONG,NGAY,TONDAU,NHAP,TRANHAP,XUAT,TRAXUAT,TONCUOI,GIANHAP,GIAXUAT)"
                  + " VALUES (" + STT + "," + ID + ",'" + MAHD + "','" + MAMH + "','" + PublicVariable.MAKHO + "','" + MANV + "','" + MADOITUONG + "','" + NGAY + "', " + TONDAU.ToString() + "," + NHAP + "," + TRANHAP + "," + XUAT + "," + TRAXUAT + "," + toncuoi.ToString() + "," + GIAMUA + "," + GIABAN + ")";

           executeNonQuery(SQL);


           SQL = "UPDATE TONKHOTT SET TONKHONGAY=" + toncuoi.ToString() + "  WHERE NGAY='" + NGAY + "' and MAMH='" + MAMH + "'";
           executeNonQuery(SQL);
           
            
        }
        public void INSERT_TONKHO2(string ID, string MAHD, string MAMH,string MANV,string MADOITUONG, string NGAY, string NHAP, string XUAT,string GIA)
        {
            string SQL = "select TOP 1 STT from tonkho where MAHD='" + MAHD + "' ";
            DataTable dt = getdata(SQL);
            string STT = "0";
            if (dt.Rows.Count > 0)
            {
                STT = dt.Rows[0][0].ToString();

                SQL = "select * from tonkho where MAMH='" + MAMH + "' and STT=(select max(STT) from tonkho where MAMH='" + MAMH + "' AND (STT<" + STT + " OR  STT=" + STT + ")) ORDER BY ID DESC ";
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

                double toncuoi = Convert.ToDouble(TONDAU) + Convert.ToDouble(NHAP) - Convert.ToDouble(XUAT);
                string TRANHAP = "0", TRAXUAT = "0";
                string GIAMUA="0", GIABAN="0";
                SQL = "select GIAMUA,GIABAN FROM MATHANG WHERE MAMH='" + MAMH + "'";
                dt = getdata(SQL);

                if (MAHD.Substring(0, 6) == "MATHDN")
                {
                    TRANHAP = XUAT;
                    XUAT = "0";
                    GIAMUA = dt.Rows[0]["GIAMUA"].ToString();
                    GIABAN = GIA;
                }
                else if (MAHD.Substring(0, 5) == "MAHDN")
                {
                    GIAMUA = GIA;
                    GIABAN = dt.Rows[0]["GIABAN"].ToString();
                }
                else if (MAHD.Substring(0, 6) == "MATHDX")
                {
                    TRAXUAT = NHAP;
                    NHAP = "0";
                    GIAMUA = GIA;
                    GIABAN = dt.Rows[0]["GIABAN"].ToString();
                }
                else if (MAHD.Substring(0, 5) == "MAHDX")
                {
                    GIAMUA = GIA;
                    GIABAN = dt.Rows[0]["GIABAN"].ToString();
                }

                SQL = "INSERT TONKHO(STT,ID,MAHD,MAMH,MAKHO,MANV,MADOITUONG,NGAY,TONDAU,NHAP,TRANHAP,XUAT,TRAXUAT,TONCUOI,GIANHAP,GIAXUAT)"
                       + " VALUES (" + STT + "," + ID + ",'" + MAHD + "','" + MAMH + "','" + PublicVariable.MAKHO + "','" + MANV + "','" + MADOITUONG + "','" + NGAY + "', " + TONDAU + "," + NHAP + "," + TRANHAP + "," + XUAT + "," + TRAXUAT + "," + toncuoi.ToString() + "," + GIAMUA + "," + GIABAN + ")";
                executeNonQuery(SQL);

                
                if (NHAP == "0")
                {
                    NHAP = TRANHAP;
                }
                if (XUAT == "0")
                {
                    XUAT = TRAXUAT;
                }
                string sxuat = (-Convert.ToDouble(XUAT)).ToString();
                //update cac dong sau
                SQL = "UPDATE TONKHO SET  tondau=tondau+" + NHAP + "+" + sxuat + ",  toncuoi=toncuoi+" + NHAP + "+" + sxuat + "  WHERE STT>" + STT + " and MAMH='" + MAMH + "'";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  tondau=tondau+" + NHAP + "+" + sxuat + ",  toncuoi=toncuoi+" + NHAP + "+" + sxuat + "  WHERE STT=" + STT + " and MAMH='" + MAMH + "' and ID>" + ID;
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHOTT SET TONKHONGAY=" + toncuoi.ToString() + "  WHERE NGAY='" + NGAY + "' and MAMH='" + MAMH + "'";
                executeNonQuery(SQL);
            }
            
            

        }
        public void UPDATE_TONKHO(string ID, string MAHD, string MAMH, string NHAP, string XUAT, String GIA)
        {
            string SQL = "select nhap,TRANHAP,xuat,TRAXUAT,STT from tonkho where MAHD='" + MAHD + "' AND ID='" + ID + "' ";
            DataTable dt = getdata(SQL);
            string STT = "1";
            string SUANHAP = "0";
            string SUAXUAT = "0";
            
            if (dt.Rows.Count > 0)
            {
                STT = dt.Rows[0]["STT"].ToString();
                SUANHAP = (Convert.ToDouble(NHAP) - Convert.ToDouble(dt.Rows[0]["nhap"].ToString()) - Convert.ToDouble(dt.Rows[0]["TRANHAP"].ToString())).ToString();
                SUAXUAT = (Convert.ToDouble(XUAT) - Convert.ToDouble(dt.Rows[0]["xuat"].ToString()) - Convert.ToDouble(dt.Rows[0]["TRAXUAT"].ToString())).ToString();
                if (SUANHAP != "0")
                {
                    SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + MAMH + "'," + SUANHAP + ",'THEM',N'"+PublicVariable.TMPtring+"')";
                    executeNonQuery(SQL);
                }
                else
                {
                    SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + MAMH + "'," + SUAXUAT + ",'GIAM',N'" + PublicVariable.TMPtring + "')";
                    executeNonQuery(SQL);
                }
            }

            string TRANHAP="0", TRAXUAT="0";
            string GIAMUA = "0", GIABAN = "0";
            SQL = "select GIAMUA,GIABAN FROM MATHANG WHERE MAMH='" + MAMH + "'";
            dt = getdata(SQL);
            if (MAHD.Substring(0, 6) == "MATHDN")
            {
                TRANHAP = XUAT;
                XUAT = "0";
                GIAMUA = dt.Rows[0]["GIAMUA"].ToString();
                GIABAN = GIA;
            }
            else if (MAHD.Substring(0, 5) == "MAHDN")
            {
                GIAMUA = GIA;
                GIABAN = dt.Rows[0]["GIABAN"].ToString();
            }
            else if (MAHD.Substring(0, 6) == "MATHDX")
            {
                TRAXUAT = NHAP;
                NHAP = "0";
                GIAMUA = GIA;
                GIABAN = dt.Rows[0]["GIABAN"].ToString();
            }
            else if (MAHD.Substring(0, 5) == "MAHDX")
            {
                GIAMUA = GIA;
                GIABAN = dt.Rows[0]["GIABAN"].ToString();
            }

            string ssuaxuat = (-Convert.ToDouble(SUAXUAT)).ToString();

            SQL = "UPDATE TONKHO SET  toncuoi=toncuoi+" + SUANHAP + "+" + ssuaxuat + " ,NHAP=" + NHAP + ",TRANHAP=" + TRANHAP + ",XUAT=" + XUAT + " ,TRAXUAT=" + TRAXUAT + " ,GIANHAP=" + GIAMUA + ", GIAXUAT=" + GIABAN + "  WHERE STT=" + STT + " and id= " + ID;
            executeNonQuery(SQL);


            SQL = "UPDATE TONKHO SET  tondau=tondau+" + SUANHAP + "+" + ssuaxuat + ",  toncuoi=toncuoi+" + SUANHAP + "+" + ssuaxuat + "  WHERE STT>" + STT + " and MAMH='" + MAMH + "'";
            executeNonQuery(SQL);

            SQL = "UPDATE TONKHO SET  tondau=tondau+" + SUANHAP + "+" + ssuaxuat + ",  toncuoi=toncuoi+" + SUANHAP + "+" + ssuaxuat + "  WHERE STT=" + STT + " and MAMH='" + MAMH + "' and ID>" + ID;
            executeNonQuery(SQL);

            SQL = " select convert(varchar,NGAY,101) AS NGAY FROM TONKHO WHERE STT=" + STT + " and id= " + ID;
            dt = GET_DATA(SQL);
            SQL = "UPDATE TONKHOTT SET TONKHONGAY=TONKHONGAY+" + SUANHAP + "+" + ssuaxuat + "  WHERE NGAY='" + dt.Rows[0][0].ToString() + "' and MAMH='" + MAMH + "'";
            executeNonQuery(SQL);
        }

        public void DELETE_TONKHO(string ID, string MAHD)
        {
            string SQL = "select nhap,TRANHAP,TRAXUAT,xuat,STT,mamh,convert(varchar,NGAY,101) as ngay from tonkho where mahd='" + MAHD + "' and id=" + ID;
            DataTable dt = getdata(SQL);
            if (dt.Rows.Count > 0)
            {
                SQL = "delete from tonkho where STT=" + dt.Rows[0]["STT"].ToString()+" and ID="+ID;
                executeNonQuery(SQL);

                string CHENHLECH = (-(Convert.ToDouble(dt.Rows[0]["NHAP"].ToString()) - Convert.ToDouble(dt.Rows[0]["TRANHAP"].ToString()) + Convert.ToDouble(dt.Rows[0]["TRAXUAT"].ToString()) - Convert.ToDouble(dt.Rows[0]["XUAT"].ToString()))).ToString();

                SQL = "INSERT INTO LOG (MAHD,MAMH,SOLUONG,LOG,LYDO) VALUES ( '" + MAHD + "', '" + dt.Rows[0]["MAMH"].ToString() + "'," + CHENHLECH + ",'DELETE',N'" + PublicVariable.TMPtring + "')";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  TONDAU=TONDAU+ " + CHENHLECH + ", toncuoi=toncuoi+" + CHENHLECH + "  WHERE STT>" + dt.Rows[0]["STT"].ToString() + " and MAMH='" + dt.Rows[0]["MAMH"].ToString() + "' ";
                executeNonQuery(SQL);

                SQL = "UPDATE TONKHO SET  TONDAU=TONDAU+ " + CHENHLECH + ", toncuoi=toncuoi+" + CHENHLECH + " WHERE STT=" + dt.Rows[0]["STT"].ToString() + " and MAMH='" + dt.Rows[0]["MAMH"].ToString() + "' and ID>" + ID;
                executeNonQuery(SQL);

                SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH +" + CHENHLECH + "  WHERE MAMH='" + dt.Rows[0]["MAMH"].ToString() + "'";
                executeNonQuery(SQL);


                SQL = "UPDATE TONKHOTT SET TONKHONGAY=TONKHONGAY+" + CHENHLECH + "  WHERE NGAY>='" + dt.Rows[0]["ngay"].ToString() + "' and MAMH='" + dt.Rows[0]["MAMH"].ToString() + "'";
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

            string SQL = "select SOLUONGNHAP,GIANHAP from traCHITIETHDN where (MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "')";
            DataTable dt = getdata(SQL);
            Double sluongnhapcu = 0;
            int giacu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongnhapcu = Convert.ToDouble(dt.Rows[0]["SOLUONGNHAP"].ToString());
                giacu = Convert.ToInt32(dt.Rows[0]["GIANHAP"].ToString());
            }


            SQL = "update traCHITIETHDN set SOLUONGNHAP=" + dto.SOLUONGNHAP + ",GIANHAP=" + dto.GIANHAP + ",GIATRANHAP=" + dto.GIATRANHAP + ",HSD=" + dto.HSD + ", TINHTRANG= 1 where (MAHDN='" + dto.MAHDN + "' AND ID=" + dto.ID + ")";
            executeNonQuery(SQL);

          

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH+" + (-(dto.SOLUONGNHAP - sluongnhapcu)).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            Double chinhsuanhap = dto.SOLUONGNHAP - sluongnhapcu;
            int chinhsuagia = dto.GIANHAP - giacu;
            if (chinhsuanhap != 0||chinhsuagia!=0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDN, dto.MAMH, "0", dto.SOLUONGNHAP.ToString(), dto.GIANHAP.ToString());
            }

        }

        public void UPDATECTHOADONNHAP(DTO dto)
        {

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n update CHITIETHDN SET  SOLUONGNHAP="+ dto.SOLUONGNHAP.ToString() + ", KMAI="+dto.KMAI.ToString()+", GIANHAP="+dto.GIANHAP+", HSD='"+dto.HSD+"' WHERE MAHDN='" + dto.MAHDN + "' AND ID="+dto.ID.ToString()+"";
           
            //////////// BEGIN  UPDATE MATHANG/////////////
            string SQL = "SELECT SOLUONGNHAP,KMAI FROM CHITIETHDN WHERE MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAHDN + "' AND ID=" + dto.ID.ToString() + "";
            DataTable dt = getdata(SQL);
            Double SOLUONGNHAPCU = 0;
            if (dt.Rows.Count > 0)
            {
                SOLUONGNHAPCU = (Double)Convert.ToDouble(dt.Rows[0][0].ToString()) + (Double)Convert.ToDouble(dt.Rows[0][1].ToString());
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE MATHANG  SET SOLUONGMH = - "+SOLUONGNHAPCU+"+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + " + SOLUONGMH WHERE MAMH='" + dto.MAMH + "'";
            //////////  END UPDATE MATHANG //////////

            //////////// BEGIN  INSERT KHOHANG/////////////
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE KHOHANG SET TONKHO =" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ", NHAPKHO =" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='"+dto.LOHANG+"'";
            }
            else
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO-" + SOLUONGNHAPCU + "+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ", NHAPKHO =NHAPKHO - " + SOLUONGNHAPCU + " + " + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='"+dto.LOHANG+"'";
            }

            //////////  END INSERT KHOHANG //////////

            //////////// BEGIN  INSERT TONKHO /////////////

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE TONKHO SET NHAPXUAT=" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() +", TONCUOI=TONDAU + " + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() +" ";
            //////////  END INSERT TONKHO //////////

        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID, string MAMH, string LOHANG,string SOLUONG)
        {

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM TONKHO where MAHD='" + MAHDN + "' AND ID=" + ID.ToString();
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM KHOHANG where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }
            else
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO-"+SOLUONG+", NHAPKHO=NHAPKHO-"+SOLUONG+" where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE  MATHANG SET SOLUONGMH=SOLUONGMH-" + SOLUONG + " where MAMH='" + MAMH + "' ";

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM  CHITIETHDN where MAHDN='" + MAHDN + "' AND ID=" + ID.ToString();
        }
        public void DELETECTHOADONXUATTAM(string MAHDX)
        {
            string SQL = "DELETE FROM CHITIETHDXTAM where MAHDX='" + MAHDX + "' ";
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
            string SQL = "SELECT ID,T5.MAMH TENMH,HSD AS _HSD,T5.MAMH MAMH,T6.SOLUONGNHAP SOLUONG,T6.KMAI,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIAMUA,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETinCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT ID,T5.TENMH TENMH,HSD AS _HSD,T5.MAMH MAMH,T6.SOLUONGNHAP SOLUONG,T6.KMAI,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETtraCTHOADONNHAP(string MAHDN)
        {
            string SQL = String.Format("SELECT ID,T5.MAMH+'_'+LOHANG AS TENMH,T5.MAMH MAMH,T6.SOLUONGNHAP SOLUONG,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total, LOHANG as _LOHANG FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE   MATHANG.MAMH IN (SELECT MAMH FROM traCHITIETHDN WHERE MAHDN='{0}')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from traCHITIETHDN where MAHDN='{0}') T6 ON T6.MAMH =t5.MAMH", MAHDN);
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT ID,T5.MAMH+'_'+LOHANG AS TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, LOHANG as _LOHANG,TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE  MATHANG.MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUATIN(string MAHDX)
        {
            string SQL = "SELECT ID,T5.TENMH AS TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, LOHANG as _LOHANG,TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE  MATHANG.MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUATTAM(string MAHDX)
        {
            string SQL = "SELECT '' as ID,LOHANG AS _LOHANG,CHITIETHDXTAM.MAMH +'_'+LOHANG AS  TENMH,CHITIETHDXTAM.MAMH MAMH,SOLUONGXUAT SOLUONG,GIATIEN _DonGia,DONVITINH _DVT,SOLUONGXUAT*GIATIEN _Total,TIENTHU FROM  CHITIETHDXTAM,MATHANG,DONVITINH WHERE CHITIETHDXTAM.MAMH=MATHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT and CHITIETHDXTAM.MAHDX='" + MAHDX + "'";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUATTAM()
        {
            string SQL = "SELECT MAHDX FROM  CHITIETHDXTAM where MAKHO='"+PublicVariable.MAKHO+"' GROUP BY MAHDX  ";
            return getdata(SQL);
        }
        public DataTable GETtraCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT ID,T5.MAMH TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, T5.HSD AS _HSD, TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD FROM (SELECT MATHANG.*,HSD FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MAMH IN (SELECT MAMH FROM traCHITIETHDX WHERE MAHDX='" + MAHDX + "') AND KHOHANG.LOHANG IN (SELECT LOHANG FROM TRACHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from traCHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
            //string SQL = "SELECT ID,T5.MAMH TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, T5.HSD AS _HSD, TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD FROM (SELECT MATHANG.*,HSD FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MAMH IN (SELECT MAMH FROM TRACHITIETHDX WHERE MAHDX='" + MAHDX + "')  AND KHOHANG.LOHANG IN (SELECT LOHANG FROM TRACHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from TRACHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
           // return getdata(SQL);

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
            string NGAYNHAP = "convert(varchar,getDate(),101)";
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                NGAYNHAP = "'"+DateTime.Now.ToString("MM-dd-yyyy")+"'";
            }
            string SQL = "insert into HOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN)"
            + " values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + NGAYNHAP + ",'" + dto.TIENPHAITRA + "','" + dto.TIENDATRA + "','" + dto.GHICHU + "',N'" + dto.TINHTRANG + "'," + dto.CKTIEN + ")";
            executeNonQuery(SQL);
        }
        public void INSERTtraHOADONXUAT(DTO dto)
        {
            string NGAYNHAP = "convert(varchar,getDate(),101)";
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            }
            string SQL = "insert into traHOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN)"
            + " values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + NGAYNHAP + ",'" + dto.TIENPHAITRA + "','" + dto.TIENDATRA + "','" + dto.TIENDATRA + "','" + dto.GHICHU + "',N'" + dto.TINHTRANG + "'," + dto.CKTIEN + ")";
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

            string SQL = "update HOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void UPDATEtraHOADONXUAT(DTO dto)
        {
            string SQL = "update traHOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void INSERTCTHOADONXUAT(DTO dto)
        {
            string NGAYNHAP = "convert(varchar,getDate(),101)";
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            }


            string SQL = "INSERT INTO CHITIETHDX (ID, MAHDX, MAMH,LOHANG,NGAYXUAT,SOLUONGXUAT,GIATIEN,TINHTRANG,TIENTHU,GIANHAP,HSD) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "','" + dto.LOHANG + "'," + NGAYNHAP + "," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "'," + dto.TIENTHU + "," + dto.GIANHAP + ",'" + dto.HSD + "')";
            executeNonQuery(SQL);

            SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            Double tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = (Double)Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH+" + (-Convert.ToDouble(dto.SOLUONGXUAT)).ToString() + " WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYXUAT,101) FROM HOADONXUAT where MAHDX = '" + dto.MAHDX + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();

            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.MANV, dto.MAKH, ngay, "0", dto.SOLUONGXUAT.ToString(), dto.GIATIEN.ToString());
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.MANV, dto.MAKH, ngay, tondau, "0", dto.SOLUONGXUAT.ToString(), dto.GIATIEN.ToString());
            }

            UPDATE_KHOHANG_NX(dto.MAMH, dto.LOHANG, "0", "0", dto.SOLUONGXUAT.ToString(), "0");
        }
        public void INSERTtraCTHOADONXUAT(DTO dto)
        {
            string SQL = "INSERT INTO traCHITIETHDX (ID, MAHDX, MAMH,SOLUONGXUAT,GIATIEN,TINHTRANG,LOHANG,TIENTHU,GIABAN,HSD) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "'," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "','" + dto.LOHANG + "','" + dto.TIENTHU + "','" + dto.GIABAN + "','" + dto.HSD + "')";
            executeNonQuery(SQL);

            SQL = "SELECT SOLUONGMH FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);
            Double tondau = 0;

            if (dt.Rows.Count > 0)
            {
                tondau = (Double)Convert.ToDouble(dt.Rows[0][0].ToString());
            }
   

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH+" + dto.SOLUONGXUAT + " WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
//ymd
            SQL = "SELECT convert(varchar,NGAYXUAT,101) FROM traHOADONXUAT where MAHDX = '" + dto.MAHDX + "'";
            dt = getdata(SQL);
            string ngay = dt.Rows[0][0].ToString();

            if (dto.IsUPDATE)
            {
                INSERT_TONKHO2(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.MANV, dto.MAKH, ngay, dto.SOLUONGXUAT.ToString(), "0", dto.GIATIEN.ToString());
            }
            else
            {
                INSERT_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.MANV, dto.MAKH, ngay, tondau, dto.SOLUONGXUAT.ToString(), "0", dto.GIATIEN.ToString());
            }

            UPDATE_KHOHANG_NX(dto.MAMH, dto.LOHANG, "0", "0","0", dto.SOLUONGXUAT.ToString());

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
                Double slton = (Double)Convert.ToDouble(dt.Rows[0]["soluongmh"].ToString());
                SQL = "select SOLUONGXUAT from CHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
                dt = getdata(SQL);
                Double slxuatcu = 0;
                
                if (dt.Rows.Count > 0)
                {
                    slxuatcu = (Double)Convert.ToDouble(dt.Rows[0]["SOLUONGXUAT"].ToString());
                    
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


            SQL = "select SOLUONGXUAT,GIATIEN from CHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "')";
            dt = getdata(SQL);
            Double sluongxuatcu = 0;
            int giatiencu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongxuatcu = Convert.ToDouble(dt.Rows[0]["SOLUONGXUAT"].ToString());
                giatiencu = Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString());
            }

            SQL = "update CHITIETHDX set SOLUONGXUAT=" + dto.SOLUONGXUAT + "   ,GIATIEN=" + dto.GIATIEN + ",GIANHAP=" + dto.GIANHAP + ",HSD=" + dto.HSD + ",TIENTHU=" + dto.TIENTHU + " where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);

    

            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH +" + (-(dto.SOLUONGXUAT - sluongxuatcu)).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            Double chinhsuaxuat = dto.SOLUONGXUAT - sluongxuatcu;
            int chinhsuagia = dto.GIATIEN - giatiencu;
            if (chinhsuaxuat != 0 || chinhsuagia != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, "0", dto.SOLUONGXUAT.ToString(), dto.GIATIEN.ToString());
                UPDATE_KHOHANG_NX(dto.MAMH, dto.LOHANG, "0", "0", dto.SOLUONGXUAT.ToString(), "0");
            }
        }
        public void UPDATEtraCTHOADONXUAT(DTO dto)
        {
            string SQL = "select soluongmh from mathang where MAMH='" + dto.MAMH + "'";
            DataTable dt = getdata(SQL);

            if (dt.Rows.Count > 0)
            {
                Double slton = Convert.ToDouble(dt.Rows[0]["soluongmh"].ToString());
                SQL = "select SOLUONGXUAT from traCHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
                dt = getdata(SQL);
                Double slxuatcu = 0;
                if (dt.Rows.Count > 0)
                {
                    slxuatcu = Convert.ToDouble(dt.Rows[0]["SOLUONGXUAT"].ToString());
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

            SQL = "select SOLUONGXUAT,GIATIEN,TIENTHU from traCHITIETHDX where (MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "')";
            dt = getdata(SQL);
            Double sluongxuatcu = 0;
            int giatiencu = 0;
            if (dt.Rows.Count > 0)
            {
                sluongxuatcu = Convert.ToDouble(dt.Rows[0]["SOLUONGXUAT"].ToString());
                giatiencu = Convert.ToInt32(dt.Rows[0]["GIATIEN"].ToString());
            }

            SQL = "update traCHITIETHDX set SOLUONGXUAT=" + dto.SOLUONGXUAT + "   ,GIATIEN=" + dto.GIATIEN + ",GIABAN=" + dto.GIABAN + ",HSD='" + dto.HSD + "' where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);



            SQL = "UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH " + (-(dto.SOLUONGXUAT - sluongxuatcu)).ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);

            Double chinhsuaxuat = dto.SOLUONGXUAT - sluongxuatcu;
            int chinhsuagia = dto.GIATIEN - giatiencu;
            if (chinhsuaxuat != 0 || chinhsuagia != 0)
            {
                UPDATE_TONKHO(dto.ID.ToString(), dto.MAHDX, dto.MAMH, dto.SOLUONGXUAT.ToString(), "0",dto.GIATIEN.ToString());
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
