using System;
using System.Collections.Generic;

using System.Data;
//using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class DAO : Provider
    {
        
        public void insertKhachHang(DTO dto)
        {
            string SQL = " \r\nGO\r\n insert into KHACHHANG(MAKH,MAKV,MANV,MABG,MAKHO,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG,CONGNO,TIENTRATRUOC)"
            + " values('" + dto.MAKH + "','" + dto.MAKV + "','" + dto.MANV + "','" + dto.MABG + "','" + PublicVariable.MAKHO + "',N'" + dto.TENKH + "','" + dto.SOTAIKHOAN + "',N'" + dto.NGANHANG + "','" + dto.MASOTHUE + "',N'" + dto.DIACHI + "',N'" + dto.SDT + "','" + dto.FAX + "','" + dto.WEBSITE + "','" + dto.YAHOO + "','" + dto.SKYPE + "','" + dto.TINHTRANG + "',0,0)";

            SQL = SQL + "\r\nGO\r\n INSERT INTO TONDAUCONGNOKH([MAKH],[CONGNO])VALUES ('" + dto.MAKH + "',0)";
            executeNonQuery2(SQL);

        }
        public String getIDNHAP()
        {
            string IDTIME = "", IDDATE="";
            string SQLNGAY = "SELECT convert(varchar,getDATE(),12) AS DATE,convert(varchar,getDATE(),14) AS TIMER ";
            DataTable dtn = getdata(SQLNGAY);
            IDTIME = dtn.Rows[0]["TIMER"].ToString();
            IDDATE = dtn.Rows[0]["DATE"].ToString();
            IDTIME = IDTIME.Substring(0, 2) + IDTIME.Substring(3, 2) + IDTIME.Substring(6, 2);
            return IDDATE+IDTIME;
        }

        public void updateKhachHang(DTO dto)
        {
            string SQL = "update KHACHHANG set MAKH='" + dto.MAKH + "' ,MABG='" + dto.MABG + "',MANV='" + dto.MANV + "',MAKV='" + dto.MAKV + "',TENKH=N'" + dto.TENKH + "',SOTAIKHOAN='" + dto.SOTAIKHOAN + "',NGANHANG=N'" + dto.NGANHANG + "',MASOTHUE='" + dto.MASOTHUE + "',DIACHI=N'" + dto.DIACHI + "',SDT=N'" + dto.SDT + "',FAX='" + dto.FAX + "',WEBSITE='" + dto.WEBSITE + "',YAHOO='" + dto.YAHOO + "',SKYPE='" + dto.SKYPE + "',TINHTRANG='" + dto.TINHTRANG + "' where 	(MAKH='" + dto.MAKH + "')";
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
            string SQL = " \r\nGO\r\n insert into BOPHAN(MABP,TENBOPHAN,TINHTRANG) values('"+dto.MABP+"',N'"+dto.TENBOPHAN+"','"+dto.TINHTRANG+"')";
            //PHAN KHO
            SQL = SQL + " \r\nGO\r\n insert into PHANKHO(MABP,MAKHO) SELECT '" + dto.MABP + "' AS MABP,MAKHO FROM KHO";
            //PHAN QUYEN
            SQL = SQL+  " \r\nGO\r\n insert into PHANQUYEN(MABP,MACN) SELECT '" + dto.MABP + "' AS MABP,MACN FROM CHUCNANG";
            executeNonQuery2(SQL);
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
            string SQL = " \r\nGO\r\n insert into NHACUNGCAP(MANCC,MAKV,MAKHO,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG,CONGNO,TIENTRATRUOC)"
            +" values('"+dto.MANCC+"','"+dto.MAKV+"','"+PublicVariable.MAKHO+"',N'"+dto.TENNCC+"',N'"+dto.DIACHI+"','"+dto.MASOTHUE+"','"+dto.SOTAIKHOAN+"',N'"+dto.NGANHANG+"','"+dto.SDT+"','"+dto.EMAIL+"','"+dto.FAX+"','"+dto.WEBSITE+"','"+dto.TINHTRANG+"',0,0)";

            SQL = SQL + " \r\nGO\r\n INSERT INTO TONDAUCONGNONCC([MANCC],[CONGNO])VALUES ('" + dto.MANCC + "',0)";
            executeNonQuery2(SQL);
        }
        public void UPDATENHACC(DTO dto)
        {
            string SQL = "update NHACUNGCAP set MANCC= '"+dto.MANCC+"',MAKV= '"+dto.MAKV+"',TENNCC= N'"+dto.TENNCC+"',DIACHI= N'"+dto.DIACHI+"',MASOTHUE= '"+dto.MASOTHUE+"',SOTAIKHOAN= '"+dto.SOTAIKHOAN+"',NGANHANG= N'"+dto.NGANHANG+"',SDT= '"+dto.SDT+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"', WEBSITE= '"+dto.WEBSITE+"',TINHTRANG= '"+dto.TINHTRANG+"' where MANCC='"+dto.MANCC+"'";
            executeNonQuery(SQL);
        }
        public void INSERTKHO(DTO dto)
        {
            string SQL = " \r\nGO\r\n insert into KHO(MAKHO,[CODEKHO],TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG)"
            + " values('" + dto.MAKHO + "','" + dto.CODEKHO + "',N'" + dto.TENKHO + "',N'" + dto.DIACHI + "','" + dto.SDTB + "','" + dto.DTDD + "',N'" + dto.NGUOILH + "','" + dto.FAX + "','" + dto.GHICHU + "','" + dto.TINHTRANG + "')";

            SQL = SQL+ " \r\nGO\r\n insert into PHANKHO(MABP,MAKHO) SELECT  MABP,'" + dto.MAKHO + "' AS MAKHO FROM BOPHAN";

            SQL = SQL+ " \r\nGO\r\n insert into KHOASOTHEOKHO (ID,MAKHO,NGAY) SELECT  ID, '" + dto.MAKHO + "' AS MAKHO, convert(varchar,GETDATE(),101) AS NGAY  FROM KHOASO";
            executeNonQuery2(SQL);
        }
        public void INSERTDVT(DTO dto)
        {
            string SQL = "insert into DONVITINH(MADVT,DONVITINH) values('"+dto.MADVT+"',N'"+dto.DONVITINH+"')";
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
            string SQL = "update DONVITINH set MADVT= '"+dto.MADVT+"',DONVITINH= N'"+dto.DONVITINH+"' where 	MADVT='"+dto.MADVT+"'";
            executeNonQuery(SQL);
        }
        public void UPDATENHANVIEN(DTO dto)
        {
            string SQL = "update NHANVIEN set MANV= '" + dto.MANV + "',TENNV= N'" + dto.TENNV + "',DIACHI= N'" + dto.DIACHI + "',NGAYSINH= '" + dto.NGAYSINH + "',SCMND= '" + dto.SCMND + "',SDT= '" + dto.SDT + "',TINHTRANG= '" + dto.TINHTRANG + "' where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
        public void UPDATEQUANLY(DTO dto)
        {
            string SQL = "update QUANLY set MAQL= '"+dto.MAQL+"',USERNAMES= '"+dto.USERNAME+"',PASSWORD= '"+dto.PASSWORD+"',TENQL= '"+dto.TENQL+"',DIACHI= '"+dto.DIACHI+"',NGAYSINH= '"+ dto.NGAYSINH+"',SCMND= '"+dto.SCMND+"',SDT= '"+dto.SDT+"',TINHTRANG= '"+dto.TINHTRANG+"' where MAQL='"+dto.MAQL+"'";
            executeNonQuery(SQL);
        }
        public void INSERTQUANLY(DTO dto)
        {
            string SQL = "insert into QUANLY(MAQL,USERNAMES,PASSWORD,TENQL,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG)"
            +" values('"+dto.MAQL+"','"+dto.USERNAME+"','"+dto.PASSWORD+"',N'"+dto.TENQL+"',N'"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }

        public void UPDATElohangtondau(DTO dto)
        {
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n  UPDATE TONDAUMATHANG SET TONDAU=TONDAU + "+dto.CHENHLECH+" WHERE MAMH='"+dto.MAMH+"'";
            SQL = SQL + "\r\nGO\r\n  UPDATE TONDAUKHOHANG SET TONKHO=TONKHO + "+dto.CHENHLECH+", GIAMUA="+dto.GIAMUA+" WHERE MAMH='"+dto.MAMH+"' AND LOHANG='"+dto.LOHANG+"'";
            SQL = SQL + "\r\nGO\r\n  UPDATE KHOHANG SET TONKHO=TONKHO + "+dto.CHENHLECH+", GIAMUA="+dto.GIAMUA+", HSD='"+dto.HSD+"' WHERE MAMH='"+dto.MAMH+"' AND LOHANG='"+dto.LOHANG+"'";
            SQL = SQL + "\r\nGO\r\n  UPDATE MATHANG SET SOLUONGMH=SOLUONGMH + "+dto.CHENHLECH+", GIAMUA="+dto.GIAMUA+" WHERE MAMH='"+dto.MAMH+"' ";
    
            executeNonQuery2(SQL);
        }

        public void addMatHang(DTO dto)
        {
            string SQL = "select manh from nhomhang";
            DataTable dt = getdata(SQL);
            
            SQL = "";
            SQL = SQL + "\r\nGO\r\n  insert into MATHANG(MAMH,MATH,MANH,MAKHO,MANCC,TENMH,MADVT,KLDVT,SOLUONGMH,GIAMUA, MOTA,TINHTRANG,QUYCACH) VALUES('" + dto.MAMH + "','" + dto.MATH + "','" + dt.Rows[0][0].ToString() + "','" + dto.MAKHO + "','" + dto.MANCC + "',N'" + dto.TENMH + "','" + dto.MADVT + "','" + dto.KLDVT + "',0," + dto.GIAMUA + ", N'" + dto.MOTA + "','" + dto.TINHTRANG + "',N'" + dto.QUYCACH + "')";

            SQL = SQL + "\r\nGO\r\n  INSERT INTO KHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO],[NGAYNHAP],[HSD],[TINHTRANG]) VALUES('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIAMUA + ",0,convert(varchar,GETDATE(),101),convert(varchar,GETDATE(),101),1)";

            SQL = SQL + "\r\nGO\r\n  INSERT INTO TONDAUMATHANG([MAMH],[TONDAU]) VALUES ('" + dto.MAMH + "',0)";

            SQL = SQL + "\r\nGO\r\n  INSERT INTO TONDAUKHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO]) VALUES ('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIAMUA + ",0)";

            SQL = SQL + "\r\nGO\r\n  INSERT INTO BANGGIAMATHANG ([MABG],[MAMH],[GIABAN])  SELECT MABG,'" + dto.MAMH + "' AS MAMH,0 AS GIABAN FROM BANGGIA WHERE MAKHO='" + PublicVariable.MAKHO + "'";

            String SQL2 = "select COUNT(*) from TONKHOTT WHERE NGAY=convert(varchar,GETDATE(),101) AND MAKHO='"+PublicVariable.MAKHO+"'";
            dt = getdata(SQL2);
            if (dt.Rows[0][0].ToString() != "0")
            {
                SQL = SQL + "\r\nGO\r\n  INSERT INTO TONKHOTT([NGAY],[MAMH],[TONKHONGAY],[MAKHO]) VALUES (convert(varchar,GETDATE(),101),'" + dto.MAMH + "',0,'"+PublicVariable.MAKHO+"')";
            }

            executeNonQuery2(SQL);

        }
        public void UPDATEMATHANG(DTO dto)
        {
            String SQL = "update MATHANG set MANCC= '" + dto.MANCC + "',GIAMUA= " + dto.GIAMUA + ",MATH= '" + dto.MATH + "',MAKHO= '" + dto.MAKHO + "',TENMH= N'" + dto.TENMH + "',MADVT= '" + dto.MADVT + "',KLDVT= '" + dto.KLDVT + "',QUYCACH=N'" + dto.QUYCACH + "', MOTA= N'" + dto.MOTA + "',TINHTRANG= '" + dto.TINHTRANG + "' where 	MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
        }

        public void addBanggia(DTO dto)
        {
            string SQL = " \r\nGO\r\n insert into BANGGIA(MABG,TENBG,MAKHO,GHICHU)"
            + " values('" + dto.MABG + "',N'" + dto.TENBG + "','" + PublicVariable.MAKHO + "',N'" + dto.GHICHU + "')";

            SQL = SQL + " \r\nGO\r\n insert into BANGGIAMATHANG(MABG,MAMH,GIABAN) SELECT '" + dto.MABG + "' AS MABG, MAMH, 0 AS GIABAN FROM MATHANG  WHERE TINHTRANG='TRUE' AND MAKHO='" + PublicVariable.MAKHO + "'";
            executeNonQuery2(SQL);
        }

        public void updateBanggia(DTO dto)
        {
            String SQL = "update BANGGIA set TENBG= N'" + dto.TENBG + "',MAKHO= '" + PublicVariable.MAKHO + "',GHICHU= N'" + dto.GHICHU + "' WHERE MABG='" + dto.MABG + "'";
            executeNonQuery(SQL);
        }
        public void deleteBanggia(String MABG)
        {
            string SQL = " \r\nGO\r\n delete from BANGGIA where 	MABG='" + MABG + "'";

            SQL =SQL+ "\r\nGO\r\n delete from BANGGIAMATHANG where 	MABG='" + MABG + "'";
            executeNonQuery2(SQL);
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
            string SQL = " \r\nGO\r\n delete from BOPHAN where 	MABP='" + dto.MABP + "'";
            SQL = SQL + " \r\nGO\r\n delete from PHANQUYEN where 	MABP='" + dto.MABP + "'";
            SQL = SQL + " \r\nGO\r\n delete from PHANKHO where 	MABP='" + dto.MABP + "'";
            executeNonQuery2(SQL);
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
            string SQL = " \r\nGO\r\n delete from MATHANG where 	MAMH='" + dto.MAMH + "'";
            SQL = SQL+ " \r\nGO\r\n delete from TONKHOTT where 	MAMH='" + dto.MAMH + "'";
            SQL = SQL+ " \r\nGO\r\n delete from KHOHANG where 	MAMH='" + dto.MAMH + "'";
            SQL = SQL+ " \r\nGO\r\n delete from TONDAUKHOHANG where 	MAMH='" + dto.MAMH + "'";
            SQL = SQL+ " \r\nGO\r\n delete from TONDAUMATHANG where 	MAMH='" + dto.MAMH + "'";
            SQL = SQL+ " \r\nGO\r\n delete from BANGGIAMATHANG where 	MAMH='" + dto.MAMH + "'";
            executeNonQuery2(SQL);
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
            string SQL = " \r\nGO\r\n delete from KHO where 	MAKHO='" + dto.MAKHO + "'";
            SQL =SQL+ " \r\nGO\r\n delete from PHANKHO where 	MAKHO='" + dto.MAKHO + "'";
            executeNonQuery2(SQL);
        }

        public Boolean isDELELEKHO(DTO dto)
        {
            string SQL = "select TOP 1 makho from mathang where 	MAKHO='" + dto.MAKHO + "' ";
            DataTable dt=getdata(SQL);
            if (dt.Rows.Count > 0)
                return false;

            SQL = "select MAKHO from KHO";
            dt = getdata(SQL);
            if (dt.Rows.Count ==1)
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
            string SQL = "delete NHANVIEN where 	MANV='" + dto.MANV + "'";
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
            +" values('"+dto.MANV+"',N'"+dto.TENNV+"',N'"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATEKHO(DTO dto)
        {
            string SQL = "update KHO set TENKHO= N'"+dto.TENKHO+"',DIACHI= N'"+dto.DIACHI+"',SDTB= '"+dto.SDTB+"',DTDD= '"+dto.DTDD+"',NGUOILH= N'"+dto.NGUOILH+"',FAX= '"+dto.FAX+"',GHICHU= '"+dto.GHICHU+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAKHO='"+dto.MAKHO+"'";
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
       
        public DataTable GETMATHANG(string MAMH)
        {
            string SQL = "SELECT MAMH,TENMH,SOLUONGMH,GIABAN,MATHANG.MADVT,DONVITINH FROM MATHANG,DONVITINH WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH='" + MAMH + "'";
            return getdata(SQL);
        }
        public DataTable GETMATHANG(string MAMH, String LOHANG)
        {
           string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH,LOHANG,HSD,GIANHAP FROM (SELECT LOHANG,T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD,GIANHAP FROM (SELECT MATHANG.*,LOHANG,KHOHANG.HSD,KHOHANG.GIAMUA AS GIANHAP FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.MAMH='" + MAMH + "' AND KHOHANG.LOHANG='" + LOHANG + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
          //  string SQL = "SELECT TENMH, MATHANG.MAMH,LOHANG,HSD, SOLUONGMH,GIABAN,KHOHANG.GIAMUA AS GIANHAP, MATHANG.MADVT, DONVITINH FROM KHOHANG,MATHANG,DONVITINH,(SELECT MAMH,GIABAN FROM KHACHHANG,BANGGIAMATHANG WHERE KHACHHANG.MABG=BANGGIAMATHANG.MABG AND KHACHHANG.MAKH='" + MAKH + "' AND BANGGIAMATHANG.MAMH='" + MAMH + "') AS T1 WHERE KHOHANG.MAMH=T1.MAMH AND KHOHANG.LOHANG='" + LOHANG + "' AND MATHANG.MAMH=T1.MAMH AND DONVITINH.MADVT=MATHANG.MADVT";
            return getdata(SQL);
        }

        public DataTable GETMATHANG_XUAT(string MAMH, String LOHANG, string MAKH)
        {
            //  string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH,LOHANG,HSD,GIANHAP FROM (SELECT LOHANG,T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD,GIANHAP FROM (SELECT MATHANG.*,LOHANG,KHOHANG.HSD,KHOHANG.GIAMUA AS GIANHAP FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.MAMH='" + MAMH + "' AND KHOHANG.LOHANG='" + LOHANG + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            string SQL = "SELECT TENMH, MATHANG.MAMH,LOHANG,HSD, SOLUONGMH,GIABAN,KHOHANG.GIAMUA AS GIANHAP, MATHANG.MADVT, DONVITINH FROM KHOHANG,MATHANG,DONVITINH,(SELECT MAMH,GIABAN FROM KHACHHANG,BANGGIAMATHANG WHERE KHACHHANG.MABG=BANGGIAMATHANG.MABG AND KHACHHANG.MAKH='" + MAKH + "' AND BANGGIAMATHANG.MAMH='" + MAMH + "') AS T1 WHERE KHOHANG.MAMH=T1.MAMH AND KHOHANG.LOHANG='" + LOHANG + "' AND MATHANG.MAMH=T1.MAMH AND DONVITINH.MADVT=MATHANG.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG_KHTRA(string MAMH, string MAKH)
        {
            //  string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIABAN,T3.MADVT, T4.DONVITINH,LOHANG,HSD,GIANHAP FROM (SELECT LOHANG,T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD,GIANHAP FROM (SELECT MATHANG.*,LOHANG,KHOHANG.HSD,KHOHANG.GIAMUA AS GIANHAP FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.MAMH='" + MAMH + "' AND KHOHANG.LOHANG='" + LOHANG + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            string SQL = "SELECT TENMH, MATHANG.MAMH, SOLUONGMH,GIABAN,GIAMUA AS GIANHAP, MATHANG.MADVT, DONVITINH FROM MATHANG,DONVITINH,(SELECT MAMH,GIABAN FROM KHACHHANG,BANGGIAMATHANG WHERE KHACHHANG.MABG=BANGGIAMATHANG.MABG AND KHACHHANG.MAKH='" + MAKH + "' AND BANGGIAMATHANG.MAMH='" + MAMH + "') AS T1 WHERE MATHANG.MAMH=T1.MAMH AND DONVITINH.MADVT=MATHANG.MADVT";
            return getdata(SQL);
        }

        public DataTable GETMATHANG_MUA(string MAMH)
        {
            string SQL = "SELECT T3.TENMH,T3.MAMH,T3.SOLUONGMH,T3.GIAMUA,T3.MADVT, T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIAMUA,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE MAMH='" + MAMH + "') AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT";
            return getdata(SQL);
        }
        public DataTable GETMATHANG_TRANCC(string MAMH, String LOHANG)
        {
            string SQL = "SELECT    TENMH, MATHANG.MAMH,LOHANG,convert(varchar,HSD,103)as HSD, SOLUONGMH ,MATHANG.GIAMUA AS GIABAN,MATHANG.GIAMUA AS GIANHAP, MATHANG.MADVT, DONVITINH    FROM KHOHANG,MATHANG,DONVITINH WHERE KHOHANG.MAMH=MATHANG.MAMH AND KHOHANG.LOHANG='" + LOHANG + "' AND  DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH='" + MAMH + "'";
            
            return getdata(SQL);
        }
        public DataTable GETMATHANGEDIT()
        {
            string SQL = "select mathang.MAMH,CONVERT(VARCHAR,KLDVT)+' - '+DONVITINH as DONVITINH,GIAMUA,TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,GIAMUA,MOTA,mathang.TINHTRANG, GIAMUA*SOLUONGMH AS THANHTIEN,QUYCACH from  MATHANG,NHACUNGCAP,DONVITINH WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETMATHANG()
        {
            string SQL = "select mathang.MAMH,CONVERT(VARCHAR,KLDVT)+' - '+DONVITINH as DONVITINH,GIAMUA,TENMH+' - ' + QUYCACH AS TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,GIAMUA,MOTA,mathang.TINHTRANG, GIAMUA*SOLUONGMH AS THANHTIEN from  MATHANG,NHACUNGCAP,DONVITINH WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETBANGGIA(string MABG)
        {
            string SQL = "select 	mathang.MAMH,CONVERT(VARCHAR,KLDVT)+' - '+DONVITINH as DONVITINH,TENMH+' - ' + QUYCACH AS TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,BANGGIAMATHANG.GIABAN,MOTA,mathang.TINHTRANG, BANGGIAMATHANG.GIABAN*SOLUONGMH AS THANHTIEN from  MATHANG,NHACUNGCAP,DONVITINH,BANGGIAMATHANG WHERE BANGGIAMATHANG.MABG='" + MABG + "' AND MATHANG.MAMH=BANGGIAMATHANG.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETBANGGIA(string MABG, String HESONHAN)
        {
            string SQL = "select 	mathang.MAMH,CONVERT(VARCHAR,KLDVT)+' - '+DONVITINH as DONVITINH,TENMH+' - ' + QUYCACH AS TENMH,MATH,MANH,KLDVT,mathang.MANCC,mathang.MAKHO,TENNCC,mathang.MADVT,SOLUONGMH,CONVERT(Bigint, MATHANG.GIAMUA*" + HESONHAN + ") AS GIABAN,MOTA,mathang.TINHTRANG, CONVERT(Bigint, MATHANG.GIAMUA*" + HESONHAN + " *SOLUONGMH) AS THANHTIEN from  MATHANG,NHACUNGCAP,DONVITINH,BANGGIAMATHANG WHERE BANGGIAMATHANG.MABG='" + MABG + "' AND MATHANG.MAMH=BANGGIAMATHANG.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND mathang.MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETMATHANG1()
        {
            string SQL = "select 	MAMH,TENMH,SOLUONGMH FROM MATHANG where MAKHO='" + PublicVariable.MAKHO + "' ";
            return GET_DATA(SQL);
        }
        public DataTable GETTHUE()
        {
            string SQL = "select MATH,SOTHUE from  THUE";
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
            string SQL = "select 	MAQL,USERNAMES AS USERNAME,PASSWORD,TENQL,DIACHI,convert(varchar,NGAYSINH,103),SCMND,SDT,TINHTRANG from  QUANLY";
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

        public DataTable GETDANHSACHDOITUONGKH()
        {
            string SQL = "select 	MAKH AS MADOITUONG, TENKH AS TENDOITUONG FROM KHACHHANG WHERE  MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENKH  ASC";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHDOITUONGNCC()
        {
            string SQL = "select 	MANCC AS MADOITUONG, TENNCC AS TENDOITUONG FROM NHACUNGCAP WHERE  MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC  ASC";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH()
        {
            string SQL = "select 	MAKH,TENKV,KHACHHANG.MAKV,KHACHHANG.MANV,TENNV,BANGGIA.MABG,TENBG,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,KHACHHANG.DIACHI,KHACHHANG.SDT,KHACHHANG.FAX,KHACHHANG.WEBSITE,KHACHHANG.YAHOO,KHACHHANG.SKYPE,KHACHHANG.TINHTRANG,TIENTRATRUOC,CONGNO,0 AS SLIN from  KHACHHANG,KHUVUC,NHANVIEN,BANGGIA where KHACHHANG.MABG=BANGGIA.MABG AND KHACHHANG.MAKV=KHUVUC.MAKV AND KHACHHANG.MANV=NHANVIEN.MANV AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "' order by TENKH ASC";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH(string MAKH)
        {
            string SQL = "SELECT * FROM KHACHHANG WHERE MAKH='" + MAKH + "'";
            return GET_DATA(SQL);
        }

        public DataTable GETDANHSACHKH1()
        {
            string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG where makho='" + PublicVariable.MAKHO + "' order by TENKH ASC";
            return GET_DATA(SQL);
        }

        public DataTable GETDANHSACHTYPE()
        {
            string SQL = "select 	MATYPE,TYPE from  TYPE where matype <> 1";
            return GET_DATA(SQL);

        }
        public DataTable GETDANHSACHNCC()
        {
            string SQL = "select 	MANCC,MAKV,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG,TIENTRATRUOC,CONGNO from  NHACUNGCAP where makho='" + PublicVariable.MAKHO + "' order by TENNCC ASC";
            return GET_DATA(SQL);
        }

        public DataTable GETDANHSACHNCC(string MANCC)
        {
            string SQL = "SELECT * FROM NHACUNGCAP WHERE MANCC='" + MANCC + "'";
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
            string SQL = "select 	MAKHO,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG from  KHO";
            return GET_DATA(SQL);
        }

        public DataTable GETMMH2()
        {
            string SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            return getdata(SQL);
        }

        public DataTable GETMMHKHTRA()
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC   AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }

            return getdata(SQL);
        }

        public DataTable GETMMH_BGKHTRA(string MAKH)
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }

            return getdata(SQL);
        }

        public DataTable GETMMH()
        {
            string SQL = "";
            
                if (PublicVariable.isHSD)
                {
                    SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
                }
                else
                {
                    SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
                }
            
            return getdata(SQL);
        }

        public DataTable GETMMH_nhap()
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP , DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP, DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }

            return getdata(SQL);
        }

        public DataTable GETMMH_BG_nhap(string MAKH)
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP, DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP, DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }

            return getdata(SQL);
        }

        public DataTable GETMMH_BG(string MAKH)
        {
            string SQL = "";

            if (PublicVariable.isHSD)
            {
                SQL = "SELECT  MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP, DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP, DONVITINH where DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }

            return getdata(SQL);
        }

        public DataTable GETMMH_NHAPKHAC()
        {
            string SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND   MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            return getdata(SQL);
        }

        public DataTable GETMMH(string MANCC)
        {
            string SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC FROM MATHANG,NHACUNGCAP,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            return getdata(SQL);
        }

        public DataTable GETMMH2(string MANCC)
        {
            string SQL = "";
            if (PublicVariable.isHSD)
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS  TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TONKHO>0 AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            return getdata(SQL);
        }

        public DataTable GETMMH2_load(string MANCC)
        {
            string SQL = "";
            if (PublicVariable.isHSD)
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,HSD,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            else
            {
                SQL = "SELECT MATHANG.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,MATHANG.MAMH+'_'+LOHANG AS LOHANG,TONKHO FROM MATHANG,KHOHANG,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND NHACUNGCAP.MANCC='" + MANCC + "' AND MATHANG.MAMH=KHOHANG.MAMH  AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            }
            return getdata(SQL);
        }

        public DataTable GETMMHN(String MAHDN)
        {
            string SQL = "SELECT mathang.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,SOLUONGNHAP-SOLUONGTRANHAP AS SOLUONGNHAP FROM MATHANG, chitiethdn,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND   MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.mamh=chitiethdn.mamh  and MAHDN='" + MAHDN + "'and soluongnhap-SOLUONGTRANHAP>0  and mathang.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
            return getdata(SQL);
        }

        public DataTable GETMMHX(String MAHDX)
        {
            string SQL = "SELECT mathang.MAMH,TENMH+' - ' + QUYCACH AS TENMH,TENNCC,soluongxuat-SOLUONGTRAXUAT AS SOLUONGXUAT FROM MATHANG, chitiethdx,NHACUNGCAP ,DONVITINH where MATHANG.MADVT=DONVITINH.MADVT AND   MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.mamh=chitiethdx.mamh and MAHDX='" + MAHDX + "'  and soluongxuat-soluongtraxuat>0 and mathang.MAKHO='" + PublicVariable.MAKHO + "' ORDER BY TENNCC,TENMH ASC";
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
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + "\r\nGO\r\n insert into TRAHOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN,TYPE,IDNHAP,MAPT,TYPEMONEY)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + dto.NGAYNHAP + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "',1," + dto.CKTIEN + "," + dto.TYPE + "," + dto.IDNHAP + ",'',0)";
            if (dto.TYPE == "1")
            {
                Int64 TIENNO = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO - " + TIENNO.ToString() + " WHERE MANCC='" + dto.MANCC + "'";
            }
        }

        public static void INSERTHOADONNHAP(DTO dto)
        {
            PublicVariable.SQL_NHAP= PublicVariable.SQL_NHAP + "\r\nGO\r\n insert into HOADONNHAP(MAHDN,MANCC,MANV,MAKHO,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN,TYPE,IDNHAP,MAPC,TYPEMONEY,VAT)"
            + " values('" + dto.MAHDN + "','" + dto.MANCC + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + dto.NGAYNHAP + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "','" + dto.TINHTRANG + "'," + dto.CKTIEN + "," + dto.TYPE + "," + dto.IDNHAP + ",'',0," + dto.VAT + ")";


            if (dto.TYPE == "1")
            {
                Int64 TIENNO=Convert.ToInt64(dto.TIENPHAITRA)-Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO + " + TIENNO.ToString() + " WHERE MANCC='" + dto.MANCC + "'";
            }
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
            //string SQL = "update traHOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            string SQL = "SELECT CKTIEN,TIENPHAITRA,TIENDATRA FROM TRAHOADONNHAP WHERE MAHDN='" + dto.MAHDN + "'";
            DataTable DT = getdata(SQL);

            if (dto.TYPE == "1")
            {
                Int64 TIENPHAITRACU = Convert.ToInt64(DT.Rows[0]["TIENPHAITRA"].ToString());
                Int64 TIENDATRACU = Convert.ToInt64(DT.Rows[0]["TIENDATRA"].ToString());
                Int64 CONGNOCU = TIENPHAITRACU - TIENDATRACU;

                Int64 CONGNOMOI = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO+ " + CONGNOCU.ToString() + " - " + CONGNOMOI.ToString() + " where MANCC='" + dto.MANCC + "'";
            }

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n update TRAHOADONNHAP set  TIENPHAITRA= " + dto.TIENPHAITRA + ", TIENDATRA= " + dto.TIENDATRA + ", CKTIEN= " + dto.CKTIEN + " , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";


            Double CKTIENS = 0;
            if (DT.Rows.Count > 0)
            {
                CKTIENS =Convert.ToDouble(DT.Rows[0]["CKTIEN"].ToString());
            }
            if (CKTIENS - Convert.ToDouble(dto.CKTIEN) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog + "---- UPDATE  TRA NHAP HANG : CKTIEN FROM (" + DT.Rows[0]["CKTIEN"].ToString() + ") TO(" + dto.CKTIEN + ")  ";
            }
            
     
        }
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "SELECT CKTIEN,TIENPHAITRA,TIENDATRA FROM HOADONNHAP WHERE MAHDN='" + dto.MAHDN + "'";
            DataTable DT = getdata(SQL);

            if (dto.TYPE == "1")
            {
                Int64 TIENPHAITRACU = Convert.ToInt64(DT.Rows[0]["TIENPHAITRA"].ToString());
                Int64 TIENDATRACU = Convert.ToInt64(DT.Rows[0]["TIENDATRA"].ToString());
                Int64 CONGNOCU = TIENPHAITRACU - TIENDATRACU;

                Int64 CONGNOMOI = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO- " + CONGNOCU.ToString() + " + " + CONGNOMOI.ToString()+" where MANCC='"+dto.MANCC+"'";
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n update HOADONNHAP set  TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= " + dto.CKTIEN + ", VAT= " + dto.VAT + " , GHICHU= N'" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";

            
            Double CKTIENS = 0;
            if (DT.Rows.Count > 0)
            {
                CKTIENS = Convert.ToDouble(DT.Rows[0]["CKTIEN"].ToString());
            }
            if (CKTIENS - Convert.ToDouble(dto.CKTIEN) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE  NHAP HANG : CKTIEN FROM (" + DT.Rows[0]["CKTIEN"].ToString() + ") TO(" + dto.CKTIEN + ")  ";
            }
            
     
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {
            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO CHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,KMAI,GIANHAP,TIENNHAPTT,LOHANG,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.KMAI + "," + dto.GIANHAP + "," + dto.TIENTRA + ",'" + dto.LOHANG + "','" + dto.TINHTRANG + "')";


            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE MATHANG  SET 	SOLUONGMH =" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + " + SOLUONGMH, GIAMUA=" + dto.GIANHAP + " WHERE MAMH='" + dto.MAMH + "'";

            string SQL = "SELECT GIAMUA FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable TBGIA = GET_DATA(SQL);
            string GIACU = TBGIA.Rows[0][0].ToString();


           PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE BANGGIAMATHANG  SET GIABAN=GIABAN + " + dto.GIANHAP + " -" + GIACU + " WHERE MAMH='" + dto.MAMH + "'";
          
           PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- INSERT NHAP HANG MAMH:" + dto.MAMH + "  AS (" + dto.SOLUONGNHAP.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
            
            //////////// BEGIN  INSERT KHOHANG /////////////
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO KHOHANG (MAMH,LOHANG, GIAMUA,TONKHO,NGAYNHAP,HSD,TINHTRANG) VALUES ('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIANHAP + "," + dto.SOLUONGNHAP + "+" + dto.KMAI + "," + dto.NGAYNHAP + ",'" + dto.HSD + "',1)";
            }
            else
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='"+dto.LOHANG+"'";
            }
            
            //////////  END INSERT KHOHANG //////////

            //////////// BEGIN  INSERT TONKHO/////////////

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n INSERT INTO TONKHO (MAHD,MAMH, MANHAPXUAT,MAKHO,MANV, MADOITUONG,NGAY,NHAPXUAT,GIATIEN,TYPE,IDNHAP,LOHANG) VALUES ('" + dto.MAHDN + "','" + dto.MAMH + "','N','" + PublicVariable.MAKHO + "','" + dto.MANV + "','" + dto.MANCC + "'," + dto.NGAYNHAP + "," + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + "," + dto.TIENTRA + "," + dto.TYPE + "," + dto.IDNHAP + ",'" + dto.LOHANG + "')";
            //////////  END INSERT TONKHO //////////

        }


        public void INSERTtraCTHOADONNHAP(DTO dto)
        {

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n INSERT INTO TRACHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,KMAI,GIANHAP,GIATRANHAP,TIENTRANHAPTT,LOHANG,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.KMAI + "," + dto.GIANHAP + "," + dto.GIATRANHAP + "," + dto.TIENTRA + ",'" + dto.LOHANG + "',1)";

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH -" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO-" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + " WHERE MAMH='" + dto.MAMH + "' AND LOHANG='"+dto.LOHANG+"'";

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n INSERT INTO TONKHO (MAHD,MAMH, MANHAPXUAT,MAKHO,MANV, MADOITUONG,NGAY,NHAPXUAT,GIATIEN,TYPE,IDNHAP,LOHANG) VALUES ('" + dto.MAHDN + "','" + dto.MAMH + "','TN','" + PublicVariable.MAKHO + "','" + dto.MANV + "','" + dto.MANCC + "'," + dto.NGAYNHAP + ",-" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + "," + dto.TIENTRA + "," + dto.TYPE + "," + dto.IDNHAP + ",'" + dto.LOHANG + "')";
            
            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- INSERT TRA NHAP MAMH:" + dto.MAMH + "  AS (" + dto.SOLUONGNHAP.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
           

        }
       
        public void EXCUTE_SQL2(string SQL)
        {
            executeNonQuery2(SQL);
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
            string SQL = "SELECT SOLUONGNHAP + KMAI AS SOLUONGNHAP, KMAI FROM TRACHITIETHDN WHERE MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "' ";
            DataTable dt = getdata(SQL);
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n update TRACHITIETHDN SET  SOLUONGNHAP=" + dto.SOLUONGNHAP.ToString() + ", KMAI=" + dto.KMAI.ToString() + ", GIANHAP=" + dto.GIANHAP + ", GIATRANHAP=" + dto.GIATRANHAP + ", TIENTRANHAPTT=" + dto.TIENTRA + " WHERE MAMH='" + dto.MAMH + "' AND MAHDN='" + dto.MAHDN + "' AND LOHANG='" + dto.LOHANG + "' ";

            //////////// BEGIN  UPDATE MATHANG/////////////
            
            Double SOLUONGTRANHAPCU = 0;
            if (dt.Rows.Count > 0)
            {
                SOLUONGTRANHAPCU = (Double)Convert.ToDouble(dt.Rows[0][0].ToString()) ;
            }
            if ((SOLUONGTRANHAPCU- (Convert.ToDouble(dto.SOLUONGNHAP.ToString()) - Convert.ToDouble(dto.KMAI.ToString()))) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE TRA NHAP MAMH:" + dto.MAMH + " FROM (" + dt.Rows[0]["SOLUONGNHAP"].ToString() + "+ " + dt.Rows[0]["KMAI"].ToString() + ") TO (" + dto.SOLUONGNHAP.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
            }
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE MATHANG  SET SOLUONGMH = SOLUONGMH + " + SOLUONGTRANHAPCU + "-" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            //////////  END UPDATE MATHANG //////////

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO+" + SOLUONGTRANHAPCU + "-" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE TONKHO SET NHAPXUAT=-" + dto.KMAI.ToString() + " - " + dto.SOLUONGNHAP.ToString() + ", GIATIEN=" + dto.TIENTRA + " WHERE MAMH='" + dto.MAMH + "' AND MAHD='" + dto.MAHDN + "'  AND LOHANG='" + dto.LOHANG + "' ";
        }

        public void UPDATECTHOADONNHAP(DTO dto)
        {
            string SQL = "SELECT SOLUONGNHAP + KMAI AS SOLUONGNHAP, KMAI  FROM CHITIETHDN WHERE MAHDN='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";
            DataTable dt = getdata(SQL);

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n update CHITIETHDN SET  SOLUONGNHAP=" + dto.SOLUONGNHAP.ToString() + ", KMAI=" + dto.KMAI.ToString() + ", GIANHAP=" + dto.GIANHAP + ",TIENNHAPTT=" + dto.TIENTRA + " WHERE MAMH='" + dto.MAMH + "' AND MAHDN='" + dto.MAHDN + "' AND LOHANG='" + dto.LOHANG + "' ";
           
            //////////// BEGIN  UPDATE MATHANG/////////////
            
            Double SOLUONGNHAPCU = 0;
            if (dt.Rows.Count > 0)
            {
                SOLUONGNHAPCU = (Double)Convert.ToDouble(dt.Rows[0][0].ToString()) ;
            }

            if ((SOLUONGNHAPCU - Convert.ToDouble(dto.SOLUONGNHAP.ToString()) - Convert.ToDouble(dto.KMAI.ToString())) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE NHAP HANG MAMH:" + dto.MAMH + " FROM (" + dt.Rows[0]["SOLUONGNHAP"].ToString() + "+ " + dt.Rows[0]["KMAI"].ToString() + ") TO (" + dto.SOLUONGNHAP.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE MATHANG  SET SOLUONGMH = SOLUONGMH - " + SOLUONGNHAPCU + "+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ",GIAMUA=" + dto.GIANHAP + "   WHERE MAMH='" + dto.MAMH + "'";
            SQL = "SELECT GIAMUA FROM MATHANG WHERE MAMH='" + dto.MAMH + "'";
            DataTable TBGIA = GET_DATA(SQL);
            string GIACU = TBGIA.Rows[0][0].ToString();
            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE BANGGIAMATHANG  SET GIABAN=GIABAN + " + dto.GIANHAP + " -" + GIACU + " WHERE MAMH='" + dto.MAMH + "'";

            //////////  END UPDATE MATHANG //////////

            //////////// BEGIN  INSERT KHOHANG/////////////

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE KHOHANG SET TONKHO =TONKHO - " + SOLUONGNHAPCU + "+" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ", GIAMUA=" + dto.GIANHAP + ",HSD='" + dto.HSD + "'  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";
         
            //////////  END INSERT KHOHANG //////////

            //////////// BEGIN  INSERT TONKHO /////////////

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE TONKHO SET NHAPXUAT=" + dto.KMAI.ToString() + " + " + dto.SOLUONGNHAP.ToString() + ", GIATIEN=" + dto.TIENTRA + " WHERE  MAHD='" + dto.MAHDN + "' AND MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";
            //////////  END INSERT TONKHO //////////

        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID, string MAMH, string LOHANG,string SOLUONG, string KMAI)
        {

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM TONKHO where MAHD='" + MAHDN + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM KHOHANG where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }
            else
            {
                PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO-" + SOLUONG + "-" + KMAI + " where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n UPDATE  MATHANG SET SOLUONGMH=SOLUONGMH-" + SOLUONG + "-" + KMAI + " where MAMH='" + MAMH + "' ";

            PublicVariable.SQL_NHAP = PublicVariable.SQL_NHAP + " \r\nGO\r\n DELETE FROM  CHITIETHDN where MAHDN='" + MAHDN + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";

            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- DELETE NHAP HANG MAMH:" + MAMH + " TO (" + SOLUONG + "+ " + KMAI + ")  ";
            
        }
        public void DELETECTHOADONXUATTAM(string MAHDX)
        {
            string SQL = "DELETE FROM HOADONDATNHAP where MAHDX='" + MAHDX + "' ";
            executeNonQuery(SQL);
        }
        public void DELETEHOADONDATNHAP(string MAHDN)
        {
            string SQL = "DELETE FROM HOADONDATNHAP where MAHDN='" + MAHDN+ "' ";
            executeNonQuery(SQL);
        }
        public void DELETEHOADONDATXUAT(string MAHDX)
        {
            string SQL = "DELETE FROM HOADONDATXUAT where MAHDX='" + MAHDX + "' ";
            executeNonQuery(SQL);
        }
        public void DELETEtraCTHOADONNHAP(string MAHDN, int ID, string MAMH, string LOHANG,string SOLUONG, string KMAI)
        {
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n DELETE FROM TONKHO where MAHD='" + MAHDN + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";
 
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO+" + SOLUONG + "+" + KMAI + " where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            
            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n UPDATE  MATHANG SET SOLUONGMH=SOLUONGMH+" + SOLUONG + "+" + KMAI + " where MAMH='" + MAMH + "' ";

            PublicVariable.SQL_TRANHAP = PublicVariable.SQL_TRANHAP + " \r\nGO\r\n DELETE FROM  TRACHITIETHDN where MAHDN='" + MAHDN + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";

            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- DELETE TRA NHAP HANG MAMH:" + MAMH + " TO (" + SOLUONG + "+ " + KMAI + ")  ";
            
        }

        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT ID,MATHANG.MAMH AS TENMH,KHOHANG.LOHANG,HSD AS _HSD,MATHANG.MAMH MAMH,SOLUONGNHAP SOLUONG,KMAI, (SOLUONGNHAP+ KMAI)*KLDVT AS KHOILUONG,GIANHAP _DonGia, DONVITINH _DVT, (SOLUONGNHAP*GIANHAP) _Total,TIENNHAPTT AS TIENTRA FROM MATHANG,KHOHANG,CHITIETHDN, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =CHITIETHDN.MAMH AND KHOHANG.LOHANG =CHITIETHDN.LOHANG AND CHITIETHDN.MAHDN='" + MAHDN + "'ORDER BY ID ASC";
            return getdata(SQL);
        }
        public DataTable GETinCTHOADONNHAP(string MAHDN)
        {
            //string SQL = "SELECT ID,T5.TENMH,HSD,T5.MAMH,T6.SOLUONGNHAP SOLUONG,T6.SOLUONGNHAP*KLDVT AS KHOILUONG,T6.KMAI,T6.GIANHAP AS DONGIA, T5.DONVITINH AS DVT, (T6.SOLUONGNHAP*T6.GIANHAP) AS THANHTIEN,TIENNHAPTT AS TIENTRA FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,KLDVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH,TIENNHAPTT,GIANHAP FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            string SQL = "SELECT ID,TENMH+' - ' + QUYCACH AS  TENMH,KHOHANG.LOHANG,HSD AS HSD,MATHANG.MAMH MAMH,SOLUONGNHAP SOLUONG,(SOLUONGNHAP+KMAI)*KLDVT AS KHOILUONG,KMAI,GIANHAP DONGIA,DONVITINH  AS DVT, (SOLUONGNHAP*GIANHAP) AS THANHTIEN,TIENNHAPTT AS TIENTRA FROM MATHANG,KHOHANG,CHITIETHDN, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =CHITIETHDN.MAMH AND KHOHANG.LOHANG =CHITIETHDN.LOHANG AND CHITIETHDN.MAHDN='" + MAHDN + "'ORDER BY ID ASC";
            return getdata(SQL);
        }
        public DataTable GETtraCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT ID,MATHANG.MAMH+'_' + KHOHANG.LOHANG AS TENMH,MATHANG.MAMH MAMH,SOLUONGNHAP SOLUONG,GIANHAP DONGIA, DONVITINH _DVT, (SOLUONGNHAP*GIANHAP) _Total, KHOHANG.LOHANG as _LOHANG, TIENTRANHAPTT AS TIENTRA,KMAI,GIANHAP,convert(varchar,HSD,103)as HSD FROM MATHANG,KHOHANG,TRACHITIETHDN, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =TRACHITIETHDN.MAMH AND KHOHANG.LOHANG =TRACHITIETHDN.LOHANG AND TRACHITIETHDN.MAHDN='" + MAHDN + "'ORDER BY ID ASC";
            return getdata(SQL);
        }
        public DataTable GETinTRACTHOADONNHAP(string MAHDN)
        {
            //string SQL = "SELECT ID,T5.TENMH,HSD,T5.MAMH,T6.SOLUONGNHAP SOLUONG,T6.SOLUONGNHAP*KLDVT AS KHOILUONG,T6.KMAI,T6.GIANHAP AS DONGIA, T5.DONVITINH AS DVT, (T6.SOLUONGNHAP*T6.GIANHAP) AS THANHTIEN,TIENNHAPTT AS TIENTRA FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,KLDVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH,TIENNHAPTT,GIANHAP FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            string SQL = "SELECT ID,TENMH+' - ' + QUYCACH AS TENMH,HSD,MATHANG.MAMH,SOLUONGNHAP AS SOLUONG,(SOLUONGNHAP+KMAI)*KLDVT AS KHOILUONG,KMAI,GIATRANHAP AS DONGIA, DONVITINH  AS DVT, (SOLUONGNHAP*GIATRANHAP) AS THANHTIEN,TIENTRANHAPTT AS TIENTRA FROM MATHANG,KHOHANG,TRACHITIETHDN, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =TRACHITIETHDN.MAMH AND KHOHANG.LOHANG =TRACHITIETHDN.LOHANG AND TRACHITIETHDN.MAHDN='" + MAHDN + "'ORDER BY ID ASC";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            //string SQL = "SELECT ID,T5.MAMH+'_'+LOHANG AS TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, LOHANG as _LOHANG,TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE  MATHANG.MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            string SQL = "SELECT ID,MATHANG.MAMH+'_'+KHOHANG.LOHANG AS TENMH,MATHANG.MAMH,KMAI,SOLUONGXUAT AS SOLUONG,GIABAN AS _DonGia, DONVITINH AS _DVT,(SOLUONGXUAT*GIABAN) AS _Total, KHOHANG.LOHANG as _LOHANG,TIENTHU AS TIENTHU,HSD,GIANHAP FROM MATHANG,KHOHANG,CHITIETHDX, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =CHITIETHDX.MAMH AND KHOHANG.LOHANG =CHITIETHDX.LOHANG AND CHITIETHDX.MAHDX='" + MAHDX + "'ORDER BY ID ASC";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUATIN(string MAHDX)
        {
           // string SQL = "SELECT ID,T5.TENMH AS TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, LOHANG as _LOHANG,TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE  MATHANG.MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            string SQL = "SELECT ID,TENMH+' - ' + QUYCACH AS TENMH,HSD,MATHANG.MAMH,SOLUONGXUAT AS SOLUONG,(SOLUONGXUAT+KMAI)*KLDVT AS KHOILUONG,KMAI,GIABAN AS DONGIA, DONVITINH as  DVT, (SOLUONGXUAT*GIABAN) AS THANHTIEN,TIENTHU,TENNCC FROM MATHANG,KHOHANG,CHITIETHDX, DONVITINH,NHACUNGCAP WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =CHITIETHDX.MAMH AND KHOHANG.LOHANG =CHITIETHDX.LOHANG AND CHITIETHDX.MAHDX='" + MAHDX + "'ORDER BY ID ASC";
            
            return getdata(SQL);
        }

        public DataTable GETtraCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT ID,TRACHITIETHDX.MAMH TENMH,TRACHITIETHDX.MAMH,KMAI,SOLUONGXUAT AS SOLUONG,GIABAN AS DONGIA, DONVITINH AS _DVT, (SOLUONGXUAT*GIABAN) AS _Total,KHOHANG.LOHANG, TIENTHU,HSD AS _HSD,GIANHAP FROM MATHANG,KHOHANG,TRACHITIETHDX, DONVITINH WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH=TRACHITIETHDX.MAMH AND KHOHANG.LOHANG =TRACHITIETHDX.LOHANG AND TRACHITIETHDX.MAHDX='" + MAHDX + "' ORDER BY ID ASC";
            return getdata(SQL);
            //string SQL = "SELECT ID,T5.MAMH TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, T5.HSD AS _HSD, TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT,HSD FROM (SELECT MATHANG.*,HSD FROM MATHANG,KHOHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MAMH IN (SELECT MAMH FROM TRACHITIETHDX WHERE MAHDX='" + MAHDX + "')  AND KHOHANG.LOHANG IN (SELECT LOHANG FROM TRACHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from TRACHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            // return getdata(SQL);

        }
        public DataTable GETTRACTHOADONXUATIN(string MAHDX)
        {
           // string SQL = "SELECT ID,T5.TENMH AS TENMH,T5.MAMH MAMH,T6.SOLUONGXUAT SOLUONG,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total, LOHANG as _LOHANG,TIENTHU FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT MATHANG.* FROM MATHANG WHERE  MATHANG.MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            string SQL = "SELECT ID,TENMH+' - ' + QUYCACH AS TENMH,HSD,MATHANG.MAMH,SOLUONGXUAT AS SOLUONG,(SOLUONGXUAT+KMAI)*KLDVT AS KHOILUONG,KMAI,GIABAN AS DONGIA,  DONVITINH as DVT, (SOLUONGXUAT*GIABAN) AS THANHTIEN,TIENTHU,TENNCC FROM MATHANG,KHOHANG,TRACHITIETHDX, DONVITINH,NHACUNGCAP WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND  MATHANG.MAMH=KHOHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =TRACHITIETHDX.MAMH AND KHOHANG.LOHANG =TRACHITIETHDX.LOHANG AND TRACHITIETHDX.MAHDX='" + MAHDX + "'ORDER BY ID ASC";
            
            return getdata(SQL);
        }
        public DataTable GETHOADONDATXUAT(string MAHDX)
        {
            //string SQL = "SELECT ID,LOHANG AS _LOHANG,CHITIETHDXTAM.MAMH +'_'+LOHANG AS  TENMH,CHITIETHDXTAM.MAMH MAMH,SOLUONGXUAT SOLUONG,GIATIEN _DonGia,DONVITINH _DVT,SOLUONGXUAT*GIATIEN _Total,TIENTHU,KMAI,GIANHAP FROM MATHANG,TRACHITIETHDX, DONVITINH WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =TRACHITIETHDX.MAMH AND TRACHITIETHDX.MAHDX='" + MAHDX + "'";
            string SQL = "SELECT '' AS ID,KHOHANG.LOHANG AS _LOHANG,MATHANG.MAMH+'_'+KHOHANG.LOHANG AS TENMH,MATHANG.MAMH,SOLUONGXUAT SOLUONG,GIABAN _DonGia,DONVITINH _DVT,SOLUONGXUAT*GIABAN _Total,TIENTHU,KMAI,GIANHAP,KHOHANG.HSD FROM MATHANG,HOADONDATXUAT, DONVITINH, KHOHANG WHERE KHOHANG.LOHANG=HOADONDATXUAT.LOHANG AND KHOHANG.MAMH=HOADONDATXUAT.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =HOADONDATXUAT.MAMH AND HOADONDATXUAT.MAHDX='" + MAHDX + "'";
            return getdata(SQL);
        }
        public DataTable GETHOADONDATNHAP(string MAHDN)
        {
            string SQL = "SELECT '' AS ID,MATHANG.MAMH AS TENMH,'' AS _HSD,MATHANG.MAMH MAMH,SOLUONGNHAP SOLUONG,KMAI, (SOLUONGNHAP+ KMAI)*KLDVT AS KHOILUONG,GIANHAP _DonGia, DONVITINH _DVT, (SOLUONGNHAP*GIANHAP) _Total,TIENNHAPTT AS TIENTRA FROM MATHANG,HOADONDATNHAP, DONVITINH WHERE  MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH =HOADONDATNHAP.MAMH AND  HOADONDATNHAP.MAHDN='" + MAHDN + "'";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUATTAM()
        {
            string SQL = "SELECT MAHDX FROM  CHITIETHDXTAM where MAKHO='"+PublicVariable.MAKHO+"' GROUP BY MAHDX  ";
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
            string SQL = "SELECT CONGNO as 'TIENNO',TIENTRATRUOC from NHACUNGCAP where MANCC ='" + dto.MANCC + "'";
            return getdata(SQL);

        }
        public DataTable LAYTIENNOKH(DTO dto)
        {
            string SQL = "SELECT CONGNO as 'TIENNO',TIENTRATRUOC from KHACHHANG where MAKH ='" + dto.MAKH + "'";
            return getdata(SQL);

        }
        public void INSERTHOADONXUAT(DTO dto)
        {
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n insert into HOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN,TYPE,IDNHAP,MAPT,TYPEMONEY) values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + dto.NGAYXUAT + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "'," + dto.TINHTRANG + "," + dto.CKTIEN + "," + dto.TYPE + "," + dto.IDNHAP + ",'',0)";
            if (dto.TYPE == "1")
            {
                Int64 CONGNO = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO+ " + CONGNO.ToString() + " WHERE MAKH='" + dto.MAKH + "'";
            }
        }
        public void INSERTtraHOADONXUAT(DTO dto)
        {
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n insert into TRAHOADONXUAT(MAHDX,MAKH,MANV,MAKHO,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG,CKTIEN,TYPE,IDNHAP,MAPC,TYPEMONEY) values('" + dto.MAHDX + "','" + dto.MAKH + "','" + dto.MANV + "','" + PublicVariable.MAKHO + "'," + dto.NGAYNHAP + "," + dto.TIENPHAITRA + "," + dto.TIENDATRA + ",N'" + dto.GHICHU + "',1," + dto.CKTIEN + "," + dto.TYPE + "," + dto.IDNHAP + ",'',0)";
            if (dto.TYPE == "1")
            {
                Int64 CONGNO = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO- " + CONGNO.ToString() + " WHERE MAKH='" + dto.MAKH + "'";
            }
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
            string SQL = "SELECT CKTIEN,TIENPHAITRA,TIENDATRA FROM HOADONXUAT WHERE MAHDX='" + dto.MAHDX + "'";
            DataTable DT = getdata(SQL);

            if (dto.TYPE == "1")
            {
                Int64 TIENPHAITRACU = Convert.ToInt64(DT.Rows[0]["TIENPHAITRA"].ToString());
                Int64 TIENDATRACU = Convert.ToInt64(DT.Rows[0]["TIENDATRA"].ToString());
                Int64 CONGNOCU = TIENPHAITRACU - TIENDATRACU;

                Int64 CONGNOMOI = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO- " + CONGNOCU.ToString() + " + " + CONGNOMOI.ToString() + " where MAKH='" + dto.MAKH + "'";
            }

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n update HOADONXUAT set  TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "', CKTIEN= '" + dto.CKTIEN + "' , GHICHU= N'" + dto.GHICHU + "' where MAHDX='" + dto.MAHDX + "'  ";

            
            Double CKTIENS = 0;
            if (DT.Rows.Count > 0)
            {
                CKTIENS = Convert.ToDouble(DT.Rows[0]["CKTIEN"].ToString());
            }
            if (CKTIENS - Convert.ToDouble(dto.CKTIEN) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE  XUAT HANG : CKTIEN FROM (" + DT.Rows[0]["CKTIEN"].ToString() + ") TO(" + dto.CKTIEN + ")  ";
            }
            
        }

        public void UPDATEtraHOADONXUAT(DTO dto)
        {
            string SQL = "SELECT CKTIEN,TIENPHAITRA,TIENDATRA FROM TRAHOADONXUAT WHERE MAHDX='" + dto.MAHDX + "'";
            DataTable DT = getdata(SQL);

            if (dto.TYPE == "1")
            {
                Int64 TIENPHAITRACU = Convert.ToInt64(DT.Rows[0]["TIENPHAITRA"].ToString());
                Int64 TIENDATRACU = Convert.ToInt64(DT.Rows[0]["TIENDATRA"].ToString());
                Int64 CONGNOCU = TIENPHAITRACU - TIENDATRACU;

                Int64 CONGNOMOI = Convert.ToInt64(dto.TIENPHAITRA) - Convert.ToInt64(dto.TIENDATRA);
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO+ " + CONGNOCU.ToString() + " - " + CONGNOMOI.ToString() + " where MAKH='" + dto.MAKH + "'";
            }
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n update TRAHOADONXUAT set  TIENPHAITRA= " + dto.TIENPHAITRA + ", TIENDATRA= " + dto.TIENDATRA + ", CKTIEN= " + dto.CKTIEN + " , GHICHU= N'" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";

     
            Double CKTIENS = 0;
            if (DT.Rows.Count > 0)
            {
                CKTIENS = Convert.ToDouble(DT.Rows[0]["CKTIEN"].ToString());
            }
            if (CKTIENS - Convert.ToDouble(dto.CKTIEN) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE  TRA XUAT HANG : CKTIEN FROM (" + DT.Rows[0]["CKTIEN"].ToString() + ") TO(" + dto.CKTIEN + ")  ";
            }
            
        }

        public void INSERTCTHOADONXUAT(DTO dto)
        {
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n INSERT INTO CHITIETHDX (ID, MAHDX, MAMH,LOHANG,SOLUONGXUAT,KMAI,GIABAN,TIENTHU,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.SOLUONGXUAT + "," + dto.KMAI + "," + dto.GIABAN + "," + dto.TIENTHU + "," + dto.GIANHAP + ",1)";

            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- INSERT XUAT HANG MAMH:" + dto.MAMH + "  AS (" + dto.SOLUONGXUAT.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
           
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH - " + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
    
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO-" + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='"+dto.LOHANG+"'";

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n INSERT INTO TONKHO (MAHD,MAMH, MANHAPXUAT,MAKHO,MANV, MADOITUONG,NGAY,NHAPXUAT,GIATIEN,TYPE,IDNHAP,LOHANG) VALUES ('" + dto.MAHDX + "','" + dto.MAMH + "','X','" + PublicVariable.MAKHO + "','" + dto.MANV + "','" + dto.MAKH + "'," + dto.NGAYXUAT + ",-" + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + "," + dto.TIENTHU + "," + dto.TYPE + "," + dto.IDNHAP + ",'" + dto.LOHANG + "')";
        }

        public void INSERTtraCTHOADONXUAT(DTO dto)
        {
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n INSERT INTO TRACHITIETHDX (ID, MAHDX, MAMH,LOHANG,SOLUONGXUAT,KMAI,GIABAN,TIENTHU,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.SOLUONGXUAT + "," + dto.KMAI + "," + dto.GIABAN + "," + dto.TIENTHU + "," + dto.GIANHAP + ",1)";

            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE MATHANG  SET 	SOLUONGMH =SOLUONGMH + " + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";

            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- INSERT TRA XUAT MAMH:" + dto.MAMH + "  AS (" + dto.SOLUONGXUAT.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
           
            
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n INSERT INTO KHOHANG (MAMH,LOHANG, GIAMUA,TONKHO,NGAYNHAP,HSD,TINHTRANG) VALUES ('" + dto.MAMH + "','" + dto.LOHANG + "'," + dto.GIABAN + "," + dto.SOLUONGXUAT + "+" + dto.KMAI + "," + dto.NGAYNHAP + ",'" + dto.HSD + "',1)";
            } 
            else
            {
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO+" + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";
            }

            //////////// BEGIN  INSERT TONKHO/////////////
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n INSERT INTO TONKHO (MAHD,MAMH, MANHAPXUAT,MAKHO,MANV, MADOITUONG,NGAY,NHAPXUAT,GIATIEN,TYPE,IDNHAP,LOHANG) VALUES ('" + dto.MAHDX + "','" + dto.MAMH + "','TX','" + PublicVariable.MAKHO + "','" + dto.MANV + "','" + dto.MAKH + "'," + dto.NGAYNHAP + "," + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + "," + dto.TIENTHU + "," + dto.TYPE + "," + dto.IDNHAP + ",'" + dto.LOHANG + "')";
            //////////  END INSERT TONKHO //////////

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
            string SQL = "SELECT SOLUONGXUAT + KMAI AS SOLUONGXUAT, KMAI FROM CHITIETHDX WHERE MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "' ";
            DataTable dt = getdata(SQL);
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n update CHITIETHDX SET  SOLUONGXUAT=" + dto.SOLUONGXUAT.ToString() + ", KMAI=" + dto.KMAI.ToString() + ", GIABAN=" + dto.GIABAN + ", TIENTHU=" + dto.TIENTHU + ", GIANHAP=" + dto.GIANHAP + " WHERE MAMH='" + dto.MAMH + "' AND MAHDX='" + dto.MAHDX + "' AND LOHANG='" + dto.LOHANG + "' ";

            //////////// BEGIN  UPDATE MATHANG/////////////
            
            Double SOLUONGXUATCU = 0;
            if (dt.Rows.Count > 0)
            {
                SOLUONGXUATCU = (Double)Convert.ToDouble(dt.Rows[0][0].ToString()) ;
            }
            if ((SOLUONGXUATCU - Convert.ToDouble(dto.SOLUONGXUAT.ToString()) - Convert.ToDouble(dto.KMAI.ToString())) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE XUAT HANG MAMH:" + dto.MAMH + " FROM (" + dt.Rows[0]["SOLUONGXUAT"].ToString() + "+ " + dt.Rows[0]["KMAI"].ToString() + ") TO (" + dto.SOLUONGXUAT.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
            }
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE MATHANG  SET SOLUONGMH = SOLUONGMH + " + SOLUONGXUATCU + "-" + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            //////////  END UPDATE MATHANG //////////

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE KHOHANG  SET TONKHO =TONKHO + " + SOLUONGXUATCU + "-" + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "'";

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE TONKHO SET NHAPXUAT=-" + dto.KMAI.ToString() + " - " + dto.SOLUONGXUAT.ToString() + ", GIATIEN=" + dto.TIENTHU + " WHERE MAMH='" + dto.MAMH + "' AND MAHD='" + dto.MAHDX + "'  AND LOHANG='" + dto.LOHANG + "' ";
        }
        public void UPDATEtraCTHOADONXUAT(DTO dto)
        {
            string SQL = "SELECT SOLUONGXUAT + KMAI AS SOLUONGXUAT, KMAI FROM TRACHITIETHDX WHERE MAHDX='" + dto.MAHDX + "' AND MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "' ";
            DataTable dt = getdata(SQL);
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n update TRACHITIETHDX SET  SOLUONGXUAT=" + dto.SOLUONGXUAT.ToString() + ", KMAI=" + dto.KMAI.ToString() + ", GIABAN=" + dto.GIABAN + ", TIENTHU=" + dto.TIENTHU + ", GIANHAP=" + dto.GIANHAP + " WHERE MAMH='" + dto.MAMH + "' AND MAHDX='" + dto.MAHDX + "'  AND LOHANG='" + dto.LOHANG + "' ";

            //////////// BEGIN  UPDATE MATHANG/////////////
            
            Double SOLUONGTRAXUATCU = 0;
            if (dt.Rows.Count > 0)
            {
                SOLUONGTRAXUATCU = (Double)Convert.ToDouble(dt.Rows[0][0].ToString()) ;
            }
            if ((SOLUONGTRAXUATCU -  Convert.ToDouble(dto.SOLUONGXUAT.ToString()) -  Convert.ToDouble(dto.KMAI.ToString())) != 0)
            {
                PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- UPDATE TRA XUAT MAMH:" + dto.MAMH + " FROM (" + dt.Rows[0]["SOLUONGXUAT"].ToString() + "+ " + dt.Rows[0]["KMAI"].ToString() + ") TO (" + dto.SOLUONGXUAT.ToString() + "+ " + dto.KMAI.ToString() + ")   ";
            }
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE MATHANG  SET SOLUONGMH = SOLUONGMH - " + SOLUONGTRAXUATCU + "+" + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "'";
            //////////  END UPDATE MATHANG //////////

            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE KHOHANG  SET 	TONKHO =TONKHO - " + SOLUONGTRAXUATCU + "+" + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + "  WHERE MAMH='" + dto.MAMH + "' AND LOHANG='" + dto.LOHANG + "' ";

            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE TONKHO SET NHAPXUAT=" + dto.KMAI.ToString() + " + " + dto.SOLUONGXUAT.ToString() + ", GIATIEN=" + dto.TIENTHU + " WHERE MAMH='" + dto.MAMH + "' AND MAHD='" + dto.MAHDX + "'  AND LOHANG='" + dto.LOHANG + "' ";
        }

        public void DELETECTHOADONXUAT(string MAHDX, int ID, string MAMH, string LOHANG,string SOLUONG, string KMAI)
        {
            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n DELETE FROM TONKHO where MAHD='" + MAHDX + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO+" + SOLUONG + "+"+KMAI+" where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n UPDATE  MATHANG SET SOLUONGMH=SOLUONGMH+" + SOLUONG + "+" + KMAI + " where MAMH='" + MAMH + "' ";

            PublicVariable.SQL_XUAT = PublicVariable.SQL_XUAT + " \r\nGO\r\n DELETE FROM  CHITIETHDX where MAHDX='" + MAHDX + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";

            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- DELETE XUAT HANG MAMH:" + MAMH + " TO (" + SOLUONG + "+ " + KMAI + ")  ";
            

        }
        public void DELETEtraCTHOADONXUAT(string MAHDX, int ID, string MAMH, string LOHANG, string SOLUONG, string KMAI)
        {
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n DELETE FROM TONKHO where MAHD='" + MAHDX + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";

            //PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO-" + SOLUONG + "-" + KMAI + " where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            if (PublicVariable.isHSD)
            {
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n DELETE FROM KHOHANG where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }
            else
            {
                PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE  KHOHANG SET TONKHO=TONKHO-" + SOLUONG + "-" + KMAI + " where MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            }
            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n UPDATE  MATHANG SET SOLUONGMH=SOLUONGMH-" + SOLUONG + "-" + KMAI + " where MAMH='" + MAMH + "' ";

            PublicVariable.SQL_TRAXUAT = PublicVariable.SQL_TRAXUAT + " \r\nGO\r\n DELETE FROM  TRACHITIETHDX where MAHDX='" + MAHDX + "' AND MAMH='" + MAMH + "' AND LOHANG ='" + LOHANG + "' ";
            
            PublicVariable.TMPlog = PublicVariable.TMPlog +  "---- DELETE TRA XUAT HANG MAMH:" + MAMH + " TO (" + SOLUONG + "+ " + KMAI + ")  ";
            
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
            string SQL = "select 	MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  HOADONXUAT where NGAYXUAT='" + dto.NGAYXUAT + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }

        public DataTable GETtraHOADONXUAT(DTO dto)
        {
            string SQL = "select MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  traHOADONXUAT where NGAYXUAT='" + dto.NGAYXUAT + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }

        public string getmaxidNHAP(string MAHD)
        {
            string SQL = "select MAX(ID) FROM CHITIETHDN WHERE MAHDN='" + MAHD + "'";
            DataTable DT= getdata(SQL);
            if (DT.Rows[0][0].ToString() != "")
                return DT.Rows[0][0].ToString();

            return "0";
        }
        public string getmaxidXUAT(string MAHD)
        {
            string SQL = "select MAX(ID) FROM CHITIETHDX WHERE MAHDX='" + MAHD + "'";
            DataTable DT = getdata(SQL);
            if (DT.Rows[0][0].ToString() != "")
                return DT.Rows[0][0].ToString();

            return "0";
        }
        public string getmaxidTRANHAP(string MAHD)
        {
            string SQL = "select MAX(ID) FROM TRACHITIETHDN WHERE MAHDN='" + MAHD + "'";
            DataTable DT = getdata(SQL);
            if (DT.Rows[0][0].ToString() != "")
                return DT.Rows[0][0].ToString();

            return "0";
        }
        public string getmaxidTRAXUAT(string MAHD)
        {
            string SQL = "select MAX(ID) FROM TRACHITIETHDX WHERE MAHDX='" + MAHD + "'";
            DataTable DT = getdata(SQL);
            if (DT.Rows[0][0].ToString() != "")
                return DT.Rows[0][0].ToString();

            return "0";
        }


        
    }
}
