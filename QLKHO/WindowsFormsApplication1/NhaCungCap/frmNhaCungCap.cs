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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
       
        string sma, sten, smakv,sdiachi,smasothue,ssotaikhoan,snganhang,ssdt,semail,sfax,swebsite, stinhtrang;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        
        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNhaCungCap tncc = new frmThemNhaCungCap();
            tncc.iNgonNgu = iNgonNgu;
            tncc.kiemtra = 1;
            tncc.ShowDialog();
            LOADNHACC();

        }
       public frmMain frm;
       public delegate void _deDongTab();
       public _deDongTab deDongTab;
       PublicVariable PV;
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            PV = new PublicVariable();

            if (PV.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet2.NHACUNGCAP' table. You can move, or remove it, as needed.
           // this.nHACUNGCAPTableAdapter.Fill(this.xUAT_NHAPTONDataSet2.NHACUNGCAP);
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            LOADNHACC();
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            } 
        }
        public int iNgonNgu=1;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMANCC.Caption = LamVN.MANCC.ToString();
            colMAKV.Caption = LamVN.MAKV.ToString();
            colTENNCC.Caption = LamVN.TENNCC.ToString();
            colDIACHI.Caption = LamVN.DIACHI.ToString();
            colMASOTHUE.Caption = LamVN.MASOTHUE.ToString();
            colSOTK.Caption = LamVN.SOTAIKHOAN.ToString();
            colNGANHANG.Caption = LamVN.NGANHANG.ToString();
            colSDT.Caption = LamVN.SDT.ToString();
            colEMAIL.Caption = LamVN.EMAIL.ToString();
            colFAX.Caption = LamVN.FAX.ToString();
            colWEBSITE.Caption = LamVN.WEBSITE.ToString();
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
            colMANCC.Caption = LamEL.MANCC.ToString();
            colMAKV.Caption = LamEL.MAKV.ToString();
            colTENNCC.Caption = LamEL.TENNCC.ToString();
            colDIACHI.Caption = LamEL.DIACHI.ToString();
            colMASOTHUE.Caption = LamEL.MASOTHUE.ToString();
            colSOTK.Caption = LamEL.SOTAIKHOAN.ToString();
            colNGANHANG.Caption = LamEL.NGANHANG.ToString();
            colSDT.Caption = LamEL.SDT.ToString();
            colEMAIL.Caption = LamEL.EMAIL.ToString();
            colFAX.Caption = LamEL.FAX.ToString();
            colWEBSITE.Caption = LamEL.WEBSITE.ToString();
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
        private void LOADNHACC()
        {
            gridControl1.DataSource = CTL.GETDANHSACHNCC();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
            
        }

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            gridControl1.ShowPrintPreview();
        }

        private void btxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                sten = dtr[2].ToString();

                smakv = dtr[1].ToString();
                sdiachi = dtr[3].ToString();
                smasothue = dtr[4].ToString();
                ssotaikhoan = dtr[5].ToString();
                snganhang = dtr[6].ToString();
                ssdt = dtr[7].ToString();
                semail = dtr[8].ToString();
                sfax = dtr[9].ToString();
                swebsite = dtr[10].ToString();
                stinhtrang = dtr[11].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    XtraMessageBox.Show("Please Select Infomation Need To Delete !!!!!!!!");
                }

            }
            else  if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin nhà cung cấp :  " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MANCC = sma;
                    Boolean isdeletencc = CTL.isDELETENCC(DTO);
                    if (!isdeletencc)
                    {
                        MessageBox.Show("Nhà cung cấp đang có hóa đơn bạn không thể xóa");
                        return;
                    }
                    CTL.DELETENCC(DTO);
                    LOADNHACC();
                    sma = "";

                    sten = "";

                    smakv = "";
                    sdiachi = "";
                    smasothue = "";
                    ssotaikhoan = "";
                    snganhang = "";
                    ssdt = "";
                    semail ="";
                    sfax = "";
                    swebsite ="";
                    stinhtrang ="";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Provider :   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MANCC = sma;
                    Boolean isdeletencc = CTL.isDELETENCC(DTO);
                    if (!isdeletencc)
                    {
                        MessageBox.Show("Provider is curent used you can not delete");
                        return;
                    }
                    CTL.DELETENCC(DTO);
                    LOADNHACC();
                    sma = "";

                    sten = "";

                    smakv = "";
                    sdiachi = "";
                    smasothue = "";
                    ssotaikhoan = "";
                    snganhang = "";
                    ssdt = "";
                    semail = "";
                    sfax = "";
                    swebsite = "";
                    stinhtrang = "";
                }
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PV.SUA == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNhaCungCap sua = new frmThemNhaCungCap();

            sua.kiemtra = 0;
            if (sma == null || sma =="")
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
                sua.MANCC = sma;
                sua.MAKV = smakv;
                sua.TENNCC = sten;
                sua.DIACHI = sdiachi;
                sua.SDT = ssdt;
                sua.MASOTHUE = smasothue;
                sua.FAX = sfax;
                sua.SOTAIKHOAN = ssotaikhoan;
                sua.NGANHANG = snganhang;
                sua.WEBSITE = swebsite;
                sua.TINHTRANG = stinhtrang;
                sua.EMAIL = semail;

                sua.ShowDialog();
                LOADNHACC();
            }
            
           
            

            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
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
                    frmThemNhaCungCap sua = new frmThemNhaCungCap();
                    sua.kiemtra = 0;
                    sua.MANCC = sma;
                    sua.MAKV = smakv;
                    sua.TENNCC = sten;
                    sua.DIACHI = sdiachi;
                    sua.SDT = ssdt;
                    sua.MASOTHUE = smasothue;
                    sua.FAX = sfax;
                    sua.SOTAIKHOAN = ssotaikhoan;
                    sua.NGANHANG = snganhang;
                    sua.WEBSITE = swebsite;
                    sua.TINHTRANG = stinhtrang;
                    sua.ShowDialog();
                    LOADNHACC();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LOADNHACC();
        }
    }
}