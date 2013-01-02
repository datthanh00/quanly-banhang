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
    public partial class reportBaoCaoMathang : DevExpress.XtraReports.UI.XtraReport
    {
        public int iNgonNgu;

        //,string sLoaiThoiGian, DateTime dateNgayBD, DateTime dateNgaKT
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();
        public reportBaoCaoMathang(DataTable dt, int iNgonNgu)
        {
            
            InitializeComponent();
            gridControl1.MainView = gridView4;
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

            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
            lbDiaChi.Text = resVietNam.lbDiaChi.ToString();
            lbDienThoai.Text = resVietNam.lbDienThoai.ToString();
            lbFax.Text = resVietNam.lbFax.ToString();
            lbGiamDoc.Text = resVietNam.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resVietNam.lbKeToan.ToString();
            lbNguoiLap.Text = resVietNam.lbNguoiLap.ToString();
           
            lbBaoCaoMATHANG.Text = resVietNam.lbBaoCaoMATHANG.ToString();
            lbNgayThang.Text = resVietNam.lbNgayThang.ToString();
            coltenkh1.Caption = resVietNam.colkhachhang11.ToString();
            //coltenkh1.Caption = resVietNam.colkhachhang.t
            coltenmathang5.Caption = resVietNam.coltenmathang.ToString();
            gridColumn16.Caption = resVietNam.coltenmathang.ToString();
            gridColumn17.Caption = resVietNam.colsoluong.ToString();
            gridColumn18.Caption = resVietNam.colDonViTInh.ToString();
            gridColumn19.Caption = resVietNam.coldongia.ToString();
            gridColumn20.Caption = resVietNam.colthanhtien.ToString();
            gridColumn21.Caption = resVietNam.colthanhtien.ToString();
            colloinhuan.Caption = resVietNam.colloinhuan.ToString();
            gridColumn22.Caption = resVietNam.colmahang.ToString();
            gridColumn23.Caption = resVietNam.colthueGTGT.ToString();
            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
            gridColumn25.Caption = resVietNam.colNgay.ToString();
            colkho.Caption = resVietNam.colkho.ToString();
            colsongayhethan.Caption = resVietNam.colsongayconhan.ToString();
            colhansudung.Caption = resVietNam.colhansudung.ToString();
            coltennhomhang.Caption = resVietNam.coltennhomhang.ToString();
        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            coltennhomhang.Caption = resEngLand.coltennhomhang.ToString();
            colsongayhethan.Caption = resEngLand.colsongayconhan.ToString();
            colhansudung.Caption = resEngLand.colhansudung.ToString();
            coltenmathang5.Caption = resEngLand.coltenmathang.ToString();
            gridColumn16.Caption = resEngLand.coltenmathang.ToString();
            gridColumn17.Caption = resEngLand.colsoluong.ToString();
            gridColumn18.Caption = resEngLand.colDonViTInh.ToString();
            gridColumn19.Caption = resEngLand.coldongia.ToString();
            gridColumn20.Caption = resEngLand.colthanhtien.ToString();
            gridColumn21.Caption = resEngLand.colthanhtien.ToString();
            colloinhuan.Caption = resEngLand.colloinhuan.ToString();
            gridColumn22.Caption = resEngLand.colmahang.ToString();
            gridColumn23.Caption = resEngLand.colthueGTGT.ToString();
           
            gridColumn25.Caption = resVietNam.colNgay.ToString();
            colkho.Caption = resVietNam.colkho.ToString();
            lbDiaChi.Text = resEngLand.lbDiaChi.ToString();
            lbDienThoai.Text = resEngLand.lbDienThoai.ToString();
            lbFax.Text = resEngLand.lbFax.ToString();
            lbGiamDoc.Text = resEngLand.lbGiamDoc.ToString();
            lbKeToanTruong.Text = resEngLand.lbKeToan.ToString();
            lbNguoiLap.Text = resEngLand.lbNguoiLap.ToString();
            
            lbBaoCaoMATHANG.Text = resEngLand.lbBaoCaoMATHANG.ToString();
            lbNgayThang.Text = resEngLand.lbNgayThang.ToString();


        }
    }
}
