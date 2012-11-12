using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1.HoaDonNhap
{
    public partial class In : DevExpress.XtraReports.UI.XtraReport
    {
        public In(ArrayList list,string mancc, string tenncc,double tientra, double tienno, double thanhtien, string mahdn )
        {
            InitializeComponent();
            gridControl1.DataSource = list;
            lbMaNCC.Text = mancc;
            lbTenNCC.Text = tenncc;
            lbtientra.Text = tientra.ToString();
            lbtienno.Text = tienno.ToString();
            lbthanhtien.Text = thanhtien.ToString();
            lbmahd.Text = mahdn;
        }

    }
}
