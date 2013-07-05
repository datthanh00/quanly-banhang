﻿using System;
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
            String SQL = "select * from NHANVIEN where USERNAME='"+dto.TENDANGNHAP+"'";
            return getdata(SQL);
        }

        public void addMatHang(clDTO dto)
        {
            String SQL = "insert into MATHANG(MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN, MOTA,TINHTRANG)"
            +" values( '"+dto.MAMH +"','"+ dto.MATH+"','"+dto.MANH+"','"+dto.MAKHO+"','"+dto.TENMH+"','"+dto.MADVT+"',"+dto.SOLUONGMH+",'"+dto.HANSUDUNG+"',"+dto.GIAMUA+","+dto.GIABAN+",'"+ dto.MOTA+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void insertNhomHang(clDTO dto)
        {
            String SQL = "insert into NHOMHANG(MANH,TENNHOMHANG,GHICHU)"
            +" values('"+dto.MANH +"','"+ dto.TENNHOMHANG +"','"+ dto.GHICHU+"')";
            executeNonQuery(SQL);
        }
        public void updateThonTinCongTy(clDTO dto)
        {
             String SQL = "update THONGTINCT set MACT= '"+dto.MACT+"',TENCT= N'"+dto.TENCT+"',DIACHI= N'"+dto.DIACHI+"',SDT= '"+dto.SDT+"',"
	        +" MOBILE= '"+dto.MOBILE+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"',MASOTHUE= '"+dto.MASOTHUE+"',WEBSITE= '"+dto.WEBSITE+"'"
            +" where 	(MACT='"+dto.MACT+"')";
            executeNonQuery(SQL);
        }//----------------GET NHAN VIEN
        public DataTable getNhanVien()
        {
            String SQL = "select MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from  NHANVIEN where TINHTRANG='False'";
            return getdata(SQL);
        }

        public DataTable getNhanVienBP(clDTO dto)
        {
            String SQL = "select MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from NHANVIEN where mabp='"+dto.MABOPHAN+"' and TINHTRANG='True'";
            return getdata(SQL);

        }
        public DataTable getBoPhan()
        {
            String SQL = "select MABP,TENBOPHAN,TINHTRANG from  BOPHAN";
            return getdata(SQL);
        }
        public DataTable getThongTinCT(clDTO dto)
        {
            String SQL = "select MACT,TENCT,DIACHI,SDT,MOBILE,EMAIL,FAX,LOGO,MASOTHUE,WEBSITE from  THONGTINCT where (MACT='"+dto.MACT+"')";
            return getdata(SQL);
        }
        public void delMatHang(clDTO dto)
        {
            String SQL = "delete MATHANG where 	(MAMH='"+dto.MAMH+"')";
            executeNonQuery(SQL);
        }
        //-------------------------THEM NGUOI DUNG --

        public void THEMNGUOIDUNG(clDTO dto)
        {
            String SQL = "update NHANVIEN set MABP= '" + dto.MABOPHAN + "',USERNAME= '" + dto.TENDANGNHAP + "',PASSWORD= '" + dto.MATKHAU + "',TINHTRANG='" + dto.TINHTRANG + "' where MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
          public void SuaNguoiDung(clDTO dto)
        {
            String SQL = "update NHANVIEN set MABP= '" + dto.MABOPHAN + "' where MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
          public void DoiMatKhau(clDTO dto)
          {
              String SQL = "update NHANVIEN set PASSWORD='" + dto.MATKHAU + "' where 	MANV='" + dto.MANV + "'";
              executeNonQuery(SQL);
          }
          public DataTable KiemTraMatKhau(clDTO dto)
          {
              String SQL = "select * from NHANVIEN where MANV='" + dto.MANV + "' AND PASSWORD='" + dto.MATKHAU + "'";
              return getdata(SQL);

          }
        public void XoaNguoiDUng(clDTO dto)
        {
            String SQL = "update NHANVIEN set MABP=null,USERNAME=null,PASSWORD=null,TINHTRANG= 'False' where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
        public DataTable getNhomHang()
        {
            String SQL = "select MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
        }
        //------------------Get all Kho-------------------
        public DataTable getKho()
        {
            String SQL = "select 	MAKHO,MANV,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG from  KHO";
            return getdata(SQL);
        }
        //------------------------TON KHO
        public DataTable getTonKhoTTngay2(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "" && dto.MAMH != null)
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }

            String SQL = "SELECT TENMH,MATHANG.MAMH,GIAMUA,LOHANG, MATHANG.MANCC, TENNCC,KLDVT, DONVITINH,convert(varchar,GETDATE(),103) AS NGAY, TONCUOI AS TONTT, TONCUOI-TONCUOI AS CHENHLECH, TONDAU, TONDAU*KLDVT AS KLTONDAU, TONDAU*GIAMUA AS THANHTIENTONDAU, NHAP, NHAP*KLDVT AS KLNHAP, THANHTIENNHAP, XUAT, XUAT*KLDVT AS KLXUAT, THANHTIENXUAT, TRANHAP, TRANHAP*KLDVT AS KLTRANHAP, THANHTIENTRANHAP, TRAXUAT, TRAXUAT*KLDVT AS KLTRAXUAT, THANHTIENTRAXUAT, TONCUOI, TONCUOI*KLDVT AS KLTONCUOI, TONCUOI*GIAMUA AS THANHTIENTONCUOI FROM"
            +" (SELECT KHOHANG.MAMH,KHOHANG.LOHANG,(KHOHANG.TONKHO -(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY = '" + dto.NGAYBDKHO + "' ) )AS TONDAU,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY = '" + dto.NGAYBDKHO + "') AS NHAP,"
            +" (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENNHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS XUAT,"
            +" (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENXUAT,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS TRANHAP,"
            +" (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENTRANHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS TRAXUAT,"
            +" (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENTRAXUAT,KHOHANG.TONKHO AS TONCUOI FROM KHOHANG) AS T1, MATHANG,NHACUNGCAP, DONVITINH WHERE MATHANG.MAMH=T1.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT = DONVITINH.MADVT";

            return getdata(SQL);
        }

        public DataTable getTonKhoTTngay(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "" && dto.MAMH != null)
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }

            String SQL = "SELECT TENMH,MATHANG.MAMH,GIAMUA,LOHANG, MATHANG.MANCC, TENNCC,KLDVT, DONVITINH,convert(varchar,GETDATE(),103) AS NGAY, TONTT, TONTT-TONCUOI AS CHENHLECH, TONDAU, TONDAU*KLDVT AS KLTONDAU, TONDAU*GIAMUA AS THANHTIENTONDAU, NHAP, NHAP*KLDVT AS KLNHAP, THANHTIENNHAP, XUAT, XUAT*KLDVT AS KLXUAT, THANHTIENXUAT, TRANHAP, TRANHAP*KLDVT AS KLTRANHAP, THANHTIENTRANHAP, TRAXUAT, TRAXUAT*KLDVT AS KLTRAXUAT, THANHTIENTRAXUAT, TONCUOI, TONCUOI*KLDVT AS KLTONCUOI, TONCUOI*GIAMUA AS THANHTIENTONCUOI FROM"
             + " (SELECT KHOHANG.MAMH,TONKHONGAY AS TONTT,KHOHANG.LOHANG,(KHOHANG.TONKHO -(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY = '" + dto.NGAYBDKHO + "' ) )AS TONDAU,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY = '" + dto.NGAYBDKHO + "') AS NHAP,"
             + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENNHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS XUAT,"
             + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENXUAT,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS TRANHAP,"
             + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENTRANHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS TRAXUAT,"
             + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY ='" + dto.NGAYBDKHO + "') AS THANHTIENTRAXUAT,KHOHANG.TONKHO AS TONCUOI FROM (SELECT KHOHANG.MAMH,TONKHO,KHOHANG.LOHANG,TONKHONGAY FROM KHOHANG, TONKHOTT WHERE KHOHANG.MAMH=TONKHOTT.MAMH AND KHOHANG.LOHANG=TONKHOTT.LOHANG AND TONKHOTT.NGAY='" + dto.NGAYBDKHO + "') AS KHOHANG) AS T1, MATHANG,NHACUNGCAP, DONVITINH WHERE MATHANG.MAMH=T1.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT = DONVITINH.MADVT";

            return getdata(SQL);
        }

        public DataTable getTonKho(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "" && dto.MAMH != null)
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 =SQL1+ " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }
            
           // String SQL = "SELECT *, TONDAU*KLDVT AS KLTONDAU, NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP, XUAT*KLDVT AS KLXUAT, TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI ,TONDAU*GIABAN AS THANHTIENTONDAU, NHAP*GIABAN AS THANHTIENNHAP,TRANHAP*GIABAN AS THANHTIENTRANHAP, XUAT*GIABAN AS THANHTIENXUAT, TRAXUAT*GIABAN AS THANHTIENTRAXUAT, TONCUOI*GIABAN AS THANHTIENTONCUOI"
          //  + " FROM(SELECT T3.*,TONKHONGAY AS TONCUOI, (TONKHONGAY-(NHAP-TRANHAP-XUAT+TRAXUAT)) AS TONDAU FROM (select MAMH,TENMH,TENNCC,KLDVT,DONVITINH,GIAMUA,GIABAN,CASE WHEN NHAP IS NULL THEN 0 ELSE NHAP END AS NHAP ,CASE WHEN TRANHAP IS NULL THEN 0 ELSE TRANHAP END AS TRANHAP ,CASE WHEN XUAT IS NULL THEN 0 ELSE XUAT END AS XUAT ,CASE WHEN TRAXUAT IS NULL THEN 0 ELSE TRAXUAT END AS TRAXUAT "
        //    + " FROM (select t1.*,SUM(nhap) AS NHAP,SUM(tranhap) AS TRANHAP,SUM(xuat) AS XUAT,SUM(traxuat) AS TRAXUAT from (select mathang.mamh,tenmh,TENNCC,KLDVT,DONVITINH,GIAMUA,GIABAN from mathang,DONVITINH,NHACUNGCAP WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC " + SQL1 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' )  as t1 LEFT JOIN (SELECT * FROM TONKHO WHERE TONKHO.MAKHO='" + PublicVariable.MAKHO + "' AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' ) AS tonkho on tonkho.mamh= t1.mamh GROUP BY T1.MAMH, T1.TENMH, T1.TENNCC,T1.KLDVT,T1.DONVITINH, T1.GIAMUA, T1.GIABAN ) AS T2) AS T3, (SELECT * FROM TONKHOTT WHERE NGAY='" + dto.NGAYKTKHO + "' AND MAKHO='" + PublicVariable.MAKHO + "') AS TONKHOTT WHERE T3.MAMH=TONKHOTT.MAMH) AS T6";
            String SQL = " SELECT T1.MAMH,GIAMUA, TONDAU,NHAP,TRANHAP,XUAT,TRAXUAT,TONCUOI,KLDVT, TENMH,TENNCC,DONVITINH,TONDAU*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI,GIAMUA* TONDAU AS THANHTIENTONDAU, GIAMUA*TONCUOI AS THANHTIENTONCUOI,THANHTIENNHAP,THANHTIENXUAT,THANHTIENTRANHAP,THANHTIENTRAXUAT FROM"
            + " (SELECT MATHANG.MAMH,(SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=MATHANG.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY <= '" + dto.NGAYBDKHO + "' ) AS TONDAU,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS NHAP,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY  BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENNHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY  BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS XUAT,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENXUAT,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY  BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS TRANHAP,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENTRANHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY  BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS TRAXUAT,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENTRAXUAT,(SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=MATHANG.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY <= '" + dto.NGAYKTKHO + "' ) AS TONCUOI FROM MATHANG WHERE MATHANG.MAKHO='" + PublicVariable.MAKHO + "') AS T1, MATHANG, NHACUNGCAP,DONVITINH WHERE MATHANG.MAMH=T1.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND DONVITINH.MADVT=MATHANG.MADVT " +SQL1;

            return getdata(SQL);
        }
        public DataTable getTonKhoncc(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'  ";
            }
            String SQL = " SELECT MANCC,TENNCC, SUM(TONDAU) AS TONDAU,SUM(NHAP) AS NHAP,SUM(XUAT) AS XUAT,SUM(TRANHAP) AS TRANHAP,SUM(TRAXUAT) AS TRAXUAT,SUM(TONCUOI) AS TONCUOI,SUM(KLTONDAU) AS KLTONDAU,SUM(KLNHAP) AS KLNHAP,SUM(KLXUAT) AS KLXUAT,SUM(KLTRANHAP) AS KLTRANHAP,SUM(KLTRAXUAT) AS KLTRAXUAT,SUM(KLTONCUOI) AS KLTONCUOI, SUM(THANHTIENTONDAU) AS THANHTIENTONDAU,SUM(THANHTIENNHAP) AS THANHTIENNHAP,SUM(THANHTIENXUAT) AS THANHTIENXUAT,SUM(THANHTIENTRANHAP) AS THANHTIENTRANHAP,SUM(THANHTIENTRAXUAT) AS THANHTIENTRAXUAT,SUM(THANHTIENTONCUOI) AS THANHTIENTONCUOI FROM ("
            + " SELECT MATHANG.MANCC,TENNCC, TONDAU,NHAP,XUAT,TRANHAP,TRAXUAT,TONCUOI,TONDAU*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI, TONDAU*GIAMUA AS THANHTIENTONDAU, TONCUOI*GIAMUA AS THANHTIENTONCUOI,THANHTIENNHAP AS THANHTIENNHAP,THANHTIENXUAT AS THANHTIENXUAT,THANHTIENTRANHAP AS THANHTIENTRANHAP,THANHTIENTRAXUAT AS THANHTIENTRAXUAT FROM"
            + " (SELECT MATHANG.MAMH,(SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=MATHANG.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY <= '" + dto.NGAYBDKHO + "' ) AS TONDAU,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS NHAP,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENNHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS XUAT,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENXUAT,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS TRANHAP,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENTRANHAP,(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS TRAXUAT,"
            + " (SELECT CASE WHEN SUM(GIATIEN) IS NULL THEN 0 ELSE SUM(GIATIEN) END  FROM TONKHO WHERE TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS THANHTIENTRAXUAT,(SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=MATHANG.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=MATHANG.MAMH AND TONKHO.NGAY <= '" + dto.NGAYKTKHO + "' ) AS TONCUOI FROM MATHANG) AS T1, MATHANG, NHACUNGCAP,DONVITINH "
            +" WHERE MATHANG.MAMH=T1.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND DONVITINH.MADVT=MATHANG.MADVT "+SQL1+") AS TB1 GROUP BY MANCC,TENNCC ";

            return getdata(SQL);
        }
        //--------------------Backup Restore---------------------------


        public void KET_SO()
        {
            string SQLKETSO= "\r\nGO\r\n DELETE TONDAUPHAITHU WHERE [TONGTIENTRA]-[TIENDATRA]=0 "
            + "\r\nGO\r\n DELETE TONDAUPHAITRA WHERE [TONGTIENTRA]-[TIENDATRA]=0 "
            + "\r\nGO\r\n DELETE TONDAUKHOHANG "
            + "\r\nGO\r\n DELETE TONDAUMATHANG "
            + "\r\nGO\r\n INSERT INTO TONDAUKHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO],[HSD]) SELECT MAMH,LOHANG,GIAMUA,TONKHO,HSD FROM KHOHANG WHERE TONKHO >0 "
            + "\r\nGO\r\n INSERT INTO TONDAUMATHANG ([MAMH],[TONDAU]) SELECT MAMH, SOLUONGMH AS TONDAU FROM MATHANG "
            + "\r\nGO\r\n DELETE TONDAUCONGNO "
            + "\r\nGO\r\n INSERT INTO TONDAUCONGNO ([MA],[TONGTIENTRA],[TIENDATRA],[NGAY]) SELECT MA, TONGTIENTRA,TIENDATRA,NGAY FROM TONDAUPHAITRA "
            + "\r\nGO\r\n DELETE TONDAUPHAITRA "
            + "\r\nGO\r\n INSERT INTO TONDAUPHAITRA ([MA],[TONGTIENTRA],[TIENDATRA],[NGAY]) SELECT  MA, SUM(TONGTIENTRA) AS TONGTIENTRA,SUM(TIENDATRA) AS TIENDATRA,convert(varchar,GETDATE(),101)AS NGAY FROM (SELECT  MANCC AS MA,(TIENPHAITRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA  FROM HOADONNHAP WHERE TYPE=1 AND TIENPHAITRA-TIENDATRA<>0 UNION ALL   SELECT MA ,(TONGTIENTRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA  FROM TONDAUCONGNO WHERE TONGTIENTRA-TIENDATRA<>0 UNION ALL SELECT MAKH AS MA,(TIENPHAITRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA FROM TRAHOADONXUAT WHERE  TYPE=1 AND TIENPHAITRA-TIENDATRA<>0 ) AS T1 GROUP BY MA "
            + "\r\nGO\r\n DELETE TONDAUCONGNO "
            + "\r\nGO\r\n INSERT INTO TONDAUCONGNO ([MA],[TONGTIENTRA],[TIENDATRA],[NGAY]) SELECT MA, TONGTIENTRA,TIENDATRA,NGAY FROM TONDAUPHAITHU "
            + "\r\nGO\r\n DELETE TONDAUPHAITHU "
            + "\r\nGO\r\n INSERT INTO TONDAUPHAITHU ([MA],[TONGTIENTRA],[TIENDATRA],[NGAY]) SELECT MA, SUM(TONGTIENTRA) AS TONGTIENTRA,SUM(TIENDATRA) AS TIENDATRA,convert(varchar,GETDATE() ,101)AS NGAY FROM (SELECT  MAKH AS MA,(TIENPHAITRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA  FROM HOADONXUAT WHERE TYPE=1 AND TIENPHAITRA-TIENDATRA<>0 UNION ALL   SELECT MA  ,(TONGTIENTRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA  FROM TONDAUCONGNO WHERE TONGTIENTRA-TIENDATRA<>0 UNION ALL SELECT MANCC AS MA,(TIENPHAITRA-TIENDATRA) AS TONGTIENTRA, 0 AS TIENDATRA FROM TRAHOADONNHAP WHERE  TYPE=1 AND TIENPHAITRA-TIENDATRA<>0 ) AS T1 GROUP BY MA "
            + "\r\nGO\r\n DELETE HOADONNHAP "
            + "\r\nGO\r\n DELETE CHITIETHDN "
            + "\r\nGO\r\n DELETE HOADONXUAT "
            + "\r\nGO\r\n DELETE CHITIETHDX "
            + "\r\nGO\r\n DELETE CHITIETHDXTAM "
            + "\r\nGO\r\n DELETE TRAHOADONNHAP "
            + "\r\nGO\r\n DELETE TRACHITIETHDN "
            + "\r\nGO\r\n DELETE TRAHOADONXUAT "
            + "\r\nGO\r\n DELETE TRACHITIETHDX "
            + "\r\nGO\r\n DELETE KHOHANG WHERE TONKHO=0 "
            + "\r\nGO\r\n DELETE [LOG] "
            + "\r\nGO\r\n DELETE PHIEUCHI "
            + "\r\nGO\r\n UPDATE KHOASO SET NGAY=convert(varchar,GETDATE(),101) "
            + "\r\nGO\r\n DELETE PHIEUTHU "
            + "\r\nGO\r\n DELETE TONKHO "
            + "\r\nGO\r\n DELETE TONKHOTT "
            + "\r\nGO\r\n DELETE TONKIEMKHO ";
            try
            {
            executeNonQuery2(SQLKETSO);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("CÓ LỖI XẢY RA RỒI KHÔNG KẾT SỔ ĐƯỢC");
            }
        }

        public  void Backup(clDTO DTO)
        {
            try
            {
                String SQL = "BACKUP DATABASE KHO_VINAVETCO TO DISK = '" + DTO.TENFILE + "'";
                executeNonQuery(SQL);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("không backup được");
            }
        }
        public DataTable getDoanhThu(clDTO dto)
        {
            String SQL ="select  NGAYXUAT , TENKH as 'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND  NGAYXUAT BETWEEN '"+dto.NGAYBD+"' AND '"+dto.NGAYKT+"' group by TENKH,TENKV,ngayxuat AND HOADONXUAT.MAKHO='"+PublicVariable.MAKHO+"'";
            
            return getdata(SQL);
        }
        public DataTable getcpmuahangngay(clDTO dto)
        {
           string SQL = "SELECT NGAYNHAP, SUM(NHAP) AS NHAP, SUM(TRAXUAT) AS TRAXUAT FROM (SELECT NGAYNHAP, TIENPHAITRA AS NHAP, 0 AS TRAXUAT FROM HOADONNHAP WHERE MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' UNION ALL SELECT NGAYXUAT AS NGAYNHAP, 0 AS NHAP, TIENPHAITRA AS TRAXUAT FROM TRAHOADONXUAT WHERE MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' ) AS T2 GROUP BY NGAYNHAP";
            return getdata(SQL);
        }

        public DataTable getcpmuahangncc(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 = " AND NHACUNGCAP.MANCC='" + dto.MANCC + "'  ";
            }
            //string SQL = "SELECT MATHANG.MANCC,TENNCC,SUM(NHAP) AS TIENMUAHANG FROM (select  MAMH, SUM(GIATIEN) AS NHAP FROM TONKHO as T2 WHERE MANHAPXUAT='N' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MAMH) AS T3, NHACUNGCAP,MATHANG WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND T3.MAMH=MATHANG.MAMH " + SQL1 + "  group by MATHANG.MANCC,TENNCC";
            string SQL = "SELECT HOADONNHAP.MANCC,TENNCC,SUM(TIENPHAITRA) AS TIENMUAHANG, SUM(NHAPXUAT*KLDVT) AS KHOILUONG FROM HOADONNHAP, NHACUNGCAP ,TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND HOADONNHAP.IDNHAP=TONKHO.IDNHAP AND HOADONNHAP.MANCC=NHACUNGCAP.MANCC AND NGAYNHAP BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND HOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "'   " + SQL1 + " GROUP BY HOADONNHAP.MANCC, TENNCC";
            return getdata(SQL);
        }

        public DataTable getcpmuahang_KHTRA(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAKH != "")
            {
                SQL1 = " AND KHACHHANG.MAKH='" + dto.MAKH + "'  ";
            }
            //string SQL = "SELECT KHACHHANG.MAKH,TENKH,SUM(NHAP) AS TIENMUAHANG FROM (select  MADOITUONG, SUM(GIATIEN) AS NHAP FROM TONKHO as T2 WHERE MANHAPXUAT='TX' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MADOITUONG) AS T3, KHACHHANG WHERE KHACHHANG.MAKH=T3.MADOITUONG  " + SQL1 + "  group by KHACHHANG.MAKH,TENKH";
            string SQL = "SELECT KHACHHANG.MAKH,TENKH,SUM(TIENPHAITRA) AS TIENMUAHANG , SUM(NHAPXUAT*KLDVT) AS KHOILUONG FROM TRAHOADONXUAT, KHACHHANG ,TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND TRAHOADONXUAT.IDNHAP=TONKHO.IDNHAP AND TRAHOADONXUAT.MAKH=KHACHHANG.MAKH AND NGAYXUAT BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND TRAHOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "'   " + SQL1 + " GROUP BY KHACHHANG.MAKH, TENKH";
            
            return getdata(SQL);
        }
        public DataTable getDoanhThungay(clDTO dto)
        {
           
           string SQL = "SELECT NGAYXUAT, SUM(XUAT) AS XUAT, SUM(TRANHAP) AS TRANHAP FROM (SELECT NGAYXUAT, TIENPHAITRA AS XUAT, 0 AS TRANHAP FROM HOADONXUAT WHERE MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' UNION ALL SELECT NGAYNHAP AS NGAYXUAT, 0 AS XUAT, TIENPHAITRA AS TRANHAP FROM TRAHOADONNHAP WHERE MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' ) AS T2 GROUP BY NGAYXUAT";
           
            return getdata(SQL);
        }
        public DataTable getDoanhThukh(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAKH != "")
            {
                SQL1 = " AND KHACHHANG.MAKH='" + dto.MAKH + "'  ";
            }
            //string SQL = "SELECT KHACHHANG.MAKH,TENKH,SUM(NHAP) AS DOANHTHU,SUM(NHAPXUAT) AS KHOILUONG FROM (select  MADOITUONG, SUM(GIATIEN) AS NHAP, -SUM(NHAPXUAT) AS NHAPXUAT FROM TONKHO as T2 WHERE MANHAPXUAT='X' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MADOITUONG) AS T3, KHACHHANG WHERE KHACHHANG.MAKH=T3.MADOITUONG  " + SQL1 + "  group by KHACHHANG.MAKH,TENKH";
            string SQL = "SELECT KHACHHANG.MAKH,TENKH,SUM(TIENPHAITRA) AS DOANHTHU , SUM(-NHAPXUAT*KLDVT) AS KHOILUONG FROM HOADONXUAT, KHACHHANG ,TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND HOADONXUAT.IDNHAP=TONKHO.IDNHAP AND HOADONXUAT.MAKH=KHACHHANG.MAKH AND NGAYXUAT BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "'   " + SQL1 + " GROUP BY KHACHHANG.MAKH, TENKH";
            
            return getdata(SQL);
        }
        public DataTable getDoanhThuTRANCC(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MANCC != "" && dto.MANCC != null)
            {
                SQL1 = " AND NHACUNGCAP.MANCC='" + dto.MANCC + "'  ";
            }
            //string SQL = "SELECT MATHANG.MANCC,TENNCC,SUM(NHAP) AS DOANHTHU, SUM(KLUONG) AS KHOILUONG FROM (select  MAMH, -SUM(NHAPXUAT) AS KLUONG, SUM(GIATIEN) AS NHAP FROM TONKHO as T2 WHERE MANHAPXUAT='TN' AND NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MAMH) AS T3, NHACUNGCAP,MATHANG WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND T3.MAMH=MATHANG.MAMH " + SQL1 + "  group by MATHANG.MANCC,TENNCC";
            string SQL = "SELECT TRAHOADONNHAP.MANCC,TENNCC,SUM(TIENPHAITRA) AS DOANHTHU, SUM(-NHAPXUAT*KLDVT) AS KHOILUONG FROM TRAHOADONNHAP, NHACUNGCAP,TONKHO,MATHANG WHERE MATHANG.MAMH=TONKHO.MAMH AND TRAHOADONNHAP.IDNHAP=TONKHO.IDNHAP AND TRAHOADONNHAP.MANCC=NHACUNGCAP.MANCC AND NGAYNHAP BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND TRAHOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "'   " + SQL1 + " GROUP BY TRAHOADONNHAP.MANCC, TENNCC";
            
            return getdata(SQL);
        }
        public DataTable getDoanhsonv(clDTO dto)
        {
            string SQL = "SELECT TENNV,DONVITINH,KLDVT,-SUM(KLXUAT)AS SLXUAT,-SUM(KLTRANHAP) AS SLTRANHAP,-SUM(KLXUAT)*KLDVT AS KLXUAT,-SUM(KLTRANHAP)*KLDVT AS KLTRANHAP,-SUM(XUAT) AS TIENXUAT, -SUM(TRANHAP) AS TIENTRANHAP FROM (select  MANV,MAMH, (CASE WHEN T2.MANHAPXUAT<>'X' THEN 0 ELSE SUM(GIATIEN) END) AS XUAT,(CASE WHEN T2.MANHAPXUAT<>'X' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLXUAT,(CASE WHEN T2.MANHAPXUAT<>'TN' THEN 0 ELSE SUM(GIATIEN) END) AS TRANHAP,(CASE WHEN T2.MANHAPXUAT<>'TN' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLTRANHAP  FROM TONKHO as T2 WHERE NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MANV,MAMH, MANHAPXUAT) AS T3, NHANVIEN,MATHANG,DONVITINH WHERE NHANVIEN.MANV=T3.MANV AND T3.MAMH=MATHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT group by TENNV,DONVITINH,KLDVT";
            return getdata(SQL);
        }
        public DataTable getcpmuahangsp(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "" && dto.MAMH != null)
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }
            string SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,DONVITINH,KLDVT,SUM(KLNHAP)AS SLNHAP,SUM(KLTRAXUAT) AS SLTRAXUAT,SUM(KLNHAP)*KLDVT AS KLNHAP,SUM(KLTRAXUAT)*KLDVT AS KLTRAXUAT,SUM(NHAP) AS TIENMUAHANG, SUM(TRAXUAT) AS TIENTRAXUAT FROM (select  MAMH, (CASE WHEN T2.MANHAPXUAT<>'N' THEN 0 ELSE SUM(GIATIEN) END) AS NHAP,(CASE WHEN T2.MANHAPXUAT<>'N' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLNHAP,(CASE WHEN T2.MANHAPXUAT<>'TX' THEN 0 ELSE SUM(GIATIEN) END) AS TRAXUAT,(CASE WHEN T2.MANHAPXUAT<>'TX' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLTRAXUAT  FROM TONKHO as T2 WHERE NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MAMH, MANHAPXUAT) AS T3, NHACUNGCAP,MATHANG,DONVITINH WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND T3.MAMH=MATHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT " + SQL1 + " group by MATHANG.MAMH,TENMH,TENNCC,DONVITINH,KLDVT";
            return getdata(SQL);
        }
        public DataTable getDoanhsosp(clDTO dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "" && dto.MAMH != null)
            {
                SQL1 = " AND MATHANG.MAMH='" + dto.MAMH + "'  ";
            }

            string SQL = "SELECT MATHANG.MAMH,TENMH,TENNCC,DONVITINH,KLDVT,SUM(KLXUAT)AS SLXUAT,SUM(KLTRANHAP) AS SLTRANHAP,SUM(KLXUAT)*KLDVT AS KLXUAT,SUM(KLTRANHAP)*KLDVT AS KLTRANHAP,SUM(XUAT) AS TIENXUAT, SUM(TRANHAP) AS TIENTRANHAP FROM (select  MAMH, (CASE WHEN T2.MANHAPXUAT<>'X' THEN 0 ELSE SUM(GIATIEN) END) AS XUAT,(CASE WHEN T2.MANHAPXUAT<>'X' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLXUAT,(CASE WHEN T2.MANHAPXUAT<>'TN' THEN 0 ELSE SUM(GIATIEN) END) AS TRANHAP,(CASE WHEN T2.MANHAPXUAT<>'TN' THEN 0 ELSE SUM(NHAPXUAT) END) AS KLTRANHAP  FROM TONKHO as T2 WHERE NGAY BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND T2.MAKHO='" + PublicVariable.MAKHO + "' group by MAMH, MANHAPXUAT) AS T3, NHACUNGCAP,MATHANG,DONVITINH WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND T3.MAMH=MATHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT " + SQL1 + " group by MATHANG.MAMH,TENMH,TENNCC,DONVITINH,KLDVT";
            return getdata(SQL);
        }
        public DataTable testLogin(clDTO dto)
        {
            string SQL="select 	MANV,MABP,USERNAME,PASSWORD,CHUCVU,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from  NHANVIEN"
            + " where 	PASSWORD='"+dto.MATKHAU+"' and USERNAME='"+dto.TENDANGNHAP+"'";
            return getdata(SQL);
        }

       
    }
}
