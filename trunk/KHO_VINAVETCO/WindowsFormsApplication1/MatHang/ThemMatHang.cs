﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Globalization;
using System.Threading;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class ThemMatHang : DevExpress.XtraEditors.XtraForm
    {
        public ThemMatHang()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public void loadma()
        {
            txtMaMH.Text = connect.sTuDongDienMaMH(txtMaMH.Text);
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
           // lbnhomhang.Text = LamVN.NHOMHANG.ToString();
            lbtenmh.Text = LamVN.TENMH.ToString();
            lbmamh.Text = LamVN.MAMH.ToString();
            lbDVT.Text = LamVN.DVT.ToString();
            lbtinhtrang.Text = LamVN.TINHTRANG.ToString();
            //lbhinhanh.Text = LamVN.HINHANH.ToString();
            lbmathue.Text = LamVN.MASOTHUE.ToString();
            
           
            lbCHUY.Text = LamVN.CHUY.ToString();
            btLuu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();
            colmadvt.Caption = LamVN.MADVT.ToString();
            coldvt.Caption = LamVN.DVT.ToString();
           // colghichu.Caption = LamVN.GHICHU.ToString();
            colmanh.Caption = LamVN.MANH.ToString();
            colten.Caption = LamVN.TENNHOMHANG.ToString();
            colmathue.Caption = LamVN.MATH.ToString();
            colsothue.Caption = LamVN.SOTHUE.ToString();

            groupControl1.Text = "Thông tin giao dịch";
        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
          //  lbnhomhang.Text = LamEL.NHOMHANG.ToString();
            lbtenmh.Text = LamEL.TENMH.ToString();
            lbmamh.Text = LamEL.MAMH.ToString();
            lbDVT.Text = LamEL.DVT.ToString();
            lbtinhtrang.Text = LamEL.TINHTRANG.ToString();
            //lbhinhanh.Text = LamEL.HINHANH.ToString();
            lbmathue.Text = LamEL.MASOTHUE.ToString();
        
           
            lbmota.Text = LamEL.MOTA.ToString();
           
            lbCHUY.Text = LamEL.CHUY.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            colmadvt.Caption = LamEL.MADVT.ToString();
            coldvt.Caption = LamEL.DVT.ToString();
           // colghichu.Caption = LamEL.GHICHU.ToString();
            colmanh.Caption = LamEL.MANH.ToString();
            colten.Caption = LamEL.TENNHOMHANG.ToString();
            colmathue.Caption = LamEL.MATH.ToString();
            colsothue.Caption = LamEL.SOTHUE.ToString();
            groupControl1.Text = "Infomation trade";
           
            this.Text = "Form Insert && Update Products";
        }
        public string MANHOMHANG, MANCC, TENMATHANG, MAMH, DVT, TINHTRANG, HINHANH, MASOTHUE, SOLUONG, MOTA, MAKHO, MADVT,KLDVT,GIAMUA;
        DataView dvdropdow;
        public void loadgirdlookupTHUE()
        {
            
            cbthue.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbthue.Properties.DataSource = dvdropdow;
            cbthue.Properties.DisplayMember = "SOTHUE";
            cbthue.Properties.ValueMember = "MATH";
            cbthue.Properties.View.BestFitColumns();
            cbthue.Properties.PopupFormWidth = 300;
            cbthue.Properties.DataSource = CTL.GETTHUE();
            

        }
        public void loadgirdlookupDVT()
        {

            cbDvt.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbDvt.Properties.DataSource = dvdropdow;
            cbDvt.Properties.DisplayMember = "DONVITINH";
            cbDvt.Properties.ValueMember = "MADVT";
            cbDvt.Properties.View.BestFitColumns();
            cbDvt.Properties.PopupFormWidth = 300;
            cbDvt.Properties.DataSource = CTL.GETDVT();


        }
        public void loadgirdlookupNCC()
        {

            cbNhomHang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbNhomHang.Properties.DataSource = dvdropdow;
            cbNhomHang.Properties.DisplayMember = "TENNCC";
            cbNhomHang.Properties.ValueMember = "MANCC";
            cbNhomHang.Properties.View.BestFitColumns();
            cbNhomHang.Properties.PopupFormWidth = 300;
            cbNhomHang.Properties.DataSource = CTL.GETNCC();


        }
        public void LoadKhoHang()
        {
            
           


        }
        public string sBoPhan;
        private void ThemMatHang_Load(object sender, EventArgs e)
        {



            txtgiamua.Text = "0";


           
            if (iNgonNgu == 1)
            {
                LoadEL();
            }
            else 
            {
                LoadTV();


            }
              if (kiemtra == 0)
            {
                
                LoadKhoHang();
                loadgirdlookupNCC();
                loadgirdlookupDVT();
                loadgirdlookupTHUE();

                txtMaMH.Text = MAMH;
                txtTenMH.Text = TENMATHANG;
                cbNhomHang.Text = MANCC;
                cbDvt.Text = DVT;
                calKLDVT.Text = KLDVT;
                txtgiamua.Text = GIAMUA;

                cbthue.Text = MASOTHUE;

                txtmota.Text = MOTA;
        
                if (TINHTRANG == "True")
                {
                    checkTT.Checked = true;
                }
                else
                {
                    checkTT.Checked = false;
                }
            }
            else
            {
                LoadKhoHang();
                loadgirdlookupNCC();
                loadgirdlookupDVT();
                loadgirdlookupTHUE();
                loadma();
                
            }

        }
        DataNavigator datanav;
        DataView dvMain;
        //DataView dvdropdow;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        byte[] imageData;
        public int kiemtra;
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    bool KT=false;
                    if (checkTT.Checked)
                    {
                        KT = true;

                    }
                    else
                    {
                        KT = false;
                    }
                    if (txtTenMH.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Mặt Hàng");
                        txtTenMH.Focus();
                        return;
                    }
    
                    else if (cbDvt.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Chọn Đơn Vị Tính ");
                        cbDvt.Focus();
                        return;
                    }
                    else if (cbNhomHang.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Nhóm Hàng");
                        cbNhomHang.Focus();
                        return;
                    }

                    else if (txtgiamua.Text == "" || txtgiamua.Text == "0")
                    {
                        XtraMessageBox.Show("Vui lòng điền Số Giá Mua ");
                        txtgiamua.Focus();
                        return;
                    }
      
                    else if (calKLDVT.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền khối lượng theo đơn vị tính ");
                        cbthue.Focus();
                        return;
                    }


                    else
                    {
                        if (kiemtra == 1)
                        {
                            int COUNTSTART = 0;
                        START_EXCUTIVE:
                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = "TH00001";//gridView2.GetFocusedRowCellValue("MATH").ToString();

                            DTO.MANCC = MANCC;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MADVT = DVT;
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.SOLUONGMH = "0";
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA= txtgiamua.Text;
                            DTO.LOHANG = "TONDAU";
                          
                            DTO.MOTA = txtmota.Text;
                            DTO.TINHTRANG = "True";

                            string SQLstart = "SELECT ACTIVE FROM MAHDARRAY WHERE TYPE='MH' AND MAKHO='" + PublicVariable.MAKHO + "'";
                            DataTable DTstart = connect.getdata(SQLstart);
                            if (DTstart.Rows.Count>0)
                            if (DTstart.Rows[0][0].ToString() == "True" && COUNTSTART < 20)
                            {
                                COUNTSTART = COUNTSTART + 1;
                                connect.dealTimer();
                                if (COUNTSTART == 19)
                                {
                                    MessageBox.Show("CHƯA THÊM ĐƯỢC VUI LÒNG THỬ LẠI ");
                                    return;
                                }
                                goto START_EXCUTIVE;
                                
                            }
                            loadma();
                            DTO.MAMH = txtMaMH.Text;

                            connect.ACTIVEINSERT("MH");
                            CTL.addMatHangCtrl(DTO);
                            connect.UNACTIVEINSERT("MH");
                            XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                            loadma();
                            this.Close();
                        }
                        else
                        {

                            MemoryStream ms = new MemoryStream();
                            
                           

                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = "TH00001";//gridView2.GetFocusedRowCellValue("MATH").ToString();
                            DTO.MANCC = MANCC;
                            DTO.MADVT = DVT;
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.LOHANG = "TONDAU";
                            DTO.SOLUONGMH = "0";
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA = txtgiamua.Text;
                    
                            DTO.MOTA = txtmota.Text;
                            DTO.TINHTRANG = "True";
                            CTL.UPDATEMATHANG(DTO);
                            XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                            this.Close();
                        }

                    }
                }
                else
                {
                    bool KT;
                    if (checkTT.Checked)
                    {
                        KT = true;

                    }
                    else
                    {
                        KT = false;
                    }
                    if (txtTenMH.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter The Name Of Product");
                        txtTenMH.Focus();
                        return;
                    }

  
                    else if (cbNhomHang.Text == "")
                    {
                        XtraMessageBox.Show("Please Choose The Group Product");
                        cbNhomHang.Focus();
                        return;
                    }

                    else if (txtgiamua.Text == "" || txtgiamua.Text == "0")
                    {
                        XtraMessageBox.Show("Vui lòng điền Số Giá Mua ");
                        txtgiamua.Focus();
                        return;
                    }
                    else if (calKLDVT.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền khối lượng theo đơn vị tính ");
                        cbthue.Focus();
                        return;
                    }

                    else
                    {
                        if (kiemtra == 1)
                        {
                            //    MemoryStream ms = new MemoryStream();
                            //    pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
                            //    imageData = ms.GetBuffer();
                            //    ms.Close();
                            //    DTO.PICTURE = imageData;
                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = MASOTHUE;
                            DTO.MANCC = MANCC;
                            DTO.MADVT = DVT;
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.SOLUONGMH = "0";
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA = txtgiamua.Text;
                            DTO.LOHANG = "TONDAU";

                            DTO.MOTA = txtmota.Text;
                            DTO.TINHTRANG = "True";
                            CTL.addMatHangCtrl(DTO);
                            XtraMessageBox.Show("You Added Succeesful");
                            loadma();
                            this.Close();
                        }
                        else
                        {

                            //MemoryStream ms = new MemoryStream();
                            //pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
                            //imageData = ms.GetBuffer();
                            //ms.Close();
                            //DTO.PICTURE = imageData;
                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = MASOTHUE;
                            DTO.MANCC = MANCC;
                            DTO.MADVT = DVT;
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.LOHANG = "TONDAU";
                            DTO.SOLUONGMH = "0";
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA = txtgiamua.Text;
                 
                            DTO.MOTA = txtmota.Text;
                            DTO.TINHTRANG = "True";
                            CTL.UPDATEMATHANG(DTO);
                            XtraMessageBox.Show("You Edited Succeesful");
                            this.Close();
                        }

                    }
                }
            }
            catch 
            {

                
            }
           
            
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap th = new frmThemNhaCungCap();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
            loadgirdlookupNCC();
            //this.nHOMHANGTableAdapter.Fill(this.xUAT_NHAPTONDataSet26.NHOMHANG);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemKho t = new frmThemKho();
            t.iNgonNgu = iNgonNgu;
            t.kiemtra = 1;
            t.ShowDialog();// this.kHOTableAdapter.Fill(this.xUAT_NHAPTONDataSet25.KHO);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void btThemKhuVuc_Click(object sender, EventArgs e)
        {
           
 
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbNhomHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);
               
            }
        }

        private void txtTenMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txtMaMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void cbDvt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void pictureEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void cbthue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }

        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void btThemKhuVuc_Click_1(object sender, EventArgs e)
        {
            frmThemThue thue = new frmThemThue();
            thue.ingonngu = iNgonNgu;
            thue.kiemtra = 1;
            thue.ShowDialog();
            loadgirdlookupTHUE();//this.tHUETableAdapter.Fill(this.xUAT_NHAPTONDataSet31.THUE);
        }

        private void cbthue_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbDvt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            frmThemDVT dv = new frmThemDVT();
            dv.iNgonNgu = iNgonNgu;
            dv.kiemtra = 1;
            dv.ShowDialog();
            loadgirdlookupDVT();// this.dONVITINHTableAdapter.Fill(this.xUAT_NHAPTONDataSet27.DONVITINH);
        }

        private void lbgiamua_Click(object sender, EventArgs e)
        {

        }

        private void lbsoluong_Click(object sender, EventArgs e)
        {

        }

        private void txthansudung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null,null);

               
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frmThemKho frm = new frmThemKho();
            frm.iNgonNgu = iNgonNgu;
            frm.kiemtra = 1;
            frm.ShowDialog();
            LoadKhoHang();
            
        }

        private void txthansudung_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void lbhansudung_Click(object sender, EventArgs e)
        {

        }

        private void txtmota_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbNhomHang_Validated(object sender, EventArgs e)
        {
            MANCC=gridLookUpEdit1View.GetFocusedRowCellValue("MANCC").ToString();
        }

        private void cbDvt_Validated(object sender, EventArgs e)
        {
            DVT=gridView1.GetFocusedRowCellValue("MADVT").ToString();
        }

        private void cbthue_Validated(object sender, EventArgs e)
        {
            MASOTHUE = gridView2.GetFocusedRowCellValue("MATH").ToString();
        }
        
      
    }
}