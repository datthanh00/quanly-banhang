﻿using System;
using System.Data;

namespace WindowsFormsApplication1
{
    class Class_ctrl_thongkekho
    {
        ClassThongke_mathang_dal dao = new ClassThongke_mathang_dal();
       
        public DataTable thongkhetheokhachang(Class_DTO_ThongKe dto)
        {
            return dao.THONGKHETHEOKHACHHANG(dto);
        }
        public DataTable thongkhetheoNCC(Class_DTO_ThongKe dto)
        {
            return dao.THONGKHETHEONCC(dto);
        }
        public DataTable LOINHUANKINHDOANH(Class_DTO_ThongKe dto)
        {
            return dao.getloinhuan(dto);
        }
        public DataTable TONKHOTONGHOP(Class_DTO_ThongKe dto)
        {
            return dao.gettonkhotonghop(dto);
        }
        public DataTable THEKHO(Class_DTO_ThongKe dto)
        {
            return dao.getthekho(dto);
        }
        public DataTable SOCHITIETHANGHOA(Class_DTO_ThongKe dto)
        {
            return dao.getsochitiethanghoa(dto);
        }

        public DataTable getBAOCAOTHEOKHO(Class_DTO_ThongKe dto)
        {
            return dao.getbaocaotheokho(dto);
        }
        public DataTable getTonKho(Class_DTO_ThongKe dto)
        {
            return dao.getTonKho(dto);
        }
       


        public DataTable geTthongke_ct_mathang2(Class_DTO_ThongKe dto1)
        {
            return dao.load_ct_mathang2(dto1);
        }

        public DataTable dtGetNH()
        {
            return dao.get_NH();
        }
        public DataTable dtGetNH2()
        {
            return dao.get_NH2();
        }
        public DataTable dtGetkho()
        {
            return dao.dtGetkho();
        }
        public DataTable dtGetsanpham()
        {
            return dao.dtGetsanpham();
        }
        //public DataTable getTHONGKE_CT_MATHANG(Class_DTO_ThongKe dto)
        //{
        //    return dao.load_ct_mathang(dto);
        //}
        public DataTable getthongkebaocaoxuathang (Class_DTO_ThongKe dto)
        {
            return dao.load_getbaocaotonkho(dto);
        }
        public DataTable gethieuquakinhdoanh(Class_DTO_ThongKe dto)
        {
            return dao.load_hieuquakinhdoanh(dto);
        }
    }
}
