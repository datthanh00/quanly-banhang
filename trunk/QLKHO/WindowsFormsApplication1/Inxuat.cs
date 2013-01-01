using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inxuat : DevExpress.XtraReports.UI.XtraReport
    {
        public Inxuat(DataTable list, string tenkh, string diachi, string tientra, string tienno, string thanhtien, string mahdx, string ten)
        {
        
            InitializeComponent();
            gridControl1.DataSource = list;
            lbDiaci.Text = diachi;
            lbtenKH.Text = tenkh;
            lbtientra.Text = tientra;
            lbtienno.Text = tienno;
            lbthanhtien.Text = thanhtien;
            lbhd.Text = mahdx;
            if (ten != "")
            {
                lbBaoCaoDoanhThu.Text = ten;
            }
            String SQL = "select * from thongtinct where mact=1";
            CTL ctl = new CTL();
            DataTable dt = ctl.GETDATA(SQL);

            xrLabel4.Text = dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text = dt.Rows[0]["SDT"].ToString();
            xrLabel2.Text = dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
        }

    }
}
