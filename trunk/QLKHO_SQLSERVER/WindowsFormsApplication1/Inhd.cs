using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhd : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhd(DataTable list )
        {
            
            CTL ctl = new CTL();
            InitializeComponent();
            gridControl1.DataSource = list;
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
            DataTable dt2 = ctl.GETDATA(SQL);
            
            string ss1 = dt2.Rows[0][0].ToString();
            lbngaylap.Text = ss1;
             SQL = "select * from thongtinct where mact=1";
            
            DataTable dt = ctl.GETDATA(SQL);

            xrLabel4.Text = dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text = dt.Rows[0]["SDT"].ToString();
            xrLabel2.Text = dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
        }

    }
}
