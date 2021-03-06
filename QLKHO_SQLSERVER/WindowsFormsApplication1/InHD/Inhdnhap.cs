using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhdnhap : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdnhap(DataTable list )
        {
         
            InitializeComponent();
            gridControl1.MainView=gridView1;
            gridControl1.DataSource = list;
            lbBaoCaoDoanhThu.Text="Danh Sách Phân Phối Hàng";
            
            String SQL = "select * from thongtinct where mact=1";
            CTL  ctl =new CTL();
            DataTable dt = ctl.GETDATA(SQL);

            xrLabel4.Text=dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text=dt.Rows[0]["SDT"].ToString();
            xrLabel2.Text = dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();

        }
    }
}
