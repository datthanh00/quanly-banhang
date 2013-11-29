using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Timers;

namespace WindowsFormsApplication1
{
    class ketnoi:Provider
    {


    
        public string sTuDongDienMapc(string sMaPC)
        {
            string HEAD = "PC", MAHD = "MAPC", TABLE = "PHIEUCHI";
            int LENHEAD = HEAD.Length+2;
            string SQL = "";
      
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaPC = DT.Rows[0][0].ToString();

            return sMaPC;
        }

        public string sTuDongDienMapc()
        {
            string HEAD = "PC", MAHD = "MAPC", TABLE = "PHIEUCHI";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
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
        public string sTuDongDienMapt(string sMaPT)
        {
            string HEAD = "PT", MAHD = "MAPT", TABLE = "PHIEUTHU";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaPT = DT.Rows[0][0].ToString();
            return sMaPT;
            
        }
        public string sTuDongDienMapt()
        {
            string HEAD = "PT", MAHD = "MAPT", TABLE = "PHIEUTHU";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }

        public string sTuDongDienMaKH(string sMaKH)
        {
            string HEAD = "KH", MAHD = "MAKH", TABLE = "KHACHHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"' )+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKH = DT.Rows[0][0].ToString();
            return sMaKH;
        }

        public string sTuDongDienMaKH()
        {
            string HEAD = "KH", MAHD = "MAKH", TABLE = "KHACHHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"' )+1)  AS T1) AS T2";
            return SQL;
        }
        //----------------------------------------------------------////
        
        public string sTuDongDienMaKho(string sMaKHO)
        {
            string HEAD = "KHO", MAHD = "MAKHO", TABLE = "KHO";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKHO = DT.Rows[0][0].ToString();
            return sMaKHO;
        }
        public string sTuDongDienMaKho()
        {
            string HEAD = "KHO", MAHD = "MAKHO", TABLE = "KHO";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        ////--------------------load ma tu dong DVT--------------------------
        public string sTuDongDienMaDVT(string sMaDVT)
        {
            string HEAD = "DVT", MAHD = "MADVT", TABLE = "DONVITINH";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaDVT = DT.Rows[0][0].ToString();
            return sMaDVT;
        }
        public string sTuDongDienMaDVT()
        {
            string HEAD = "DVT", MAHD = "MADVT", TABLE = "DONVITINH";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        //--------------load ma MH----------
        
        public string sTuDongDienMaBG(string sMaBG)
        {
            string HEAD = "BG", MAHD = "MABG", TABLE = "BANGGIA";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaBG = DT.Rows[0][0].ToString();
            return sMaBG;
        }
        public string sTuDongDienMaBG()
        {
            string HEAD = "BG", MAHD = "MABG", TABLE = "BANGGIA";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaTH)
        {
            string HEAD = "TH", MAHD = "MATH", TABLE = "THUE";
            int LENHEAD = HEAD.Length ;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaTH = DT.Rows[0][0].ToString();
            return sMaTH;
        }
        public string sTuDongDienMaThue()
        {
            string HEAD = "TH", MAHD = "MATH", TABLE = "THUE";
            int LENHEAD = HEAD.Length ;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKV)
        {
            string HEAD = "KV", MAHD = "MAKV", TABLE = "KHUVUC";
            int LENHEAD = HEAD.Length ;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKV = DT.Rows[0][0].ToString();
            return sMaKV;
        }
        public string sTuDongDienMaKV()
        {
            string HEAD = "KV", MAHD = "MAKV", TABLE = "KHUVUC";
            int LENHEAD = HEAD.Length ;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {
            string HEAD = "NV", MAHD = "MANV", TABLE = "NHANVIEN";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNV = DT.Rows[0][0].ToString();
            return sMaNV;
        }
        public string sTuDongDienMaNV()
        {
            string HEAD = "NV", MAHD = "MANV", TABLE = "NHANVIEN";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        //-----------------------------load ma tu dong quan ly----------------
     

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {
            string HEAD = "BP", MAHD = "MABP", TABLE = "BOPHAN";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaBP = DT.Rows[0][0].ToString();
            return sMaBP;
        }

        public string sTuDongDienMaBP()
        {
            string HEAD = "BP", MAHD = "MABP", TABLE = "BOPHAN";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {
            string HEAD = "NH", MAHD = "MANH", TABLE = "NHOMHANG";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNH = DT.Rows[0][0].ToString();
            return sMaNH;
        }

        public string sTuDongDienMaNhomHang()
        {
            string HEAD = "NH", MAHD = "MANH", TABLE = "NHOMHANG";
            int LENHEAD = HEAD.Length;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + "1' ELSE T1 END FROM (SELECT '" + HEAD + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            return SQL;
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaNCC)
        {
            string HEAD = "NCC", MAHD = "MANCC", TABLE = "NHACUNGCAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNCC = DT.Rows[0][0].ToString();
            return sMaNCC;
        }

        public string sTuDongDienMaNCC()
        {
            string HEAD = "NCC", MAHD = "MANCC", TABLE = "NHACUNGCAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string sTuDongDienMaMH(string sMaMH)
        {
            string HEAD = "MH", MAHD = "MAMH", TABLE = "MATHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaMH = DT.Rows[0][0].ToString();
            return sMaMH;
        }
        public string sTuDongDienMaMH()
        {
            string HEAD = "MH", MAHD = "MAMH", TABLE = "MATHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {
            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            return sMahdx;
        }
        public string sTuDongDienMaHoaDonXuat()
        {
            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }

        public string sTuDongDienMaHoaDonXuatKHAC(string sMahdx)
        {
            string HEAD = "HDXK", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            return sMahdx;
        }

        public string sTuDongDienMaHoaDonXuatKHAC()
        {
            string HEAD = "HDXK", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string sTuDongDienMaHoaDondatxuat(string sMahdx)
        {
            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONDATXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            return sMahdx;
        }
        public string sTuDongDienMaHoaDondatnhap(string sMahdx)
        {
            string HEAD = "HDN", MAHD = "MAHDN", TABLE = "HOADONDATNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            return sMahdx;
        }
        public string sTuDongDienMaHoaDonXuattam()
        {
            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }

       
        public string sTuDongDienMatraHoaDonXuat(string sMahdx)
        {
            string HEAD = "THDX", MAHD = "MAHDX", TABLE = "TRAHOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            return sMahdx;
        }
        public string sTuDongDienMatraHoaDonXuat()
        {
            string HEAD = "THDX", MAHD = "MAHDX", TABLE = "TRAHOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string MAXID_TONKHO()
        {
            String SQL = "Select MAX(ID) from TONKHO";
            DataTable dt = getdata(SQL);
            int MAXID = 0;
            if (dt.Rows[0][0].ToString() != "")
            {
                MAXID = int.Parse(dt.Rows[0][0].ToString());
            }
            return (MAXID + 1).ToString();
        }
        public string sTuDongDienMaHoaDonNhap(string sMahdn)
        {
            string HEAD = "HDN", MAHD = "MAHDN", TABLE = "HOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();
            return sMahdn;
        }
        public string sTuDongDienMaHoaDonNhap()
        {
            string HEAD = "HDN", MAHD = "MAHDN", TABLE = "HOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string sTuDongDienMaHoaDonNhapKHAC(string sMahdn)
        {
            string HEAD = "HDNK", MAHD = "MAHDN", TABLE = "HOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();
            return sMahdn;
        }
        public string sTuDongDienMaHoaDonNhapKHAC()
        {
            string HEAD = "HDNK", MAHD = "MAHDN", TABLE = "HOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
        public string sTuDongDienMatraHoaDonNhap(string sMahdn)
        {
            string HEAD = "THDN", MAHD = "MAHDN", TABLE = "TRAHOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='"+PublicVariable.MAKHO+"')+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();
            return sMahdn;
        }
        public string sTuDongDienMatraHoaDonNhap()
        {
            string HEAD = "THDN", MAHD = "MAHDN", TABLE = "TRAHOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "1' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + " WHERE MAKHO='" + PublicVariable.MAKHO + "')+1)  AS T1) AS T2";
            return SQL;
        }
    }
}
