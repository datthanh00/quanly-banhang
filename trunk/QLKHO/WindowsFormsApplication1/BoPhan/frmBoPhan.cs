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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        
        string sma, sten;
        string  stinhtrang;
        DTO DTO = new DTO();
        CTL CTL = new CTL();


        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        PublicVariable PV;
        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            PV = new PublicVariable();

            if (PV.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            loadbophan();
            if (iNgonNgu == 1)
            {
                LoadEL();
                

            }
            else
            {
                LoadTV();
               

            }
            gridControl1.DataSource = CTL.GETBP();
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet9.BOPHAN' table. You can move, or remove it, as needed.
          //  this.bOPHANTableAdapter.Fill(this.xUAT_NHAPTONDataSet9.BOPHAN);

        }
        public int iNgonNgu ;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMABP.Caption = LamVN.MABP.ToString();
            colTENBOPHAN.Caption = LamVN.TENBP.ToString();
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
            colMABP.Caption = LamEL.MABP.ToString();
            colTENBOPHAN.Caption = LamEL.TENBP.ToString();
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
        private void loadbophan()
        {
            gridControl1.DataSource = CTL.GETBP();
        }
        string loadma;
        ketnoi connect = new ketnoi();
        private void barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.THEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            frmThemBoPhan th = new frmThemBoPhan();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
            

            
            loadbophan();

        }

        private void barSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frmThemBoPhan sua = new frmThemBoPhan();
            sua.iNgonNgu = iNgonNgu;
            sua.MABP = sma;
            sua.TENBOPHAN = sten;
            sua.kiemtra = 0;
            sua.TINHTRANG = stinhtrang;
            if (sma == null || sma == "")
            {
                if (iNgonNgu==0)
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

                loadbophan();
            }
           
        }

        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void barXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.XOA == "0")
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
                    XtraMessageBox.Show("Please Select Infomation Need To delete !!!!!!!!");
                }

            }
            else if (iNgonNgu==0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin Bộ Phận " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MABP = sma;
                    Boolean isdeletebp = CTL.isDELETEBOPHAN(DTO);
                    if (!isdeletebp)
                    {
                        MessageBox.Show("Bộ phận này đang có nhân viên, bạn không thể xóa");
                        return;
                    }
                    CTL.DELETEBOPHAN(DTO);
                    loadbophan();
                    sma = "";

                    sten = "";

                   
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Posibility   " + sten + " ???", "Warming", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MABP = sma;
                    Boolean isdeletebp = CTL.isDELETEBOPHAN(DTO);
                    if (!isdeletebp)
                    {
                        MessageBox.Show("Department is not empty, you can not delete it");
                        return;
                    }
                    CTL.DELETEBOPHAN(DTO);
                    loadbophan();
                    sma = "";

                    sten = "";


                    stinhtrang = "";
                }
            }
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                sten = dtr[1].ToString();
                stinhtrang = dtr[2].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (PV.SUA == "0")
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
                    frmThemBoPhan sua = new frmThemBoPhan();
                    sua.iNgonNgu = iNgonNgu;
                    sua.MABP = sma;
                    sua.TENBOPHAN = sten;
                    sua.TINHTRANG = stinhtrang;
                    sua.ShowDialog();
                    loadbophan();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            gridControl1.ShowPrintPreview();
        }

        private void barXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.IN == "0")
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
                gridControl1.ExportToXls(saveFileDialog1.FileName); 
            }
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                sten = dtr[1].ToString();
                stinhtrang = dtr[2].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadbophan();
        }

        

       

        
    }
}