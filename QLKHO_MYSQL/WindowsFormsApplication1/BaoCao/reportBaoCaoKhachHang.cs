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
    public partial class reportBaoCaoKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        //public int iNgonNgu=1;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        Class_ctrl_thongkekho ctl = new Class_ctrl_thongkekho();
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        public reportBaoCaoKhachHang(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl1.MainView = gridView2;
            gridControl1.DataSource = dt;
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
            
            
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            colmahang.Caption = resVietNam.colmahang.ToString();
            coldonvitinh1.Caption = resVietNam.colDonViTInh1.ToString();


            colsoluongmh.Caption = resVietNam.colsoluongmh.ToString();

            // coldonvi.Caption = resVietNam.colDonViTInh.ToString();

            gridColumn1.Caption = resVietNam.colkhachhang11.ToString();
            gridColumn2.Caption = resVietNam.colmahang.ToString();
            gridColumn3.Caption = resVietNam.colsoluongmh.ToString();
            gridColumn5.Caption = resVietNam.colDonViTInh.ToString();
            gridColumn6.Caption = resVietNam.coldongia.ToString();
            colthanhtienxuat1.Caption = resVietNam.colthanhtienxuat.ToString();
            gridColumn8.Caption = resVietNam.colthanhtien.ToString();
            gridColumn9.Caption = resVietNam.colmahang.ToString();
            gridColumn10.Caption = resVietNam.colloinhuan.ToString();
            gridColumn13.Caption = resVietNam.colthueGTGT.ToString();
            gridColumn41.Caption = resVietNam.COLMAHDX.ToString();
            gridColumn42.Caption = resVietNam.coltennhomhang.ToString();
            colgiakho.Caption = resVietNam.coldongia.ToString();
            colthanhtien2.Caption = resVietNam.colthanhtien.ToString();
            colngayxuat.Caption = resVietNam.colngay11.ToString();
            colngayxuathoadon.Caption = resVietNam.colngay11.ToString();
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colthanhtien2.Caption = resEngLand.colthanhtien.ToString();
            colngayxuathoadon.Caption = resEngLand.colNgay.ToString();
            colngayxuat.Caption = resEngLand.colNgay1.ToString();
            gridColumn1.Caption = resEngLand.colkhachang.ToString();
            gridColumn2.Caption = resEngLand.colmahang.ToString();
            gridColumn3.Caption = resEngLand.colsoluongmh.ToString();
            gridColumn5.Caption = resEngLand.colDonViTInh.ToString();
            gridColumn6.Caption = resEngLand.coldongia.ToString();
            colthanhtienxuat1.Caption = resEngLand.colthanhtienxuat.ToString();
            gridColumn8.Caption = resEngLand.colthanhtien.ToString();
            gridColumn9.Caption = resEngLand.colmahang.ToString();
            gridColumn10.Caption = resEngLand.colloinhuan.ToString();
            gridColumn13.Caption = resEngLand.colthueGTGT.ToString();
            gridColumn41.Caption = resEngLand.COLMAHDX.ToString();
            gridColumn42.Caption = resEngLand.coltennhomhang.ToString();
            colgiakho.Caption = resEngLand.coldongia.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
           
            lbBaoCaoDoanhThu.Text = resEngLand.lbBaoCaoDoanhThu.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();


        }
    }
}
