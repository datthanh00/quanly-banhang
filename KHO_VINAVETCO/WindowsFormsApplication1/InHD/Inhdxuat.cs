using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inhdxuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdxuat(DataTable list2 )
        {
            InitializeComponent();
            gridControl2.DataSource = list2;
            lbtonghopxh.Text="Danh Sách xuất Hàng Ra Kho";

            String SQL = "select * from thongtinct where mact=1";
            CTL  ctl =new CTL();
            DataTable dt = ctl.GETDATA(SQL);

            xrLabel4.Text=dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text=dt.Rows[0]["SDT"].ToString();
            xrLabel2.Text = dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            lbintrai.Text = dt.Rows[0]["TTINTRAI"].ToString();
            lbttinphai.Text = dt.Rows[0]["TTINPHAI"].ToString();
            lbingiua.Text = dt.Rows[0]["TTINGIUA"].ToString();

            Form f = new Form();
            f.Controls.Add(this.gridControl2);
            f.Location = new Point(2000, 2000);
            gridView2.BestFitColumns();
            f.Controls.Clear();
            f.Dispose();
        }
    }
}
