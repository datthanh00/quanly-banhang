using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using WindowsFormsApplication1.Class_ManhCuong;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Globalization;
using System.Threading;
using System.Configuration;


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
            CTL ctl = new CTL();
            String SQL = "SELECT CODEACTIVE,CODERUNT from THONGTINCT";
            DataTable dt = ctl.GETDATA(SQL);
            if (dt.Rows[0]["CODEACTIVE"].ToString() == txtcode.Text)
            {
                SaveRegistry(dt.Rows[0]["CODERUNT"].ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã Kích Hoạt Không Đúng");
                Application.Exit();
            }
        }

        private void SaveRegistry(String CODERUNT)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\SaveUserAndPassword", "ACTIVE", CODERUNT);
        }
     

       
    }
}