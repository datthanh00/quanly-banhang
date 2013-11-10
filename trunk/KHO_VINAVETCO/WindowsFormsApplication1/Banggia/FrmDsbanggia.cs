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
    public partial class FrmDsbanggia : DevExpress.XtraEditors.XtraForm
    {
        public FrmDsbanggia()
        {
            InitializeComponent();
        }

        Ctrl_Tien CTR = new Ctrl_Tien();
        CTL CTL = new CTL();
        private string sMaBG, sTenBG, sGhichu;

        private void FrmDsbanggia_Load(object sender, EventArgs e)
        {
            loadctkh();
            sMaBG = "";
        }
        public void loadctkh()
        {
            gridControl1.DataSource = CTR.GETBANGGIA();
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

            ThemBanggia themBG = new ThemBanggia();
            themBG.isthem = true;
            themBG.MABG = "";
            themBG.ShowDialog();
            loadctkh();
        }

        private void barXóa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            
            if(sMaBG=="")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa");
                return;
            }

             CTL CTL = new CTL();

             Boolean isdeletemathang = CTL.isDELETEBANGGIA(sMaBG);
             if (!isdeletemathang)
             {
                 MessageBox.Show("Bảng Giá đang áp dụng cho khách hàng nên không thể xóa");
                 return;
             }
             try
             {
                 CTL.deleteBanggia(sMaBG);
             }
             catch
             {
                 MessageBox.Show("Bạn không thể xóa do có khách hàng đang sử dụng bảng giá này");
                 return;
             }

             loadctkh();
        }

        private void barsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if(sMaBG=="")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa");
                return;
            }

             ThemBanggia suaBG = new ThemBanggia();
             suaBG.isthem=false;
             suaBG.MABG=sMaBG;
             suaBG.TENBG=sTenBG;
             suaBG.GHICHU=sGhichu;
             suaBG.ShowDialog();
             loadctkh();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sMaBG = dtr["MABG"].ToString();
                sTenBG = dtr["TENBG"].ToString();
                sGhichu = dtr["GHICHU"].ToString();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (sMaBG == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa");
                return;
            }

            ThemBanggia suaBG = new ThemBanggia();
            suaBG.isthem = false;
            suaBG.MABG = sMaBG;
            suaBG.TENBG = sTenBG;
            suaBG.GHICHU = sGhichu;
            suaBG.ShowDialog();
            loadctkh();
        }

    }
}