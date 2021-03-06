using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class lbinphai : DevExpress.XtraReports.UI.XtraReport
    {
        public lbinphai(DataTable list, string tenkh, string diachi, string tientra, string tienno, string thanhtien, string tienck, string mahdx, string ten)
        {
        
            InitializeComponent();
            gridControl1.DataSource = list;
            lbDiaci.Text = diachi;
            lbtenKH.Text = tenkh;

            Double sthanhtien = Convert.ToDouble(thanhtien);
            Double stienck = Convert.ToDouble(tienck);
            Double stientra = Convert.ToDouble(tientra);
            Double stienno = Convert.ToDouble(tienno);
            sthanhtien = sthanhtien + stienck;

            lbthanhtien.Text = String.Format("{0:0,0}", sthanhtien);
            lbtienck.Text = String.Format("{0:0,0}", stienck);
            lbtientra.Text = String.Format("{0:0,0}", stientra);
            lbtienno.Text = String.Format("{0:0,0}", stienno); 
           
            lbhd.Text = mahdx;
            if (ten != "")
            {
                lbBaoCaoDoanhThu.Text = ten;
            }
            String SQL = "select * from thongtinct where mact=1";
            CTL ctl = new CTL();
            DataTable dt = ctl.GETDATA(SQL);
            SQL = "SELECT convert(varchar,NGAYXUAT,103) FROM HOADONXUAT WHERE MAHDX='" + mahdx + "'";

            DataTable DT2 = ctl.GETDATA(SQL);
            LBNGAY.Text = "Ngày: " + DT2.Rows[0][0].ToString();

            xrLabel4.Text = dt.Rows[0]["TENCT"].ToString();
            xrLabel3.Text = "Điện Thoại:  "+dt.Rows[0]["SDT"].ToString()+"       Fax:  "+ dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = "Địa Chỉ:  "+dt.Rows[0]["DIACHI"].ToString();
            lbintrai.Text=dt.Rows[0]["TTINTRAI"].ToString();
            lbttinphai.Text = dt.Rows[0]["TTINPHAI"].ToString();
            lbingiua.Text = dt.Rows[0]["TTINGIUA"].ToString();

            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["HSD"].Visible = false;
            }
            if (!PublicVariable.isKHOILUONG)
            {
                gridCTHOADON.Columns["KHOILUONG"].Visible = false;
            }
            Form f = new Form();
            f.Controls.Add(this.gridControl1);
            f.Location = new Point(2000, 2000);
            gridCTHOADON.BestFitColumns();
            f.Controls.Clear();
            f.Dispose();
        }

    }
}
