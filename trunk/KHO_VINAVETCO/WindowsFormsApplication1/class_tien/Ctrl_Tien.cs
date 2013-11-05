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

        /// <summary>
        /// //////////////Lại từ đầu
        /// </summary>
        /// <returns></returns>

        public DataTable GETALLPHIEUTHU_ctrl(string NGAYBD, string NGAYKT)
        {
            return CNKH.GETALL_PHIEUTHU_DAO(NGAYBD, NGAYKT);
        }
        public DataTable GETALLHOADON_ctrl(string NGAYBD, string NGAYKT)
        {
            return CNKH.GETALLHOADON_ctrl(NGAYBD, NGAYKT);
        }
        public  DataTable get1pthdx_ctrl(string MaHDX)
        {
            return CNKH.get1pt_dao(MaHDX);
        }
        public DataTable GETCODEACTIVE()
        {
            return CNKH.GETCODEACTIVE();
        }
        public DataTable GETTIENTRATRUOC()
        {
            return CNKH.GETTIENTRATRUOC();
        }

        public DataTable GETBANGGIA()
        {
            return CNKH.GETBANGGIA();
        }

        public void DELETECODEACTIVE(string ACTIVE)
        {
            CNKH.DELETECODEACTIVE(ACTIVE);
        }
        public void INSERTCODEACTIVE()
        {
            CNKH.INSERTCODEACTIVE();
        }
        public void ACTIVE_CODEACTIVE(string ACTIVE, String COMPUTERNAME)
        {
            CNKH.ACTIVE_CODEACTIVE(ACTIVE, COMPUTERNAME);
        }
        public  void THEM_PHIEUTHU_ctrl(PHIEUTHU_DTO dt)
        {
              CNKH.THEMPHIEUTHU_DAO(dt);
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

        public  DataTable GETALLcongno_ncc()
        {
            return CNNCC.GETALLcongno_ncc();
        }
        public DataTable GETALLcongno_kh()
        {
            return CNKH.GETALLcongno_kh();
        }
        public  string GETcongno_HDN(string MHDN)
        {
            return CNNCC.GETcongno_HDN(MHDN);
        }
        public  string GETcongno_HDX(string MHDX)
        {
            return CNNCC.GETcongno_HDX(MHDX);
        }

        public string GETcongno_NCC(string MANCC)
        {
            return CNNCC.GETcongno_NCC(MANCC);
        }
        public string GETcongno_KH(string MAKH)
        {
            return CNNCC.GETcongno_KH(MAKH);
        }

        public  DataTable Getall_phieuchi_Dao(string NGAYBD,string NGAYKT)
        {
            return CNNCC.Getall_phieuchi_Dao(NGAYBD, NGAYKT);
        }
        public DataTable Getall_hoadon_Dao(string NGAYBD, string NGAYKT)
        {
            return CNNCC.Getall_hoadon_Dao(NGAYBD, NGAYKT);
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
            CNNCC.THEMPHIEUCHI_DAO(dt);
        }
    }
}
