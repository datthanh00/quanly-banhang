using System;
using System.Text;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Globalization;
using System.Threading;
using System.Configuration;
using Quanlykho;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;


namespace WindowsFormsApplication1
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btKetThuc_Click(object sender, EventArgs e)
        {
            if (iNgonNgu == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to exit ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmCauHinhHeThong cauhinh = new frmCauHinhHeThong();
            cauhinh.ShowDialog();
        }

        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO(); 
        public static string MaHoa(string cleanString)
        {
            Byte[] clearBytes = new UnicodeEncoding().GetBytes(cleanString);
            Byte[] hashedBytes = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
            return BitConverter.ToString(hashedBytes);
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text=="")
            {
               
              Validate_EmptyStringRule(txtTenTaiKhoan);
              if (iNgonNgu == 0)
              {
                  XtraMessageBox.Show("Vui lòng nhập tên");
                  return;
              }
              else
              {
                  XtraMessageBox.Show("Please input username");
                  return;
              }
            }
            if (txtMatKhau.Text=="")
            {
                Validate_EmptyStringRule(txtMatKhau);
                if (iNgonNgu==0)
                {
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                }
                else 
                {
                    XtraMessageBox.Show("Please input password");
                    return;
                }
                
            }  
             
            dto.TENDANGNHAP=txtTenTaiKhoan.Text;
            dto.MATKHAU=txtMatKhau.Text;
            DataTable tb = new DataTable(); 
            tb= ctr.ctrTestLogin(dto);
            ctr.ctrISnewyear();
            if (tb.Rows.Count > 0)
            {
             
                if (tb.Rows[0]["tinhtrang"].ToString() == "False")
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Bạn đang trong tình trạng chưa kích hoạt");
                    }
                    else
                    {
                        XtraMessageBox.Show("You are in a state may be activated");
                    }

                }
                else
                {
                    this.Hide();
                    frmLoad frm = new frmLoad();
                    frm.sTennv = tb.Rows[0]["tennv"].ToString();
                    frm.sBoPhan = tb.Rows[0]["mabp"].ToString();
                    frm.sManv = tb.Rows[0]["manv"].ToString();
                    PublicVariable.MANV = tb.Rows[0]["manv"].ToString();
                    frm.iNgonNgu = iNgonNgu;
                    frm.ShowDialog();
                    SaveRegistry();
                }
               
            }
            else
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                }
                else
                {
                    XtraMessageBox.Show("Username or pasword wrong");
                }
                
            }
             
        }
        
        private void SaveRegistry()
        {
            string TENCTY = "";
            if (PublicVariable.IS_VINAVETCO)
            {
                TENCTY = "vnvc";
            }
            else
            {
                TENCTY = "tuanhanh";
            }
            if (checkNho.Checked == true)
            {

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\"+TENCTY, "Chk", "1");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "ID", txtTenTaiKhoan.Text);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "PSS", txtMatKhau.Text);
            }
            else if (checkNho.Checked == false)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "Chk", "0");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "ID", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "PSS", "");
            }
        }
        private void LoadRegistry()
        {
            string TENCTY = "";
            if (PublicVariable.IS_VINAVETCO)
            {
                TENCTY = "vnvc";
            }
            else
            {
                TENCTY = "tuanhanh";
            }
            txtTenTaiKhoan.Text = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "ID", null));
            txtMatKhau.Text = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "PSS", null);
            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "Chk", null) == "1")
            {
                checkNho.Checked = true;
            }
            if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "Chk", null) == "0")
            {
                checkNho.Checked = false;
            }

            string ACTIVE = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "ACTIVE", null);
            string CODERUN = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\" + TENCTY, "CODERUN", null);
            if (ACTIVE != "" && CODERUN != "")
            {
                CTL ctl = new CTL();
                String SQL = "SELECT CODERUN from ACTIVE WHERE ACTIVE='" + ACTIVE + "' AND CODERUN='" + CODERUN + "' AND TYPE=1";
                DataTable dt=new DataTable();
                try
                {
                    dt = ctl.GETDATA(SQL);
                }
                catch
                {

                }
                if (dt.Rows.Count <= 0)
                {
                    frmActive active = new frmActive();
                    active.ShowDialog();
                }
            }
            else
            {
                frmActive active = new frmActive();
                active.ShowDialog();
            }

        }
        System.Configuration.Configuration NgonNguVA = ConfigurationManager.OpenExeConfiguration("NgonNgu");
        public int iNgonNgu;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string current = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            System.Diagnostics.Process[] procs;
            procs = System.Diagnostics.Process.GetProcessesByName(current);
            if (procs.Length >= 2)
            {
                MessageBox.Show("chương trình đang chạy trên máy tính bạn rồi!");
                Application.ExitThread();
                Application.Exit();
                return;
            }
            CHECKVERSION();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = NgonNguVA.AppSettings.Settings["Skin"].Value;
            iNgonNgu = int.Parse(NgonNguVA.AppSettings.Settings["NgonNgu"].Value);
            if (iNgonNgu == 1)
            {
                loadEN();
            }
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            txtTenTaiKhoan.Focus();
            LoadRegistry();
        }
        public void CHECKVERSION()
        {
            
            CTL ctl = new CTL();
            String SQL = "SELECT VERSION  from THONGTINCT";
            DataTable dt = new DataTable();
            try
            {
                dt = ctl.GETDATA(SQL);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Kiểm Tra Lại Kết Nối InterNet nếu không được thì gọi cho Thành SĐT:0907093902");
                Application.ExitThread();
                Application.Exit();
                return;
            }
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Kiểm Tra Lại DATABASE. gọi cho Thành SĐT:0907093902//FRMLOGIN.ROWS 281");
                Application.ExitThread();
                Application.Exit();
                return;
            }
            else
            {
                int lastversion = Convert.ToInt32(dt.Rows[0][0].ToString());
                if (PublicVariable.VERSION<lastversion)
                {
                    MessageBox.Show("VUI LÒNG CẬP NHẬT PHẦN MỀM MỚI ĐỂ SỦ DỤNG. PHẦN MỀM NÀY ĐÃ ĐƯỢC NÂNG CẤP LÊN PHIÊN BẢN MỚI");
                    Application.ExitThread();
                    Application.Exit();
                }
            }
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            //lbTenTaiKhoan.Text = LamVN.USERNAME.ToString();
            //lbMatKhau.Text = LamVN.PASSWORD.ToString();
            //lbDangNhap.Text = resVietNam.DangNhap.ToString();
            btDangNhap.Text = resVietNam.DangNhap.ToString();
            btTuyChon.Text = resVietNam.TuyChon.ToString();
            btKetThuc.Text = LamVN.DONG.ToString();
            checkNho.Text = resVietNam.checkNho.ToString();
           // this.Text = "Đăng nhập tài khoản";
        }
        public void loadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            //lbTenTaiKhoan.Text = LamEL.USERNAME.ToString();
            //lbMatKhau.Text = LamEL.PASSWORD.ToString();
           // lbDangNhap.Text = resEngLand.DangNhap.ToString();
            btDangNhap.Text = resEngLand.DangNhap.ToString();
            btTuyChon.Text = resEngLand.TuyChon.ToString();
            btKetThuc.Text = LamEL.DONG.ToString();
            checkNho.Text = resEngLand.checkNho.ToString();
         //   this.Text = "Login account";
          

        }
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }

        private void txtTenTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            Validate_EmptyStringRule(sender as BaseEdit);
        }
    }
}