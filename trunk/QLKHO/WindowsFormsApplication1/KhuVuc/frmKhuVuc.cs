using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        
        string sma, sten, sghichu, stinhtrang;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
       
        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frmThemKhuVuc tkv = new frmThemKhuVuc();
            
            tkv.kiemtra = 1;
            tkv.iNgonNgu = iNgonNgu;
            tkv.ShowDialog();
            loadkhuvuc();
            
        }
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
      
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
           
            if (PublicVariable.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            // TODO: This line of code loads data into the 'xUAT_NHAPTONKhuVuc.KHUVUC' table. You can move, or remove it, as needed.
            //this.kHUVUCTableAdapter1.Fill(this.xUAT_NHAPTONKhuVuc.KHUVUC);
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet1.KHUVUC' table. You can move, or remove it, as needed.
          //  this.kHUVUCTableAdapter.Fill(this.xUAT_NHAPTONDataSet1.KHUVUC);
            loadkhuvuc();
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            } 
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMAKV.Caption = LamVN.MAKV.ToString();
            colTENKV.Caption = LamVN.TENKV.ToString();
            colGHICHU.Caption = LamVN.GHICHU.ToString();
            colTINHTRANG.Caption = LamVN.TINHTRANG.ToString();
            barThem.Caption = LamVN.THEM.ToString();
            barXoa.Caption = LamVN.XOA.ToString();
            barSua.Caption = LamVN.SUA.ToString();
            barNapLai.Caption = LamVN.NAPLAI.ToString();
            barIn.Caption = LamVN.IN.ToString();
            barXuat.Caption = LamVN.XUATDULIEU.ToString();
            barNhap.Caption = LamVN.NHAPDULIEU.ToString();
            barThoat.Caption = LamVN.THOAT.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMAKV.Caption = LamEL.MAKV.ToString();
            colTENKV.Caption = LamEL.TENKV.ToString();
            colGHICHU.Caption = LamEL.GHICHU.ToString();
            colTINHTRANG.Caption = LamEL.TINHTRANG.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
            barThoat.Caption = LamEL.THOAT.ToString();
        }
        private void loadkhuvuc()
        {
            
          gridControl1.DataSource = CTL.GETKHUVUC();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
         
           
        }

       

       
        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            gridControl1.ShowPrintPreview();
        }

        private void btxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName!="")
            {
                gridControl1.ExportToXls(saveFileDialog1.FileName); 

            }
        }
       
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                //textEdit1.Text = sma;
                sten = dtr[1].ToString();
                //textEdit2.Text = sten;
                sghichu = dtr[2].ToString();
                stinhtrang = dtr[3].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XOA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (sma == null || sma == "")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Xóa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Delete !!!!!!!!");
                }

            }
            else  if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin khu vực : " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                
                if (a == DialogResult.Yes)
                {

                    DTO.MAKV = sma;
                    Boolean isdeletekv = CTL.isDELETEKV(DTO);
                    if (!isdeletekv)
                    {
                        MessageBox.Show("khu vực đang được sử dụng bạn không thể xóa");
                        return;
                    }
                    CTL.DELETEKV(DTO);
                    loadkhuvuc();
                    sma = "";
                    //textEdit1.Text = sma;
                    sten = "";
                    //textEdit2.Text = sten;
                    sghichu = "";
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Area :  " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                

                if (a == DialogResult.Yes)
                {

                    DTO.MAKV = sma;
                    Boolean isdeletekv = CTL.isDELETEKV(DTO);
                    if (!isdeletekv)
                    {
                        MessageBox.Show("Area is used, you cannot delete");
                        return;
                    }
                    CTL.DELETEKV(DTO);
                    loadkhuvuc();
                    sma = "";
                    //textEdit1.Text = sma;
                    sten = "";
                    //textEdit2.Text = sten;
                    sghichu = "";
                    stinhtrang = "";
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (PublicVariable.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            frmThemKhuVuc sua = new frmThemKhuVuc();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MAKHUVUC = sma;
            sua.TENKHUVUC = sten;
           sua.GHICHU = sghichu;
            sua.TINHTRANG = stinhtrang;
            if (sma == null||sma=="")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                }

            }
            else
            {
               sua.ShowDialog();
            loadkhuvuc();
            }
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            try
            {
                if (sma == null || sma == "")
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                    }
                    if (iNgonNgu == 1)
                    {
                        XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                    }

                }
                else
                {
                    frmThemKhuVuc sua = new frmThemKhuVuc();
                    sua.kiemtra = 0;
                    sua.iNgonNgu = iNgonNgu;
                    sua.MAKHUVUC = sma;
                    sua.TENKHUVUC = sten;
                    sua.GHICHU = sghichu;
                    sua.TINHTRANG = stinhtrang;
                    sua.ShowDialog();
                    loadkhuvuc();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dtr = gridView1.GetDataRow(e.RowHandle);
            sma = dtr[0].ToString();
            //textEdit1.Text = sma;
            sten = dtr[1].ToString();
            //textEdit2.Text = sten;
            sghichu = dtr[2].ToString();
            stinhtrang = dtr[3].ToString();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dtr = gridView1.GetDataRow(e.RowHandle);
            sma = dtr[0].ToString();
            //textEdit1.Text = sma;
            sten = dtr[1].ToString();
            //textEdit2.Text = sten;
            sghichu = dtr[2].ToString();
            stinhtrang = dtr[3].ToString();
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadkhuvuc();
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

        }

        private void gridView1_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {

        }

    }
}