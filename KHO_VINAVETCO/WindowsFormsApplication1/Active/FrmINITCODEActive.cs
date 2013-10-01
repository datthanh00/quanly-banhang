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
    public partial class FrmINITCODEActive : DevExpress.XtraEditors.XtraForm
    {
        public FrmINITCODEActive()
        {
            InitializeComponent();
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        Ctrl_Tien CTR = new Ctrl_Tien();
        private string SACTIVE, SCODEACTIVE, STYPE;

        private void FrmDsbanggia_Load(object sender, EventArgs e)
        {
            loadctkh();
            SACTIVE = "";
        }
        public void loadctkh()
        {
            gridControl1.DataSource = CTR.GETCODEACTIVE();
            gridControl1.Refresh();
        }
 
        private void barstDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            CTR.INSERTCODEACTIVE();
            loadctkh();
        }

        private void barXóa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa ID: " + SACTIVE + "   không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            
            if(SACTIVE==""||SACTIVE==null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa");
                return;
            }
            CTR.DELETECODEACTIVE(SACTIVE);
            loadctkh();
        }

       


        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                SACTIVE = dtr["ACTIVE"].ToString();
                SCODEACTIVE = dtr["CODEACTIVE"].ToString();
                STYPE = dtr["TYPE"].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

    }
}