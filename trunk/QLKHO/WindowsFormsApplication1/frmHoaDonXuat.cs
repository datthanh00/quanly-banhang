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

            cboMaKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboMaKH.Properties.DataSource = dtvKH;
            cboMaKH.Properties.DisplayMember = "MAKH";
            cboMaKH.Properties.ValueMember = "TENKH";
            cboMaKH.Properties.View.BestFitColumns();
            cboMaKH.Properties.PopupFormWidth = 300;
            cboMaKH.Properties.DataSource = ctlNCC.GETKHACHHANG();
            dtoNCC.MANCC = gridKH.GetFocusedRowCellValue("MAKH").ToString();
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
            loaddridmathang();
            loaddridDVT();
            loadgridthue();
            loadmahdx();
            cboNhanVienLap.Text = sMaNV;
        }

        private void cboMaKH_EditValueChanged(object sender, EventArgs e)
        {
            cboTenKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenKH.Properties.DataSource = dtvKH;
            cboTenKH.Properties.DisplayMember = "TENKH";
            cboTenKH.Properties.ValueMember = "TENKH";
            cboTenKH.Properties.View.BestFitColumns();
            cboTenKH.Properties.PopupFormWidth = 300;
            cboTenKH.Properties.DataSource = ctlNCC.GETKHACHHANG();
            cboTenKH.Text = gridKH.GetFocusedRowCellValue("TENKH").ToString();
            txtSDT.Text = gridKH.GetFocusedRowCellValue("SDT").ToString();
            txtDiachi.Text = gridKH.GetFocusedRowCellValue("DIACHI").ToString();
            txtWeb.Text = gridKH.GetFocusedRowCellValue("WEBSITE").ToString();   
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
        ArrayList list1 = new ArrayList();
        WindowsFormsApplication1.Class_ManhCuong.Cart.HoaDon hd = new Cart.HoaDon();
        private void btXemTruoc_Click(object sender, EventArgs e)
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
            dtoNCC.WEBSITE = txtWeb.Text;
            dtoNCC.NGAYXUAT = DateTime.Now;
            dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
            dtoNCC.MAHDX = txtMaHD.Text;
            dtoNCC.GHICHU= textBoxX1.Text;
             
            dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
            ctlNCC.INSERTHOADONXUAT(dtoNCC);
            foreach (Cart cart in hd._Cart)
            {
                insert_HoadonChitietxuat(txtMaHD.Text, cart._MaMH, cart._SoLuong, cart._DonGia);

            }

            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
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
                ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
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
            cboMaKH.Text = "";
            cboTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            txtWeb.Text = "";
            cboMaMatHang.Text = "";
            cboThue.Text = "";
            cboSL.Text = "";
            cboDonGia.Text = "";
            cboDVT.Text = "";
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData(); 

        }

    }
}