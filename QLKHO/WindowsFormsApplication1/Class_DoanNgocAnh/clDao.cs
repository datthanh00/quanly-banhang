using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{

    class clDao:Provider
    {
        public DataTable kiemtra_user(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@USERNAME", dto.TENDANGNHAP));
            return executeNonQuerya("KIEMTRA_USER", sqlpa);
        }

        public void inSertHoaDonXuat(clDTO dto)
        {
            //List<SqlParameter> sqlpa = new List<SqlParameter>();
           
            //sqlpa.Add(new SqlParameter("@ghichu", dto.MANHOMHANG));
            //sqlpa.Add(new SqlParameter("@tinhtrang", dto.TENNHOMHANG));
            //ChayProc("NHOMHANG_add", sqlpa);
        }
        public void addMatHang(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            sqlpa.Add(new SqlParameter("@MATH", dto.MATH));
            sqlpa.Add(new SqlParameter("@MANH", dto.MANH));
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@TENMH", dto.TENMH));
            sqlpa.Add(new SqlParameter("@MADVT", dto.MADVT));
            sqlpa.Add(new SqlParameter("@SOLUONGMH", dto.SOLUONGMH));
            sqlpa.Add(new SqlParameter("@HANSUDUNG", dto.HANSUDUNG));
            sqlpa.Add(new SqlParameter("@GIAMUA", dto.GIAMUA));
            sqlpa.Add(new SqlParameter("@GIABAN", dto.GIABAN));
            sqlpa.Add(new SqlParameter("@PICTURE", dto.PICTURE));
            sqlpa.Add(new SqlParameter("@MOTA", dto.MOTA));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("MATHANG_add", sqlpa);
        }
        public void insertNhomHang(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();

            sqlpa.Add(new SqlParameter("@MANHOMHANG", dto.MANHOMHANG));
            sqlpa.Add(new SqlParameter("@TENNHOMHANG", dto.TENNHOMHANG));
            ChayProc("NHOMHANG_add", sqlpa);
        }
        public void updateThonTinCongTy(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MACT", dto.MACT));
            sqlpa.Add(new SqlParameter("@TENCT", dto.TENCT));
            sqlpa.Add(new SqlParameter("@DIACHI", dto.DIACHI));
            sqlpa.Add(new SqlParameter("@FAX", dto.FAX));
            sqlpa.Add(new SqlParameter("@SDT", dto.SDT));
            sqlpa.Add(new SqlParameter("@MOBILE", dto.MOBILE));
            sqlpa.Add(new SqlParameter("@EMAIL", dto.EMAIL));
            sqlpa.Add(new SqlParameter("@LOGO", dto.LOGO));
            sqlpa.Add(new SqlParameter("@MASOTHUE", dto.MASOTHUE));
            sqlpa.Add(new SqlParameter("@WEBSITE", dto.WEBSITE));

            ChayProc("THONGTINCT_update", sqlpa);
        }//----------------GET NHAN VIEN
        public DataTable getNhanVien()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();


            return executeNonQuerya("NHANVIEN_gettrue", sqlpa);

        }
             public DataTable getNhanVienBP(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();

            sqlpa.Add(new SqlParameter("@mabp", dto.MABOPHAN));
            return executeNonQuerya("NHANVIEN_getoneBOPHAN", sqlpa);

        }
        public DataTable getBoPhan()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("BOPHAN_getall", sqlpa);
        }
        public DataTable getThongTinCT(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            
             sqlpa.Add(new SqlParameter("@MACT",dto.MACT));
            return executeNonQuerya("THONGTINCT_get", sqlpa);

        }
        public void delMatHang(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();

            sqlpa.Add(new SqlParameter("@MAMH", dto.MAMH));
            ChayProc("MATHANG_delete", sqlpa);
        }
        //-------------------------THEM NGUOI DUNG --

        public void THEMNGUOIDUNG(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MABP", dto.MABOPHAN));
            sqlpa.Add(new SqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new SqlParameter("@PASSWORD", dto.MATKHAU));
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@TINHTRANG", dto.TINHTRANG));
            ChayProc("THEMNGUOIDUNG_update", sqlpa);
        }
          public void SuaNguoiDung(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            sqlpa.Add(new SqlParameter("@MABP", dto.MABOPHAN));
            ChayProc("NHANVIEN_SuaNguoiDung", sqlpa);
        }
          public void DoiMatKhau(clDTO dto)
          {
              List<SqlParameter> sqlpa = new List<SqlParameter>();
              sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
              sqlpa.Add(new SqlParameter("@pass", dto.MATKHAU));
              ChayProc("NHANVIEN_DoiMatKhau", sqlpa);
          }
          public DataTable KiemTraMatKhau(clDTO dto)
          {
              List<SqlParameter> sqlpa = new List<SqlParameter>();
              sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
              sqlpa.Add(new SqlParameter("@Pass", dto.MATKHAU));
              return executeNonQuerya("NHANVIEN_KiemTraPass", sqlpa);
          }
        public void XoaNguoiDUng(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MANV", dto.MANV));
            ChayProc("NHANVIEN_XoaPQ", sqlpa);
        }
        public DataTable getNhomHang()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("NHOMHANG_getall", sqlpa);
            
        }//-----------------Get day du mat hang
           public DataTable getDayDuMatHang()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("MatHang_DayDu", sqlpa);
           
        }
        //------------------Lay Tat ca database--------
        public DataTable getDatabase()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("sp_databases", sqlpa);
        }//------------------Get all Kho-------------------
        public DataTable getKho()
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            return executeNonQuerya("KHO_getall", sqlpa);
        }
        //------------------------TON KHO
        public DataTable getTonKho(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            DataTable tb = new DataTable();
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("TONKHO_getall", sqlpa);
        }
        //--------------------Backup Restore---------------------------
        public  void Backup(clDTO DTO)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@TENFILE",DTO.TENFILE));
            ChayProc("BACKUP_DATABASE", sqlpa);
        }
        public DataTable getDoanhThu(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@NGAY_BD", dto.NGAYBD));
            sqlpa.Add(new SqlParameter("@NGAY_KT", dto.NGAYKT));
            sqlpa.Add(new SqlParameter("@LOAI_TG", dto.LOAITG));
            return executeNonQuerya("THONGKE_DOANHTHU", sqlpa);
        }
        public DataTable testLogin(clDTO dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@USERNAME", dto.TENDANGNHAP));
            sqlpa.Add(new SqlParameter("@PASSWORD", dto.MATKHAU));
            DataTable tb = new DataTable();
            return executeNonQuerya("TEST_NHANVIEN", sqlpa);
        }

       
    }
}
