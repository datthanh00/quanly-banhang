using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{

    class clDao:Provider
    {
  
        public DataTable kiemtra_user(clDTO dto)
        {
           // List<MySqlParameter> sqlpa = new List<MySqlParameter>();
           // sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
           // return executeNonQuerya("KIEMTRA_USER", sqlpa);
       
            
            String SQL = "select * from NHANVIEN where USERNAME='"+dto.TENDANGNHAP+"'";
            return getdata(SQL);
        }

        public void addMatHang(clDTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
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
            sqlpa.Add(new MySqlParameter("@PICTURE", dto.PICTURE));
            sqlpa.Add(new MySqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_add", sqlpa);
            */
            String SQL = "insert into MATHANG(MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN, MOTA,TINHTRANG)"
            +" values( '"+dto.MAMH +"','"+ dto.MATH+"','"+dto.MANH+"','"+dto.MAKHO+"','"+dto.TENMH+"','"+dto.MADVT+"',"+dto.SOLUONGMH+",'"+dto.HANSUDUNG+"',"+dto.GIAMUA+","+dto.GIABAN+",'"+ dto.MOTA+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void insertNhomHang(clDTO dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            //sqlpa.Add(new MySqlParameter("@MANHOMHANG", dto.MANHOMHANG));
            //sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            //ChayProc("NHOMHANG_add", sqlpa);

            String SQL = "insert into NHOMHANG(MANH,TENNHOMHANG,GHICHU)"
            +" values('"+dto.MANH +"','"+ dto.TENNHOMHANG +"','"+ dto.GHICHU+"')";
            executeNonQuery(SQL);
        }
        public void updateThonTinCongTy(clDTO dto)
        {
            /*
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MACT", dto.MACT));
            sqlpa.Add(new MySqlParameter("@TENCT", dto.TENCT));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@MOBILE", dto.MOBILE));
            sqlpa.Add(new MySqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new MySqlParameter("@LOGO", dto.LOGO));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));

            ChayProc("THONGTINCT_update", sqlpa);
             * */
             String SQL = "update THONGTINCT set MACT= '"+dto.MACT+"',TENCT= N'"+dto.TENCT+"',DIACHI= N'"+dto.DIACHI+"',SDT= '"+dto.SDT+"',"
	        +" MOBILE= '"+dto.MOBILE+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"',MASOTHUE= '"+dto.MASOTHUE+"',WEBSITE= '"+dto.WEBSITE+"'"
            +" where 	(MACT='"+dto.MACT+"')";
            executeNonQuery(SQL);
        }//----------------GET NHAN VIEN
        public DataTable getNhanVien()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("NHANVIEN_gettrue", sqlpa);
            String SQL = "select MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from  NHANVIEN where TINHTRANG='False'";
            return getdata(SQL);

        }

        public DataTable getNhanVienBP(clDTO dto)
        {
           // List<MySqlParameter> sqlpa = new List<MySqlParameter>();
           // sqlpa.Add(new MySqlParameter("@mabp", dto.MABOPHAN));
           // return executeNonQuerya("NHANVIEN_getoneBOPHAN", sqlpa);

            String SQL = "select MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from NHANVIEN where mabp='"+dto.MABOPHAN+"' and TINHTRANG='True'";
            //String SQL = "select * from NHANVIEN";
            return getdata(SQL);

        }
        public DataTable getBoPhan()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("BOPHAN_getall", sqlpa);
            String SQL = "select MABP,TENBOPHAN,TINHTRANG from  BOPHAN";
            return getdata(SQL);
        }
        public DataTable getThongTinCT(clDTO dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@MACT",dto.MACT));
            //return executeNonQuerya("THONGTINCT_get", sqlpa);

            String SQL = "select MACT,TENCT,DIACHI,SDT,MOBILE,EMAIL,FAX,LOGO,MASOTHUE,WEBSITE from  THONGTINCT where (MACT='"+dto.MACT+"')";
            return getdata(SQL);
        }
        public void delMatHang(clDTO dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            //sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));
            //ChayProc("MATHANG_delete", sqlpa);

            String SQL = "delete MATHANG where 	(MAMH='"+dto.MAMH+"')";
            executeNonQuery(SQL);
        }
        //-------------------------THEM NGUOI DUNG --

        public void THEMNGUOIDUNG(clDTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABOPHAN));
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.MATKHAU));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("THEMNGUOIDUNG_update", sqlpa);
             */
            String SQL = "update NHANVIEN set MABP= '" + dto.MABOPHAN + "',USERNAME= '" + dto.TENDANGNHAP + "',PASSWORD= '" + dto.MATKHAU + "',TINHTRANG='" + dto.TINHTRANG + "' where MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
          public void SuaNguoiDung(clDTO dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            //sqlpa.Add(new MySqlParameter("@MABP", dto.MABOPHAN));
            //ChayProc("NHANVIEN_SuaNguoiDung", sqlpa);

            String SQL = "update NHANVIEN set MABP= '" + dto.MABOPHAN + "' where MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
          public void DoiMatKhau(clDTO dto)
          {
              /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
              sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
              sqlpa.Add(new MySqlParameter("@pass", dto.MATKHAU));
              ChayProc("NHANVIEN_DoiMatKhau", sqlpa);
              */
              String SQL = "update NHANVIEN set PASSWORD='" + dto.MATKHAU + "' where 	MANV='" + dto.MANV + "'";
              executeNonQuery(SQL);
          }
          public DataTable KiemTraMatKhau(clDTO dto)
          {
              //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
              //sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
              //sqlpa.Add(new MySqlParameter("@Pass", dto.MATKHAU));
              //return executeNonQuerya("NHANVIEN_KiemTraPass", sqlpa);
              String SQL = "select * from NHANVIEN where MANV='" + dto.MANV + "' AND PASSWORD='" + dto.MATKHAU + "'";
              return getdata(SQL);

          }
        public void XoaNguoiDUng(clDTO dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            //ChayProc("NHANVIEN_XoaPQ", sqlpa);
            String SQL = "update NHANVIEN set MABP=null,USERNAME=null,PASSWORD=null,TINHTRANG= 'False' where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
        public DataTable getNhomHang()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("NHOMHANG_getall", sqlpa);

            String SQL = "select MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
            
        }
        //------------------Get all Kho-------------------
        public DataTable getKho()
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("KHO_getall", sqlpa);
            String SQL = "select 	MAKHO,MANV,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG from  KHO";
            return getdata(SQL);
        }
        //------------------------TON KHO
        public DataTable getTonKhoTTngay2(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "")
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }

            String SQL = " SELECT  convert(varchar,TONKHOTT.NGAY,103) AS NGAY, SOLUONGMH -TONTT AS CHENHLECH,T2.MAMH,TENMH, TENNCC, DONVITINH,KLDVT,TONTT,SOLUONGMH AS TONCUOI,TONTT*kldvt as KLTONTT,(SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP))*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,SOLUONGMH*KLDVT AS KLTONCUOI,SOLUONGMH*giamua AS THANHTIENTONCUOI, NHAP,NHAP*GIAMUA AS THANHTIENNHAP, XUAT,XUAT*GIABAN AS THANHTIENXUAT,TRANHAP,TRANHAP*GIAMUA AS THANHTIENTRANHAP ,TRAXUAT,TRAXUAT*GIABAN AS THANHTIENTRAXUAT,SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP) AS TONDAU,(SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP))* GIAMUA AS THANHTIENTONDAU,GIAMUA,GIABAN FROM "
              + " (SELECT ngay,MATHANG.TENMH,MANCC,MADVT,KLDVT,SOLUONGMH,GIAMUA,GIABAN,MATHANG.MAMH, CASE WHEN NHAP IS NULL THEN 0 ELSE NHAP END AS NHAP, CASE WHEN XUAT IS NULL THEN 0 ELSE XUAT END AS XUAT, "
              + " CASE WHEN TRANHAP IS NULL THEN 0 ELSE TRANHAP END AS TRANHAP,CASE WHEN TRAXUAT IS NULL THEN 0 ELSE TRAXUAT END AS TRAXUAT "
              + " FROM MATHANG LEFT JOIN (select mamh,ngay, SUM(NHAP) AS NHAP,SUM(XUAT) AS XUAT,SUM(TRANHAP) AS TRANHAP,SUM(TRAXUAT) AS TRAXUAT "
              + " from tonkho WHERE NGAY='" + dto.NGAYBDKHO + "'  group by mamh,ngay) AS T2 ON MATHANG.MAMH=T2.MAMH WHERE MATHANG.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1 + ") T2, NHACUNGCAP,DONVITINH,TONKHOTT WHERE T2.MANCC=NHACUNGCAP.MANCC AND T2.MADVT=DONVITINH.MADVT AND T2.MAMH=TONKHOTT.MAMH and TONKHOTT.NGAY='" + dto.NGAYBDKHO + "'";

            return getdata(SQL);
        }

        public DataTable getTonKhoTTngay(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "")
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }

            String SQL = " SELECT  convert(varchar,'" + dto.NGAYBD + "',103) AS NGAY, SOLUONGMH-SOLUONGMH AS CHENHLECH,T2.MAMH,TENMH, TENNCC, DONVITINH,KLDVT,SOLUONGMH*kldvt as KLTONTT,(SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP))*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,SOLUONGMH*KLDVT AS KLTONCUOI,SOLUONGMH AS TONCUOI,SOLUONGMH AS TONTT,SOLUONGMH*giamua AS THANHTIENTONCUOI, NHAP,NHAP*GIAMUA AS THANHTIENNHAP, XUAT,XUAT*GIABAN AS THANHTIENXUAT,TRANHAP,TRANHAP*GIAMUA AS THANHTIENTRANHAP ,TRAXUAT,TRAXUAT*GIABAN AS THANHTIENTRAXUAT,SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP) AS TONDAU,(SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP))* GIAMUA AS THANHTIENTONDAU,GIAMUA,GIABAN FROM "
            + " (SELECT ngay,MATHANG.TENMH,MANCC,MADVT,KLDVT,SOLUONGMH,GIAMUA,GIABAN,MATHANG.MAMH, CASE WHEN NHAP IS NULL THEN 0 ELSE NHAP END AS NHAP, CASE WHEN XUAT IS NULL THEN 0 ELSE XUAT END AS XUAT, "
            + " CASE WHEN TRANHAP IS NULL THEN 0 ELSE TRANHAP END AS TRANHAP,CASE WHEN TRAXUAT IS NULL THEN 0 ELSE TRAXUAT END AS TRAXUAT "
            + " FROM MATHANG LEFT JOIN (select mamh,ngay, SUM(NHAP) AS NHAP,SUM(XUAT) AS XUAT,SUM(TRANHAP) AS TRANHAP,SUM(TRAXUAT) AS TRAXUAT "
            + " from tonkho WHERE NGAY='" + dto.NGAYBDKHO + "'  group by mamh,ngay) AS T2 ON MATHANG.MAMH=T2.MAMH WHERE MATHANG.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1 + ") T2, NHACUNGCAP,DONVITINH WHERE T2.MANCC=NHACUNGCAP.MANCC AND T2.MADVT=DONVITINH.MADVT ";

            return getdata(SQL);
        }

        public DataTable getTonKho(clDTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("TONKHO_getall", sqlpa);
            */
           // String SQL = "select TENNHOMHANG,TENMH,MATHANG.MAKHO,TONKHO.MAMH,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH "
           // + " AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MAKHO='"+dto.MAKHO +"' AND"
          //  + " NGAYTHANG BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "")
            {
                SQL1 =SQL1+ " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }
            /*
            String SQL = "select *,GIAMUA*TONDAU AS THANHTIENTONDAU,GIAMUA*XUAT AS THANHTIENXUAT, GIAMUA*NHAP AS THANHTIENNHAP,GIAMUA*TONCUOI AS THANHTIENTONCUOI,GIAMUA,GIAMUA*TRANHAP AS THANHTIENTRANHAP, GIAMUA*TRAXUAT AS THANHTIENTRAXUAT FROM  (SELECT MAMH, TENMH,TENNCC,KLDVT,  DONVITINH,GIAMUA, CASE WHEN MAMH2<>'' THEN TRANHAP2 ELSE TRANHAP END AS TRANHAP, CASE WHEN MAMH2<>'' THEN TRAXUAT2 ELSE TRAXUAT END AS TRAXUAT, CASE WHEN MAMH2<>'' THEN NHAP2 ELSE NHAP END AS NHAP, CASE WHEN MAMH2<>'' THEN XUAT2 ELSE XUAT END AS XUAT, CASE WHEN MAMH2<>'' THEN TONDAU2 ELSE TONDAU END AS TONDAU, CASE WHEN MAMH2<>'' THEN TONCUOI2 ELSE TONCUOI END AS TONCUOI FROM "
            + "(SELECT MATHANG.MAMH,GIAMUA, TENMH,TENNCC,KLDVT, DONVITINH, SOLUONGMH AS TONDAU, 0 AS NHAP,0 as TRANHAP, 0 AS XUAT,0 AS TRAXUAT,SOLUONGMH AS TONCUOI FROM MATHANG, DONVITINH,NHACUNGCAP WHERE  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' and MATHANG.MADVT=DONVITINH.MADVT  " + SQL1 + "  AND MATHANG.MANCC=NHACUNGCAP.MANCC ) AS T3"
            + " LEFT JOIN (SELECT  T2.MAMH AS MAMH2,TONDAU AS TONDAU2, NHAP AS NHAP2, TRANHAP AS TRANHAP2, XUAT AS XUAT2, TRAXUAT AS TRAXUAT2, TONDAU+NHAP-XUAT AS TONCUOI2 FROM "
            + " (SELECT T1.MAMH, NHAP ,XUAT,TRANHAP,TRAXUAT,"
            + " CASE WHEN TONDAU>=0 THEN TONDAU ELSE (SELECT TONCUOI FROM (SELECT TOP 1 TONCUOI,STT  FROM TONKHO WHERE MAMH=T1.MAMH AND NGAY < '" + dto.NGAYBDKHO + "'  ORDER BY STT DESC ) AS TH) END AS TONDAU   "
            + " FROM (SELECT MATHANG.MAMH, SUM(NHAP) AS NHAP, SUM(TRANHAP) AS TRANHAP, SUM(XUAT) AS XUAT, SUM(TRAXUAT) AS TRAXUAT,TONDAU=(SELECT TOP 1 TONDAU FROM TONKHO WHERE NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND MATHANG.MAMH=TONKHO.MAMH ) "
            + " FROM ( SELECT * FROM MATHANG WHERE MAKHO='" + PublicVariable.MAKHO + "') AS MATHANG, (SELECT * FROM TONKHO WHERE NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "')AS TONKHO WHERE  MATHANG.MAMH = TONKHO.MAMH GROUP BY MATHANG.MAMH ) AS T1) AS T2) AS T ON T3.MAMH=T.MAMH2) as T9";
            */
            String SQL = "SELECT *,tondau*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI FROM "
            +" (SELECT * FROM (select MATHANG.MAMH,TENMH,GIAMUA,TENNCC,KLDVT,DONVITINH,SOLUONGMH AS TONDAU,SOLUONGMH*GIAMUA AS THANHTIENTONDAU,0 AS NHAP, 0 AS THANHTIENNHAP,0 AS TRANHAP,0 AS THANHTIENTRANHAP,0 AS XUAT,0 AS THANHTIENXUAT,0 AS TRAXUAT,0 AS THANHTIENTRAXUAT,SOLUONGMH AS TONCUOI,SOLUONGMH*GIABAN AS THANHTIENTONCUOI FROM MATHANG,NHACUNGCAP,DONVITINH WHERE NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH NOT IN( SELECT DISTINCT MAMH FROM TONKHO WHERE TONKHO.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1 + ") AS T1"
            + " UNION ALL(SELECT MAMH,TENMH,GIAMUA,TENNCC,KLDVT,DONVITINH,(TONCUOI-(NHAP-TRANHAP-XUAT+TRAXUAT)) AS TONDAU,(TONCUOI-(NHAP-TRANHAP-XUAT+TRAXUAT))*GIAMUA AS THANHTIENTONDAU,NHAP,THANHTIENNHAP,TRANHAP,THANHTIENTRANHAP,XUAT, THANHTIENXUAT,TRAXUAT,THANHTIENTRAXUAT,TONCUOI,THANHTIENTONCUOI"
            + " FROM (select MATHANG.MAMH,TENMH,TENNCC,KLDVT,DONVITINH,GIAMUA,SUM(TRAXUAT)AS TRAXUAT,SUM(NHAP) AS NHAP,SUM(TRANHAP) AS TRANHAP,SUM(XUAT) AS XUAT,SOLUONGMH AS TONCUOI,SUM(NHAP*GIANHAP) AS THANHTIENNHAP,SUM(TRANHAP*GIANHAP) AS THANHTIENTRANHAP,SUM(XUAT*GIAXUAT) AS THANHTIENXUAT, SUM(TRAXUAT*GIAXUAT) AS THANHTIENTRAXUAT,SOLUONGMH*GIABAN AS THANHTIENTONCUOI FROM TONKHO, NHACUNGCAP,MATHANG,DONVITINH WHERE TONKHO.MAMH=MATHANG.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT=DONVITINH.MADVT " + SQL1 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'  GROUP BY  MATHANG.MAMH,TENMH,TENNCC,KLDVT,DONVITINH,SOLUONGMH,SOLUONGMH*GIABAN,GIAMUA)AS T2)) AS TB1";
            
            return getdata(SQL);
        }
        public DataTable getTonKhoncc(clDTO dto)
        {
            String SQL = "SELECT TENNCC,SUM(tondau*KLDVT) AS KLTONDAU,SUM(NHAP*KLDVT) AS KLNHAP,SUM(TRANHAP*KLDVT) AS KLTRANHAP,SUM(XUAT*KLDVT) AS KLXUAT,SUM(TRAXUAT*KLDVT) AS KLTRAXUAT,SUM(TONCUOI*KLDVT) AS KLTONCUOI,SUM(TONDAU)AS TONDAU,SUM(THANHTIENTONDAU) AS THANHTIENTONDAU,SUM(NHAP) AS NHAP,SUM(THANHTIENNHAP) AS THANHTIENNHAP,SUM(TRANHAP) AS TRANHAP,SUM(THANHTIENTRANHAP) AS THANHTIENTRANHAP,SUM(XUAT) AS XUAT,SUM(THANHTIENXUAT) AS THANHTIENXUAT,SUM(TRAXUAT) AS TRAXUAT,SUM(THANHTIENTRAXUAT) AS THANHTIENTRAXUAT,SUM(TONCUOI) AS TONCUOI,SUM(THANHTIENTONCUOI) AS THANHTIENTONCUOI FROM "
            + "(SELECT * FROM (select MATHANG.MAMH,TENMH,GIAMUA,TENNCC,KLDVT,DONVITINH,SOLUONGMH AS TONDAU,SOLUONGMH*GIAMUA AS THANHTIENTONDAU,0 AS NHAP, 0 AS THANHTIENNHAP,0 AS TRANHAP,0 AS THANHTIENTRANHAP,0 AS XUAT,0 AS THANHTIENXUAT,0 AS TRAXUAT,0 AS THANHTIENTRAXUAT,SOLUONGMH AS TONCUOI,SOLUONGMH*GIABAN AS THANHTIENTONCUOI FROM MATHANG,NHACUNGCAP,DONVITINH WHERE NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MAMH NOT IN( SELECT DISTINCT MAMH FROM TONKHO WHERE TONKHO.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "') AS T1"
            + " UNION ALL(SELECT MAMH,TENMH,GIAMUA,TENNCC,KLDVT,DONVITINH,(TONCUOI-(NHAP-TRANHAP-XUAT+TRAXUAT)) AS TONDAU,(TONCUOI-(NHAP-TRANHAP-XUAT+TRAXUAT))*GIAMUA AS THANHTIENTONDAU,NHAP,THANHTIENNHAP,TRANHAP,THANHTIENTRANHAP,XUAT, THANHTIENXUAT,TRAXUAT,THANHTIENTRAXUAT,TONCUOI,THANHTIENTONCUOI"
            + " FROM (select MATHANG.MAMH,TENMH,TENNCC,KLDVT,DONVITINH,GIAMUA,SUM(TRAXUAT)AS TRAXUAT,SUM(NHAP) AS NHAP,SUM(TRANHAP) AS TRANHAP,SUM(XUAT) AS XUAT,SOLUONGMH AS TONCUOI,SUM(NHAP*GIANHAP) AS THANHTIENNHAP,SUM(TRANHAP*GIANHAP) AS THANHTIENTRANHAP,SUM(XUAT*GIAXUAT) AS THANHTIENXUAT, SUM(TRAXUAT*GIAXUAT) AS THANHTIENTRAXUAT,SOLUONGMH*GIABAN AS THANHTIENTONCUOI FROM TONKHO, NHACUNGCAP,MATHANG,DONVITINH WHERE TONKHO.MAMH=MATHANG.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT=DONVITINH.MADVT  AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'  GROUP BY  MATHANG.MAMH,TENMH,TENNCC,KLDVT,DONVITINH,SOLUONGMH,SOLUONGMH*GIABAN,GIAMUA)AS T2)) AS TB1 GROUP BY TENNCC";

            return getdata(SQL);
        }
        //--------------------Backup Restore---------------------------
        public  void Backup(clDTO DTO)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@TENFILE",DTO.TENFILE));
            //ChayProc("BACKUP_DATABASE", sqlpa);
            try
            {
                Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
                String SQL = "BACKUP DATABASE " + AppC.AppSettings.Settings["database"].Value.ToString() + " TO DISK = '" + DTO.TENFILE + "'";
               
                executeNonQuery(SQL);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("không backup được");
            }
        }
        public DataTable getDoanhThu(clDTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAY_BD", dto.NGAYBD));
            sqlpa.Add(new MySqlParameter("@NGAY_KT", dto.NGAYKT));
            sqlpa.Add(new MySqlParameter("@LOAI_TG", dto.LOAITG));
            return executeNonQuerya("THONGKE_DOANHTHU", sqlpa);*/
            String SQL ="select  NGAYXUAT , TENKH as 'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND  NGAYXUAT BETWEEN '"+dto.NGAYBD+"' AND '"+dto.NGAYKT+"' group by TENKH,TENKV,ngayxuat AND HOADONXUAT.MAKHO='"+PublicVariable.MAKHO+"'";
            
            return getdata(SQL);
        }
        public DataTable getcpmuahangngay(clDTO dto)
        {
            String SQL = "select NGAY AS NGAYNHAP ,SUM((NHAP-TRANHAP)*GIANHAP) AS CHIPHI, SUM((NHAP-TRANHAP)*KLDVT) AS KHOILUONG FROM TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND  (NHAP - TRANHAP<>0)  AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND TONKHO.MAKHO='"+PublicVariable.MAKHO+"'  group by NGAY";
            return getdata(SQL);
        }

        public DataTable getcpmuahangncc(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MANCC != "")
            {
                SQL1 = " AND NHACUNGCAP.MANCC='" + dto.MANCC + "'  ";
            }
            String SQL = "select NHACUNGCAP.MANCC,TENNCC,TENKV,SUM((NHAP-TRANHAP)*GIANHAP) AS CHIPHI,SUM((NHAP-TRANHAP)*KLDVT) AS KHOILUONG FROM NHACUNGCAP,KHUVUC,TONKHO,MATHANG WHERE  MATHANG.MAMH=TONKHO.MAMH AND KHUVUC.MAKV=NHACUNGCAP.MAKV AND TONKHO.MADOITUONG=NHACUNGCAP.MANCC AND (NHAP-TRANHAP<>0) AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1 + " AND TONKHO.NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by NHACUNGCAP.MANCC,TENNCC,TENKV";
            return getdata(SQL);
        }
        public DataTable getDoanhThungay(clDTO dto)
        {
            String SQL = "select NGAY AS NGAYXUAT ,SUM((XUAT-TRAXUAT)*GIAXUAT) AS DOANHTHU,SUM((XUAT-TRAXUAT)*KLDVT) AS KHOILUONG FROM TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND   (XUAT - TRAXUAT<>0) AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by NGAY";

            return getdata(SQL);
        }
        public DataTable getDoanhThukh(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAKH != "")
            {
                SQL1 = " AND KHACHHANG.MAKH='" + dto.MAKH + "'  ";
            }

            String SQL = "select KHACHHANG.MAKH,TENKH,SDT ,TENKV,SUM((XUAT-TRAXUAT)*GIAXUAT) AS DOANHTHU,SUM((XUAT-TRAXUAT)*KLDVT) AS KHOILUONG FROM KHACHHANG,KHUVUC,TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND TONKHO.MADOITUONG=KHACHHANG.MAKH AND KHUVUC.MAKV=KHACHHANG.MAKV  AND (XUAT-TRAXUAT<>0) AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1 + " AND TONKHO.NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by KHACHHANG.MAKH,TENKH,SDT,TENKV";
            return getdata(SQL);
        }
        public DataTable getDoanhsonv(clDTO dto)
        {

            String SQL = "select NHANVIEN.MANV,TENNV ,SUM((XUAT-TRAXUAT)*GIAXUAT) AS DOANHSO,SUM((XUAT-TRAXUAT)*KLDVT) AS KHOILUONG FROM TONKHO,NHANVIEN,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND TONKHO.MANV=NHANVIEN.MANV AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by NHANVIEN.MANV,TENNV";
            return getdata(SQL);
        }
        public DataTable getcpmuahangsp(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }

            String SQL = "select TENMH ,MATHANG.MAMH,TENNCC,DONVITINH,KLDVT ,SUM((NHAP-TRANHAP)*GIANHAP) as TIENPHAITRA,SUM((NHAP-TRANHAP)*KLDVT) AS KHOILUONG from MATHANG,NHACUNGCAP,DONVITINH,TONKHO where  MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND NHACUNGCAP.MANCC=MATHANG.MANCC AND (NHAP-TRANHAP<>0) " + SQL1 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' and TONKHO.NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' GROUP BY TENMH,MATHANG.MAMH,TENNCC,DONVITINH,KLDVT";
            return getdata(SQL);
        }
        public DataTable getDoanhsosp(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }

            String SQL = "select TENMH ,TONKHO.MAMH,TENNCC,DONVITINH,KLDVT,sum((XUAT-TRAXUAT)*GIAXUAT) as DOANHSO,sum((XUAT-TRAXUAT)*KLDVT) as KHOILUONG FROM TONKHO,MATHANG,NHACUNGCAP,DONVITINH WHERE TONKHO.MAMH=MATHANG.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT " + SQL1 + "  AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by TENMH ,TONKHO.MAMH,TENNCC,DONVITINH,KLDVT";
            return getdata(SQL);
        }
        public DataTable testLogin(clDTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.MATKHAU));
            return executeNonQuerya("TEST_NHANVIEN", sqlpa);
            */
            string SQL="select 	MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from  NHANVIEN"
            + " where 	PASSWORD='"+dto.MATKHAU+"' and USERNAME='"+dto.TENDANGNHAP+"'";
            return getdata(SQL);
        }

       
    }
}
