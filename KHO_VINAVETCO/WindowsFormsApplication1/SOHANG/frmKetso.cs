using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Timers;
using WindowsFormsApplication1.Class_ManhCuong;
using System.Globalization;
using System.Threading;
using DevExpress.XtraEditors;
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmKetso : DevExpress.XtraEditors.XtraForm
    {
        private delegate void TimerDelegate(object sender, ElapsedEventArgs e);
        public int iNgonNgu;
        public frmKetso()
        {
            InitializeComponent();
                     
        }

        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
           
            btDong.Text = resEngLand.btDong.ToString();
            btLuu.Text = resEngLand.btLuu.ToString();
            this.Text = resEngLand.btSaoLuu.ToString();
            

        }

   
        clCtrl ctrl = new clCtrl();

        private void frmSaoLuu_Load(object sender, EventArgs e)
        {
            
           
            PublicVariable.TMPtring = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (PublicVariable.TATCA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (PublicVariable.TMPtring != "KETSO")
            {
                if (XtraMessageBox.Show("Bạn Chưa sao lưu dữ liệu, Bạn có muốn sao lưu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    frmSaoLuu dt = new frmSaoLuu();
                   // dt.deDongTab = new frmSaoLuu._deDongTab();
                    dt.ShowDialog();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có chắc thực hiện kết sổ không, Kết sổ sẽ xóa hết dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // ctrl.KET_SO();
                   // MessageBox.Show("ĐÃ KẾT SỔ");
                    MessageBox.Show("TẠM THỜI KHÓA CHỨC NĂNG NÀY TRONG CODE YEU CAU LAP TRINH LAI");
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PublicVariable.TATCA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frmSaoLuu frmSaoLuu1 = new frmSaoLuu();
            frmSaoLuu1.ShowDialog();
        }

        private void frmKetso_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }
    }
}