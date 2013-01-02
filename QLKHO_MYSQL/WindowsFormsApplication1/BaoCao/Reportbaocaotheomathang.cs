using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Threading;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Reportbaocaotheomathang : DevExpress.XtraReports.UI.XtraReport
    {
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        public Reportbaocaotheomathang(DataTable tb)
        {
            InitializeComponent();
            gridControl1.MainView = gridView4;
            gridControl1.DataSource = tb;
        }

    }
}
