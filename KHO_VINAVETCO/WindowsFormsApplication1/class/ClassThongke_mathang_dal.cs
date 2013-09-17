using System;
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
            string SQL1 = " AND TYPE=1 ";
            string SQL2 = " AND TYPE=1 ";
            if (dto.MAKH != "")
            {
                SQL1 = SQL1+ "and HOADONXUAT.MAKH ='" + dto.MAKH + "'";
                SQL2 = SQL2 +"and TRAHOADONXUAT.MAKH ='" + dto.MAKH + "'";
            }

            String SQL = "select KMAI,KLDVT,convert(varchar,KHOHANG.HSD,103)AS HSD,TENNCC,TENKH, HOADONXUAT.MAHDX, convert(varchar,HOADONXUAT.NGAYXUAT,103)AS NGAYXUAT,MATHANG.MAMH,MATHANG.TENMH,DONVITINH,SOLUONGXUAT,SOLUONGXUAT*KLDVT AS KHOILUONG,GIABAN AS GIATIEN,CAST((SOLUONGXUAT * GIABAN) AS NUMERIC(18,0)) AS TIENXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM CHITIETHDX,MATHANG,KHOHANG,DONVITINH, HOADONXUAT,KHACHHANG,THUE,NHACUNGCAP WHERE CHITIETHDX.MAMH=KHOHANG.MAMH AND CHITIETHDX.LOHANG=KHOHANG.LOHANG AND MATHANG.MANCC=NHACUNGCAP.MANCC AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND THUE.MATH = MATHANG.MATH AND HOADONXUAT.MAHDX = CHITIETHDX.MAHDX AND HOADONXUAT.NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL1 + "  AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' "
                + " union all select KMAI,KLDVT,convert(varchar,KHOHANG.HSD,103)AS HSD,TENNCC,TENKH, trahoadonxuat.MAHDX, convert(varchar,NGAYXUAT,103)AS NGAYXUAT,MATHANG.MAMH,MATHANG.TENMH,DONVITINH,SOLUONGXUAT,SOLUONGXUAT*KLDVT AS KHOILUONG,GIABAN AS GIATIEN,CAST((SOLUONGXUAT * GIABAN) AS NUMERIC(18,0)) AS TIENXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM trachitiethdx,MATHANG,KHOHANG,DONVITINH, trahoadonxuat,KHACHHANG,THUE,NHACUNGCAP WHERE trachitiethdx.MAMH=KHOHANG.MAMH AND trachitiethdx.LOHANG=KHOHANG.LOHANG AND  MATHANG.MANCC=NHACUNGCAP.MANCC AND DONVITINH.MADVT=MATHANG.MADVT AND trachitiethdx.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = trahoadonxuat.MAKH AND THUE.MATH = MATHANG.MATH AND trahoadonxuat.MAHDX = trachitiethdx.MAHDX AND NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL2 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";

            return getdata(SQL);
        }
        public DataTable THONGKHETHEONCC(Class_DTO_ThongKe dto)
        {
            string SQL1 = " AND TYPE=1 ";
            if (dto.MANCC != "")
            {
                SQL1 = SQL1 + "and mathang.mancc ='"+dto.MANCC+"'";
            }

            String SQL = "select KMAI,TENNCC, HOADONNHAP.MAHDN, convert(varchar,HOADONNHAP.NGAYNHAP,103)AS NGAYNHAP,MATHANG.MAMH,TENMH,DONVITINH,SOLUONGNHAP,SOLUONGNHAP*KLDVT AS KHOILUONG,KLDVT,convert(varchar,KHOHANG.HSD,103)AS HSD,GIANHAP,CAST((SOLUONGNHAP * GIANHAP)  AS  NUMERIC(18,0)) AS TIENNHAP, TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM CHITIETHDN,MATHANG,DONVITINH,HOADONNHAP,NHACUNGCAP,THUE,KHOHANG WHERE DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDN.MAMH=KHOHANG.MAMH AND CHITIETHDN.LOHANG=KHOHANG.LOHANG AND CHITIETHDN.MAMH = MATHANG.MAMH AND NHACUNGCAP.MANCC = HOADONNHAP.MANCC  AND THUE.MATH = MATHANG.MATH AND HOADONNHAP.MAHDN = CHITIETHDN.MAHDN AND HOADONNHAP.NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL1 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' "
                + " union all select KMAI,TENNCC, trahoadonnhap.MAHDN, convert(varchar,trahoadonnhap.NGAYNHAP,103)AS NGAYNHAP,MATHANG.MAMH,TENMH,DONVITINH,SOLUONGNHAP,SOLUONGNHAP*KLDVT AS KHOILUONG,KLDVT,convert(varchar,KHOHANG.HSD,103)AS HSD,GIANHAP,CAST((SOLUONGNHAP * GIANHAP) AS  NUMERIC(18,0)) AS TIENNHAP, TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM trachitiethdn,MATHANG,DONVITINH,trahoadonnhap,NHACUNGCAP,THUE,KHOHANG WHERE DONVITINH.MADVT=MATHANG.MADVT AND trachitiethdn.MAMH=KHOHANG.MAMH AND trachitiethdn.LOHANG=KHOHANG.LOHANG AND trachitiethdn.MAMH = MATHANG.MAMH AND NHACUNGCAP.MANCC = trahoadonnhap.MANCC  AND THUE.MATH = MATHANG.MATH AND trahoadonnhap.MAHDN = trachitiethdn.MAHDN AND trahoadonnhap.NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL1 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }
        //--------------------
        public DataTable getloinhuan(Class_DTO_ThongKe dto)
        {
            String SQL = "SELECT HOADONNHAP.MAHDN, convert(varchar,NGAYNHAP,103)AS NGAYNHAP,CHITIETHDN.MAMH,SOLUONGNHAP,MATHANG.MAMH,TENMH,THUE.MATH,SOTHUE,MATHANG.MANH,TENNHOMHANG,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,(GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100  as TONGTIENMUA,GIABAN,CAST((GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN) / 100 AS  NUMERIC(18,0)) as TONGTIENBAN,CAST(((GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN) / 100) -((GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA) / 100) AS  NUMERIC(18,0)) AS LOINHUAN FROM THUE,NHOMHANG,MATHANG,DONVITINH ,CHITIETHDN,HOADONNHAP WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT and CHITIETHDN.MAMH = MATHANG.MAMH AND CHITIETHDN.MAHDN = HOADONNHAP.MAHDN AND NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }
        //---------------------------------------------------
        public DataTable gettonkhotonghop(Class_DTO_ThongKe dto)
        {
            string SQL1 = "";
            if (dto.MAMH != "")
            {
                SQL1 = "and mathang.mamh ='" + dto.MAMH + "' ";
            }
            if (dto.MANCC != "")
            {
                SQL1 = SQL1+ "and mathang.MANCC ='" + dto.MANCC + "'";
            }
            SQL1 = SQL1 + " AND (TONKHO>0 OR (SOLUONGMH=0 AND LOHANG='" + PublicVariable.LOHANG + "'))";
            String SQL = "select mathang.MAMH,LOHANG, convert(varchar,HSD,103)AS HSD, TENMH,KLDVT, DONVITINH, TENKHO, TENNCC, TONKHO AS SOLUONGMH,TONKHO*KLDVT AS KHOILUONG, KHOHANG.GIAMUA, KHOHANG.giamua*TONKHO as THANHTIEN   from mathang, donvitinh, kho, NHACUNGCAP,KHOHANG where MATHANG.MAMH=KHOHANG.MAMH AND mathang.madvt=donvitinh.madvt and  mathang.makho=kho.makho and mathang.MANCC=NHACUNGCAP.MANCC " + SQL1 + " and mathang.makho='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);

        }
        public DataTable getthekho(Class_DTO_ThongKe dto)
        {
            string MAMH = "";
            if (dto.MAMH != "")
            {
                MAMH = "and mathang.mamh ='" + dto.MAMH + "' ";
            }
            if (dto.MANCC != "")
            {
                MAMH = MAMH + "and mathang.MANCC ='" + dto.MANCC + "'";
            }
//            String SQL = "select MATHANG.MAMH,KLDVT, TENMH, convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,TONDAU*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI,TONDAU, NHAP,TRANHAP, XUAT,TRAXUAT, TONCUOI FROM MATHANG,TONKHO, NHACUNGCAP,DONVITINH,KHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND TONKHO.MAKHO=KHO.MAKHO AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + MAMH + "";
            String SQL = "SELECT IDNHAP,T1.MAMH,TONDAU,NHAP,XUAT,TRANHAP,TRAXUAT,TONCUOI,KLDVT, TENMH, convert(varchar,NGAY,103)AS NGAY, MAHD,TENNCC,DONVITINH,TONDAU*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI,LOHANG FROM (SELECT T2.MAMH,MAHD,LOHANG,NGAY,IDNHAP,(SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=T2.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=T2.MAMH AND TONKHO.IDNHAP < T2.IDNHAP ) AS TONDAU,"
            + " (SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MAHD=T2.MAHD AND TONKHO.MANHAPXUAT='N' AND TONKHO.MAMH=T2.MAMH ) AS NHAP, (SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MAHD=T2.MAHD AND TONKHO.MANHAPXUAT='X' AND TONKHO.MAMH=T2.MAMH ) AS XUAT, "
            + " (SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE -SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MAHD=T2.MAHD AND TONKHO.MANHAPXUAT='TN' AND TONKHO.MAMH=T2.MAMH ) AS TRANHAP, (SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END  FROM TONKHO WHERE TONKHO.MAHD=T2.MAHD AND TONKHO.MANHAPXUAT='TX' AND TONKHO.MAMH=T2.MAMH ) AS TRAXUAT, "
            + " (SELECT TONDAU FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=T2.MAMH)+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=T2.MAMH AND TONKHO.IDNHAP <= T2.IDNHAP ) AS TONCUOI "
            + " FROM (SELECT * FROM TONKHO WHERE MAKHO='"+PublicVariable.MAKHO+"' AND NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "') AS T2) AS T1, DONVITINH,MATHANG,NHACUNGCAP WHERE T1.MAMH=MATHANG.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC  ORDER BY IDNHAP ASC";
            return getdata(SQL);
        }
        public DataTable getsochitiethanghoa(Class_DTO_ThongKe dto)
        {
            string MAMH = "";
            if (dto.MAMH != "")
            {
                MAMH = "and mathang.mamh ='" + dto.MAMH + "' ";
            }
            if (dto.MANCC != "")
            {
                MAMH = MAMH + "and mathang.MANCC ='" + dto.MANCC + "'";
            }
           String SQL = "select MATHANG.MAMH,KLDVT, TENMH,  convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,GIANHAP AS GIAMUA,GIAXUAT AS GIABAN,TONDAU*KLDVT AS KLTONDAU,NHAP*KLDVT AS KLNHAP,TRANHAP*KLDVT AS KLTRANHAP,XUAT*KLDVT AS KLXUAT,TRAXUAT*KLDVT AS KLTRAXUAT,TONCUOI*KLDVT AS KLTONCUOI,TONDAU, TONDAU*GIANHAP AS TIENTONDAU, NHAP , GIANHAP*NHAP AS TIENNHAP,TRANHAP , GIANHAP*TRANHAP AS TIENTRANHAP, XUAT, GIAXUAT * XUAT AS TIENXUAT, TRAXUAT, GIAXUAT * TRAXUAT AS TIENTRAXUAT, TONCUOI, GIANHAP*TONCUOI AS TIENTONCUOI FROM MATHANG,TONKHO, NHACUNGCAP,DONVITINH,KHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND TONKHO.MAKHO=KHO.MAKHO AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + MAMH + "";
            return getdata(SQL);
        }

        public DataTable getbaocaotheokho(Class_DTO_ThongKe dto)
        {
            String SQL = "select SOLUONGMH,GIABAN,CAST(((GIABAN*(tondau+nhap-xuat)) + (SOTHUE * (tondau+nhap-xuat) * GIABAN)/ 100) AS NUMERIC(18,0)) as thanhtienban, THUE.MATH,SOTHUE,TENNHOMHANG,TENMH,tondau+nhap-xuat as SOLUONGTON,MATHANG.MAKHO,TENKHO,DONVITINH, convert(varchar,NGAY,103)AS NGAY,tondau,GIAMUA*tondau AS TONGTIENDAU,nhap,nhap*GIAMUA AS TONGTIENNHAP,xuat,xuat*GIABAN AS TONGTIENXUAT,tondau+nhap-xuat as SOLUONGTON,(tondau+nhap-xuat)*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO,THUE "
            + " WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MAKHO=KHO.MAKHO  AND THUE.MATH = MATHANG.MATH AND"
            + "  NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND KHO.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }
    //---------------------------------------------
         public DataTable getTonKho(Class_DTO_ThongKe dto)
        {
            String SQL = "select TENNHOMHANG,TENMH,MATHANG.MAKHO,TONKHO.MAMH,DONVITINH, convert(varchar,NGAYTHANG,103)AS NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH"
            + " AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND"
            + " '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "'";
            return getdata(SQL);

        }
        //------------------------TON KHO
        public DataTable load_hieuquakinhdoanh(Class_DTO_ThongKe dto)
        {
            String SQL = "SELECT MAMH,"
	        + " THUE.MATH,SOTHUE,"
	        + " MATHANG.MANH,TENNHOMHANG,"
	        + " TENMH,"
	        + " DONVITINH.MADVT,DONVITINH,"
	        + " SOLUONGMH,"
            + " GIAMUA,CAST((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100 AS  NUMERIC(18,0))  as TONGTIENMUA,"
            + " GIABAN,CAST(GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100 AS  NUMERIC(18,0))as TONGTIENBAN ,"
            + " CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100 -(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) AS  NUMERIC(18,0)) AS LOINHUAN"
            + " FROM THUE,NHOMHANG,MATHANG,DONVITINH "
            + " WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);

        }
        public DataTable load_getbaocaotonkho(Class_DTO_ThongKe dto)
        {
            String SQL = "select HOADONXUAT.MANV,USERNAME, HOADONXUAT.MAKH,TENKH,NGAYXUAT, TENNHOMHANG,TENMH,CHITIETHDX.MAMH,CHITIETHDX.MAHDX,DONVITINH,GIAMUA,GIABAN,SOLUONGMH,SOLUONGMH *GIABAN AS TONGTIENBAN ,SOLUONGMH * GIAMUA AS TONGTIENMUA,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,KHO,HOADONXUAT,KHACHHANG,NHANVIEN,THUE"
            + " WHERE MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND HOADONXUAT.MANV = NHANVIEN.MANV AND THUE.MATH = MATHANG.MATH AND"
            + " NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND KHO.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }

        //--------------------Backup Restore---------------------------


       

        public DataTable load_ct_mathang2(Class_DTO_ThongKe dto)
        {
            string SQL = "";

                if (dto.Loai_HT == "0")
                {//load tat ca
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,SOLUONGMH*KLDVT AS KHOILUONG,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100)  as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                    + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
                if (dto.Loai_HT == "1")
                {//con han
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,SOLUONGMH*KLDVT AS KHOILUONG,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                   + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt AND MATHANG.MAMH='" + dto.MAMH + "' and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
                if (dto.Loai_HT == "2")
                {//het han
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,SOLUONGMH*KLDVT AS KHOILUONG,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                    + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt AND MATHANG.MANCC='" + dto.MANCC + "' and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
           
            return getdata(SQL);
        }


        public void DELETE_LOHANGTONDAU(string MAMH, string LOHANG)
        {
            string SQL = "delete from TONDAUKHOHANG where 	MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'" +
                 " GO delete from KHOHANG where 	MAMH='" + MAMH + "' AND LOHANG='" + LOHANG + "'";
            executeNonQuery(SQL);
        }
        public DataTable getCONGNOKH_DAUKY()
        {
            string SQL = "";

            SQL = "SELECT TENKH,KHACHHANG.MAKH, DIACHI, SDT,TONDAUCONGNOKH.CONGNO AS TONGTIENTRA FROM TONDAUCONGNOKH, KHACHHANG WHERE KHACHHANG.MAKH=TONDAUCONGNOKH.MAKH AND MAKHO='" + PublicVariable.MAKHO + "' ";
            
            return getdata(SQL);
        }


        public DataTable getKHOASO()
        {
            string SQL = " SELECT * FROM KHOASO";
            return getdata(SQL);
        }
             
        public DataTable getCONGNONCC_DAUKY()
        {
            string SQL = "";

            SQL = "SELECT TENNCC,NHACUNGCAP.MANCC, DIACHI, SDT,TONDAUCONGNONCC.CONGNO as TONGTIENTRA FROM TONDAUCONGNONCC, NHACUNGCAP WHERE NHACUNGCAP.MANCC=TONDAUCONGNONCC.MANCC AND MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }
        public void updatetonkiemkho()
        {
            string SQL = "INSERT INTO [TONKIEMKHO]([NGAY],[MAMH],[LOHANG],[MAKHO],[TONTT]) select convert(varchar,getDate(),101) AS CurrentDateTime ,MATHANG.MAMH,LOHANG,MATHANG.MAKHO,TONKHO as TONTT FROM KHOHANG,MATHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND TINHTRANG='TRUE' AND TONKHO>0 AND MAKHO='" + PublicVariable.MAKHO + "'";
            executeNonQuery(SQL);
        }
        public void createtonkiemkho()
        {
            string SQL = "SELECT * FROM TONKIEMKHO WHERE NGAY=convert(varchar,getDate(),101) AND MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable DT = getdata(SQL);
            if (DT.Rows.Count <= 0)
            {
                SQL = "INSERT INTO [TONKIEMKHO]([NGAY],[MAMH],[LOHANG],[MAKHO],[TONTT],[TONKHO]) select convert(varchar,getDate(),101) AS CurrentDateTime ,MATHANG.MAMH,LOHANG,MATHANG.MAKHO,TONKHO as TONTT,TONKHO FROM KHOHANG,MATHANG WHERE MATHANG.MAMH=KHOHANG.MAMH AND KHOHANG.TINHTRANG='TRUE' AND MATHANG.TINHTRANG='TRUE' AND (TONKHO>0 OR(SOLUONGMH=0 AND LOHANG='"+PublicVariable.LOHANG+"')) AND MAKHO='" + PublicVariable.MAKHO + "'";
                executeNonQuery(SQL);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("NGÀY HÔM NAY ĐÃ KIỂM KHO RỒI NÊN KHÔNG THỂ TẠO NỮA");
            }
        }
        public DataTable getonkiemkho(string KIKIEM)
        {
            string SQL = "";
            if (KIKIEM.Length > 6)
            {
                KIKIEM = KIKIEM.Substring(6, 4) + "/" + KIKIEM.Substring(3, 2) + "/" + KIKIEM.Substring(0, 2);

            }
            SQL = " SELECT NGAY,MATHANG.MAMH,TENMH,LOHANG,TENNCC,HSD,KLDVT,DONVITINH,KLDVT*TONTT AS KHOILUONG,TONTT,TONKHO,TONTT-TONKHO AS CHENHLECH FROM DONVITINH,NHACUNGCAP,(SELECT MATHANG.*,KHOHANG.LOHANG,TONTT,TONKIEMKHO.TONKHO,KHOHANG.HSD,NGAY FROM TONKIEMKHO,MATHANG,KHOHANG WHERE TONKIEMKHO.MAMH=KHOHANG.MAMH AND TONKIEMKHO.LOHANG=KHOHANG.LOHANG AND KHOHANG.MAMH=MATHANG.MAMH AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND TONKIEMKHO.NGAY='" + KIKIEM + "')AS MATHANG WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC ";
            return getdata(SQL);
        }

        public DataTable getondauky_mathang()
        {
            string SQL = "";

            SQL = "SELECT MATHANG.MAMH,TENMH, TENNCC, TONDAUKHOHANG.LOHANG,KLDVT,DONVITINH, TONDAUKHOHANG.TONKHO AS SOLUONGMH, TONDAUKHOHANG.TONKHO*KLDVT AS KHOILUONG, TONDAUKHOHANG.GIAMUA, TONDAUKHOHANG.GIAMUA*TONDAUKHOHANG.TONKHO AS THANHTIEN, convert(varchar,KHOHANG.HSD,103)AS HANSUDUNG,convert(varchar,KHOHANG.HSD,103)AS HSD,cast(HSD-GETDATE() as int) as NGAYSUDUNG FROM TONDAUKHOHANG,MATHANG,KHOHANG,DONVITINH,NHACUNGCAP WHERE KHOHANG.MAMH=TONDAUKHOHANG.MAMH AND KHOHANG.LOHANG=TONDAUKHOHANG.LOHANG AND MATHANG.MAMH=TONDAUKHOHANG.MAMH AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MANCC= NHACUNGCAP.MANCC ";

            return getdata(SQL);
        }

        public DataTable load_ct_mathang_lo(Class_DTO_ThongKe dto)
        {
            string SQL = "", SQL1="";
            if (dto.Loai_HT == "1")
            {
                SQL1 = SQL1 + " AND MATHANG.MAMH='" + dto.MAMH + "'";
            }
            if (dto.Loai_HT == "2")
            {
                SQL1 = SQL1 + " AND MATHANG.MANCC='" + dto.MANCC + "'";
            }
            if (dto.Loai_HT == "3")
            {
                SQL1 = SQL1 + " and  cast(HSD-GETDATE() as int)<=0";
            }
            SQL1 = SQL1 + " AND (TONKHO >0 OR (SOLUONGMH=0 AND LOHANG='" + PublicVariable.LOHANG + "'))";

            SQL = "SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,TONKHO AS SOLUONGMH,TONKHO*KLDVT as KHOILUONG,HSD AS HANSUDUNG, cast(HSD-GETDATE() as int) as NGAYSUDUNG,KHOHANG.GIAMUA,LOHANG, (khohang.GIAMUA*TONKHO) as thanhtien, MOTA "
            + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH,khohang WHERE THUE.MATH = MATHANG.MATH and MATHANG.MAMH=KHOHANG.MAMH and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' " + SQL1;
            
            return getdata(SQL);
        }

        public DataTable get_NH()
        { 
            String SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
        }
        public DataTable get_NH2()
        {
            String SQL = "select 	MANH ,TENNHOMHANG from  NHOMHANG";
            return getdata(SQL);
        }

        public DataTable dtGetKIKIEM()
        {
            String SQL = "select convert(varchar,NGAY,103)AS NGAY from  TONKIEMKHO WHERE  MAKHO='" + PublicVariable.MAKHO + "' GROUP BY NGAY ORDER BY NGAY DESC";
            return getdata(SQL);
        }
        public DataTable get_NCC()
        {
            String SQL = "select 	MANCC ,TENNCC from  NHACUNGCAP WHERE MAKHO='"+PublicVariable.MAKHO+"'";
            return getdata(SQL);
        }
        public DataTable get_BG()
        {
            String SQL = "select MABG ,TENBG from  BANGGIA WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable get_KH()
        {
            String SQL = "select 	TENKH ,MAKH from  KHACHHANG WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
        public DataTable dtGetkho()
        {
            String SQL = "select MAKHO,TENKHO from  KHO";
            return getdata(SQL);
        }
        public DataTable dtGetsanpham()
        {
            String SQL = "select 	MAMH AS MASANPHAM,TENMH AS TENSANPHAM,TENNCC from  MATHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.makho='"+PublicVariable.MAKHO+"'";
            return getdata(SQL);
        }
        public DataTable dtGetsanpham2()
        {
            String SQL = "select 	MAMH ,TENMH,TENNCC from  MATHANG,NHACUNGCAP where MATHANG.MANCC=NHACUNGCAP.MANCC AND mathang.makho='" + PublicVariable.MAKHO + "'";
            return getdata(SQL);
        }
    }
}
