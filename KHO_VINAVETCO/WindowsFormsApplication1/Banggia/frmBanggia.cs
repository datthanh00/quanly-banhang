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
                MABGNOW = dto.MABG;
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
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
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
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn lưu bảng giá này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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
        public String MABGNOW="";
        private void cbbanggia_Validated(object sender, EventArgs e)
        {
            try
            {
                dto.MABG = gridView1.GetFocusedRowCellValue("MABG").ToString();
                MABGNOW = dto.MABG;
                gridControl2.DataSource = CTL.GETBANGGIA(dto.MABG);

                gridView1.ExpandAllGroups();
            }
            catch
            {
                MessageBox.Show("Chưa có bản giá vui lòng nhấn vào danh sách bảng giá để tạo bảng giá mới");
            }
        }

        private void advBandedGridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            DataRow dtr = advBandedGridView2.GetDataRow(advBandedGridView2.FocusedRowHandle);

            if (dtr != null)
            {

                if (e.Column.FieldName.ToString() == "GIABAN")
                {
                    Int64 THANHTIEN1=0;
                    try
                    {

                     THANHTIEN1 = Convert.ToInt64((Convert.ToInt64(dtr["GIABAN"].ToString())) * (Convert.ToDouble(dtr["SOLUONGMH"].ToString())));
                     if (Convert.ToInt64(dtr["GIABAN"].ToString()) < 0)
                     {
                         MessageBox.Show("Giá bán phải lớn hơn hoặc bằng 0");
                         dtr["GIABAN"] = "0";
                         return;
                     }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Giá bán phải là số nguyên");
                        dtr["GIABAN"] = "0";
                        return;
                    }

                    dtr["THANHTIEN"] = Convert.ToInt64(THANHTIEN1).ToString();
                }

            }
                
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                gridControl2.ExportToXls(saveFileDialog1.FileName);

            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            gridControl2.ShowPrintPreview();
        }

        private void frmBanggia_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String hesonhan = cbohesonhan.Value.ToString();

            if (MABGNOW != "")
            {
                gridControl2.DataSource = CTL.GETBANGGIA(dto.MABG,hesonhan);

                gridView1.ExpandAllGroups();
            }
            else
            {
                MessageBox.Show("VUI LÒNG CHỌN 1 BẢNG GIÁ");
            }

        }

     

    }
}