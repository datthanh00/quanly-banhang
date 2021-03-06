﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

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
             String SQL = "update THONGTINCT set MACT= '"+dto.MACT+"',TENCT= '"+dto.TENCT+"',DIACHI= '"+dto.DIACHI+"',SDT= '"+dto.SDT+"',"
	        +" MOBILE= '"+dto.MOBILE+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"',LOGO= '"+dto.LOGO+"',MASOTHUE= '"+dto.MASOTHUE+"',WEBSITE= '"+dto.WEBSITE+"'"
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

            String SQL = "SELECT MATHANG.MAMH, TENMH, TENNHOMHANG, DONVITINH, TONDAU, NHAP, XUAT, TONCUOI, CAST(TONCUOI * GIAMUA AS SIGNED) AS TONGTIEN, CAST((XUAT * GIABAN)- (NHAP * GIAMUA)AS SIGNED)  AS LOINHUAN FROM MATHANG, DONVITINH,NHOMHANG, "
            + " (SELECT  *, TONDAU+NHAP-XUAT AS TONCUOI FROM "
            +" (SELECT T1.MAMH, IF(NHAP>0, NHAP, 0) AS NHAP,IF(XUAT>0, XUAT, 0) AS XUAT,"
            + " IF(TONDAU>0, TONDAU, (SELECT TONCUOI   FROM TONKHO WHERE MAMH=T1.MAMH AND NGAY < '" + dto.NGAYBDKHO + "'  ORDER BY STT DESC LIMIT 1)) AS TONDAU   "
            + " FROM (SELECT MATHANG.MAMH, SUM(NHAP) AS NHAP, SUM(XUAT) AS XUAT,TONDAU FROM ( SELECT * FROM MATHANG WHERE MAKHO='" + PublicVariable.MAKHO + "') AS MATHANG LEFT JOIN (SELECT * FROM TONKHO WHERE NGAY BETWEEN '" + dto.NGAYBDKHO + "' AND '" + dto.NGAYKTKHO + "')AS TONKHO ON MATHANG.MAMH = TONKHO.MAMH GROUP BY MAMH ) AS T1) AS T2) AS T WHERE MATHANG.MAMH=T.MAMH AND MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANH=NHOMHANG.MANH";
            
           
            return getdata(SQL);
        }
        //--------------------Backup Restore---------------------------
        public  void Backup(clDTO DTO)
        {
            //List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            //sqlpa.Add(new MySqlParameter("@TENFILE",DTO.TENFILE));
            //ChayProc("BACKUP_DATABASE", sqlpa);
            String SQL = "BACKUP DATABASE XUAT_NHAPTON TO DISK = '"+DTO.TENFILE+"'";
            executeNonQuery(SQL);
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
            String SQL = "select NGAYNHAP ,SUM(TIENPHAITRA) AS CHIPHI FROM HOADONNHAP WHERE  ngaynhap BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' AND HOADONNHAP.MAKHO='"+PublicVariable.MAKHO+"'  group by ngaynhap";
            return getdata(SQL);
        }

        public DataTable getcpmuahangncc(clDTO dto)
        {
            String SQL = "select NHACUNGCAP.MANCC,TENNCC,TENKV,SUM(TIENPHAITRA) AS CHIPHI FROM HOADONNHAP, NHACUNGCAP,KHUVUC WHERE KHUVUC.MAKV=NHACUNGCAP.MAKV AND HOADONNHAP.MAKHO='"+PublicVariable.MAKHO+"' AND NHACUNGCAP.MANCC=HOADONNHAP.MANCC AND ngaynhap BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by TENNCC,TENKV";
            return getdata(SQL);
        }
        public DataTable getDoanhThungay(clDTO dto)
        {
            String SQL = "select NGAYXUAT ,SUM(TIENPHAITRA) AS DOANHTHU FROM HOADONXUAT WHERE  HOADONXUAT.MAKHO='"+PublicVariable.MAKHO+"' AND ngayxuat BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by ngayxuat";

            return getdata(SQL);
        }
        public DataTable getDoanhThukh(clDTO dto)
        {
            String SQL = "select KHACHHANG.MAKH,TENKH,SDT ,TENKV ,SUM(TIENPHAITRA) AS DOANHTHU FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH AND HOADONXUAT.MAKHO='"+PublicVariable.MAKHO+"' AND ngayxuat BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by TENKH,TENKV";
            return getdata(SQL);
        }
        public DataTable getDoanhsonv(clDTO dto)
        {
            String SQL = "select NHANVIEN.MANV,TENNV ,SUM(TIENPHAITRA) AS DOANHSO FROM HOADONXUAT,NHANVIEN WHERE  NHANVIEN.MANV=HOADONXUAT.MANV AND HOADONXUAT.MAKHO='"+PublicVariable.MAKHO+"' AND ngayxuat BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "' group by TENNV";
            return getdata(SQL);
        }
        public DataTable getcpmuahangsp(clDTO dto)
        {
            String SQL = "select TENMH ,t1.MAMH,TENNHOMHANG,TENKHO,TIENPHAITRA from (select TENMH ,mathang.mamh,tennhomhang,tenkho FROM MATHANG,NHOMHANG,KHO WHERE MATHANG.MANH=NHOMHANG.MANH AND MATHANG.MAKHO=KHO.MAKHO AND KHO.MAKHO='" + PublicVariable.MAKHO + "') as t1 LEFT JOIN (select  chitiethdn.MAMH,sum(soluongnhap*gianhap) as TIENPHAITRA from hoadonnhap, chitiethdn where hoadonnhap.MAHDN=chitiethdn.MAHDN AND HOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "'   and ngaynhap  BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "'  group by MAMH) as t2 ON  t1.mamh=t2.mamh";
            return getdata(SQL);
        }
        public DataTable getDoanhsosp(clDTO dto)
        {
            String SQL = "select TENMH ,t1.MAMH,TENNHOMHANG,TENKHO,DOANHSO from (select TENMH ,mathang.mamh,tennhomhang,tenkho FROM MATHANG,NHOMHANG,KHO WHERE MATHANG.MANH=NHOMHANG.MANH AND MATHANG.MAKHO=KHO.MAKHO AND KHO.MAKHO='" + PublicVariable.MAKHO + "') as t1 LEFT JOIN (select  chitiethdx.MAMH,sum(soluongxuat*giatien) as doanhso from hoadonxuat, chitiethdx where hoadonxuat.MAHDX=chitiethdx.MAHDX   AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and ngayxuat  BETWEEN '" + dto.NGAYBD + "' AND '" + dto.NGAYKT + "'  group by MAMH) as t2 ON  t1.mamh=t2.mamh";
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
