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
        public void loadgridNhacCungCap()
        {

            cboMANCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMANCC.Properties.DataSource = dtvNCC;
            cboMANCC.Properties.DisplayMember = "MANCC";
            cboMANCC.Properties.ValueMember = "TENNCC";
            cboMANCC.Properties.View.BestFitColumns();
            cboMANCC.Properties.PopupFormWidth = 300;
            cboMANCC.Properties.DataSource = ctlNCC.GETDANHSACHNCC();
            dtoNCC.MANCC = gridNCC.GetFocusedRowCellValue("MANCC").ToString();
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
   
        private void cboMANCC_EditValueChanged(object sender, EventArgs e)
        {
            cboTenNCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenNCC.Properties.DataSource = dtvNCC;
            cboTenNCC.Properties.DisplayMember = "TENNCC";
            cboTenNCC.Properties.ValueMember = "TENNCC";
            cboTenNCC.Properties.View.BestFitColumns();
            cboTenNCC.Properties.PopupFormWidth = 300;
            cboTenNCC.Properties.DataSource = ctlNCC.GETDANHSACHNCC();
            cboTenNCC.Text = gridNCC.GetFocusedRowCellValue("TENNCC").ToString();
            txtSoDT.Text = gridNCC.GetFocusedRowCellValue("SDT").ToString();
            txtFax.Text = gridNCC.GetFocusedRowCellValue("FAX").ToString();
            txtEmail.Text = gridNCC.GetFocusedRowCellValue("EMAIL").ToString();
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
                    ctlNCC.INSERTHOADONNHAP(dtoNCC);
                    foreach (Cart cart in hd._Cart)
                    {
                        insert_HoadonChitiet(txtMaHD.Text, cart._MaMH, cart._SoLuong, cart._DonGia);

                    }

                    if (hd._Cart.Count > 0)
                    {
                        hd._Cart.Clear();
                    }
                    loadGiaoDich();
                    MessageBox.Show("Bạn Đã Thêm Thành Công");
                    loadmahdn();
                    // this.Close();
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
                ctlNCC.INSERTCTHOADONNHAP(dtoNCC);
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
      
    }
}