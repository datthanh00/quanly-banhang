using System;
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

      //---------------------------------------get all kho
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
        public DataTable getTonKhoncc(clDTO dto)
        {
            return dao.getTonKhoncc(dto);
        }
        public DataTable getTonKhoTTngay(clDTO dto)
        {
            return dao.getTonKhoTTngay(dto);
        }
        public DataTable getTonKhoTTngay2(clDTO dto)
        {
            return dao.getTonKhoTTngay2(dto);
        }
        //----------------------------------
        public  void Back_Up(clDTO dto)
        {
            dao.Backup(dto);
        }

        public void KET_SO()
        {
            dao.KET_SO();
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

        public DataTable getcpmuahangngay(clDTO dto)
        {
            return dao.getcpmuahangngay(dto);
        }

        public DataTable getcpmuahangncc(clDTO dto)
        {
            return dao.getcpmuahangncc(dto);
        }
        public DataTable getDoanhThungay(clDTO dto)
        {
            return dao.getDoanhThungay(dto);
        }
        public DataTable getDoanhThukh(clDTO dto)
        {
            return dao.getDoanhThukh(dto);
        }
        public DataTable getDoanhsonv(clDTO dto)
        {
            return dao.getDoanhsonv(dto);
        }
        public DataTable getcpmuahangsp(clDTO dto)
        {
            return dao.getcpmuahangsp(dto);
        }
        public DataTable getDoanhsosp(clDTO dto)
        {
            return dao.getDoanhsosp(dto);
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
