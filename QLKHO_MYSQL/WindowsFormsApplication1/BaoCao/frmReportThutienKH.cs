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
    public partial class frmReportThutienKH : DevExpress.XtraReports.UI.XtraReport
    {
        public frmReportThutienKH(DataTable dt, int iNgonNgu, string rMapt, string rHdx, string rTientra, string rTienno, string rNgaythu, string rNv)
        {
            InitializeComponent();
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            hdx.Text = rHdx;
            phieuthu.Text = rMapt;
            tienno.Text = rTienno;
            tientra.Text = rTientra;
            ngay.Text = rNgaythu;
            NhanVien.Text = rNv;
            gridControl1.DataSource = dt;
        }
        public void loadVN()
        {
            
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbDiachi.Text = Tien_VN.lbDiachi.ToString();
            lbDT.Text = Tien_VN.lbDT.ToString();
            lbFax.Text = Tien_VN.lbFax.ToString();
            lbMahdx.Text = Tien_VN.colMãhóađơnxuất.ToString();
            lbMaNV.Text = Tien_VN.colMãnhânviên.ToString();
            lbNgay.Text = Tien_VN.colNgàythu.ToString();
            lbTienno.Text = Tien_VN.lbTienno.ToString();
            lbTientra.Text = Tien_VN.lbTratien.ToString();
            colMãhóađơnxuất.Caption = Tien_VN.colMãhóađơnxuất.ToString();
            colMãnhânviên.Caption = Tien_VN.colMãnhânviên.ToString();
            colMãphiếuthu.Caption = Tien_VN.colMãphiếuthu.ToString();
            colNgàythu.Caption = Tien_VN.colNgàythu.ToString();
            colTiềnđãtrả.Caption = Tien_VN.colTiềnđãtrả.ToString();
            lbNTN.Text = Tien_VN.lbNTN.ToString();
            lbNgLap.Text = Tien_VN.lbNgLap.ToString();
            lbKhachHang.Text = Tien_VN.lbKhachHang.ToString();
            xrLbTieude1.Text = Tien_VN.xrLbTieude1.ToString();
        }
        public void loadEL()
        {
            
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbDiachi.Text = Tien_EL.lbDiachi.ToString();
            lbDT.Text = Tien_EL.lbDT.ToString();
            lbFax.Text = Tien_EL.lbFax.ToString();
            lbMahdx.Text = Tien_EL.colMãhóađơnxuất.ToString();
            lbMaNV.Text = Tien_EL.colMãnhânviên.ToString();
            lbNgay.Text = Tien_EL.colNgàythu.ToString();
            lbTienno.Text = Tien_EL.lbTienno.ToString();
            lbTientra.Text = Tien_EL.lbTratien.ToString();
            colMãhóađơnxuất.Caption = Tien_EL.colMãhóađơnxuất.ToString();
            colMãnhânviên.Caption = Tien_EL.colMãnhânviên.ToString();
            colMãphiếuthu.Caption = Tien_EL.colMãphiếuthu.ToString();
            colNgàythu.Caption = Tien_EL.colNgàythu.ToString();
            colTiềnđãtrả.Caption = Tien_EL.colTiềnđãtrả.ToString();
            lbNTN.Text = Tien_EL.lbNTN.ToString();
            lbNgLap.Text = Tien_EL.lbNgLap.ToString();
            lbKhachHang.Text = Tien_EL.lbKhachHang.ToString();
            xrLbTieude1.Text = Tien_EL.xrLbTieude1.ToString();
        }

    }
}
