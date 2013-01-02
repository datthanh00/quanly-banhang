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
    public partial class reportBaoCaoDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        //public int iNgonNgu=1;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        public reportBaoCaoDoanhThu(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl6.DataSource = dt;
            if (iNgonNgu==1)
            {
                loadReSEG();
            }
            if (iNgonNgu==0)
            {
                loadReSVN();
            }
        }
        private void loadReSVN()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

            
            lbDiaChi.Text = resVietNam.lbDiaChi.ToString();
            lbDienThoai.Text = resVietNam.lbDienThoai.ToString();
            lbFax.Text = resVietNam.lbFax.ToString();
            lbGiamDoc.Text = resVietNam.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resVietNam.lbKeToan.ToString();
            lbNguoiLap.Text = resVietNam.lbNguoiLap.ToString();
            lbKi.Text = resVietNam.lbKiTen.ToString();
            lbKi1.Text = resVietNam.lbKiTen.ToString();
            lbKi2.Text = resVietNam.lbKiTen.ToString();
            lbBaoCaoDoanhThu.Text = resVietNam.lbBaoCaoDoanhThu.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            colTongDanhThu.Caption = resVietNam.colTongDanhThu.ToString();
            colKhucVuc.Caption = resVietNam.colTenKhuVuc.ToString();
            ColTenKhachHang.Caption = resVietNam.colKhachHang.ToString();
            colNgayXuat.Caption = resVietNam.colNgay.ToString();
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colTongDanhThu.Caption = resEngLand.colTongDanhThu.ToString();
            colKhucVuc.Caption = resEngLand.colTenKhuVuc.ToString();
            ColTenKhachHang.Caption = resEngLand.colKhachHang.ToString();
            colNgayXuat.Caption = resEngLand.colNgay.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
            lbKi.Text = resEngLand.lbKiTen.ToString();
            lbKi1.Text = resEngLand.lbKiTen.ToString();
            lbKi2.Text = resEngLand.lbKiTen.ToString();
            lbBaoCaoDoanhThu.Text = resEngLand.lbBaoCaoDoanhThu.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();


        }
    }
}
