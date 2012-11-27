using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraEditors.DXErrorProvider;
using WindowsFormsApplication1.Class_ManhCuong;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsFormsApplication1.HoaDonXuat
{
    public partial class frmHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDonXuat()
        {
            InitializeComponent();
        }
        DataView dtvKH = new DataView();
        DataView dtvNhanVien = new DataView();
        DataView dtvMH = new DataView();
        DataView dtvDVT = new DataView();
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        public void loadgridKhachHang()
        {
            cboTenKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenKH.Properties.DataSource = dtvKH;
            cboTenKH.Properties.DisplayMember = "TENKH";
            cboTenKH.Properties.ValueMember = "MAKH";
            cboTenKH.Properties.View.BestFitColumns();
            cboTenKH.Properties.PopupFormWidth = 300;
            cboTenKH.Properties.DataSource = ctlNCC.GETKHACHHANG();
           // dtoNCC.MANCC = gridKH1.GetFocusedRowCellValue("TENKH").ToString();
            cboMaKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMaKH.Properties.DataSource = dtvKH;
            cboMaKH.Properties.DisplayMember = "MAKH";
            cboMaKH.Properties.ValueMember = "MAKH";
            cboMaKH.Properties.View.BestFitColumns();
            cboMaKH.Properties.PopupFormWidth = 300;
            cboMaKH.Properties.DataSource = ctlNCC.GETKHACHHANG();
        }
        public void loadgridKhachHang(string MAKH)
        {
            cboTenKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenKH.Properties.DataSource = dtvKH;
            cboTenKH.Properties.DisplayMember = "TENKH";
            cboTenKH.Properties.ValueMember = "MAKH";
            cboTenKH.Properties.View.BestFitColumns();
            cboTenKH.Properties.PopupFormWidth = 300;
            DataTable dt = ctlNCC.GETKHACHHANG(MAKH);
            cboTenKH.Properties.DataSource = dt;
            cboTenKH.Text = dt.Rows[0]["MANCC"].ToString();

        }
        public void Load_panel_create()
        {
            Panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            panel_Grid.Visible = false;
            panel_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Create.Visible = true;
            panel_info.Visible = true;
            panel_tool.Visible = true;
        }
        public void Load_panel_filter()
        {
            Panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            panel_Grid.Visible = true;
            panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Create.Visible = false;
            panel_info.Visible = false;
            panel_tool.Visible = false;
        }
        public void loadgridCTHOADON()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("_MaMH"));
            dt.Columns.Add(new DataColumn("_TenMH"));
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("_DonGia"));
            dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            gridControl1.DataSource = dt;

        }
        public void loadgridCTHOADON(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETCTHOADONXUAT(MHDX);
            gridControl1.DataSource = dt;

        }
        public void loadGrid_sanpham()
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH();
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "MAMH";

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public int iNgonNgu;
        public frmMain frm;
        public string sTenNV, sMaNV;
        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
           // cbotientra.Text = "0";
            loadgridKhachHang();
            loadgridNhanVien();
           // loaddridmathang();
           // loaddridDVT();
           // loadgridthue();
            loadmahdx();
            loadgridCTHOADON();
            loadGrid_sanpham();
            cboNhanVienLap.Text = sMaNV;
            Load_panel_create();
        }

        private void cboTenKH_Validated(object sender, EventArgs e)
        {

            DataRow rowselect = gridKH1.GetFocusedDataRow();

            if (rowselect != null)
            {
                cboMaKH.Text = gridKH1.GetFocusedRowCellValue("MAKH").ToString();
                txtSDT.Text = gridKH1.GetFocusedRowCellValue("SDT").ToString();
                txtDiachi.Text = gridKH1.GetFocusedRowCellValue("DIACHI").ToString();
                //txtWeb.Text = gridKH1.GetFocusedRowCellValue("WEBSITE").ToString();   
            }
        }


        public void loadgridNhanVien()
        {
            cboNhanVienLap.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboNhanVienLap.Properties.DataSource = dtvNhanVien;
            cboNhanVienLap.Properties.DisplayMember = "TENNV";
            cboNhanVienLap.Properties.ValueMember = "MANV";
            cboNhanVienLap.Properties.View.BestFitColumns();
            cboNhanVienLap.Properties.PopupFormWidth = 300;
            cboNhanVienLap.Properties.DataSource = ctlNCC.GETNV();
            dtoNCC.MANV = gridNV.GetFocusedRowCellValue("MANV").ToString();
        }
        /*
        public void loaddridmathang()
        {
            cboMaMatHang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMaMatHang.Properties.DataSource = dtvMH;
            cboMaMatHang.Properties.DisplayMember = "MAMH";
            cboMaMatHang.Properties.ValueMember = "TENMH";
            cboMaMatHang.Properties.View.BestFitColumns();
            cboMaMatHang.Properties.PopupFormWidth = 300;
            cboMaMatHang.Properties.DataSource = ctlNCC.GETMATHANG();
            dtoNCC.MAMH = gridMH.GetFocusedRowCellValue("MAMH").ToString();
           
        }
        public void loaddridDVT()
        {
            cboDVT.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboDVT.Properties.DataSource = dtvDVT;
            cboDVT.Properties.DisplayMember = "DONVITINH";
            cboDVT.Properties.ValueMember = "MADVT";
            cboDVT.Properties.View.BestFitColumns();
            cboDVT.Properties.PopupFormWidth = 300;
            cboDVT.Properties.DataSource = ctlNCC.GETDVT();
            dtoNCC.MADVT = gridDVT.GetFocusedRowCellValue("MADVT").ToString();
           
        }
         
        public void loadgridthue()
        {
            cboThue.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboThue.Properties.DataSource = dtvMH;
            cboThue.Properties.DisplayMember = "SOTHUE";
            cboThue.Properties.ValueMember = "MATH";
            cboThue.Properties.View.BestFitColumns();
            cboThue.Properties.PopupFormWidth = 300;
            cboThue.Properties.DataSource = ctlNCC.GETTHUE();
            dtoNCC.MATH = gridTHUE.GetFocusedRowCellValue("MATH").ToString();
        }
        private void cboMaMatHang_EditValueChanged(object sender, EventArgs e)
        {
            cboTenMH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenMH.Properties.DataSource = dtvMH;
            cboTenMH.Properties.DisplayMember = "TENMH";
            cboTenMH.Properties.ValueMember = "TENMH";
            cboTenMH.Properties.View.BestFitColumns();
            cboTenMH.Properties.PopupFormWidth = 300;
            cboTenMH.Properties.DataSource = ctlNCC.GETMATHANG();
            cboTenMH.Text = gridMH.GetFocusedRowCellValue("TENMH").ToString();
            cboThue.Text = gridMH.GetFocusedRowCellValue("MATH").ToString();
            cboDVT.Text = gridMH.GetFocusedRowCellValue("MADVT").ToString();
            cboDonGia.Text = gridMH.GetFocusedRowCellValue("GIABAN").ToString();
        }
         */
        ArrayList list1 = new ArrayList();
        WindowsFormsApplication1.Class_ManhCuong.Cart.HoaDon hd = new Cart.HoaDon();
       /* private void btXemTruoc_Click(object sender, EventArgs e)
        {
                ArrayList list = new ArrayList();
                if (int.Parse(cboSL.Text) <= 0)
                {
                    Validate_LessThanMinRule(cboSL, 0);
                    XtraMessageBox.Show("Nhập Số Lượng không phù hợp");

                }
                else
                {
                    createHoadon();
                    foreach (Cart cart in hd._Cart)
                    {
                        list.Add(cart);
                    }
                    gridControl1.DataSource = list;
                    list1 = list;
                    txtthanhtien.Text = hd.tong_HoaDon.ToString();
                }
        }
        public void createHoadon()
        {
            String mamh = cboMaMatHang.Text;
            try
            {
                ctlNCC.GETMH();
                if (int.Parse(cboSL.Text) > 0)
                    hd.insert_item_toCart(cboMaMatHang.Text, cboTenMH.Text, int.Parse(cboSL.Text), int.Parse(cboDonGia.Text), int.Parse(cboThue.Text), cboDVT.Text);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu"); }
            catch (Exception ex) { MessageBox.Show("Có lỗi sảy ra, bạn có chắc là đã thao tác đúng các bước không?", "Norther says", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
            }
        }
        */
        private void Validate_LessThanMinRule(BaseEdit control, Decimal min)
        {
            if (!(control.EditValue is Decimal)) return;
            if ((Decimal)control.EditValue < min) dxErrorProvider1.SetError(control, "Please enter a greater value than " + min.ToString(), ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }

        private void cboSL_Validating(object sender, CancelEventArgs e)
        {
            Validate_LessThanMinRule(sender as BaseEdit, 0);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMaKH.Text =="")
                {
                    XtraMessageBox.Show("Vui lòng chọn Mã Khách Hàng");
                }
                else
                {
                
            dtoNCC.MAKH = cboMaKH.Text;
            dtoNCC.TENKH = cboTenKH.Text;
            dtoNCC.DIACHI = txtDiachi.Text;
            dtoNCC.SDT = txtSDT.Text;
           // dtoNCC.WEBSITE = txtWeb.Text;
            dtoNCC.NGAYXUAT = DateTime.Now;
            dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
            dtoNCC.MAHDX = txtMaHD.Text;
            if (cbotientra.Text == "")
            {
                cbotientra.Text = "0";
            }
            dtoNCC.GHICHU= textBoxX1.Text;
             
            dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

            bool isINSERTHOADONXUAT = ctlNCC.isINSERTHOADONXUAT(dtoNCC.MAHDN);
            if (isINSERTHOADONXUAT)
            {
                ctlNCC.INSERTHOADONXUAT(dtoNCC);
            }
            else
            {
                ctlNCC.UPDATEHOADONXUAT(dtoNCC);
            }

            
              

            int rowcount = gridCTHOADON.DataRowCount;
            for (int i = 0; i < rowcount; i++)
            {
               DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
               insert_HoadonChitietxuat(txtMaHD.Text, dtr["_MaMH"].ToString(), int.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
            }

            loadGiaoDich();
            MessageBox.Show("Bạn Đã Thêm Thành Công");
            loadmahdx();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
      
        private void loadGiaoDich()
        {
            dtoNCC.NGAYXUAT = DateTime.Now;
            gridControl2.DataSource = ctlNCC.GETHOADONXUAT(dtoNCC);
        }
        double conlai, thanhtien, tientra;
        private void cbotientra_TextChanged(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }
        public void insert_HoadonChitietxuat(string mahdx, String mamh, int SoLuong, int DonGia)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;


                bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(mahdx, mamh);
                if (isinsert)
                {
                    ctlNCC.INSERTCTHOADONNHAP(dtoNCC);
                    MessageBox.Show("insert");
                }
                else
                {
                    ctlNCC.UPDATECTHOADONNHAP(dtoNCC);
                    MessageBox.Show("update");
                }



                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        int kiemtra;
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmThemKhachHang tkh = new frmThemKhachHang();
           // tkh.iNgonNgu = iNgonNgu;
            tkh.kiemtra = 1;
            tkh.ShowDialog();
        }

        private void btIn_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    //dt = gridCTHOADON.DataSource;
                    Inxuat rep = new Inxuat(list1, cboTenKH.Text, txtDiachi.Text,cbotientra.Text, txtNo.Text, txtthanhtien.Text, txtMaHD.Text);
                    rep.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Chưa có CT nào");
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
           
            
         
        }
        tudienma connect = new tudienma();
        public void loadmahdx()
        {
            txtMaHD.Text = connect.sTuDongDienMaHoaDonXuat(txtMaHD.Text);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btAddMH_Click(object sender, EventArgs e)
        {
            ThemMatHang frm = new ThemMatHang();
           // frm.iNgonNgu = iNgonNgu;
            frm.kiemtra = 1;
           // frm.sBoPhan = sMaBP;
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Create_new();
        }
        public void Create_new()
        {
            cboMaKH.Text = "";
            cboTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            // txtWeb.Text = "";
            /* cboMaMatHang.Text = "";
             cboThue.Text = "";
             cboSL.Text = "";
             cboDonGia.Text = "";
             cboDVT.Text = "";
             * */
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData(); 
        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_create();
            Create_new();
            loadgridCTHOADON();
        }

        private void linkTheoHoaDon_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_filter();
            string SQL = "SELECT T1.NGAYXUAT 'Ngày xuất',T1.MAHDX 'Mã Hóa Đơn',T2.TENNV 'Tên Nhân Viên',T1.TIENPHAITRA 'Tiền Phải Trả',T1.TIENDATRA 'Tiền Đã Trả',(T1.TIENPHAITRA - T1.TIENDATRA) 'Tiền Nợ',T1.GHICHU 'Ghi Chú' FROM (SELECT * FROM HOADONXUAT ) AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDX DESC";
            loadgridPHIEUNHAP(SQL);
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_filter();
            string SQL = "SELECT T3.NGAYXUAT 'Ngày Xuất',T3.MAHDX 'Mã Hóa Đơn', T3.MAMH 'Mã Hàng', T4.TENMH 'Tên Hàng',T3.SOLUONGXUAT 'Số Lượng',T3.GIATIEN 'Giá Bán' FROM (select T2.NGAYXUAT,T1.MAHDX,T1.MAMH,T1.SOLUONGXUAT,T1.GIATIEN FROM (SELECT * FROM CHITIETHDX ) AS T1 INNER JOIN HOADONXUAT AS T2 ON T1.MAHDX =T2.MAHDX) as T3 INNER JOIN MATHANG AS T4 ON T3.MAMH =T4.MAMH";
            loadgridSANPHAM(SQL);
        }

        public void loadgridPHIEUNHAP(string SQL)
        {
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridView4.Columns.Clear();
            gridControl3.DataSource = TBS;
            gridView4.RefreshData();
            gridControl3.RefreshDataSource();

        }
        public void loadgridSANPHAM(string SQL)
        {
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridView4.Columns.Clear();
            gridControl3.DataSource = TBS;
            gridView4.Columns["Mã Hóa Đơn"].Group();
            gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridView4.ExpandAllGroups();
            gridView4.RefreshData();
            gridControl3.RefreshDataSource();


        }

        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
            if (dtr != null)
                if (dtr["_TenMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "_TenMH")
                    {
                        DataTable dtmh = ctlNCC.GETMATHANG(dtr["_TenMH"].ToString());
                        dtr["_MaMH"] = dtmh.Rows[0]["MAMH"];
                        dtr["_SoLuong"] = "0";
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        //dtr["_TenMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                    }
                    else
                    {
                        int Num;
                        bool isNum = int.TryParse(dtr["_SoLuong"].ToString(), out Num);
                        if (isNum)
                        {
                            int total = int.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_SoLuong"] = "0";
                            dtr["_Total"] = "0";
                        }
                    }
                }
        }

        private void gridCTHOADON_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridCTHOADON.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                    bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

                    if (!isinsert)
                        ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

                    GridView view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                }
            }
        }

        private void gridCTHOADON_RowcountChanged(object sender, EventArgs e)
        {
            gettotal();
        }

        private void gridCTHOADON_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip1.Show(view.GridControl, e.Point);
            }
        }
        public void gettotal()
        {
            int rowcount = gridCTHOADON.RowCount;
            int total = 0;
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                if (dtr != null)
                {
                    int Num;
                    bool isNum = int.TryParse(dtr["_Total"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            txtthanhtien.Text = total.ToString();
            //MessageBox.Show(total.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if (dtr != null)
                {
                    bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

                    if (!isinsert)
                        ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

                    // GridView view = sender as GridView;
                    // view.DeleteRow(view.FocusedRowHandle);
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                }
            }
        }
        public void View_phieunhap(string MAHDX)
        {
            loadgridCTHOADON(MAHDX);

            txtMaHD.Text = MAHDX;
            string SQL = "SELECT T1.NGAYXUAT ,T1.MAHDX ,T2.MANV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO FROM (SELECT * FROM HOADONXUAT WHERE MAHDX='" + MAHDX + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV";
            DataTable DT = ctlNCC.GETDATA(SQL);
            cboNhanVienLap.Text = DT.Rows[0]["MANV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr = dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            string MAKH = ctlNCC.GETMANCCfromMHDN(dtr["Mã Hóa Đơn"].ToString());
            View_phieunhap(dtr["Mã Hóa Đơn"].ToString());
            txtNgayXuat.Text = dtr["NGÀY XUẤT"].ToString();
            loadgridKhachHang(MAKH);//MANCC
            //cboTenNCC_EDITCHANGED();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load_panel_create();
            loadgridCTHOADON();
        }

        private void gridView4_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip2.Show(view.GridControl, e.Point);
            }
        }

     
     

    }
}