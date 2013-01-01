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
        }

    }
}
