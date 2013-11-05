using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;


namespace WindowsFormsApplication1
{
    public partial class frmActive : DevExpress.XtraEditors.XtraForm
    {
        public frmActive()
        {
            InitializeComponent();
        }

        private void btKetThuc_Click(object sender, EventArgs e)
        {
                if (XtraMessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    Application.Exit();
                }
            
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string CODEACTIVE = txtcode.Text;
            int INDEX = CODEACTIVE.IndexOf("-");
            if(INDEX<0)
            {
                MessageBox.Show("Mã Kích Hoạt Không Đúng");
                Application.Exit();
                return;
            }
            string CODE = CODEACTIVE.Substring(INDEX + 1, CODEACTIVE.Length - INDEX - 1);
            string ACTIVE = CODEACTIVE.Substring(0, INDEX);

            CTL ctl = new CTL();
            String SQL = "SELECT ACTIVE,CODERUN from ACTIVE WHERE ACTIVE="+ACTIVE+" AND CODE='"+CODE+"' AND TYPE=0";
            DataTable dt = new DataTable();
            try
            {
                dt = ctl.GETDATA(SQL);
            }
            catch
            {

            }
            if (dt.Rows.Count>0)
            {
                SaveRegistry(dt.Rows[0]["ACTIVE"].ToString(), dt.Rows[0]["CODERUN"].ToString());
                Ctrl_Tien CTR = new Ctrl_Tien();
                string UserHost_ComputerName5 = Environment.MachineName;
                CTR.ACTIVE_CODEACTIVE(ACTIVE, UserHost_ComputerName5);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã Kích Hoạt Không Đúng");
                Application.Exit();
            }
        }

        private void SaveRegistry(String ACTIVE,String CODERUN)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\vnvc", "ACTIVE", ACTIVE);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\vnvc", "CODERUN", CODERUN);
        }
     

       
    }
}