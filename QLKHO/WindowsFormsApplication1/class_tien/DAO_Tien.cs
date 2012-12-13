using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    /*
    class DAO_Tien
    {
    }
   
    class CHITIETNHCC_HDN:Provider
    {
        public static Mysqlchange MSQL = new Mysqlchange();
        public static DataTable TTNCC_DAO(string sMancc)
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("HOADONNHAP_CNO", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@mancc", sMancc);
                DataTable dtttncc = new DataTable();
                dtttncc.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dtttncc;
            }


            //String SQL = "select * from NHANVIEN where USERNAME='" + dto.TENDANGNHAP + "'";
           // return getdata(SQL);
        }
        public static ArrayList RDTTNCC_DAO()
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("THONGTIN_HOADONNHAP_CNO", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                ArrayList AR = new ArrayList();
                MSQL.SqlDataReader1 = MSQL.sqlcmdLenhThucThi.ExecuteReader();
                while (MSQL.SqlDataReader1.Read())
                {
                    NHACUNGCAP ncc = new NHACUNGCAP();
                    ncc.ManNCC1 = MSQL.SqlDataReader1[0].ToString();
                    ncc.TenNCC1 = MSQL.SqlDataReader1[1].ToString();
                    ncc.Diachi1 = MSQL.SqlDataReader1[2].ToString();
                    ncc.MaSoThue1 = MSQL.SqlDataReader1[3].ToString();
                    ncc.SdT1 = MSQL.SqlDataReader1[4].ToString();
                    ncc.Email1 = MSQL.SqlDataReader1[5].ToString();
                    ncc.GhiChu1 = MSQL.SqlDataReader1[6].ToString();
                    ncc.SoTienPhaiTra1 = int.Parse(MSQL.SqlDataReader1[7].ToString());
                    ncc.SoTienDaTra1 = int.Parse(MSQL.SqlDataReader1[8].ToString());
                    AR.Add(ncc);
                }
                MSQL.SqlDataReader1.Close();
                return AR;
            }
      
        }
        public static DataTable TONGHOPNCC_DAO(string sMancc)
        {
            try
            {
                using (MSQL.sqlKetNoi = Provider.get_Connect())
                {
                    MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("sp_CONGNONCC", MSQL.sqlKetNoi);
                    MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                    MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@CNNCC", sMancc);
                    MSQL.DA = MSQL.SqlDataAdapter(MSQL.sqlcmdLenhThucThi);
                    DataTable dtthncc = new DataTable();
                    MSQL.DA.Fill(dtthncc);
                    return dtthncc;
                }
            }
            catch (Exception ex)
            {
              //  mess
                throw;
            }
        }
        public static DataTable ChiTietPNCC_DAO(string sMancc)
        {
            try
            {
                using (MSQL.sqlKetNoi = Provider.get_Connect())
                {
                    MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("sp_phieuthu_chitiet_nhacungcap", MSQL.sqlKetNoi);
                    MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                    MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@PC", sMancc);
                    MSQL.DA = MSQL.SqlDataAdapter(MSQL.sqlcmdLenhThucThi);
                    DataTable dtthncc = new DataTable();
                    MSQL.DA.Fill(dtthncc);
                    return dtthncc;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public static DataTable TONGHOP1CONGNO_DAO(string sMancc)
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("TonghopchimotNcc", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable dttonghop1 = new DataTable();
                dttonghop1.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dttonghop1;
            }
        }
        public static DataTable MOTPC_DAO(string sMapc)
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("get_phieuchi", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@mpc", sMapc);
                DataTable pc = new DataTable();
                pc.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return pc;
            }
        }
        public static DataTable TONGHOPCONGNO_DAO()
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("TonghopchiNcc", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                //MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable dttonghop = new DataTable();
                dttonghop.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dttonghop;
            }
        }
        public static string THEMPHIEUCHI_DAO(THEMPHIEUCHI_DTO dt)
        {

                Provider dv = new Provider();
                List<MySqlParameter> sqlParams = new List<MySqlParameter>();
                MySqlParameter sqlpa = new MySqlParameter("@MAPC", SqlDbType.VarChar, 15);
                sqlpa.Direction = ParameterDirection.Output;
                sqlParams.Add(sqlpa);

                dv.ChayProc("INSERT_PHIEUCHI", sqlParams);

                return dt.MaPhieuChi = Convert.ToString(sqlpa.Value.ToString());

        }
        public static void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new MySqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new MySqlParameter("@NGAYCHI", dto.NgayChi));

            sqlpa.Add(new MySqlParameter("@SOTIENDATRA_PC", dto.SoTienDaTra));
            dv.ChayProc("UPDATE_PHIEUCHI", sqlpa);
        }
        public static DataTable TONGHOPCHI()
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("TONGHOPCHI", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                DataTable THC = new DataTable();
                THC.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return THC;
            }
        }
        public static void XOAPHIEUCHI_DAO(XOAPHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPC", dto.MaPhieuChi));
            dv.ChayProc("DELETE_PHIEUCHI", sqlpa);
        }       
    }
    */
    class CONGNOKH:Provider
    {
        public static Mysqlchange MSQL = new Mysqlchange();
        public static DataTable GETALLHDX_DAO()
        {
            /*
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                string SQL = "SELECT MAHDX as N'Mã hóa đơn xuất',NGAYXUAT as N'Ngày Xuất',TENKH as N'Tên khách hàng',HOADONXUAT.MAKH as N'Mã khách hàng',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONXUAT,KHACHHANG WHERE HOADONXUAT.MAKH=KHACHHANG.MAKH and tienphaitra-tiendatra <> 0 group by hoadonxuat.mahdx,hoadonxuat.tienphaitra,hoadonxuat.tiendatra,khachhang.tenkh,hoadonxuat.makh,hoadonxuat.ngayxuat";

                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                return dt;
            }
            */
            Provider pv = new Provider();
            string SQL = "SELECT MAHDX as N'Mã hóa đơn xuất',NGAYXUAT as N'Ngày Xuất',TENKH as N'Tên khách hàng',HOADONXUAT.MAKH as N'Mã khách hàng',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONXUAT,KHACHHANG WHERE HOADONXUAT.MAKH=KHACHHANG.MAKH and tienphaitra-tiendatra <> 0 group by hoadonxuat.mahdx,hoadonxuat.tienphaitra,hoadonxuat.tiendatra,khachhang.tenkh,hoadonxuat.makh,hoadonxuat.ngayxuat";

            return pv.getdata(SQL);

        }
        public static DataTable GETALLPHIEUCHI_DAO()
        {
            /*
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                string SQL = "SELECT MAPT as N'Mã phiếu thu',MANV as N'Mã nhân viên',MAhdx as N'Mã hóa đơn xuất',ngaythu as N'Ngày thu',SoTienTra_PT as N'Tiền đã trả' FROM PHIEUTHU";
             
                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                return dt;
            }
             */
            Provider pv = new Provider();
            string SQL = "SELECT MAPT as N'Mã phiếu thu',MANV as N'Mã nhân viên',MAhdx as N'Mã hóa đơn xuất',ngaythu as N'Ngày thu',SoTienTra_PT as N'Tiền đã trả' FROM PHIEUTHU";
            return pv.getdata(SQL);
             
        }
        public static DataTable get1pt_dao(string sMahdx)
        {
           /* using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("GETONEPT", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@MAHDX", sMahdx);
                DataTable dtgetpt = new DataTable();
                dtgetpt.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dtgetpt;
            }
            * */
            Provider pv = new Provider();
            string SQL = "SELECT MAPT as N'Mã phiếu thu',MANV as N'Mã nhân viên',MAhdx as N'Mã hóa đơn xuất',ngaythu as N'Ngày thu',sotientra_pt as N'Tiền đã trả' FROM PHIEUTHU WHERE MAHDX='" + sMahdx + "'";
            return pv.getdata(SQL);
        }
        /*
        public static DataTable TONGHOPTHU()
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("TONGHOP_THU", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                //MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable THT = new DataTable();
                THT.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return THT;
            }
        }
        public static DataTable MAPT_DAO()
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("MA_PHIEUTHU", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                DataTable PT = new DataTable();
                PT.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return PT;
            }
            
        }
         */
        public static void THEM_PHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            /*Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPT", dto.MaPhieuThu));
            sqlpa.Add(new MySqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new MySqlParameter("@NGAYTHU", dto.NgayThu));
            sqlpa.Add(new MySqlParameter("@MAHDX", dto.Mahoadonxuat));
            sqlpa.Add(new MySqlParameter("@TIENTHU", dto.SoTienDaTra));
            dv.ChayProc("INSERTPT", sqlpa);
            */
            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUTHU (MAPT,MAHDX,NGAYTHU,MANV,SoTienTra_PT)"
            + " VALUES('" + dto.MaPhieuThu + "', '" + dto.Mahoadonxuat + "','" + dto.NgayThu + "','" + dto.NhanVien + "','" + dto.SoTienDaTra + "')"
            + " select TIENCANSUA =SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'"
            + " update hoadonxuat set TIENDATRA=tiendatra+TIENCANSUA WHERE MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);
        }
        /* public static DataTable ChiTietPNKH_DAO(string sMaKH)
         {

             try
             {
                 using (MSQL.sqlKetNoi = Provider.get_Connect())
                 {
                     MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("sp_phieuthu_chitiet_khachhang", MSQL.sqlKetNoi);
                     MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                     MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@pt", sMaKH);
                     MSQL.DA = MSQL.SqlDataAdapter(MSQL.sqlcmdLenhThucThi);
                     DataTable dtthkh = new DataTable();
                     MSQL.DA.Fill(dtthkh);
                     //  dtthncc.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                     //MSQL.sqlKetNoi.Close();
                     return dtthkh;
                 }
             }
             catch (Exception ex)
             {
                 //  mess
                 throw;
             }
         }
        
         public static DataTable TH1CNKH_DAO(string sMaKH)
         {
             using (MSQL.sqlKetNoi = Provider.get_Connect())
             {
                 MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("TonghopthumotKH", MSQL.sqlKetNoi);
                 MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                 MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@makh", sMaKH);
                 DataTable dttonghop1 = new DataTable();
                 dttonghop1.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                 MSQL.sqlKetNoi.Close();
                 return dttonghop1;
             }
         }
         
        public static string THEMPHIEUTHU_DAO(THEMPHIEUTHU_DTO dt)
        {

            Provider dv = new Provider();
            List<MySqlParameter> sqlParams = new List<MySqlParameter>();
            MySqlParameter sqlpa = new MySqlParameter("@MAPT", SqlDbType.VarChar, 15);
            sqlpa.Direction = ParameterDirection.Output;
            sqlParams.Add(sqlpa);

            dv.ChayProc("INSERT_PHIEUTHU", sqlParams);

            return dt.MaPhieuThu = Convert.ToString(sqlpa.Value.ToString());

        }
         */
        public static void SUAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            /*Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPT", dto.MaPhieuThu));
            sqlpa.Add(new MySqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new MySqlParameter("@NGAYTHU", dto.NgayThu));
            sqlpa.Add(new MySqlParameter("@MAHDX",dto.Mahoadonxuat));
            sqlpa.Add(new MySqlParameter("@TIENTHU", dto.SoTienDaTra));
            dv.ChayProc("UPDATEPT", sqlpa);
            */
            Provider pv = new Provider();
            string SQL = "select TIENCANSUA =SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX='" + dto.Mahoadonxuat + "' AND MAPT='" + dto.MaPhieuThu + "'"
             + " UPDATE  PHIEUTHU set NGAYTHU ='" + dto.NgayThu + "',MAHDX='" + dto.Mahoadonxuat + "',MANV='" + dto.NhanVien + "',SoTienTra_PT='" + dto.SoTienDaTra + "' WHERE MAPT='" + dto.MaPhieuThu + "'"
             + " UPDATE HOADONXUAT SET TIENDATRA=(tiendatra-TIENCANSUA)+'" + dto.SoTienDaTra + "' where MAHDX='" + dto.Mahoadonxuat + "'";
            pv.executeNonQuery(SQL);
        }
        /*public static DataTable MOTPT_DAO(string sMapt)
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("get_phieuthu", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@mpt", sMapt);
                DataTable pt = new DataTable();
                pt.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return pt;
            }
        }
        public static void XOAPHIEUTHU_DAO(XOAPHIEUTHU_DTO dto)
        {
            Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPT", dto.MaPhieuThu));
            dv.ChayProc("DELETE_PHIEUTHU", sqlpa);
        }
        public static DataTable LOADHDX_DAO(string maKH)
        {
            using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("LoadHDX", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@makh", maKH);
                DataTable dtloadhdx = new DataTable();
                dtloadhdx.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dtloadhdx;
            }
        }
         */ 
    }
    class CONGNONCC
    {
        public static Mysqlchange MSQL = new Mysqlchange();
        public static DataTable GETALLHDN_DAO()
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("LoadGETALLHDN", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                //MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable THC = new DataTable();
                THC.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return THC;
            }*/
            Provider pv = new Provider();
            string SQL = "SELECT MAHDN as N'Mã hóa đơn nhập',TENncc as N'Tên nhà cung cấp',HOADONnhap.MAncc as N'Mã nhà cung cấp',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại'"
            +" FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc and hoadonnhap.tinhtrang='false' "
            +" group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc";
            return pv.getdata(SQL);
        }
        public static DataTable GETALLcongno_ncc()
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                string SQL = "SELECT MAHDN as N'Mã hóa đơn nhập',NGAYNHAP as N'Ngày nhập',TENncc as N'Tên nhà cung cấp',HOADONnhap.MAncc as N'Mã nhà cung cấp',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc and tienphaitra-tiendatra<>0 group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc,hoadonnhap.ngaynhap";
                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                return dt;
            }*/
            Provider pv = new Provider();
            string SQL = "SELECT MAHDN as N'Mã hóa đơn nhập',NGAYNHAP as N'Ngày nhập',TENncc as N'Tên nhà cung cấp',HOADONnhap.MAncc as N'Mã nhà cung cấp',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc and tienphaitra-tiendatra<>0 group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc,hoadonnhap.ngaynhap";
            return pv.getdata(SQL);
        }

        public static string GETcongno_HDN(string MHDN)
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONnhap where MAHDN='"+MHDN+"'";
                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                if (dt.Rows.Count > 0)
                    return dt.Rows[0][0].ToString();
                return "0";
            }*/
            Provider pv = new Provider();
            string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONnhap where MAHDN='"+MHDN+"'";
            DataTable dt = new DataTable();
            dt= pv.getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "0";
        }
        public static string GETcongno_HDX(string MHDX)
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONXUAT where MAHDX='" + MHDX + "'";
             
                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                if (dt.Rows.Count > 0)
                    return dt.Rows[0][0].ToString();
                return "0";
            }*/
            Provider pv = new Provider();
            string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONXUAT where MAHDX='" + MHDX + "'";
            DataTable dt = new DataTable();
            dt = pv.getdata(SQL);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "0";

        }
        public static DataTable get1pc_dao(string sMahdn)
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {
                MSQL.sqlcmdLenhThucThi = MSQL.SqlCommand("GETONEPC", MSQL.sqlKetNoi);
                MSQL.sqlcmdLenhThucThi.CommandType = CommandType.StoredProcedure;
                MSQL.sqlcmdLenhThucThi.Parameters.AddWithValue("@MAHDN", sMahdn);
                DataTable dtgetpc = new DataTable();
                dtgetpc.Load(MSQL.sqlcmdLenhThucThi.ExecuteReader());
                MSQL.sqlKetNoi.Close();
                return dtgetpc;
            }
            */
            Provider pv = new Provider();
            string SQL = "SELECT MAPc as N'Mã phiếu chi',MANV as N'Mã nhân viên',MAhdn as N'Mã hóa đơn nhập',ngaychi as N'Ngày chi',SoTienDaTra_PC as N'Tiền đã trả' FROM PHIEUCHI WHERE MAHDN='"+sMahdn+"'";
            return pv.getdata(SQL);
        }
        public static DataTable Getall_phieuchi_Dao()
        {
            /*using (MSQL.sqlKetNoi = Provider.get_Connect())
            {

                string SQL = "SELECT MAPc as N'Mã phiếu chi',MANV as N'Mã nhân viên',MAhdn as N'Mã hóa đơn nhập',ngaychi as N'Ngày chi',SoTienDaTra_PC as N'Tiền đã trả' FROM PHIEUCHI";
    
                MSQL.DA = MSQL.SqlDataAdapter(SQL, MSQL.sqlKetNoi);
                DataTable dt = new DataTable();
                MSQL.DA.Fill(dt);
                MSQL.sqlKetNoi.Close();
                return dt;
            }*/
            Provider pv = new Provider();
            string SQL = "SELECT MAPc as N'Mã phiếu chi',MANV as N'Mã nhân viên',MAhdn as N'Mã hóa đơn nhập',ngaychi as N'Ngày chi',SoTienDaTra_PC as N'Tiền đã trả' FROM PHIEUCHI";
            return pv.getdata(SQL);
        }
        public static void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            /*Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new MySqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new MySqlParameter("@NGAYCHI", dto.NgayChi));
            sqlpa.Add(new MySqlParameter("@MAHDN", dto.Mahoadonnhap));
            sqlpa.Add(new MySqlParameter("@TIENTRA", dto.SoTienDaTra));
            dv.ChayProc("UPDATEPC", sqlpa);
            */
            Provider pv = new Provider();
            string SQL = "select TIENCANSUA =SoTienDaTra_PC FROM PHIEUCHI WHERE MAHDN='"+dto.Mahoadonnhap+"' AND MAPC='"+dto.MaPhieuChi+"'"
	        +" UPDATE  PHIEUCHI set NGAYCHI ='"+dto.NgayChi+"',MAHDN='"+dto.Mahoadonnhap+"',MANV='"+dto.NhanVien+"',SoTienDaTra_PC='"+dto.SoTienDaTra+"' WHERE MAPC='"+dto.MaPhieuChi+"'"
	        +" UPDATE HOADONnhap SET TIENDATRA=(tiendatra-TIENCANSUA)+'"+dto.SoTienDaTra+"' where MAHDN='"+dto.Mahoadonnhap+"'";
            pv.executeNonQuery(SQL);
        }
        public static void THEM_PHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            /*Provider dv = new Provider();
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new MySqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new MySqlParameter("@NGAYCHI", dto.NgayChi));
            sqlpa.Add(new MySqlParameter("@MAHDN", dto.Mahoadonnhap));
            sqlpa.Add(new MySqlParameter("@TIENTRA", dto.SoTienDaTra));
            dv.ChayProc("INSERTPC", sqlpa);
            */
            Provider pv = new Provider();
            string SQL = "INSERT INTO PHIEUCHI (MAPC,MAHDN,NGAYCHI,MANV,SoTienDaTra_PC)   VALUES('"+dto.MaPhieuChi+"', '"+dto.Mahoadonnhap+"','"+dto.NgayChi+"','"+dto.NhanVien+"','"+dto.SoTienDaTra+"')"
	        +" select TIENCANSUA =SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN='"+dto.Mahoadonnhap+"' AND MAPC='"+dto.MaPhieuChi+"'"
	        +" update hoadonnhap set TIENDATRA=tiendatra+TIENCANSUA WHERE MAHDN='"+dto.Mahoadonnhap+"'";
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
