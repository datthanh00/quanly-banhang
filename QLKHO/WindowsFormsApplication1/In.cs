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
        public In(DataTable list,string mancc, string tenncc,double tientra, double tienno, double thanhtien, string mahdn,string ten )
        {
            InitializeComponent();
            gridControl1.DataSource = list;
            lbMaNCC.Text = mancc;
            lbTenNCC.Text = tenncc;
            lbtientra.Text = tientra.ToString();
            lbtienno.Text = tienno.ToString();
            lbthanhtien.Text = thanhtien.ToString();
            lbmahd.Text = mahdn;
            if(ten!="")
            {
                lbBaoCaoDoanhThu.Text=ten;
            }
        }

    }
}
