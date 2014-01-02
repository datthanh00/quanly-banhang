using System;
using System.Data;


namespace WindowsFormsApplication1
{
	class PublicVariable
	{
        // XAC DINH VERSION CHO  PHAN MÊM DE KHOA NGUOI DUNG SU DUNG VERSION CU
       public static int VERSION = 109;
      
       // XAC DINH BUILD DE BUILD LA KHO CONG TY HAY KHO TUAN HANH
       public static Boolean IS_VINAVETCO = false;
       public static string TATCA,XEM,THEM, XOA, SUA, IN, MAKHO,MANV,CODEKHO;
       public static Boolean isHSD, isBARCODE, isTONNHAPXUATNGAYFULL, isKHOILUONG, isBANGGIA;
       public static Boolean isUSELAN=false;
       public static DataTable KhoQL;
       public static String TMPtring, SQL_NHAP, SQL_XUAT, SQL_TRANHAP, SQL_TRAXUAT, TMPlog;
       public static String LOHANG = "TONDAU";
       public static int ComboNhap = 3, ComboXuat=3,ComboTraNhap=3,ComboTraXuat=3;
	}
}
