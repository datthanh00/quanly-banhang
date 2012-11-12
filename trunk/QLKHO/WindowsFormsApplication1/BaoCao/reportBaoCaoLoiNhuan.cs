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
    public partial class reportBaoCaoLoiNhuan : DevExpress.XtraReports.UI.XtraReport
    {
        //public int iNgonNgu=1;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        Class_ctrl_thongkekho ctl = new Class_ctrl_thongkekho();
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        public reportBaoCaoLoiNhuan(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl1.MainView = gridView1;
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


            colmahang.Caption = resVietNam.colmahang.ToString();
            coldonvitinh1.Caption = resVietNam.colDonViTInh1.ToString();
            colgiamua1.Caption = resVietNam.colgiamua.ToString();

            colsoluongmh.Caption = resVietNam.colsoluongmh.ToString();

            // coldonvi.Caption = resVietNam.colDonViTInh.ToString();
            colthanhtien2.Caption = resVietNam.colthanhtien.ToString();
            coldongia.Caption = resVietNam.coldongia.ToString();
            colngayxuat.Caption = resVietNam.colNgay.ToString();
            gridColumn1.Caption = resVietNam.colkhachhang11.ToString();

            colthanhtien.Caption = resVietNam.coltienban.ToString();
            COLGIAVON.Caption = resVietNam.COLGIAVON.ToString();
            colmahang.Caption = resVietNam.colmahang.ToString();

            colloinhuan.Caption = resVietNam.colloinhuan.ToString();
            colthueGTGT.Caption = resVietNam.colthueGTGT.ToString();
            COLMAHDX.Caption = resVietNam.COLMAHDX.ToString();
            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
            colmathang.Caption = resVietNam.colmathang.ToString();
            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
            colnhomhang.Caption = resVietNam.colNhomHang.ToString();
            colLoiNhuanG1.Caption = resVietNam.colloinhuan.ToString();
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colmahang.Caption = resVietNam.colmahang.ToString();
            coldonvitinh1.Caption = resVietNam.colDonViTInh1.ToString();


            colsoluongmh.Caption = resVietNam.colsoluongmh.ToString();

            // coldonvi.Caption = resVietNam.colDonViTInh.ToString();

            colgiamua1.Caption = resEngLand.colgiamua.ToString();
            coldonvitinh1.Caption = resEngLand.coldonvi.ToString();
            colngayxuat.Caption = resEngLand.colngayxuat.ToString();

            colkhachang.Caption = resEngLand.colkhachang.ToString();
            colmahang.Caption = resEngLand.colmahang.ToString();

            colsoluongmh.Caption = resEngLand.colsoluongmh.ToString();

            // coldonvi.Caption = resEngLand.colDonViTInh.ToString();
            colthanhtien2.Caption = resEngLand.colthanhtien.ToString();
            coldongia.Caption = resEngLand.coldongia.ToString();

            colthanhtien.Caption = resEngLand.coltienban.ToString();
            COLGIAVON.Caption = resEngLand.COLGIAVON.ToString();
            colmahang.Caption = resEngLand.colmahang.ToString();

            colloinhuan.Caption = resEngLand.colloinhuan.ToString();
            colthueGTGT.Caption = resEngLand.colthueGTGT.ToString();
            COLMAHDX.Caption = resEngLand.COLMAHDX.ToString();
            coltennhomhang.Caption = resEngLand.coltennhomhang.ToString();

            colmathang.Caption = resEngLand.colmathang.ToString();
            
            colnhomhang.Caption = resEngLand.colNhomHang.ToString();
            colLoiNhuanG1.Caption = resEngLand.colloinhuan.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
           
            lbBaoCaoLOINHUAN.Text = resEngLand.lbBaoCaoDoanhThu.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();


        }
    }
}
