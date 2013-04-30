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
        public Inhdx(string MAHD, string MAMH, string TENMH, string LYDOXOA)
        {
            InitializeComponent();
            CTL ctl = new CTL();
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime, TENMH FROM MATHANG WHERE MAMH='"+MAMH+"' ";
            DataTable dt2 = ctl.GETDATA(SQL);
            string ss1 = dt2.Rows[0][0].ToString();
            lbngaylap.Text = ss1;

            lbnoidung.Text="Xóa Chứng từ: "+MAHD;
            lbtenmathang.Text = "Mã Mặt Hàng: " + MAMH + " Tên Mặt Hàng: " + dt2.Rows[0][1].ToString();
            lblydoxoa.Text = "Lý Do Xóa: " + LYDOXOA;

           
          

        }

    }
}
