using System;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class ketnoi:Provider
    {
        public Mysqlchange MSQL = new Mysqlchange();
       
        int Maxa = 1;

        public string sTuDongDienMapc(string sMaPC)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAPC from PHIEUCHI", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaPC = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaPC.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        public string sTuDongDienMapt(string sMaPT)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAPT from PHIEUTHU", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaPT = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaPT.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }

        public string sTuDongDienMaKH(string sMaKH)
        {
            MSQL.sqlKetNoi = get_Connect();
            int iMaxSoSanh = 1;
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAKH from KHACHHANG",MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKH = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaKH.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        //----------------------------------------------------------////
        
        public string sTuDongDienMaKho(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAKHO from KHO", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaKHO.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        ////--------------------load ma tu dong DVT--------------------------
        public string sTuDongDienMaDVT(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MADVT from DONVITINH", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaDVT.ToString().Trim().Substring(3, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        //--------------load ma MH----------
        public string sTuDongDienMaMH(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAMH from MATHANG", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaDVT.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MATH from THUE", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaDVT.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAKV from KHUVUC", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaKHO.ToString().Trim().Substring(4, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MANV from NHANVIEN", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNV = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaNV.ToString().Trim().Substring(4, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        //-----------------------------load ma tu dong quan ly----------------
        public string sTuDongDienMaQL(string sMaNV)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAQL from QUANLY", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNV = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaNV.ToString().Trim().Substring(4, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MABP from BOPHAN", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaBP = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaBP.ToString().Trim().Substring(4, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MANH from NHOMHANG", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNH = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaNH.ToString().Trim().Substring(2, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MANCC from NHACUNGCAP", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMaKHO.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }

        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAHDX from HOADONXUAT", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdx = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMahdx.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;

                    }


                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        public string sTuDongDienMatraHoaDonXuat(string sMahdx)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAHDX from traHOADONXUAT", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdx = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMahdx.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;

                    }


                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
        public string sTuDongDienMaHoaDonNhap(string sMahdn)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAHDN from HOADONNHAP", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdn = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMahdn.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }

        public string sTuDongDientraMaHoaDonNhap(string sMahdn)
        {
            int iMaxSoSanh = 1;
            MSQL.sqlKetNoi = get_Connect();
            MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("Select MAHDN from traHOADONNHAP", MSQL.sqlKetNoi);
            MSQL.sqldatareader = MSQL.sqlcmdLenhThucThi.ExecuteReader();
            while (MSQL.sqldatareader.Read())
            {
                for (int ii = 0; ii < MSQL.sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdn = MSQL.sqldatareader.GetValue(0).ToString().Trim();
                    int iLaySoDuoi = int.Parse(sMahdn.ToString().Trim().Substring(5, 5));
                    if (iMaxSoSanh == iLaySoDuoi)
                    {
                        iMaxSoSanh++;
                    }
                    if (iMaxSoSanh != iLaySoDuoi)
                    {
                        Maxa = iMaxSoSanh;
                    }
                }
            }
            MSQL.sqldatareader.Close();

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
            MSQL.sqlKetNoi.Close();
        }
    }
}
