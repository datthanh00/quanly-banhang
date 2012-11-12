using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Class_ManhCuong
{
    class tudienma :Provider
    {

        SqlConnection sqlKetNoi = get_Connect();

        int Maxa = 1;
        public string sTuDongDienMaHoaDonNhap(string sMahdn)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAHDN from HOADONNHAP", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdn = sqldatareader.GetValue(0).ToString().Trim();



                    int iLaySoDuoi = int.Parse(sMahdn.ToString().Trim().Substring(5,5));
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
            sqlKetNoi.Close();
        }
        public string sTuDongDienMaHoaDonXuat(string sMahdx)
        {
            int iMaxSoSanh = 1;
            //sqlKetNoi.Open();
            SqlCommand sqlcmdLenhThucThi = new SqlCommand("Select MAHDX from HOADONXUAT", sqlKetNoi);

            //sqlcmdLenhThucThi = new SqlCommand("Select MAKH from KHACHHANG", sqlKetNoi);
            SqlDataReader sqldatareader = sqlcmdLenhThucThi.ExecuteReader();
            while (sqldatareader.Read())
            {
                for (int ii = 0; ii < sqldatareader.GetValue(0).ToString().Length; ii++)
                {
                    sMahdx = sqldatareader.GetValue(0).ToString().Trim();



                    int iLaySoDuoi = int.Parse(sMahdx.ToString().Trim().Substring(5,5));
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
            sqlKetNoi.Close();
        }
    }
}
