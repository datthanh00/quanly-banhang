using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevComponents.DotNetBar;
using WindowsFormsApplication1.Class_ManhCuong;
using DevExpress.Skins;
using System.Configuration;
using System.IO;
using System.Globalization;
using System.Threading;
using DevExpress.XtraEditors;
using WindowsFormsApplication1.HoaDonXuat;
using System.Diagnostics;
using WindowsFormsApplication1.KHtra;
using WindowsFormsApplication1.class_import;
//using DoanCuoi;


namespace WindowsFormsApplication1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
           
        }
        public frmBaoCaoTonKho frmTonKho;
        public Boolean isclose;
        private void btKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("11");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

           bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Khách hàng";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe ="Custommer";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "KhachHang";
                frmKhachHang dt = new frmKhachHang();
                dt.deDongTab = new frmKhachHang._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
          
        }
        //public void vTatTab()
        //{
        //    TabItem t = tabControl1.SelectedTab;
        //    tabControl1.Tabs.Remove(t);
        //}
        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            
            TabItem t = tabControl12.SelectedTab;
            tabControl12.Tabs.Remove(t);
        }
        public void vDoiTenTab()
        {
            for (int i = 0; i < tabControl12.Tabs.Count; i++)
            {
                if (iNgonNgu == 0)
                {
                    if (tabControl12.Tabs[i].Text == "sldalsd,asd")
                    {
                        tabControl12.SelectedTabIndex = i;


                    }
                }
                 
            }
        }
        private void btNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("12");

            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

         bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Nhà cung cấp";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Supplier";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "NhaCungCap";
                frmNhaCungCap dt = new frmNhaCungCap();
                dt.deDongTab = new frmNhaCungCap._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void bKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("13");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            // bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Khu vực";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe ="Area";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "KhuVuc";
                frmKhuVuc dt = new frmKhuVuc();
                dt.deDongTab = new frmKhuVuc._deDongTab(vDOngTab);
               dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("14");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

         bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Kho";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Store";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "Kho";
                frmKho1 dt = new frmKho1();
                dt.deDongTab = new frmKho1._deDongTab(vDOngTab);
           dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
            
        }
        
        private bool checkOpenTabs(string name)
        {
            for (int i = 0; i < tabControl12.Tabs.Count; i++)
            {
                //if (tabControl.TabPages[i].Text == name)
                if (tabControl12.Tabs[i].Text == name)
                {
                    tabControl12.SelectedTabIndex = i;
                    return true;

                }
            }
            return false;
        }
        clDTO dto = new clDTO();
        public string sManv, sTennv, sBoPhan;


        private void SetPhanQuyen(string MACN)
        {
            int tabcount= tabControl12.Tabs.Count;
            if (tabcount == 0)
            {
                //int phanquyencount = PhanQuyen.Rows.Count;
         
                int imacn = Convert.ToInt32(MACN);
       
                PublicVariable.XEM = PhanQuyen.Rows[imacn - 1]["TRUYCAP"].ToString();
                PublicVariable.THEM = PhanQuyen.Rows[imacn - 1]["THEM"].ToString();
                PublicVariable.XOA = PhanQuyen.Rows[imacn - 1]["XOA"].ToString();
                PublicVariable.SUA = PhanQuyen.Rows[imacn - 1]["SUA"].ToString();
                PublicVariable.IN = PhanQuyen.Rows[imacn - 1]["IN"].ToString();
            }

              
        }
        private void SetPhanQuyen2(string MACN)
        {

                int imacn = Convert.ToInt32(MACN);

                PublicVariable.TATCA = PhanQuyen.Rows[imacn - 1]["TATCA"].ToString();
                PublicVariable.XEM = PhanQuyen.Rows[imacn - 1]["TRUYCAP"].ToString();
                PublicVariable.THEM = PhanQuyen.Rows[imacn - 1]["THEM"].ToString();
                PublicVariable.XOA = PhanQuyen.Rows[imacn - 1]["XOA"].ToString();
                PublicVariable.SUA = PhanQuyen.Rows[imacn - 1]["SUA"].ToString();
                PublicVariable.IN = PhanQuyen.Rows[imacn - 1]["IN"].ToString();
            


        }

        private void SetPhanKho(DataTable KHO)
        {

            PublicVariable.KhoQL = KHO;
        }


        public void vKiemTraDangNhap()
        {
            int phanquyencount=PhanQuyen.Rows.Count;
            for (int i = 0; i < phanquyencount; i++)
            {
                switch (PhanQuyen.Rows[i]["MACN"].ToString())
                {
                    case "1":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString()=="True")
                        {
                            
                            btNhapHang.Enabled= true;
                            break;
                        }
                        else
                        {
                           
                            btNhapHang.Enabled = false;
                            break;
                        }
                    case "2":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btXuatHang.Enabled = true;
                            barButtonItem1.Enabled = true;
                            btnphanlo.Enabled = true;
                            break;
                        }
                        else
                        {
                            btXuatHang.Enabled = false;
                            barButtonItem1.Enabled = false;
                            btnphanlo.Enabled = false;
                            break;
                        }
                    case "3":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btmathangthongkhe.Enabled = true;
                            break;
                        }
                        else
                        {
                            btmathangthongkhe.Enabled = false;
                            break;
                        }
                    case "4":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            BTTraNCC.Enabled = true;
                            break;
                        }
                        else
                        {
                            BTTraNCC.Enabled = false;
                            break;
                        }
                    case "5":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            BTKHtra.Enabled = true;
                            break;
                        }
                        else
                        {
                            BTKHtra.Enabled = false;
                            break;
                        }
                    case "6":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btCongNoKH.Enabled = true;
                            break;
                        }
                        else
                        {
                            btCongNoKH.Enabled = false;
                            break;
                        }
                    case "7":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btCongNoNCC.Enabled = true;
                            break;
                        }
                        else
                        {
                            btCongNoNCC.Enabled = false;
                            break;
                        }
                    case "8":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btTongHop.Enabled = true;
                            break;
                        }
                        else
                        {
                            btTongHop.Enabled = false;
                            break;
                        }
                    case "9":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btDoanhThu.Enabled = true;
                            break;
                        }
                        else
                        {
                            btDoanhThu.Enabled = false;
                            break;
                        }
                    case "10":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btTonKho.Enabled = true;
                            break;
                        }
                        else
                        {
                            btTonKho.Enabled = false;
                            break;
                        }
                    case "11":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btKhachHang.Enabled = true;
                            break;
                        }
                        else
                        {
                            btKhachHang.Enabled = false;
                            break;
                        }
                    case "12":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btNhaCungCap.Enabled = true;
                            break;
                        }
                        else
                        {
                            btNhaCungCap.Enabled = false;
                            break;
                        }
                    case "13":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btKhuVuc.Enabled = true;
                            break;
                        }
                        else
                        {
                            btKhuVuc.Enabled = false;
                            break;
                        }
                    case "14":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btKho.Enabled = true;
                            break;
                        }
                        else
                        {
                            btKho.Enabled = false;
                            break;
                        }
                    case "15":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btNhomHang.Enabled = true;
                            break;
                        }
                        else
                        {
                            btNhomHang.Enabled = false;
                            break;
                        }
                    case "16":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btMatHang.Enabled = true;
                            break;
                        }
                        else
                        {
                            btMatHang.Enabled = false;
                            break;
                        }
                    case "17":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btDonViTinh.Enabled = true;
                            break;
                        }
                        else
                        {
                            btDonViTinh.Enabled = false;
                            break;
                        }
                    case "18":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btNhanVien.Enabled = true;
                            break;
                        }
                        else
                        {
                            btNhanVien.Enabled = false;
                            break;
                        }
                    case "19":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btBoPhan.Enabled = true;
                            break;
                        }
                        else
                        {
                            btBoPhan.Enabled = false;
                            break;
                        }
                    case "20":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btThue.Enabled = true;
                            break;
                        }
                        else
                        {
                            btThue.Enabled = false;
                            break;
                        }
                    case "21":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btSaoluu.Enabled = true;
                            break;
                        }
                        else
                        {
                            btSaoluu.Enabled = false;
                            break;
                        }
                    case "22":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btPhuchoi.Enabled = true;
                            break;
                        }
                        else
                        {
                            btPhuchoi.Enabled = false;
                            break;
                        }
                    case "23":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btPhanQuyen.Enabled = true;
                            btnlog.Enabled = true;
                            btnimportexcell.Enabled = true;
                            break;
                        }
                        else
                        {
                            btPhanQuyen.Enabled = false;
                            btnlog.Enabled = false;
                            btnimportexcell.Enabled = false;
                            break;
                        }
                    case "24":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btDoiMatKhau.Enabled = true;
                            break;
                        }
                        else
                        {
                            btDoiMatKhau.Enabled = false;
                            break;
                        }
                    case "25":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btThongTin.Enabled = true;
                            break;
                        }
                        else
                        {
                            btThongTin.Enabled = false;
                            break;
                        }
                    case "26":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            btnbanggia.Enabled = true;
                            break;
                        }
                        else
                        {
                            btnbanggia.Enabled = false;
                            break;
                        }
                    case "27":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtontondau.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtontondau.Enabled = false;
                            break;
                        }
                    case "28":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtoncongnodau.Enabled = true;
                            
                            break;
                        }
                        else
                        {
                            barButtoncongnodau.Enabled = false;
                           
                            break;
                        }
                    case "29":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonkiemkekho.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonkiemkekho.Enabled = false;
                            break;
                        }
                    case "30":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonkhoaso.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonkhoaso.Enabled = false;
                            break;
                        }
                    case "31":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonketso.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonketso.Enabled = false;
                            break;
                        }
                    case "32":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonphaithudauky.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonphaithudauky.Enabled = false;
                            break;
                        }
                    case "33":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonnhapkhac.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonnhapkhac.Enabled = false;
                            break;
                        }
                    case "34":
                        if (PhanQuyen.Rows[i]["TRUYCAP"].ToString() == "True")
                        {
                            barButtonxuatkhac.Enabled = true;
                            break;
                        }
                        else
                        {
                            barButtonxuatkhac.Enabled = false;
                            break;
                        }
                }
            }
               
        }
        System.Configuration.Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");
        System.Configuration.Configuration NgonNguVA = ConfigurationManager.OpenExeConfiguration("NgonNgu");
        public void loadStatus()
        {
            barStaticNhanVien.Caption= sTennv;
           barMayChu.Caption = AppC.AppSettings.Settings["Server"].Value;
          barDatabase.Caption = AppC.AppSettings.Settings["Database"].Value;
        }
        int iNgonNgu; 
        public DataTable PhanKho=new DataTable();
        public DataTable PhanQuyen = new DataTable();

        private void frmMain_Load(object sender, EventArgs e)
        {
            vKiemTraDangNhap();
            foreach (DevExpress.Skins.SkinContainer skin in DevExpress.Skins.SkinManager.Default.Skins)
            {
                BarCheckItem item = ribbon.Items.CreateCheckItem(skin.SkinName, false);
                item.Tag = skin.SkinName;
                item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(OnPaintStyleClick);
                barSubItem1.ItemLinks.Add(item);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = NgonNguVA.AppSettings.Settings["Skin"].Value;
            }
           
            if (!File.Exists("NgonNgu"))
            {
                File.Create("NgonNgu");
                FileInfo fi = new FileInfo("NgonNgu");
                fi.Attributes = FileAttributes.Hidden | FileAttributes.System;
            }
            if (!File.Exists("NgonNgu.config"))
            {
                NgonNguVA.AppSettings.Settings.Add("NgonNgu","0");
                NgonNguVA.Save();
            }
            
                iNgonNgu = int.Parse(NgonNguVA.AppSettings.Settings["NgonNgu"].Value);
                if (iNgonNgu==1)
                {
                    btAnh.Enabled = false;
                    loadEN();
                }
                if (iNgonNgu==0)
                {
                    btNgonNguViet.Enabled = false;
                    loadVN();
                }

            //gans cho kho ma user quan ly
                SetPhanKho(PhanKho);
                load_cbkho();
            loadStatus();
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
            ld.simpleCloseWait();
            timer1.Enabled = true;
            isclose = false;
            notifyIcon();
         
        }
 
        private void load_cbkho()
        {
            cbkho.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbkho.Properties.DisplayMember = "TENKHO";
            cbkho.Properties.ValueMember = "MAKHO";
            cbkho.Properties.View.BestFitColumns();
            cbkho.Properties.PopupFormWidth = 200;
            CTL ctl = new CTL();
            String SQL = "select TENKHO,KHO.MAKHO,CODEKHO from phankho,KHO WHERE KHO.MAKHO=PHANKHO.MAKHO AND MABP='" + sBoPhan + "' and quanly=1 AND KHO.TINHTRANG='TRUE'";
            
            cbkho.Properties.DataSource = ctl.GETDATA(SQL);
            gridcbkho.SelectRow(0);

            cbkho.Text = gridcbkho.GetFocusedRowCellValue("MAKHO").ToString();
          
            PublicVariable.MAKHO = gridcbkho.GetFocusedRowCellValue("MAKHO").ToString();
            PublicVariable.CODEKHO = gridcbkho.GetFocusedRowCellValue("CODEKHO").ToString();
            LOAD_CHUCNANGKHO();
            
        }
        void LOAD_CHUCNANGKHO()
        {
            CTL ctl = new CTL();
            string SQL = "select KHO.GHICHU from KHO where MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctl.GETDATA(SQL);
            string chucnang = dt.Rows[0][0].ToString();
            if (chucnang.IndexOf("HSD") >= 0)
            {
                PublicVariable.isHSD = true;
                btnphanlo.Enabled = true;
            }
            else
            {
                PublicVariable.isHSD = false;
                btnphanlo.Enabled = false;
            }

            if (chucnang.IndexOf("BARCODE") >= 0)
            {
                PublicVariable.isBARCODE = true;
            }
            else
            {
                PublicVariable.isBARCODE = false;
            }
            //HSD--BARCODE--TONTHUCTE
            if (chucnang.IndexOf("TONTHUCTE") >= 0)
            {
                PublicVariable.isTONTHUCTE = true;
                barButtonItem1.Enabled = true;
            }
            else
            {
                PublicVariable.isTONTHUCTE = false;
                barButtonItem1.Enabled = false;
            }

            if (chucnang.IndexOf("TONTHUCTE1") >= 0)
            {
                PublicVariable.isTONTHUCTE1 = true;
            }
            else
            {
                PublicVariable.isTONTHUCTE1 = false;
            }

            if (chucnang.IndexOf("KHOILUONG") >= 0)
            {
                PublicVariable.isKHOILUONG = true;
            }
            else
            {
                PublicVariable.isKHOILUONG = false;
            }

            if (chucnang.IndexOf("BANGGIA") >= 0)
            {
                PublicVariable.isBANGGIA = true;
                btnbanggia.Enabled = true;
            }
            else
            {
                PublicVariable.isBANGGIA = false;
                btnbanggia.Enabled = false;
            }
        }
        void OnPaintStyleClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString());
            luuSkin(e.Item.Tag.ToString());
        }
         Loadingggg ld = new Loadingggg();
        private void timer1_Tick(object sender, EventArgs e)
        {
            barThoiGian.Caption = DateTime.Now.ToString();
        }

        private void btDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("9");
            if (!checkOpenTabs("Báo Cáo Chi Phí - Doanh Thu"))
            {
                TabItem t = tabControl12.CreateTab("Báo Cáo Doanh Thu");
                t.Name = "Doanhthu";
                frmThongKeDoanhThu dt = new frmThongKeDoanhThu();
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }           
        }

        
        private void btDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen2("21");
            frmSaoLuu frmsaoluu = new frmSaoLuu();
            frmsaoluu.iNgonNgu = iNgonNgu;
            frmsaoluu.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen2("22");
            frmKhoiPhuc frm = new frmKhoiPhuc();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #region ngonngu
        public void loadEN()
        {
            tabControl12.Text = sTieuDe;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            //btSaoLuu.Caption = resEngLand.btPhucHoi.ToString();
            //btPhucHoi.Caption = resEngLand.btSaoLuu.ToString();
            ribDoiTac.Text = resEngLand.ribDoiTac.ToString();
            btBoPhan.Caption = resEngLand.btBoPhan.ToString();
            //btDanhSachNV.Caption = resEngLand.btDanhSachNV.ToString();
            btDonViTinh.Caption = resEngLand.btDonViTinh.ToString();
            btKhachHang.Caption = resEngLand.btKhachHang.ToString();
            btKho.Caption = resEngLand.btKho.ToString();
            btKhuVuc.Caption = resEngLand.btKhuVuc.ToString();
            btMatHang.Caption = resEngLand.btMatHang.ToString();
            btNhaCungCap.Caption = resEngLand.btNhaCungCap.ToString();
            btNhanVien.Caption = resEngLand.btNhanVien.ToString();
            btNhomHang.Caption = resEngLand.btNhomHang.ToString();
            ribDanhMuc.Text = resEngLand.ribDanhMuc.ToString();
            ribKhoHang.Text = resEngLand.ribKhoHang.ToString();
            ribNhanVien.Text = resEngLand.ribNhanVien.ToString();
            btCongNoKH.Caption = resEngLand.btCongNoKH.ToString();
            btCongNoNCC.Caption = resEngLand.btCongNoNCC.ToString();
            btDoanhThu.Caption = resEngLand.btDoanhThu.ToString();
            btHoaDonNhap.Caption = resEngLand.btHoaDonNhap.ToString();
            btHoaDonXuat.Caption = resEngLand.btHoaDonXuat.ToString();
            btHuongDan.Caption = resEngLand.btHuongDan.ToString();
            btLienHe.Caption = resEngLand.btLienHe.ToString();
            btNhapHang.Caption = resEngLand.btNhapHang.ToString();
            btNhomHang.Caption = resEngLand.btNhomHang.ToString();
            btTacGia.Caption = resEngLand.btTacGia.ToString();
            btTongHop.Caption = resEngLand.btTongHop.ToString();
            //btTonKho.Caption = resEngLand.btTonKho.ToString();
            btXuatHang.Caption = resEngLand.btXuatHang.ToString();
            ribChucNang.Text = resEngLand.ribChucNang.ToString();
            ribDanhMuc.Text = resEngLand.ribDanhMuc.ToString();
            ribDoiTac.Text = resEngLand.ribDoiTac.ToString();
            ribHeThong.Text = resEngLand.ribHeThong.ToString();
           // ribHoaDon.Text = resEngLand.ribHoaDon.ToString();
            ribKhoHang.Text = resEngLand.ribKhoHang.ToString();
            ribNhanVien.Text = resEngLand.ribNhanVien.ToString();
            ribQLCongNo.Text = resEngLand.ribQLCongNo.ToString();
            ribQLHangHoa.Text = resEngLand.ribQLHangHoa.ToString();
            ribThongKe.Text = resEngLand.ribThongke.ToString();
            ribTroGiup.Text = resEngLand.ribTroGiup.ToString();
            btTroGiupBar.Text = resEngLand.ribTroGiupBar.ToString();
            barChuongTrinh.Caption = resEngLand.barChuongTrinh.ToString();
            ribBaoMat.Text = resEngLand.ribBaoMat.ToString();
            ribDuLieu.Text = resEngLand.ribDuLieu.ToString();
            ribHeThongBar.Text = resEngLand.ribHeThongBar.ToString();
            btDangXuat.Caption = resEngLand.btDangXuat.ToString();
            btDoiMatKhau.Caption = resEngLand.btDoiMatKhau.ToString();
            btKetThuc.Caption = resEngLand.btKetThuc.ToString();
            btPhanQuyen.Caption = resEngLand.btPhanQuyen.ToString();
            btThongTin.Caption = resEngLand.btThongTin.ToString();
            this.Text = resEngLand.frmMain.ToString();
            hiệnToolStripMenuItem.Text = "Show";
            ẩnToolStripMenuItem.Text = "Hide";
            phụcHồiDữLiệuToolStripMenuItem.Text = resEngLand.btPhucHoi.ToString();
            saoLưuDữLiệuToolStripMenuItem.Text = resEngLand.btSaoLuu.ToString();
            thoátToolStripMenuItem.Text = resEngLand.Thoat.ToString();
            btmathangthongkhe.Caption = resEngLand.btMatHang.ToString();
            btThue.Caption = "Tax";
        }
        public void loadVN()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
           // btSaoLuu.Caption = resVietNam.btPhucHoi.ToString();
            //btPhucHoi.Caption = resVietNam.btSaoLuu.ToString();
            ribDoiTac.Text = resVietNam.ribDoiTac.ToString();
            btBoPhan.Caption = resVietNam.btBoPhan.ToString();
           // btDanhSachNV.Caption = resVietNam.btDanhSachNV.ToString();
            btDonViTinh.Caption = resVietNam.btDonViTinh.ToString();
            btKhachHang.Caption = resVietNam.btKhachHang.ToString();
            btKho.Caption = resVietNam.btKho.ToString();
            btKhuVuc.Caption = resVietNam.btKhuVuc.ToString();
            btMatHang.Caption = resVietNam.btMatHang.ToString();
            btNhaCungCap.Caption = resVietNam.btNhaCungCap.ToString();
            btNhanVien.Caption = resVietNam.btNhanVien.ToString();
            btNhomHang.Caption = resVietNam.btNhomHang.ToString();
            ribDanhMuc.Text = resVietNam.ribDanhMuc.ToString();
            ribKhoHang.Text = resVietNam.ribKhoHang.ToString();
            ribNhanVien.Text = resVietNam.ribNhanVien.ToString();
            btNhomHang.Caption = resVietNam.btNhomHang.ToString();
            ribDanhMuc.Text = resVietNam.ribDanhMuc.ToString();
            ribKhoHang.Text = resVietNam.ribKhoHang.ToString();
            ribNhanVien.Text = resVietNam.ribNhanVien.ToString();
            btCongNoKH.Caption = resVietNam.btCongNoKH.ToString();
            btCongNoNCC.Caption = resVietNam.btCongNoNCC.ToString();
            btDoanhThu.Caption = resVietNam.btDoanhThu.ToString();
            btHoaDonNhap.Caption = resVietNam.btHoaDonNhap.ToString();
            btHoaDonXuat.Caption = resVietNam.btHoaDonXuat.ToString();
            btHuongDan.Caption = resVietNam.btHuongDan.ToString();
            btLienHe.Caption = resVietNam.btLienHe.ToString();
            btNhapHang.Caption = resVietNam.btNhapHang.ToString();
            btNhomHang.Caption = resVietNam.btNhomHang.ToString();
            btTacGia.Caption = resVietNam.btTacGia.ToString();
            btTongHop.Caption = resVietNam.btTongHop.ToString();
            //btTonKho.Caption = resVietNam.btTonKho.ToString();
            btXuatHang.Caption = resVietNam.btXuatHang.ToString();
            ribChucNang.Text = resVietNam.ribChucNang.ToString();
            ribDanhMuc.Text = resVietNam.ribDanhMuc.ToString();
            ribDoiTac.Text = resVietNam.ribDoiTac.ToString();
            ribHeThong.Text = resVietNam.ribHeThong.ToString();
           // ribHoaDon.Text = resVietNam.ribHoaDon.ToString();
            ribKhoHang.Text = resVietNam.ribKhoHang.ToString();
            ribNhanVien.Text = resVietNam.ribNhanVien.ToString();
            ribQLCongNo.Text = resVietNam.ribQLCongNo.ToString();
            ribQLHangHoa.Text = resVietNam.ribQLHangHoa.ToString();
            ribThongKe.Text = resVietNam.ribThongke.ToString();
            ribTroGiup.Text = resVietNam.ribTroGiup.ToString();
            btTroGiupBar.Text = resVietNam.ribTroGiupBar.ToString();
            barChuongTrinh.Caption = resVietNam.barChuongTrinh.ToString();
            ribBaoMat.Text = resVietNam.ribBaoMat.ToString();
            ribDuLieu.Text = resVietNam.ribDuLieu.ToString();
            ribHeThongBar.Text = resVietNam.ribHeThongBar.ToString();
            btDangXuat.Caption = resVietNam.btDangXuat.ToString();
            btDoiMatKhau.Caption = resVietNam.btDoiMatKhau.ToString();
            btKetThuc.Caption = resVietNam.btKetThuc.ToString();
            btPhanQuyen.Caption = resVietNam.btPhanQuyen.ToString();
            btThongTin.Caption = resVietNam.btThongTin.ToString();
            this.Text = resVietNam.frmMain.ToString();
            hiệnToolStripMenuItem.Text = "Hiện";
            ẩnToolStripMenuItem.Text ="Ẩn";
            phụcHồiDữLiệuToolStripMenuItem.Text = resVietNam.btPhucHoi.ToString();
            saoLưuDữLiệuToolStripMenuItem.Text = resVietNam.btSaoLuu.ToString();
            thoátToolStripMenuItem.Text = resVietNam.Thoat.ToString();
            btmathangthongkhe.Caption = resVietNam.btMatHang.ToString();
            btThue.Caption = "Thuế";

        }
        #endregion
        private void btAnh_ItemClick(object sender, ItemClickEventArgs e)
        {
            vDoiTenTab();
            loadEN();
            if (bKTraMoTab)
                LoadEN();
            btAnh.Enabled = false;
            btNgonNguViet.Enabled = true;
            loadLuuNgonNgu(1);
            iNgonNgu = 1;
            loadLaiTenTab();
        }
        public void loadLuuNgonNgu(int kieuNgonNgu)
        {
            if (!File.Exists("NgonNgu"))
            {
                File.Create("NgonNgu");
                FileInfo fi = new FileInfo("NgonNgu");
                fi.Attributes = FileAttributes.Hidden | FileAttributes.System;
            }
            if (!File.Exists("NgonNgu.config"))
            {
                NgonNguVA.AppSettings.Settings.Add("NgonNgu", kieuNgonNgu.ToString());
                NgonNguVA.Save();
            }
            else
            {
                NgonNguVA.AppSettings.Settings["NgonNgu"].Value = kieuNgonNgu.ToString();

                NgonNguVA.Save();
            }
        }
        public void luuSkin(string name)
        {
            if (!File.Exists("NgonNgu.config"))
            {
                NgonNguVA.AppSettings.Settings.Add("Skin", name.ToString());
                NgonNguVA.Save();
            }
            else
            {
                NgonNguVA.AppSettings.Settings["Skin"].Value = name.ToString();
                NgonNguVA.Save();
            }
        }

        public delegate void Translate();
        public Translate LoadVI;
        public Translate LoadEN;

        bool bKTraMoTab = false;
        private void btNgonNguViet_ItemClick(object sender, ItemClickEventArgs e)
        { 

            loadLuuNgonNgu(0);
            iNgonNgu = 0;
            loadVN();
            if (bKTraMoTab)
                LoadVI();
                
            btAnh.Enabled = true;
            btNgonNguViet.Enabled = false;
            loadLaiTenTab();
           
            
        }
        public void loadLaiTenTab()
        {
            foreach (TabItem item in tabControl12.Tabs)
            
            {
                if (item.Name == "ThongKe")
                {
                    if (iNgonNgu == 0)
                        item.Text = "Báo cáo tồn khi tổng hợp";
                    else
                        item.Text = "Report total";
                }
                if (item.Name == "DoanhThu")
                {
                    if (iNgonNgu == 0)
                        item.Text = "Thống kê doanh thu";
                    else
                        item.Text = "Revenue report";
                }
                if (item.Name == "PhanQuyen")
                {
                    if (iNgonNgu == 0)
                        item.Text = "Phân quyền";
                    else
                        item.Text = "Decentralization";
                }
                if (item.Name == "MatHang")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btMatHang.ToString();
                    else
                        item.Text = resEngLand.btMatHang.ToString();
                }
                if (item.Name == "NhomHang")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btNhomHang.ToString();
                    else
                        item.Text = resEngLand.btNhomHang.ToString();
                }
                if (item.Name == "DonViTinh")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btDonViTinh.ToString();
                    else
                        item.Text = resEngLand.btDonViTinh.ToString();
                }
                if (item.Name == "NhaCungCap")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btNhaCungCap.ToString();
                    else
                        item.Text = resEngLand.btNhaCungCap.ToString();
                }
                if (item.Name == "KhuVuc")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btKhuVuc.ToString();
                    else
                        item.Text = resEngLand.btKhuVuc.ToString();
                }
                if (item.Name == "Kho")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btKho.ToString();
                    else
                        item.Text = resEngLand.btKho.ToString();
                }
                if (item.Name == "NhanVien")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btNhanVien.ToString();
                    else
                        item.Text = resEngLand.btNhanVien.ToString();
                }
                if (item.Name == "KhachHang")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btKhachHang.ToString();
                    else
                        item.Text = resEngLand.btKhachHang.ToString();
                }
                if (item.Name == "CNCC")
                {
                    if (iNgonNgu == 0)
                    {
                item.Text = "Công nợ nhà cung cấp";

                    }
                    else
                    {
                        item.Text = "Debt Custommer";

                    }
                }
                if (item.Name == "CNKH")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = "Công nợ khách hàng";

                    }
                    else
                    {
                        item.Text = "Custommer's Debt";

                    }
                }
                if (item.Name == "BoPhan")
                {
                    if (iNgonNgu == 0)
                        item.Text = resVietNam.btBoPhan.ToString();
                    else
                        item.Text = resEngLand.btBoPhan.ToString();
                }
                if (item.Name == "HoaDonXuat")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = resVietNam.btHoaDonXuat.ToString();

                    }
                    else
                    {
                        item.Text = resEngLand.btHoaDonXuat.ToString();

                    }
                } if (item.Name == "TKTongHop")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = resVietNam.btTongHop.ToString();

                    }
                    else
                    {
                        item.Text = resEngLand.btTongHop.ToString();

                    }
                }
                if (item.Name == "Thue")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = "Thuế"; 

                    }
                    else
                    {
                        item.Text = "Tax";

                    }
                }
                
                if (item.Name == "HoaDonNhap")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = resVietNam.btHoaDonNhap.ToString();
                    }
                    else
                    {
                        item.Text = resEngLand.btHoaDonNhap.ToString();

                    }
                }

                if (item.Name == "TKMatHang")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text ="Thống kê"+ resVietNam.btMatHang.ToString();
                    }
                    else
                    {
                        item.Text = "Static " + resEngLand.btMatHang.ToString();

                    }

                }
                if (item.Name == "TraNCC")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = "Trả hàng cho nhà cung cấp";
                    }
                    else
                    {
                        item.Text = "rerun product in company  ";

                    }

                }
                if (item.Name == "KHtra")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = "Khách hàng trả lại hàng";
                    }
                    else
                    {
                        item.Text = "Customner return product";

                    }

                }
                if (item.Name == "BANGGIA")
                {
                    if (iNgonNgu == 0)
                    {
                        item.Text = "Bảng Giá";
                    }
                    else
                    {
                        item.Text = "Bảng Giá";
                    }

                }
                //item.
            }
            //tabControl1.Text = sTieuDe;
        }
        string sTieuDe;
        private void btTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("10");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
            
            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu==0)
            {
                sTieuDe = "Tổng hợp xuất nhập tồn";
                
            }
            if (iNgonNgu==1)
            {
                sTieuDe = "Total of investory";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
               t.Name = "ThongKe";
                frmBaoCaoTonKho dt = new frmBaoCaoTonKho();
                dt.deDongTab = new frmBaoCaoTonKho._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }


        private void btDoanhThu_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("9");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Báo cáo doanh thu";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Revenue report";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "DoanhThu";
                frmThongKeDoanhThu dt = new frmThongKeDoanhThu();
                dt.deDongTab = new frmThongKeDoanhThu._deDongTab(vDOngTab);
                dt.frm=this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            } ld.simpleCloseWait();
        }

        private void vDOngTab()
        {
            foreach (TabItem item in tabControl12.Tabs)
            {
                if (item.IsSelected)
                {
                    tabControl12.Tabs.Remove(item);
                    return;
                }
            }
        }
        public string sMaBP;
        private void btMatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("16");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btMatHang.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btMatHang.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "MatHang";
                frmMatHang dt = new frmMatHang();
                dt.deDongTab = new frmMatHang._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.sMaBP = sBoPhan;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("1");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            //bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btHoaDonNhap.ToString();
            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btHoaDonNhap.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "HoaDonNhap";
                frmNhapHang dt = new frmNhapHang();
                dt.deDongTab = new frmNhapHang._deDongTab(vDOngTab);
                dt.frm = this;
                
                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen2("25");
            frmThongTin frm = new frmThongTin();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
        }

      

        private void btDangXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            

            if (iNgonNgu == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn đăng xuất hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    frmLogin frm = new frmLogin();
                    notifyIcon1.Dispose();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to Log Off ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    frmLogin frm = new frmLogin();
                    notifyIcon1.Dispose();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }

     
        private void btTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinNhom frm = new frmThongTinNhom();
            frm.ShowDialog();
        }



        #region ICon
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
              
                if (iNgonNgu ==0)
                {
                    notifyIcon1.ShowBalloonTip(1, "Thông báo", "Nhấn chuột phải chọn hiển thị lại để mở lại cửa sổ hoặc double click vào icon chương trình", ToolTipIcon.Info);
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(1, "Infomation", "Right-click again to select the display window open or double click the program icon", ToolTipIcon.Info);
                }
               
            }
        }
        private void notifyIcon()
        {
           
            notifyIcon1.Text = "Quản Lý Kho";

            if (iNgonNgu == 0)
            {
                notifyIcon1.ShowBalloonTip(1, "Chào mừng", "Chương trình quản lý xuất nhập tồn đang chạy máy tính của bạn", ToolTipIcon.Info);
            }
            else
                notifyIcon1.ShowBalloonTip(1, "Welcome", "Entry management programs exist that are running your computer", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                    notifyIcon1.ContextMenuStrip = contextMenuStrip1;
                
            }  
        }

        private void hiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                if (iNgonNgu == 0)
                {
                    notifyIcon1.ShowBalloonTip(1, "Thông báo", "Nhấn chuột phải chọn hiển thị lại để mở lại cửa sổ hoặc double click vào icon chương trình", ToolTipIcon.Info);
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(1, "Infomation", "Right-click again to select the display window open or double click the program icon", ToolTipIcon.Info);
                }


        }
        #endregion

        private void phụcHồiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoiPhuc frm = new frmKhoiPhuc();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaoLuu frmsaoluu = new frmSaoLuu();
            frmsaoluu.iNgonNgu = iNgonNgu;
            frmsaoluu.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iNgonNgu == 0)
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    notifyIcon1.Dispose();
                    Application.Exit();
                }
            }
            else
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Do you want to exit program? ", "Notifications", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    notifyIcon1.Dispose();
                    Application.Exit();
                }
            }
           
        }

        private void btPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("23");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

           bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Phân quyền";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Decentralization";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "PhanQuyen";
                frmPhanQuyen dt = new frmPhanQuyen();
                dt.deDongTab = new frmPhanQuyen._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("19");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
         bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btBoPhan.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btBoPhan.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "BoPhan";
                frmBoPhan dt = new frmBoPhan();
                dt.deDongTab = new frmBoPhan._deDongTab(vDOngTab);
                dt.frm = this;
               dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("18");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btNhanVien.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btNhanVien.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "NhanVien";
                frmNhanVien dt = new frmNhanVien();
                dt.deDongTab = new frmNhanVien._deDongTab(vDOngTab);
              dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("17");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

           bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.colDonViTInh.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.colDonViTInh.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "DonViTinh";
                frmDonViTinh dt = new frmDonViTinh();
               dt.deDongTab = new frmDonViTinh._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("15");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

          bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.colNhomHang.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.colNhomHang.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "NhomHang";
                frmnhomhang dt = new frmnhomhang();
                dt.deDongTab = new frmnhomhang._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barSubItem1_Popup(object sender, EventArgs e)
        {
            foreach (BarItemLink link in barSubItem1.ItemLinks)
                ((BarCheckItem)link.Item).Checked = link.Item.Caption == defaultLookAndFeel1.LookAndFeel.ActiveSkinName;
        }

        private void btKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (iNgonNgu == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    notifyIcon1.Dispose();
                    Application.Exit();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to exit ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    notifyIcon1.Dispose();
                    Application.Exit();
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isclose == true)
            {
                notifyIcon1.Dispose();
                Application.Exit();
            }
            
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iNgonNgu == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    isclose = true;
                    e.Cancel = false;
                }
                else
                {
                    isclose = false;
                    e.Cancel = true;
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to exit ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    isclose = true;
                    e.Cancel = false;
                }
                else
                {
                    isclose = false;
                    e.Cancel = true;
                }
            }
        }

        private void btCongNoNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("7");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Công Nợ NCC";
            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Debt Custommer";
            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "CNCC";
                frmCongNoNcc dt = new frmCongNoNcc();
                dt.deDongTab = new frmCongNoNcc._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sTenNV = sTennv;
                dt.sMaNV = sManv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btCongNoKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("6");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Công Nợ Khách Hàng";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Custommer's Debt";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "CNKH";
                frmCongNoKH dt = new frmCongNoKH();
                dt.deDongTab = new frmCongNoKH._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sTenNV = sTennv;
                dt.sMaNV = sManv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btTongHop_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("8");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btTongHop.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btTongHop.ToString();
                
            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "TKTongHop";
                frmBaoCaoTongHop dt = new frmBaoCaoTongHop();
                dt.deDongTab = new frmBaoCaoTongHop._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btmathangthongkhe_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("3");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Tồn Kho Theo Hàng Hóa";
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "TKMatHang";
                frmTonphanlo dt = new frmTonphanlo();
                dt.deDongTab = new frmTonphanlo._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btThue_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("20");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

           bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Thuế";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Tax";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "Thue";
                frmThue dt = new frmThue();
                dt.deDongTab = new frmThue._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("2");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

          //  bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = resVietNam.btHoaDonXuat.ToString();
            }
            if (iNgonNgu == 1)
            {
                sTieuDe = resEngLand.btHoaDonXuat.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "HoaDonXuat";
                frmHoaDonXuat dt = new frmHoaDonXuat();
                dt.deDongTab = new frmHoaDonXuat._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen2("24");
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.sMaNV = sManv;
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
        }

        private void btHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process notePad = new Process();

            notePad.StartInfo.FileName = "Help.chm";
           

            notePad.Start();
        }

        private void btLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLienHe frm = new frmLienHe();
            frm.ShowDialog();
        }

        private void BTTraNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("4");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            //bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Trả NCC";
            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "rerun product in company  ";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "TraNCC";
                frmTraNCC dt = new frmTraNCC();
                dt.deDongTab = new frmTraNCC._deDongTab(vDOngTab);
                dt.frm = this;

                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void BTKHtra_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("5");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            //  bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "KH trả hàng";
            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "rerun product in company";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "KHtra";
                frmKHtra dt = new frmKHtra();
                dt.deDongTab = new frmKHtra._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void cbkho_EditValueChanged(object sender, EventArgs e)
        {
            
            PublicVariable.MAKHO = gridcbkho.GetFocusedRowCellValue("MAKHO").ToString();
            PublicVariable.CODEKHO = gridcbkho.GetFocusedRowCellValue("CODEKHO").ToString();
            LOAD_CHUCNANGKHO();
            //for (int i = 0; i < tabControl12.Tabs.Count; i++)
            //{
                tabControl12.Tabs.Clear();
            //}
          
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("23");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
       
            sTieuDe = "LOG Hệ thống";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "LOG";
                frmLog dt = new frmLog();
                dt.deDongTab = new frmLog._deDongTab(vDOngTab);

                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("23");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;

            sTieuDe = "import dữ liệu bằng excell";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "import_excell";
                import dt = new import();
                dt.deDongTab = new import._deDongTab(vDOngTab);

                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }



    

        private void tabControl12_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
           

            TabItem ti = tabControl12.SelectedTab as TabItem;


            int imacn = 1;
            if(ti!=null)
            switch (ti.Name)
            {
                case "HoaDonNhap":
                    imacn = 1;
                    break;
                case "HoaDonXuat":
                    imacn = 2;
                    break;
                case "TKMatHang":
                    imacn = 3;
                    break;
                case "TraNCC":
                    imacn = 4;
                    break;
                case "KHtra":
                    imacn = 5;
                    break;
                case "CNKH":
                    imacn = 6;
                    break;
                case "CNCC":
                    imacn = 7;
                    break;
                case "TKTongHop":
                    imacn = 8;
                    break;
                case "Doanhthu":
                    imacn = 9;
                    break;
                case "ThongKe":
                    imacn = 10;
                    break;
                case "KhachHang":
                    imacn = 11;
                    break;
                case "NhaCungCap":
                    imacn = 12;
                    break;
                case "KhuVuc":
                    imacn = 13;
                    break;
                case "Kho":
                    imacn = 14;
                    break;
                case "NhomHang":
                    imacn = 15;
                    break;
                case "MatHang":
                    imacn = 16;
                    break;
                case "DonViTinh":
                    imacn = 17;
                    break;
                case "NhanVien":
                    imacn = 18;
                    break;
                case "BoPhan":
                    imacn = 19;
                    break;
                case "Thue":
                    imacn = 20;
                    break;
                case "PhanQuyen":
                    imacn = 23;
                    break;
                case "LOG":
                    imacn = 23;
                    break;
                case "import_excell":
                    imacn = 23;
                    break;
                case "BANGGIA":
                    imacn = 26;
                    break;
                case "TONDAUKY":
                    imacn = 27;
                    break;
                case "CONGNODAUKY":
                    imacn = 28;
                    break;
                case "KIEMKEKHO":
                    imacn = 29;
                    break;
                case "KHOASO":
                    imacn = 30;
                    break;
                case "CHOTSO":
                    imacn = 31;
                    break;
                case "PHAITHUDAUKY":
                    imacn = 32;
                    break;
                case "NHAPKHAC":
                    imacn = 33;
                    break;
                case "XUATKHAC":
                    imacn = 34;
                    break;
            }

            PublicVariable.TATCA = PhanQuyen.Rows[imacn - 1]["TATCA"].ToString();
            PublicVariable.XEM = PhanQuyen.Rows[imacn - 1]["TRUYCAP"].ToString();
            PublicVariable.THEM = PhanQuyen.Rows[imacn - 1]["THEM"].ToString();
            PublicVariable.XOA = PhanQuyen.Rows[imacn - 1]["XOA"].ToString();
            PublicVariable.SUA = PhanQuyen.Rows[imacn - 1]["SUA"].ToString();
            PublicVariable.IN = PhanQuyen.Rows[imacn - 1]["IN"].ToString();


            //MessageBox.Show(ti.Name);
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {

            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Tồn Kho thực tế theo ngày";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Total of investory";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "tonkhongay";
                frmTonKhoNgay dt = new frmTonKhoNgay();
                dt.deDongTab = new frmTonKhoNgay._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void btnphanlo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Tồn Kho Phân Lô";

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Total of investory";

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "tonphanlo";
                frmTonphanlo dt= new frmTonphanlo();
                dt.deDongTab = new frmTonphanlo._deDongTab(vDOngTab);
                dt.frm = this;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("26");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Bảng Giá Mặt Hàng";
           
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "BANGGIA";
                frmBanggia dt = new frmBanggia();
                dt.deDongTab = new frmBanggia._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtontondau_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("27");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Số Lượng Hàng Hóa Đầu Kỳ";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "TONDAUKY";
                frmhangtondau dt = new frmhangtondau();
                dt.deDongTab = new frmhangtondau._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtoncongnodau_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("28");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Công Nợ Nhà Cung Cấp Đầu Kỳ";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "CONGNODAUKY";
                frmnodauky dt = new frmnodauky();
                dt.deDongTab = new frmnodauky._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonkiemkekho_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("29");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Kiểm Kê Kho";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "KIEMKEKHO";
                frmKiemkho dt = new frmKiemkho();
                dt.deDongTab = new frmKiemkho._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonkhoaso_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("30");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Khóa Sổ";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "KHOASO";
                frmKhoaso dt = new frmKhoaso();
                dt.deDongTab = new frmKhoaso._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonketso_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("31");
            frmKetso frmKetso1 = new frmKetso();
            frmKetso1.ShowDialog();
        }

        private void barButtonphaithudauky_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("32");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            bKTraMoTab = true;
            sTieuDe = "Công Nợ Khách Hàng Đầu Kỳ";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "PHAITHUDAUKY";
                frmKHnodauky dt = new frmKHnodauky();
                dt.deDongTab = new frmKHnodauky._deDongTab(vDOngTab);
                dt.frm = this;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonnhapkhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("33");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            //  bKTraMoTab = true;
            sTieuDe = "Nhập Khác";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "NHAPKHAC";
                frmnhapkhac dt = new frmnhapkhac();
                dt.deDongTab = new frmnhapkhac._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }

        private void barButtonxuatkhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("34");
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");

            //  bKTraMoTab = true;
            sTieuDe = "Xuất Khác";

            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "XUATKHAC";
                frmxuatkhac dt = new frmxuatkhac();
                dt.deDongTab = new frmxuatkhac._deDongTab(vDOngTab);
                dt.frm = this;
                dt.sMaNV = sManv;
                dt.sTenNV = sTennv;
                dt.iNgonNgu = iNgonNgu;
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            ld.simpleCloseWait();
        }


    }
}