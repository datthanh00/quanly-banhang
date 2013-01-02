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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        string sma, sten, susername, spassword, schucvu, smabp, sdiachi, sscmnd, ssdt, stinhtrang, sngaysinh;
       // DateTime sngaysinh;
        DTO DTO = new DTO();
        CTL CTL = new CTL();

         public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
       
        private void frmNhanVien_Load(object sender, EventArgs e)
        {


            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
              
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);
            gridControl1.DataSource = CTL.GETNV();

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
            colMANV.Caption = LamVN.MANV.ToString();
            //colMABP.Caption = LamVN.MABP.ToString();
            ////colUSERNAME.Caption = LamVN.USERNAME.ToString();
            ////colPASSWORD.Caption = LamVN.PASSWORD.ToString();
            //colCHUCVU.Caption = LamVN.CHUCVU.ToString();
            colTENNV.Caption = LamVN.TENNV.ToString();
            colDIACHI.Caption = LamVN.DIACHI.ToString();
            colNGAYSINH.Caption = LamVN.NGAYSINH.ToString();
            colSCMND.Caption = LamVN.SCMND.ToString();
            colSDT.Caption = LamVN.SDT.ToString();
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
            colMANV.Caption = LamEL.MANV.ToString();
            //colMABP.Caption = LamEL.MABP.ToString();
            //colUSERNAME.Caption = LamEL.USERNAME.ToString();
            //colPASSWORD.Caption = LamEL.PASSWORD.ToString();
            //colCHUCVU.Caption = LamEL.CHUCVU.ToString();
            colTENNV.Caption = LamEL.TENNV.ToString();
            colDIACHI.Caption = LamEL.DIACHI.ToString();
            colNGAYSINH.Caption = LamEL.NGAYSINH.ToString();
            colSCMND.Caption = LamEL.SCMND.ToString();
            colSDT.Caption = LamEL.SDT.ToString();
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
        private void loadnhanvien()
        {
            gridControl1.DataSource = CTL.GETNV();
            
        }

       


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frmThemNhanVien th = new frmThemNhanVien();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
            loadnhanvien();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin nhân viên " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MANV = sma;
                    Boolean isdeletenv = CTL.isDELETENHANVIEN(DTO);
                    if (!isdeletenv)
                    {
                        MessageBox.Show("Mã nhân viên này đã xuất hóa đơn cho khách, bạn có thể dổi tên nhân viên thay vì xóa");
                        return;
                    }
                    CTL.DELETENHANVIEN(DTO);
                    loadnhanvien();
                    sma = "";
                    
                    sten = "";
                   

                    sdiachi = "";
                    sngaysinh = "";
                    sscmnd = "";
                    ssdt = "";
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Employee  " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MANV = sma;
                    Boolean isdeletenv = CTL.isDELETENHANVIEN(DTO);
                    if (!isdeletenv)
                    {
                        MessageBox.Show("Employee is used for bill can not delete");
                        return;
                    }
                    CTL.DELETENHANVIEN(DTO);
                    loadnhanvien();
                    sma = "";

                    sten = "";


                    sdiachi = "";
                    sngaysinh = "";
                    sscmnd = "";
                    ssdt = "";
                    stinhtrang = "";
                }
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNhanVien sua = new frmThemNhanVien();
            sua.kiemtra = 0;
            sua.MANV = sma;
            //sua.MABP = smabp;
            //sua.USERNAME = susername;
            //sua.PASSWORD = spassword;
            //sua.CHUCVU = schucvu;
            sua.TENNV = sten;
            sua.DIACHI = sdiachi;
            sua.NGAYSINH = sngaysinh;
            sua.SCMND = sscmnd;
            sua.SDT = ssdt;
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
               loadnhanvien();
            }
            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                textEdit1.Text = sma.Trim().ToString();
                sten = dtr[1].ToString();
                textEdit2.Text = sten;

                sdiachi = dtr[2].ToString();
                sngaysinh = String.Format("{0:d}", dtr[3]);
                sscmnd = dtr[4].ToString();
                ssdt = dtr[5].ToString();
                stinhtrang = dtr[6].ToString();
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
                    frmThemNhanVien sua = new frmThemNhanVien();
                    sua.kiemtra = 0;
                    sua.MANV = sma;
                    //sua.MABP = smabp;
                    //sua.USERNAME = susername;
                    //sua.PASSWORD = spassword;
                    //sua.CHUCVU = schucvu;
                    sua.TENNV = sten;
                    sua.DIACHI = sdiachi;
                    sua.NGAYSINH = sngaysinh;
                    sua.SCMND = sscmnd;
                    sua.SDT = ssdt;
                    sua.TINHTRANG = stinhtrang;
                    sua.ShowDialog();
                    loadnhanvien();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
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

        private void barNapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadnhanvien();
        }
    }
}