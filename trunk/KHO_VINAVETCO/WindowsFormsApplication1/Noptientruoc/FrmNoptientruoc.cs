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
    public partial class FrmNoptientruoc : DevExpress.XtraEditors.XtraForm
    {
        public FrmNoptientruoc()
        {
            InitializeComponent();
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        Ctrl_Tien CTR = new Ctrl_Tien();
        private string SMANCC, SMAKH, SSOTIEN, SID,STENKH,STENNCC;

        private void FrmDsbanggia_Load(object sender, EventArgs e)
        {
            loadctkh();
        }
        public void loadctkh()
        {
            gridControl1.DataSource = CTR.GETTIENTRATRUOC();
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
            frmThemNoptientruoc NTT = new frmThemNoptientruoc();
            NTT.isthem = true;
            NTT.ShowDialog();


            loadctkh();
        }

        private void barXóa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa Nộp tiền KH-NCC: "+STENKH+STENNCC+" không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            
            if(SID==""||SID==null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa");
                return;
            }
            string SQL = "";
            SQL = "\r\nGO\r\n DELETE [TIENTRATRUOC] WHERE ID="+SID;
            if (STENNCC == "" || STENNCC == null)
            {
                SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET TIENTRATRUOC=TIENTRATRUOC - " + SSOTIEN+ " WHERE MAKH='" + SMAKH + "'";
            }
            else
            {
                SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET TIENTRATRUOC=TIENTRATRUOC - " + SSOTIEN + " WHERE MANCC='" + SMANCC + "'";
            }
            CTL ctlDOITUONG = new CTL();
            ctlDOITUONG.EXCUTE_SQL2(SQL);
            loadctkh();
        }

       


        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                SSOTIEN = dtr["SOTIEN"].ToString();
                SMAKH = dtr["MADOITUONG"].ToString();
                SMANCC = dtr["MADOITUONG"].ToString();
                SID = dtr["ID"].ToString();
                STENKH = dtr["TENKH"].ToString();
                STENNCC = dtr["TENNCC"].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (SID == ""||SID==null)
            {
                MessageBox.Show("VUI LÒNG CHỌN MỘT DÒNG TRƯỚC");
            }
            frmThemNoptientruoc NTT = new frmThemNoptientruoc();
            NTT.isthem = false;
            NTT.SOTIEN = SSOTIEN;
            NTT.MAKH = SMAKH;
            NTT.MANCC = SMANCC;
            NTT.ID = SID;
            if (STENKH == null || STENKH == "")
            {
                NTT.iskhachhang = false;
            }
            else
            {
                NTT.iskhachhang = true;
            }
            NTT.ShowDialog();


            loadctkh();
        }

        private void baredit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (SID == ""||SID==null)
            {
                MessageBox.Show("VUI LÒNG CHỌN MỘT DÒNG TRƯỚC");
            }
            frmThemNoptientruoc NTT = new frmThemNoptientruoc();
            NTT.isthem = false;
            NTT.SOTIEN = SSOTIEN;
            NTT.MAKH = SMAKH;
            NTT.MANCC = SMANCC;
            NTT.ID = SID;
            if (STENKH == null || STENKH == "")
            {
                NTT.iskhachhang = false;
            }
            else
            {
                NTT.iskhachhang = true;
            }
            NTT.ShowDialog();


            loadctkh();
        }

        private void FrmNoptientruoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

    }
}