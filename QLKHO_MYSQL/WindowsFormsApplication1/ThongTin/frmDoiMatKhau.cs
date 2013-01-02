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
namespace WindowsFormsApplication1
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public string sMaNV;
        DataTable tb = new DataTable();
        public int iNgonNgu;
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
        private void Validate_Tu6den15kitu(BaseEdit control)
        {
            string sThongBao;
            if (iNgonNgu == 0)
            {
                sThongBao = " Phải nhập từ 6 đến 15 kí tự";
            }
            else
            {
                sThongBao = "You must enter from 6 to 15  character";
            }
            if (control.Text.Length < 6 || control.Text.Trim().Length > 15) dxErrorProvider1.SetError(control, sThongBao, ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (txtPassCu.Text=="")
            {
                Validate_EmptyStringRule(txtPassCu);
                txtPassCu.Focus();
                return;
            }
            if (txtPassMoi.Text == "")
                {
                    Validate_EmptyStringRule(txtPassMoi);
                    txtPassMoi.Focus();
                    return;
                }
            if (txtPassMoi.Text.Length < 6 || txtPassMoi.Text.Length > 15)
            {
                Validate_Tu6den15kitu(txtPassMoi);
                txtPassMoi.Focus();
                return;
            }
            if (txtPassMoi.Text != txtPassXacNhan.Text)
            {

                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Xác nhận mật khẩu sai");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Comfirm pass incortect");
                    return;
                }
                txtPassXacNhan.Focus();
            }
            dto.MATKHAU = txtPassCu.Text;
            dto.MANV = sMaNV;
            tb = ctr.KiemTraPass(dto);
            if (tb.Rows.Count > 0)
            {
                dto.MANV = sMaNV;
                dto.MATKHAU = txtPassXacNhan.Text;
                ctr.DoiMatKhau(dto);
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Sửa thành công");
                }
                else
                    XtraMessageBox.Show("Change pass Succesfully");
                this.Close();
            }
            else
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Mật khẩu cũ không đúng");
                }
                else
                    XtraMessageBox.Show("Old password is incorrect");
            }
        }
   
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
      

            if (PublicVariable.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                LoadEN();

        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

            lbMatKhauCu.Text = "Mật khẩu cũ";
            lbMatKhauMoi.Text = "Mật khẩu mới";
            this.Text = "Đổi mật khẩu";
            // checkEdit1.Text = "Active";
            lbXacNhan.Text = "Xác nhận mật khẩu mới";
            btLuu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();
        }
        public void LoadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMatKhauCu.Text = "Old passoword";
            lbMatKhauMoi.Text = "New passoword";
            this.Text = "Change password";
            // checkEdit1.Text = "Active";
            lbXacNhan.Text = LamEL.PASSWORD1.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassCu_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
        }

        private void txtPassMoi_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
        }
    }
}