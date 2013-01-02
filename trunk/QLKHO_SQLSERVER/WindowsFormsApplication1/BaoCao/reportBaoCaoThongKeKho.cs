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
    public partial class reportBaoCaoThongKeKho : DevExpress.XtraReports.UI.XtraReport
    {
        //public int iNgonNgu=1;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        ClassThongke_mathang_dal dto = new ClassThongke_mathang_dal();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        public reportBaoCaoThongKeKho(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl1.MainView = gridView3;
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

            gridColumn12.Caption = resVietNam.colNhomHang.ToString();
            colNgay.Caption = resVietNam.colNgay.ToString();
            colMa.Caption = resVietNam.colmahang.ToString();
            colHangHoa.Caption = resVietNam.coltenmathang.ToString();
            colDonViTInh.Caption = resVietNam.colDonViTInh.ToString();
            colSLDau1.Caption = resVietNam.colSLDau1.ToString();
            colSLNhap1.Caption = resVietNam.colSLNhap1.ToString();
            colSLXuat1.Caption = resVietNam.colSLXuat1.ToString();
            colSLTOn1.Caption = resVietNam.colSLTOn1.ToString();
            gridColumn14.Caption = resVietNam.colthanhtien.ToString();
            gridColumn44.Caption = resVietNam.colsoluong.ToString();
            gridColumn45.Caption = resVietNam.colthueGTGT.ToString();
            colkho.Caption = resEngLand.colkho.ToString();
            colthue.Caption = resVietNam.colthue.ToString();
            colkho.Caption = resVietNam.colkho.ToString();
            gridColumn39.Caption = resVietNam.colkho.ToString();
            colnhomhang5.Caption = resVietNam.colNhomHang.ToString();
            lbDiaChi.Text = resVietNam.lbDiaChi.ToString();
            lbDienThoai.Text = resVietNam.lbDienThoai.ToString();
            lbFax.Text = resVietNam.lbFax.ToString();
            lbGiamDoc.Text = resVietNam.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resVietNam.lbKeToan.ToString();
            lbNguoiLap.Text = resVietNam.lbNguoiLap.ToString();
            lbKi.Text = resVietNam.lbKiTen.ToString();
            lbKi1.Text = resVietNam.lbKiTen.ToString();
            lbKi2.Text = resVietNam.lbKiTen.ToString();
            lbBaoCaotheokho.Text = resVietNam.lbBaoCaotheokho.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();

        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
            lbKi.Text = resEngLand.lbKiTen.ToString();
            lbKi1.Text = resEngLand.lbKiTen.ToString();
            lbKi2.Text = resEngLand.lbKiTen.ToString();
            lbBaoCaotheokho.Text = resEngLand.lbBaoCaotheokho.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();

            gridColumn12.Caption = resEngLand.colNhomHang.ToString();
            colNgay.Caption = resEngLand.colNgay.ToString();
            colMa.Caption = resEngLand.colmahang.ToString();
            colHangHoa.Caption = resEngLand.coltenmathang.ToString();
            colDonViTInh.Caption = resEngLand.colDonViTInh.ToString();
            colSLDau1.Caption = resEngLand.colSLDau1.ToString();
            colSLNhap1.Caption = resEngLand.colSLNhap1.ToString();
            colSLXuat1.Caption = resEngLand.colSLXuat1.ToString();
            colSLTOn1.Caption = resEngLand.colSLTOn1.ToString();
            gridColumn14.Caption = resEngLand.colthanhtien.ToString();
            gridColumn44.Caption = resEngLand.colsoluong.ToString();
            gridColumn45.Caption = resEngLand.colthueGTGT.ToString();
            colkho.Caption = resEngLand.colkho.ToString();
            //coltenkh1.Caption = resVietNam.colkhachhang.t
            
            
        }
    }
}
