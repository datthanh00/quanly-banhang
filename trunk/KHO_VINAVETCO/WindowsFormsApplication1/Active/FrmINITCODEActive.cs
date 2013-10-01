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
            this.Close();
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
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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

       
        private void gridView1_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle >= 0)
            {
                DataRow dtr = gridView1.GetDataRow(hitInfo.RowHandle);
                SACTIVE = dtr["ACTIVE"].ToString();
                SCODEACTIVE = dtr["CODEACTIVE"].ToString();
                STYPE = dtr["TYPE"].ToString();
            }
        }

    }
}