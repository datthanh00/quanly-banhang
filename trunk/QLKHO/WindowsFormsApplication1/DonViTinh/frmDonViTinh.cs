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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
       
        string sma, sten;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        
       
       public frmMain frm;
                 public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private void frmDonViTinh_Load(object sender, EventArgs e)
        { 
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            LoadDVT();
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();
            }
            gridControl1.DataSource = CTL.GETDVT();
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet11.DONVITINH' table. You can move, or remove it, as needed.
            

        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMADVT.Caption = LamVN.MADVT.ToString();
            colDONVITINH.Caption = LamVN.DVT.ToString();
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
            colMADVT.Caption = LamEL.MADVT.ToString();
            colDONVITINH.Caption = LamEL.DVT.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
            barThoat.Caption = LamEL.THOAT.ToString();
           
        }
        private void LoadDVT()
        {
            gridControl1.DataSource = CTL.GETDVT();
        }

       
        private void barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDVT th = new frmThemDVT();
            th.iNgonNgu = iNgonNgu;
            th.kiemtra = 1;
            th.ShowDialog();
            LoadDVT();
        }

        private void barXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
             else if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin đơn vị tính : " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MADVT = sma;
                    Boolean isdeletedvt = CTL.isDELETEDVT(DTO);
                    if (!isdeletedvt)
                    {
                        MessageBox.Show("Đơn vị tính đang được sử dụng cho sản phẩm. bạn không thể xóa");
                        return;
                    }
                    CTL.DELETEDVT(DTO);
                    LoadDVT();
                    sma = "";

                    sten = "";


                    
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Unit :   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MADVT = sma;
                    Boolean isdeletedvt = CTL.isDELETEDVT(DTO);
                    if (!isdeletedvt)
                    {
                        MessageBox.Show("Unit is curent us for product, you cant not delete it");
                        return;
                    }
                    CTL.DELETEDVT(DTO);
                    LoadDVT();
                    sma = "";

                    sten = "";
                }
            }
        }
        public int kiemtra;
        private void barSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDVT sua = new frmThemDVT();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MADVT = sma;
            sua.DONVITINH = sten;
            
            if (sma == null || sma == "")
            {
                if (iNgonNgu == 0)
                {
                    MessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    MessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                }

            }
            else
            {
                sua.ShowDialog();
                LoadDVT();

            }
            
        }
        
        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                //textEdit1.Text = sma.Trim().ToString();
                sten = dtr[1].ToString();
                //textEdit2.Text = sten;
            } 
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (sma == null || sma == "")
                {
                    if (iNgonNgu == 0)
                    {
                        MessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                    }
                    if (iNgonNgu == 1)
                    {
                        MessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                    }

                }
                else
                {
                    frmThemDVT sua = new frmThemDVT();
                    sua.MADVT = sma;
                    sua.DONVITINH = sten;
                    sua.iNgonNgu = iNgonNgu;
                    sua.ShowDialog();
                    LoadDVT();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void barXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName!="")
            {
                 gridControl1.ExportToXls(saveFileDialog1.FileName); 
            }
           
        }

       
    }
}