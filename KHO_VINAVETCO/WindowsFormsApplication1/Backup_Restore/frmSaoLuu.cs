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
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        private delegate void TimerDelegate(object sender, ElapsedEventArgs e);
        private System.Timers.Timer ticker;
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public frmSaoLuu()
        {
            InitializeComponent();
            ticker = new System.Timers.Timer();
            ticker.Elapsed += new ElapsedEventHandler(ticker_Elapsed);
            ticker.Interval = 250;            
        }
        private void loadReSVN()
        {
          CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
          lbTenFile.Text = resVietNam.lbDienTen.ToString();
          lbDuongDan.Text = resVietNam.lbDuongDan.ToString();
          btDong.Text = resVietNam.btDong.ToString();
          btLuu.Text = resVietNam.btLuu.ToString();
          this.Text = resVietNam.btSaoLuu.ToString();
           


        }

        private void loadReSEG()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbTenFile.Text = resEngLand.lbDienTen.ToString();
            lbDuongDan.Text = resEngLand.lbDuongDan.ToString();
            btDong.Text = resEngLand.btDong.ToString();
            btLuu.Text = resEngLand.btLuu.ToString();
            this.Text = resEngLand.btSaoLuu.ToString();
            

        }
        void ticker_Elapsed(object sender, ElapsedEventArgs e)
        {
           // prgProgress.Value = (prgProgress.Value + 1) % prgProgress.Maximum;
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new TimerDelegate(ticker_Elapsed), sender, e);
            //}
            //else
            //{
            //    if (prgProgress.Value == prgProgress.Maximum)
            //    {
            //        prgProgress.Value = 0;
            //    }
            //    else
            //    {
            //        prgProgress.Value += 20;
            //    }
            //}
        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdgl = new FolderBrowserDialog();
            if (fdgl.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = fdgl.SelectedPath.ToString();
            }
        }
        clDTO dto = new clDTO();
        clCtrl ctrl = new clCtrl();
        private void btLuuDuLieu_Click(object sender, EventArgs e)
        {
            
        }
        private void frmSaoLuu_Load(object sender, EventArgs e)
        {
            txtTenFile.Text = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_"+"ProMag";
            if (iNgonNgu==0)
            {
                loadReSVN();
            }
            if (iNgonNgu==1)
            {
                loadReSEG();
            }
            
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.TATCA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            string sFileName = txtDuongDan.Text + "\\" + txtTenFile.Text + ".bak";
            if (txtTenFile.Text == "")
            {
                if (iNgonNgu == 0)
                {
                    MessageBoxEx.Show("Vui lòng điền tên cần lưu");

                }
                else
                {
                    XtraMessageBox.Show("  Please select the file");
                }

            }
            else if (txtDuongDan.Text == "")
            {

                if (iNgonNgu == 0)
                {
                    MessageBoxEx.Show("Vui lòng chọn đường dẫn");

                }
                else
                {
                    XtraMessageBox.Show("  Please select path");
                }
            }
            else
            {
                if (File.Exists(sFileName))
                {
                    if (XtraMessageBox.Show("Đã có một file tại vị trí bạn lưu, Bạn có muốn ghi ghi đè không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Loadingggg ld = new Loadingggg();
                        ld.CreateWaitDialog();
                        ld.SetWaitDialogCaption("Đang sao luu dữ liệu - Vui Lòng Chờ");
                        ticker.Start();
                        this.Cursor = Cursors.WaitCursor;
                        File.Delete(sFileName);
                        dto.TENFILE = sFileName;
                        ctrl.Back_Up(dto);
                        ld.simpleCloseWait();

                        PublicVariable.TMPtring = "KETSO";
                        if (iNgonNgu == 0)
                        {
                            XtraMessageBox.Show("Lưu trữ cơ sở dữ liệu thành công");
                        }
                        else
                        {
                            XtraMessageBox.Show("Backup database succesfully");
                        }
                        try
                        {
                            deDongTab();
                        }
                        catch
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        txtTenFile.Focus();
                        txtTenFile.SelectAll();
                    }
                }
                else
                {
                    Loadingggg ld = new Loadingggg();
                    ld.CreateWaitDialog();
                    ld.SetWaitDialogCaption("Đang sao luu dữ liệu - Vui Lòng Chờ");

                    dto.TENFILE = sFileName;
                    ctrl.Back_Up(dto);
                    //prgProgress.Value = 0;
                    //prgProgress.Update();
                    //prgProgress.Refresh();
                    //ticker.Stop();
                    ld.simpleCloseWait();
                    PublicVariable.TMPtring = "KETSO";
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Lưu trữ cơ sở dữ liệu thành công");

                    }
                    else
                    {
                        XtraMessageBox.Show("Backup database succesfully");
                    }
                    try
                    {
                        deDongTab();
                    }
                    catch
                    {
                        this.Close();
                    }
                }
            }
       
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdgl = new FolderBrowserDialog();
            if (fdgl.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = fdgl.SelectedPath.ToString();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            try
            {
                deDongTab();
            }
            catch
            {
                this.Close();
            }
        }

        private void frmSaoLuu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                deDongTab();
            }
            catch
            {
                this.Close();
            }
        }

    
    }
}