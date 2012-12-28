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
            int phanquyencount = PhanQuyen.Rows.Count;
            PublicVariable PV = new PublicVariable();

           // for (int i = 0; i < phanquyencount; i++)
           // {
            int imacn = Convert.ToInt32(MACN);
                //if (PhanQuyen.Rows[i]["MACN"].ToString() == MACN)
                //{
            PV.XEM = PhanQuyen.Rows[imacn-1]["TRUYCAP"].ToString();
            PV.THEM = PhanQuyen.Rows[imacn-1]["THEM"].ToString();
            PV.XOA = PhanQuyen.Rows[imacn-1]["XOA"].ToString();
            PV.SUA = PhanQuyen.Rows[imacn-1]["SUA"].ToString();
            PV.IN = PhanQuyen.Rows[imacn-1]["IN"].ToString();
                //}
            //}
        }
        private void SetPhanKho(DataTable KHO)
        {
            PublicVariable PV = new PublicVariable();
            PV.AddKhoQL(KHO);
        }

        public Boolean Isused(string MACN)
        {
            int phanquyencount = PhanQuyen.Rows.Count;
            string TATCA,TRUYCAP;
            for (int i = 0; i < phanquyencount; i++)
            {
                if (PhanQuyen.Rows[i]["MACN"].ToString() == MACN)
                {
                    TRUYCAP = PhanQuyen.Rows[i]["TRUYCAP"].ToString();
                    if (TRUYCAP == "1")
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
        public void vKiemTraDangNhap()
        {
            int phanquyencount=PhanQuyen.Rows.Count;
            for (int i = 0; i < phanquyencount; i++)
            {
                switch (PhanQuyen.Rows[i]["MACN"].ToString())
                {
                    case "1":
                        if (Isused("1"))
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
                        if (Isused("2"))
                        {
                            btXuatHang.Enabled = true;
                            break;
                        }
                        else
                        {
                            btXuatHang.Enabled = false;
                            break;
                        }
                    case "3":
                        if (Isused("3"))
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
                        if (Isused("4"))
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
                        if (Isused("5"))
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
                        if (Isused("6"))
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
                        if (Isused("7"))
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
                        if (Isused("8"))
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
                        if (Isused("9"))
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
                        if (Isused("10"))
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
                        if (Isused("11"))
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
                        if (Isused("12"))
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
                        if (Isused("13"))
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
                        if (Isused("14"))
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
                        if (Isused("15"))
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
                        if (Isused("16"))
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
                        if (Isused("17"))
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
                        if (Isused("18"))
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
                        if (Isused("19"))
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
                        if (Isused("20"))
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
                        if (Isused("21"))
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
                        if (Isused("22"))
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
                        if (Isused("23"))
                        {
                            btPhanQuyen.Enabled = true;
                            break;
                        }
                        else
                        {
                            btPhanQuyen.Enabled = false;
                            break;
                        }
                    case "24":
                        if (Isused("24"))
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
                        if (Isused("25"))
                        {
                            btThongTin.Enabled = true;
                            break;
                        }
                        else
                        {
                            btThongTin.Enabled = false;
                            break;
                        }

                }
            }
                if (sBoPhan == "MABP00001")
                {
                    btNhapHang.Enabled = true;
                    btCongNoNCC.Enabled = true;
                    btHoaDonNhap.Enabled = true;
                    btXuatHang.Enabled = false;
                    btHoaDonXuat.Enabled = false;
                    btCongNoKH.Enabled = false;
                    ribBaoMat.Visible = false;
                    ribDuLieu.Visible = false;
                    ribNhanVien.Visible = false;
                }
            if (sBoPhan == "MABP00002")
            {

                btXuatHang.Enabled = true;
                btHoaDonXuat.Enabled = true;
                btCongNoKH.Enabled = true;
                btNhapHang.Enabled = false;
                btCongNoNCC.Enabled = false;
                btHoaDonNhap.Enabled = false;
                ribBaoMat.Visible = false;
                ribDuLieu.Visible = false;
                ribNhanVien.Visible = false;
            }
           
            if (sBoPhan == "MABP00004")
            {
                btNhapHang.Enabled = true;
                btCongNoNCC.Enabled = true;
                btHoaDonNhap.Enabled = true;
                btXuatHang.Enabled = true;
                btHoaDonXuat.Enabled = true;
                btCongNoKH.Enabled = true;
                ribBaoMat.Visible = true;
                ribDuLieu.Visible = true;
                ribNhanVien.Visible = true;
                
               
            
                
            }
            if (sBoPhan == "MABP00003")
            {
                btNhapHang.Enabled = true;
                btCongNoNCC.Enabled = true;
                btHoaDonNhap.Enabled = true;
                btXuatHang.Enabled = true;
                btHoaDonXuat.Enabled = true;
                btCongNoKH.Enabled = true;
                ribBaoMat.Visible = false;
                ribDuLieu.Visible = false;
                ribNhanVien.Visible = false;
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
           
            loadStatus();
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
            ld.simpleCloseWait();
            timer1.Enabled = true;
            notifyIcon();
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
            if (!checkOpenTabs("Báo Cáo Doanh Thu"))
            {
                TabItem t = tabControl12.CreateTab("Báo Cáo Doanh Thu");
                frmThongKeDoanhThu dt = new frmThongKeDoanhThu();
                dt.TopLevel = false;
                dt.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(dt);
                dt.Show();
                tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
            }
            
            
        }

        private void btTongHop_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabItem t = tabControl12.CreateTab("Báo Cáo Doanh Thu");
            frmThongKeTongHop th = new frmThongKeTongHop();
            th.TopLevel = false;
            th.Dock = DockStyle.Fill;
            t.AttachedControl.Controls.Add(th);
            th.Show();
            tabControl12.SelectedTabIndex = tabControl12.Tabs.Count - 1;
        }

        private void btDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("21");
            frmSaoLuu frmsaoluu = new frmSaoLuu();
            frmsaoluu.iNgonNgu = iNgonNgu;
            frmsaoluu.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPhanQuyen("22");
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
            btTonKho.Caption = resEngLand.btTonKho.ToString();
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
            btTonKho.Caption = resVietNam.btTonKho.ToString();
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
            SetPhanQuyen("25");
            frmThongTin frm = new frmThongTin();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btDangXuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            

            if (iNgonNgu == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn đăng xuất hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    frmLogin frm = new frmLogin();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to Log Off ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    frmLogin frm = new frmLogin();
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
                this.Hide();
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
           
            notifyIcon1.Text = "ProMag";

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
                    Application.Exit();
                }
            }
            else
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Do you want to exit program? ", "Notifications", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
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
                    Application.Exit();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Do you want to exit ? ", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
         
                Application.Exit();
            
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
                sTieuDe = "Trả Tiền";
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
                sTieuDe = "Thu Tiền";

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
                frmBangKeXuatKhoTheoKHAchhangHangHoa dt = new frmBangKeXuatKhoTheoKHAchhangHangHoa();
                dt.deDongTab = new frmBangKeXuatKhoTheoKHAchhangHangHoa._deDongTab(vDOngTab);
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
            sTieuDe = "";
            if (iNgonNgu == 0)
            {
                sTieuDe = "Thống kê" + resVietNam.btMatHang.ToString();

            }
            if (iNgonNgu == 1)
            {
                sTieuDe = "Static " + resEngLand.btMatHang.ToString();

            }
            if (!checkOpenTabs(sTieuDe))
            {
                TabItem t = tabControl12.CreateTab(sTieuDe);
                t.Name = "TKMatHang";
                frmThongKeTongHop dt = new frmThongKeTongHop();
                dt.deDongTab = new frmThongKeTongHop._deDongTab(vDOngTab);
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
            SetPhanQuyen("24");
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

    }
}