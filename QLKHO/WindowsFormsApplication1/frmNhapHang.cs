using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WindowsFormsApplication1.Class_ManhCuong;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraEditors.DXErrorProvider;
using WindowsFormsApplication1.HoaDonNhap;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsFormsApplication1
{
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        
       
        public frmNhapHang()
        {
            InitializeComponent();
            
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public int iNgonNgu;
        public frmMain frm;
        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }
        
        NhapHangDTO dto = new NhapHangDTO();
        NhapHangDAO mh = new NhapHangDAO();
        WindowsFormsApplication1.Class_ManhCuong.Cart.HoaDon hd = new Cart.HoaDon();
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            
            loadGiaoDich();
            loadgridNhacCungCap();
            loadgridNhanVien();
            loaddridmathang();
            loadgridthue();
            loaddridDVT();
            loadmahdn();
            cboNhanVienLap.Text = sMaNV;
            loadGiaoDich();
            loadgridCTHOADON();
            loadGrid_sanpham();
            Load_panel_create();

        }
        DataView dvdropdow;
        DataTable layno = new DataTable();
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        tudienma connect = new tudienma();
        DataView dtvNCC;
        DataView dtvNhanVien;
        DataView dtvMH;
        DataView dtvThue;
        DataView dtvDVT;
        public void Load_panel_create()
        {
            //panel_create
            //panel_filter
            //panel_info
            panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
           // panel_filter_grid.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            panel_create.Visible = true;
            panel_info1.Visible = true;
            panel_grid.Visible = true;
             
        }
        public void Load_panel_filter()
        {
            panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
           // panel_filter_grid.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            panel_create.Visible = false;
            panel_info1.Visible = false;
            panel_grid.Visible = false;
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
        public void loadgridCTHOADON2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("_MaMH"));
            dt.Columns.Add(new DataColumn("_TenMH"));
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("_DonGia"));
           // dt.Columns.Add(new DataColumn("_Thue"));
           // dt.Columns.Add(new DataColumn("_DVT"));
            //dt.Columns.Add(new DataColumn("_Total"));

            gridControl1.DataSource = dt;
        }
        public void loadGrid_sanpham()
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH();
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "MAMH";
           
        }
        public void loadgridNhacCungCap()
        {

            cboTenNCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenNCC.Properties.DataSource = dtvNCC;
            cboTenNCC.Properties.DisplayMember = "TENNCC";
            cboTenNCC.Properties.ValueMember = "MANCC";
            cboTenNCC.Properties.View.BestFitColumns();
            cboTenNCC.Properties.PopupFormWidth = 300;
            cboTenNCC.Properties.DataSource = ctlNCC.GETDANHSACHNCC();
            //dtoNCC.TENNCC = gridNCC.GetFocusedRowCellValue("TENNCC").ToString();
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
        public void loaddridmathang()
        {
           /* cboMaMatHang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMaMatHang.Properties.DataSource = dtvMH;
            cboMaMatHang.Properties.DisplayMember = "MAMH";
            cboMaMatHang.Properties.ValueMember = "TENMH";
            cboMaMatHang.Properties.View.BestFitColumns();
            cboMaMatHang.Properties.PopupFormWidth = 300;
            cboMaMatHang.Properties.DataSource = ctlNCC.GETMATHANG();
            dtoNCC.MAMH = gridMH.GetFocusedRowCellValue("MAMH").ToString();
            */ 
        }
        public void loadgridthue()
        {
            /*cboThue.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboThue.Properties.DataSource = dtvMH;
            cboThue.Properties.DisplayMember = "SOTHUE";
            cboThue.Properties.ValueMember = "MATH";
            cboThue.Properties.View.BestFitColumns();
            cboThue.Properties.PopupFormWidth = 300;
            cboThue.Properties.DataSource = ctlNCC.GETTHUE();
            dtoNCC.MATH = gridTHUE.GetFocusedRowCellValue("MATH").ToString();
            */
        }
        public void loaddridDVT()
        {
            /*cboDVT.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboDVT.Properties.DataSource = dtvDVT;
            cboDVT.Properties.DisplayMember = "DONVITINH";
            cboDVT.Properties.ValueMember = "MADVT";
            cboDVT.Properties.View.BestFitColumns();
            cboDVT.Properties.PopupFormWidth = 300;
            cboDVT.Properties.DataSource = ctlNCC.GETDVT();
            dtoNCC.MADVT = gridDVT.GetFocusedRowCellValue("MADVT").ToString();
             */ 
        }
        private void cboTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            cboMANCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMANCC.Properties.DataSource = dtvNCC;
            cboMANCC.Properties.DisplayMember = "MANCC";
            cboMANCC.Properties.ValueMember = "MANCC";
            cboMANCC.Properties.View.BestFitColumns();
            cboMANCC.Properties.PopupFormWidth = 300;
            cboMANCC.Properties.DataSource = ctlNCC.GETDANHSACHNCC();
            cboMANCC.Text = gridView3.GetFocusedRowCellValue("MANCC").ToString();
            txtSoDT.Text = gridView3.GetFocusedRowCellValue("SDT").ToString();
            txtFax.Text = gridView3.GetFocusedRowCellValue("FAX").ToString();
            txtEmail.Text = gridView3.GetFocusedRowCellValue("EMAIL").ToString();
            dtoNCC.MANCC = cboMANCC.Text;
            layno = ctlNCC.LAYTIENNO(dtoNCC);
            string tienno = layno.Rows[0]["TIENNO"].ToString();
            if (tienno == "")
            {
                txtNo.Text = "0";
            }
            else
            {
                txtNo.Text = string.Format("{0:N}", double.Parse(tienno));
            }
        }
      
        private void cboMANCC_EditValueChanged(object sender, EventArgs e)
        {
    

        }
        private void cboTenMatHang_EditValueChanged(object sender, EventArgs e)
        {
           /* cboTenMH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenMH.Properties.DataSource = dtvMH;
            cboTenMH.Properties.DisplayMember = "TENMH";
            cboTenMH.Properties.ValueMember = "TENMH";
            cboTenMH.Properties.View.BestFitColumns();
            cboTenMH.Properties.PopupFormWidth = 300;
            cboTenMH.Properties.DataSource = ctlNCC.GETMATHANG();
            cboTenMH.Text = gridMH.GetFocusedRowCellValue("TENMH").ToString();
            cboThue.Text = gridMH.GetFocusedRowCellValue("MATH").ToString();
            cboDVT.Text = gridMH.GetFocusedRowCellValue("MADVT").ToString();
            */
        }
        public string sTenNV, sMaNV;
        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            cboMANCC.Text = "";
            cboTenNCC.Text = "";
            txtSoDT.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtMaHD.Text = "";
           
            txtNo.Text = "";
          
           /* cboMaMatHang.Text = "";
            cboThue.Text = "";
            cboSL.Text = "";
            cboDonGia.Text = "";
            cboDVT.Text = "";
            */ 
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            loadmahdn();
            //   cboTinhTrang.Text = "";
           gridControl1.DataSource = null;
           gridCTHOADON.RefreshData(); 
        }
        public int kiemtra;
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMANCC.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn Mã Nhà Cung Cấp");
                }
                else
                {
                    dtoNCC.MANCC = cboMANCC.Text;
                    dtoNCC.TENNCC = cboTenNCC.Text;
                    dtoNCC.SDT = txtSoDT.Text;
                    dtoNCC.FAX = txtFax.Text;
                    dtoNCC.EMAIL = txtEmail.Text;
                    dtoNCC.GHICHU = textBoxX1.Text;
                    dtoNCC.NGAYNHAP = DateTime.Now;
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDN = txtMaHD.Text;
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                    bool isINSERTHOADONNHAP = ctlNCC.isINSERTHOADONNHAP(dtoNCC.MAHDN);
                    if (isINSERTHOADONNHAP)
                    {
                        ctlNCC.INSERTHOADONNHAP(dtoNCC);
                    }
                    else
                    {
                        ctlNCC.UPDATEHOADONNHAP(dtoNCC);
                    }

                    int rowcount = gridCTHOADON.DataRowCount;
                    for (int i = 0; i < rowcount; i++)
                    {
                        DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                        insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), int.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                    }
                    /*
                    foreach (Cart cart in hd._Cart)
                    {
                        insert_HoadonChitiet(txtMaHD.Text, cart._MaMH, cart._SoLuong, cart._DonGia);
                    }
                    
                    if (hd._Cart.Count > 0)
                    {
                        hd._Cart.Clear();
                    }
                    loadGiaoDich();
                    
                    loadmahdn();
                    // this.Close();
                     * */
                    MessageBox.Show("Bạn Đã Thêm Thành Công");
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

        }
        

        private void loadGiaoDich()
        {
            dtoNCC.NGAYNHAP = DateTime.Now;
            gridControl2.DataSource = ctlNCC.GETHOADONNHAP(dtoNCC);
        }
        public void createHoadon()
        {
          /*  String mamh = cboMaMatHang.Text;
            try
            {
                ctlNCC.GETMH();
                if (int.Parse(cboSL.Text) > 0)
                    hd.insert_item_toCart(cboMaMatHang.Text, cboTenMH.Text, int.Parse(cboSL.Text), int.Parse(cboDonGia.Text), int.Parse(cboThue.Text), cboDVT.Text);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu"); }
            catch (Exception ex) { MessageBox.Show("Vui lòng chọn đầy đủ các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
            }
           */ 
        } 
        ArrayList list1 = new ArrayList();
        private void btXemTruoc_Click(object sender, EventArgs e)
        {
           /* if (cboMaMatHang.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn Mã Mặt Hàng");
            }
            else
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
            */
        }
        public void insert_HoadonChitiet(string mahdn, String mamh, int SoLuong, int DonGia)
        {
            try
            {
                dtoNCC.MAHDN = mahdn;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGNHAP = SoLuong;
                dtoNCC.GIANHAP = DonGia;
              
                
               // ctlNCC.INSERTCTHOADONNHAP(dtoNCC);

                bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(mahdn, mamh);
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
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }

        private void cbotientra_EditValueChanged(object sender, EventArgs e)
        {

        }
        double conlai,thanhtien,tientra;
        private void cbotientra_TextChanged(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }

        private void cboTenMH_EditValueChanged(object sender, EventArgs e)
        {

        }
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
        DataTable dt = new DataTable();
        
        private void btIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    //dt = gridCTHOADON.DataSource;
                    In rep = new In(list1, cboMANCC.Text, cboTenNCC.Text, double.Parse(cbotientra.Text), double.Parse(txtNo.Text), double.Parse(txtthanhtien.Text), txtMaHD.Text);
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap tncc = new frmThemNhaCungCap();
           // tncc.iNgonNgu = iNgonNgu;
            tncc.kiemtra = 1;
            tncc.ShowDialog();
            //LOADNHACC();
        }

        public void loadmahdn()
        {
            txtMaHD.Text = connect.sTuDongDienMaHoaDonNhap(txtMaHD.Text);
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void cboNhanVienLap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btAddMH_Click(object sender, EventArgs e)
        {
            ThemMatHang frm = new ThemMatHang();
           // frm.iNgonNgu = iNgonNgu;
            frm.kiemtra = 1;
           // frm.sBoPhan = sMaBP;
            frm.ShowDialog();
        }

        private void gridCTHOADON_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
          
            
        }

        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show("Cell value Changed");
            
            DataRow dtr = dtr= gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if(dtr!=null)
                if (dtr["_TenMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "_TenMH")
                    {
                        DataTable dtmh = ctlNCC.GETMATHANG(dtr["_TenMH"].ToString());
                        dtr["_MaMH"] =dtmh.Rows[0]["MAMH"];
                        dtr["_SoLuong"] = "0";
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        //dtr["_TenMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                    }else
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
                

            //"_MaMH"));
           // dt.Columns.Add(new DataColumn("_TenMH"));
        }

        private void gridCTHOADON_RowcountChanged(object sender, EventArgs e)
        {
            gettotal();
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



        private void gridCTHOADON_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            int rowcount = gridCTHOADON.DataRowCount;
            if (rowcount > 0)
            {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                    contextMenu1.Show(view.GridControl, e.Point);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

                if (!isinsert)
                    ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, dtr["_MaMH"].ToString());

               // GridView view = sender as GridView;
               // view.DeleteRow(view.FocusedRowHandle);
                gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
            }
        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_create();
            loadgridCTHOADON();
        }

        private void linkTheoHoaDon_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_filter();
            loadgridCTHOADON2();
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Load_panel_filter();
        }

        private void dockPanel3_Click(object sender, EventArgs e)
        {

        }
    }
}