using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class In : DevExpress.XtraReports.UI.XtraReport
    {
        public In(DataTable list, string mancc, string tenncc, string tientra, string tienno, string thanhtien, string tienck, string mahdn, string ten)
        {
            InitializeComponent();
            gridControl1.DataSource = list;
            lbTenNCC.Text = tenncc;

            Double sthanhtien = Convert.ToDouble(thanhtien);
            Double stienck = Convert.ToDouble(tienck);
            Double stientra = Convert.ToDouble(tientra);
            Double stienno = Convert.ToDouble(tienno);
            sthanhtien = sthanhtien + stienck;

            lbthanhtien.Text = String.Format("{0:0,0}", sthanhtien);
            lbtienck.Text = String.Format("{0:0,0}", stienck);
            lbtientra.Text = String.Format("{0:0,0}", stientra);
            lbtienno.Text = String.Format("{0:0,0}", stienno); 
            
            lbmahd.Text = mahdn;
            if(ten!="")
            {
                lbBaoCaoDoanhThu.Text=ten;
            }

            String SQL = "select * from thongtinct where mact=1";
            CTL ctl = new CTL();
            DataTable dt = ctl.GETDATA(SQL);

            xrLabel4.Text = dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text = "Điện Thoại: "+dt.Rows[0]["SDT"].ToString()+"        Fax:  "+ dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = "Địa Chỉ:  "+ dt.Rows[0]["DIACHI"].ToString();
        }

    }
}
