using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Globalization;
using System.Threading;
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
     
        public string tennv, manv, tendangnh, stinhtrang, machucvu;
        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
            {
                LoadEN();
            }
            
             LoadGLNhanVien();
             loadGLVaiTro();
            
        }
        public void LoadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbTaiKhoan.Text = LamEL.USERNAME.ToString();
            lbNhanVIen.Text = LamEL.TENNV.ToString();
            lbMatKhau.Text = LamEL.PASSWORD.ToString();
            lbBoPhan.Text = LamEL.TENBP.ToString();
            btDong.Text = LamEL.DONG.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            lbXacNhan.Text = "Comfirm";
            this.Text = "Add User";
           // checkEdit1.Text = "Active";
            colChucVu.Caption = LamEL.CHUCVU.ToString();
            colMaBoPhan.Caption = LamEL.MABP.ToString();
            colTen.Caption = LamEL.TENNV.ToString();
            layoutControlGroup6.Text = "The information required";
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbTaiKhoan.Text = LamVN.USERNAME.ToString();
            lbNhanVIen.Text = LamVN.TENNV.ToString();
            lbMatKhau.Text = LamVN.PASSWORD.ToString();
            lbBoPhan.Text = LamVN.TENBP.ToString();
            btDong.Text = LamVN.DONG.ToString();
            btLuu.Text = LamVN.LUU.ToString();
            lbXacNhan.Text = "Xác nhận";
            this.Text = "Thêm người dùng";
           // checkEdit1.Text = "Kich hoạt";
            colChucVu.Caption = LamVN.CHUCVU.ToString();
            colMaBoPhan.Caption = LamVN.MABP.ToString();
            colTen.Caption = LamVN.TENNV.ToString();
            layoutControlGroup6.Text = "Thông tin bắt buộc";
        }
        private void loadGLVaiTro()
        {
            glVaiTro.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            glVaiTro.Properties.DisplayMember = "TENBOPHAN";
            glVaiTro.Properties.ValueMember = "MABP";
            glVaiTro.Properties.View.BestFitColumns();
            glVaiTro.Properties.PopupFormWidth = 300;
            glVaiTro.Properties.DataSource = ctr.getBoPhan();
           
        }

        private void LoadGLNhanVien()
        {
            glNhanVien.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            glNhanVien.Properties.DisplayMember = "TENNV";
            glNhanVien.Properties.ValueMember = "MANV";
            glNhanVien.Properties.View.BestFitColumns();
            glNhanVien.Properties.PopupFormWidth = 300;
            glNhanVien.Properties.DataSource = ctr.getNhanVien();
        }
        private void Validate_Tu6den15kitu(BaseEdit control)
        {
            string sThongBao;
            if (iNgonNgu == 0)
            {
                sThongBao = " Phải nhập từ 2 đến 15 kí tự";
            }
            else
            {
                sThongBao = "You must enter from 6 to 15  character";
            }
            if (control.Text.Length<2 || control.Text.Trim().Length >15) dxErrorProvider1.SetError(control, sThongBao,ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }
        private void Validate_EmptyStringRule(BaseEdit control)
        {
            string sThongBao;
            if (iNgonNgu == 0)
            {
                sThongBao = " Không được bỏ trống";
            }
            else
            {
                sThongBao = "No empty";
            }
            if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, sThongBao, ErrorType.Critical);          
            else dxErrorProvider1.SetError(control, "");
        }
        private void Validate_LessThanMinRule(BaseEdit control, Decimal min)
        {
            if (!(control.EditValue is Decimal)) return;
            if ((Decimal)control.EditValue < min) dxErrorProvider1.SetError(control, "Please enter a greater value than " + min.ToString(), ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }
        private void Validate_BetweenMinAndMaxRule(BaseEdit control, Decimal min, Decimal max)
        {
            if (!(control.EditValue is Decimal)) return;
            Decimal val = (Decimal)control.EditValue;
            if ((val < min)) dxErrorProvider1.SetError(control, "Please enter a greater value than " + (min * 100).ToString(), ErrorType.Warning);
            else if (val > max) dxErrorProvider1.SetError(control, "Please enter a value less than " + (max * 100).ToString(), ErrorType.Information);
            else dxErrorProvider1.SetError(control, "");
        }

        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
            Validate_Tu6den15kitu(sender as BaseEdit);
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
            Validate_Tu6den15kitu(sender as BaseEdit);
        }
        public static string MaHoa(string cleanString)
        {
            Byte[] clearBytes = new UnicodeEncoding().GetBytes(cleanString);
            Byte[] hashedBytes = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);

            return BitConverter.ToString(hashedBytes);
        }
        private void txtXacNhan_Validating(object sender, CancelEventArgs e)
        {


        }
        clDTO dto = new clDTO();
      
        public int iNgonNgu=1;
        public string KT;
        private void btLuu_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (glNhanVien.Text=="")
                    {
                        if (iNgonNgu == 1)
                        {
                            XtraMessageBox.Show("Please choose empleyee");
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Chọn nhân viên");
                            return;
                        }
                    }
                    if (txtTaiKhoan.Text=="")
                    {
                         Validate_EmptyStringRule(txtTaiKhoan);
                         txtTaiKhoan.Focus();
                         return;
                    }
                    if (txtTaiKhoan.Text.Length<6||txtTaiKhoan.Text.Length>15)
                    {
                        Validate_Tu6den15kitu(txtTaiKhoan);
                        txtTaiKhoan.Focus();
                        return;
                    }
                    if (txtMatKhau.Text=="")
                    {
                         Validate_EmptyStringRule(txtMatKhau);
                         txtMatKhau.Focus();
                         return;
                         
                    }
                    if (txtMatKhau.Text.Length < 6 || txtMatKhau.Text.Length> 15)
                    {

                        Validate_Tu6den15kitu(txtMatKhau);
                        txtMatKhau.Focus();
                        return;
                        
                    }
                   
                    if (txtMatKhau.Text != txtXacNhan.Text)
                    {
                        XtraMessageBox.Show("Comfirm pass fail");
                        txtXacNhan.SelectAll();
                        txtXacNhan.Focus();
                        return;
                    }
                    if (glVaiTro.Text=="")
                    {
                        if (iNgonNgu == 1)
                        {
                            XtraMessageBox.Show("Please choose deparment");
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Vui lòng chọn bộ phận");
                            return;
                        }
                    }
                    dto.MANV = glNhanVien1.GetFocusedRowCellValue("MANV").ToString();
                    dto.TENDANGNHAP = txtTaiKhoan.Text;
                    dto.MATKHAU = txtMatKhau.Text;
                    dto.MABOPHAN = glVaiTro1.GetFocusedRowCellValue("MABP").ToString();

                    dto.TINHTRANG = true;
                    DataTable tb = new DataTable();
                    tb= ctr.kiemtra_user(dto);
                    if (tb.Rows.Count == 0)
                    {
                        ctr.THEMNGUOIDUNG_UPDATE(dto);
                       
                    
                        if (iNgonNgu == 1)
                        {
                            XtraMessageBox.Show("Add sucessfully");
                            
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm thành công");
                           
                        }

                    }
                    else
                    {
                        if (iNgonNgu == 1)
                        {
                            XtraMessageBox.Show("Duplicate Username");
                        }
                        else
                        {
                            XtraMessageBox.Show("Trùng tên đăng nhập");
                        }
                        
                    }
                    
                   
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message);
                   
                }
                this.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

  
    }
}