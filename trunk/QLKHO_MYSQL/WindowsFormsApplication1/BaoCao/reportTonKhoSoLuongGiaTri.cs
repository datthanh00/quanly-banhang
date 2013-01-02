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
    public partial class reportTonKhoSoLuongGiaTri : DevExpress.XtraReports.UI.XtraReport
    {
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        public string sMaKho;
      //  public string dateNgayBD, dateNgayKT;
        public reportTonKhoSoLuongGiaTri(DataTable dt,int iNgonNgu,string sKho,string dateNgayBD, string dateNgaKT)
        {
            InitializeComponent();
            lbKho.Text = sKho;
            lbTu.Text = dateNgayBD;
            lbDen.Text = dateNgaKT;
            gridControl2.MainView = advBandedGridView3;
            gridControl2.DataSource = dt;
            if (iNgonNgu==0)
            {
                loadReSVN();
            }
            if (iNgonNgu==1)
            {
                loadReSEG();
            }
          
        }
        private void loadReSVN()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
          
            colNhomHang.Caption = resVietNam.colNhomHang.ToString();
            colNhomHang.Caption = resVietNam.colNhomHang.ToString();
            colNgay.Caption = resVietNam.colNgay.ToString();
            colMa.Caption = resVietNam.colMa.ToString();
            colDonViTInh.Caption = resVietNam.colDonViTInh.ToString();
            colHangHoa.Caption = resVietNam.colHangHoa.ToString();
            colSLDau.Caption = resVietNam.SoLuong.ToString();
            colThanhTienDau.Caption = resVietNam.TongCong.ToString();
            colSLNhap.Caption = resVietNam.SoLuong.ToString();
            colThanhTienNhap.Caption = resVietNam.TongCong.ToString();
            colSLXuat.Caption = resVietNam.SoLuong.ToString();
            colThanhTienXuat.Caption = resVietNam.TongCong.ToString();
            colSLTOn.Caption = resVietNam.SoLuong.ToString();
            colThanhTienTOn.Caption = resVietNam.TongCong.ToString();
            gridThongTin.Caption = resVietNam.gridThongTin.ToString();
            gridDauKi.Caption = resVietNam.gridDauKi.ToString();
            gridCuoiKi.Caption = resVietNam.gridCuoiKi.ToString();
            gridNhapKho.Caption = resVietNam.gridNhapKho.ToString();
            gridXuatKho.Caption = resVietNam.gridXuatKho.ToString();
            lbDiaChi.Text = resVietNam.lbDiaChi.ToString();
            lbDienThoai.Text = resVietNam.lbDienThoai.ToString();
            lbFax.Text = resVietNam.lbFax.ToString();
            lbGiamDoc.Text = resVietNam.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resVietNam.lbKeToan.ToString();
            lbNguoiLap.Text = resVietNam.lbNguoiLap.ToString();
            lbKi.Text = resVietNam.lbKiTen.ToString();
            lbKi1.Text = resVietNam.lbKiTen.ToString();
            lbKi2.Text = resVietNam.lbKiTen.ToString();
            lbTongHopXuatNhapTon.Text = resVietNam.lbTieuDeTongHop.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            lbKhoHang.Text = resVietNam.lbKhoHang.ToString();
            lbNgayBD.Text = resVietNam.NgayBD.ToString();
            lbNgayDen.Text = resVietNam.NgayKT.ToString();

            
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
         
            colNhomHang.Caption = resEngLand.colNhomHang.ToString();
            colNhomHang.Caption = resEngLand.colNhomHang.ToString();
            colNgay.Caption = resEngLand.colNgay.ToString();
            colMa.Caption = resEngLand.colMa.ToString();
            colDonViTInh.Caption = resEngLand.colDonViTInh.ToString();
            colHangHoa.Caption = resEngLand.colHangHoa.ToString();
            colSLDau.Caption = resEngLand.SoLuong.ToString();
            colThanhTienDau.Caption = resEngLand.TongCong.ToString();
            colSLNhap.Caption = resEngLand.SoLuong.ToString();
            colThanhTienNhap.Caption = resEngLand.TongCong.ToString();
            colSLXuat.Caption = resEngLand.SoLuong.ToString();
            colThanhTienXuat.Caption = resEngLand.TongCong.ToString();
            colSLTOn.Caption = resEngLand.SoLuong.ToString();
            colThanhTienTOn.Caption = resEngLand.TongCong.ToString();
            gridThongTin.Caption = resEngLand.gridThongTin.ToString();
            gridDauKi.Caption = resEngLand.gridDauKi.ToString();
            gridCuoiKi.Caption = resEngLand.gridCuoiKi.ToString();
            gridNhapKho.Caption = resEngLand.gridNhapKho.ToString();
            gridXuatKho.Caption = resEngLand.gridXuatKho.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
            lbKi.Text = resEngLand.lbKiTen.ToString();
            lbKi1.Text = resEngLand.lbKiTen.ToString();
            lbKi2.Text = resEngLand.lbKiTen.ToString();
            lbTongHopXuatNhapTon.Text = resEngLand.lbTieuDeTongHop.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();
            lbKhoHang.Text = resEngLand.lbKhoHang.ToString();
            lbNgayBD.Text = resEngLand.NgayBD.ToString();
            lbNgayDen.Text = resEngLand.NgayKT.ToString();
            

        }
        private void reportTonKhoSoLuongGiaTri_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
  
        }

        private void reportTonKhoSoLuongGiaTri_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

        }

        private void reportTonKhoSoLuongGiaTri_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

        }

    }
}
