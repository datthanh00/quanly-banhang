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
        public DataTable GETALLcongno_kh()
        {
             Provider pv = new Provider();
             string SQL = "SELECT MAKH, TENKH, CONGNO FROM KHACHHANG WHERE MAKHO='"+PublicVariable.MAKHO+"'";
          
             return pv.getdata(SQL);

        }
        public  DataTable GETALLHDX_DAO(string NGAYBD,string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = " SELECT T1.*, TENKH  FROM KHACHHANG, (SELECT MAHDX,MAKH, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYXUAT ,103)AS NGAYXUAT FROM HOADONXUAT WHERE  TYPE=1 AND HOADONXUAT.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and NGAYXUAT BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'"
            + " UNION ALL SELECT 'CONGNODAUKY' AS MAHDX,MA AS MAKH,TONGTIENTRA AS TIENPHAITRA, TIENDATRA,TONGTIENTRA- TIENDATRA AS CONLAI,convert(varchar,NGAY ,103)AS NGAYXUAT  FROM TONDAUPHAITHU WHERE TONGTIENTRA-TIENDATRA<>0 AND NGAY BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "') AS T1 WHERE T1.MAKH=KHACHHANG.MAKH"
            + " UNION ALL SELECT 'CONGNODAUKY' AS MAHDX,MA AS MAKH,TONGTIENTRA AS TIENPHAITRA, TIENDATRA,TONGTIENTRA- TIENDATRA AS CONLAI,convert(varchar,NGAY ,103)AS NGAYXUAT,TENNCC  FROM TONDAUPHAITHU,NHACUNGCAP WHERE TONGTIENTRA-TIENDATRA<>0 AND NGAY BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND TONDAUPHAITHU.MA=NHACUNGCAP.MANCC"
            + " UNION ALL SELECT MAHDN AS MAHDX,NHACUNGCAP.MANCC AS MAKH, TIENPHAITRA,TIENDATRA, tienphaitra-tiendatra as CONLAI ,convert(varchar,NGAYNHAP ,103)AS NGAYXUAT,TENNCC AS TENKH FROM TRAHOADONNHAP,NHACUNGCAP WHERE  TYPE=1 AND TRAHOADONNHAP.MANCC=NHACUNGCAP.MANCC AND TRAHOADONNHAP.MAKHO='" + PublicVariable.MAKHO + "' and tienphaitra-tiendatra<>0 and NGAYNHAP BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'";
            return pv.getdata(SQL);
        }
        public DataTable GETALL_PHIEUTHU_DAO(string NGAYBD, string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT 'PT' AS TYPE,KHACHHANG.MAKH,TENKH,MAPT,SOTIEN,NGAYTHU AS NGAY,IDNHAP FROM PHIEUTHU, KHACHHANG WHERE KHACHHANG.MAKH=PHIEUTHU.MADOITUONG AND NGAYTHU BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT 'PC' AS TYPE, KHACHHANG.MAKH,TENKH,MAPC AS MAPT,-SOTIEN AS SOTIEN,NGAYCHI AS NGAY,IDNHAP FROM PHIEUCHI, KHACHHANG WHERE KHACHHANG.MAKH=PHIEUCHI.MADOITUONG  AND NGAYCHI BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }

        public DataTable GETALLHOADON_ctrl(string NGAYBD, string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT KHACHHANG.MAKH,TENKH,MAPT AS MAHD,-SOTIEN AS SOTIEN,NGAYTHU AS NGAY,N'Khách Trả Tiền' AS CHUCNANG,IDNHAP FROM PHIEUTHU, KHACHHANG WHERE KHACHHANG.MAKH=PHIEUTHU.MADOITUONG AND NGAYTHU BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT KHACHHANG.MAKH,TENKH,MAPC  AS MAHD,SOTIEN AS SOTIEN,NGAYCHI AS NGAY,N'Khách Nhận Tiền' AS CHUCNANG,IDNHAP FROM PHIEUCHI, KHACHHANG WHERE KHACHHANG.MAKH=PHIEUCHI.MADOITUONG  AND NGAYCHI BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT KHACHHANG.MAKH,TENKH,MAHDX  AS MAHD,TIENPHAITRA AS SOTIEN,NGAYXUAT AS NGAY,N'Mua Hàng' AS CHUCNANG,IDNHAP FROM HOADONXUAT, KHACHHANG WHERE KHACHHANG.MAKH=HOADONXUAT.MAKH  AND NGAYXUAT BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT KHACHHANG.MAKH,TENKH,MAHDX  AS MAHD,-TIENPHAITRA AS SOTIEN,NGAYXUAT AS NGAY,N'Trả Hàng' AS CHUCNANG,IDNHAP FROM TRAHOADONXUAT, KHACHHANG WHERE KHACHHANG.MAKH=TRAHOADONXUAT.MAKH  AND NGAYXUAT BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND KHACHHANG.MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }
        

        public  DataTable get1pt_dao(string sMahdx)
        {
            Provider pv = new Provider();

            string SQL = "SELECT MAPT ,MANV ,convert(varchar,ngaythu ,103)AS NGAYTHU,SOTIEN as TIENDATRA FROM PHIEUTHU WHERE  MADOITUONG='" + sMahdx + "'";
            return pv.getdata(SQL);
        }
        public  DataTable GETBANGGIA()
        {
            Provider pv = new Provider();
            string SQL = "SELECT * FROM BANGGIA WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }
        
        public  void THEMPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            Provider pv = new Provider();
            string IDNHAP = getIDNHAP();
            string SQL = "INSERT INTO PHIEUTHU (MAPT,MANV,NGAYTHU,SOTIEN,MAKHO,MADOITUONG,IDNHAP)"
            + " VALUES('" + dto.MaPhieuThu + "', '" + dto.NhanVien + "',convert(varchar,getDate(),101),'" + dto.SoTienDaTra + "','" + PublicVariable.MAKHO+ "','" + dto.MaDoituong + "','"+IDNHAP+"')";
            pv.executeNonQuery(SQL);

            SQL = "";
           // SQL = SQL + "\r\nGO\r\n UPDATE hoadonxuat set TIENDATRA=tiendatra+(select SUM(SOTIEN) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAHDX='" + dto.Mahoadonxuat + "'";
            //SQL = SQL + "\r\nGO\r\n update TRAHOADONNHAP SET TIENDATRA=tiendatra+(select SUM(SOTIEN) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "') WHERE MAHDN='" + dto.Mahoadonxuat + "'";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO+ " + dto.SoTienDaTra + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO- " + dto.SoTienDaTra + " WHERE MAKH='" + dto.MaDoituong + "' ";
            pv.executeNonQuery2(SQL);
        }
        public String getIDNHAP()
        {
            string IDTIME = "", IDDATE = "";
            string SQLNGAY = "SELECT convert(varchar,getDATE(),12) AS DATE,convert(varchar,getDATE(),14) AS TIMER ";
            Provider pv = new Provider();
            DataTable dtn = pv.getdata(SQLNGAY);
            IDTIME = dtn.Rows[0]["TIMER"].ToString();
            IDDATE = dtn.Rows[0]["DATE"].ToString();
            IDTIME = IDTIME.Substring(0, 2) + IDTIME.Substring(3, 2) + IDTIME.Substring(6, 2);
            return IDDATE + IDTIME;
        }
       
        public  void SUAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {

            Provider pv = new Provider();

            string S1 = "SELECT SOTIEN FROM PHIEUTHU WHERE MAPT='" + dto.MaPhieuThu + "'";
            DataTable DT=pv.getdata(S1);
            int SOTIENCU = Convert.ToInt32(DT.Rows[0][0].ToString());
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO - " + SOTIENCU + "+ " + dto.SoTienDaTra + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO + " + SOTIENCU + " - " + dto.SoTienDaTra + " WHERE MAKH='" + dto.MaDoituong + "' ";

            SQL = SQL + "\r\nGO\r\n  UPDATE  PHIEUTHU set SOTIEN='" + dto.SoTienDaTra + "' WHERE MAPT='" + dto.MaPhieuThu + "'";
            pv.executeNonQuery2(SQL);

        }
        public void XOAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {

            Provider pv = new Provider();

            string S1 = "SELECT SOTIEN FROM PHIEUTHU WHERE MAPT='" + dto.MaPhieuThu + "'";
            DataTable DT = pv.getdata(S1);
            int SOTIENCU = Convert.ToInt32(DT.Rows[0][0].ToString());
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO - " + SOTIENCU + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO - " + SOTIENCU + " WHERE MAKH='" + dto.MaDoituong + "' ";

            SQL = SQL + "\r\nGO\r\n  DELETE  PHIEUTHU WHERE MAPT='" + dto.MaPhieuThu + "'";
            pv.executeNonQuery2(SQL);

        }
        
    }
    class CONGNONCC
    {
       // public  Mysqlchange MSQL = new Mysqlchange();

        public DataTable GETALLcongno_ncc()
        {
            Provider pv = new Provider();
            string SQL = "SELECT MANCC, TENNCC, CONGNO FROM NHACUNGCAP WHERE MAKHO='"+PublicVariable.MAKHO+"'";
            return pv.getdata(SQL);
        }
        public DataTable Getall_phieuchi_Dao(string NGAYBD, string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT 'PC' AS TYPE,NHACUNGCAP.MANCC,TENNCC,MAPC,SOTIEN,NGAYCHI AS NGAY,IDNHAP FROM PHIEUCHI, NHACUNGCAP WHERE NHACUNGCAP.MANCC=PHIEUCHI.MADOITUONG AND NGAYCHI BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND NHACUNGCAP.MAKHO='"+PublicVariable.MAKHO+"'"
                + " UNION ALL  SELECT 'PT' AS TYPE,NHACUNGCAP.MANCC,TENNCC,MAPT AS MAPC,-SOTIEN AS SOTIEN,NGAYTHU AS NGAY,IDNHAP FROM PHIEUTHU, NHACUNGCAP WHERE NHACUNGCAP.MANCC=PHIEUTHU.MADOITUONG  AND NGAYTHU BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND NHACUNGCAP.MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }

        public DataTable Getall_hoadon_Dao(string NGAYBD, string NGAYKT)
        {
            Provider pv = new Provider();
            string SQL = "SELECT NHACUNGCAP.MANCC,TENNCC,MAPT AS MAHD,SOTIEN ,NGAYTHU AS NGAY,N'Nhận Tiền NCC' AS CHUCNANG,IDNHAP FROM PHIEUTHU, NHACUNGCAP WHERE NHACUNGCAP.MANCC=PHIEUTHU.MADOITUONG AND NGAYTHU BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "'  AND NHACUNGCAP.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT NHACUNGCAP.MANCC,TENNCC,MAPC  AS MAHD,-SOTIEN AS SOTIEN,NGAYCHI AS NGAY,N'Trả Tiền NCC' AS CHUCNANG,IDNHAP FROM PHIEUCHI, NHACUNGCAP WHERE NHACUNGCAP.MANCC=PHIEUCHI.MADOITUONG  AND NGAYCHI BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND NHACUNGCAP.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT NHACUNGCAP.MANCC,TENNCC,MAHDN  AS MAHD,TIENPHAITRA AS SOTIEN,NGAYNHAP AS NGAY,N'Mua Hàng' AS CHUCNANG,IDNHAP FROM HOADONNHAP, NHACUNGCAP WHERE NHACUNGCAP.MANCC=HOADONNHAP.MANCC  AND NGAYNHAP BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND NHACUNGCAP.MAKHO='" + PublicVariable.MAKHO + "'"
                + " UNION ALL SELECT NHACUNGCAP.MANCC,TENNCC,MAHDN  AS MAHD,-TIENPHAITRA AS SOTIEN,NGAYNHAP AS NGAY,N'Trả Hàng' AS CHUCNANG,IDNHAP FROM TRAHOADONNHAP, NHACUNGCAP WHERE NHACUNGCAP.MANCC=TRAHOADONNHAP.MANCC  AND NGAYNHAP BETWEEN '" + NGAYBD + "' and '" + NGAYKT + "' AND NHACUNGCAP.MAKHO='" + PublicVariable.MAKHO + "'";
            return pv.getdata(SQL);
        }
        public  DataTable GETALLHDN_DAO()
        {

            Provider pv = new Provider();
            string SQL = "SELECT MAHDN ,TENNCC,HOADONnhap.MANCC,TIENPHAITRA ,TIENDATRA, tienphaitra-tiendatra as CONLAI"
            +" FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc AND HOADONNHAP.MAKHO='"+PublicVariable.MAKHO+"' and hoadonnhap.tinhtrang='false' "
            +" group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc";
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
        public string GETcongno_NCC(string MANCC)
        {

            Provider pv = new Provider();
            string SQL = "SELECT CONGNO FROM NHACUNGCAP where MANCC='" + MANCC + "' ";
            DataTable dt = new DataTable();
            dt = pv.getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "0";
        }
        public string GETcongno_KH(string MAKH)
        {

            Provider pv = new Provider();
            string SQL = "SELECT CONGNO FROM KHACHHANG where MAKH='" + MAKH + "' ";
            DataTable dt = new DataTable();
            dt = pv.getdata(SQL);
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
            string SQL = "SELECT MAPC,MANV ,convert(varchar,NGAYCHI ,103)AS NGAYCHI,SOTIEN as TIENDATRA FROM PHIEUCHI WHERE MADOITUONG='" + sMahdn + "'";
            return pv.getdata(SQL);
        }
        
        public  void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();

            string S1 = "SELECT SOTIEN FROM PHIEUCHI WHERE MAPC='" + dto.MaPhieuChi + "'";
            DataTable DT = pv.getdata(S1);
            int SOTIENCU = Convert.ToInt32(DT.Rows[0][0].ToString());
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO + " + SOTIENCU + "- " + dto.SoTienDaTra + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO - " + SOTIENCU + "+ " + dto.SoTienDaTra + " WHERE MAKH='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n  UPDATE  PHIEUCHI set MANV='" + dto.NhanVien + "',SOTIEN='" + dto.SoTienDaTra + "' WHERE MAPC='" + dto.MaPhieuChi + "' ";
            pv.executeNonQuery2(SQL);
        }

        public  void THEMPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            Provider pv = new Provider();
            string IDNHAP = getIDNHAP();
            string SQL = "INSERT INTO PHIEUCHI (MAPC,MANV,NGAYCHI,SOTIEN,MAKHO,MADOITUONG,IDNHAP)   VALUES('" + dto.MaPhieuChi + "', '" + dto.NhanVien + "',convert(varchar,getDate(),101),'" + dto.SoTienDaTra + "','" + PublicVariable.MAKHO + "','" + dto.MaDoituong + "','" + IDNHAP + "')";
            pv.executeNonQuery(SQL);
            SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO- " + dto.SoTienDaTra + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO+ " + dto.SoTienDaTra + " WHERE MAKH='" + dto.MaDoituong + "' ";
            pv.executeNonQuery2(SQL);

        }
        public String getIDNHAP()
        {
            string IDTIME = "", IDDATE = "";
            string SQLNGAY = "SELECT convert(varchar,getDATE(),12) AS DATE,convert(varchar,getDATE(),14) AS TIMER ";
            Provider pv = new Provider();

            DataTable dtn = pv.getdata(SQLNGAY);
            IDTIME = dtn.Rows[0]["TIMER"].ToString();
            IDDATE = dtn.Rows[0]["DATE"].ToString();
            IDTIME = IDTIME.Substring(0, 2) + IDTIME.Substring(3, 2) + IDTIME.Substring(6, 2);
            return IDDATE + IDTIME;
        }
        public void XOAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {

            Provider pv = new Provider();

            string S1 = "SELECT SOTIEN FROM PHIEUCHI WHERE MAPC='" + dto.MaPhieuChi + "'";
            DataTable DT = pv.getdata(S1);
            int SOTIENCU = Convert.ToInt32(DT.Rows[0][0].ToString());
            string SQL = "";
            SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET CONGNO=CONGNO- " + dto.SoTienDaTra + " WHERE MANCC='" + dto.MaDoituong + "' ";
            SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET CONGNO=CONGNO+ " + dto.SoTienDaTra + " WHERE MAKH='" + dto.MaDoituong + "' ";

            SQL = SQL + "\r\nGO\r\n  DELETE  PHIEUCHI WHERE MAPC='" + dto.MaPhieuChi + "'";
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
