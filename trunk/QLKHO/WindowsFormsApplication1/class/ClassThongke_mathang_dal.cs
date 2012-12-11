using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class ClassThongke_mathang_dal :Provider
    {

        public DataTable THONGKHETHEOKHACHHANG(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sqlpa1 = new List<SqlParameter>();
            sqlpa1.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa1.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("THONGKETHEOKHACHHANG_getall", sqlpa1);
        }
        //--------------------
        public DataTable getloinhuan(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sqlpa1 = new List<SqlParameter>();
            sqlpa1.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa1.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("LOINHUANKINHDOANH_getall", sqlpa1);
        }
        //---------------------------------------------------

        public DataTable getbaocaotheokho(Class_DTO_ThongKe dto)

        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("BAOCAOTHEOKHO_getall", sqlpa);

        }
    //---------------------------------------------
         public DataTable getTonKho(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            sqlpa.Add(new SqlParameter("@MAKHO", dto.MAKHO));
            sqlpa.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sqlpa.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("TONKHO_getall", sqlpa);
        }
        //------------------------TON KHO
        public DataTable load_hieuquakinhdoanh(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sqlpa = new List<SqlParameter>();
            return executeNonQuerya("THONGKEHIEUQUAKINHDOANH_getall", sqlpa);
        }
        public DataTable load_getbaocaotonkho(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sql = new List<SqlParameter>();
            sql.Add(new SqlParameter("@NGAYTHANGTU", dto.NGAYBDKHO));
            sql.Add(new SqlParameter("@NGAYTHANGDEN", dto.NGAYKTKHO));
            return executeNonQuerya("THONGKEXUATHANGTHEOKHACHHANG_getall", sql);
        }

        //--------------------Backup Restore---------------------------

        public DataTable load_mathang( Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sql = new List<SqlParameter>();
            sql.Add(new SqlParameter("@ngay_bd", dto.NGAY_BD));
            sql.Add(new SqlParameter("@Ngay_kt", dto.NGAY_KT));
            sql.Add(new SqlParameter("@loai_tg",dto.Loai_TG));
            sql.Add(new SqlParameter("@loai_ht",dto.Loai_HT));
            return executeNonQuerya("THONGKE_MATHANG", sql);
        }
        public DataTable load_ct_mathang(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sql = new List<SqlParameter>();
            sql.Add(new SqlParameter("@NGAY_BD", dto.NGAY_BD));
            sql.Add(new SqlParameter("@NGAY_KT", dto.NGAY_KT));
            sql.Add(new SqlParameter("@LOAI_TG", dto.Loai_TG));
            sql.Add(new SqlParameter("@LOAI_HT", dto.Loai_HT));
            sql.Add(new SqlParameter("@MANH", dto.MANH));
            return executeNonQuerya("THONGKE_CT_MATHANG", sql);
        }

        public DataTable load_ct_mathang2(Class_DTO_ThongKe dto)
        {
            List<SqlParameter> sql = new List<SqlParameter>();
            sql.Add(new SqlParameter("@LOAI_TG", dto.Loai_TG));
            sql.Add(new SqlParameter("@LOAI_HT", dto.Loai_HT));
            return executeNonQuerya("THONGKE_CT_MATHANG2", sql);
        }

        public DataTable get_NH()
        { 
            List<SqlParameter> sql = new List<SqlParameter>();
            return executeNonQuerya("[NHOMHANG_getall]", sql);
        }

    }
}
