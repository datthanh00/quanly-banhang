using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Globalization;
using System.Threading;
using WindowsFormsApplication1.Class_ManhCuong;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1
{
    public partial class frmKhoiPhuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiPhuc()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void btDongKhoiPhuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdlg = new OpenFileDialog();
            opdlg.Title = "Chọn cơ sở dữ liệu cần phục hồi";
            opdlg.Multiselect = false;
            opdlg.Filter = "Database (bak) | *.bak";
            if (opdlg.ShowDialog() == DialogResult.OK)
            {
                txtTapTin.Text = opdlg.FileName;
            }
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (txtTapTin.Text != "")
            {
                Loadingggg ld = new Loadingggg();
                ld.CreateWaitDialog();
                ld.SetWaitDialogCaption("Đang khôi phục dữ liệu - Vui Lòng Chờ");

               
                clCtrl ctr = new clCtrl();
                clDTO dto = new clDTO();
                dto.TENFILE = txtTapTin.Text;
                ctr.ReStore(dto);
                ld.simpleCloseWait();
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Phục hồi cơ sở dữ liệu thành công");

                }
                else
                {
                    XtraMessageBox.Show("Restore database success");
                }
            }
            else
                 if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng chọn tập tin");
                }
                else
                {
                    XtraMessageBox.Show("  Please select the file");
                }
             
           
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int iNgonNgu;
        private void frmKhoiPhuc_Load(object sender, EventArgs e)
        {
            if (iNgonNgu==0)
            {
                loadReSVN();

            }
            if (iNgonNgu==1)
            {
                loadReSEG();
            }
        }
        private void loadReSVN()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbChonTapTinh.Text = resVietNam.lbTenFile.ToString();
           
            btDong.Text = resVietNam.btDong.ToString();
            btKhoiPhuc.Text = resVietNam.btPhucHoi.ToString();
            this.Text = resVietNam.btPhucHoi.ToString();



        }

        private void loadReSEG()
        {

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbChonTapTinh.Text = resEngLand.lbTenFile.ToString();

            btDong.Text = resEngLand.btDong.ToString();
            btKhoiPhuc.Text = resEngLand.btPhucHoi.ToString();
            this.Text = resEngLand.btPhucHoi.ToString();


        }
    }
}