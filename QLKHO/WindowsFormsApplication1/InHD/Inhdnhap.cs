using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhdnhap : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdnhap(DataTable list,Boolean isCT )
        {
            if(isCT){
            InitializeComponent();
            gridControl1.MainView=gridView1;
            gridControl1.DataSource = list;
            lbBaoCaoDoanhThu.Text="Danh Sách Phân Phối Hàng";
            }
            else{
            InitializeComponent();
            gridControl1.MainView=gridCTHOADON;
            gridControl1.DataSource = list;
            lbBaoCaoDoanhThu.Text="Danh Sách xuất Hàng Ra Kho";
            
            }
        }
    }
}
