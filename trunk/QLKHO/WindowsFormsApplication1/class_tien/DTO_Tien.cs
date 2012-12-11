using System;

namespace WindowsFormsApplication1
{
    class DTO_Tien
    {
        
    }
    #region get_NHACUNGCAP
    public class get_NHACUNGCAP_TRATIEN_DTO
    {
        protected string sMaNhaCungCap;
        protected string STenNhaCungCap;
       
        protected string sDiaChi;
        protected string sFax;
        protected string sSoDienThoai;
        public string MaNhaCungCap { get { return sMaNhaCungCap; } set { sMaNhaCungCap = value; } }
        public string TenNhaCungCap { get { return STenNhaCungCap; } set { STenNhaCungCap = value; } }
        
        public string DiaChi { get { return sDiaChi; } set { sDiaChi = value; } }
        public string Fax { get { return sFax; } set { sFax = value; } }
        public string SoDienThoai { get { return sSoDienThoai; } set { sSoDienThoai = value; } }

        private string _STRUYENGIATRI;

        public string STRUYENGIATRI
        {
            get { return _STRUYENGIATRI; }
            set { _STRUYENGIATRI = value; }
        }
    }
    #endregion
    #region THEMPHIEUCHI
    public class THEMPHIEUCHI_DTO
    {
        protected string sMaPhieuChi;
        public string MaPhieuChi { get { return sMaPhieuChi; } set { sMaPhieuChi = value; } }
    }
    #endregion
    #region CLASSPHIEUCHI
    public class PHIEUCHI_DTO
    {
        protected string sMaPhieuChi;
        protected string sNhanVien;
        protected DateTime dNgayChi;
        protected double dSoTienDaTra;
        private string sMahoadonnhap;

        public string Mahoadonnhap
        {
            get { return sMahoadonnhap; }
            set { sMahoadonnhap = value; }
        }
        
        public string MaPhieuChi { get { return sMaPhieuChi; } set { sMaPhieuChi = value; } }
        
        public string NhanVien { get { return sNhanVien; } set { sNhanVien = value; } }
        public DateTime NgayChi { get { return dNgayChi; } set { dNgayChi = value; } }
        
        public double SoTienDaTra { get { return dSoTienDaTra; } set { dSoTienDaTra = value; } }
    }
    #endregion
    #region CLASSPHIEUCHI
    public class PHIEUTHU_DTO
    {
        protected string sMaPhieuThu;
        protected string sNhanVien;
        protected DateTime dNgayThu;
        private string sMahoadonxuat;

        public string Mahoadonxuat
        {
            get { return sMahoadonxuat; }
            set { sMahoadonxuat = value; }
        }
        protected double dSoTienDaTra;

        public string MaPhieuThu { get { return sMaPhieuThu; } set { sMaPhieuThu = value; } }
        public string NhanVien { get { return sNhanVien; } set { sNhanVien = value; } }
        public DateTime NgayThu { get { return dNgayThu; } set { dNgayThu = value; } }
        public double SoTienDaTra { get { return dSoTienDaTra; } set { dSoTienDaTra = value; } }
    }
    #endregion
    #region THEMPHIEUTHU
    public class THEMPHIEUTHU_DTO
    {
        protected string sMaPhieuThu;
        public string MaPhieuThu { get { return sMaPhieuThu; } set { sMaPhieuThu = value; } }
    }
    #endregion
    #region XOAPHIEUTHU
    public class XOAPHIEUTHU_DTO
    {
        protected string sMaPhieuThu;
        public string MaPhieuThu { get { return sMaPhieuThu; } set { sMaPhieuThu = value; } }
    }
    #endregion
    #region XOAPHIEUCHI
    public class XOAPHIEUCHI_DTO
    {
        protected string sMaPhieuChi;
        public string MaPhieuChi { get { return sMaPhieuChi; } set { sMaPhieuChi = value; } }
    }
    #endregion
}   