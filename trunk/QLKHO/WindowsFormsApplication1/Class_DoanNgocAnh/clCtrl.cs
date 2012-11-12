using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication1
{
    class clCtrl
    {
        clDao dao = new clDao();
        public DataTable kiemtra_user(clDTO dto)
        {
            return dao.kiemtra_user(dto);
        }
        public void insertNhomHang(clDTO dto)
        {
            dao.insertNhomHang(dto);
        }
        public void addMatHangCtrl(clDTO dto)
        {
            dao.addMatHang(dto);
        }
        public void updateThongTinCT(clDTO dto)
        {
            dao.updateThonTinCongTy(dto);
        }
        public void XoaNguoiDung(clDTO dto)
        {
            dao.XoaNguoiDUng(dto);
        }
        public void SuaNguoiDung(clDTO dto)
        {
            dao.SuaNguoiDung(dto);
        }
        public DataTable getOneNhanVienBP(clDTO dto)
        {
            return dao.getNhanVienBP(dto);
        }
        public DataTable getTTCTy(clDTO dto)
        {
            return dao.getThongTinCT(dto);
        }
        public void delMatHangCtrl(clDTO dto)
        {
            dao.delMatHang(dto);
        }
        public DataTable getNhomHang()
        {
            return dao.getNhomHang();
        }
        public DataTable getDayDuMatHang()
        {
            return dao.getDayDuMatHang();
        }
        public DataTable getDatabase()
        {
            return dao.getDatabase();
        }//---------------------------------------get all kho
        public DataTable getallKho()
        {
            return dao.getKho();
        }//---------------Nhan Vien
        public DataTable getNhanVien()
        {
            return dao.getNhanVien();
        }
        //----------------bo phan
        public DataTable getBoPhan()
        {
            return dao.getBoPhan();
        }
        //------------------ton kho
        public DataTable getTonKho(clDTO dto)
        {
            return dao.getTonKho(dto);
        }
        //----------------------------------
        public  void Back_Up(clDTO dto)
        {
            dao.Backup(dto);
        }
        public void THEMNGUOIDUNG_UPDATE(clDTO dto)
        {
            dao.THEMNGUOIDUNG(dto);
        }
        public void DoiMatKhau(clDTO dto)
        {
            dao.DoiMatKhau(dto);
        }

        clDaoRestore daorestore = new clDaoRestore();
        public void ReStore(clDTO dto)
        {
            daorestore.ReStore(dto);
        }
        //------------------------------------dOANH THU-------------
        public DataTable getDoanhThu(clDTO dto)
        {
            return dao.getDoanhThu(dto);
        }
        //________________________________TestLogin_____________________________
        public DataTable ctrTestLogin(clDTO dto)
        {
            return dao.testLogin(dto);
        }
        public DataTable KiemTraPass(clDTO dto)
        {
            return dao.KiemTraMatKhau(dto);
        }
    }
}
