using System;
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
            lbgiaban.Text = LamVN.GIABAN.ToString();
            lbgiamua.Text = LamVN.GIAMUA.ToString();
            lbsoluong.Text = LamVN.SOLUONGMH.ToString();
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
            lbgiaban.Text = LamEL.GIABAN.ToString();
            lbgiamua.Text = LamEL.GIAMUA.ToString();
            lbsoluong.Text = LamEL.SOLUONGMH.ToString();
            lbmota.Text = LamEL.MOTA.ToString();
            lbhansudung.Text = LamEL.HANSUDUNG.ToString();
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
        public string MANHOMHANG, MANCC, TENMATHANG, MAMH, DVT, TINHTRANG, HINHANH, MASOTHUE, GIABAN, GIANUA, SOLUONG, MOTA, HANSUDUNG, MAKHO, MADVT,KLDVT;
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
            txtSoLuong.Text = "0";

            if (sBoPhan == "MABP00004")
            {
                txtSoLuong.Enabled = true;
                cbthue.Enabled = true;
                btThemKhuVuc.Enabled = true;

            }
            else
            {
                txtSoLuong.Enabled = false;
                cbthue.Enabled = false;
                btThemKhuVuc.Enabled = false;
            }
           
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

                cbthue.Text = MASOTHUE;
                txthansudung.Text = HANSUDUNG;

                txtSoLuong.Text = SOLUONG;
                if (PublicVariable.XOA == "False")
                {
                    txtSoLuong.Enabled = false;
                }
                else
                {
                    txtSoLuong.Enabled = true;
                }
                
                
                txtmota.Text = MOTA;
                txtGiaBan.Text = GIABAN;
                txtGiaMua.Text = GIANUA;
                
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
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet31.THUE' table. You can move, or remove it, as needed.
            //this.tHUETableAdapter.Fill(this.xUAT_NHAPTONDataSet31.THUE);
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet27.DONVITINH' table. You can move, or remove it, as needed.
            //this.dONVITINHTableAdapter.Fill(this.xUAT_NHAPTONDataSet27.DONVITINH);
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet26.NHOMHANG' table. You can move, or remove it, as needed.
            //this.nHOMHANGTableAdapter.Fill(this.xUAT_NHAPTONDataSet26.NHOMHANG);
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet25.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Fill(this.xUAT_NHAPTONDataSet25.KHO);

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
                    
         
                   
                    else if (txtGiaBan.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền Giá Bán ");
                        txtGiaBan.Focus();
                        return;
                    }
                    else if (txtGiaMua.Text == "" )
                    {
                        XtraMessageBox.Show("Vui lòng điền Giá mua ");
                        txtGiaMua.Focus();
                        return;
                    }
                    
                    else if ( txtSoLuong.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền Số lượng ");
                        txtSoLuong.Focus();
                        return;
                    }
                    /*else if (cbthue.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền mã thuế ");
                        cbthue.Focus();
                        return;
                    }*/
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
                            //MemoryStream ms = new MemoryStream();
                            //pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
                            //imageData = ms.GetBuffer();
                            //ms.Close();
                            //DTO.PICTURE = imageData;
                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = "TH00001";//gridView2.GetFocusedRowCellValue("MATH").ToString();

                            DTO.MANCC = gridLookUpEdit1View.GetFocusedRowCellValue("MANCC").ToString();
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MADVT = gridView1.GetFocusedRowCellValue("MADVT").ToString();
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.SOLUONGMH = txtSoLuong.Text;
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA = int.Parse(txtGiaMua.Text).ToString();
                            DTO.GIABAN = int.Parse(txtGiaBan.Text).ToString();

                            DTO.MOTA = txtmota.Text;
                            DTO.TINHTRANG = "True";
                            CTL.addMatHangCtrl(DTO);
                            XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                            loadma();
                            this.Close();
                        }
                        else
                        {

                            MemoryStream ms = new MemoryStream();
                            //pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
                            //imageData = ms.GetBuffer();
                            //ms.Close();
                            //DTO.PICTURE = imageData;
                            DTO.MAMH = txtMaMH.Text;
                            DTO.MATH = "TH00001";//gridView2.GetFocusedRowCellValue("MATH").ToString();
                            DTO.MANCC = gridLookUpEdit1View.GetFocusedRowCellValue("MANCC").ToString();
                            DTO.MADVT = gridView1.GetFocusedRowCellValue("MADVT").ToString();
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.SOLUONGMH = txtSoLuong.Text;
                            DTO.HANSUDUNG = "";
                            DTO.GIAMUA = int.Parse(txtGiaMua.Text).ToString();
                            DTO.GIABAN = int.Parse(txtGiaBan.Text).ToString();

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

                    else if (txtGiaBan.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền Giá Bán ");
                        txtGiaBan.Focus();
                        return;
                    }
                    
                    else if (txtGiaMua.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền Giá mua ");
                        cbthue.Focus();
                        return;
                    }
                    
                    else if (txtSoLuong.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền Số lượng ");
                        txtSoLuong.Focus();
                        return;
                    }
                    else if (cbthue.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng điền mã thuế ");
                        txtSoLuong.Focus();
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
                            DTO.MATH = gridView2.GetFocusedRowCellValue("MATH").ToString();
                            DTO.MANCC = gridLookUpEdit1View.GetFocusedRowCellValue("MANCC").ToString();
                            DTO.MADVT = gridView1.GetFocusedRowCellValue("MADVT").ToString();
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.TENMH = txtTenMH.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.SOLUONGMH = txtSoLuong.Text;
                            DTO.HANSUDUNG = DateTime.Parse(txthansudung.Text).ToString();
                            DTO.GIAMUA = int.Parse(txtGiaMua.Text).ToString();
                            DTO.GIABAN = int.Parse(txtGiaBan.Text).ToString();

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
                            DTO.MATH = gridView2.GetFocusedRowCellValue("MATH").ToString();
                            DTO.MANCC = gridLookUpEdit1View.GetFocusedRowCellValue("MANCC").ToString();
                            DTO.MADVT = gridView1.GetFocusedRowCellValue("MADVT").ToString();
                            DTO.KLDVT = calKLDVT.Text;
                            DTO.MAKHO = PublicVariable.MAKHO;
                            DTO.TENMH = txtTenMH.Text;

                            DTO.SOLUONGMH = txtSoLuong.Text;
                            DTO.HANSUDUNG = DateTime.Parse(txthansudung.Text).ToString();
                            DTO.GIAMUA = int.Parse(txtGiaMua.Text).ToString();
                            DTO.GIABAN = int.Parse(txtGiaBan.Text).ToString();

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
        
      
    }
}