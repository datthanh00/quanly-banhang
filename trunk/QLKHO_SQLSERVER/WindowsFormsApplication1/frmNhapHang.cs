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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

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

        int CountRowTBEdit = 0;
        NhapHangDTO dto = new NhapHangDTO();
        NhapHangDAO mh = new NhapHangDAO();
        //WindowsFormsApplication1.Class_ManhCuong.Cart.HoaDon hd = new Cart.HoaDon();
        public string THEM, XOA, SUA, IN, XEM;
       
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            XEM = PublicVariable.XEM;
            THEM = PublicVariable.THEM;
            XOA = PublicVariable.XOA;
            SUA = PublicVariable.SUA;
            IN = PublicVariable.IN;

            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN MỤC NÀY");
                this.Close();
                return;
            }
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                MessageBox.Show("Bạn đang sử dụng hệ thống ngày tháng của máy tính");

            }
                loadgridNhacCungCap();
                loadgridNhanVien();
                loaddridmathang();
                loadgridthue();
                loaddridDVT();
                loadmahdn();
           
                //loadGiaoDich();
                loadgridCTHOADON();
                //loadGrid_sanpham();
                Load_panel_create();

                dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
                dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

       
            btLuu.Enabled = false;
            loadgridCTHOADON();
            Load_panel_create();
            DataRow dtr;
            if (gridControl3.MainView == gridView4)
            {
                dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            }
            else
            {
                dtr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            }
            string MANCC = ctlNCC.GETMANCCfromMHDN(dtr["MAHDN"].ToString());
            View_phieunhap(dtr["MAHDN"].ToString());
            txtNgay.Text = dtr["NGAYNHAP"].ToString();
            txtlohang.Text = dtr["MAHDN"].ToString();
            loadgridNhacCungCap(MANCC);

            Load_TTNCC();
            loadGrid_sanpham();
        }
        DataView dvdropdow;
       
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        ketnoi connect = new ketnoi();
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
            panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_grid2.Visible = false;
             
        }
        public void Load_panel_filter()
        {
            panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
           // panel_filter_grid.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            panel_create.Visible = false;
            panel_info1.Visible = false;
            panel_grid.Visible = false;
            panel_grid2.Visible = true;
            panel_grid2.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void loadgridCTHOADON()
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("_MaMH"));
            dt.Columns.Add(new DataColumn("_TenMH"));
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("_DonGia"));
            dt.Columns.Add(new DataColumn("_HSD"));
           // dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
           // gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
           // gridColumn8.DisplayFormat.FormatString = "{0:0,0}";
            gridControl1.MainView = gridCTHOADON;
            gridControl1.DataSource = dt;
            
            CountRowTBEdit = 0;

            gridCTHOADON.Columns["_DonGia"].ColumnEdit = this.repositoryItemTextEdit1;
           
            gridCTHOADON.Columns["_Total"].ColumnEdit = this.repositoryItemTextEdit1;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;

            //gridCTHOADON.Columns["_HSD"].ColumnEdit = this.repositoryItemDateEdit1;
            //this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            //this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            //this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
           // this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            /*
            gridCTHOADON.Columns["_HSD"].ColumnEdit = this.repositoryItemDateEdit1;
            this.repositoryItemDateEdit1.Mask.EditMask = "d";
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            */
           
            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["_HSD"].Visible = false;
                gridView5.Columns["HSD"].Visible = false;
                gridView7.Columns["HSD"].Visible = false;
            }
        }
        public void loadgridCTHOADON(String MAHDN)
        {
            DataTable dt = new DataTable();
            dt=ctlNCC.GETCTHOADONNHAP(MAHDN);
            gridControl1.DataSource = dt;
            //gridCTHOADON.Columns["ID"].Visible = true;

            CountRowTBEdit = dt.Rows.Count;


            DevExpress.XtraGrid.StyleFormatCondition condition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            condition1.Appearance.BackColor = Color.LightBlue;
            condition1.Appearance.Options.UseBackColor = true;
            condition1.Condition = FormatConditionEnum.Expression;
            condition1.Expression = "[ID] >0";
            gridCTHOADON.FormatConditions.Add(condition1);

          
        }
        public void loadgridPHIEUNHAP()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T1.NGAYNHAP,103) AS NGAYNHAP ,T1.MAHDN ,T1.TENNCC ,T2.TENNV,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO,T1.GHICHU  FROM ((select t9.*,t8.tenncc from HOADONNHAP  as t9  INNER JOIN nhacungcap as t8 on t9.mancc=t8.mancc where  T9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') ) AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ";
            
            DataTable TBS = ctlNCC.GETDATA(SQL);
            //gridView4.Columns.Clear();
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
            string SQL = "SELECT convert(varchar,T3.NGAYNHAP,103)AS NGAYNHAP ,T3.MAHDN ,T3.TENNCC , T3.MAMH , T4.TENMH ,T3.SOLUONGNHAP,T3.SOLUONGNHAP*KLDVT AS KHOILUONG ,T3.GIANHAP, soluongnhap*gianhap AS THANHTIEN,GHICHU,convert(varchar,HSD,103)AS HSD  FROM (select T2.NGAYNHAP,T1.MAHDN,T1.MAMH,T2.tenncc ,T1.SOLUONGNHAP,T1.GIANHAP,GHICHU,HSD FROM (SELECT * FROM CHITIETHDN )AS T1 INNER JOIN (select t9.ngaynhap,t9.mahdn,t9.mancc,t8.tenncc,GHICHU from HOADONNHAP as t9  INNER JOIN nhacungcap as t8 on t9.mancc=t8.mancc  WHERE T9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDN =T2.MAHDN) as T3 INNER JOIN MATHANG AS T4 ON T3.MAMH =T4.MAMH ";
            
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView5;
            gridControl3.DataSource = TBS;
            //gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            
            gridView5.ExpandAllGroups();
            //gridColumn26.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            //gridView4.RefreshData();
            gridControl3.RefreshDataSource();
            gridView5.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView5.Columns["KHOILUONG"].Visible = false;
               
            }

        }
        public void loadgridtongSANPHAM()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;
            Load_panel_filter();
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC, TENKHO, DONVITINH, SUM(SOLUONGNHAP) as SOLUONGNHAP, GIANHAP, SUM(SOLUONGNHAP*GIANHAP) AS TONGTIEN,SUM(SOLUONGNHAP*KLDVT) AS KHOILUONG FROM MATHANG,NHACUNGCAP,KHO,DONVITINH,(select MAMH,SOLUONGNHAP, GIANHAP FROM CHITIETHDN, HOADONNHAP WHERE CHITIETHDN.MAHDN=HOADONNHAP.MAHDN AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as CHITIETHDN WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=CHITIETHDN.MAMH AND KHO.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC, TENKHO, DONVITINH,GIANHAP";
           

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView7;
            gridControl3.DataSource = TBS;
            gridControl3.RefreshDataSource();

            if (!PublicVariable.isKHOILUONG)
            {
                gridView7.Columns["KHOILUONG"].Visible = false;
            }
        }
        
        public void loadGrid_sanpham()
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH(txtMANCC.Text);
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "MAMH";
            
            Grid_sanpham.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
           
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
        public void loadgridNhacCungCap(String MANCC)
        {
          
            cboTenNCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenNCC.Properties.DataSource = dtvNCC;
            cboTenNCC.Properties.DisplayMember = "TENNCC";
            cboTenNCC.Properties.ValueMember = "MANCC";
            cboTenNCC.Properties.View.BestFitColumns();
            cboTenNCC.Properties.PopupFormWidth = 300;
            DataTable dt=ctlNCC.GETDANHSACHNCC(MANCC);
            cboTenNCC.Properties.DataSource = dt;
           // cboTenNCC.SelectedText = dt.Rows[0]["TENNCC"].ToString();
            cboTenNCC.Text = dt.Rows[0]["MANCC"].ToString();
      
        }
        public void loadgridNhanVien()
        {
           
            dtoNCC.MANV = sMaNV;
            txtnhanvienlap.Text = sTenNV;
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
 

        private void cboTenNCC_Validated(object sender, EventArgs e)
        {
            Load_TTNCC();
            loadgridCTHOADON();
            loadGrid_sanpham();
        }
        public void Load_TTNCC()
        {

            DataRow rowselect = gridView3.GetFocusedDataRow();

            if (rowselect != null)
            {
                txtMANCC.Text = gridView3.GetFocusedRowCellValue("MANCC").ToString();
                txtSoDT.Text = gridView3.GetFocusedRowCellValue("SDT").ToString();
                txtFax.Text = gridView3.GetFocusedRowCellValue("FAX").ToString();
                txtEmail.Text = gridView3.GetFocusedRowCellValue("EMAIL").ToString();
                dtoNCC.MANCC = txtMANCC.Text;
                DataTable tblayno = ctlNCC.LAYTIENNO(dtoNCC);
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
        

        public string sTenNV, sMaNV;
        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            
            Create_new();
            
        }
        public void Create_new(){
            loadgridNhacCungCap();
            txtMANCC.Text = "";
            cboTenNCC.Text = "";
            txtSoDT.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtMaHD.Text = "";
            txtNo.Text = "";
            btLuu.Enabled = true;
          
            loadmahdn();
            //   cboTinhTrang.Text = "";
            //gridControl1.DataSource = null;
            //gridCTHOADON.RefreshData();

            loadgridCTHOADON();
        }

        public int kiemtra;
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Nhập Những Mặt Hàng Này Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                int i = 0;
            }
            else
            {
                return;
            }

            try
            {
                if (txtMANCC.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn Nhà Cung Cấp");
                }
                else
                {
                    dtoNCC.MANCC = txtMANCC.Text;
                    dtoNCC.TENNCC = cboTenNCC.Text;
                    dtoNCC.SDT = txtSoDT.Text;
                    dtoNCC.FAX = txtFax.Text;
                    dtoNCC.EMAIL = txtEmail.Text;
                    dtoNCC.GHICHU = textBoxX1.Text;
                    dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDN = txtMaHD.Text;
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                    
                    int rowcount = gridCTHOADON.DataRowCount;
                    if (rowcount == 0)
                    {
                        XtraMessageBox.Show("Hãy chọn một sản phẩm trước khi lưu");
                        return;
                    }

                    if (PublicVariable.isHSD)
                    {
                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = gridCTHOADON.GetDataRow(i);
                        
                            //insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                            if (dtr["_HSD"].ToString() == "")
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Chưa có Hạn Sử Dụng ");
                                return;
                            }
                            else if (DateTime.Now >= DateTime.Parse(dtr["_HSD"].ToString()))
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
                        for (int j = i+1; j < rowcount; j++)
                        {
                            DataRow dtr2 = gridCTHOADON.GetDataRow(j);
                            if (dtr["_MaMH"].ToString() == dtr2["_MaMH"].ToString())
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Không được nhập nhiều lần ");
                                return;
                            }
                        }
                    }


                    bool isINSERTHOADONNHAP = ctlNCC.isINSERTHOADONNHAP(dtoNCC.MAHDN);
                    if (isINSERTHOADONNHAP)
                    {
                        if (THEM == "False")
                        {
                            MessageBox.Show("KHÔNG CÓ QUYỀN THÊM");
                            return;
                        }
                        dtoNCC.IsUPDATE = false;
                        ctlNCC.INSERTHOADONNHAP(dtoNCC);
                        //insert hoa don chi tiet
                        
                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = gridCTHOADON.GetDataRow(i);
                            insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), dtr["_HSD"].ToString());
                        }
                    }
                    else
                    {

                        if (SUA == "False")
                        {
                            MessageBox.Show("KHÔNG CÓ QUYỀN SỬA");
                            return;
                        }
                        if (PublicVariable.TATCA == "False")
                        {
                            MessageBox.Show("TRÙNG MÃ HÓA ĐƠN");
                            return;
                        }

                        dtoNCC.IsUPDATE = true;
                        ctlNCC.UPDATEHOADONNHAP(dtoNCC);
                        //update hoa don chi tiet
                        
                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                           
                            String sID = dtr["ID"].ToString();

                            if (sID != "")
                            {
                                update_HoadonChitiet(txtMaHD.Text, Convert.ToInt32(sID), dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), dtr["_HSD"].ToString());
                            }
                            else
                            {
                                insert_HoadonChitiet(txtMaHD.Text, dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), dtr["_HSD"].ToString());
                            }
                        }

                       
                    }
                    MessageBox.Show("Bạn Đã Thêm Thành Công");
                    Create_new();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

        }

        private void Update_Delete_Gridview()
        {
            dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            gridControl2.DataSource = ctlNCC.GETHOADONNHAP(dtoNCC);
        }

        private void loadGiaoDich()
        {
            dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            gridControl2.DataSource = ctlNCC.GETHOADONNHAP(dtoNCC);
        }
        public void createHoadon()
        {

        } 
        ArrayList list1 = new ArrayList();
        private void btXemTruoc_Click(object sender, EventArgs e)
        {
          
        }
        public void insert_HoadonChitiet(string mahdn, String mamh, Double SoLuong, int DonGia,string HSD)
        {
            try
            {
                dtoNCC.MAHDN = mahdn;
                dtoNCC.MAMH = mamh;
                if (HSD.Length > 5)
                {
                    dtoNCC.HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                }
                else
                {
                    dtoNCC.HSD = "";
                }
                if (PublicVariable.isHSD)
                {
                    dtoNCC.LOHANG = txtlohang.Text;
                }
                else
                {
                    dtoNCC.LOHANG = "1";
                }

                dtoNCC.SOLUONGNHAP = SoLuong;
                dtoNCC.GIANHAP = DonGia;
                string SQL = "SELECT MAX(ID) FROM CHITIETHDN WHERE MAHDN='" + mahdn + "'";
                DataTable dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1;
                if (dt.Rows[0][0].ToString() != "")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                }
                ctlNCC.INSERTCTHOADONNHAP(dtoNCC);

               // ctlNCC.INSERT_KHOHANG(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitiet(string mahdn, int ID, String mamh, Double SoLuong, int DonGia, string HSD)
        {
            try
            {
                dtoNCC.MAHDN = mahdn;
                
                if (PublicVariable.isHSD)
                {
                    dtoNCC.LOHANG = txtlohang.Text;
                }
                else
                {
                    dtoNCC.LOHANG = "1";
                }
                if (HSD.Length > 5)
                {
                    dtoNCC.HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                }
                else
                {
                    dtoNCC.HSD = "";
                }
                
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGNHAP = SoLuong;
                dtoNCC.GIANHAP = DonGia;
                dtoNCC.ID = ID;
                ctlNCC.UPDATECTHOADONNHAP(dtoNCC);
          
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
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    //dt = gridCTHOADON.DataSource;
                    //gridControl1.da
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETINCTHOADONNHAP(txtMaHD.Text);

                    In rep = new In(dt, txtMANCC.Text, cboTenNCC.Text, double.Parse(cbotientra.Text), double.Parse(txtNo.Text), double.Parse(txtthanhtien.Text), txtMaHD.Text,"");
                    rep.ShowPreviewDialog();

                    //gridControl1.ShowPrintPreview();
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
            loadgridNhacCungCap();
           
        }

        public void loadmahdn()
        {
            txtMaHD.Text = connect.sTuDongDienMaHoaDonNhap(txtMaHD.Text);
            txtlohang.Text = txtMaHD.Text;
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyy");
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


        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show("Cell value Changed");
            
            DataRow dtr= gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);

                if(dtr!=null)
                if (dtr["_TenMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "_TenMH")
                    {
                        //

                        DataTable dtmh = ctlNCC.GETMATHANG_FULL(dtr["_TenMH"].ToString());
                        string mamh = dtmh.Rows[0]["MAMH"].ToString();
                        dtr["_MaMH"] = mamh;
                       
                        dtr["_SoLuong"] = "0";
                        try
                        {
                            dtr["_HSD"] = "";
                        }
                        catch { }
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        //dtr["_TenMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                    }
                    else if (e.Column.FieldName.ToString() == "_SoLuong")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_SoLuong"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_SoLuong"] = "0";
                            dtr["_Total"] = "0";
                        }
                    }
                    else if (e.Column.FieldName.ToString() == "_DonGia")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_DonGia"].ToString(), out Num);
                        if (!isNum)
                        {
                            dtr["_DonGia"] = "0";
                        }
                       
                    }
                    else if (e.Column.FieldName.ToString() == "_HSD")
                    {
                        string NGAY= dtr["_HSD"].ToString();
                        if (NGAY.Length > 10)
                            dtr["_HSD"] = NGAY.Substring(0, 10);
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
            Double total = 0;
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                if (dtr != null)
                {
                    Double Num;
                    bool isNum = Double.TryParse(dtr["_Total"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            txtthanhtien.Text = total.ToString();
            if (cbotientra.Text != "")
            {
                thanhtien = double.Parse(txtthanhtien.Text);
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
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
                    DataRow  dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                   // bool isinsert = ctlNCC.ISINSERTCTHOADONNHAP(txtMaHD.Text, focusrow+1);
                   // if (!isinsert)
                       // ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, focusrow+1);
                    GridView view = sender as GridView;
                    
                    view.DeleteRow(view.FocusedRowHandle);
                }
            }
        }



        private void gridCTHOADON_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
          //  int rowcount = gridCTHOADON.DataRowCount;
          //  if (rowcount > 0)
          //  {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;
                   
                    contextMenuStrip1.Show(view.GridControl, e.Point);
                }
            //}
        }
        private void gridView4_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
           // int rowcount = gridCTHOADON.DataRowCount;
           // if (rowcount > 0)
          //  {
                GridView view = sender as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
                if (hitInfo.InRow)
                {
                    view.FocusedRowHandle = hitInfo.RowHandle;

                    contextMenuStrip2.Show(view.GridControl, e.Point);
                }
          //  }
        }


        private void DeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XÓA ");
                return;
            }
        

            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridCTHOADON.FocusedRowHandle;
                DataRow  dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if (dtr != null)
                {
                    String sID = dtr["ID"].ToString();
                    if (sID != "")
                    {
                       

                        string SQLNGAY="SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                         DataTable dtn = ctlNCC.GETDATA(SQLNGAY);
                         if (txtNgay.Text != dtn.Rows[0][0].ToString())
                         {
                             MessageBox.Show("Không phải hóa đơn hôm nay nên không thể xóa, chỉ có thể xóa hóa đơn trong ngày  ");
                             return;
                         }

                        if (PublicVariable.isHSD)
                        {
                            String SQL = "Select * from chitiethdx where mamh='" + dtr["_MaMH"].ToString() + "' AND LOHANG='" + txtMaHD.Text + "'";
                            DataTable dt = ctlNCC.GETDATA(SQL);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Mặt hàng trong Lô Hàng này đã Xuất nên không thể xóa  ");
                                return;
                            }
                            PublicVariable.TMPtring = "";
                            frmxoahd xhd = new frmxoahd();
                            xhd.MAHD = txtMaHD.Text;
                            xhd.MAMH = dtr["_MaMH"].ToString();
                            xhd.TENMH = dtr["_TenMH"].ToString();

                            xhd.ShowDialog();
                            if (PublicVariable.TMPtring=="")
                            {
                                return;
                            }
                            

                            ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, Convert.ToInt32(sID), dtr["_MaMH"].ToString());

                            ctlNCC.DELETE_KHOHANG(dtr["_MaMH"].ToString(), txtlohang.Text);
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
                                    

                                    ctlNCC.DELETECTHOADONNHAP(txtMaHD.Text, Convert.ToInt32(sID), dtr["_MaMH"].ToString());
                                    ctlNCC.UPDATE_KHOHANG_NX(dtr["_MaMH"].ToString(), "1", (-soluonghientai).ToString(), "0", "0", "0");
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
                        dtoNCC.MANCC = txtMANCC.Text;
                        dtoNCC.GHICHU = textBoxX1.Text;
                        dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDN = txtMaHD.Text;
                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                        return;
                    }

                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);

                    gettotal();
                    dtoNCC.MANCC = txtMANCC.Text;
                    dtoNCC.GHICHU = textBoxX1.Text;
                    dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDN = txtMaHD.Text;
                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                    ctlNCC.UPDATEHOADONNHAP(dtoNCC);
                }
            }
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
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            //loadGiaoDich();
            loadgridPHIEUNHAP();
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            loadgridSANPHAM();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            loadgridtongSANPHAM();
        }


        private void gridView4_doubleclick(object sender, EventArgs e)
        {
           // Load_panel_create();
           // loadgridCTHOADON();
        }
        public void View_phieunhap(string MAHDN)
        {
            loadgridCTHOADON(MAHDN);
  
            txtMaHD.Text = MAHDN;
            txtlohang.Text =MAHDN;
            string SQL = String.Format("SELECT convert(varchar,T1.NGAYNHAP,103) ,T1.MAHDN ,T2.MANV,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO FROM (SELECT * FROM HOADONNHAP WHERE MAHDN='{0}' AND MAKHO='{1}' ) AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV", MAHDN, PublicVariable.MAKHO);
            DataTable DT = ctlNCC.GETDATA(SQL);
            txtnhanvienlap.Text = DT.Rows[0]["TENNV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
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
                dtr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            }
            string MANCC = ctlNCC.GETMANCCfromMHDN(dtr["MAHDN"].ToString());
            View_phieunhap(dtr["MAHDN"].ToString());
            txtNgay.Text = dtr["NGAYNHAP"].ToString();
            loadgridNhacCungCap(MANCC);
            Load_TTNCC();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            loadgrid();
        }



        private void gridCTHOADON_ShowingEditor_1(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            int RowCount = view.RowCount;

            if (view.FocusedColumn.FieldName == "_TenMH"&&CountRowTBEdit>0)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

           // gridControl3.ShowPrintPreview();
            printableComponentLink1.CreateDocument();

            printableComponentLink1.ShowPreview();
           

        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "0")
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

        private void linkIntheomathang_Click(object sender, EventArgs e)
        {
            

        }
        private void loadgrid()
        {
            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2)) * 365;
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2)) * 365;
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

            if (gridControl3.MainView == gridView4)
            {
                loadgridPHIEUNHAP();
            }
            else if (gridControl3.MainView == gridView4)
            {
                loadgridSANPHAM();
            }
            else if (gridControl3.MainView == gridView7)
            {
                loadgridtongSANPHAM();
            }
        }

        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                loadgrid();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                loadgrid();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btXuatDuLieu_Click_1(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
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
            string reportHeader = "Báo Cáo Nhập Hàng Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

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


   

    }
}