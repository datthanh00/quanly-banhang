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
using Quanlykho;
////using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmMatHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        string sma, sten, smathue, smanhomhang, smadvt, ssoluong, smota, stinhtrang, smakho, SKLDVT, sgiamua;
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        DTO DTO = new DTO();
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public string sMaBP;

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.xUAT_NHAPTONDataSet.MATHANG);
            loadmathang();
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
          
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet37.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter2.Fill(this.xUAT_NHAPTONDataSet37.MATHANG);
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet32.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter1.Fill(this.xUAT_NHAPTONDataSet32.MATHANG);
            
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet20.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.xUAT_NHAPTONDataSet20.MATHANG);
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
            colMAMH.Caption = LamVN.MAMH.ToString();
            colMATH.Caption = LamVN.MATH.ToString();
            colMANH.Caption = LamVN.MANH.ToString();
            colTENMH.Caption = LamVN.TENMH.ToString();
           // colMADVT.Caption = LamVN.MADVT.ToString();
            colSOLUONGMH.Caption = LamVN.SOLUONGMH.ToString();
            
            colMAKHO.Caption = LamVN.MAKHO.ToString();
            colMOTA.Caption = LamVN.MOTA.ToString();

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
            colMAMH.Caption = LamEL.MAMH.ToString();
            colMATH.Caption = LamEL.MATH.ToString();
            colMANH.Caption = LamEL.MANH.ToString();
            colTENMH.Caption = LamEL.TENMH.ToString();
           // colMADVT.Caption = LamEL.MADVT.ToString();
            colSOLUONGMH.Caption = LamEL.SOLUONGMH.ToString();

            colMAKHO.Caption = LamEL.MAKHO.ToString();
            colMOTA.Caption = LamEL.MOTA.ToString();

            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
            
        }
        private void loadmathang()
        {
            gridControl1.DataSource = CTL.GETMATHANG();
            gridView1.ExpandAllGroups();
        }
        ketnoi connect = new ketnoi();
        private void barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            ThemMatHang frm = new ThemMatHang();
            frm.iNgonNgu = iNgonNgu;
            frm.kiemtra = 1;
            frm.sBoPhan = sMaBP;
            frm.ShowDialog();
            loadmathang(); 
        }
       
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            

          
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
           else if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin mặt hàng " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    DTO.MAMH = sma;
                    Boolean isdeletemathang = CTL.isDELETEMATHANG(DTO);
                    if (!isdeletemathang)
                    {
                        MessageBox.Show("Mặt hàng đã xuất hóa đơn bạn không thể xóa");
                        return;
                    }
                    try
                    {
                        CTL.DELETEMATHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do mặt hàng đang có hóa đơn hoặc tồn đầu kỳ");
                        return;
                    }
                    loadmathang();
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MAMH = sma;
                    Boolean isdeletemathang = CTL.isDELETEMATHANG(DTO);
                    if (!isdeletemathang)
                    {
                        MessageBox.Show("product is have bill you can not delete");
                        return;
                    }
                    try
                    {
                        CTL.DELETEMATHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do mặt hàng đang có hóa đơn hoặc tồn đầu kỳ");
                        return;
                    }
                    loadmathang();
                }
            }
            
        }

        private void barSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            ThemMatHang sua = new ThemMatHang();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;

            sua.MAMH = sma;
            sua.TENMATHANG = sten;
            sua.MANCC = smanhomhang;
            sua.DVT = smadvt;
            sua.KLDVT = SKLDVT;

            sua.MASOTHUE = smathue;
  
            sua.MOTA = smota;
            sua.SOLUONG = ssoluong;

 

            sua.sBoPhan = sMaBP;
           
            
            
            sua.MAKHO = smakho;
            
            sua.HINHANH = "";
            
            sua.TINHTRANG = stinhtrang;
            sua.GIAMUA = sgiamua;
            if (sma == null||sma =="")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                }
                return;
            }
            else
            {
               
                sua.ShowDialog();

                loadmathang();
            }
            

           
        }

       
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                // = dtr[0].ToString();
                //sten = dtr[1].ToString();
                //stinhtrang = dtr[2].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        

        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            loadmathang();
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

        private void barNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr["MAMH"].ToString();
                sten = dtr["TENMH"].ToString();
                smanhomhang = dtr["MANCC"].ToString();
                smadvt = dtr["MADVT"].ToString();
                SKLDVT = dtr["KLDVT"].ToString();
                smathue = dtr["MATH"].ToString();
                smakho = dtr["MAKHO"].ToString();
                ssoluong = dtr["SOLUONGMH"].ToString();
                smota = dtr["MOTA"].ToString();
                stinhtrang = dtr["TINHTRANG"].ToString();
                sgiamua = dtr["GIAMUA"].ToString();
                
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
                    ThemMatHang sua = new ThemMatHang();
                    sua.iNgonNgu = iNgonNgu;
                    sua.kiemtra = 0;

                    sua.MAMH = sma;
                    sua.TENMATHANG = sten;
                    sua.MANCC = smanhomhang;
                    sua.DVT = smadvt;
                    sua.KLDVT = SKLDVT;

                    sua.MASOTHUE = smathue;
           
                    sua.MOTA = smota;
                    sua.SOLUONG = ssoluong;



                    sua.sBoPhan = sMaBP;



                    sua.MAKHO = smakho;

                    sua.HINHANH = "";

                    sua.TINHTRANG = stinhtrang;
                    sua.GIAMUA = sgiamua;

                    sua.ShowDialog();
                    loadmathang();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void frmMatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }
    }
}