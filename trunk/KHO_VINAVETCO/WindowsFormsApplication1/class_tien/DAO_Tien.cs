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
       // public  Mysqlchange MSQL = new Mysqlchange();
        
        public  DataTable GETALLHDX_DAO(string NGAYBD,string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = " SELECT T1.*, TENKH  FROM KHACHHANG, (SELECT MAHDX,MAKH, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYXUAT ,103)AS NGAYXUAT FROM HOADONXUAT WHERE  TYPE=1 AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and NGAYXUAT BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'"
            + " UNION SELECT 'CONGNODAUKY' AS MAHDX,MAKH,TONGTIENTRA AS TIENPHAITRA, TIENDATRA,TONGTIENTRA- TIENDATRA AS CONLAI,convert(varchar,NGAY ,103)AS NGAYXUAT  FROM TONDAUCONGNOKH WHERE TONGTIENTRA-TIENDATRA<>0 AND NGAY BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "') AS T1 WHERE T1.MAKH=KHACHHANG.MAKH"
            + " UNION SELECT MAHDN AS MAHDX,NHACUNGCAP.MANCC AS MAKH, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYNHAP ,103)AS NGAYXUAT,TENNCC AS TENKH FROM TRAHOADONNHAP,NHACUNGCAP WHERE  TYPE=1 AND TRAHOADONNHAP.MANCC=NHACUNGCAP.MANCC AND TRAHOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and NGAYNHAP BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
            return pv.getdata(SQL);
        }
        public DataTable GETALLPHIEUTHU_DAO(string NGAYBD, string NGAYKT)
        {
        

            Provider pv = new Provider();
            string SQL = "SELECT MAPT ,TENNV ,HOADONXUAT.MAHDX ,convert(varchar,NGAYTHU ,103)AS  NGAYTHU ,SoTienTra_PT AS TIENDATRA FROM PHIEUTHU, NHANVIEN,HOADONXUAT WHERE PHIEUTHU.MANV=NHANVIEN.MANV AND PHIEUTHU.MAHDX=HOADONXUAT.MAHDX AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and ngaythu BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'"
                + " UNION SELECT MAPT ,TENNV ,MAHDX ,convert(varchar,NGAYTHU ,103)AS  NGAYTHU ,SoTienTra_PT AS TIENDATRA FROM PHIEUTHU, NHANVIEN,TRAHOADONNHAP WHERE PHIEUTHU.MANV=NHANVIEN.MANV AND PHIEUTHU.MAHDX=TRAHOADONNHAP.MAHDN AND TRAHOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and ngaythu BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'"
                + " UNION SELECT MAPT ,TENNV ,MAHDX ,convert(varchar,NGAYTHU ,103)AS  NGAYTHU ,SoTienTra_PT AS TIENDATRA FROM PHIEUTHU, NHANVIEN,TONDAUCONGNOKH WHERE PHIEUTHU.MANV=NHANVIEN.MANV AND PHIEUTHU.MAHDX=TONDAUCONGNOKH.MAKH and ngaythu BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
            return pv.getdata(SQL);
        }
        public  DataTable get1pt_dao(string sMahdx)
        {
            Provider pv = new Provider();
         
            string SQL = "SELECT MAPT ,MANV ,MAHDX ,convert(varchar,ngaythu ,103)AS NGAYTHU,sotientra_pt as TIENDATRA FROM PHIEUTHU WHERE  MAHDX='" + sMahdx + "'";
            return pv.getdata(SQL);
        }
        public  DataTable GETBANGGIA()
        {
            Provider pv = new Provider();
            string SQL = "SELECT * FROM BANGGIA WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }
        
        public  void THEM_PHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUTHU (MAPT,MAHDX,NGAYTHU,MANV,SoTienTra_PT)"
            + " VALUES('" + dto.MaPhieuThu + "', '" + dto.Mahoadonxuat + "',convert(varchar,getDate(),101),'" + dto.NhanVien + "','" + dto.SoTienDaTra + "')";
            pv.executeNonQuery(SQL);

            SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE hoadonxuat set TIENDATRA=tiendatra+(select SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAHDX='" + dto.Mahoadonxuat + "'";
            SQL = SQL + "\r\nGO\r\n update TRAHOADONNHAP SET TIENDATRA=tiendatra+(select SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAHDN='" + dto.Mahoadonxuat + "'";
            SQL = SQL + "\r\nGO\r\n update TONDAUCONGNOKH SET TIENDATRA=tiendatra+(select SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAKH='" + dto.Mahoadonxuat + "' ";
            pv.executeNonQuery2(SQL);

        }
       
        public  void SUAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {

            Provider pv = new Provider();

            string SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE hoadonxuat set TIENDATRA=(tiendatra-(select SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'))+'" + dto.SoTienDaTra + "' where MAHDX='" + dto.Mahoadonxuat + "'";
            SQL = SQL + "\r\nGO\r\n update TRAHOADONNHAP SET TIENDATRA=(tiendatra-(select SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'))+'" + dto.SoTienDaTra + "' where MAHDN='" + dto.Mahoadonxuat + "'";
            SQL = SQL + "\r\nGO\r\n update TONDAUCONGNOKH SET TIENDATRA=(tiendatra-(select SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'))+'" + dto.SoTienDaTra + "' where MAKH='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery2(SQL);

             SQL = " UPDATE  PHIEUTHU set MANV='" + dto.NhanVien + "',SoTienTra_PT='" + dto.SoTienDaTra + "' WHERE MAPT='" + dto.MaPhieuThu + "' and MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);

          

           
        }
        
    }
    class CONGNONCC
    {
       // public  Mysqlchange MSQL = new Mysqlchange();
        public  DataTable GETALLHDN_DAO()
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAHDN ,TENNCC,HOADONnhap.MANCC,TIENPHAITRA ,TIENDATRA, tienphaitra-tiendatra as CONLAI"
            +" FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc AND HOADONNHAP.MAKHO='"+PublicVariable.MAKHO+"' and hoadonnhap.tinhtrang='false' "
            +" group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc";
            return pv.getdata(SQL);
        }
        public  DataTable GETALLcongno_ncc(string NGAYBD, string NGAYKT)
        {

            Provider pv = new Provider();
            string SQL = " SELECT T1.*, TENNCC  FROM NHACUNGCAP, (SELECT MAHDN,MANCC, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYNHAP ,103)AS NGAYNHAP FROM HOADONNHAP WHERE  TYPE=1 AND HOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and ngaynhap BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'"
            + " UNION SELECT 'CONGNODAUKY' AS MAHDN,MANCC,TONGTIENTRA AS TIENPHAITRA, TIENDATRA,TONGTIENTRA- TIENDATRA AS CONLAI,convert(varchar,NGAY ,103)AS NGAYNHAP  FROM TONDAUCONGNONCC WHERE TONGTIENTRA-TIENDATRA<>0 AND NGAY BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "') AS T1 WHERE T1.MANCC=NHACUNGCAP.MANCC"
            + " UNION SELECT MAHDX AS MAHDN,KHACHHANG.MAKH AS MANCC, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYXUAT ,103)AS NGAYNHAP,TENKH AS TENNCC FROM TRAHOADONXUAT,KHACHHANG WHERE  TYPE=1 AND TRAHOADONXUAT.MAKH=KHACHHANG.MAKH AND TRAHOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and NGAYXUAT BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
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
            string SQL = "SELECT MAPC,MANV ,MAHDN ,convert(varchar,NGAYCHI ,103)AS NGAYCHI,SoTienDaTra_PC as TIENDATRA FROM PHIEUCHI WHERE MAHDN='" + sMahdn + "'";
            return pv.getdata(SQL);
        }
        public  DataTable Getall_phieuchi_Dao(string NGAYBD, string NGAYKT)
        {

            Provider pv = new Provider();
            string SQL = String.Format("SELECT MAPC ,TENNV ,HOADONNHAP.MAHDN ,convert(varchar,NGAYCHI ,103)AS  NGAYCHI ,SoTienDaTra_PC AS TIENDATRA FROM PHIEUCHI, NHANVIEN,HOADONNHAP WHERE PHIEUCHI.MANV=NHANVIEN.MANV AND PHIEUCHI.MAHDN=HOADONNHAP.MAHDN AND HOADONNHAP.MAKHO='{0}' and ngaychi BETWEEN '{1}' and '{2}' UNION SELECT MAPC ,TENNV ,MAHDN ,convert(varchar,NGAYCHI ,103)AS  NGAYCHI ,SoTienDaTra_PC AS TIENDATRA FROM PHIEUCHI, NHANVIEN,TRAHOADONXUAT WHERE PHIEUCHI.MANV=NHANVIEN.MANV AND PHIEUCHI.MAHDN=TRAHOADONXUAT.MAHDX AND TRAHOADONXUAT.MAKHO='{0}' and ngaychi BETWEEN '{1}' and '{2}'UNION SELECT MAPC ,TENNV ,MAHDN ,convert(varchar,NGAYCHI ,103)AS  NGAYCHI ,SoTienDaTra_PC AS TIENDATRA FROM PHIEUCHI, NHANVIEN,TONDAUCONGNONCC WHERE PHIEUCHI.MANV=NHANVIEN.MANV AND PHIEUCHI.MAHDN=TONDAUCONGNONCC.MANCC and ngaychi BETWEEN '{1}' and '{2}'", PublicVariable.MAKHO, NGAYBD, NGAYKT);
            return pv.getdata(SQL);

        }
        public  void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n update hoadonnhap set TIENDATRA=(tiendatra-(select SoTienDaTra_PC FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "'))+'" + dto.SoTienDaTra + "' where MAHDN='" + dto.Mahoadonnhap + "'";
            SQL = SQL + "\r\nGO\r\n update TRAHOADONXUAT SET TIENDATRA=(tiendatra-(select SoTienDaTra_PC FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "'))+'" + dto.SoTienDaTra + "' where MAHDX='" + dto.Mahoadonnhap + "'";
            SQL = SQL + "\r\nGO\r\n update TONDAUCONGNONCC SET TIENDATRA=tiendatra+(select SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "') WHERE MANCC='" + dto.Mahoadonnhap + "' ";
            pv.executeNonQuery2(SQL);

            SQL = " UPDATE  PHIEUCHI set MANV='" + dto.NhanVien + "',SoTienDaTra_PC='" + dto.SoTienDaTra + "' WHERE MAPC='" + dto.MaPhieuChi + "' and MAHDN='" + dto.Mahoadonnhap + "'";
            pv.executeNonQuery(SQL);



        }
        public  void THEM_PHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUCHI (MAPC,MAHDN,NGAYCHI,MANV,SoTienDaTra_PC)   VALUES('" + dto.MaPhieuChi + "', '" + dto.Mahoadonnhap + "',convert(varchar,getDate(),101),'" + dto.NhanVien + "','" + dto.SoTienDaTra + "')";
            pv.executeNonQuery(SQL);
            SQL = "";
            SQL = SQL + "\r\nGO\r\n update hoadonnhap set TIENDATRA=tiendatra+(select SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "') WHERE MAHDN='" + dto.Mahoadonnhap + "' ";
            SQL = SQL + "\r\nGO\r\n update TRAHOADONXUAT SET TIENDATRA=tiendatra+(select SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "') WHERE MAHDX='" + dto.Mahoadonnhap + "' ";
            SQL = SQL + "\r\nGO\r\n update TONDAUCONGNONCC SET TIENDATRA=tiendatra+(select SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='" + dto.Mahoadonnhap + "' AND MAPC='" + dto.MaPhieuChi + "') WHERE MANCC='" + dto.Mahoadonnhap + "' ";
            pv.executeNonQuery2(SQL);

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
