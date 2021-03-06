using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmReportTratienNCC : DevExpress.XtraReports.UI.XtraReport
    {
        public frmReportTratienNCC(DataTable dt, int iNgonNgu, string rMapc, string rHdn, string rTientra, string rTienno, string rNgaychi, string rNv)
        {
            InitializeComponent();
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            hdn.Text = rHdn;
            phieuchi.Text = rMapc;
            tientra.Text = rTientra;
            tienno.Text = rTienno;
            ngay.Text = rNgaychi;
            NhanVien.Text = rNv;
            gridControl1.DataSource = dt;
        }
        public void loadVN()
        {
            
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbDiachi.Text = Tien_VN.lbDiachi.ToString();
            lbDT.Text = Tien_VN.lbDT.ToString();
            lbFax.Text = Tien_VN.lbFax.ToString();
            lbMahdN.Text = Tien_VN.colMãhóađơnnhập.ToString();
            lbMaNV.Text = Tien_VN.colMãnhânviên.ToString();
            lbNgay.Text = Tien_VN.colNgàythu.ToString();
            lbTienno.Text = Tien_VN.lbTienno.ToString();
            lbTientra.Text = Tien_VN.lbTratien.ToString();
            colMãhóađơnnhập.Caption = Tien_VN.colMãhóađơnnhập.ToString();
            colMãnhânviên.Caption = Tien_VN.colMãnhânviên.ToString();
            colMãphiếuchi.Caption = Tien_VN.colMãphiếuchi.ToString();
            colTiềnđãtrả.Caption = Tien_VN.colTiềnđãtrả.ToString();
            colNgàychi.Caption = Tien_VN.colNgàychi.ToString();
            lbNTN.Text = Tien_VN.lbNTN.ToString();
            lbNgLap.Text = Tien_VN.lbNgLap.ToString();
            lbKhachHang.Text = Tien_VN.lbKhachHang.ToString();
            xrLbTieude.Text = Tien_VN.xrLbTieude.ToString();
        }
        public void loadEL()
        {
            
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbDiachi.Text = Tien_EL.lbDiachi.ToString();
            lbDT.Text = Tien_EL.lbDT.ToString();
            lbFax.Text = Tien_EL.lbFax.ToString();
            lbMahdN.Text = Tien_EL.colMãhóađơnnhập.ToString();
            lbMaNV.Text = Tien_EL.colMãnhânviên.ToString();
            lbNgay.Text = Tien_EL.colNgàythu.ToString();
            lbTienno.Text = Tien_EL.lbTienno.ToString();
            lbTientra.Text = Tien_EL.lbTratien.ToString();
            colMãhóađơnnhập.Caption = Tien_EL.colMãhóađơnnhập.ToString();
            colMãnhânviên.Caption = Tien_EL.colMãnhânviên.ToString();
            colMãphiếuchi.Caption = Tien_EL.colMãphiếuchi.ToString();
            colTiềnđãtrả.Caption = Tien_EL.colTiềnđãtrả.ToString();
            colNgàychi.Caption = Tien_EL.colNgàychi.ToString();
            lbNTN.Text = Tien_EL.lbNTN.ToString();
            lbNgLap.Text = Tien_EL.lbNgLap.ToString();
            lbKhachHang.Text = Tien_EL.lbKhachHang.ToString();
            xrLbTieude.Text = Tien_EL.xrLbTieude.ToString();
        }

    }
}
