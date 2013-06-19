using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class ketnoi:Provider
    {
        public MySqlDataAdapter da;
        //public Mysqlchange MSQL = new Mysqlchange();
        int Maxa = 1;

        public string sTuDongDienMapc(string sMaPC)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAPC,7,len(MAPC)-6))) from PHIEUCHI";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "PC" + subso;
            


            if (Maxa < 10)
            {
                sMaPC = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaPC = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaPC = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaPC = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaPC = string.Concat(subMAHD, Maxa);
            }
            return sMaPC;
            
        }
        public string sTuDongDienMapt(string sMaPT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAPT,7,len(MAPT)-6))) from PHIEUTHU";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "PT" + subso;

            if (Maxa < 10)
            {
                sMaPT = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaPT = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaPT = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaPT = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaPT = string.Concat(subMAHD, Maxa);
            }
            return sMaPT;
            
        }

        public string sTuDongDienMaKH(string sMaKH)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAKH,7,len(MAKH)-6))) from KHACHHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "KH" + subso;


            if (Maxa < 10)
            {
                sMaKH = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKH = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKH = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKH = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKH = string.Concat(subMAHD, Maxa);
            }
            
            return sMaKH;
           
        }
        //----------------------------------------------------------////
        
        public string sTuDongDienMaKho(string sMaKHO)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAKHO) from KHO";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(5, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMaKHO = string.Concat("MAKHO", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKHO = string.Concat("MAKHO", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKHO = string.Concat("MAKHO", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKHO = string.Concat("MAKHO", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKHO= string.Concat("MAKHO", Maxa);
            }
            
            return sMaKHO;
            
        }
        ////--------------------load ma tu dong DVT--------------------------
        public string sTuDongDienMaDVT(string sMaDVT)
        {


            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MADVT,8,len(MADVT)-7))) from DONVITINH";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "DVT" + subso;


            if (Maxa < 10)
            {
                sMaDVT = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat(subMAHD, Maxa);
            }
            
            return sMaDVT;
           
        }
        //--------------load ma MH----------
        public string sTuDongDienMaMH(string sMaDVT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAMH,7,len(MAMH)-6))) from MATHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MH" + subso;


            if (Maxa < 10)
            {
                sMaDVT = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat(subMAHD, Maxa);
            }
            
            return sMaDVT;
          
        }
        public string sTuDongDienMaBG(string sMaDVT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MABG,7,len(MABG)-6))) from BANGGIA";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "BG" + subso;


            if (Maxa < 10)
            {
                sMaDVT = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat(subMAHD, Maxa);
            }

            return sMaDVT;

        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaDVT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MATH,7,len(MATH)-6))) from THUE";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "TH" + subso;

            if (Maxa < 10)
            {
                sMaDVT = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat(subMAHD, Maxa);
            }
            
            return sMaDVT;
            
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKHO)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAKV,9,len(MAKV)-8))) from KHUVUC";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MAKV" + subso;
            if (Maxa < 10)
            {
                sMaKHO = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKHO = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKHO = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKHO = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKHO = string.Concat(subMAHD, Maxa);
            }
            
            return sMaKHO;
            
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MANV,9,len(MANV)-8))) from NHANVIEN";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MANV" + subso;


            if (Maxa < 10)
            {
                sMaNV = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNV = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNV = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNV = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNV = string.Concat(subMAHD, Maxa);
            }
            
            return sMaNV;
           
        }
        //-----------------------------load ma tu dong quan ly----------------
        public string sTuDongDienMaQL(string sMaNV)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAQL,9,len(MAQL)-8))) from QUANLY";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MAQL" + subso;

            if (Maxa < 10)
            {
                sMaNV = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNV = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNV = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNV = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNV = string.Concat(subMAHD, Maxa);
            }
            
            return sMaNV;
           
        }

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MABP,9,len(MABP)-8))) from BOPHAN";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MABP" + subso;

            if (Maxa < 10)
            {
                sMaBP = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaBP = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaBP = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaBP = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaBP = string.Concat(subMAHD, Maxa);
            }
            
            return sMaBP;
           
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {


            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MANH,7,len(MANH)-6))) from NHOMHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "NH" + subso;

            if (Maxa < 10)
            {
                sMaNH = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNH = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNH = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNH = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNH = string.Concat(subMAHD, Maxa);
            }
            
            return sMaNH;
           
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaKHO)
        {


            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MANCC,10,len(MANCC)-9))) from NHACUNGCAP";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MANCC" + subso;

            if (Maxa < 10)
            {
                sMaKHO = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKHO = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKHO = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKHO = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKHO = string.Concat(subMAHD, Maxa);
            }
            
            return sMaKHO;
           
        }

        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAHDX,10,len(MAHDX)-9))) from HOADONXUAT";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MAHDX" + subso;

            if (Maxa < 10)
            {
                sMahdx = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdx = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdx = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdx = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdx = string.Concat(subMAHD, Maxa);
            }
            
            return sMahdx;
           
        }
        public string sTuDongDienMaHoaDonXuattam(string sMahdx)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAHDX,10,len(MAHDX)-9))) from CHITIETHDXTAM";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MAHDX" + subso;

            if (Maxa < 10)
            {
                sMahdx = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdx = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdx = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdx = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdx = string.Concat(subMAHD, Maxa);
            }

            return sMahdx;

        }
       
        public string sTuDongDienMatraHoaDonXuat(string sMahdx)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAHDX,11,len(MAHDX)-10))) from traHOADONXUAT";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MATHDX" + subso;
            if (Maxa < 10)
            {
                sMahdx = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdx = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdx = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdx = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdx = string.Concat(subMAHD, Maxa);
            }
            
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

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAHDN,10,len(MAHDN)-9))) from HOADONNHAP";
            DataTable dt = getdata(SQL);

            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }
            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;
            string subMAHD = "MAHDN" + subso;
            if (Maxa < 10)
            {
                sMahdn = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdn = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdn = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdn = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdn = string.Concat(subMAHD, Maxa);
            }
            
            return sMahdn;
            
        }

        public string sTuDongDienMatraHoaDonNhap(string sMahdn)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(convert(int,SUBSTRING(MAHDN,11,len(MAHDN)-10))) from traHOADONNHAP";
            DataTable dt = getdata(SQL);

            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString());
            }
            Maxa = maxmaphieu + 1;

            string subso = int.Parse(PublicVariable.MAKHO.Substring(5, 5)).ToString();
            if (subso.Length < 2)
            {
                subso = "0" + subso;
            }

            string subso2 = int.Parse(PublicVariable.MANV.Substring(4, 5)).ToString();
            if (subso2.Length < 2)
            {
                subso2 = "0" + subso2;
            }
            subso = subso + subso2;

            string subMAHD = "MATHDN" + subso;

            if (Maxa < 10)
            {
                sMahdn = string.Concat(subMAHD, "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdn = string.Concat(subMAHD, "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdn = string.Concat(subMAHD, "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdn = string.Concat(subMAHD, "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdn = string.Concat(subMAHD, Maxa);
            }
            
            return sMahdn;
            
        }


    }
}
