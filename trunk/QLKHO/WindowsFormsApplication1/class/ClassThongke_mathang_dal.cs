using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class ClassThongke_mathang_dal :Provider
    {

        public DataTable THONGKHETHEOKHACHHANG(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("THONGKETHEOKHACHHANG_getall", sqlpa1);
        }
        //--------------------
        public DataTable getloinhuan(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sqlpa1 = new List<MySqlParameter>();
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa1.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("LOINHUANKINHDOANH_getall", sqlpa1);
        }
        //---------------------------------------------------

        public DataTable getbaocaotheokho(Class_DTO_ThongKe dto)

        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("BAOCAOTHEOKHO_getall", sqlpa);

        }
    //---------------------------------------------
         public DataTable getTonKho(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            sqlpa.Add(new MySqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("TONKHO_getall", sqlpa);
        }
        //------------------------TON KHO
        public DataTable load_hieuquakinhdoanh(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sqlpa = new List<MySqlParameter>();
            return executeNonQuerya("THONGKEHIEUQUAKINHDOANH_getall", sqlpa);
        }
        public DataTable load_getbaocaotonkho(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sql = new List<MySqlParameter>();
            sql.Add(new MySqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sql.Add(new MySqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("THONGKEXUATHANGTHEOKHACHHANG_getall", sql);
        }

        //--------------------Backup Restore---------------------------

        public DataTable load_mathang( Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sql = new List<MySqlParameter>();
            sql.Add(new MySqlParameter("@ngay_bd", dto.NGAY_BD));
            sql.Add(new MySqlParameter("@Ngay_kt", dto.NGAY_KT));
            sql.Add(new MySqlParameter("@loai_tg",dto.Loai_TG));
            sql.Add(new MySqlParameter("@loai_ht",dto.Loai_HT));
            return executeNonQuerya("THONGKE_MATHANG", sql);
        }
        public DataTable load_ct_mathang(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sql = new List<MySqlParameter>();
            sql.Add(new MySqlParameter("@NGAY_BD", dto.NGAY_BD));
            sql.Add(new MySqlParameter("@NGAY_KT", dto.NGAY_KT));
            sql.Add(new MySqlParameter("@LOAI_TG", dto.Loai_TG));
            sql.Add(new MySqlParameter("@LOAI_HT", dto.Loai_HT));
            sql.Add(new MySqlParameter("@MANH", dto.MANH));
            return executeNonQuerya("THONGKE_CT_MATHANG", sql);
        }

        public DataTable load_ct_mathang2(Class_DTO_ThongKe dto)
        {
            List<MySqlParameter> sql = new List<MySqlParameter>();
            sql.Add(new MySqlParameter("@LOAI_TG", dto.Loai_TG));
            sql.Add(new MySqlParameter("@LOAI_HT", dto.Loai_HT));
            return executeNonQuerya("THONGKE_CT_MATHANG2", sql);
        }

        public DataTable get_NH()
        { 
            List<MySqlParameter> sql = new List<MySqlParameter>();
            return executeNonQuerya("[NHOMHANG_getall]", sql);
        }

    }
}
