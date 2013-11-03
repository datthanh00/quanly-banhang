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
using Quanlykho;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmnhomhang : DevExpress.XtraEditors.XtraForm
    {
        
       
        string sma, sten, sghichu;

        DTO DTO = new DTO();
        CTL CTL = new CTL();
        public frmnhomhang()
        {
            InitializeComponent();
        }
           public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
     
        private void frmnhomhang_Load(object sender, EventArgs e)
        {


            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            loadnhomhang();
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet8.NHOMHANG' table. You can move, or remove it, as needed.
            //this.nHOMHANGTableAdapter.Fill(this.xUAT_NHAPTONDataSet8.NHOMHANG);
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
            colMANH.Caption = LamVN.MANH.ToString();
            colTENNHOMHANG.Caption = LamVN.TENNHOMHANG.ToString();
            colGHICHU.Caption = LamVN.GHICHU.ToString();
            barThem.Caption = LamVN.THEM.ToString();
            barXoa.Caption = LamVN.XOA.ToString();
            barSua.Caption = LamVN.SUA.ToString();
            barNapLai.Caption = LamVN.NAPLAI.ToString();
            barIn.Caption = LamVN.IN.ToString();
            barXuat.Caption = LamVN.XUATDULIEU.ToString();
            barNhap.Caption = LamVN.NHAPDULIEU.ToString();
      

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMANH.Caption = LamEL.MANH.ToString();
            colTENNHOMHANG.Caption = LamEL.TENNHOMHANG.ToString();
            colGHICHU.Caption = LamEL.GHICHU.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
   

        }
        private void loadnhomhang()
        {
            
            gridControl1.DataSource = CTL.GETNHOMHANG();
        }
        private void b_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNhomHang th = new frmThemNhomHang();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
            loadnhomhang();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            else if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin nhóm hàng " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MANH = sma;
                    Boolean isdeletenhomhang = CTL.isDELETENHOMHANG(DTO);
                    if (!isdeletenhomhang)
                    {
                        MessageBox.Show("Nhóm hàng đang có hàng không thể xóa");
                        return;
                    }
                    try
                    {
                        CTL.DELETENHOMHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do nhóm hàng đã có mặt hàng sử dụng ");
                        return;
                    }
                    loadnhomhang();
                    sma = "";
                    //textEdit1.Text = sMANH;
                    sten = "";
                    // textEdit2.Text = sTENNHOMHANG;
                    sghichu = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Group Products  " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    DTO.MANH = sma;
                    Boolean isdeletenhomhang = CTL.isDELETENHOMHANG(DTO);
                    if (!isdeletenhomhang)
                    {
                        MessageBox.Show("Group Products not empty you can not delete");
                        return;
                    }
                    try
                    {
                        CTL.DELETENHOMHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do nhóm hàng đã có mặt hàng sử dụng ");
                        return;
                    }
                    loadnhomhang();
                    sma = "";
                    //textEdit1.Text = sMANH;
                    sten = "";
                    // textEdit2.Text = sTENNHOMHANG;
                    sghichu = "";
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNhomHang sua = new frmThemNhomHang();
            sua.kiemtra = 0;
            sua.iNgonNgu = iNgonNgu;
            sua.MANH = sma;
            sua.TENNH = sten;
            sua.GHICHU = sghichu;
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
            loadnhomhang();
            }
           

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                //textEdit1.Text = sMANH;
                sten = dtr[1].ToString();
                // textEdit2.Text = sTENNHOMHANG;
                sghichu = dtr[2].ToString();
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
                    if (iNgonNgu == 1)
                    {
                        XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                    }

                }
                else
                {
                    frmThemNhomHang sua = new frmThemNhomHang();
                    sua.iNgonNgu = iNgonNgu;
                    sua.kiemtra = 0;
                    sua.MANH = sma;
                    sua.TENNH = sten;
                    sua.GHICHU = sghichu;
                    sua.ShowDialog();
                    loadnhomhang();
                }
            }
                
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            gridControl1.ShowPrintPreview();
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadnhomhang();
        }

        private void frmnhomhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }
    }
}