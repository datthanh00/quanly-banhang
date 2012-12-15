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
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new MySqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_add", sqlpa);
             */
            string SQL = "	insert into KHACHHANG(MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG)"
            + " values('" + dto.MAKH + "','" + dto.MAKV + "',N'" + dto.TENKH + "','" + dto.SOTAIKHOAN + "',N'" + dto.NGANHANG + "','" + dto.MASOTHUE + "',N'" + dto.DIACHI + "','" + dto.SDT + "','" + dto.FAX + "','" + dto.WEBSITE + "','" + dto.YAHOO + "','" + dto.SKYPE + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);

        }
        public void updateKhachHang(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKH", dto.TENKH));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@YAHOO", dto.YAHOO));
            sqlpa.Add(new MySqlParameter("@SKYPE", dto.SKYPE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHACHHANG_update", sqlpa);*/
            string SQL = "update KHACHHANG set MAKH='"+ dto.MAKH +"' ,MAKV='"+ dto.MAKV +"',TENKH=N'"+ dto.TENKH +"',SOTAIKHOAN='"+ dto.SOTAIKHOAN +"',NGANHANG=N'"+ dto.NGANHANG +"',MASOTHUE='"+ dto.MASOTHUE +"',DIACHI=N'"+ dto.DIACHI +"',SDT='"+ dto.SDT +"',FAX='"+ dto.FAX +"',WEBSITE='"+ dto.WEBSITE +"',YAHOO='"+ dto.YAHOO +"',SKYPE='"+ dto.SKYPE +"',TINHTRANG='"+ dto.TINHTRANG +"' where 	(MAKH='"+dto.MAKH +"')";
            executeNonQuery(SQL);
        }
        public void INSERTKHUVUC(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_add", sqlpa);
             * */
            string SQL = "insert into KHUVUC(MAKV,TENKV,GHICHU,TINHTRANG)"
            +" values('"+dto.MAKV+"',N'"+dto.TENKV+"',N'"+dto.GHICHU+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void INSERTNHOMHANG(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
           
            ChayProc("NHOMHANG_add", sqlpa);
            */
            string SQL = "insert into NHOMHANG(MANH,TENNHOMHANG,GHICHU)"
            +" values('"+dto.MANH+"',N'"+dto.TENNHOMHANG+"','"+dto.GHICHU+"')";
            executeNonQuery(SQL);
        }
        public void UPDATENHOMHANG(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));

            ChayProc("NHOMHANG_update", sqlpa);
            */
            string SQL = "update NHOMHANG set MANH='"+dto.MANH +"' ,TENNHOMHANG=N'"+dto.TENNHOMHANG+"',GHICHU=N'"+dto.GHICHU+"' where MANH='"+dto.MANH+"'";
            executeNonQuery(SQL);
        }
        public void INSERTBOPHAN(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new MySqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_add", sqlpa);
             */
            string SQL = "insert into BOPHAN(MABP,TENBOPHAN,TINHTRANG)"
            +" values('"+dto.MABP+"',N'"+dto.TENBOPHAN+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATEBOPHAN(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));
            sqlpa.Add(new MySqlParameter("@TENBOPHAN", dto.TENBOPHAN));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("BOPHAN_update", sqlpa);*/
            string SQL = "update BOPHAN set MABP= '"+dto.MABP+"',TENBOPHAN= N'"+dto.TENBOPHAN+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MABP='"+dto.MABP+"'";
            executeNonQuery(SQL);

        }
        public void UPDATEKHUVUC(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENKV", dto.TENKV));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("KHUVUC_update", sqlpa);
            */
            string SQL = "update KHUVUC set MAKV= '"+dto.MAKV+"',TENKV= N'"+dto.TENKV+"',GHICHU= N'"+dto.GHICHU+"',TINHTRANG= '"+dto.TINHTRANG+"' where MAKV='"+dto.MAKV+"'";
            executeNonQuery(SQL);
        }
        public void INSERTNHACC(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_add", sqlpa);
            */
            string SQL = "insert into NHACUNGCAP(MANCC,MAKV,TENNCC,DIACHI,MASOTHUE,SOTAIKHOAN,NGANHANG,SDT,EMAIL,FAX,WEBSITE,TINHTRANG)"
            +" values('"+dto.MANCC+"','"+dto.MAKV+"',N'"+dto.TENNCC+"',N'"+dto.DIACHI+"','"+dto.MASOTHUE+"','"+dto.SOTAIKHOAN+"',N'"+dto.NGANHANG+"','"+dto.SDT+"','"+dto.EMAIL+"','"+dto.FAX+"','"+dto.WEBSITE+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATENHACC(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            sqlpa.Add(new MySqlParameter("@TENNCC", dto.TENNCC));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new MySqlParameter("@SOTAIKHOAN", dto.SOTAIKHOAN));
            sqlpa.Add(new MySqlParameter("@NGANHANG", dto.NGANHANG));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@WEBSITE", dto.WEBSITE));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("NHACUNGCAP_update", sqlpa);
            */
            string SQL = "update NHACUNGCAP set MANCC= '"+dto.MANCC+"',MAKV= '"+dto.MAKV+"',TENNCC= N'"+dto.TENNCC+"',DIACHI= N'"+dto.DIACHI+"',MASOTHUE= '"+dto.MASOTHUE+"',SOTAIKHOAN= '"+dto.SOTAIKHOAN+"',NGANHANG= N'"+dto.NGANHANG+"',SDT= '"+dto.SDT+"',EMAIL= '"+dto.EMAIL+"',FAX= '"+dto.FAX+"', WEBSITE= '"+dto.WEBSITE+"',TINHTRANG= '"+dto.TINHTRANG+"' where MANCC='"+dto.MANCC+"'";
            executeNonQuery(SQL);
        }
        public void INSERTKHO(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new MySqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new MySqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));                        
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_add", sqlpa);
             */
            string SQL = "insert into KHO(MAKHO,MANV,TENKHO,DIACHI,SDTB,DTDD,NGUOILH,FAX,GHICHU,TINHTRANG)"
            + " values('" + dto.MAKHO + "','" + dto.MANV + "',N'" + dto.TENKHO + "',N'" + dto.DIACHI + "','" + dto.SDTB + "','" + dto.DTDD + "',N'" + dto.NGUOILH + "','" + dto.FAX + "','" + dto.GHICHU + "','" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
        }
        public void INSERTDVT(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@DONVITINH", dto.DONVITINH));
            ChayProc("DONVITINH_add", sqlpa);
             */
            string SQL = "insert into DONVITINH(MADVT,DONVITINH) values('"+dto.MADVT+"','"+dto.DONVITINH+"')";
            executeNonQuery(SQL);
        }
        public void INSERTTHUE(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@SOTHUE", dto.SOTHUE));

            ChayProc("THUE_add", sqlpa);
             */
            string SQL = "insert into THUE(MATH,SOTHUE) values('"+dto.MATH+"','"+dto.SOTHUE+"')";
            executeNonQuery(SQL);
        }
        public void UPDATETHUE(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new MySqlParameter("@SOTHUE", dto.SOTHUE));
            ChayProc("THUE_update", sqlpa);
             */
            string SQL = "update THUE set MATH= '"+dto.MATH+"',SOTHUE= '"+dto.SOTHUE+"' where 	MATH='"+dto.MATH+"'";
            executeNonQuery(SQL);
        }
        public void UPDATEDVT(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new MySqlParameter("@DONVITINH", dto.DONVITINH));
            ChayProc("DONVITINH_update", sqlpa);
            */
            string SQL = "update DONVITINH set MADVT= '"+dto.MADVT+"',DONVITINH= '"+dto.DONVITINH+"' where 	MADVT='"+dto.MADVT+"'";
            executeNonQuery(SQL);
        }
        public void UPDATENHANVIEN(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            
            sqlpa.Add(new MySqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_update", sqlpa);
             */
            string SQL = "update NHANVIEN set MANV= '" + dto.MANV + "',TENNV= N'" + dto.TENNV + "',DIACHI= N'" + dto.DIACHI + "',NGAYSINH= '" + dto.NGAYSINH + "',SCMND= '" + dto.SCMND + "',SDT= '" + dto.SDT + "',TINHTRANG= '" + dto.TINHTRANG + "' where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL);
        }
        public void UPDATEQUANLY(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));
           
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.PASSWORD));
            
            sqlpa.Add(new MySqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_update", sqlpa);
             */ 
            string SQL = "update QUANLY set MAQL= '"+dto.MAQL+"',USERNAME= '"+dto.USERNAME+"',PASSWORD= '"+dto.PASSWORD+"',TENQL= '"+dto.TENQL+"',DIACHI= '"+dto.DIACHI+"',NGAYSINH= '"+ dto.NGAYSINH+"',SCMND= '"+dto.SCMND+"',SDT= '"+dto.SDT+"',TINHTRANG= '"+dto.TINHTRANG+"' where MAQL='"+dto.MAQL+"'";
            executeNonQuery(SQL);
        }
        public void INSERTQUANLY(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));

            sqlpa.Add(new MySqlParameter("@USERNAME", dto.USERNAME));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.PASSWORD));

            sqlpa.Add(new MySqlParameter("@TENQL", dto.TENQL));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("QUANLY_add", sqlpa);
            */
            string SQL = "insert into dbo.[QUANLY](MAQL,USERNAME,PASSWORD,TENQL,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG)"
            +" values('"+dto.MAQL+"','"+dto.USERNAME+"','"+dto.PASSWORD+"',N'"+dto.TENQL+"',N'"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
      
        public void addMatHang(DTO dto)
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
           
            sqlpa.Add(new MySqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_add", sqlpa);
             */ 
            string SQL = "insert into MATHANG(MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN, MOTA,TINHTRANG)"
            +" values('"+dto.MAMH+"','"+dto.MATH+"','"+dto.MANH+"','"+dto.MAKHO+"',N'"+dto.TENMH+"','"+dto.MADVT+"',"+dto.SOLUONGMH+",'"+dto.HANSUDUNG+"',"+dto.GIAMUA+","+dto.GIABAN+", N'"+dto.MOTA+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATEMATHANG(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
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
            sqlpa.Add(new MySqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_update", sqlpa);
            */
            string SQL = "update MATHANG set MAMH= '"+dto.MAMH+"',MATH= '"+dto.MATH+"',MANH= '"+dto.MANH+"',MAKHO= '"+dto.MAKHO+"',TENMH= N'"+dto.TENMH+"',MADVT= '"+dto.MADVT+"',SOLUONGMH= "+dto.SOLUONGMH+",HANSUDUNG= '"+dto.HANSUDUNG+"',GIAMUA= "+dto.GIAMUA+",GIABAN= "+dto.GIABAN+", MOTA= N'"+dto.MOTA+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAMH='"+dto.MAMH+"'";
            executeNonQuery(SQL);
        }
        public void DELELEKHACHHANG(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            ChayProc("KHACHHANG_delete", sqlpa);
             */
            string SQL = "delete from KHACHHANG where 	MAKH='"+dto.MAKH+"'";
            executeNonQuery(SQL);
        }
        public void DELELEBOPHAN(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABP));
            ChayProc("BOPHAN_delete", sqlpa);
             */
            string SQL = "delete from BOPHAN where 	MABP='" + dto.MABP + "'";
            executeNonQuery(SQL);
        }
        public void DELELEMATHANG(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));
            ChayProc("MATHANG_delete", sqlpa);
            */
            string SQL = "delete from MATHANG where 	MAMH='" + dto.MAMH + "'";
            executeNonQuery(SQL);
        }
        public void DELELENHOMHANG(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANH", dto.MANH));
            ChayProc("NHOMHANG_delete", sqlpa);
             */
            string SQL = "delete from NHOMHANG where 	MANH='" + dto.MANH + "'";
            executeNonQuery(SQL);
        }
        public void DELELEQUANLY(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAQL", dto.MAQL));
            ChayProc("QUANLY_delete", sqlpa);
            */
            string SQL = "delete from QUANLY where 	MAQL='" + dto.MAQL + "'";
            executeNonQuery(SQL);
        }
        public void DELELETHUE(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MATH", dto.MATH));
            ChayProc("THUE_delete", sqlpa);
            */
            string SQL = "delete from THUE where 	MATH='" + dto.MATH + "'";
            executeNonQuery(SQL);
        }
        public void DELELEKHO(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            ChayProc("KHO_delete", sqlpa);
            */
            string SQL = "delete from KHO where 	MAKHO='" + dto.MAKHO + "'";
            executeNonQuery(SQL);
        }
        public void DELELEKV(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKV", dto.MAKV));
            ChayProc("KHUVUC_delete", sqlpa);
             */
            string SQL = "delete from KHUVUC where 	MAKV='" + dto.MAKV + "'";
            executeNonQuery(SQL);
        }
        public void DELELENCC(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            ChayProc("NHACUNGCAP_delete", sqlpa);
            */
            string SQL = "delete from NHACUNGCAP where 	MANCC='" + dto.MANCC + "'";
            executeNonQuery(SQL); 
        }
        public void DELELENHANVIEN(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            ChayProc("NHANVIEN_delete", sqlpa);
            */
            string SQL = "delete from NHANVIEN where 	MANV='" + dto.MANV + "'";
            executeNonQuery(SQL); 
        }
        public void DELELEDVT(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MADVT", dto.MADVT));
            ChayProc("DONVITINH_delete", sqlpa);
            */
            string SQL = "delete from DONVITINH where 	MADVT='" + dto.MADVT + "'";
            executeNonQuery(SQL);
        }
        public void INSERTNHANVIEN(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
           
            sqlpa.Add(new MySqlParameter("@TENNV", dto.TENNV));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@NGAYSINH", dto.NGAYSINH));
            sqlpa.Add(new MySqlParameter("@SCMND", dto.SCMND));
            sqlpa.Add(new MySqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("NHANVIEN_add", sqlpa);
            */
            string SQL = "insert into NHANVIEN(MANV,TENNV,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG)"
            +" values('"+dto.MANV+"','"+dto.TENNV+"','"+dto.DIACHI+"','"+dto.NGAYSINH+"','"+dto.SCMND+"','"+dto.SDT+"','"+dto.TINHTRANG+"')";
            executeNonQuery(SQL);
        }
        public void UPDATEKHO(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TENKHO", dto.TENKHO));
            sqlpa.Add(new MySqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new MySqlParameter("@SDTB", dto.SDTB));
            sqlpa.Add(new MySqlParameter("@DTDD", dto.DTDD));
            sqlpa.Add(new MySqlParameter("@NGUOILH", dto.NGUOILH));
            sqlpa.Add(new MySqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("KHO_update", sqlpa);
            */
            string SQL = "update KHO set MAKHO= '"+dto.MAKHO+"',MANV= '"+dto.MANV+"',TENKHO= N'"+dto.TENKHO+"',DIACHI= N'"+dto.DIACHI+"',SDTB= '"+dto.SDTB+"',DTDD= '"+dto.DTDD+"',NGUOILH= N'"+dto.NGUOILH+"',FAX= '"+dto.FAX+"',GHICHU= '"+dto.GHICHU+"',TINHTRANG= '"+dto.TINHTRANG+"' where 	MAKHO='"+dto.MAKHO+"'";
            executeNonQuery(SQL);
        }
       
        
       
        public DataTable GETKV()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHUVUC_getall", sqlpa);
             */
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
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("DONVITINH_getall", sqlpa);
            */
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
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
             */
            string SQL = "select 	MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,DATE_FORMAT(HANSUDUNG,'%D%M%Y'),GIAMUA,GIABAN,MOTA,TINHTRANG from  MATHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETTHUE()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("THUE_getall", sqlpa);
            */
            string SQL = "select 	MATH,SOTHUE from  THUE";
            return GET_DATA(SQL);
        }
        public DataTable GETNHANVIEN()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHANVIEN_getall", sqlpa);
            */
            string SQL = "select 	MANV,TENNV,DIACHI,DATE_FORMAT(NGAYSINH,'%d/%m/%Y')as NGAYSINH ,SCMND,SDT,TINHTRANG from  NHANVIEN";
            return GET_DATA(SQL);
        }
        public DataTable GETQUANLY()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("QUANLY_getall", sqlpa);
             */
            string SQL = "select 	MAQL,USERNAME,PASSWORD,TENQL,DIACHI,NGAYSINH,SCMND,SDT,TINHTRANG from  QUANLY";
            return GET_DATA(SQL);
        }
       /* public void deleteDVT(DTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            ChayProc("DONVITINH_delete", sqlpa);
        }*/

        public DataTable GETBP()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("BOPHAN_getall", sqlpa);
            */
            string SQL = "select 	MABP,TENBOPHAN,TINHTRANG from  BOPHAN";
            return GET_DATA(SQL);
        }
        public DataTable GETNHOMHANG()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
            */
            string SQL = "select 	MANH,TENNHOMHANG,GHICHU from  NHOMHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHKH()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
            */
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
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
             */
            string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETDANHSACHNCC()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHACUNGCAP_getall", sqlpa);
             */
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
         public string GETMAKHfromMHDX(string MAHDX)
         {
             DataTable dt;
             string SQL = "SELECT MAKH FROM HOADONXUAT WHERE MAHDX='" + MAHDX + "'";
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
        public DataTable GETMH()
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MATHANG_getall", sqlpa);
            */
            string SQL = "select 	MAMH,MATH,MANH,MAKHO,TENMH,MADVT,SOLUONGMH,HANSUDUNG,GIAMUA,GIABAN,MOTA,TINHTRANG from  MATHANG";
            return GET_DATA(SQL);
        }
        public DataTable GETMMH()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG";
            return getdata(SQL);
        }
        public DataTable GETDATA()
        {
            string SQL = "SELECT MAMH,TENMH FROM MATHANG";
            return getdata(SQL);
        }
        public DataTable GET_DATA(string SQL)
        {
            return getdata(SQL);
        }

        public DataTable GETTINHTRANG()
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHACHHANG_getall", sqlpa);
            */
             string SQL = "select 	MAKH,MAKV,TENKH,SOTAIKHOAN,NGANHANG,MASOTHUE,DIACHI,SDT,FAX,WEBSITE,YAHOO,SKYPE,TINHTRANG from  KHACHHANG";
            return GET_DATA(SQL);
        }
        public void INSERTHOADONNHAP(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAHDN", dto.MAHDN));
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            sqlpa.Add(new MySqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new MySqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));

            ChayProc("HOADONNHAP_add", sqlpa);
             */
            string SQL = "insert into HOADONNHAP(MAHDN,MANCC,MANV,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            +" values('"+dto.MAHDN+"','"+dto.MANCC+"','"+dto.MANV+"','"+dto.NGAYNHAP+"','"+dto.TIENPHAITRA+"','"+dto.TIENDATRA+"','"+dto.GHICHU+"','"+dto.TINHTRANG+"')";
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
        public void UPDATEHOADONNHAP(DTO dto)
        {
            string SQL = "update HOADONNHAP set MANCC='" + dto.MANCC + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= '" + dto.GHICHU + "' where (MAHDN='" + dto.MAHDN + "' )";
            executeNonQuery(SQL);
        }

        public void INSERTCTHOADONNHAP(DTO dto)
        {
            string SQL = "INSERT INTO CHITIETHDN (ID, MAHDN, MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDN + "','" + dto.MAMH + "'," + dto.SOLUONGNHAP + "," + dto.GIANHAP + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
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
        public void UPDATECTHOADONNHAP(DTO dto)
        {
            string SQL = "update CHITIETHDN set MAMH='" + dto.MAMH + "', SOLUONGNHAP=" + dto.SOLUONGNHAP + " ,GIANHAP=" + dto.GIANHAP + ", TINHTRANG= 1 where (MAHDN='" + dto.MAHDN + "' AND ID=" + dto.ID + ")";
            executeNonQuery(SQL);
        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID)
        {
            string SQL = "DELETE FROM CHITIETHDN where MAHDN='" + MAHDN + "' AND ID="+ID.ToString();
            executeNonQuery(SQL);
        }

        public DataTable GETCTHOADONNHAP()
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("CHITIETHDN_getall", sqlpa);
            */
            string SQL = "select 	MAHDN,MAMH,SOLUONGNHAP,GIANHAP,TINHTRANG from  CHITIETHDN";
            return getdata(SQL);
        }

        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            string SQL = "SELECT T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGNHAP _SoLuong,T6.GIANHAP _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGNHAP*T6.GIANHAP) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDN WHERE MAHDN='" + MAHDN + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDN where MAHDN='" + MAHDN + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            string SQL = "SELECT T5.MAMH _TenMH,T5.MAMH _MaMH,T6.SOLUONGXUAT _SoLuong,T6.GIATIEN _DonGia, T5.DONVITINH _DVT, (T6.SOLUONGXUAT*T6.GIATIEN) _Total FROM  (SELECT T3.*,T4.DONVITINH FROM (SELECT T1.TENMH,T1.MAMH,T1.SOLUONGMH,T1.GIABAN,T1.MADVT FROM (SELECT * FROM MATHANG WHERE MAMH IN (SELECT MAMH FROM CHITIETHDX WHERE MAHDX='" + MAHDX + "')) AS T1) AS T3 INNER JOIN DONVITINH AS T4 ON T3.MADVT =T4.MADVT) AS T5 INNER JOIN (select * from CHITIETHDX where MAHDX='" + MAHDX + "') T6 ON T6.MAMH =t5.MAMH";
            return getdata(SQL);
        }
        public DataTable GETHOADONNHAP(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAYNHAP", dto.NGAYNHAP));
            return executeNonQuerya("HOADONNHAP_get", sqlpa);
             */
            string SQL = "select 	MAHDN,MANCC,MANV,NGAYNHAP,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  HOADONNHAP where NGAYNHAP='"+dto.NGAYNHAP+"'";
            return getdata(SQL);
        }
        public DataTable LAYTIENNO(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANCC", dto.MANCC));
            return executeNonQuerya("LAYTIENNO", sqlpa);
             */
            string SQL = "select sum(TIENPHAITRA) - sum(TIENDATRA)as TIENNO from HOADONNHAP where MANCC ='"+dto.MANCC+"'";
            return getdata(SQL);
        }
        public void INSERTHOADONXUAT(DTO dto)
        {
            /*List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAHDX", dto.MAHDX));
            sqlpa.Add(new MySqlParameter("@MAKH", dto.MAKH));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            sqlpa.Add(new MySqlParameter("@TIENPHAITRA", dto.TIENPHAITRA));
            sqlpa.Add(new MySqlParameter("@TIENDATRA", dto.TIENDATRA));
            sqlpa.Add(new MySqlParameter("@GHICHU", dto.GHICHU));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("HOADONXUAT_add", sqlpa);
            */
            string SQL = "insert into HOADONXUAT(MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG)"
            +" values('"+dto.MAHDX+"','"+dto.MAKH+"','"+dto.MANV+"','"+dto.NGAYXUAT+"','"+dto.TIENPHAITRA+"','"+dto.TIENDATRA+"','"+dto.GHICHU+"','"+dto.TINHTRANG+"')";
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
        public void UPDATEHOADONXUAT(DTO dto)
        {
            string SQL = "update HOADONXUAT set MAKH='" + dto.MAKH + "', MANV= '" + dto.MANV + "' , TIENPHAITRA= '" + dto.TIENPHAITRA + "', TIENDATRA= '" + dto.TIENDATRA + "' , GHICHU= '" + dto.GHICHU + "' where (MAHDX='" + dto.MAHDX + "' )";
            executeNonQuery(SQL);
        }
        public void INSERTCTHOADONXUAT(DTO dto)
        {
            string SQL = "INSERT INTO CHITIETHDX (ID, MAHDX, MAMH,SOLUONGXUAT,GIATIEN,TINHTRANG) VALUES (" + dto.ID + ",'" + dto.MAHDX + "','" + dto.MAMH + "'," + dto.SOLUONGXUAT + "," + dto.GIATIEN + ",'" + dto.TINHTRANG + "')";
            executeNonQuery(SQL);
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
            string SQL = "update CHITIETHDX set MAMH='" + dto.MAMH + "',SOLUONGXUAT=" + dto.SOLUONGXUAT + " ,GIATIEN=" + dto.GIATIEN + ", TINHTRANG= 1 where (MAHDX='" + dto.MAHDX + "' AND ID=" + dto.ID.ToString() + ")";
            executeNonQuery(SQL);
        }
        public void DELETECTHOADONXUAT(string MAHDX, int ID)
        {
            string SQL = "DELETE FROM CHITIETHDX where MAHDX='" + MAHDX + "' AND ID=" + ID.ToString();
            executeNonQuery(SQL);
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
           /* List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAYXUAT", dto.NGAYXUAT));
            return executeNonQuerya("HOADONXUAT_get", sqlpa);
            */
            string SQL = "select 	MAHDX,MAKH,MANV,NGAYXUAT,TIENPHAITRA,TIENDATRA,GHICHU,TINHTRANG from  HOADONXUAT where NGAYXUAT='"+dto.NGAYXUAT+"'";
            return getdata(SQL);
        }






        
    }
}
