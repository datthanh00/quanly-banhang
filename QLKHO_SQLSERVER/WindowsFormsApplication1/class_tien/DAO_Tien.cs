using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{

    class CONGNOKH:Provider
    {
        public  Mysqlchange MSQL = new Mysqlchange();
        
        public  DataTable GETALLHDX_DAO(string NGAYBD,string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT MAHDX as 'Mã hóa đơn xuất',DATE_FORMAT(NGAYXUAT,'%d/%m/%Y') as 'Ngày Xuất',TENKH as 'Tên khách hàng',HOADONXUAT.MAKH as 'Mã khách hàng',TIENPHAITRA AS 'Tiền phải trả',TIENdaTRA as 'Tiền đã trả', tienphaitra-tiendatra as 'Còn lại' FROM HOADONXUAT,KHACHHANG WHERE HOADONXUAT.MAKH=KHACHHANG.MAKH AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra <> 0 and ngayxuat BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' group by hoadonxuat.mahdx,hoadonxuat.tienphaitra,hoadonxuat.tiendatra,khachhang.tenkh,hoadonxuat.makh,hoadonxuat.ngayxuat";
            return pv.getdata(SQL);
        }
        public DataTable GETALLPHIEUCHI_DAO(string NGAYBD, string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT MAPT as 'Mã phiếu thu',TENNV as 'Tên nhân viên',HOADONXUAT.MAhdx as 'Mã hóa đơn xuất', DATE_FORMAT(ngaythu ,'%d/%m/%Y')AS 'Ngày thu',SoTienTra_PT as 'Tiền đã trả' FROM PHIEUTHU ,NHANVIEN, HOADONXUAT WHERE  NHANVIEN.MANV=PHIEUTHU.MANV AND HOADONXUAT.MAHDX=PHIEUTHU.MAHDX AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and ngaythu BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
            return pv.getdata(SQL);
        }
        public  DataTable get1pt_dao(string sMahdx)
        {
            Provider pv = new Provider();
            string SQL = "SELECT MAPT as 'Mã phiếu thu',HOADONXUAT.MANV as 'Mã nhân viên',HOADONXUAT.MAhdx as 'Mã hóa đơn xuất',DATE_FORMAT(ngaythu ,'%d/%m/%Y')AS 'Ngày thu',sotientra_pt as 'Tiền đã trả' FROM PHIEUTHU,HOADONXUAT WHERE PHIEUTHU.MAHDX=HOADONXUAT.MAHDX AND HOADONXUAT.MAHDX='" + sMahdx + "'";
            return pv.getdata(SQL);
        }

        public  void THEM_PHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUTHU (MAPT,MAHDX,NGAYTHU,MANV,SoTienTra_PT)"
            + " VALUES('" + dto.MaPhieuThu + "', '" + dto.Mahoadonxuat + "',CURDATE(),'" + dto.NhanVien + "','" + dto.SoTienDaTra + "')";
            pv.executeNonQuery(SQL);

            SQL = "update hoadonxuat set TIENDATRA=tiendatra+(select SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);

        }
       
        public  void SUAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {

            Provider pv = new Provider();

            string SQL = "UPDATE HOADONXUAT SET TIENDATRA=(tiendatra-(select SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'))+'" + dto.SoTienDaTra + "' where MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);

            SQL = " UPDATE  PHIEUTHU set MANV='" + dto.NhanVien + "',SoTienTra_PT='" + dto.SoTienDaTra + "' WHERE MAPT='" + dto.MaPhieuThu + "' and MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);
        }
        
    }
    class CONGNONCC
    {
        public  Mysqlchange MSQL = new Mysqlchange();
        public  DataTable GETALLHDN_DAO()
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAHDN as 'Mã hóa đơn nhập',TENncc as 'Tên nhà cung cấp',HOADONnhap.MAncc as 'Mã nhà cung cấp',TIENPHAITRA AS 'Tiền phải trả',TIENdaTRA as 'Tiền đã trả', tienphaitra-tiendatra as 'Còn lại'"
            +" FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc AND HOADONNHAP.MAKHO='"+PublicVariable.MAKHO+"' and hoadonnhap.tinhtrang='false' "
            +" group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc";
            return pv.getdata(SQL);
        }
        public  DataTable GETALLcongno_ncc(string NGAYBD, string NGAYKT)
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAHDN as 'Mã hóa đơn nhập',DATE_FORMAT(NGAYNHAP ,'%d/%m/%Y')AS 'Ngày nhập',TENncc as 'Tên nhà cung cấp',HOADONnhap.MAncc as 'Mã nhà cung cấp',TIENPHAITRA AS 'Tiền phải trả',TIENdaTRA as 'Tiền đã trả', tienphaitra-tiendatra as 'Còn lại' FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc AND HOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and ngaynhap BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc,hoadonnhap.ngaynhap";
            return pv.getdata(SQL);
        }

        public  string GETcongno_HDN(string MHDN)
        {
   
            Provider pv = new Provider();
            string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONnhap where MAHDN='"+MHDN+"' ";
            DataTable dt = new DataTable();
            dt= pv.getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "0";
        }
        public  string GETcongno_HDX(string MHDX)
        {
      
            Provider pv = new Provider();
            string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONXUAT where MAHDX='" + MHDX + "' ";
            DataTable dt = new DataTable();
            dt = pv.getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "0";

        }
        public  DataTable get1pc_dao(string sMahdn)
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAPc as 'Mã phiếu chi',MANV as 'Mã nhân viên',MAhdn as 'Mã hóa đơn nhập',DATE_FORMAT(NGAYCHI ,'%d/%m/%Y')AS  'Ngày chi',SoTienDaTra_PC as 'Tiền đã trả' FROM PHIEUCHI WHERE MAHDN='" + sMahdn + "'";
            return pv.getdata(SQL);
        }
        public  DataTable Getall_phieuchi_Dao(string NGAYBD, string NGAYKT)
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAPc as 'Mã phiếu chi',TENNV as 'Tên nhân viên',HOADONNHAP.MAhdn as 'Mã hóa đơn nhập',DATE_FORMAT(NGAYCHI ,'%d/%m/%Y')AS  'Ngày chi',SoTienDaTra_PC as 'Tiền đã trả' FROM PHIEUCHI, NHANVIEN,HOADONNHAP WHERE PHIEUCHI.MANV=NHANVIEN.MANV AND PHIEUCHI.MAHDN=HOADONNHAP.MAHDN AND HOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and ngaychi BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
            return pv.getdata(SQL);
        }
        public  void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();
            string SQL = " UPDATE HOADONnhap SET TIENDATRA=(tiendatra-(select SoTienDaTra_PC FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "'))+'" + dto.SoTienDaTra + "' where MAHDN='" + dto.Mahoadonnhap + "'";
            pv.executeNonQuery(SQL);

            SQL = " UPDATE  PHIEUCHI set MANV='" + dto.NhanVien + "',SoTienDaTra_PC='" + dto.SoTienDaTra + "' WHERE MAPC='" + dto.MaPhieuChi + "' and MAHDN='" + dto.Mahoadonnhap + "'";
            pv.executeNonQuery(SQL);

        }
        public  void THEM_PHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUCHI (MAPC,MAHDN,NGAYCHI,MANV,SoTienDaTra_PC)   VALUES('" + dto.MaPhieuChi + "', '" + dto.Mahoadonnhap + "',CURDATE(),'" + dto.NhanVien + "','" + dto.SoTienDaTra + "')";
            pv.executeNonQuery(SQL);

            SQL = " update hoadonnhap set TIENDATRA=tiendatra+(select SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "') WHERE MAHDN='" + dto.Mahoadonnhap + "'";
            pv.executeNonQuery(SQL);

        }
    }

    class NHACUNGCAP
    {
        string ManNCC;

        public string ManNCC1
        {
            get { return ManNCC; }
            set { ManNCC = value; }
        }


        string TenNCC;

        public string TenNCC1
        {
            get { return TenNCC; }
            set { TenNCC = value; }
        }


        string Diachi;

        public string Diachi1
        {
            get { return Diachi; }
            set { Diachi = value; }
        }

        string MaSoThue;

        public string MaSoThue1
        {
            get { return MaSoThue; }
            set { MaSoThue = value; }
        }


        string SdT;

        public string SdT1
        {
            get { return SdT; }
            set { SdT = value; }
        }

        string Email;

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }

        string GhiChu;

        public string GhiChu1
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }

        int SoTienPhaiTra;

        public int SoTienPhaiTra1
        {
            get { return SoTienPhaiTra; }
            set { SoTienPhaiTra = value; }
        }
        int SoTienDaTra;

        public int SoTienDaTra1
        {
            get { return SoTienDaTra; }
            set { SoTienDaTra = value; }
        }
    }
}
