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
        public Inhdnhap(DataTable list,DataTable list2 )
        {
         
            InitializeComponent();
            gridControl1.MainView=gridView1;
            gridControl1.DataSource = list;
            lbBaoCaoDoanhThu.Text="Danh Sách Phân Phối Hàng";
            
           
            //InitializeComponent();
            gridControl2.MainView=gridView2;
            gridControl2.DataSource = list2;
            lbtonghopxh.Text="Danh Sách xuất Hàng Ra Kho";

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
