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
            dt = Ctrl_Tien.GETALLHDn_ctrl();
            gridControl1.DataSource = dt;
        }
        private void barTraTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                loadctncc();
                loadGetAllHDN();
            }
        }

        private void barSuaTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTraTien frm = new frmTraTien();
            if (this.smpc == null)
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
                frm.Nhan = "Sua";
                frm.MaPC = smpc;
                frm.HD = smahdn;
                frm.TIEN = stientra;
                frm.Tienno = sTienno;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;
                frm.iNgonNgu = this.iNgonNgu;
                frm.ShowDialog();
                loadGetAllHDN();
                loadctncc();
            }
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
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sMahdn = dtr[0].ToString();
                smaNcc = dtr[2].ToString();
                sTienno = dtr[5].ToString();
                dt = Ctrl_Tien.get1pthdn_ctrl(dtr[0].ToString());
                gridControl2.DataSource = dt;
            }
            catch 
            {

                //XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr1 = gridView2.GetDataRow(e.RowHandle);
                smpc = dtr1[0].ToString();
                smahdn = dtr1[2].ToString();
                stientra = dtr1[4].ToString();

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
            colMãnhânviên.Caption = Tien_VN.colMãnhânviên.ToString();
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
            colMãnhânviên.Caption = Tien_EL.colMãnhânviên.ToString();
            colMãhóađơnnhập1.Caption = Tien_EL.colMãhóađơnnhập.ToString();
            colNgàychi.Caption = Tien_EL.colNgàychi.ToString();
            colTiềnđãtrả1.Caption = Tien_EL.colTiềnđãtrả.ToString();
            barBtDong.Caption = Tien_EL.barstDong.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

    }
}