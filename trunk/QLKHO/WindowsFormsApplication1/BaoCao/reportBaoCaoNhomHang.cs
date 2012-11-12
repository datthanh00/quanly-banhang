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
    public partial class reportBaoCaoNhomHang : DevExpress.XtraReports.UI.XtraReport
    {
        public int iNgonNgu;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        public reportBaoCaoNhomHang(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl1.MainView = gridView5;
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
           
            lbThongkenhmhang.Text = resVietNam.lbThongkenhmhang.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            colnhomhang.Caption = resVietNam.colNhomHang.ToString();
            colngay5.Caption = resVietNam.colNgay.ToString();
            colma5.Caption = resVietNam.colmahang.ToString();
            coltenmathang5.Caption = resVietNam.coltenmathang.ToString();
            gridColumn30.Caption = resVietNam.colDonViTInh.ToString();
            gridColumn31.Caption = resVietNam.colSLDau1.ToString();
            gridColumn33.Caption = resVietNam.colSLNhap1.ToString();
            gridColumn36.Caption = resVietNam.colSLTOn1.ToString();
            gridColumn38.Caption = resVietNam.colSLXuat1.ToString();
            colthanhtiennhomhang.Caption = resVietNam.colthanhtien.ToString();
            gridColumn40.Caption = resEngLand.colsoluong.ToString();
            colDonViTInh.Caption = resVietNam.colDonViTInh.ToString();
            coldonvitinh1.Caption = resVietNam.colDonViTInh.ToString();
            colthue.Caption = resVietNam.colthue.ToString();
            colkho.Caption = resVietNam.colkho.ToString();
            gridColumn39.Caption = resVietNam.colkho.ToString();
            colnhomhang5.Caption = resVietNam.colNhomHang.ToString();
            coldongia.Caption = resVietNam.coldongia.ToString();
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colDonViTInh.Caption = resEngLand.colDonViTInh.ToString();
            coldonvitinh1.Caption = resEngLand.colDonViTInh.ToString();
            coldongia.Caption = resEngLand.coldongia.ToString();
            colnhomhang.Caption = resEngLand.colNhomHang.ToString();
            colngay5.Caption = resEngLand.colNgay.ToString();
            colma5.Caption = resEngLand.colmahang.ToString();
            coltenmathang5.Caption = resEngLand.coltenmathang.ToString();
            gridColumn30.Caption = resEngLand.coldonvi.ToString();
            gridColumn31.Caption = resEngLand.colSLDau1.ToString();
            gridColumn33.Caption = resEngLand.colSLNhap1.ToString();
            gridColumn36.Caption = resEngLand.colSLTOn1.ToString();
            gridColumn38.Caption = resEngLand.colSLXuat1.ToString();
            colthanhtiennhomhang.Caption = resEngLand.colthanhtien.ToString();
            gridColumn40.Caption = resEngLand.colsoluong.ToString();

            colthue.Caption = resEngLand.colthue.ToString();
            colkho.Caption = resEngLand.colkho.ToString();
            gridColumn39.Caption = resEngLand.colkho.ToString();
            colnhomhang5.Caption = resEngLand.colNhomHang.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();

            lbThongkenhmhang.Text = resEngLand.lbThongkenhmhang.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();


        }
    }
}
