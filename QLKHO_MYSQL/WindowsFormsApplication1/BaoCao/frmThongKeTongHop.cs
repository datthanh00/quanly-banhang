﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using System.Globalization;
using System.Threading;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.Utils;


namespace WindowsFormsApplication1
{
    public partial class frmThongKeTongHop : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeTongHop()
        {
            InitializeComponent();
        }
        
        string dateNgayBD;
        string dateNgayKT;
        string LoaiTG = "";
        string LoaiHT = "";
        string MANH;
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();

        
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void frmThongKeTongHop_Load(object sender, EventArgs e)
        {
         
            if (PublicVariable.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(loadcbVietNam);
            ////frm.LoadVI += new frmMain.Translate(loadGird);

            
            frm.LoadEN += new frmMain.Translate(loadcbEgLish);
            //frm.LoadEN += new frmMain.Translate(loadReSEG);



            if (iNgonNgu == 0)
            {
                loadReSVN1();
                loadcbVietNam();

            }
            else
            {
                loadReSEG1();
                loadcbEgLish();
                

            } 
            vload();
            vloadchitietmathang();
            load_cbhanghoa();
            loadngonngu();

            lbnhom.Visible = false;
            lbsanpham.Visible = false;
            cbnhomhang.Visible = false;
            cbmathang.Visible = false;

        }

        private void loadReSVN1()
        {
            btxem.Text = resVietNam.btXem.ToString();
            btin.Text = resVietNam.btIn.ToString();
            BtXuatdulieu.Text = resVietNam.btXuat.ToString();
            btdong.Text = resVietNam.btDong.ToString();
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
            lbnhom.Text = resVietNam.lbchonnhom.ToString();
            //labelControl2.Text = resVietNam.lbden.ToString();
            colsongayhethan.Caption = resVietNam.colsongayconhan.ToString();
            //labelControl13.Text = resVietNam.lbtu.ToString();
            //labelControl14.Text = resVietNam.lbden.ToString();
            labelControl2.Text = resVietNam.lbloai.ToString();
            //lbTu.Text = resVietNam.lbtu.ToString();
            //lbDen.Text = resVietNam.lbden.ToString();
            //lbNam.Text = resVietNam.lbNam.ToString();
        }

        private void loadReSEG1()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

           btxem.Text = resEngLand.btXem.ToString();
           btin.Text = resEngLand.btIn.ToString();
           BtXuatdulieu.Text = resEngLand.btXuat.ToString();
           btdong.Text = resEngLand.btDong.ToString();
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
            lbnhom.Text = resEngLand.lbchonnhom.ToString();
            //labelControl2.Text = resEngLand.l.ToString();
            colsongayhethan.Caption = resEngLand.colsongayconhan.ToString();
            //labelControl13.Text = resEngLand.lbtu.ToString();
            //labelControl14.Text = resEngLand.lbden.ToString();
            labelControl2.Text = resEngLand.lbloai.ToString();
            //lbTu.Text = resEngLand.lbtu.ToString();
            //lbDen.Text = resEngLand.lbden.ToString();
            //lbNam.Text = resEngLand.lbNam.ToString();
        }
     


        private void loadngonngu()
        {
            if (iNgonNgu == 0)
            {
                loadcbVietNam();

            }
            else
            {
                loadcbEgLish();
                loadgirdenglish();

            }
        }

        private void loadgirdenglish()
        {

           
        }


        public void loadcbEgLish()
        {
            //cbHienThiBatDau.Properties.Items.Add("please chose");

            //cbHienThiBatDau.Properties.Items.Add("Jannuary");
            //cbHienThiBatDau.Properties.Items.Add("February");
            //cbHienThiBatDau.Properties.Items.Add("March");
            //cbHienThiBatDau.Properties.Items.Add("April");
            //cbHienThiBatDau.Properties.Items.Add("May");
            //cbHienThiBatDau.Properties.Items.Add("June");
            //cbHienThiBatDau.Properties.Items.Add("July");
            //cbHienThiBatDau.Properties.Items.Add("August");
            //cbHienThiBatDau.Properties.Items.Add("September");
            //cbHienThiBatDau.Properties.Items.Add("October");
            //cbHienThiBatDau.Properties.Items.Add("November");
            //cbHienThiBatDau.Properties.Items.Add("December");
            ////-----------------------------------------------
            //cbHienThiKeThuc.Properties.Items.Add("please chose");
            //cbHienThiKeThuc.Properties.Items.Add("Jannuary");
            //cbHienThiKeThuc.Properties.Items.Add("February");
            //cbHienThiKeThuc.Properties.Items.Add("March");
            //cbHienThiKeThuc.Properties.Items.Add("April");
            //cbHienThiKeThuc.Properties.Items.Add("May");
            //cbHienThiKeThuc.Properties.Items.Add("June");
            //cbHienThiKeThuc.Properties.Items.Add("July");
            //cbHienThiKeThuc.Properties.Items.Add("August");
            //cbHienThiKeThuc.Properties.Items.Add("September");
            //cbHienThiKeThuc.Properties.Items.Add("October");
            //cbHienThiKeThuc.Properties.Items.Add("November");
            //cbHienThiKeThuc.Properties.Items.Add("December");
            ////-------------------------------------------------
            //cbNam.Properties.Items.Clear();
            //cbHienThiBatDau.Properties.Items.Clear();
            //cbHienThiKeThuc.Properties.Items.Clear();
            //for (int i = 1; i < 13; i++)
            //{
            //    cbHienThiBatDau.Properties.Items.Add(i.ToString());
            //    cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            //}
            //for (int i = 1900; i < DateTime.Now.Year + 1; i++)
            //{
            //    cbNam.Properties.Items.Add(i.ToString());
            //}
            //cbHienThiKeThuc.SelectedIndex = 1;


        }
        public void loadcbVietNam()
        {
            //cbHienThiBatDau.Properties.Items.Add("Chọn Tháng");

            //cbHienThiBatDau.Properties.Items.Add("Tháng 1");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 2");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 3");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 4");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 5");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 6");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 7");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 8");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 9");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 10");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 11");
            //cbHienThiBatDau.Properties.Items.Add("Tháng 12");
            ////------------------------------------------------- 
            //cbHienThiKeThuc.Properties.Items.Add("Chọn Tháng");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 1");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 2");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 3");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 4");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 5");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 6");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 7");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 8");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 9");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 10");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 11");
            //cbHienThiKeThuc.Properties.Items.Add("Tháng 12");
            ////-------------------------------------------------
            //cbNam.Properties.Items.Clear();
            //cbHienThiBatDau.Properties.Items.Clear();
            //cbHienThiKeThuc.Properties.Items.Clear();
            //for (int i = 1; i < 13; i++)
            //{
            //    cbHienThiBatDau.Properties.Items.Add(i.ToString());
            //    cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            //}
            //for (int i = 1900; i < DateTime.Now.Year + 1; i++)
            //{
            //    cbNam.Properties.Items.Add(i.ToString());
            //}

            //cbHienThiKeThuc.SelectedIndex = 1;

            //cbHienThiBatDau.SelectedIndex = 1;
        }
  
        public void load()
        {
            //dto.NGAY_BD = DateTime.Parse(dateNgayBD);
            //dto.NGAY_KT = DateTime.Parse(dateNgayKT);
            dto.Loai_TG = LoaiTG;
            dto.Loai_HT = LoaiHT;

        }



        private void LinkTheoqui_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (iNgonNgu == 0)
            //{
            //    cbHienThiBatDau.Text = "Chọn Quí";
            //    cbHienThiKeThuc.Text = "Chọn Năm";
            //    xtraTabPage3.Text = "Thống Kê Theo Quí";

            //}
            //else
            //{
            //    cbHienThiBatDau.Text = "Select quarter";
            //    cbHienThiKeThuc.Text = "Select Year";
            //    xtraTabPage3.Text = "Quarterly statistics";

            //}


            //LoaiHT = "thoigian";
            //pnThangNam.Visible = true;
            //pnThoiGian.Visible = false;
            //cbHienThiKeThuc.Visible = true;
            //lbNam.Visible = false;
            //cbNam.Visible = false;
            //lbDen.Visible = false;
            //cbHienThiBatDau.Properties.Items.Clear();
            //cbHienThiKeThuc.Properties.Items.Clear();
            //if (DateTime.Now.Month > 4)
            //{
            //    for (int i = 1; i <= (12 / 3); i++)
            //    {
            //        cbHienThiBatDau.Properties.Items.Add(i.ToString());
            //    }
            //}
            //for (int i = 2005; i < DateTime.Now.Year + 1; i++)
            //{
            //    cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            //}
            //LoaiHT = "";
            //dateNgayBD = DateTime.Now.ToShortDateString();
            //dateNgayKT = DateTime.Now.ToShortDateString();

            //LoaiTG = "QUI";
        }


        private void vloadchitietmathang()
        {
                cbloaihienthi.Properties.Items.Add("Tất Cả");
                cbloaihienthi.Properties.Items.Add("Theo Hàng Hóa");
                cbloaihienthi.Properties.Items.Add("Theo Nhóm Hàng");
                cbloaihienthi.SelectedIndex = 0;
        }

        private void vload()
        {
            if (iNgonNgu == 0)
            {
                xtraTabPage3.Text = "Chọn Loại Thống Kê Mặt Hàng";
            }
            else
            {
                xtraTabPage3.Text = "STATISTICAL ITEMS REPORT";
            }
        }

        private void load_cbhanghoa()
        {
            cbmathang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbmathang.Properties.DisplayMember = "TENSANPHAM";
            cbmathang.Properties.ValueMember = "MASANPHAM";
            cbmathang.Properties.View.BestFitColumns();
            cbmathang.Properties.PopupFormWidth = 200;
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            cbmathang.Properties.DataSource = ctr1.dtGetsanpham();

            cbnhomhang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbnhomhang.Properties.DisplayMember = "TENNHOMHANG";
            cbnhomhang.Properties.ValueMember = "MANH";
            cbnhomhang.Properties.View.BestFitColumns();
            cbnhomhang.Properties.PopupFormWidth = 200;
            cbnhomhang.Properties.DataSource = ctr1.dtGetNH2();
        }


        private void simpleButton11_Click(object sender, EventArgs e)
        {
            int loaihienthi = cbloaihienthi.SelectedIndex;
            if (loaihienthi == 1)
            {
                if (cbmathang.Text == "")
                {
                    MessageBox.Show("Hãy Chọn một mã hàng");
                    return;
                }

            }
            else if (loaihienthi == 2)
            {
                if (cbmathang.Text == "")
                {
                    MessageBox.Show("Hãy Chọn một nhóm hàng");
                    return;
                }
            }

                dto.Loai_HT = loaihienthi.ToString();

                dto.MAMH = gridView2.GetFocusedRowCellValue("MASANPHAM").ToString();
                dto.MANH = gridView3.GetFocusedRowCellValue("MANH").ToString();

            
                dt = ctr.geTthongke_ct_mathang2(dto);
                
              
                gridControl1.DataSource = dt;
                DevExpress.XtraGrid.StyleFormatCondition cn;
                cn = new DevExpress.XtraGrid.StyleFormatCondition(FormatConditionEnum.Less, gridView1.Columns["SONGAYHETHANH"], null, 0);
                cn.Appearance.BackColor = Color.Yellow;
                gridView1.FormatConditions.Add(cn);
                cn.ApplyToRow = true;
                gridView1.FormatConditions.Add(cn);
                gridView1.BestFitColumns();

            }
            //catch (Exception)
            //{
            //    if (iNgonNgu == 0)
            //    {

            //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter enough information");

            //    }

               
        




        private void linkNgayThang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            //if (iNgonNgu == 0)
            //{
            //    dateBD.SelectedText = "Chọn Ngày";
            //    dateKetThuc.SelectedText = "Chọn Ngày";

            //    xtraTabPage3.Text = "Thống Kê Theo Ngày";

            //}
            //else
            //{
            //    dateBD.SelectedText = "Select Day";
            //    dateKetThuc.SelectedText = "Select day";

            //    xtraTabPage3.Text = "Day statistics";

            //}



            //pnThoiGian.Visible = true;
            //pnThangNam.Visible = false;
            //LoaiHT = "";
            //dateNgayBD = DateTime.Now.ToShortDateString();
            //dateNgayKT = DateTime.Now.ToShortDateString();

            //LoaiTG = "ngay";
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }



        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            gridControl1.ShowPrintPreview();
           // reporthansudung hansudung = new reporthansudung(dt, iNgonNgu);
           // hansudung.ShowPreviewDialog();
        }

     

        

        private void cbHienThiBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void BtXuatdulieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "0")
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

                DevComponents.DotNetBar.MessageBoxEx.Show("Đã Tồn Tại Tên");
            }

        }

        private void cmbloaihienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaihienthi = cbloaihienthi.SelectedIndex;
            if (loaihienthi==0)
            {
                lbnhom.Visible = false;
                lbsanpham.Visible = false;
                cbnhomhang.Visible = false;
                cbmathang.Visible = false;
            }
            else if (loaihienthi == 1)
            {
                lbnhom.Visible = false;
                lbsanpham.Visible = true;
                cbnhomhang.Visible = false;
                cbmathang.Visible = true;
            }
            else
            {
                lbnhom.Visible = true;
                lbsanpham.Visible = false;
                cbnhomhang.Visible = true;
                cbmathang.Visible = false;
            }

        }



        private void labelControl13_Click(object sender, EventArgs e)
        {
            //if (iNgonNgu == 2)
            //{
            //    labelControl13.pr = " Từ";



            //}
            //else
            //{
            //    labelControl13.TextChanged = " From";

            //}
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            if (iNgonNgu == 0)
            {
               //labelControl1.c
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbloaihienthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
        
       
    
