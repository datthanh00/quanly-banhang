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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsFormsApplication1
{
    public partial class frmCongNoNcc : DevExpress.XtraEditors.XtraForm
    {
        public frmCongNoNcc()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public string smaNcc;
        public string sTienno;
        public string sMahdn;
        public string smpc;
        public string smahdn;
        public string stientra;
        public string sMaNV, sTenNV;
        public void loadGetAllHDN()
        {
            //dt = Ctrl_Tien.GETALLHDn_ctrl();
            dt = Ctrl_Tien.GETALLcongno_ncc();
            gridControl1.DataSource = dt;
        }
        public void loadGetAllphieuchi()
        {
            //dt = Ctrl_Tien.GETALLHDn_ctrl();
            dt = Ctrl_Tien.Getall_phieuchi_Dao();
            gridControl2.DataSource = dt;
        }
        public void loadctncc()
        {
            dt = Ctrl_Tien.get1pthdn_ctrl(sMahdn);
            gridControl2.DataSource = dt;
        }
         public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        
        private void frmCongNoNcc_Load(object sender, EventArgs e)
        {
            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEL);
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            
            loadGetAllHDN();
            load_congno();
        }
        public void load_congno()
        {
            panel_congno.Visible = true;
            panel_phieuchi.Visible = false;

            groupControl_congno.Visible = true;
            groupControl_congno.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl_phieuchi.Visible = false;
            gridView1.ExpandAllGroups();
        }
        public void load_phieuchi()
        {
            panel_congno.Visible = false;
            panel_phieuchi.Visible = true;

            groupControl_congno.Visible = false;
            groupControl_phieuchi.Visible = true;
            groupControl_phieuchi.Dock = System.Windows.Forms.DockStyle.Fill;
            gridView2.ExpandAllGroups();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
                if (hitInfo.InRow)
                {
                    DataRow dtr = gridView1.GetDataRow(hitInfo.RowHandle);
                    sMahdn = dtr[0].ToString();
                    smaNcc = dtr[2].ToString();
                    sTienno = dtr[6].ToString();
                    loadfrm_tratien();
                }
        }

        
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sMahdn = dtr[0].ToString();
                smaNcc = dtr[2].ToString();
                sTienno = dtr[6].ToString();

            }
            catch
            {
                //XtraMessageBox.Show(ex.Message);

            }
            
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barTraTien.Caption = Tien_VN.barTraTien.ToString();
            barSuaTien.Caption = Tien_VN.barSuaTien.ToString();
            colMãhóađơnnhập.Caption = Tien_VN.colMãhóađơnnhập.ToString();
            colTênnhàcungcấp.Caption = Tien_VN.colTênnhàcungcấp.ToString();
            colMãnhàcungcấp.Caption = Tien_VN.colMãnhàcungcấp.ToString();
            colTiềnphảitrả.Caption = Tien_VN.colTiềnphảitrả.ToString();
            colTiềnđãtrả.Caption = Tien_VN.colTiềnđãtrả.ToString();
            colCònlại.Caption = Tien_VN.colCònlại.ToString();
            colMãphiếuchi.Caption = Tien_VN.colMãphiếuchi.ToString();
            //colTênnhânviên.Caption = Tien_VN.colTênnhanvien.ToString();
            colMãhóađơnnhập1.Caption = Tien_VN.colMãhóađơnnhập.ToString();
            colNgàychi.Caption = Tien_VN.colNgàychi.ToString();
            colTiềnđãtrả1.Caption = Tien_VN.colTiềnđãtrả.ToString();
            barBtDong.Caption = Tien_VN.barstDong.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barTraTien.Caption = Tien_EL.barTraTien.ToString();
            barSuaTien.Caption = Tien_EL.barSuaTien.ToString();
            colMãhóađơnnhập.Caption = Tien_EL.colMãhóađơnnhập.ToString();
            colTênnhàcungcấp.Caption = Tien_EL.colTênnhàcungcấp.ToString();
            colMãnhàcungcấp.Caption = Tien_EL.colMãnhàcungcấp.ToString();
            colTiềnphảitrả.Caption = Tien_EL.colTiềnphảitrả.ToString();
            colTiềnđãtrả.Caption = Tien_EL.colTiềnđãtrả.ToString();
            colCònlại.Caption = Tien_EL.colCònlại.ToString();
            colMãphiếuchi.Caption = Tien_EL.colMãphiếuchi.ToString();
            //colTênnhânviên.Caption = Tien_EL.colTênnhanvien.ToString();
            colMãhóađơnnhập1.Caption = Tien_EL.colMãhóađơnnhập.ToString();
            colNgàychi.Caption = Tien_EL.colNgàychi.ToString();
            colTiềnđãtrả1.Caption = Tien_EL.colTiềnđãtrả.ToString();
            barBtDong.Caption = Tien_EL.barstDong.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btTratien_Click(object sender, EventArgs e)
        {
            loadfrm_tratien();
        }
        public void loadfrm_tratien()
        {
            frmTraTien frm = new frmTraTien();
            if (this.smaNcc == null)
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
                frm.MaChuyen = sMahdn;
                
                frm.Tienno = sTienno;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;

                frm.iNgonNgu = this.iNgonNgu;
                frm.ShowDialog();
                //loadctncc();
                loadGetAllHDN();
                load_congno();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr1 = gridView2.GetDataRow(e.RowHandle);
                smpc = dtr1[0].ToString();
                sMaNV = dtr1[1].ToString();
                smahdn = dtr1[2].ToString();
                stientra = dtr1[4].ToString();
            }
            catch
            {
                //XtraMessageBox.Show(ex.Message);

            }
        }
        private void bt_edittratien_Click(object sender, EventArgs e)
        {
            frmTraTien frm = new frmTraTien();
            if (this.smpc == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu chi để sửa tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");
            }
            else
            {
                frm.Nhan = "Sua";
                frm.MaPC = smpc;
                frm.HD = smahdn;
                frm.TIEN = stientra;
                frm.sMaNV = sMaNV;

                frm.Tienno = Ctrl_Tien.GETcongno_HDN(smahdn);
                frm.sTenNV = sTenNV;
                
                
                frm.iNgonNgu = this.iNgonNgu;
                frm.ShowDialog();
                loadGetAllHDN();
                //loadctncc();
            }
        }

        private void linkcongno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            load_congno();
        }

        private void linkphieuchi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadGetAllphieuchi();
            load_phieuchi();
        }

        

       

   

    }
}