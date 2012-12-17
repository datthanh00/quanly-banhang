using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsFormsApplication1
{
    public partial class frmCongNoKH : DevExpress.XtraEditors.XtraForm
    {
        public frmCongNoKH()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public void loadGetAllHDX()
        {
            dt = Ctrl_Tien.GETALLHDX_ctrl();
            gridControl1.DataSource = dt;
        }
        public void loadGetAllPHIEUCHI()
        {
            dt = Ctrl_Tien.GETALLPHIEUCHI_ctrl();
            gridControl2.DataSource = dt;
        }
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
           
        private void frmCongNoKH_Load(object sender, EventArgs e)
        {
            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEL);
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            loadGetAllHDX();
            load_congno();
        }
        public string smaKH;
        public string sTienno;
        public string sMahdx;
        public string smpt;
        public string smahdx;
        public string stientra;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sMahdx = dtr[0].ToString();
                smaKH = dtr[2].ToString();
                sTienno = dtr[6].ToString();
                //dt = Ctrl_Tien.get1pthdx_ctrl(dtr[0].ToString());
                //gridControl2.DataSource = dt;
            }
            catch 
            {

               // MessageBox.Show(ex.Message);
            }
        }
        public string sMaNV, sTenNV;

        public void load_congno()
        {
            panel_congno.Visible = true;
            panel_phieuchi.Visible = false;

            groupControl_congno.Visible = true;
            groupControl_congno.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl_phieuthu.Visible = false;
            gridView1.ExpandAllGroups();
        }
        public void load_phieuthu()
        {
            panel_congno.Visible = false;
            panel_phieuchi.Visible = true;

            groupControl_congno.Visible = false;
            groupControl_phieuthu.Visible = true;
            groupControl_phieuthu.Dock = System.Windows.Forms.DockStyle.Fill;
            gridView2.ExpandAllGroups();
        }
        private void btThutien_Click(object sender, EventArgs e)
        {
            loadfrm_thutien();
        }
        public void loadfrm_thutien()
        {
            FrmThuTien frm = new FrmThuTien();
            if (this.smaKH == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 hóa đơn để thu tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");

            }
            else
            {
                frm.Nhan = "Them";
                frm.MaChuyen = sMahdx;
                frm.Tienno = sTienno;
                frm.iNgonNgu = this.iNgonNgu;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;
                frm.ShowDialog();
                loadGetAllHDX();
                //loadctkh();
                load_congno();
            }
        }
        private void btneditthutien_Click(object sender, EventArgs e)
        {
            FrmThuTien frm = new FrmThuTien();
            if (this.smpt == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu thu để sửa lại số tiền vừa trả");
                }
                else
                    XtraMessageBox.Show("You must select a bill to update paid money!!!");

            }
            else
            {
                frm.Nhan = "Sua";
                frm.MaPT = smpt;
                frm.HD = smahdx;
                frm.TIEN = stientra;
                frm.sMaNV = sMaNV;

                frm.Tienno = Ctrl_Tien.GETcongno_HDX(smahdx);
                frm.iNgonNgu = this.iNgonNgu;
                
                frm.sTenNV = sTenNV;
                frm.ShowDialog();
                loadGetAllHDX();
                //loadctkh();
                load_phieuthu();
            }
        }
 

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr1 = gridView2.GetDataRow(e.RowHandle);
                smpt = dtr1[0].ToString();
                sMaNV = dtr1[1].ToString();
                smahdx=dtr1[2].ToString();
                stientra = dtr1[4].ToString();
               
            }
            catch 
            {
                //MessageBox.Show(ex.Message);
                
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                DataRow dtr = gridView1.GetDataRow(hitInfo.RowHandle);
                sMahdx = dtr[0].ToString();
                smaKH = dtr[2].ToString();
                sTienno = dtr[6].ToString();
                loadfrm_thutien();
            }
        }
        public void loadctkh()
        {
            //DataTable dt = new DataTable();
            dt = Ctrl_Tien.get1pthdx_ctrl(sMahdx);
            gridControl2.DataSource = dt;
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barThuTien.Caption = Tien_VN.barThuTien.ToString();
            barSuaTien.Caption = Tien_VN.barSuaTien.ToString();
            colMãhóađơnxuất.Caption = Tien_VN.colMãhóađơnxuất.ToString();
            colTênkháchhàng.Caption = Tien_VN.colTênkháchhàng.ToString();
            colTiềnđãtrả.Caption = Tien_VN.colTiềnđãtrả.ToString();
            colTiềnphảitrả.Caption = Tien_VN.colTiềnphảitrả.ToString();
            colCònlại.Caption = Tien_VN.colCònlại.ToString();
            colMãphiếuthu.Caption = Tien_VN.colMãphiếuthu.ToString();
            colMãhóađơnxuất1.Caption = Tien_VN.colMãhóađơnxuất1.ToString();
            colTiềnđãtrả1.Caption = Tien_VN.colTiềnđãtrả1.ToString();
            colMãnhânviên.Caption = Tien_VN.colMãnhânviên.ToString();
            colNgàythu.Caption = Tien_VN.colNgàythu.ToString();
            groupControl_congno.Text = Tien_VN.groupControl1.ToString();
            groupControl_phieuthu.Text = Tien_VN.groupControl2.ToString();
            barBtDong.Caption = Tien_VN.barstDong.ToString();
            colMãkháchhàng.Caption = Tien_VN.colMãkháchhàng.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barThuTien.Caption = Tien_EL.barThuTien.ToString();
            barSuaTien.Caption = Tien_EL.barSuaTien.ToString();
            colMãhóađơnxuất.Caption = Tien_EL.colMãhóađơnxuất.ToString();
            colTênkháchhàng.Caption = Tien_EL.colTênkháchhàng.ToString();
            colTiềnđãtrả.Caption = Tien_EL.colTiềnđãtrả.ToString();
            colTiềnphảitrả.Caption = Tien_EL.colTiềnphảitrả.ToString();
            colCònlại.Caption = Tien_EL.colCònlại.ToString();
            colMãphiếuthu.Caption = Tien_EL.colMãphiếuthu.ToString();
            colMãhóađơnxuất1.Caption = Tien_EL.colMãhóađơnxuất1.ToString();
            colTiềnđãtrả1.Caption = Tien_EL.colTiềnđãtrả1.ToString();
            colMãnhânviên.Caption = Tien_EL.colMãnhânviên.ToString();
            colNgàythu.Caption = Tien_EL.colNgàythu.ToString();
            groupControl_congno.Text = Tien_EL.groupControl1.ToString();
            groupControl_phieuthu.Text = Tien_EL.groupControl2.ToString();
            barBtDong.Caption = Tien_EL.barstDong.ToString();
            colMãkháchhàng.Caption = Tien_EL.colMãkháchhàng.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void linkcongno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            load_congno();
        }

        private void linkphieuthu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadGetAllPHIEUCHI();
            load_phieuthu();
        }

        

      

       
    }
}