using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class ketnoi:Provider
    {
        
        //public SqlConnection sqlcondatabase(SqlConnection sqlKetNoi)
        //{

        SqlConnection sqlKetNoi = get_Connect();
          
        //    return sqlKetNoi;
        //}
        //-----------------------//
        int Maxa = 1;









        public string sTuDongDienMapc(string sMaPC)
        {
            int iMaxSoSanh = 1;
           // sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAPC from PHIEUCHI", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaPC = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        public string sTuDongDienMapt(string sMaPT)
        {
            int iMaxSoSanh = 1;
           // sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAPT from PHIEUTHU", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaPT = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }






        public string sTuDongDienMaKH(string sMaKH)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG",sqlKetNoi);
            
            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                     sMaKH = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        //----------------------------------------------------------////
        
        public string sTuDongDienMaKho(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAKHO from KHO", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        ////--------------------load ma tu dong DVT--------------------------
        public string sTuDongDienMaDVT(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MADVT from DONVITINH", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        //--------------load ma MH----------
        public string sTuDongDienMaMH(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAMH from MATHANG", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        /////------------load thue---------------------
        public string sTuDongDienMaThue(string sMaDVT)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MATH from THUE", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaDVT = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaKV(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAKV from KHUVUC", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        //----------------------load ma nhan vien-------------------
      
        ///---------------------------------load ma tu dong khhu vuc---------------

        public string sTuDongDienMaNV(string sMaNV)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MANV from NHANVIEN", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNV = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        //-----------------------------load ma tu dong quan ly----------------
        public string sTuDongDienMaQL(string sMaNV)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAQL from QUANLY", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNV = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }

//----------------------load ma tu dong Bo Phan---------------
        public string sTuDongDienMaBP(string sMaBP)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MABP from BOPHAN", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaBP = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }

        //------------------load ma tu dong NHOM HÀng-----------------

        public string sTuDongDienMaNhomHang(string sMaNH)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MANH from NHOMHANG", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaNH = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        //-------------------load ma nha Cung cap-----------------------//
       
        public string sTuDongDienMaNCC(string sMaKHO)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MANCC from NHACUNGCAP", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMaKHO = sqldatareader.GetValue(0).ToString().Trim();



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
            sqldatareader.Close();

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
            sqlKetNoi.Close();
        }
        ///
        //internal string matudong(string p, SqlCommand sqlCmd, SqlConnection sqlCon)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
