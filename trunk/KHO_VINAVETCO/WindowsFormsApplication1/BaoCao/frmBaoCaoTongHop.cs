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
using DevExpress.XtraPrinting;
using Quanlykho;


namespace WindowsFormsApplication1
{
    public partial class frmBaoCaoTongHop : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoTongHop()
        {
            InitializeComponent();
        }

        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public  int iNgonNgu ;
        public  string optionload="";

      

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
           

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
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
            load_cbhanghoa();
            pnthoigian.Visible = true;
            lbmahang.Visible = true;
            cbsanpham.Visible = true;

            lbncc.Visible = true;
            cbncc.Visible = true;

            lbkhachhang.Visible = false;
            cbkhachhang.Visible = false;
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
        }


        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
        DataTable dt = new DataTable();
     
        private void loadGird1()
        {
            if (cbncc.Text != "")
            {
                dto.MANCC = gridCBNCC.GetFocusedRowCellValue("MANCC").ToString();
                gridCBNCC.ClearSelection();
                cbncc.Text = "";
            }
            else
            {
                dto.MANCC = "";
            }

            //dto.MAKHO = gView.GetFocusedRowCellValue("MAKHO").ToString();
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;
            
            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dto.NGAYKTKHO = NGAYKT;

            gridControl1.MainView = grid_hoadontheo_NCC;
            if (ISXEMCLICK){
            dt = ctr1.thongkhetheoNCC(dto);
                gridControl1.DataSource = dt;
            }
            else
            {
                gridControl1.DataSource = null;
            }
            ISXEMCLICK = false;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_hoadontheo_NCC.Columns["KHOILUONG"].Visible = false;
            }
            if (!PublicVariable.isHSD)
            {
                grid_hoadontheo_NCC.Columns["HSD"].Visible = false;
            }
           
        }
        private void loadGird2()
        {
            if (cbkhachhang.Text != "")
            {
                dto.MAKH = gridCBKH.GetFocusedRowCellValue("MAKH").ToString();
                gridCBKH.ClearSelection();
                cbkhachhang.Text = "";
            }
            else
            {
                dto.MAKH = "";
            }

            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dto.NGAYKTKHO = NGAYKT;

            gridControl1.MainView = grid_hoadontheo_KHACHHANG;
            if (ISXEMCLICK){
            dt = ctr1.thongkhetheokhachang(dto);
                gridControl1.DataSource = dt;
            }
            else
            {
                gridControl1.DataSource = null;
            }
            ISXEMCLICK = false;
            grid_hoadontheo_KHACHHANG.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                grid_hoadontheo_KHACHHANG.Columns["KHOILUONG"].Visible = false;
            }
            if (!PublicVariable.isHSD)
            {
                grid_hoadontheo_KHACHHANG.Columns["HSD"].Visible = false;
            }
        }
       
        private void loadGird_tonkhotonghop()
        {
            //dto.MAKHO = gridcbkho.GetFocusedRowCellValue("MAKHO").ToString();
            if (cbsanpham.Text != "")
            {
                dto.MAMH = gridcbmathang.GetFocusedRowCellValue("MASANPHAM").ToString();
                gridcbmathang.ClearSelection();
                cbsanpham.Text = "";
            }
            else
            {
                dto.MAMH = "";
            }

            if (cbncc.Text != "")
            {
                dto.MANCC = gridCBNCC.GetFocusedRowCellValue("MANCC").ToString();
                gridCBNCC.ClearSelection();
                cbncc.Text = "";
            }
            else
            {
                dto.MANCC = "";
            }

            gridControl1.MainView = grid_tonkho_CUOIKY;
            if (ISXEMCLICK){
            dt = ctr1.TONKHOTONGHOP(dto);
                gridControl1.DataSource = dt;
            }
            else
            {
                gridControl1.DataSource = null;
            }
            ISXEMCLICK = false;
            //grid_tonkho_CUOIKY.RefreshData();
            grid_tonkho_CUOIKY.BestFitColumns();
           // gridControl1.RefreshDataSource();
            if (!PublicVariable.isKHOILUONG)
            {
                grid_tonkho_CUOIKY.Columns["KHOILUONG"].Visible = false;
            }
            if (!PublicVariable.isHSD)
            {
                grid_tonkho_CUOIKY.Columns["HSD"].Visible = false;
                grid_tonkho_CUOIKY.Columns["LOHANG"].Visible = false;
            }
        }
        private void loadGird_thekho()
        {
            if (cbsanpham.Text != "")
            {
                dto.MAMH = gridcbmathang.GetFocusedRowCellValue("MASANPHAM").ToString();
                gridcbmathang.ClearSelection();
                cbsanpham.Text = "";
            }
            else
            {
                dto.MAMH = "";
            }

            if (cbncc.Text != "")
            {
                dto.MANCC = gridCBNCC.GetFocusedRowCellValue("MANCC").ToString();
                gridCBNCC.ClearSelection();
                cbncc.Text = "";
            }
            else
            {
                dto.MANCC = "";
            }

            //dto.MAKHO = gView.GetFocusedRowCellValue("MAKHO").ToString();
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dto.NGAYKTKHO = NGAYKT;

           // dto.MAKHO = gridcbkho.GetFocusedRowCellValue("MAKHO").ToString();

            //dto.MAKHO = cbkho.Text;
            //dto.MAMH = cbsanpham.Text;

            gridControl1.MainView = grid_THEKHO;
            if (ISXEMCLICK){
            dt = ctr1.THEKHO(dto);
                gridControl1.DataSource = dt;
            }
            else
            {
                gridControl1.DataSource = null;
            }
            ISXEMCLICK = false;
            grid_THEKHO.RefreshData();
            gridControl1.RefreshDataSource();

            //gridView6.Columns["Mã Hàng"].Group();
            //gridView6.Columns["Ngày"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            grid_THEKHO.ExpandAllGroups();
            grid_THEKHO.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                grid_THEKHO.Columns["KLTONDAU"].Visible = false;
                grid_THEKHO.Columns["KLNHAP"].Visible = false;
                grid_THEKHO.Columns["KLTRANHAP"].Visible = false;
                grid_THEKHO.Columns["KLXUAT"].Visible = false;
                grid_THEKHO.Columns["KLTRAXUAT"].Visible = false;
                grid_THEKHO.Columns["KLTONCUOI"].Visible = false;
            }

        }
        private void loadGird_chitiethanghoa()
        {
            if (cbsanpham.Text != "")
            {
                dto.MAMH = gridcbmathang.GetFocusedRowCellValue("MASANPHAM").ToString();
                gridcbmathang.ClearSelection();
                cbsanpham.Text = "";
            }
            else
            {
                dto.MAMH = "";
            }

            if (cbncc.Text != "")
            {
                dto.MANCC = gridCBNCC.GetFocusedRowCellValue("MANCC").ToString();
                gridCBNCC.ClearSelection();
                cbncc.Text = "";
            }
            else
            {
                dto.MANCC = "";
            }

            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dto.NGAYKTKHO = NGAYKT;


            

            gridControl1.MainView = gridView9;
            if (ISXEMCLICK)
            {
                dt = ctr1.SOCHITIETHANGHOA(dto);
                gridControl1.DataSource = dt;
            }
            else
            {
                gridControl1.DataSource = null;
            }
            ISXEMCLICK = false;
           
            gridView9.RefreshData();
            gridControl1.RefreshDataSource();

            //gridView6.Columns["tenmh"].Group();
           // gridView6.Columns["ngaythang"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            gridView9.ExpandAllGroups();
            gridView9.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView9.Columns["KLTONDAU"].Visible = false;
                gridView9.Columns["KLNHAP"].Visible = false;
                gridView9.Columns["KLTRANHAP"].Visible = false;
                gridView9.Columns["KLXUAT"].Visible = false;
                gridView9.Columns["KLTRAXUAT"].Visible = false;
                gridView9.Columns["KLTONCUOI"].Visible = false;
            }
        }
       
  
        
       

       

      

        private void loadReSVN()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resVietNam.btXem.ToString();
            btIn.Text = resVietNam.btIn.ToString();
            btXuat.Text = resVietNam.btXuat.ToString();
     
              colngayxuathoadon.Caption = resVietNam.colngay11.ToString();
           
              gridColumn2.Caption = resVietNam.coltenmathang.ToString();
              gridColumn3.Caption = resVietNam.colsoluongmh.ToString();
              gridColumn5.Caption = resVietNam.colDonViTInh.ToString();
              gridColumn6.Caption = resVietNam.colgiaban.ToString();
              colthanhtienxuat1.Caption = resVietNam.colthanhtien.ToString();
              
              gridColumn9.Caption = resVietNam.colmahang.ToString();
             
              gridColumn41.Caption = resVietNam.COLMAHDX.ToString();
             
          }

        

          private void loadReSEG()
          {
              CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
              btXem.Text = resEngLand.btXem.ToString();


          }

          public void loadcbEgLish()
          {
              //cbThoiGian.Properties.Items.Add("Option");
              cbThoiGian.Properties.Items.Add("Today");
              cbThoiGian.Properties.Items.Add("This Month");
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
              cbThoiGian.Properties.Items.Add("Tháng này");
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
                          dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
                          dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");

                          break;
                      }
                  case 1:
                      {
                          dateDen.Text = "31/" + DateTime.Now.ToString("MM/yyy");
                          dateTu.Text = "01/" + DateTime.Now.ToString("MM/yyy");

                          break;
                      }
                  case 2:
                      {
                          dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 3:
                      {
                          dateDen.Text = "31/01/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 4:
                      {
                          dateDen.Text = "28/02/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/02/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 5:
                      {
                          dateDen.Text = "31/03/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/03/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 6:
                      {
                          dateDen.Text = "30/04/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/04/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 7:
                      {
                          dateDen.Text = "31/05/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/05/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 8:
                      {
                          dateDen.Text = "30/06/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/06/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 9:
                      {
                          dateDen.Text = "31/07/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/07/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 10:
                      {
                          dateDen.Text = "31/08/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/08/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 11:
                      {
                          dateDen.Text = "30/09/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/09/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 12:
                      {
                          dateDen.Text = "31/10/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/10/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 13:
                      {
                          dateDen.Text = "30/11/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/11/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 14:
                      {
                          dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                          dateTu.Text = "01/12/" + DateTime.Now.Year.ToString();
                          break;
                      }
                  case 15:
                      {

                          dateDen.Text = DateTime.Now.ToString("yyy/MM/dd");

                          dateTu.Text = DateTime.Now.ToString("yyy/MM/dd");

                          break;
                      }
               
              }
           
          }
          Boolean ISXEMCLICK=false;


          private void btXem_Click(object sender, EventArgs e)
          {
              ISXEMCLICK = true;
              int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
              int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
              if (ingaybd > ingaykt)
              {
                  MessageBox.Show("ngày kết thúc phải lớn hơn ngày bắt đầu");
                  return;
              }
              try
              {
                  if (gridControl1.MainView == grid_hoadontheo_NCC)
                  {

                      loadGird1();
                  }
                  if (gridControl1.MainView == grid_hoadontheo_KHACHHANG)
                  {

                      loadGird2();
                  }
              
                  if (gridControl1.MainView == grid_tonkho_CUOIKY)
                  {
                      loadGird_tonkhotonghop();
                  }
                  if (gridControl1.MainView == grid_THEKHO)
                  {
                      loadGird_thekho();
                  }
                  if (gridControl1.MainView == gridView9)
                  {
                      loadGird_chitiethanghoa();
                  }
               
              }
              catch (Exception)
              {

                  MessageBox.Show("Vui long chọn đúng thông tin");
              }
          }

          private void btIn_Click(object sender, EventArgs e)
          {
              if (PublicVariable.IN == "False")
              {
                  MessageBox.Show("KHÔNG CÓ QUYỀN ");
                  return;
              }
           
   
            //  gridControl1.ShowPrintPreview();
            //printableComponentLink1.CreateDocument();
           // printableComponentLink1.ShowPreview();
              DataTable printtable = (DataTable)gridControl1.DataSource;
              if (gridControl1.MainView == grid_hoadontheo_NCC)
              {
                  Inhdoanhthu rep = new Inhdoanhthu(printtable, 7);
                  rep.ShowPreviewDialog();
              }
              if (gridControl1.MainView == grid_hoadontheo_KHACHHANG)
              {
                  Inhdoanhthu rep = new Inhdoanhthu(printtable, 8);
                  rep.ShowPreviewDialog();
              }
              if (gridControl1.MainView == grid_tonkho_CUOIKY)
              {
                  Inhdoanhthu rep = new Inhdoanhthu(printtable, 9);
                  rep.ShowPreviewDialog();
              }
              if (gridControl1.MainView == grid_THEKHO)
              {
                  Inhdoanhthu rep = new Inhdoanhthu(printtable, 10);
                  rep.ShowPreviewDialog();
              }
              if (gridControl1.MainView == gridView9)
              {
                  Inhdoanhthu rep = new Inhdoanhthu(printtable, 11);
                  rep.ShowPreviewDialog();
              }

        }

        private void cbThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNgay();
        }


        private void btXuat_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
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


        private void hoadontheoNCC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadGird1();
            gridControl1.MainView = grid_hoadontheo_NCC;
            //gridControl1.DataSource = ctr1.LOINHUANKINHDOANH(dto);
           // dt = ctr1.LOINHUANKINHDOANH(dto);
            //pnkho.Visible = false;
            pnthoigian.Visible = true;

            lbmahang.Visible = false;
            cbsanpham.Visible = false;

            lbncc.Visible = true;
            cbncc.Visible = true;

            lbkhachhang.Visible = false;
            cbkhachhang.Visible = false;

            
        }

        private void Khachhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadGird2();
            pnthoigian.Visible = true;
           // pnkho.Visible = false;
            //gridControl1.MainView = gridView2;
            //gridControl1.DataSource = ctr1.thongkhetheokhachang(dto);
            //dt = ctr1.thongkhetheokhachang(dto);
            lbmahang.Visible = false;
            cbsanpham.Visible = false;

            lbncc.Visible = false;
            cbncc.Visible = false;

            lbkhachhang.Visible = true;
            cbkhachhang.Visible = true;
        }


        private void btdong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void load_cbhanghoa()
        {
            cbsanpham.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbsanpham.Properties.DisplayMember = "TENSANPHAM";
            cbsanpham.Properties.ValueMember = "MASANPHAM";
            cbsanpham.Properties.View.BestFitColumns();
            //cbsanpham.Properties.PopupFormWidth = 200;
            cbsanpham.Properties.DataSource = ctr1.dtGetsanpham();
            gridcbmathang.BestFitColumns();

            cbncc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbncc.Properties.DisplayMember = "TENNCC";
            cbncc.Properties.ValueMember = "MANCC";
            cbncc.Properties.View.BestFitColumns();
            cbncc.Properties.PopupFormWidth = 300;
            cbncc.Properties.DataSource = ctr1.dtGetNCC();

            cbkhachhang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbkhachhang.Properties.DisplayMember = "TENKH";
            cbkhachhang.Properties.ValueMember = "MAKH";
            cbkhachhang.Properties.View.BestFitColumns();
            cbkhachhang.Properties.PopupFormWidth = 300;
            cbkhachhang.Properties.DataSource = ctr1.dtGetKH();

        }
        private void LinktonkhoCUOIKY_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            optionload = "tonkhotonghop";
            gridControl1.DataSource = null;
            //gridView6.Columns.Clear();
            loadGird_tonkhotonghop();
            pnthoigian.Visible = false;
            lbmahang.Visible = true;
            cbsanpham.Visible = true;

            lbncc.Visible = true;
            cbncc.Visible = true;

            lbkhachhang.Visible = false;
            cbkhachhang.Visible = false;
            
        }
        

        private void Linkthekho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            optionload = "thekho";
           // pnkho.Visible = true;
            pnthoigian.Visible = true;
           // lbkho.Visible = true;
            //cbkho.Visible = true;
      
            gridControl1.DataSource = null;
            //gridView6.Columns.Clear();
            loadGird_thekho();

            lbmahang.Visible = true;
            cbsanpham.Visible = true;

            lbncc.Visible = true;
            cbncc.Visible = true;

            lbkhachhang.Visible = false;
            cbkhachhang.Visible = false;
        }
        

        private void Linkchitiethanghoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            optionload = "sochitiethanghoa";
           
            gridControl1.DataSource = null;
            //gridView6.Columns.Clear();
            loadGird_chitiethanghoa();
            pnthoigian.Visible = true;
           // pnkho.Visible = true;

            lbmahang.Visible = true;
            cbsanpham.Visible = true;

            lbncc.Visible = true;
            cbncc.Visible = true;

            lbkhachhang.Visible = false;
            cbkhachhang.Visible = false;
        }

        private void cbkho_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {

            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Báo Cáo Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
			
        }

        private void frmBaoCaoTongHop_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }


        

        
    }
}