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
            String SQL = "Select MAX(MAPC) from PHIEUCHI";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu+1;
            


            if (Maxa < 10)
            {
                sMaPC = string.Concat("PC", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaPC = string.Concat("PC", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaPC = string.Concat("PC", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaPC = string.Concat("PC", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaPC = string.Concat("PT", Maxa);
            }
            return sMaPC;
            
        }
        public string sTuDongDienMapt(string sMaPT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(MAPT) from PHIEUTHU";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaPT = string.Concat("PT", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaPT = string.Concat("PT", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaPT = string.Concat("PT", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaPT = string.Concat("PT", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaPT = string.Concat("PT", Maxa);
            }
            return sMaPT;
            
        }

        public string sTuDongDienMaKH(string sMaKH)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAKH) from KHACHHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMaKH = string.Concat("KH", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKH = string.Concat("KH", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKH = string.Concat("KH", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKH = string.Concat("KH", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKH = string.Concat("KH", Maxa);
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
            String SQL = "Select MAX(MADVT) from DONVITINH";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(3, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaDVT = string.Concat("DVT", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat("DVT", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat("DVT", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat("DVT", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat("DVT", Maxa);
            }
            
            return sMaDVT;
           
        }
        //--------------load ma MH----------
        public string sTuDongDienMaMH(string sMaDVT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(MAMH) from MATHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMaDVT = string.Concat("MH", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat("MH", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat("MH", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat("MH", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat("MH", Maxa);
            }
            
            return sMaDVT;
          
        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaDVT)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(MATH) from THUE";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaDVT = string.Concat("TH", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaDVT = string.Concat("TH", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaDVT = string.Concat("TH", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaDVT = string.Concat("TH", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaDVT = string.Concat("TH", Maxa);
            }
            
            return sMaDVT;
            
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKHO)
        {
            int maxmaphieu = 0;
            String SQL = "Select MAX(MAKV) from KHUVUC";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(4, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaKHO = string.Concat("MAKV", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKHO = string.Concat("MAKV", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKHO = string.Concat("MAKV", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKHO = string.Concat("MAKV", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKHO = string.Concat("MAKV", Maxa);
            }
            
            return sMaKHO;
            
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MANV) from NHANVIEN";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(4, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMaNV = string.Concat("MANV", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNV = string.Concat("MANV", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNV = string.Concat("MANV", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNV = string.Concat("MANV", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNV = string.Concat("MANV", Maxa);
            }
            
            return sMaNV;
           
        }
        //-----------------------------load ma tu dong quan ly----------------
        public string sTuDongDienMaQL(string sMaNV)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAQL) from QUANLY";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(4, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaNV = string.Concat("MAQL", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNV = string.Concat("MAQL", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNV = string.Concat("MAQL", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNV = string.Concat("MAQL", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNV = string.Concat("MAQL", Maxa);
            }
            
            return sMaNV;
           
        }

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MABP) from BOPHAN";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(4, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaBP = string.Concat("MABP", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaBP = string.Concat("MABP", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaBP = string.Concat("MABP", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaBP = string.Concat("MABP", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaBP = string.Concat("MABP", Maxa);
            }
            
            return sMaBP;
           
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {


            int maxmaphieu = 0;
            String SQL = "Select MAX(MANH) from NHOMHANG";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(2, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaNH = string.Concat("NH", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaNH = string.Concat("NH", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaNH = string.Concat("NH", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaNH = string.Concat("NH", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaNH = string.Concat("NH", Maxa);
            }
            
            return sMaNH;
           
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaKHO)
        {


            int maxmaphieu = 0;
            String SQL = "Select MAX(MANCC) from NHACUNGCAP";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(4, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMaKHO = string.Concat("MANCC", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMaKHO = string.Concat("MANCC", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMaKHO = string.Concat("MANCC", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMaKHO = string.Concat("MANCC", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMaKHO = string.Concat("MANCC", Maxa);
            }
            
            return sMaKHO;
           
        }

        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAHDX) from HOADONXUAT";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(5, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMahdx = string.Concat("MAHDX", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdx = string.Concat("MAHDX", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdx = string.Concat("MAHDX", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdx = string.Concat("MAHDX", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdx = string.Concat("MAHDX", Maxa);
            }
            
            return sMahdx;
           
        }
        public string sTuDongDienMatraHoaDonXuat(string sMahdx)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAHDX) from traHOADONXUAT";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(6, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMahdx = string.Concat("MATHDX", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdx = string.Concat("MATHDX", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdx = string.Concat("MATHDX", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdx = string.Concat("MATHDX", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdx = string.Concat("MATHDX", Maxa);
            }
            
            return sMahdx;
            
        }
        public string sTuDongDienMaHoaDonNhap(string sMahdn)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAHDN) from HOADONNHAP";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                string S = dt.Rows[0][0].ToString();
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(5, 5));
            }
            Maxa = maxmaphieu + 1;

            if (Maxa < 10)
            {
                sMahdn = string.Concat("MAHDN", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdn = string.Concat("MAHDN", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdn = string.Concat("MAHDN", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdn = string.Concat("MAHDN", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdn = string.Concat("MAHDN", Maxa);
            }
            
            return sMahdn;
            
        }

        public string sTuDongDienMatraHoaDonNhap(string sMahdn)
        {

            int maxmaphieu = 0;
            String SQL = "Select MAX(MAHDN) from traHOADONNHAP";
            DataTable dt = getdata(SQL);
            if (dt.Rows[0][0].ToString() != "")
            {
                maxmaphieu = int.Parse(dt.Rows[0][0].ToString().Substring(6, 5));
            }
            Maxa = maxmaphieu + 1;


            if (Maxa < 10)
            {
                sMahdn = string.Concat("MATHDN", "0000", Maxa);
            }
            if (Maxa >= 10)
            {
                sMahdn = string.Concat("MATHDN", "000", Maxa);
            }
            if (Maxa >= 100)
            {
                sMahdn = string.Concat("MATHDN", "00", Maxa);
            }
            if (Maxa >= 1000)
            {
                sMahdn = string.Concat("MATHDN", "0", Maxa);
            }
            if (Maxa >= 10000)
            {
                sMahdn = string.Concat("MATHDN", Maxa);
            }
            
            return sMahdn;
            
        }


    }
}
