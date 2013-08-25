using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using DevExpress.XtraEditors;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThue : Form
    {
        public frmThue()
        {
            InitializeComponent();
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public frmMain frm;
        string sma, ssothue;
        DTO DTO = new DTO();
        CTL CTL = new CTL();

       // public frmMain frm;
       // public delegate void _deDongTab();
       // public _deDongTab deDongTab;
        public int iNgonNgu;

        private void frmThue_Load(object sender, EventArgs e)
        {


            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            LoadT();

            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);

            if (iNgonNgu == 1)
            {
                LoadEL();
            }
            else
            {
                LoadTV();
            }
        }

       
       

        private void barSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
 
            frmThemThue sua = new frmThemThue();
             sua.ingonngu = iNgonNgu;
             sua.kiemtra = 0;
            sua.MATH = sma;
            sua.SOTHUE = ssothue;
            if (sma == null|| sma== "")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                }
                else
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                }

            }
            else
            {
                sua.ShowDialog();
                LoadT();
            }
           
           
        }

        private void LoadT()
        {
            gridControl1.DataSource = CTL.GETTHUE();
        }
        
        private void barXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XOA == "False")
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
            else  
             if (iNgonNgu == 0)
             {
                 DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa xóa số thuế " + ssothue + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (a == DialogResult.Yes)
                 {

                     DTO.MATH = sma;
                     Boolean isdeletethue = CTL.isDELETETHUE(DTO);
                     if (!isdeletethue)
                     {
                         MessageBox.Show("Đã có sản phẩm sử dụng mã thuế này, bạn không thể xóa");
                         return;
                     }
                     try
                     {
                         CTL.DELETETHUE(DTO);
                     } 
                     catch
                     {
                         MessageBox.Show("Bạn không thể xóa do thuế đã có mặt hàng sử dụng ");
                         return;
                     }
                     LoadT();
                     sma = "";


                     ssothue = "";
                 }
             }
             else
             {
                 DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Tax Number  " + ssothue + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (a == DialogResult.Yes)
                 {

                     DTO.MATH = sma;
                     Boolean isdeletethue = CTL.isDELETETHUE(DTO);
                     if (!isdeletethue)
                     {
                         MessageBox.Show("Tax Number is used you can not delete");
                         return;
                     }
                     try
                     {
                         CTL.DELETETHUE(DTO);
                     }
                     catch
                     {
                         MessageBox.Show("Bạn không thể xóa do thuế đã có mặt hàng sử dụng ");
                         return;
                     }
                     LoadT();

                     sma = "";


                     ssothue = "";
                 }
             }
        }
       
        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            deDongTab();
            
        }

        private void barThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemThue th = new frmThemThue();
            th.ingonngu = iNgonNgu;
            th.kiemtra = 1; 
            th.ShowDialog();
            LoadT();
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadT();
        }

        private void barIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            gridControl1.ShowPrintPreview();
        }

        private void barXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }
             
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                ssothue = dtr[1].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
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
                    else
                    {
                        XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                    }

                }
                else
                {

                    frmThemThue sua = new frmThemThue();
                    sua.ingonngu = iNgonNgu;
                    sua.kiemtra = 0;
                    sua.MATH = sma;
                    sua.SOTHUE = ssothue;
                    sua.ShowDialog();
                    LoadT();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMATH.Caption = LamVN.MATH.ToString();
            colSOTHUE.Caption = LamVN.SOTHUE.ToString();
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
            colMATH.Caption = LamEL.MATH.ToString();
            colSOTHUE.Caption = LamEL.SOTHUE.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
            barThoat.Caption = LamEL.THOAT.ToString();
        }
    }
}
