using System;
using System.Data;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Ctrl_Tien
    {
        CONGNOKH CNKH = new CONGNOKH();
        public  void SUAPHIEUTHU_ctrl(PHIEUTHU_DTO dt)
        {
            CNKH.SUAPHIEUTHU_DAO(dt);
        }
        public  DataTable TONGHOPTHU_KHD12()
        {
            return CNKH.GETALLHDX_DAO("","");
        }
        /// <summary>
        /// //////////////Lại từ đầu
        /// </summary>
        /// <returns></returns>
        public  DataTable GETALLHDX_ctrl(string NGAYBD,string NGAYKT)
        {
            return CNKH.GETALLHDX_DAO(NGAYBD, NGAYKT);
            
        }
        public DataTable GETALLPHIEUCHI_ctrl(string NGAYBD, string NGAYKT)
        {
            return CNKH.GETALLPHIEUCHI_DAO(NGAYBD, NGAYKT);

        }
        public  DataTable get1pthdx_ctrl(string MaHDX)
        {
            return CNKH.get1pt_dao(MaHDX);
        }
        public  void THEM_PHIEUTHU_ctrl(PHIEUTHU_DTO dt)
        {
              CNKH.THEM_PHIEUTHU_DAO(dt);
        }
       /* public  DataTable MAPT_ctrl()
        {
            return CNKH.MAPT_DAO();
        }*/
        CONGNONCC CNNCC = new CONGNONCC();
        public  DataTable GETALLHDn_ctrl()
        {
            return CNNCC.GETALLHDN_DAO();
        }

        public  DataTable GETALLcongno_ncc(string NGAYBD, string NGAYKT)
        {
            return CNNCC.GETALLcongno_ncc(NGAYBD, NGAYKT);
        }
        public  string GETcongno_HDN(string MHDN)
        {
            return CNNCC.GETcongno_HDN(MHDN);
        }
        public  string GETcongno_HDX(string MHDX)
        {
            return CNNCC.GETcongno_HDX(MHDX);
        }

        public  DataTable Getall_phieuchi_Dao(string NGAYBD,string NGAYKT)
        {
            return CNNCC.Getall_phieuchi_Dao(NGAYBD, NGAYKT);
        }
        public  DataTable get1pthdn_ctrl(string MaHDn)
        {
            return CNNCC.get1pc_dao(MaHDn);
        }
        public  void SUAPHIEUCHI(PHIEUCHI_DTO dt)
        {
            CNNCC.SUAPHIEUCHI_DAO(dt);
        }
        public  void THEM_PHIEUCHI_ctrl(PHIEUCHI_DTO dt)
        {
            CNNCC.THEM_PHIEUCHI_DAO(dt);
        }
    }
}
