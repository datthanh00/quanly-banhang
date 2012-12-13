﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class ClassThongke_mathang_dal :Provider
    {

        public DataTable THONGKHETHEOKHACHHANG(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("THONGKETHEOKHACHHANG_getall", sqlpa1);

            String SQL = "select KHACHHANG.MAKH,TENKH ,NHOMHANG.MANH,TENNHOMHANG, HOADONXUAT.MAHDX,NGAYXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO,CHITIETHDX.MAMH,SOLUONGXUAT,GIATIEN,(SOLUONGXUAT * GIATIEN) + (SOTHUE *SOLUONGXUAT * GIATIEN)/100 AS TIENXUAT ,MATHANG.MAMH,TENMH, DONVITINH.MADVT,DONVITINH,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,HOADONXUAT,KHACHHANG,NHANVIEN,THUE WHERE MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND HOADONXUAT.MANV = NHANVIEN.MANV AND THUE.MATH = MATHANG.MATH AND HOADONXUAT.MAHDX = CHITIETHDX.MAHDX AND NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO+ "'";
            return getdata(SQL);
        }
        //--------------------
        public DataTable getloinhuan(Class_DTO_ThongKe dto)
        {
            /*List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("LOINHUANKINHDOANH_getall", sqlpa1);
             */
            String SQL = "SELECT HOADONNHAP.MAHDN,NGAYNHAP,CHITIETHDN.MAMH,SOLUONGNHAP,MATHANG.MAMH,TENMH,THUE.MATH,SOTHUE,MATHANG.MANH,TENNHOMHANG,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100  as TONGTIENMUA,GIABAN,(GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100 as TONGTIENBAN,((GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100) -((GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100) AS LOINHUAN FROM THUE,NHOMHANG,MATHANG,DONVITINH ,CHITIETHDN,HOADONNHAP WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT and CHITIETHDN.MAMH = MATHANG.MAMH AND CHITIETHDN.MAHDN = HOADONNHAP.MAHDN AND NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            return getdata(SQL);
        }
        //---------------------------------------------------

        public DataTable getbaocaotheokho(Class_DTO_ThongKe dto)

        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("BAOCAOTHEOKHO_getall", sqlpa);
            String SQL = "select SOLUONGMH,GIABAN,((GIABAN*SOLUONGTON) + (SOTHUE * SOLUONGTON * GIABAN)/100) as thanhtienban, THUE.MATH,SOTHUE,TENNHOMHANG,TENMH,SOLUONGTON,MATHANG.MAKHO,TENKHO,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO,THUE "
            + " WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MAKHO=KHO.MAKHO  AND THUE.MATH = MATHANG.MATH AND"
            + " '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            return getdata(SQL);
        }
    //---------------------------------------------
         public DataTable getTonKho(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("TONKHO_getall", sqlpa);
            String SQL = "select TENNHOMHANG,TENMH,MATHANG.MAKHO,TONKHO.MAMH,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH"
            + " AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MAKHO='" + dto.MAKHO + "' AND"
            + " '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            return getdata(SQL);

        }
        //------------------------TON KHO
        public DataTable load_hieuquakinhdoanh(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //return executeNonQuerya("THONGKEHIEUQUAKINHDOANH_getall", sqlpa);
            String SQL = "SELECT MAMH,"
	        + " THUE.MATH,SOTHUE,"
	        + " MATHANG.MANH,TENNHOMHANG,"
	        + " TENMH,"
	        + " DONVITINH.MADVT,DONVITINH,"
	        + " SOLUONGMH,"
	        + " HANSUDUNG,"
            + " CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',"
	        + " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as TONGTIENMUA,"
	        + " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as TONGTIENBAN,"
            + " (GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 -(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100) AS LOINHUAN"
            + " FROM THUE,NHOMHANG,MATHANG,DONVITINH "
            + " WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT";
            return getdata(SQL);

        }
        public DataTable load_getbaocaotonkho(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sql = new List<MySqlParameter>();
            //sql.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sql.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("THONGKEXUATHANGTHEOKHACHHANG_getall", sql);
            String SQL = "select HOADONXUAT.MANV,USERNAME, HOADONXUAT.MAKH,TENKH,NGAYXUAT, TENNHOMHANG,TENMH,CHITIETHDX.MAMH,CHITIETHDX.MAHDX,DONVITINH,GIAMUA,GIABAN,SOLUONGMH,SOLUONGMH *GIABAN AS TONGTIENBAN ,SOLUONGMH * GIAMUA AS TONGTIENMUA,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,KHO,HOADONXUAT,KHACHHANG,NHANVIEN,THUE"
            + " WHERE MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND HOADONXUAT.MANV = NHANVIEN.MANV AND THUE.MATH = MATHANG.MATH AND"
            + " NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            return getdata(SQL);
        }

        //--------------------Backup Restore---------------------------

        public DataTable load_mathang( Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sql = new List<MySqlParameter>();
            sql.Add(new MySqlParameter("@ngay_bd", dto.NGAY_BD));
            sql.Add(new MySqlParameter("@Ngay_kt", dto.NGAY_KT));
            sql.Add(new MySqlParameter("@loai_tg",dto.Loai_TG));
            sql.Add(new MySqlParameter("@loai_ht",dto.Loai_HT));
            return executeNonQuerya("THONGKE_MATHANG", sql);
        }
        public DataTable load_ct_mathang(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sql = new List<MySqlParameter>();
            //sql.Add(new MySqlParameter("@NGAY_BD",  '"+ '"+ '"+dto.NGAY_BD+"' +"' +"' ));
            //sql.Add(new MySqlParameter("@NGAY_KT", dto.NGAY_KT));
            //sql.Add(new MySqlParameter("@LOAI_TG", dto.Loai_TG));
            //sql.Add(new MySqlParameter("@LOAI_HT", dto.Loai_HT));
            //sql.Add(new MySqlParameter("@MANH", dto.MANH));
            //return executeNonQuerya("THONGKE_CT_MATHANG", sql);

            String SQL = "BEGIN"
    + " IF( '" + dto.Loai_TG + "'  = 'NGAY')"
	+ " BEGIN"
    + " IF( '" + dto.Loai_HT + "'  = '0')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN  '"+dto.NGAY_BD+"'  AND  '"+dto.NGAY_KT+"' ))"
    + " ELSE IF ( '" + dto.Loai_HT + "'  = '1')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN  '"+dto.NGAY_BD+"'  AND  '"+dto.NGAY_KT+"' ))"
	+ " ELSE"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND  MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN  '"+dto.NGAY_BD+"'  AND  '"+dto.NGAY_KT+"' ))"
	+ " END"
    + " ELSE IF( '" + dto.Loai_TG + "'  = 'THANG')"
	+ " BEGIN"
    + " IF( '" + dto.Loai_HT + "'  = '0')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND  HANSUDUNG > GETDATE() AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"'  )) AND YEAR(NGAYNHAP)=YEAR( '"+dto.NGAY_BD+"' )))"
    + " ELSE IF ( '" + dto.Loai_HT + "'  = '1')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND (HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE()) AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"'  )) AND YEAR(NGAYNHAP)=YEAR( '"+dto.NGAY_BD+"' )))"
	+ " ELSE"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"'  )) AND YEAR(NGAYNHAP)=YEAR( '"+dto.NGAY_BD+"' )))"
	+ " END"
    + " ELSE IF( '" + dto.Loai_TG + "'  = 'QUI')"
	+ " BEGIN"
    + " IF( '" + dto.Loai_HT + "'  = '0')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
    + " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR( '"+dto.NGAY_BD+"' ) AND MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"' )))"
    + " ELSE IF ( '" + dto.Loai_HT + "'  = '1')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR( '"+dto.NGAY_BD+"' ) AND MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"' )))"
	+ " ELSE"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
    + " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND   MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR( '"+dto.NGAY_BD+"' ) AND MONTH(NGAYNHAP) BETWEEN MONTH( '"+dto.NGAY_BD+"' ) AND MONTH( '"+dto.NGAY_KT+"' )))"
	+ " END"
	+ " ELSE"
	+ " BEGIN"
    + " IF( '" + dto.Loai_HT + "'  = '0')"
    + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0"
    + " ELSE IF ( '" + dto.Loai_HT + "'  = '1')"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE()"
	+ " ELSE"
	+ " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,"
	+ " GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,"
	+ " GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,MOTA,TINHTRANG"
 + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG > GETDATE()"
	+ " END"
+ " END";
            return getdata(SQL);
        }

        public DataTable load_ct_mathang2(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sql = new List<MySqlParameter>();
            //sql.Add(new MySqlParameter("@LOAI_TG", dto.Loai_TG));
            //sql.Add(new MySqlParameter("@LOAI_HT", dto.Loai_HT));
            //return executeNonQuerya("THONGKE_CT_MATHANG2", sql);
            string SQL = "BEGIN"
            + " if( '" + dto.Loai_TG + "' ='')"
        + " begin "
                + " if( '" + dto.Loai_HT + "' ='0')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
        + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 "
        + "         if( '" + dto.Loai_HT + "'  ='1')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
		+ "    FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and  HANSUDUNG - getdate() < 0"
        + " if( '" + dto.Loai_HT + "'  ='2')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
		+ "       FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and HANSUDUNG - getdate() >=0 "
        + " END"
        + " else"
        + " begin"
        + " if( '" + dto.Loai_HT + "'  ='0')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
        + "     FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang =  '" + dto.Loai_TG + "' "
        + " if( '" + dto.Loai_HT + "'  ='1')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
        + " FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang =  '" + dto.Loai_TG + "'  and HANSUDUNG- getdate() <0"
        + " if( '" + dto.Loai_HT + "'  ='2')"
        + " SELECT MAMH,THUE.MATH,SOTHUE,MATHANG.MANH,tennhomhang,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,"
        + " CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',MOTA,TINHTRANG"
        + "     FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang =  '" + dto.Loai_TG + "'  and HANSUDUNG - getdate()>= 0"
        + " END "
        + " END";
            return getdata(SQL);
        }

        public DataTable get_NH()
        { 
           // List<MySqlParameter> sql = new List<MySqlParameter>();
            //return executeNonQuerya("[NHOMHANG_getall]", sql);
            String SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
        }

    }
}
