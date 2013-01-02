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
    public partial class Reporttheoloinhuan : DevExpress.XtraReports.UI.XtraReport
    {
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        public Reporttheoloinhuan(DataTable dt)
        {
            InitializeComponent();
            gridControl1.MainView = gridView1;
            gridControl1.DataSource = dt;
        }

    }
}
