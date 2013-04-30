using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
//////using WindowsFormsApplication1.class_TungLam;
using DevExpress.XtraEditors.DXErrorProvider;

namespace WindowsFormsApplication1
{
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            //if (DevComponents.DotNetBar.XtraMessageBoxEx.Show("Bạn có muốn thoát hay không ?", "Thông Báo", XtraMessageBoxButtons.OKCancel, XtraMessageBoxIcon.Warning, XtraMessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
                this.Close();
            //}
        }
        DTO DTO = new DTO();
        CTL CTRL = new CTL();
       
        ketnoi connect = new ketnoi();
        

        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string Nhan;
        public string TenKH, sMaKV, sMaNV, sMaBG, sTenKV, DIACHI, SDT, SOTK, NGANHANG, MASOTHUE, FAX, YAHOO, WEBSITE, SKYPE, TINHTRANG;
        public int kiemtra;
        public void loadma()
        {
           txtmakh.Text = connect.sTuDongDienMaKH(txtmakh.Text);
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
        //private void matudong()
        //{
        //    txtmakh.Text = connect.matudong(txtmakh.Text, sqlCmd, sqlCon);
        //}
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    string KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }


                    //try
                    //{
                    if (cmbtenkhuvuc.Properties.ValueMember.ToString() == "")
                    {
                        XtraMessageBox.Show("Vui Lòng Chọn Khu Vực ", "Thông Báo");
                        cmbtenkhuvuc.Focus();
                        return;
                    }
                    else if (txttenkh.Text == "")
                    {
                        XtraMessageBox.Show("Vui Lòng Nhập Tên Khách Hàng", "Thông Báo");
                        txttenkh.Focus();
                        return;
                    }

                   
                    else if (cmbtenkhuvuc.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Chọn Tên Khu Vực");
                        cmbtenkhuvuc.Focus();
                        return;
                    }

                    if (!PublicVariable.isBANGGIA)
                    {
                        if (cmbtennhanvien.Text == "")
                        {
                            XtraMessageBox.Show("Vui lòng Chọn Tên Nhân Viên Phụ Trách");
                            cmbtennhanvien.Focus();
                            return;
                        }

                        if (cmbbanggia.Text == "")
                        {
                            XtraMessageBox.Show("Vui lòng Chọn Bảng Giá Cho Đại Lý Này");
                            cmbbanggia.Focus();
                            return;
                        }
                    }

                    if (kiemtra == 1)
                    {

                        DTO.MAKH = txtmakh.Text;
                        DTO.MAKV = sMaKV;
                     
                        DTO.MANV = sMaNV;
                        DTO.MABG = sMaBG;
                    
                        DTO.TENKH = txttenkh.Text;
                        DTO.SOTAIKHOAN = txtsotaikhan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.DIACHI = txtdiachi.Text;

                        DTO.SDT = txtsdt.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.YAHOO = txtyahoo.Text;
                        DTO.SKYPE = txtnickskype.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.insertKhachHang(DTO);
                        XtraMessageBox.Show("Bạn Đã Thêm Thành Công");

                        this.Close();
                    }
                    else
                    {

                        DTO.MAKH = txtmakh.Text;
                        txtmakh.Enabled = false;
                        DTO.MAKV = sMaKV;
            
                        DTO.MANV = sMaNV;
                        DTO.MABG = sMaBG;
                    
                        DTO.TENKH = txttenkh.Text;
                        DTO.SOTAIKHOAN = txtsotaikhan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        // TXTSDT.Focus();
                        //TXTSDT.SelectAll();
                        DTO.SDT = txtsdt.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.YAHOO = txtyahoo.Text;
                        DTO.SKYPE = txtnickskype.Text;
                        DTO.TINHTRANG = KT;
                        // CTRL.insertKhachHang(DTO);
                        CTRL.updateKhachHang(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();

                    }

                }
                else
                {
                    string KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }


                    //try
                    //{
                    if (cmbtenkhuvuc.Properties.ValueMember.ToString() == "")
                    {
                        XtraMessageBox.Show("Please choose Area ", "Warming");
                        cmbtenkhuvuc.Focus();
                        return;
                    }
                    else if (txttenkh.Text == "")
                    {
                        XtraMessageBox.Show("Please Insert Name Of Custommer", "Warming");
                        txttenkh.Focus();
                        return;
                    }





                    //else if (cmbtinhtrang.Text == "")
                    //{
                    //    XtraMessageBox.Show("Please Choose Status");

                    //}
                    else if (cmbtenkhuvuc.Text == "")
                    {
                        XtraMessageBox.Show("Please Choose Name of Area ");
                        cmbtenkhuvuc.Focus();
                        return;
                    }

                    else if (kiemtra == 1)
                    {

                        DTO.MAKH = txtmakh.Text;
                        DTO.MAKV = sMaKV;
                        DTO.MANV = sMaNV;
                        DTO.MABG = sMaBG;
                        DTO.TENKH = txttenkh.Text;
                        DTO.SOTAIKHOAN = txtsotaikhan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.DIACHI = txtdiachi.Text;

                        DTO.SDT = txtsdt.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.YAHOO = txtyahoo.Text;
                        DTO.SKYPE = txtnickskype.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.insertKhachHang(DTO);
                        XtraMessageBox.Show("You Added Succeesful");

                        this.Close();
                    }
                    else
                    {

                        DTO.MAKH = txtmakh.Text;
                        txtmakh.Enabled = false;
                        DTO.MAKV = sMaKV;
                        DTO.MANV = sMaNV;
                        DTO.MABG = sMaBG;
                        DTO.TENKH = txttenkh.Text;
                        DTO.SOTAIKHOAN = txtsotaikhan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        // TXTSDT.Focus();
                        //TXTSDT.SelectAll();
                        DTO.SDT = txtsdt.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.YAHOO = txtyahoo.Text;
                        DTO.SKYPE = txtnickskype.Text;
                        DTO.TINHTRANG = KT;
                        // CTRL.insertKhachHang(DTO);
                        CTRL.updateKhachHang(DTO);
                        XtraMessageBox.Show("You Edited Succeesful ");
                        this.Close();

                    }
                }
        
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }   
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMAKH.Text = LamVN.MAKH.ToString();
            colTENKH.Text = LamVN.TENKH.ToString();
            colMAKV.Text = LamVN.TENKV.ToString();
            colSOTK.Text = LamVN.SOTAIKHOAN.ToString();
            colNGANHANG.Text = LamVN.NGANHANG.ToString();
            colMASOTHUE.Text = LamVN.MASOTHUE.ToString();
            colDIACHI.Text = LamVN.DIACHI.ToString();
            colSODT.Text = LamVN.SDT.ToString();
            colFAX.Text = LamVN.FAX.ToString();
            colWEBSITE.Text = LamVN.WEBSITE.ToString();
            colYAHOO.Text = LamVN.YAHOO.ToString();
            colNICKSKYPE.Text = LamVN.SKYPE.ToString();
            colTINHTRANG.Text = LamVN.TINHTRANG.ToString();
            lbCHUY.Text = LamVN.CHUY.ToString();
            btLuu.Text = LamVN.LUU.ToString();
            cotMaKV.Caption = LamVN.MAKV.ToString();
            cotTenKV.Caption = LamVN.TENKV.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMAKH.Text = LamEL.MAKH.ToString();
            colTENKH.Text = LamEL.TENKH.ToString();
            colMAKV.Text = LamEL.MAKV.ToString();
            colSOTK.Text = LamEL.SOTAIKHOAN.ToString();
            colNGANHANG.Text = LamEL.NGANHANG.ToString();
            colMASOTHUE.Text = LamEL.MASOTHUE.ToString();
            colDIACHI.Text = LamEL.DIACHI.ToString();
            colSODT.Text = LamEL.SDT.ToString();
            colFAX.Text = LamEL.FAX.ToString();
            colWEBSITE.Text = LamEL.WEBSITE.ToString();
            colYAHOO.Text = LamEL.YAHOO.ToString();
            colNICKSKYPE.Text = LamEL.SKYPE.ToString();
            colTINHTRANG.Text = LamEL.TINHTRANG.ToString();
            cotMaKV.Caption = LamEL.MAKV.ToString();
            cotTenKV.Caption = LamEL.TENKV.ToString();
            lbCHUY.Text = LamEL.CHUY.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString(); 
            checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            this.Text = "Form Insert Custommer"; 
        }

        DataView dvdropdow;
        public void loadgirdlookupKV()
        {

            cmbtenkhuvuc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cmbtenkhuvuc.Properties.DataSource = dvdropdow;
            cmbtenkhuvuc.Properties.DisplayMember = "TENKV";
            cmbtenkhuvuc.Properties.ValueMember = "MAKV";
            cmbtenkhuvuc.Properties.View.BestFitColumns();
            cmbtenkhuvuc.Properties.PopupFormWidth = 400;
            cmbtenkhuvuc.Properties.DataSource = CTRL.GETKHUVUC();

            cmbtennhanvien.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cmbtennhanvien.Properties.DataSource = dvdropdow;
            cmbtennhanvien.Properties.DisplayMember = "TENNV";
            cmbtennhanvien.Properties.ValueMember = "MANV";
            cmbtennhanvien.Properties.View.BestFitColumns();
            cmbtennhanvien.Properties.PopupFormWidth = 400;
            cmbtennhanvien.Properties.DataSource = CTRL.GETNV();

            cmbbanggia.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cmbbanggia.Properties.DataSource = dvdropdow;
            cmbbanggia.Properties.DisplayMember = "TENBG";
            cmbbanggia.Properties.ValueMember = "MABG";
            cmbbanggia.Properties.View.BestFitColumns();
            cmbbanggia.Properties.PopupFormWidth = 400;
            cmbbanggia.Properties.DataSource = CTRL.GETBG();
          
        }
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet35.KHUVUC' table. You can move, or remove it, as needed.
           // this.kHUVUCTableAdapter1.Fill(this.xUAT_NHAPTONDataSet35.KHUVUC);
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
                loadgirdlookupKV();
                txtmakh.Text = MACHUYEN;
                txttenkh.Text = TenKH;
                cmbtenkhuvuc.Text = sMaKV;
                cmbtennhanvien.Text = sMaNV;
                cmbbanggia.Text = sMaBG;
                txtdiachi.Text = DIACHI;
                txtmasothue.Text = MASOTHUE;
                txtnganhang.Text = NGANHANG;
                txtsdt.Text = SDT;
                txtwebsite.Text = WEBSITE;
                txtyahoo.Text = YAHOO;
                txtfax.Text = FAX;
                if (TINHTRANG == "True")
                {
                    checkTT.Checked = true;
                }
                else
                {
                    checkTT.Checked = false;
                }
                txtsotaikhan.Text = SOTK;
                txtnickskype.Text = SKYPE;  
            }
            else
            {
                loadma();
                loadgirdlookupKV();
            }


            if (PublicVariable.isBANGGIA)
            {
                cmbtennhanvien.Enabled = false;
                cmbbanggia.Enabled = false;
            }
            
        }

        private void btThemKhuVuc_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc th = new frmThemKhuVuc();
            th.kiemtra = 1; 
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
            loadgirdlookupKV();
           // this.kHUVUCTableAdapter1.Fill(this.xUAT_NHAPTONDataSet35.KHUVUC);
        }

        private void txtmakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void cmbtenkhuvuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtsotaikhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtnganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtmasothue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtyahoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtwebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void txtnickskype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);
            }
        }
        private void Validate_EmptyStringRule(BaseEdit control)
        {
            if (iNgonNgu == 0)
            {
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "Vui lòng Nhập Thông Tin Vào", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }
            else
            {
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }

        }
        private void Validate_Tu8den11kitu(BaseEdit control)
        {
            if (iNgonNgu == 0)
            {
                if (control.Text.Length < 8 || control.Text.Trim().Length > 11) dxErrorProvider1.SetError(control, "Số Điện Thoại Phải Nhập Từ 8->11 Số ", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");

            }
            else
            {
                if (control.Text.Length < 8 || control.Text.Trim().Length > 11) dxErrorProvider1.SetError(control, "The Phone Number must into between 8 to 11 number ", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }
           
        }
        private void cmbtenkhuvuc_Validating(object sender, CancelEventArgs e)
        {
            //Validate_EmptyStringRule(sender as BaseEdit);
            //cmbtenkhuvuc.Focus();
            //return;
            sMaKV= gridLookUpEdit1View.GetFocusedRowCellValue("MAKV").ToString();
        }

        private void txttenkh_Validating(object sender, CancelEventArgs e)
        {
            //Validate_EmptyStringRule(sender as BaseEdit);
            //txttenkh.Focus();
            //return;
        }

        private void txtsdt_Validating(object sender, CancelEventArgs e)
        {
            //Validate_EmptyStringRule(sender as BaseEdit);
            //Validate_Tu8den11kitu(sender as BaseEdit);
            //txtsdt.Focus();
            //return;
        }

        private void cmbtenkhuvuc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbtennhanvien_Validating(object sender, CancelEventArgs e)
        {
            sMaNV= gridView1.GetFocusedRowCellValue("MANV").ToString();
        }

        private void cmbbanggia_EditValueChanged(object sender, EventArgs e)
        {
            sMaBG = gridView2.GetFocusedRowCellValue("MABG").ToString();
        }

      

       
    }
}