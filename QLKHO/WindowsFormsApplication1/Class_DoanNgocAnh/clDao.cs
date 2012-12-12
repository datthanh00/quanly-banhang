using System;
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
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
            return executeNonQuerya("KIEMTRA_USER", sqlpa);
        }

        public void addMatHang(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
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
        }
        public void insertNhomHang(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            sqlpa.Add(new MySqlParameter("@MANHOMHANG", dto.MANHOMHANG));
            sqlpa.Add(new MySqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            ChayProc("NHOMHANG_add", sqlpa);
        }
        public void updateThonTinCongTy(clDTO dto)
        {
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
        }//----------------GET NHAN VIEN
        public DataTable getNhanVien()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();


            return executeNonQuerya("NHANVIEN_gettrue", sqlpa);

        }
             public DataTable getNhanVienBP(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            sqlpa.Add(new MySqlParameter("@mabp", dto.MABOPHAN));
            return executeNonQuerya("NHANVIEN_getoneBOPHAN", sqlpa);

        }
        public DataTable getBoPhan()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("BOPHAN_getall", sqlpa);
        }
        public DataTable getThongTinCT(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            
             sqlpa.Add(new MySqlParameter("@MACT",dto.MACT));
            return executeNonQuerya("THONGTINCT_get", sqlpa);

        }
        public void delMatHang(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();

            sqlpa.Add(new MySqlParameter("@MAMH", dto.MAMH));
            ChayProc("MATHANG_delete", sqlpa);
        }
        //-------------------------THEM NGUOI DUNG --

        public void THEMNGUOIDUNG(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABOPHAN));
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.MATKHAU));
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("THEMNGUOIDUNG_update", sqlpa);
        }
          public void SuaNguoiDung(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new MySqlParameter("@MABP", dto.MABOPHAN));
            ChayProc("NHANVIEN_SuaNguoiDung", sqlpa);
        }
          public void DoiMatKhau(clDTO dto)
          {
              List<MySqlParameter> sqlpa = new List<MySqlParameter>();
              sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
              sqlpa.Add(new MySqlParameter("@pass", dto.MATKHAU));
              ChayProc("NHANVIEN_DoiMatKhau", sqlpa);
          }
          public DataTable KiemTraMatKhau(clDTO dto)
          {
              List<MySqlParameter> sqlpa = new List<MySqlParameter>();
              sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
              sqlpa.Add(new MySqlParameter("@Pass", dto.MATKHAU));
              return executeNonQuerya("NHANVIEN_KiemTraPass", sqlpa);
          }
        public void XoaNguoiDUng(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MANV", dto.MANV));
            ChayProc("NHANVIEN_XoaPQ", sqlpa);
        }
        public DataTable getNhomHang()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
            
        }//-----------------Get day du mat hang
           public DataTable getDayDuMatHang()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("MatHang_DayDu", sqlpa);
           
        }
        //------------------Lay Tat ca database--------
        public DataTable getDatabase()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("sp_databases", sqlpa);
        }//------------------Get all Kho-------------------
        public DataTable getKho()
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("KHO_getall", sqlpa);
        }
        //------------------------TON KHO
        public DataTable getTonKho(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("TONKHO_getall", sqlpa);
        }
        //--------------------Backup Restore---------------------------
        public  void Backup(clDTO DTO)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@TENFILE",DTO.TENFILE));
            ChayProc("BACKUP_DATABASE", sqlpa);
        }
        public DataTable getDoanhThu(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAY_BD", dto.NGAYBD));
            sqlpa.Add(new MySqlParameter("@NGAY_KT", dto.NGAYKT));
            sqlpa.Add(new MySqlParameter("@LOAI_TG", dto.LOAITG));
            return executeNonQuerya("THONGKE_DOANHTHU", sqlpa);
        }
        public DataTable testLogin(clDTO dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new MySqlParameter("@PASSWORD", dto.MATKHAU));
            return executeNonQuerya("TEST_NHANVIEN", sqlpa);
        }

       
    }
}
