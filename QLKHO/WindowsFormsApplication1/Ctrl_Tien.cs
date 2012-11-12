using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Ctrl_Tien
    {
        public static DataTable TTNCC_CTRL(string sMancc)
        {

            return CHITIETNHCC_HDN.TTNCC_DAO(sMancc);
        }
        public static DataTable TIM_THCNNCC_CTRL(string sMancc)
        {

            return CHITIETNHCC_HDN.TONGHOPNCC_DAO(sMancc);
        }
        public static ArrayList RDTTNCC_CTRL()
        {

            return CHITIETNHCC_HDN.RDTTNCC_DAO();
        }

        public static DataTable ChiTietPNCC_DAO(string sMancc)
        {
            return CHITIETNHCC_HDN.ChiTietPNCC_DAO(sMancc);
        }
        public static DataTable thcongnoncc_DAO()
        {
            return CHITIETNHCC_HDN.TONGHOPCONGNO_DAO();
        }
        public static DataTable thcongnoncc1_DAO(string sma)
        {
            return CHITIETNHCC_HDN.TONGHOP1CONGNO_DAO(sma);
        }
        public static DataTable pc_ctrl(string sma)
        {
            return CHITIETNHCC_HDN.MOTPC_DAO(sma);
        }
        public static string THEMPHIEUCHI_CTRL(THEMPHIEUCHI_DTO dt)
        {

            return CHITIETNHCC_HDN.THEMPHIEUCHI_DAO(dt);
        }

        public static DataTable tonghopchi_dao()
        {
            return CHITIETNHCC_HDN.TONGHOPCHI();
        }

        
        public static DataTable TONGHOPTHU_KH()
        {
            return CONGNOKH.GETALLHDX_DAO();
        }
        public static DataTable Chitietnokh(string sMaKH)
        {
            return CONGNOKH.ChiTietPNKH_DAO(sMaKH);
        }
        public static DataTable THCN1KH(string sma)
        {
            return CONGNOKH.TH1CNKH_DAO(sma);
        }
        public static string THEMPHIEUTHU_CTRL(THEMPHIEUTHU_DTO dt)
        {

            return CONGNOKH.THEMPHIEUTHU_DAO(dt);
        }
        public static void SUAPHIEUTHU_ctrl(PHIEUTHU_DTO dt)
        {
            CONGNOKH.SUAPHIEUTHU_DAO(dt);
        }
        public static DataTable pt_ctrl(string sma)
        {
            return CONGNOKH.MOTPT_DAO(sma);
        }
        public static void XOAPHIEUTHU_ctrl(XOAPHIEUTHU_DTO dto)
        {
            CONGNOKH.XOAPHIEUTHU_DAO(dto);
        }
        public static void XOAPHIEUCHI_ctrl(XOAPHIEUCHI_DTO dto)
        {
            CHITIETNHCC_HDN.XOAPHIEUCHI_DAO(dto);
        }
        
        public static DataTable loadhdx_ctrl(string MaKH)
        {
            return CONGNOKH.LOADHDX_DAO(MaKH);
        }
        /// <summary>
        /// //////////////Lại từ đầu
        /// </summary>
        /// <returns></returns>
        public static DataTable GETALLHDX_ctrl()
        {
            return CONGNOKH.GETALLHDX_DAO();
            
        }
        public static DataTable get1pthdx_ctrl(string MaHDX)
        {
            return CONGNOKH.get1pt_dao(MaHDX);
        }
        public static void THEM_PHIEUTHU_ctrl(PHIEUTHU_DTO dt)
        {
              CONGNOKH.THEM_PHIEUTHU_DAO(dt);
        }
        public static DataTable MAPT_ctrl()
        {
            return CONGNOKH.MAPT_DAO();
        }
        public static DataTable GETALLHDn_ctrl()
        {
            return CONGNONCC.GETALLHDN_DAO();
        }
        public static DataTable get1pthdn_ctrl(string MaHDn)
        {
            return CONGNONCC.get1pc_dao(MaHDn);
        }
        public static void SUAPHIEUCHI(PHIEUCHI_DTO dt)
        {
            CONGNONCC.SUAPHIEUCHI_DAO(dt);
        }
        public static void THEM_PHIEUCHI_ctrl(PHIEUCHI_DTO dt)
        {
            CONGNONCC.THEM_PHIEUCHI_DAO(dt);
        }
    }
}
