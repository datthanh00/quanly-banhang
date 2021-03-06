﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;
////using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmMatHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        string sma, sten, smathue, smanhomhang ,smadvt, ssoluong, shansudung, sgiamua, sgiaban, shinhanh, smota, stinhtrang,smakho;
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        DTO DTO = new DTO();
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public string sMaBP;

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "0")
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
            colMADVT.Caption = LamVN.MADVT.ToString();
            colSOLUONGMH.Caption = LamVN.SOLUONGMH.ToString();
            colHANSUDUNG.Caption = LamVN.HANSUDUNG.ToString();
            colGIAMUA.Caption = LamVN.GIAMUA.ToString();
            colGIABAN.Caption = LamVN.GIABAN.ToString();
            colMAKHO.Caption = LamVN.MAKHO.ToString();
            colMOTA.Caption = LamVN.MOTA.ToString();
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
            colMAMH.Caption = LamEL.MAMH.ToString();
            colMATH.Caption = LamEL.MATH.ToString();
            colMANH.Caption = LamEL.MANH.ToString();
            colTENMH.Caption = LamEL.TENMH.ToString();
            colMADVT.Caption = LamEL.MADVT.ToString();
            colSOLUONGMH.Caption = LamEL.SOLUONGMH.ToString();
            colHANSUDUNG.Caption = LamEL.HANSUDUNG.ToString();
            colGIAMUA.Caption = LamEL.GIAMUA.ToString();
            colGIABAN.Caption = LamEL.GIABAN.ToString();
            colMAKHO.Caption = LamEL.MAKHO.ToString();
            colMOTA.Caption = LamEL.MOTA.ToString();
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
        private void loadmathang()
        {
            gridControl1.DataSource = CTL.GETMATHANG();
        }
        ketnoi connect = new ketnoi();
        private void barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "0")
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
                    CTL.DELETEMATHANG(DTO);
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
                    CTL.DELETEMATHANG(DTO);
                    loadmathang();
                }
            }
            
        }

        private void barSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            ThemMatHang sua = new ThemMatHang();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MAMH = sma;
            sua.MASOTHUE = smathue;
            sua.sBoPhan = sMaBP;
            sua.MANHOMHANG = smanhomhang;
            sua.TENMATHANG = sten;
            sua.DVT = smadvt;
            sua.MAKHO = smakho;
            sua.SOLUONG = ssoluong;
            sua.HANSUDUNG = shansudung;
            sua.GIANUA = sgiamua;
            sua.GIABAN = sgiaban;
            sua.HINHANH = shinhanh;
            sua.MOTA = smota;
            sua.TINHTRANG = stinhtrang;
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
            loadmathang();
        }

        private void barXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            if (PublicVariable.IN == "0")
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
                sma = dtr[0].ToString();
                smathue = dtr[1].ToString();
                smanhomhang = dtr[2].ToString();
                smakho = dtr[3].ToString();
                smadvt = dtr[5].ToString();
                ssoluong = dtr[6].ToString();
                shansudung = dtr[7].ToString();
                sgiamua = dtr[8].ToString();
                sgiaban = dtr[9].ToString();
                //shinhanh = dtr[9].ToString();
                smota = dtr[10].ToString();
                stinhtrang = dtr[11].ToString();
                sten = dtr[4].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
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
                    ThemMatHang sua = new ThemMatHang();
                    sua.iNgonNgu = iNgonNgu;
                    sua.kiemtra = 0;
                    sua.MAMH = sma;
                    sua.MASOTHUE = smathue;
                    sua.MANHOMHANG = smanhomhang;
                    sua.TENMATHANG = sten;
                    sua.DVT = smadvt;
                    sua.MAKHO = smakho;
                    sua.SOLUONG = ssoluong;
                    sua.HANSUDUNG = shansudung;
                    sua.GIANUA = sgiamua;
                    sua.GIABAN = sgiaban;
                    sua.HINHANH = shinhanh;
                    sua.MOTA = smota;
                    sua.TINHTRANG = stinhtrang;
                    sua.sBoPhan = sMaBP;
                    sua.ShowDialog();
                    loadmathang();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}