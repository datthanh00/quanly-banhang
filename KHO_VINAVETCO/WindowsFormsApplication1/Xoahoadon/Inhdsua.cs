using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhdsua : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdsua(string MAHD, string LYDOSUA,DataTable LISTDAU, DataTable LISTCUOI)
        {
            InitializeComponent();
            CTL ctl = new CTL();
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
            DataTable dt2 = ctl.GETDATA(SQL);
            string ss1 = "Hôm nay ngày: "+dt2.Rows[0][0].ToString();
            lbngaylap.Text = ss1;

            lbnoidung.Text="Sửa Chứng từ: "+MAHD;
           
            lblydoxoa.Text = "Lý Do Sửa: " + LYDOSUA;
            gridControl1.DataSource = LISTDAU;
            gridControl2.DataSource = LISTCUOI;

           
          

        }

    }
}
