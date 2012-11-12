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
////using WindowsFormsApplication1.class_TungLam;


namespace WindowsFormsApplication1
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string sTenKH;
        string sMaKH;

        string sSoTaiKhoan;

        public string SSoTaiKhoan
        {
            get { return sSoTaiKhoan; }
            set { sSoTaiKhoan = value; }
        }
        string sNganHang;

        public string SNganHang
        {
            get { return sNganHang; }
            set { sNganHang = value; }
        }
        string sMaST;

        public string SMaST
        {
            get { return sMaST; }
            set { sMaST = value; }
        }
        string sDiaChi;

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }
        string sSDT;

        public string SSDT
        {
            get { return sSDT; }
            set { sSDT = value; }
        }
        string sSofax;

        public string SSofax
        {
            get { return sSofax; }
            set { sSofax = value; }
        }
        string sWebsite;
        string sYahoo;
        string sNickSkype;
        string sTinhTrang;


         public frmMain frm;
                 public delegate void _deDongTab();
        public _deDongTab deDongTab;
           
        public string TenKH { get { return sTenKH; } set { sTenKH = value; } }
        public string MaKH { get { return sMaKH; } set { sMaKH = value; } }
        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
             frmThemKhachHang tkh = new frmThemKhachHang();
             tkh.iNgonNgu = iNgonNgu;
             tkh.kiemtra = 1;
             tkh.ShowDialog();
             LOADDANHSACHKHACHHANG();
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        //private bool thoat = false;
        string sma, sten,smakv,sdiachi,sdodt,ssoTK,snganhang,smasothue,sfax,syahoo,snickskype,stinhtrang;
       
        DTO DTO = new DTO();
        CTL ctl= new CTL();
        public string fsten;
       
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin khách hàng " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MAKH = sma;
                    ctl.DELETEKHACHHANG(DTO);
                    LOADDANHSACHKHACHHANG();
                    sma = "";

                    sten = "";

                    smakv = "";

                    ssoTK = "";
                    snganhang = "";
                    smasothue = "";
                    sdiachi = "";
                    sSDT = "";
                    sfax = "";
                    sWebsite = "";
                    syahoo = "";
                    snickskype = "";
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Custommer :   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {


                    DTO.MAKH = sma;
                    ctl.DELETEKHACHHANG(DTO);
                    LOADDANHSACHKHACHHANG();
                    sma = "";

                    sten = "";

                    smakv = "";

                    ssoTK = "";
                    snganhang = "";
                    smasothue = "";
                    sdiachi = "";
                    sSDT = "";
                    sfax = "";
                    sWebsite = "";
                    syahoo = "";
                    snickskype = "";
                    stinhtrang = "";
                }
            }
           
        }

        
        
        private void LOADDANHSACHKHACHHANG()
        {
            girdcontrol.DataSource = ctl.GETDANHSACHKH();
           
            
            
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
           
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xUAT_NHAPTONKhachHang.KHACHHANG' table. You can move, or remove it, as needed.
           // this.kHACHHANGTableAdapter.Fill(this.xUAT_NHAPTONKhachHang.KHACHHANG);
            frm.LoadVI += new frmMain.Translate(LoadTV);
            frm.LoadEN += new frmMain.Translate(LoadEL);

            LOADDANHSACHKHACHHANG();
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
            colMAKH.Caption = LamVN.MAKH.ToString();
            colTENKH.Caption = LamVN.TENKH.ToString();
            colMAKV.Caption = LamVN.MAKV.ToString();
            colSOTAIKHOAN.Caption = LamVN.SOTAIKHOAN.ToString();
            colNGANHANG.Caption = LamVN.NGANHANG.ToString();
            colMASOTHUE.Caption = LamVN.MASOTHUE.ToString();
            colDIACHI.Caption = LamVN.DIACHI.ToString();
            colSDT.Caption = LamVN.SDT.ToString();
            colFAX.Caption = LamVN.FAX.ToString();
            colWEBSITE.Caption = LamVN.WEBSITE.ToString();
            colYAHOO.Caption = LamVN.YAHOO.ToString();
            colSKYPE.Caption = LamVN.SKYPE.ToString();
            colTINHTRANG.Caption = LamVN.TINHTRANG.ToString();
            barThem.Caption = LamVN.THEM.ToString();
            barXoa.Caption = LamVN.XOA.ToString();
            barSua.Caption = LamVN.SUA.ToString();
            barNapLai.Caption = LamVN.NAPLAI.ToString();
            barIn.Caption = LamVN.IN.ToString();
            barXuat1.Caption = LamVN.XUATDULIEU.ToString();
            barNhap.Caption = LamVN.NHAPDULIEU.ToString();
            barThoat.Caption = LamVN.THOAT.ToString();
        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMAKH.Caption = LamEL.MAKH.ToString();
            colTENKH.Caption = LamEL.TENKH.ToString();
            colMAKV.Caption = LamEL.MAKV.ToString();
            colSOTAIKHOAN.Caption = LamEL.SOTAIKHOAN.ToString();
            colNGANHANG.Caption = LamEL.NGANHANG.ToString();
            colMASOTHUE.Caption = LamEL.MASOTHUE.ToString();
            colDIACHI.Caption = LamEL.DIACHI.ToString();
            colSDT.Caption = LamEL.SDT.ToString();
            colFAX.Caption = LamEL.FAX.ToString();
            colWEBSITE.Caption = LamEL.WEBSITE.ToString();
            colYAHOO.Caption = LamEL.YAHOO.ToString();
            colSKYPE.Caption = LamEL.SKYPE.ToString();
            colTINHTRANG.Caption = LamEL.TINHTRANG.ToString();
            barThem.Caption = LamEL.THEM.ToString();
            barXoa.Caption = LamEL.XOA.ToString();
            barSua.Caption = LamEL.SUA.ToString();
            barNapLai.Caption = LamEL.NAPLAI.ToString();
            barIn.Caption = LamEL.IN.ToString();
            barXuat1.Caption = LamEL.XUATDULIEU.ToString();
            barNhap.Caption = LamEL.NHAPDULIEU.ToString();
            barThoat.Caption = LamEL.THOAT.ToString();
        }
       

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            girdcontrol.ShowPrintPreview();
        }

       

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName!="")
            {
                girdcontrol.ExportToXls(saveFileDialog1.FileName); 
            }
            
        }

        // string sma,sten;
       // public string ma;

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                sma = dtr[0].ToString();
                
                sten = dtr[2].ToString();
                
                smakv = dtr[1].ToString();
                
                ssoTK = dtr[3].ToString();
                snganhang = dtr[4].ToString();
                smasothue = dtr[5].ToString();
                sdiachi = dtr[6].ToString();
                sSDT = dtr[7].ToString();
                sfax = dtr[8].ToString();
                sWebsite = dtr[9].ToString();
                syahoo = dtr[10].ToString();
                snickskype = dtr[11].ToString();
                stinhtrang = dtr[12].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
   
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmThemKhachHang sua = new frmThemKhachHang();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MACHUYEN = sma;
            sua.TenKH = sten;
            sua.sMaKV = smakv;
            sua.SOTK = ssoTK;
            sua.NGANHANG = snganhang;
            sua.MASOTHUE = smasothue;
            sua.DIACHI = sdiachi;
            sua.SDT = sSDT;
            sua.FAX = sfax;
            sua.WEBSITE = sWebsite;
            sua.YAHOO = syahoo;
            sua.SKYPE = snickskype;
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

            }
            else
            {
                sua.ShowDialog();
                LOADDANHSACHKHACHHANG();

            }
            //sua.machuyen = sma;
            

            //LoadfrmSua();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LOADDANHSACHKHACHHANG();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
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
                    frmThemKhachHang sua = new frmThemKhachHang();
                    sua.iNgonNgu = iNgonNgu; sua.kiemtra = 0;
                    sua.MACHUYEN = sma;
                    sua.TenKH = sten;
                    sua.sMaKV = smakv;
                    sua.SOTK = ssoTK;
                    sua.NGANHANG = snganhang;
                    sua.MASOTHUE = smasothue;
                    sua.DIACHI = sdiachi;
                    sua.SDT = sSDT;
                    sua.FAX = sfax;
                    sua.WEBSITE = sWebsite;
                    sua.YAHOO = syahoo;
                    sua.SKYPE = snickskype;
                    sua.TINHTRANG = stinhtrang;
                    sua.ShowDialog();
                    LOADDANHSACHKHACHHANG();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

        }

        private void barNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
       
    }
}
