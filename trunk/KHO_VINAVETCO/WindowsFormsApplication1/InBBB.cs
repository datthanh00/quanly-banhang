using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InBBBG : DevExpress.XtraReports.UI.XtraReport
    {
        public InBBBG(DataTable list)
        {
            InitializeComponent();
            gridControl1.DataSource = list;
          
            Form f = new Form();
            f.Controls.Add(this.gridControl1);
            f.Location = new Point(2000, 2000);
            gridCTHOADON.BestFitColumns();
            f.Controls.Clear();
            f.Dispose();
        }

    }
}
