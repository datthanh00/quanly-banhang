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
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1.KHtra
{
    public partial class frmKHtra : DevExpress.XtraEditors.XtraForm
    {
        public frmKHtra()
        {
            InitializeComponent();
        }
        int CountRowTBEdit = 0;
        string mahdtam = "";
    
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
            DataTable dt = ctlNCC.GETKHACHHANG();
            cboTenKH.Properties.DataSource = dt;
           // dtoNCC.MANCC = gridKH1.GetFocusedRowCellValue("TENKH").ToString();
            
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
            if (dt.Rows.Count > 0)
            cboTenKH.Text = dt.Rows[0]["MAKH"].ToString();

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
            dt.Columns.Add(new DataColumn("_HSD"));
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("KMAI"));
            dt.Columns.Add(new DataColumn("_DonGia"));
            //dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("TIENTHU"));
            gridControl1.DataSource = dt;
            CountRowTBEdit = 0;

            gridCTHOADON.Columns["_DonGia"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["_Total"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["TIENTHU"].ColumnEdit = this.repositoryItemTextEdit1;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["_HSD"].Visible = false;
 
            }
        }
        public void loadgridCTHOADON(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETtraCTHOADONXUAT(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;


            DevExpress.XtraGrid.StyleFormatCondition condition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            condition1.Appearance.BackColor = Color.LightBlue;
            condition1.Appearance.Options.UseBackColor = true;
            condition1.Condition = FormatConditionEnum.Expression;
            condition1.Expression = "[ID] >0";
            gridCTHOADON.FormatConditions.Add(condition1);

        }
        public void loadgridCTHOADONTAM(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETCTHOADONXUATTAM(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;

        }
        public void loadGrid_sanpham()
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH2();
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "MAMH";
            Grid_sanpham.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public int iNgonNgu;
        public frmMain frm;
        public string sTenNV, sMaNV;
        public string THEM, XOA, SUA, IN, XEM;
        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            XEM = PublicVariable.XEM;
            THEM = PublicVariable.THEM;
            XOA = PublicVariable.XOA;
            SUA = PublicVariable.SUA;
            IN = PublicVariable.IN;

            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                MessageBox.Show("Bạn đang sử dụng hệ thống ngày tháng của máy tính");

            }
           // cbotientra.Text = "0";
            loadgridKhachHang();
            loadgridNhanVien();
           // loaddridmathang();
           // loaddridDVT();
           // loadgridthue();
            loadmahdx();
            loadgridCTHOADON();
            loadGrid_sanpham();
            
            Load_panel_create();
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");
            cktien.Text = "0";
            ckphantram.Text = "0";
            txtthanhtien.Text = "0";
            gridControl2.DataSource = ctlNCC.GETCTHOADONXUATTAM();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView1.Columns["KHOILUONG"].Visible = false;
                gridView3.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void cboTenKH_Validated(object sender, EventArgs e)
        {
            LOAD_TTKH();
            loadgridCTHOADON();
           // loadGrid_sanpham();   
        }
        public void LOAD_TTKH()
        {
            DataRow rowselect = gridKH1.GetFocusedDataRow();

            if (rowselect != null)
            {
                txtmakh.Text = gridKH1.GetFocusedRowCellValue("MAKH").ToString();
                txtSDT.Text = gridKH1.GetFocusedRowCellValue("SDT").ToString();
                txtDiachi.Text = gridKH1.GetFocusedRowCellValue("DIACHI").ToString();
                dtoNCC.MAKH = txtmakh.Text;  
                DataTable tblayno = ctlNCC.LAYTIENNOKH(dtoNCC);
                if (tblayno.Rows.Count > 0)
                {
                    txtNo.Text = tblayno.Rows[0]["TIENNO"].ToString();
                }
                else
                {
                    txtNo.Text = "0";
                }
            }
        }
       
        public void loadgridNhanVien()
        {
            dtoNCC.MANV = sMaNV;
            txtnhanvienlap.Text = sTenNV;
        }

        ArrayList list1 = new ArrayList();


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
        DataTable tbsanpham;
        private void btLuu_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có muốn Lưu Vào Hóa Đơn Khách Hàng Trả Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtmakh.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng chọn Mã Khách Hàng");
                    }
                    else
                    {
                        PublicVariable.SQL_TRAXUAT = "";
                        dtoNCC.MAKH = txtmakh.Text;
                        dtoNCC.TENKH = cboTenKH.Text;
                        dtoNCC.DIACHI = txtDiachi.Text;
                        dtoNCC.SDT = txtSDT.Text;
                        dtoNCC.CKTIEN = cktien.Value.ToString();
                        // dtoNCC.WEBSITE = txtWeb.Text;
                        dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDX = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.GHICHU = textBoxX1.Text;

                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                        int rowcount = gridCTHOADON.DataRowCount;


                        if (rowcount == 0)
                        {
                            XtraMessageBox.Show("Hãy chọn một sản phẩm trước khi lưu");
                            return;
                        }
                        String SQL="";
                        DataTable dt;
                        
         
                        if (PublicVariable.isHSD)
                        {
                            string SQL1 = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                            DataTable dttime = ctlNCC.GETDATA(SQL1);
                            String timenow = dttime.Rows[0][0].ToString();

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = gridCTHOADON.GetDataRow(i);
                                //insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                                if (dtr["_HSD"].ToString() == "")
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Chưa có Hạn Sử Dụng ");
                                    return;
                                }
                                else if (DateTime.Parse(timenow) >= DateTime.Parse(dtr["_HSD"].ToString()))
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Hạn Sử Dụng Quá Ngắn ");
                                    return;
                                }
                                DateTime time = DateTime.Parse(dtr["_HSD"].ToString());
                            }
                        }

                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = gridCTHOADON.GetDataRow(i);
                            //insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                            if (dtr["_SoLuong"].ToString() == "")
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Số lượng quá ít ");
                                return;
                            }
                            else
                            {
                                Double soluong = Convert.ToDouble(dtr["_SoLuong"].ToString());
                                if (soluong <= 0)
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Số lượng quá ít ");
                                    return;
                                }
                            }
                            for (int j = i + 1; j < rowcount; j++)
                            {
                                DataRow dtr2 = gridCTHOADON.GetDataRow(j);
                                if (dtr["_MaMH"].ToString() == dtr2["_MaMH"].ToString())
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Không được nhập nhiều lần ");
                                    return;
                                }
                            }
                        }

                        bool isINSERTHOADONXUAT = ctlNCC.isINSERTtraHOADONXUAT(dtoNCC.MAHDX);
                        if (isINSERTHOADONXUAT)
                        {
                            if (THEM == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                                return;
                            }

                         
                            dtoNCC.IsUPDATE = false;
                            ctlNCC.INSERTtraHOADONXUAT(dtoNCC);
                            //insert hoa don chi tiet

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                string HSD="";
                                if (PublicVariable.isHSD)
                                {
                                    HSD = dtr["_HSD"].ToString();
                                    if (HSD.Length > 5)
                                    {
                                        HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                                    }
                                    else
                                    {
                                        dtoNCC.HSD = "";
                                    }
                                    
                                    SQL = "select * from khohang where  mamh='" + dtr["_MaMH"].ToString() + "' and HSD ='" + HSD + "'";
                                    dt = ctlNCC.GETDATA(SQL);
                                    if (dt.Rows.Count > 0)
                                    {
                                        dtoNCC.LOHANG = dt.Rows[0]["LOHANG"].ToString();
                                    }
                                    else
                                    {
                                        if (XtraMessageBox.Show("" + dtr["_MaMH"].ToString() + ": chưa có Lô hàng với Hạn Dùng này bạn có muốn thêm lô hàng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            dtoNCC.LOHANG = txtMaHD.Text;
                                            ctlNCC.INSERT_KHOHANG(dtr["_MaMH"].ToString(), txtMaHD.Text,dtr["_DonGia"].ToString(), "0", HSD);
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    SQL = "select * from khohang where  mamh='" + dtr["_MaMH"].ToString() + "'";
                                    dt = ctlNCC.GETDATA(SQL);
                                    if (dt.Rows.Count > 0)
                                    {
                                        dtoNCC.LOHANG = dt.Rows[0]["LOHANG"].ToString();
                                    }
                                    else
                                    {
                                        if (XtraMessageBox.Show(dtr["_MaMH"].ToString()+": chưa có mặt hàng này bạn có muốn thêm mặt hàng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            ctlNCC.INSERT_KHOHANG(dtr["_MaMH"].ToString(), "1", dtr["_DonGia"].ToString(), "0", dtr["_HSD"].ToString());
                                            dtoNCC.LOHANG = "1";
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                }
                                insert_HoadonChitietxuat(txtMaHD.Text, dtoNCC.LOHANG, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString());
                            }
                        }
                        else
                        {

                            MessageBox.Show("KHÔNG CÓ QUYỀN ");
                            return;
                            if (PublicVariable.TATCA == "False")
                            {
                                MessageBox.Show("TRÙNG MÃ HÓA ĐƠN");
                                return;
                            }
                            dtoNCC.IsUPDATE = true;
                            ctlNCC.UPDATEtraHOADONXUAT(dtoNCC);

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                String sID = dtr["ID"].ToString();

                                if (sID != "")
                                {
                                    update_HoadonChitietxuat(txtMaHD.Text, Convert.ToInt32(sID), dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString());
                                }
                                else
                                {
                                    insert_HoadonChitietxuat(txtMaHD.Text, dtoNCC.LOHANG, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString());
                                }
                            }


                        }






                        loadGiaoDich();
                        MessageBox.Show("Bạn Đã Thêm Thành Công");
                        Create_new();
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
      
        private void loadGiaoDich()
        {
            dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            
        }
        double conlai, thanhtien, tientra;

        public void insert_HoadonChitietxuat(string mahdx, string lohang, String mamh, Double SoLuong, int DonGia, int tienthu, string HSD, String _KMAI)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.LOHANG = lohang;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.GIABAN = DonGia.ToString();
                dtoNCC.TIENTHU = tienthu;
                dtoNCC.HSD = HSD;
                string SQL = "SELECT MAX(ID) FROM traCHITIETHDX WHERE MAHDX='" + mahdx + "'";
                DataTable dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1;
                if (dt.Rows[0][0].ToString() != "")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                }
               
                ctlNCC.INSERTtraCTHOADONXUAT(dtoNCC);
      
                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitietxuat(string mahdx, int ID, String mamh, Double SoLuong, int DonGia, int tienthu, string HSD, String _KMAI)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.GIABAN = DonGia.ToString();
                dtoNCC.HSD = HSD;
                dtoNCC.ID = ID;
                dtoNCC.TIENTHU = tienthu;
                
                ctlNCC.UPDATEtraCTHOADONXUAT(dtoNCC);

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
            loadgridKhachHang();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    string ten = "Khách trả hàng";
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETtraCTHOADONXUAT(txtMaHD.Text);
                    Inxuat rep = new Inxuat(dt, "", "",cbotientra.Text, "", txtthanhtien.Text, txtMaHD.Text,ten);
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
        ketnoi connect = new ketnoi();
        public void loadmahdx()
        {
            txtMaHD.Text = connect.sTuDongDienMatraHoaDonXuat(txtMaHD.Text);
            txtNgayXuat.Text = DateTime.Now.ToString("dd/MM/yyy");
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
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Create_new();
            
        }
        public void Create_new()
        {
            txtmakh.Text = "";
            cboTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";           
            txtMaHD.Text = "";
            txtNgayXuat.Text = DateTime.Now.ToString("yyy/MM/dd");
            txtNo.Text = "0";
            txtconLai.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "";
            mahdtam = "";
            btLuu.Enabled = true;

            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData();

            loadgridCTHOADON();
        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Load_panel_create();
            Create_new();
            loadgridCTHOADON();
        }

        private void linkTheoHoaDon_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridPHIEUXUAT();
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridSANPHAM();
        }
        private void tongsanpham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridTONGSANPHAM();
        }
        public void loadgridPHIEUXUAT()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;
            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) AS NGAYXUAT,T1.MAHDX ,T1.TENKH ,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA)AS TONGTIEN ,T1.GHICHU  FROM (select t9.*,t8.tenkh from TRAHOADONXUAT   as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDX DESC";
            
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView4;
            gridControl3.DataSource = TBS;
            gridView4.RefreshData();
            gridControl3.RefreshDataSource();
            gridView4.BestFitColumns();

        }
        public void loadgridSANPHAM()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T3.NGAYXUAT,103) AS NGAYXUAT,T3.TENKH ,T3.MAHDX , T3.MAMH , T4.TENMH ,T3.SOLUONGXUAT,T3.SOLUONGXUAT*kldvt as KHOILUONG ,T3.GIATIEN,soluongxuat*giatien AS THANHTIEN,TIENTHU,TENNCC, GHICHU,LOHANG   FROM (select T2.NGAYXUAT,T1.MAHDX,T1.MAMH,T1.SOLUONGXUAT,T1.GIATIEN,GHICHU,TIENTHU,LOHANG,t2.tenkh FROM (SELECT * FROM TRACHITIETHDX ) AS T1 INNER JOIN (select t9.ngayxuat,t9.mahdx,t9.makh,t8.tenkh,GHICHU from TRAHOADONXUAT  as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDX =T2.MAHDX) as T3 INNER JOIN (SELECT TENMH,MAMH,TENNCC,KLDVT FROM MATHANG,NHACUNGCAP WHERE NHACUNGCAP.MANCC=MATHANG.MANCC) AS T4 ON T3.MAMH =T4.MAMH";
      
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView1;
            gridControl3.DataSource = TBS;
            //gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridView1.ExpandAllGroups();
            gridView1.RefreshData();
            gridControl3.RefreshDataSource();
            gridView1.BestFitColumns();
            
        }

        public void loadgridTONGSANPHAM()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();

            //String SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC,KLDVT, DONVITINH, sum(TRAXUAT) as SOLUONGXUAT,TONKHO.GIAXUAT AS GIATIEN,SUM(TIENTHU) AS TIENTHU, SUM(TRAXUAT*TONKHO.GIAXUAT) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,TONKHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND TRAXUAT>0 AND TONKHO.NGAY BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "' group by MATHANG.MAMH, TENMH, TENNCC,KLDVT, DONVITINH,TONKHO.GIAXUAT";
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC, KLDVT, DONVITINH,LOHANG,sum(SOLUONGXUAT*KLDVT) AS KHOILUONG, sum(SOLUONGXUAT) as SOLUONGXUAT, GIATIEN,SUM(TIENTHU) AS TIENTHU, SUM(SOLUONGXUAT*GIATIEN) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,(select MAMH,SOLUONGXUAT, GIATIEN,TIENTHU,LOHANG FROM TRACHITIETHDX,TRAHOADONXUAT WHERE TRACHITIETHDX.MAHDX=TRAHOADONXUAT.MAHDX AND  NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as TRACHITIETHDX WHERE MATHANG.MANCC=NHACUNGCAP.MANCC  AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=TRACHITIETHDX.MAMH AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC, DONVITINH,GIATIEN,KLDVT,LOHANG ";

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView3;
            gridControl3.DataSource = TBS;
            
            gridView3.RefreshData();
            gridControl3.RefreshDataSource();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView3.Columns["KHOILUONG"].Visible = false;
            }
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
                        dtr["KMAI"] = "0";
                        try
                        {
                            dtr["_HSD"] = "";
                        }
                        catch { }
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        dtr["_Total"] = "0";
                        dtr["TIENTHU"] = "0";
                    }
                    else if (e.Column.FieldName.ToString() == "_SoLuong")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_SoLuong"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_SoLuong"] = "0";
                            dtr["KMAI"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTHU"] = "0";
                        }
                    }
                    else if (e.Column.FieldName.ToString() == "_HSD")
                    {
                        string NGAY = dtr["_HSD"].ToString();
                        if (NGAY.Length > 10)
                            dtr["_HSD"] = NGAY.Substring(0, 10);
                    }
                    else if (e.Column.FieldName.ToString() == "_DonGia")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_DonGia"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_DonGia"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTHU"] = "0";
                        }

                    }
                    else if (e.Column.FieldName.ToString() == "TIENTHU")
                    {

                        gettotal();
                    }
                }
        }

        private void gridCTHOADON_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridCTHOADON.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                DataRow dtr1 = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if (dtr1["ID"].ToString() != "")
                {
                    return;
                }
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int focusrow=gridCTHOADON.FocusedRowHandle;
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(focusrow);

                    //bool isinsert = ctlNCC.ISINSERTCTHOADONXUAT(txtMaHD.Text, focusrow+1);

                    //if (!isinsert)
                    //    ctlNCC.DELETECTHOADONXUAT(txtMaHD.Text, focusrow+1);

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
        private int tienchuack = 0;
        public void gettotal()
        {
            int rowcount = gridCTHOADON.RowCount;
            Double total = 0;
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                if (dtr != null)
                {
                    Double Num;
                    bool isNum = Double.TryParse(dtr["TIENTHU"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            tienchuack = Convert.ToInt32(total);
            total = total - Convert.ToInt32(cktien.Text);
            txtthanhtien.Text = total.ToString();
            if (cbotientra.Text != "")
            {
                thanhtien = double.Parse(txtthanhtien.Text);
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridCTHOADON.FocusedRowHandle;
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(focusrow);
                if (dtr != null)
                {
                    String sID = "";

                    try
                    {
                        sID = dtr["ID"].ToString();
                    }
                    catch { }

                    if (sID != "")
                    {
                        if (XOA == "False")
                        {
                            MessageBox.Show("KHÔNG CÓ QUYỀN ");
                            return;
                        }
                        string SQLNGAY = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                        DataTable dtn = ctlNCC.GETDATA(SQLNGAY);
                        if (txtNgayXuat.Text != dtn.Rows[0][0].ToString())
                        {
                            MessageBox.Show("Không phải hóa đơn hôm nay nên không thể xóa, chỉ có thể xóa hóa đơn trong ngày  ");
                            return;
                        }
                        string HSD = dtr["_HSD"].ToString();
                        HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                        if (PublicVariable.isHSD)
                        {
                            String SQL = "select * from khohang where  mamh='" + dtr["_MaMH"].ToString() + "' and HSD ='" + HSD + "'";
                            DataTable dt = ctlNCC.GETDATA(SQL);
                            if (dt.Rows.Count > 0)
                            {
                                dtoNCC.LOHANG = dt.Rows[0]["LOHANG"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Mặt hàng  " + dtr["_MaMH"].ToString() + " không có lô hàng nên không thể xóa  ");
                                return;
                            }

                            PublicVariable.TMPtring = "";
                            frmxoahd xhd = new frmxoahd();
                            xhd.MAHD = txtMaHD.Text;
                            xhd.MAMH = dtr["_MaMH"].ToString();
                            xhd.TENMH = dtr["_TenMH"].ToString();

                            xhd.ShowDialog();
                            if (PublicVariable.TMPtring == "")
                            {
                                return;
                            }
                           

                            ctlNCC.DELETEtraCTHOADONXUAT(txtMaHD.Text, Convert.ToInt32(sID));

                            ctlNCC.UPDATE_KHOHANG_NX(dtr["_MaMH"].ToString(), dtoNCC.LOHANG,  "0", "0", "0","-"+dtr["_SoLuong"].ToString());
                            PublicVariable.TMPtring = "";
                        }
                        else
                        {
                            String SQL = "Select tonkho from khohang where mamh='" + dtr["_MaMH"].ToString() + "' and lohang='1' ";
                            DataTable dt = ctlNCC.GETDATA(SQL);

                            if (dt.Rows.Count > 0)
                            {
                                double soluongmh = Convert.ToDouble(dt.Rows[0][0].ToString());
                                double soluonghientai = Convert.ToDouble(dtr["_SoLuong"].ToString());

                                if (soluonghientai > soluongmh)
                                {
                                    MessageBox.Show("mặt hàng " + dtr["_MaMH"].ToString() + " này đã xuất nên không thể xóa");
                                    return;
                                }
                                else
                                {
                                    PublicVariable.TMPtring = "";
                                    frmxoahd xhd = new frmxoahd();
                                    xhd.MAHD = txtMaHD.Text;
                                    xhd.MAMH = dtr["_MaMH"].ToString();
                                    xhd.TENMH = dtr["_TenMH"].ToString();

                                    xhd.ShowDialog();
                                    if (PublicVariable.TMPtring == "")
                                    {
                                        return;
                                    }
                                    

                                    ctlNCC.DELETEtraCTHOADONXUAT(txtMaHD.Text, Convert.ToInt32(sID));
                                    ctlNCC.UPDATE_KHOHANG_NX(dtr["_MaMH"].ToString(), "1", "0", "0", "0", (-soluonghientai).ToString());
                                    PublicVariable.TMPtring = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("không có mặt hàng " + dtr["_MaMH"].ToString() + " trong kho nên không thể xóa ");
                                return;
                            }
                        }
                        
                    }
                    else
                    {
                        gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                        gettotal();

                        dtoNCC.MAKH = txtmakh.Text;
                        dtoNCC.TENKH = cboTenKH.Text;
                        dtoNCC.DIACHI = txtDiachi.Text;
                        dtoNCC.SDT = txtSDT.Text;

                        // dtoNCC.WEBSITE = txtWeb.Text;
                        dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDX = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.GHICHU = textBoxX1.Text;

                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                        return;
                    }
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                    gettotal();

                    dtoNCC.MAKH = txtmakh.Text;
                    dtoNCC.TENKH = cboTenKH.Text;
                    dtoNCC.DIACHI = txtDiachi.Text;
                    dtoNCC.SDT = txtSDT.Text;

                    // dtoNCC.WEBSITE = txtWeb.Text;
                    dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDX = txtMaHD.Text;
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.GHICHU = textBoxX1.Text;

                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                    ctlNCC.UPDATEtraHOADONXUAT(dtoNCC);

                }
            }
        }
        public void View_phieuxuat(string MAHDX)
        {
            loadgridCTHOADON(MAHDX);

            txtMaHD.Text = MAHDX;
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) ,T1.MAHDX ,T2.MANV,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO FROM (SELECT * FROM traHOADONXUAT WHERE MAHDX='" + MAHDX + "' AND  MAKHO='" + PublicVariable.MAKHO + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV";
            DataTable DT = ctlNCC.GETDATA(SQL);
            txtnhanvienlap.Text = DT.Rows[0]["TENNV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
            if (gridControl3.MainView == gridView4)
            {
                dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            }
            else
            {
                dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            }
            string MAKH = ctlNCC.GETMAKHfromtraMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
            loadGrid_sanpham();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            btLuu.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
            if (gridControl3.MainView == gridView4)
            {
                dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            }
            else
            {
                dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            }
            string MAKH = ctlNCC.GETMAKHfromMHDX(dtr["Mã Hóa Đơn"].ToString());
            View_phieuxuat(dtr["Mã Hóa Đơn"].ToString());
            txtNgayXuat.Text = dtr["NGÀY XUẤT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
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

        private void pnThangNam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridCTHOADON_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            int RowCount = view.RowCount;

            if (view.FocusedColumn.FieldName == "_TenMH" && CountRowTBEdit > 0)
            {
                int rowfocus = view.FocusedRowHandle;
                if (rowfocus >= 0)
                {
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(rowfocus);

                    String sID = dtr["ID"].ToString();
                    if (sID != "")
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            loadgrid();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl3.DataSource;
            if (gridControl3.MainView == gridView4)
            {
                Inhd rep = new Inhd(printtable, 6);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridView1)
            {
                Inhd rep = new Inhd(printtable, 7);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridView3)
            {
                Inhd rep = new Inhd(printtable, 8);
                rep.ShowPreviewDialog();
            }
           // gridControl3.ShowPrintPreview();
            /*
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
             * */
        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (IN == "False")
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
                gridControl3.ExportToXls(saveFileDialog1.FileName);
            }
			
        }

        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadgrid();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadgrid();
            }
        }


        private void loadgrid()
        {
            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }

            if (gridControl3.MainView == gridView4)
            {
                loadgridPHIEUXUAT();
            }
            else if (gridControl3.MainView == gridView1)
            {
                loadgridSANPHAM();
            }
            else if (gridControl3.MainView == gridView3)
            {
                loadgridTONGSANPHAM();
            }
        }

 

        private void txtMaHD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                kiemtramahd();
            }
        }
        public void kiemtramahd()
        {
            if (txtMaHD.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền mã hóa đơn xuất");
                //txtMaHD.Focus();
                return;
            }

            String SQL = "Select mahdx From hoadonxuat where mahdx='" + txtMaHD.Text + "' and makho='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlNCC.GETDATA(SQL);
            if (dt.Rows.Count <= 0)
            {
                txtMaHD.Text = "";
                XtraMessageBox.Show("Không có mã hóa đơn này");
                //txtMaHD.Focus();
                return;
            }

            loadGrid_sanpham();
            loadgridCTHOADON();
            
        }

        private void txtMaHD_Validated(object sender, EventArgs e)
        {
            kiemtramahd();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (IN == "False")
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

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Khách Hàng Trả Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void ckphantram_Validated(object sender, EventArgs e)
        {
            Double thanhtien = tienchuack;
            int _cktien = Convert.ToInt32(thanhtien * Convert.ToDouble(ckphantram.Value) / 100);
            thanhtien = thanhtien - _cktien;
            txtthanhtien.Text = thanhtien.ToString();
            cktien.Value = _cktien;
            if (cbotientra.Text != "")
            {
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void cktien_Validated(object sender, EventArgs e)
        {
            Double thanhtien = tienchuack;
            int _cktien = Convert.ToInt32(cktien.Value);
            ckphantram.Value = Convert.ToDecimal(_cktien / thanhtien * 100);
            thanhtien = thanhtien - _cktien;
            txtthanhtien.Text = thanhtien.ToString();
            if (cbotientra.Text != "")
            {
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }

        }

        private void cbotientra_Validated(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }





    }
}