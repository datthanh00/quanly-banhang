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
            //List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("THONGKETHEOKHACHHANG_getall", sqlpa1);
            string SQL1 = "";
            string SQL2 = "";
            if (dto.MAKH != "")
            {
                SQL1 = "and HOADONXUAT.MAKH ='" + dto.MAKH + "'";
                SQL2 = "and TRAHOADONXUAT.MAKH ='" + dto.MAKH + "'";
            }

            String SQL = "select KLDVT,TENNCC,TENKH, HOADONXUAT.MAHDX, convert(varchar,HOADONXUAT.NGAYXUAT,103)AS NGAYXUAT,MATHANG.MAMH,MATHANG.TENMH,DONVITINH,SOLUONGXUAT,GIATIEN,CAST((SOLUONGXUAT * GIATIEN) + (SOTHUE *SOLUONGXUAT * GIATIEN) / 100 AS NUMERIC(18,0)) AS TIENXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM CHITIETHDX,MATHANG,DONVITINH, HOADONXUAT,KHACHHANG,THUE,NHACUNGCAP WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND THUE.MATH = MATHANG.MATH AND HOADONXUAT.MAHDX = CHITIETHDX.MAHDX AND HOADONXUAT.NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL1 + "  AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' "
                + " union all select KLDVT,TENNCC,TENKH, trahoadonxuat.MAHDX, convert(varchar,NGAYXUAT,103)AS NGAYXUAT,MATHANG.MAMH,MATHANG.TENMH,DONVITINH,SOLUONGXUAT,GIATIEN,CAST((SOLUONGXUAT * GIATIEN) + (SOTHUE *SOLUONGXUAT * GIATIEN) / 100 AS NUMERIC(18,0)) AS TIENXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM trachitiethdx,MATHANG,DONVITINH, trahoadonxuat,KHACHHANG,THUE,NHACUNGCAP WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND DONVITINH.MADVT=MATHANG.MADVT AND trachitiethdx.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = trahoadonxuat.MAKH AND THUE.MATH = MATHANG.MATH AND trahoadonxuat.MAHDX = trachitiethdx.MAHDX AND NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' " + SQL2 + " AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";

            return getdata(SQL);
        }
        public DataTable THONGKHETHEONCC(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("THONGKETHEOKHACHHANG_getall", sqlpa1);
            string SQL1 = "";
            if (dto.MANCC != "")
            {
                SQL1 = "and mathang.mancc ='"+dto.MANCC+"'";
            }

            String SQL = "select TENNCC, HOADONNHAP.MAHDN, convert(varchar,NGAYNHAP,103)AS NGAYNHAP,MATHANG.MAMH,TENMH,DONVITINH,SOLUONGNHAP,GIANHAP,CAST((SOLUONGNHAP * GIANHAP) + (SOTHUE *SOLUONGNHAP * GIANHAP) / 100 AS  NUMERIC(18,0)) AS TIENNHAP, TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM CHITIETHDN,MATHANG,DONVITINH,HOADONNHAP,NHACUNGCAP,THUE WHERE DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDN.MAMH = MATHANG.MAMH AND NHACUNGCAP.MANCC = HOADONNHAP.MANCC  AND THUE.MATH = MATHANG.MATH AND HOADONNHAP.MAHDN = CHITIETHDN.MAHDN AND NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' "+SQL1+" AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' "
                + " union all select TENNCC, trahoadonnhap.MAHDN, convert(varchar,NGAYNHAP,103)AS NGAYNHAP,MATHANG.MAMH,TENMH,DONVITINH,SOLUONGNHAP,GIANHAP,CAST((SOLUONGNHAP * GIANHAP) + (SOTHUE *SOLUONGNHAP * GIANHAP) / 100 AS  NUMERIC(18,0)) AS TIENNHAP, TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO FROM trachitiethdn,MATHANG,DONVITINH,trahoadonnhap,NHACUNGCAP,THUE WHERE DONVITINH.MADVT=MATHANG.MADVT AND trachitiethdn.MAMH = MATHANG.MAMH AND NHACUNGCAP.MANCC = trahoadonnhap.MANCC  AND THUE.MATH = MATHANG.MATH AND trahoadonnhap.MAHDN = trachitiethdn.MAHDN AND NGAYNHAP BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' "+SQL1+" AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
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

            String SQL = "select mathang.MAMH, TENMH,KLDVT, DONVITINH, TENKHO, TENNCC, SOLUONGMH, GIAMUA, giamua*soluongmh as THANHTIEN   from mathang, donvitinh, kho, NHACUNGCAP where mathang.madvt=donvitinh.madvt and  mathang.makho=kho.makho and mathang.MANCC=NHACUNGCAP.MANCC "+SQL1+" and mathang.makho='" + PublicVariable.MAKHO + "'";
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
           // String SQL = "select MAMH,KLDVT, TENMH, convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,TONDAU, NHAP,TRANHAP, XUAT,TRAXUAT, TONCUOI from (select tonkho.*, math, tenmh,makho,manh,madvt,MANCC,KLDVT  from tonkho, mathang where tonkho.mamh= mathang.mamh and ngay BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' and MATHANG.makho='" + PublicVariable.MAKHO + "' " + MAMH + ")  as t1, kho,NHACUNGCAP,donvitinh where t1.makho=kho.makho and t1.MANCC=NHACUNGCAP.MANCC and t1.madvt=donvitinh.madvt";
            String SQL = "select MATHANG.MAMH,KLDVT, TENMH, convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,TONDAU, NHAP,TRANHAP, XUAT,TRAXUAT, TONCUOI FROM MATHANG,TONKHO, NHACUNGCAP,DONVITINH,KHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND TONKHO.MAKHO=KHO.MAKHO AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + MAMH + "";
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
            // String SQL = "select MAMH,KLDVT, TENMH,  convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,GIAMUA,GIABAN,TONDAU, TONDAU*GIAMUA AS TIENTONDAU, NHAP , GIAMUA*NHAP AS TIENNHAP, TRANHAP , GIAMUA*TRANHAP AS TIENTRANHAP, XUAT, GIABAN * XUAT AS TIENXUAT, TRAXUAT, GIABAN * TRAXUAT AS TIENTRAXUAT, TONCUOI, GIAMUA*TONCUOI AS TIENTONCUOI  from (select tonkho.*, math, tenmh,makho,manh,madvt,GIAMUA,GIABAN,MANCC,KLDVT from tonkho, mathang where tonkho.mamh= mathang.mamh and ngay BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' and makho='" + PublicVariable.MAKHO + "' " + MAMH + ") as t1, kho,NHACUNGCAP,donvitinh where t1.makho=kho.makho and t1.MANCC=NHACUNGCAP.MANCC and t1.madvt=donvitinh.madvt";
            String SQL = "select MATHANG.MAMH,KLDVT, TENMH,  convert(varchar,NGAY,103)AS NGAY, MAHD,TENKHO,TENNCC,DONVITINH,GIANHAP AS GIAMUA,GIAXUAT AS GIABAN,TONDAU, TONDAU*GIANHAP AS TIENTONDAU, NHAP , GIANHAP*NHAP AS TIENNHAP,TRANHAP , GIANHAP*TRANHAP AS TIENTRANHAP, XUAT, GIAXUAT * XUAT AS TIENXUAT, TRAXUAT, GIAXUAT * TRAXUAT AS TIENTRAXUAT, TONCUOI, GIANHAP*TONCUOI AS TIENTONCUOI FROM MATHANG,TONKHO, NHACUNGCAP,DONVITINH,KHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MADVT=DONVITINH.MADVT AND TONKHO.MAKHO=KHO.MAKHO AND TONKHO.NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND TONKHO.MAKHO='" + PublicVariable.MAKHO + "' " + MAMH + "";
            return getdata(SQL);
        }

        public DataTable getbaocaotheokho(Class_DTO_ThongKe dto)

        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            //sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            //return executeNonQuerya("BAOCAOTHEOKHO_getall", sqlpa);
            String SQL = "select SOLUONGMH,GIABAN,CAST(((GIABAN*(tondau+nhap-xuat)) + (SOTHUE * (tondau+nhap-xuat) * GIABAN)/ 100) AS NUMERIC(18,0)) as thanhtienban, THUE.MATH,SOTHUE,TENNHOMHANG,TENMH,tondau+nhap-xuat as SOLUONGTON,MATHANG.MAKHO,TENKHO,DONVITINH, convert(varchar,NGAY,103)AS NGAY,tondau,GIAMUA*tondau AS TONGTIENDAU,nhap,nhap*GIAMUA AS TONGTIENNHAP,xuat,xuat*GIABAN AS TONGTIENXUAT,tondau+nhap-xuat as SOLUONGTON,(tondau+nhap-xuat)*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO,THUE "
            + " WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MAKHO=KHO.MAKHO  AND THUE.MATH = MATHANG.MATH AND"
            + "  NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND KHO.MAKHO='" + PublicVariable.MAKHO + "' ";
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
            String SQL = "select TENNHOMHANG,TENMH,MATHANG.MAKHO,TONKHO.MAMH,DONVITINH, convert(varchar,NGAYTHANG,103)AS NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH"
            + " AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND"
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
            + " GIAMUA,CAST((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100 AS  NUMERIC(18,0))  as TONGTIENMUA,"
            + " GIABAN,CAST(GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100 AS  NUMERIC(18,0))as TONGTIENBAN ,"
            + " CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100 -(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) AS  NUMERIC(18,0)) AS LOINHUAN"
            + " FROM THUE,NHOMHANG,MATHANG,DONVITINH "
            + " WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
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
            + " NGAYXUAT BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "' AND KHO.MAKHO='" + PublicVariable.MAKHO + "' ";
            return getdata(SQL);
        }

        //--------------------Backup Restore---------------------------


       

        public DataTable load_ct_mathang2(Class_DTO_ThongKe dto)
        {
            //List<MySqlParameter> sql = new List<MySqlParameter>();
            //sql.Add(new MySqlParameter("@LOAI_TG", dto.Loai_TG));
            //sql.Add(new MySqlParameter("@LOAI_HT", dto.Loai_HT));
            //return executeNonQuerya("THONGKE_CT_MATHANG2", sql);
            string SQL = "";

                if (dto.Loai_HT == "0")
                {//load tat ca
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100)  as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                    + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
                if (dto.Loai_HT == "1")
                {//con han
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                   + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt AND MATHANG.MAMH='" + dto.MAMH + "' and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
                if (dto.Loai_HT == "2")
                {//het han
                    SQL = " SELECT MATHANG.MAMH,MATHANG.MANCC,TENNCC,KLDVT,THUE.MATH,SOTHUE,MATHANG.MANH,TENNCC,TENMH,DONVITINH.MADVT,DONVITINH,SOLUONGMH,HANSUDUNG,GIAMUA,CAST(((GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA) / 100) as  NUMERIC(18,0))  as thanhtien,GIABAN,CAST((GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN) / 100) as  NUMERIC(18,0)) as thanhtienban,MOTA"
                    + " FROM THUE,NHACUNGCAP,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and NHACUNGCAP.MANCC=MATHANG.MANCC and DONVITINH.madvt=MATHANG.madvt AND MATHANG.MANCC='" + dto.MANCC + "' and MATHANG.MAKHO='" + PublicVariable.MAKHO + "' ";
                }
           

        
            return getdata(SQL);
        }

        public DataTable get_NH()
        { 
           // List<MySqlParameter> sql = new List<MySqlParameter>();
            //return executeNonQuerya("[NHOMHANG_getall]", sql);
            String SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return getdata(SQL);
        }
        public DataTable get_NH2()
        {
            // List<MySqlParameter> sql = new List<MySqlParameter>();
            //return executeNonQuerya("[NHOMHANG_getall]", sql);
            String SQL = "select 	MANH ,TENNHOMHANG from  NHOMHANG";
            return getdata(SQL);
        }
        public DataTable get_NCC()
        {
            // List<MySqlParameter> sql = new List<MySqlParameter>();
            //return executeNonQuerya("[NHOMHANG_getall]", sql);
            String SQL = "select 	MANCC ,TENNCC from  NHACUNGCAP WHERE MAKHO='"+PublicVariable.MAKHO+"'";
            return getdata(SQL);
        }
        public DataTable get_KH()
        {
            // List<MySqlParameter> sql = new List<MySqlParameter>();
            //return executeNonQuerya("[NHOMHANG_getall]", sql);
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
