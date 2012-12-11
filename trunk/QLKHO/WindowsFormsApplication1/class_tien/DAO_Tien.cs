using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DAO_Tien
    {
    }
    class CHITIETNHCC_HDN
    {
        public static DataTable TTNCC_DAO(string sMancc)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("HOADONNHAP_CNO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mancc", sMancc);
                DataTable dtttncc = new DataTable();
                dtttncc.Load(cmd.ExecuteReader());
                cn.Close();
                return dtttncc;
            }
        }
        public static ArrayList RDTTNCC_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("THONGTIN_HOADONNHAP_CNO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                ArrayList AR = new ArrayList();
                SqlDataReader RD = cmd.ExecuteReader();
                while (RD.Read())
                {
                    NHACUNGCAP ncc = new NHACUNGCAP();
                    ncc.ManNCC1 = RD[0].ToString();
                    ncc.TenNCC1 = RD[1].ToString();
                    ncc.Diachi1 = RD[2].ToString();
                    ncc.MaSoThue1 = RD[3].ToString();
                    ncc.SdT1 = RD[4].ToString();
                    ncc.Email1 = RD[5].ToString();
                    ncc.GhiChu1 = RD[6].ToString();
                    ncc.SoTienPhaiTra1 = int.Parse(RD[7].ToString());
                    ncc.SoTienDaTra1 = int.Parse(RD[8].ToString());
                    AR.Add(ncc);
                }
                RD.Close();
                return AR;
            }
        }
        public static DataTable TONGHOPNCC_DAO(string sMancc)
        {
            try
            {
                using (SqlConnection cn = Provider.get_Connect())
                {
                    SqlCommand cmd = new SqlCommand("sp_CONGNONCC", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CNNCC", sMancc);
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataTable dtthncc = new DataTable();
                    dt.Fill(dtthncc);
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
                using (SqlConnection cn = Provider.get_Connect())
                {
                    SqlCommand cmd = new SqlCommand("sp_phieuthu_chitiet_nhacungcap", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PC", sMancc);
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataTable dtthncc = new DataTable();
                    dt.Fill(dtthncc);
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
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("TonghopchimotNcc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable dttonghop1 = new DataTable();
                dttonghop1.Load(cmd.ExecuteReader());
                cn.Close();
                return dttonghop1;
            }
        }
        public static DataTable MOTPC_DAO(string sMapc)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("get_phieuchi", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mpc", sMapc);
                DataTable pc = new DataTable();
                pc.Load(cmd.ExecuteReader());
                cn.Close();
                return pc;
            }
        }
        public static DataTable TONGHOPCONGNO_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("TonghopchiNcc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable dttonghop = new DataTable();
                dttonghop.Load(cmd.ExecuteReader());
                cn.Close();
                return dttonghop;
            }
        }
        public static string THEMPHIEUCHI_DAO(THEMPHIEUCHI_DTO dt)
        {

                Provider dv = new Provider();
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                SqlParameter sqlpa = new SqlParameter("@MAPC", SqlDbType.VarChar, 15);
                sqlpa.Direction = ParameterDirection.Output;
                sqlParams.Add(sqlpa);

                dv.ChayProc("INSERT_PHIEUCHI", sqlParams);

                return dt.MaPhieuChi = Convert.ToString(sqlpa.Value.ToString());

        }
        public static void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new SqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new SqlParameter("@NGAYCHI", dto.NgayChi));

            sqlpa.Add(new SqlParameter("@SOTIENDATRA_PC", dto.SoTienDaTra));
            dv.ChayProc("UPDATE_PHIEUCHI", sqlpa);
        }
        public static DataTable TONGHOPCHI()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("TONGHOPCHI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable THC = new DataTable();
                THC.Load(cmd.ExecuteReader());
                cn.Close();
                return THC;
            }
        }
        public static void XOAPHIEUCHI_DAO(XOAPHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPC", dto.MaPhieuChi));
            dv.ChayProc("DELETE_PHIEUCHI", sqlpa);
        }       
    }
    class CONGNOKH
    {
        public static DataTable GETALLHDX_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                string SQL = "SELECT MAHDX as N'Mã hóa đơn xuất',NGAYXUAT as N'Ngày Xuất',TENKH as N'Tên khách hàng',HOADONXUAT.MAKH as N'Mã khách hàng',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONXUAT,KHACHHANG WHERE HOADONXUAT.MAKH=KHACHHANG.MAKH and tienphaitra-tiendatra <> 0 group by hoadonxuat.mahdx,hoadonxuat.tienphaitra,hoadonxuat.tiendatra,khachhang.tenkh,hoadonxuat.makh,hoadonxuat.ngayxuat";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        public static DataTable GETALLPHIEUCHI_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                string SQL = "SELECT MAPT as N'Mã phiếu thu',MANV as N'Mã nhân viên',MAhdx as N'Mã hóa đơn xuất',ngaythu as N'Ngày thu',SoTienTra_PT as N'Tiền đã trả' FROM PHIEUTHU";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        public static DataTable get1pt_dao(string sMahdx)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("GETONEPT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAHDX", sMahdx);
                DataTable dtgetpt = new DataTable();
                dtgetpt.Load(cmd.ExecuteReader());
                cn.Close();
                return dtgetpt;
            }
        }
        public static DataTable TONGHOPTHU()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("TONGHOP_THU", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable THT = new DataTable();
                THT.Load(cmd.ExecuteReader());
                cn.Close();
                return THT;
            }
        }
        public static DataTable MAPT_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("MA_PHIEUTHU", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable PT = new DataTable();
                PT.Load(cmd.ExecuteReader());
                cn.Close();
                return PT;
            }
        }
        public static void THEM_PHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPT", dto.MaPhieuThu));
            sqlpa.Add(new SqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new SqlParameter("@NGAYTHU", dto.NgayThu));
            sqlpa.Add(new SqlParameter("@MAHDX", dto.Mahoadonxuat));
            sqlpa.Add(new SqlParameter("@TIENTHU", dto.SoTienDaTra));
            dv.ChayProc("INSERTPT", sqlpa);
        }
        public static DataTable ChiTietPNKH_DAO(string sMaKH)
        {

            try
            {
                using (SqlConnection cn = Provider.get_Connect())
                {
                    SqlCommand cmd = new SqlCommand("sp_phieuthu_chitiet_khachhang", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pt", sMaKH);
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataTable dtthkh = new DataTable();
                    dt.Fill(dtthkh);
                    //  dtthncc.Load(cmd.ExecuteReader());
                    //cn.Close();
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
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("TonghopthumotKH", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", sMaKH);
                DataTable dttonghop1 = new DataTable();
                dttonghop1.Load(cmd.ExecuteReader());
                cn.Close();
                return dttonghop1;
            }
        }
        public static string THEMPHIEUTHU_DAO(THEMPHIEUTHU_DTO dt)
        {

            Provider dv = new Provider();
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            SqlParameter sqlpa = new SqlParameter("@MAPT", SqlDbType.VarChar, 15);
            sqlpa.Direction = ParameterDirection.Output;
            sqlParams.Add(sqlpa);

            dv.ChayProc("INSERT_PHIEUTHU", sqlParams);

            return dt.MaPhieuThu = Convert.ToString(sqlpa.Value.ToString());

        }
        public static void SUAPHIEUTHU_DAO(PHIEUTHU_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPT", dto.MaPhieuThu));
            sqlpa.Add(new SqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new SqlParameter("@NGAYTHU", dto.NgayThu));
            sqlpa.Add(new SqlParameter("@MAHDX",dto.Mahoadonxuat));
            sqlpa.Add(new SqlParameter("@TIENTHU", dto.SoTienDaTra));
            dv.ChayProc("UPDATEPT", sqlpa);
        }
        public static DataTable MOTPT_DAO(string sMapt)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("get_phieuthu", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mpt", sMapt);
                DataTable pt = new DataTable();
                pt.Load(cmd.ExecuteReader());
                cn.Close();
                return pt;
            }
        }
        public static void XOAPHIEUTHU_DAO(XOAPHIEUTHU_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPT", dto.MaPhieuThu));
            dv.ChayProc("DELETE_PHIEUTHU", sqlpa);
        }
        public static DataTable LOADHDX_DAO(string maKH)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("LoadHDX", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", maKH);
                DataTable dtloadhdx = new DataTable();
                dtloadhdx.Load(cmd.ExecuteReader());
                cn.Close();
                return dtloadhdx;
            }
        }

        
    }
    class CONGNONCC
    {
        public static DataTable GETALLHDN_DAO()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("LoadGETALLHDN", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@manhacc", sMancc);
                DataTable THC = new DataTable();
                THC.Load(cmd.ExecuteReader());
                cn.Close();
                return THC;
            }
        }
        public static DataTable GETALLcongno_ncc()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                string SQL = "SELECT MAHDN as N'Mã hóa đơn nhập',NGAYNHAP as N'Ngày nhập',TENncc as N'Tên nhà cung cấp',HOADONnhap.MAncc as N'Mã nhà cung cấp',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại' FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc and tienphaitra-tiendatra<>0 group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc,hoadonnhap.ngaynhap";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

        public static string GETcongno_HDN(string MHDN)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONnhap where MAHDN='"+MHDN+"'";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count > 0)
                    return dt.Rows[0][0].ToString();
                return "0";
            }
        }
        public static string GETcongno_HDX(string MHDX)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                string SQL = "SELECT tienphaitra-tiendatra conlai FROM HOADONXUAT where MAHDX='" + MHDX + "'";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count > 0)
                    return dt.Rows[0][0].ToString();
                return "0";
            }
        }
        public static DataTable get1pc_dao(string sMahdn)
        {
            using (SqlConnection cn = Provider.get_Connect())
            {
                SqlCommand cmd = new SqlCommand("GETONEPC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAHDN", sMahdn);
                DataTable dtgetpc = new DataTable();
                dtgetpc.Load(cmd.ExecuteReader());
                cn.Close();
                return dtgetpc;
            }
        }
        public static DataTable Getall_phieuchi_Dao()
        {
            using (SqlConnection cn = Provider.get_Connect())
            {

                string SQL = "SELECT MAPc as N'Mã phiếu chi',MANV as N'Mã nhân viên',MAhdn as N'Mã hóa đơn nhập',ngaychi as N'Ngày chi',SoTienDaTra_PC as N'Tiền đã trả' FROM PHIEUCHI";
                SqlDataAdapter da;
                da = new SqlDataAdapter(SQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        public static void SUAPHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new SqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new SqlParameter("@NGAYCHI", dto.NgayChi));
            sqlpa.Add(new SqlParameter("@MAHDN", dto.Mahoadonnhap));
            sqlpa.Add(new SqlParameter("@TIENTRA", dto.SoTienDaTra));
            dv.ChayProc("UPDATEPC", sqlpa);
        }
        public static void THEM_PHIEUCHI_DAO(PHIEUCHI_DTO dto)
        {
            Provider dv = new Provider();
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAPC", dto.MaPhieuChi));
            sqlpa.Add(new SqlParameter("@MANV", dto.NhanVien));
            sqlpa.Add(new SqlParameter("@NGAYCHI", dto.NgayChi));
            sqlpa.Add(new SqlParameter("@MAHDN", dto.Mahoadonnhap));
            sqlpa.Add(new SqlParameter("@TIENTRA", dto.SoTienDaTra));
            dv.ChayProc("INSERTPC", sqlpa);
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
