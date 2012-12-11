using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid;


namespace WindowsFormsApplication1
{
    public partial class frmBangKeXuatKhoTheoKHAchhangHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmBangKeXuatKhoTheoKHAchhangHangHoa()
        {
            InitializeComponent();
        }

        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
       public  int iNgonNgu ;
     
       

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            frm.LoadVI += new frmMain.Translate(loadcbVietNam);
            ////frm.LoadVI += new frmMain.Translate(loadGird);

            frm.LoadVI += new frmMain.Translate(loadReSVN);
            frm.LoadEN += new frmMain.Translate(loadcbEgLish);
            frm.LoadEN += new frmMain.Translate(loadReSEG);

           // loadgirdlookup();

            if (iNgonNgu == 0)
            {
             
                loadReSVN();
                loadcbVietNam();

            }
            else
            {
                loadReSEG();
                loadcbEgLish();

            }

            //loadGird();
            loadGird1();
            loadGird2();
            loadGird3();
            loadGird5();
        }

        //private void loadgirdlookup()
        //{
        //    glKhoHang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
        //    glKhoHang.Properties.DataSource = dvdropdow;
        //    glKhoHang.Properties.DisplayMember = "TENKHO";
        //    glKhoHang.Properties.ValueMember = "MAKHO";
        //    glKhoHang.Properties.View.BestFitColumns();
        //    glKhoHang.Properties.PopupFormWidth = 300;
        //    glKhoHang.Properties.DataSource = ctr1.getTonKho(dto);
        //}
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
        DataTable dt = new DataTable();
        DataView dvdropdow;
        private void loadGird1()
        {
            
            //dto.MAKHO = gView.GetFocusedRowCellValue("MAKHO").ToString();
            dto.NGAYBDKHO = dateTu.Text;
            dto.NGAYKTKHO = dateDen.Text;
            gridControl1.MainView = gridView1;
            dt = ctr1.LOINHUANKINHDOANH(dto);
            gridControl1.DataSource = dt;
                
            

        }
        private void loadGird2()
        {
            dto.NGAYBDKHO = dateTu.Text;
            dto.NGAYKTKHO = dateDen.Text;
            gridControl1.MainView = gridView2;

            dt = ctr1.thongkhetheokhachang(dto);
               gridControl1.DataSource = dt;
        }
        private void loadGird3()
        {
            dto.NGAYBDKHO = dateTu.Text;
            dto.NGAYKTKHO = dateDen.Text;
            gridControl1.MainView = gridView3;
           
               dt = ctr1.getBAOCAOTHEOKHO(dto);
               gridControl1.DataSource = dt;
        }
        private void loadGird4()
        {
            dto.NGAYBDKHO = dateTu.Text;
            dto.NGAYKTKHO = dateDen.Text;
            gridControl1.MainView = gridView4;
           
               dt = ctr1.gethieuquakinhdoanh(dto);
               gridControl1.DataSource = dt;
               DevExpress.XtraGrid.StyleFormatCondition cn1;
               //cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView4.Columns["SONGAYHETHANH"], null, 0);
               cn1 = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView4.Columns["SOLUONGMH"], null, 0);
               cn1 = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Equal, gridView4.Columns["SOLUONGMH"], null, 0);

               //cn.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
               //cn.Appearance.ForeColor = SystemColors.ControlDark;
               cn1.Appearance.BackColor = Color.Yellow;
               gridView4.FormatConditions.Add(cn1);
               cn1.ApplyToRow = true;
               //gridView4.FormatConditions.Add(cn1);
               gridView4.BestFitColumns();
        }
        private void loadGird5()
        {
            dto.NGAYBDKHO = dateTu.Text;
            dto.NGAYKTKHO = dateDen.Text;
            gridControl1.MainView = gridView5;

            dt = ctr1.gethieuquakinhdoanh(dto);
              gridControl1.DataSource = dt;
              DevExpress.XtraGrid.StyleFormatCondition cn;
              //cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView4.Columns["SONGAYHETHANH"], null, 0);
              cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView5.Columns["SOLUONGMH"], null, 0);
              cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Equal, gridView5.Columns["SOLUONGMH"], null, 0);

              //cn.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
              //cn.Appearance.ForeColor = SystemColors.ControlDark;
              cn.Appearance.BackColor = Color.YellowGreen;
              //gridView5.FormatConditions.Add(cn);
              cn.ApplyToRow = true;
              gridView5.FormatConditions.Add(cn);
              gridView5.BestFitColumns();
        }
       
       
  
        
       

       

      

        private void loadReSVN()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resVietNam.btXem.ToString();
            btIn.Text = resVietNam.btIn.ToString();
            btXuat.Text = resVietNam.btXuat.ToString();
            btdong.Text = resEngLand.btDong.ToString();
            //colkhachang.Caption = resEngLand
            //colngay.Caption = resVietNam.colNgay1.ToString();
            colmahang.Caption = resVietNam.colmahang.ToString();
            coldonvitinh1.Caption = resVietNam.colDonViTInh1.ToString();
            colgiamua1.Caption = resVietNam.colgiamua.ToString();

            colsoluongmh.Caption = resVietNam.colsoluongmh.ToString();

            // coldonvi.Caption = resVietNam.colDonViTInh.ToString();
            colthanhtien2.Caption = resVietNam.colthanhtien.ToString();
            coldongia.Caption = resVietNam.colgiaban.ToString();
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
            //--------------------------------gỉdview3
            // gridColumn1.Caption = resVietN
            colngayxuathoadon.Caption = resVietNam.colngay11.ToString();
            colngayxuat.Caption = resVietNam.colNgay.ToString();
            gridColumn2.Caption = resVietNam.coltenmathang.ToString();
            gridColumn3.Caption = resVietNam.colsoluongmh.ToString();
            gridColumn5.Caption = resVietNam.colDonViTInh.ToString();
            gridColumn6.Caption = resVietNam.colgiaban.ToString();
            colthanhtienxuat1.Caption = resVietNam.colthanhtien.ToString();
            gridColumn8.Caption = resVietNam.colthanhtien.ToString();
            gridColumn9.Caption = resVietNam.colmahang.ToString();
            gridColumn10.Caption = resVietNam.colloinhuan.ToString();
            gridColumn13.Caption = resVietNam.colthueGTGT.ToString();
            gridColumn41.Caption = resVietNam.COLMAHDX.ToString();
            gridColumn42.Caption = resVietNam.coltennhomhang.ToString();
            //===================gird33333333333
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
            // colkho.Caption = resVietNam.

            //--------------------------------
            coltenkh1.Caption = resVietNam.colkhachhang11.ToString();
            //coltenkh1.Caption = resVietNam.colkhachhang.t
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
            //-----------------------------------
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
            gridColumn40.Caption = resVietNam.colsoluong.ToString();
            colthue.Caption = resVietNam.colthue.ToString();
            colkho.Caption = resVietNam.colkho.ToString();
            gridColumn39.Caption = resVietNam.colkho.ToString();
            colnhomhang5.Caption = resVietNam.colNhomHang.ToString();
            loinhuan.Caption = resVietNam.linktheoloinhuan.ToString();
            Khachhang.Caption = resVietNam.linktheokhachhang.ToString();
            tenhang.Caption = resVietNam.linktheomathang.ToString();
            Theokho.Caption = resVietNam.linhtheokho.ToString();
            TheoNhom.Caption = resVietNam.linktheonhomhang.ToString();
            navthongke.Caption = resVietNam.navthongke.ToString();
            colgiakho.Caption = resVietNam.coldongia.ToString();
            colgia5.Caption = resVietNam.coldongia.ToString();
            colhansudung.Caption = resVietNam.colhansudung.ToString();
        }

        

        private void loadReSEG()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resEngLand.btXem.ToString();

         colNgay.Caption = resEngLand.colNgay.ToString();
           navthongke.Caption = resEngLand.navthongke.ToString();
            //navthongke.Caption = navthongke.Caption = resVietNam.navthongke.ToString();.navthongke.ToString();
            //coltennhomhang.Caption = navthongke.Caption = resVietNam.navthongke.ToString();.coltennhomhang.ToString();
           colgiamua1.Caption = resEngLand.colgiamua.ToString();
            coldonvitinh1.Caption = resEngLand.coldonvi.ToString();
            colngayxuat.Caption = resEngLand.colngayxuat.ToString();

            colkhachang.Caption = resEngLand.colkhachang.ToString();
            colmahang.Caption = resEngLand.colmahang.ToString();

            colsoluongmh.Caption = resEngLand.colsoluongmh.ToString();

           // coldonvi.Caption = resEngLand.colDonViTInh.ToString();
            colthanhtien2.Caption = resEngLand.colthanhtien.ToString();
            coldongia.Caption = resEngLand.colgiaban.ToString();

            colthanhtien.Caption = resEngLand.coltienban.ToString();
            COLGIAVON.Caption = resEngLand.COLGIAVON.ToString();
            colmahang.Caption = resEngLand.colmahang.ToString();

            colloinhuan.Caption = resEngLand.colloinhuan.ToString();
            colthueGTGT.Caption = resEngLand.colthueGTGT.ToString();
            COLMAHDX.Caption = resEngLand.COLMAHDX.ToString();
            coltennhomhang.Caption = resEngLand.coltennhomhang.ToString();

            colmathang.Caption = resEngLand.colmathang.ToString();
            btdong.Text = resEngLand.btDong.ToString();

            btIn.Text = resEngLand.btIn.ToString();
            btXuat.Text = resEngLand.btXuat.ToString();
            colnhomhang.Caption = resEngLand.colNhomHang.ToString();
            colLoiNhuanG1.Caption = resEngLand.colloinhuan.ToString();
            //----------------------------------
            colngayxuathoadon.Caption = resEngLand.colNgay.ToString();
            colngayxuat.Caption = resEngLand.colNgay.ToString();
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
            //-----------------------------------
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
            //-------------------------------------
            coltenkh1.Caption = resEngLand.colkhachang.ToString();
            //coltenkh1.Caption = resVietNam.colkhachhang.t
            gridColumn16.Caption = resEngLand.coltenmathang.ToString();
            gridColumn17.Caption = resEngLand.colsoluong.ToString();
            gridColumn18.Caption = resEngLand.colDonViTInh.ToString();
            gridColumn19.Caption = resEngLand.coldongia.ToString();
            gridColumn20.Caption = resEngLand.colthanhtien.ToString();
            gridColumn21.Caption = resEngLand.colthanhtien.ToString();
            colloinhuan.Caption = resEngLand.colloinhuan.ToString();
            gridColumn22.Caption = resEngLand.colmahang.ToString();
            gridColumn23.Caption = resEngLand.colthueGTGT.ToString();
            coltennhomhang.Caption = resEngLand.coltennhomhang.ToString();
            gridColumn25.Caption = resEngLand.colNgay.ToString();
            gridColumn24.Caption = resEngLand.COLMAHDX.ToString();
            colsongayhethan.Caption = resEngLand.colsongayconhan.ToString();

            colkho.Caption = resEngLand.colkho.ToString();
            
            //-----------------------5555555555555555555
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
            colhansudung.Caption = resEngLand.colhansudung.ToString();
            colthue.Caption = resEngLand.colthue.ToString();
            colkho.Caption = resEngLand.colkho.ToString();
            gridColumn39.Caption = resEngLand.colkho.ToString();
            colnhomhang5.Caption = resEngLand.colNhomHang.ToString();
            loinhuan.Caption = resEngLand.linktheoloinhuan.ToString();
            Khachhang.Caption = resEngLand.linktheokhachhang.ToString();
            tenhang.Caption = resEngLand.linktheomathang.ToString();
            Theokho.Caption = resEngLand.linhtheokho.ToString();
            TheoNhom.Caption = resEngLand.linktheonhomhang.ToString();
            colgia5.Caption = resEngLand.coldongia.ToString();
                


        }

        //private void loadGridEgLish()
        //{
        //    colkhachang.Caption = "CUSTOMER";
        //    colmahang.Caption = " Product";
        //    colsoluongmh.Caption = "quantity";
        //    gridColumn4.Caption = "Unit";
        //    coldongia.Caption = "price";
        //    colthanhtien.Caption = "Total Money";
        //    COLGIAVON.Caption = "Purchase price";
        //    colmahang.Caption = "Code's product";
        //    //colhinhanh.Caption = "Image";
        //    colthueGTGT.Caption = "Tax VAT";
        //    COLMAHDX.Caption = "Bill code's";
        //    colnhomhang.Caption = "Group name";
            
        //}

        public void loadcbEgLish()
        {
            //cbThoiGian.Properties.Items.Add("Option");
            cbThoiGian.Properties.Items.Add("Today");
            cbThoiGian.Properties.Items.Add("This Year");
            cbThoiGian.Properties.Items.Add("Jannuary");
            cbThoiGian.Properties.Items.Add("February");
            cbThoiGian.Properties.Items.Add("March");
            cbThoiGian.Properties.Items.Add("April");
            cbThoiGian.Properties.Items.Add("May");
            cbThoiGian.Properties.Items.Add("June");
            cbThoiGian.Properties.Items.Add("July");
            cbThoiGian.Properties.Items.Add("August");
            cbThoiGian.Properties.Items.Add("September");
            cbThoiGian.Properties.Items.Add("October");
            cbThoiGian.Properties.Items.Add("November");
            cbThoiGian.Properties.Items.Add("December");
            cbThoiGian.SelectedIndex = 1;
        }
        public void loadcbVietNam()
        {
            //cbThoiGian.Properties.Items.Add("Tùy Chọn");
            cbThoiGian.Properties.Items.Add("Ngày nay");
            cbThoiGian.Properties.Items.Add("Năm này");
            cbThoiGian.Properties.Items.Add("Tháng 1");
            cbThoiGian.Properties.Items.Add("Tháng 2");
            cbThoiGian.Properties.Items.Add("Tháng 3");
            cbThoiGian.Properties.Items.Add("Tháng 4");
            cbThoiGian.Properties.Items.Add("Tháng 5");
            cbThoiGian.Properties.Items.Add("Tháng 6");
            cbThoiGian.Properties.Items.Add("Tháng 7");
            cbThoiGian.Properties.Items.Add("Tháng 8");
            cbThoiGian.Properties.Items.Add("Tháng 9");
            cbThoiGian.Properties.Items.Add("Tháng 10");
            cbThoiGian.Properties.Items.Add("Tháng 11");
            cbThoiGian.Properties.Items.Add("Tháng 12");
            cbThoiGian.SelectedIndex = 1;
        }

        

        public void loadNgay()
        {
            switch (cbThoiGian.SelectedIndex)
            {
                    

                case 0:
                    {
                        dateDen.Text = DateTime.Now.ToShortDateString();
                        dateTu.Text = DateTime.Now.ToShortDateString();
                        break;
                    }
                case 1:
                    {
                        dateDen.Text = "12/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/"+DateTime.Now.Year.ToString();
                        break;
                    }
                case 2:
                    {
                        dateDen.Text = "01/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 3:
                    {
                        dateDen.Text = "02/28/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "02/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 4:
                    {
                        dateDen.Text = "03/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "03/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 5:
                    {
                        dateDen.Text = "04/30/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "04/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 6:
                    {
                        dateDen.Text = "05/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "05/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 7:
                    {
                        dateDen.Text = "06/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "06/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 8:
                    {
                        dateDen.Text = "07/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "07/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 9:
                    {
                        dateDen.Text = "08/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "08/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 10:
                    {
                        dateDen.Text = "09/30/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "09/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 11:
                    {
                        dateDen.Text = "10/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "10/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 12:
                    {
                        dateDen.Text = "11/30/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "11/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 13:
                    {
                        dateDen.Text = "12/31/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "12/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 14:
                    {
                        
                        dateDen.Text = DateTime.Now.ToShortDateString();
                        dateTu.Text = DateTime.Now.ToShortDateString();
                        break;
                    }
               
            }
           
        }
        

        private void btXem_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (gridControl1.MainView == gridView1)
                {

                    loadGird1();
                }
                if (gridControl1.MainView == gridView2)
                {

                    loadGird2();
                }
                if (gridControl1.MainView == gridView3)
                {

                    loadGird3();
                }
                if (gridControl1.MainView == gridView4)
                {

                    loadGird4();
                }
                if (gridControl1.MainView == gridView5)
                {

                    loadGird5();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui long chọn đúng thông tin");
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {

            if (gridControl1.MainView == gridView1)
            {

                reportBaoCaoLoiNhuan loinhuan = new reportBaoCaoLoiNhuan(dt, iNgonNgu);
                loinhuan.ShowPreviewDialog();
            }
            if (gridControl1.MainView == gridView2)
            {

                reportBaoCaoKhachHang KHACHANG = new reportBaoCaoKhachHang(dt, iNgonNgu);
                KHACHANG.ShowPreviewDialog();
            }
            if (gridControl1.MainView == gridView3)
            {

                reportBaoCaoThongKeKho KHO = new reportBaoCaoThongKeKho(dt, iNgonNgu);
                KHO.ShowPreviewDialog();
            }
            if (gridControl1.MainView == gridView4)
            {
                reportBaoCaoMathang mathang = new reportBaoCaoMathang(dt, iNgonNgu);
                mathang.ShowPreviewDialog();
            }
            if (gridControl1.MainView == gridView5)
            {
                reportBaoCaoNhomHang nhom = new reportBaoCaoNhomHang(dt, iNgonNgu);
                nhom.ShowPreviewDialog();

            }

        }

        private void cbThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNgay();
        }

       

        private void btXuat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    gridControl1.ExportToXls(saveFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                DevComponents.DotNetBar.MessageBoxEx.Show("Da ton tai ten");
            }
        }


        private void loinhuan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControl1.MainView = gridView1;
            gridControl1.DataSource = ctr1.LOINHUANKINHDOANH(dto);
            dt = ctr1.LOINHUANKINHDOANH(dto);
            pnthoigian.Visible = true;
        }

        private void Khachhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnthoigian.Visible = true;
            gridControl1.MainView = gridView2;
            gridControl1.DataSource = ctr1.thongkhetheokhachang(dto);
            dt = ctr1.thongkhetheokhachang(dto);
        }

        private void Theokho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnthoigian.Visible = true;
            gridControl1.MainView = gridView3;
            gridControl1.DataSource =  ctr1.getBAOCAOTHEOKHO(dto);
            dt = ctr1.getBAOCAOTHEOKHO(dto);
        }

        private void tenhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnthoigian.Visible = false;
            gridControl1.MainView = gridView4;
            gridControl1.DataSource = ctr1.gethieuquakinhdoanh(dto);
            dt = ctr1.gethieuquakinhdoanh(dto);
            DevExpress.XtraGrid.StyleFormatCondition cn;
            cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView4.Columns["SONGAYHETHANH"], null, 0);
            //cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView4.Columns["SOLUONGMH"], null, 0);
            //cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Equal, gridView4.Columns["SOLUONGMH"], null, 0);

            //cn.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
            ///cn.Appearance.ForeColor = SystemColors.ControlDark;
            cn.Appearance.BackColor = Color.SpringGreen;
            gridView4.FormatConditions.Add(cn);
            cn.ApplyToRow = true;
            gridView4.FormatConditions.Add(cn);
            gridView4.BestFitColumns();
        }

        private void TheoNhom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnthoigian.Visible = false;
            gridControl1.MainView = gridView5;
            gridControl1.DataSource = ctr1.gethieuquakinhdoanh(dto);
            dt = ctr1.gethieuquakinhdoanh(dto);
        }

        private void navBarGroup1_ItemChanged(object sender, EventArgs e)
        {
            
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void dateDen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btdong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        

        
    }
}