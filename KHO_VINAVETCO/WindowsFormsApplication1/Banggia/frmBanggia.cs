using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
////using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmBanggia : DevExpress.XtraEditors.XtraForm
    {
        public frmBanggia()
        {
            InitializeComponent();
        }
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        DTO dto = new DTO();
        CTL CTL = new CTL();


        private void load_cbhanghoa()
        {
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            cbbanggia.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbbanggia.Properties.DisplayMember = "TENBG";
            cbbanggia.Properties.ValueMember = "MABG";
            cbbanggia.Properties.View.BestFitColumns();
            cbbanggia.Properties.PopupFormWidth = 400;
            DataTable dt = ctr1.dtGetBG();
            cbbanggia.Properties.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                cbbanggia.Text = dt.Rows[0]["MABG"].ToString();
                dto.MABG = gridView1.GetFocusedRowCellValue("MABG").ToString();
            }

        }
        
        private void loadmathang()
        {
            load_cbhanghoa();
            gridControl2.DataSource = CTL.GETBANGGIA(dto.MABG);
            gridView1.ExpandAllGroups();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btdanhsach_Click(object sender, EventArgs e)
        {
            FrmDsbanggia DSBG = new FrmDsbanggia();

            DSBG.ShowDialog();
            loadmathang();
        }

        private void frmBanggia_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
          

            loadmathang();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
                CTL ctlNCC = new CTL();
                for (int i = 0; i < advBandedGridView2.DataRowCount; i++)
                {
                   DataRow dtr = advBandedGridView2.GetDataRow(i);
                   String SQL = "UPDATE  [BANGGIAMATHANG] SET GIABAN=" + dtr["GIABAN"].ToString() + " WHERE MAMH='" + dtr["MAMH"].ToString() + "' AND MABG='" + dto.MABG + "'";
                   ctlNCC.executeNonQuery(SQL);
                }
                MessageBox.Show("Bạn Đã Lưu Thành Công");
        }

        private void cbbanggia_Validated(object sender, EventArgs e)
        {
            dto.MABG = gridView1.GetFocusedRowCellValue("MABG").ToString();
            gridControl2.DataSource = CTL.GETBANGGIA(dto.MABG);
            gridView1.ExpandAllGroups();
        }

        private void advBandedGridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            DataRow dtr = advBandedGridView2.GetDataRow(advBandedGridView2.FocusedRowHandle);

            if (dtr != null)
            {

                if (e.Column.FieldName.ToString() == "GIABAN")
                {
                    Double THANHTIEN1=0;
                    try
                    {

                     THANHTIEN1 = (Convert.ToInt32(dtr["GIABAN"].ToString())) * (Convert.ToDouble(dtr["SOLUONGMH"].ToString()));
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Giá bán phải là số nguyên");
                        dtr["GIABAN"] = "0";
                        return;
                    }

                    dtr["THANHTIEN"] = Convert.ToInt32(THANHTIEN1).ToString();
                }

            }
                
        }

    }
}