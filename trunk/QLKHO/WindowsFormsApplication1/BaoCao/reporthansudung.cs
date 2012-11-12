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
    public partial class reporthansudung : DevExpress.XtraReports.UI.XtraReport
    {
        public int iNgonNgu;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        public reporthansudung(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
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

            //lbBaoCaoMATHANG.Text = resVietNam.lbBaoCaoMATHANG.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            //coltenkh1.Caption = resVietNam.colkhachhang11.ToString();
            //colmahang.Caption = resVietNam.colmahang.ToString();

            colmamhathang.Caption = resVietNam.colmahang.ToString();
            colhinhanh.Caption = resVietNam.colhinhanh.ToString();
            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
            coltenmathang.Caption = resVietNam.coltenmathang.ToString();
            coltendonvi.Caption = resVietNam.coltendonvi.ToString();
            colsoluong.Caption = resVietNam.colsoluong.ToString();
            colhansudung.Caption = resVietNam.colhansudung.ToString();
            colthanhtiennhap.Caption = resVietNam.colthanhtiennhap.ToString();
            colgiaban.Caption = resVietNam.colgiaban.ToString();
            colmota.Caption = resVietNam.colmota.ToString();
            coltinhtrang.Caption = resVietNam.coltinhtrang.ToString();
            colthue.Caption = resVietNam.colthue.ToString();
            colthanhtienxuat.Caption = resVietNam.colthanhtienxuat.ToString();
            colgiamua.Caption = resVietNam.colgiamua.ToString();
            colsongayhethan.Caption = resVietNam.colsongayconhan.ToString();
           // lbTongHopXuatNhapTon.Text = resVietNam.lbTieuDeTongHop.ToString();
            
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

       
            //colmahang.Caption = resVietNam.colmahang.ToString();
            colmamhathang.Caption = resEngLand.colmahang.ToString();
            colhinhanh.Caption = resEngLand.colhinhanh.ToString();
            coltennhomhang.Caption = resEngLand.coltennhomhang.ToString();
            coltenmathang.Caption = resEngLand.coltenmathang.ToString();
            coltendonvi.Caption = resEngLand.coltendonvi.ToString();
            colsoluong.Caption = resEngLand.colsoluong.ToString();
            colhansudung.Caption = resEngLand.colhansudung.ToString();
            colthanhtiennhap.Caption = resEngLand.colthanhtiennhap.ToString();
            colgiaban.Caption = resEngLand.colgiaban.ToString();
            colmota.Caption = resEngLand.colmota.ToString();
            coltinhtrang.Caption = resEngLand.coltinhtrang.ToString();
            colthue.Caption = resEngLand.colthue.ToString();
            colthanhtienxuat.Caption = resEngLand.colthanhtienxuat.ToString();
            colgiamua.Caption = resEngLand.colgiamua.ToString();
            
            colsongayhethan.Caption = resEngLand.colsongayconhan.ToString();


            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();

            lbBaoCaoDoanhThu.Text = resEngLand.lbBaoCaoMATHANG.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();

        }
    }
}
