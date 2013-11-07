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
    public partial class frmKho1 : DevExpress.XtraEditors.XtraForm
    {
        public frmKho1()
        {
            InitializeComponent();
        }
        string sma, sten, smakv, sdiachi, ssodtB, ssodtDD, snguoilienhe, sfax, sghichu, stinhtrang;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        public string fsten;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void frmKho1_Load(object sender, EventArgs e)
        {

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet28.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Fill(this.xUAT_NHAPTONDataSet28.KHO);
           
            loadKho();
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
            colMAKHO.Caption = LamVN.MAKHO.ToString();
            colMANV.Caption = LamVN.MANV.ToString();
            colTENKHO.Caption = LamVN.TENKHO.ToString();
            colDIACHI.Caption = LamVN.DIACHI.ToString();
            colSDTB.Caption = LamVN.SDTB.ToString();
            colDTDD.Caption = LamVN.DTDD.ToString();
            colNGUOILH.Caption = LamVN.NGUOILIENHE.ToString();
            colFAX.Caption = LamVN.FAX.ToString();
            colGHICHU.Caption = LamVN.GHICHU.ToString();
            colTINHTRANG.Caption = LamVN.TINHTRANG.ToString();
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
            colMAKHO.Caption = LamEL.MAKHO.ToString();
            colMANV.Caption = LamEL.MANV.ToString();
            colTENKHO.Caption = LamEL.TENKHO.ToString();
            colDIACHI.Caption = LamEL.DIACHI.ToString();
            colSDTB.Caption = LamEL.SDTB.ToString();
            colDTDD.Caption = LamEL.DTDD.ToString();
            colNGUOILH.Caption = LamEL.NGUOILIENHE.ToString();
            colFAX.Caption = LamEL.FAX.ToString();
            colGHICHU.Caption = LamEL.GHICHU.ToString();
            colTINHTRANG.Caption = LamEL.TINHTRANG.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
     
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            frmThemKho tk = new frmThemKho();
            tk.iNgonNgu = iNgonNgu;
            tk.kiemtra = 1;
            tk.ShowDialog();
            loadKho();
        }
        private void loadKho()
        {
            gridControl1.DataSource = CTL.GETKHO();
        }

        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
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
            if (saveFileDialog1.FileName!="")
            {
                 gridControl1.ExportToXls(saveFileDialog1.FileName); 
            }
           
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                // smakv, sdiachi, ssodtB, ssodtDD, snguoilienhe, sfax,sghichu, stinhtrang;       
                //DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                //textEdit1.Text = sma.Trim().ToString();
                sten = dtr[2].ToString();
                //textEdit2.Text = sten;
                smakv = dtr[1].ToString();
                sdiachi = dtr[3].ToString();
                ssodtB = dtr[4].ToString();
                ssodtDD = dtr[5].ToString();
                snguoilienhe = dtr[6].ToString();
                sfax = dtr[7].ToString();
                sghichu = dtr[8].ToString();
                stinhtrang = dtr[9].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
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
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin kho :  " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MAKHO = sma;
    
                    Boolean isdeletekho = CTL.isDELETEKHO(DTO);
                    if (!isdeletekho)
                    {
                        MessageBox.Show("Kho đang chứa hàng bạn không thể xóa");
                        return;
                    }
                    try
                    {
                        CTL.DELETEKHO(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do kho đang có hàng hóa hoặc hóa đơn");
                        return;
                    }
                    loadKho();
                    sma = "";
                    //textEdit1.Text = sma.Trim().ToString();
                    sten = "";
                    //textEdit2.Text = sten;
                    smakv = "";
                    sdiachi = "";

                    ssodtB = "";
                    ssodtDD = "";
                    snguoilienhe = "";
                    sfax = "";
                    sghichu = "";
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Posibility :   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MAKHO = sma;
                    Boolean isdeletekho = CTL.isDELETEKHO(DTO);
                    if (!isdeletekho)
                    {
                        MessageBox.Show("Posibility is not empty you can not delete");
                        return;
                    }
                    try
                    {
                        CTL.DELETEKHO(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do kho đang có hàng hóa hoặc hóa đơn");
                        return;
                    }
                    loadKho();
                    sma = "";
                    //textEdit1.Text = sma.Trim().ToString();
                    sten = "";
                    //textEdit2.Text = sten;
                    smakv = "";
                    sdiachi = "";

                    ssodtB = "";
                    ssodtDD = "";
                    snguoilienhe = "";
                    sfax = "";
                    sghichu = "";
                    stinhtrang = "";
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
            frmThemKho sua = new frmThemKho();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MACHUYEN = sma;
            sua.MANV = smakv;
            sua.TENKHO = sten;
            sua.DIACHI = sdiachi;
            sua.SDTB = ssodtB;
            sua.DTDD = ssodtDD;
            sua.FAX = sfax;
            sua.TINHTRANG = stinhtrang;
            sua.GHICHU = sghichu;
            sua.NGUOILIENHE = snguoilienhe;
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
                sua.ShowDialog();
                loadKho();
            }
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
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
                    frmThemKho sua = new frmThemKho();
                    sua.iNgonNgu = iNgonNgu;
                    sua.kiemtra = 0;
                    sua.MACHUYEN = sma;
                    sua.MANV = smakv;
                    sua.TENKHO = sten;
                    sua.DIACHI = sdiachi;
                    sua.SDTB = ssodtB;
                    sua.DTDD = ssodtDD;
                    sua.FAX = sfax;
                    sua.TINHTRANG = stinhtrang;
                    sua.GHICHU = sghichu;
                    sua.NGUOILIENHE = snguoilienhe;
                    sua.ShowDialog();
                    loadKho();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow dtr = gridView1.GetDataRow(e.RowHandle);
            sma = dtr[0].ToString();
            //textEdit1.Text = sma.Trim().ToString();
            sten = dtr[2].ToString();
            //textEdit2.Text = sten;
            smakv = dtr[1].ToString();
            sdiachi = dtr[3].ToString();
            
            ssodtB = dtr[4].ToString();
            ssodtDD = dtr[5].ToString();
            snguoilienhe = dtr[6].ToString();
            sfax = dtr[7].ToString();
            sghichu = dtr[8].ToString();
            stinhtrang = dtr[9].ToString();
        }

        private void barNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadKho();
        }

        private void frmKho1_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }
    }
}