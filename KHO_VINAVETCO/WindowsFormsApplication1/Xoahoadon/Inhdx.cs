using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhdx : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdx(string MAHD, string MAMH, string TENMH,string SOLUONG, string LYDOXOA)
        {
            InitializeComponent();
            CTL ctl = new CTL();
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
            DataTable dt2 = ctl.GETDATA(SQL);
            string ss1 = "Hôm nay ngày: "+dt2.Rows[0][0].ToString();
            lbngaylap.Text = ss1;

            lbnoidung.Text="Xóa Chứng từ: "+MAHD;
            lbtenmathang.Text = "Mã Mặt Hàng: " + MAMH + " - - Tên Mặt Hàng: " + TENMH + " - - SỐ LƯỢNG: " + SOLUONG;
            lblydoxoa.Text = "Lý Do Xóa: " + LYDOXOA;
            SQL = "select * from thongtinct where mact=1";
         
            DataTable dt = ctl.GETDATA(SQL);
            lbintrai.Text = dt.Rows[0]["TTINTRAI"].ToString();
            lbttinphai.Text = dt.Rows[0]["TTINPHAI"].ToString();
            lbingiua.Text = dt.Rows[0]["TTINGIUA"].ToString();
          

        }

    }
}
