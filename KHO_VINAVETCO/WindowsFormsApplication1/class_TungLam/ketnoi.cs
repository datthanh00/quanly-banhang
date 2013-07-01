using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Timers;

namespace WindowsFormsApplication1
{
    class ketnoi:Provider
    {
        public MySqlDataAdapter da;
        //public Mysqlchange MSQL = new Mysqlchange();
        int Maxa = 1;

        public string sTuDongDienMapc(string sMaPC)
        {
            string HEAD = "PC", MAHD = "MAPC", TABLE = "PHIEUCHI";
            int LENHEAD = HEAD.Length+2;
            string SQL = "";
      
            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaPC = DT.Rows[0][0].ToString();

            return sMaPC;
        }
        public string sTuDongDienMapt(string sMaPT)
        {
            string HEAD = "PT", MAHD = "MAPT", TABLE = "PHIEUTHU";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaPT = DT.Rows[0][0].ToString();

            return sMaPT;
            
        }

        public string sTuDongDienMaKH(string sMaKH)
        {

            string HEAD = "KH", MAHD = "MAKH", TABLE = "KHACHHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKH = DT.Rows[0][0].ToString();
            
            return sMaKH;
           
        }
        //----------------------------------------------------------////
        
        public string sTuDongDienMaKho(string sMaKHO)
        {

            string HEAD = "", MAHD = "MAKHO", TABLE = "KHO";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '1' ELSE T1 END FROM (SELECT  convert(VARCHAR,(SELECT MAX(convert(int," + MAHD + ")) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKHO = DT.Rows[0][0].ToString();

            return sMaKHO;
            
        }
        ////--------------------load ma tu dong DVT--------------------------
        public string sTuDongDienMaDVT(string sMaDVT)
        {
            string HEAD = "DVT", MAHD = "MADVT", TABLE = "DONVITINH";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaDVT = DT.Rows[0][0].ToString();
            
            return sMaDVT;
           
        }
        //--------------load ma MH----------
        public string sTuDongDienMaMH(string sMaMH)
        {
            string HEAD = "MH", MAHD = "MAMH", TABLE = "MATHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaMH = DT.Rows[0][0].ToString();
            
            return sMaMH;
          
        }
        public string sTuDongDienMaBG(string sMaBG)
        {
            string HEAD = "BG", MAHD = "MABG", TABLE = "BANGGIA";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaBG = DT.Rows[0][0].ToString();
            return sMaBG;

        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaTH)
        {
            string HEAD = "TH", MAHD = "MATH", TABLE = "THUE";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaTH = DT.Rows[0][0].ToString();
            
            return sMaTH;
            
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKV)
        {
            string HEAD = "KV", MAHD = "MAKV", TABLE = "KHUVUC";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaKV = DT.Rows[0][0].ToString();
            
            return sMaKV;
            
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {

            string HEAD = "NV", MAHD = "MANV", TABLE = "NHANVIEN";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNV = DT.Rows[0][0].ToString();
            
            return sMaNV;
           
        }
        //-----------------------------load ma tu dong quan ly----------------
     

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {

            string HEAD = "BP", MAHD = "MABP", TABLE = "BOPHAN";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaBP = DT.Rows[0][0].ToString();
            
            return sMaBP;
           
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {
            string HEAD = "NH", MAHD = "MANH", TABLE = "NHOMHANG";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNH = DT.Rows[0][0].ToString();
            
            return sMaNH;
           
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaNCC)
        {
            string HEAD = "NCC", MAHD = "MANCC", TABLE = "NHACUNGCAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMaNCC = DT.Rows[0][0].ToString();
            
            return sMaNCC;
           
        }

        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {

            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            
            return sMahdx;
           
        }

        public string sTuDongDienMaHoaDonXuatKHAC(string sMahdx)
        {

            string HEAD = "HDXK", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();

            return sMahdx;

        }
        public string sTuDongDienMaHoaDonXuattam(string sMahdx)
        {

            string HEAD = "HDX", MAHD = "MAHDX", TABLE = "HOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();

            return sMahdx;

        }
       
        public string sTuDongDienMatraHoaDonXuat(string sMahdx)
        {

            string HEAD = "THDX", MAHD = "MAHDX", TABLE = "TRAHOADONXUAT";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdx = DT.Rows[0][0].ToString();
            
            return sMahdx;
            
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

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();

            
            return sMahdn;
            
        }
        public string sTuDongDienMaHoaDonNhapKHAC(string sMahdn)
        {

            string HEAD = "HDNK", MAHD = "MAHDN", TABLE = "HOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();
            return sMahdn;

        }
        public string sTuDongDienMatraHoaDonNhap(string sMahdn)
        {

            string HEAD = "THDN", MAHD = "MAHDN", TABLE = "TRAHOADONNHAP";
            int LENHEAD = HEAD.Length + 2;
            string SQL = "";

            SQL = "SELECT CASE WHEN T1 IS NULL THEN '" + HEAD + PublicVariable.CODEKHO + "01' ELSE T1 END FROM (SELECT '" + HEAD + PublicVariable.CODEKHO + "' + convert(VARCHAR,(SELECT MAX(convert(int,SUBSTRING(" + MAHD + "," + (LENHEAD + 1).ToString() + ",len(" + MAHD + ")-" + LENHEAD.ToString() + "))) FROM " + TABLE + ")+1)  AS T1) AS T2";
            DataTable DT = getdata(SQL);
            sMahdn = DT.Rows[0][0].ToString();
            
            return sMahdn;
            
        }

        public void ACTIVEINSERT(string TYPE)
        {
           string  SQL = "";
           SQL = "SELECT ACTIVE FROM MAHDARRAY WHERE TYPE='"+TYPE+"' AND MAKHO='" + PublicVariable.MAKHO + "'";

           DataTable DTstart = getdata(SQL);
           if (DTstart.Rows.Count > 0)
           {
               SQL = "UPDATE MAHDARRAY SET ACTIVE =1 WHERE TYPE='" + TYPE + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
           }
           else
           {
               SQL = "INSERT INTO MAHDARRAY ([TYPE],[MAKHO],[ACTIVE]) VALUES ('" + TYPE + "','" + PublicVariable.MAKHO + "',1)";
           }
          
           executeNonQuery(SQL);
        }

        public void UNACTIVEINSERT(string TYPE)
        {
            string SQLstart = "UPDATE MAHDARRAY SET ACTIVE =0 WHERE TYPE='" + TYPE + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            executeNonQuery(SQLstart);
        }

        public void dealTimer()
        {
            System.Threading.Thread.Sleep(2000);
        }


    }
}
