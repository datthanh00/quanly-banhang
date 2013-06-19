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
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1
{
    public partial class frmTraNCC : DevExpress.XtraEditors.XtraForm
    {
        
       
        public frmTraNCC()
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
        Boolean isdelete = false;
        NhapHangDTO dto = new NhapHangDTO();
        NhapHangDAO mh = new NhapHangDAO();
        string IDNHAP = "0";
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
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                this.Close();
                return;
            }
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                MessageBox.Show("Bạn đang sử dụng hệ thống ngày tháng của máy tính");

            }
                loadGiaoDich();
            loadgridNhacCungCap();
            loadgridNhanVien();
                loaddridmathang();
                loadgridthue();
                loaddridDVT();
            loadmahdn();
            
                //loadGiaoDich();
            loadgridCTHOADON();
           
            Load_panel_create();
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");
            cktien.Text = "0";
            ckphantram.Text = "0";
            txtthanhtien.Text = "0";
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
            dt.Columns.Add(new DataColumn("MAMH"));
            dt.Columns.Add(new DataColumn("TENMH"));
            dt.Columns.Add(new DataColumn("SOLUONG"));
            dt.Columns.Add(new DataColumn("KMAI"));
            dt.Columns.Add(new DataColumn("_LOHANG"));
            dt.Columns.Add(new DataColumn("DONGIA"));
           // dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("GIANHAP"));
            dt.Columns.Add(new DataColumn("HSD"));
            dt.Columns.Add(new DataColumn("TIENTRA"));
            gridControl1.MainView = gridCTHOADON;
            gridControl1.DataSource = dt;
            CountRowTBEdit = 0;

            gridCTHOADON.Columns["DONGIA"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["TIENTRA"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["_Total"].ColumnEdit = this.repositoryItemTextEdit1;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;

            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["_LOHANG"].Visible = false;
               
            }
        }
        public void loadgridCTHOADON(String MAHDN)
        {
            DataTable dt = new DataTable();
            dt=ctlNCC.GETtraCTHOADONNHAP(MAHDN);
            gridControl1.DataSource = dt;

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
            string SQL = "SELECT convert(varchar,T1.NGAYNHAP,103) AS NGAYNHAP ,T1.MAHDN ,T1.TENNCC ,T2.TENNV,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO,T1.GHICHU  FROM ((select t9.*,t8.tenncc from TRAHOADONNHAP  as t9  INNER JOIN nhacungcap as t8 on t9.mancc=t8.mancc where  TYPE=1 AND t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') ) AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDN DESC";
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewPHIEUTRA;
            gridControl3.DataSource = TBS;
            gridViewPHIEUTRA.RefreshData();
            gridControl3.RefreshDataSource();
            gridViewPHIEUTRA.BestFitColumns();
            
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
            string SQL = "SELECT convert(varchar,T3.NGAYNHAP,103)AS NGAYNHAP ,T3.MAHDN ,T3.TENNCC , T3.MAMH , T4.TENMH ,T3.SOLUONGNHAP,T3.SOLUONGNHAP*KLDVT AS KHOILUONG ,T3.GIANHAP, soluongnhap * gianhap AS THANHTIEN,GHICHU,KMAI  FROM (select T2.NGAYNHAP,T1.MAHDN,T1.MAMH,T2.tenncc ,T1.SOLUONGNHAP,T1.GIANHAP,ghichu,KMAI FROM (SELECT * FROM TRACHITIETHDN )AS T1 INNER JOIN (select t9.ngaynhap,t9.mahdn,t9.mancc,t8.tenncc,ghichu from TRAHOADONNHAP  as t9  INNER JOIN nhacungcap as t8 on t9.mancc=t8.mancc where  TYPE=1 AND t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDN =T2.MAHDN) as T3 INNER JOIN MATHANG AS T4 ON T3.MAMH =T4.MAMH order by T3.MAHDN desc";
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewSANPHAM;
            gridControl3.DataSource = TBS;
            //gridView4.Columns[""].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridViewSANPHAM.ExpandAllGroups();
            gridViewSANPHAM.RefreshData();
            gridControl3.RefreshDataSource();
            gridViewSANPHAM.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                gridViewSANPHAM.Columns["KHOILUONG"].Visible = false;
            }
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
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC,KLDVT, TENKHO, DONVITINH, sum(KMAI) as KMAI, sum(SOLUONGNHAP*KLDVT) as KHOILUONG, sum(SOLUONGNHAP) as SOLUONGNHAP, GIANHAP, SUM(SOLUONGNHAP*GIANHAP) AS TONGTIEN FROM MATHANG,NHACUNGCAP,KHO,DONVITINH,(select MAMH,SOLUONGNHAP, GIANHAP,KMAI FROM TRACHITIETHDN, TRAHOADONNHAP WHERE TYPE=1 AND TRACHITIETHDN.MAHDN=TRAHOADONNHAP.MAHDN AND NGAYNHAP BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as TRACHITIETHDN WHERE MATHANG.MANCC=NHACUNGCAP.MANCC AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=TRACHITIETHDN.MAMH AND KHO.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC,KLDVT, TENKHO, DONVITINH,GIANHAP";
           

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewTONGSANPHAM;
            gridControl3.DataSource = TBS;
            //gridView4.Columns[""].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            //gridView4.ExpandAllGroups();
            gridViewTONGSANPHAM.RefreshData();
            gridControl3.RefreshDataSource();
            if (!PublicVariable.isKHOILUONG)
            {
                gridViewTONGSANPHAM.Columns["KHOILUONG"].Visible = false;
            }
        }
        
        public void loadGrid_sanpham(string MAHDN)
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH2(txtMANCC.Text);
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "LOHANG";
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
            if (dt.Rows.Count > 0)
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
            loadGrid_sanpham(txtMaHD.Text);
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
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            loadgridNhacCungCap();
            txtMANCC.Text = "";
            cboTenNCC.Text = "";
            txtSoDT.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtMaHD.Text = "";
            txtNo.Text = "";
            btLuu.Enabled=true;
            cboTenNCC.Enabled = true;
            txtghichu.Text = "";
            cktien.Text = "0";
            ckphantram.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "0";
            txtconLai.Text = "0";
         
            loadmahdn();
            //   cboTinhTrang.Text = "";
            //gridControl1.DataSource = null;
            //gridCTHOADON.RefreshData();
            loadgridNhacCungCap();
            Grid_sanpham.DataSource = null;
            loadgridCTHOADON();
        }

        public int kiemtra;
     
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Lưu Vào Hóa Đơn trả nhà cung cấp không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtMANCC.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng chọn Nhà Cung Cấp");
                    }
                    else
                    {
                        PublicVariable.SQL_TRANHAP = "";
                        dtoNCC.MANCC = txtMANCC.Text;
                        dtoNCC.TENNCC = cboTenNCC.Text;
                        dtoNCC.SDT = txtSoDT.Text;
                        dtoNCC.FAX = txtFax.Text;
                        dtoNCC.EMAIL = txtEmail.Text;
                        dtoNCC.GHICHU = txtghichu.Text;
                        dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDN = txtMaHD.Text;
                        dtoNCC.CKTIEN = cktien.Value.ToString();
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                        dtoNCC.TYPE = "1";

                        int rowcount = gridCTHOADON.DataRowCount;
                        if (rowcount == 0)
                        {
                            XtraMessageBox.Show("Hãy chọn một sản phẩm trả trước khi lưu");
                            return;
                        }

                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = gridCTHOADON.GetDataRow(i);
                            Double soluongtra = 0;
                            Double soluongnhap = 0;
                            

                            for (int k = i; k < rowcount; k++)
                            {
                                DataRow dtr2 = gridCTHOADON.GetDataRow(k);
                                if (dtr["MAMH"].ToString() == dtr2["MAMH"].ToString())
                                {
                                    soluongtra = soluongtra + Convert.ToDouble(dtr2["SOLUONG"].ToString()) + Convert.ToDouble(dtr2["KMAI"].ToString());
                                }
                            }
                           // string lohang = gridCTHOADON.GetFocusedRowCellValue("LOHANG").ToString();
                            String SQL = "Select TONKHO from KHOHANG where MAMH='" + dtr["MAMH"].ToString() + "' AND LOHANG='" + dtr["_LOHANG"].ToString() + "'";
                            DataTable dt = ctlNCC.GETDATA(SQL);

                            if (dt.Rows.Count > 0)
                            {
                                soluongnhap =Convert.ToDouble(dt.Rows[0][0].ToString());
                            }
                            if (soluongtra > soluongnhap)
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " có Số lượng trả không thể nhiều hơn số lượng tồn");
                                return;
                            }

                            if (Convert.ToDouble(dtr["SOLUONG"].ToString())<=0)
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " có Số lượng trả không được <=0");
                                return;
                            }
                        }
                        dtoNCC.NGAYNHAP = "convert(varchar,getDate(),101)";
                        if (PublicVariable.isUSE_COMPUTERDATE)
                        {
                            dtoNCC.NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
                        }

                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                        bool isINSERTHOADONNHAP = ctlNCC.isINSERTtraHOADONNHAP(dtoNCC.MAHDN);
                        if (isINSERTHOADONNHAP)
                        {
                            if (THEM == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                                return;
                            }

                            dtoNCC.IsUPDATE = false;
                            dtoNCC.IDNHAP = ctlNCC.getIDNHAP();
                            ctlNCC.INSERTtraHOADONNHAP(dtoNCC);
                            //insert hoa don chi tiet

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = gridCTHOADON.GetDataRow(i);
                                insert_HoadonChitiet(txtMaHD.Text, dtr["_LOHANG"].ToString(), dtr["MAMH"].ToString(), Double.Parse(dtr["SOLUONG"].ToString()), int.Parse(dtr["DONGIA"].ToString()), dtr["GIANHAP"].ToString(), dtr["TIENTRA"].ToString(), dtr["HSD"].ToString(), dtr["KMAI"].ToString(), i);
                            }
                            ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRANHAP);
                            PublicVariable.SQL_TRANHAP = "";
                            MessageBox.Show("Bạn Đã Thêm Thành Công");
                        }
                        else
                        {
                            if (PublicVariable.SUA == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN SỬA");
                                return;
                            }

                            dtoNCC.IsUPDATE = true;
                            dtoNCC.IDNHAP = IDNHAP;
                            ctlNCC.UPDATEtraHOADONNHAP(dtoNCC);
                            //update hoa don chi tiet



                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                String sID = dtr["ID"].ToString();

                                if (sID != "")
                                {
                                    update_HoadonChitiet(txtMaHD.Text, Convert.ToInt32(sID), dtr["MAMH"].ToString(), Double.Parse(dtr["SOLUONG"].ToString()), int.Parse(dtr["DONGIA"].ToString()), dtr["GIANHAP"].ToString(), dtr["TIENTRA"].ToString(), dtr["HSD"].ToString(), dtr["KMAI"].ToString());
                                }
                                else
                                {
                                    insert_HoadonChitiet(txtMaHD.Text, dtr["_LOHANG"].ToString(), dtr["MAMH"].ToString(), Double.Parse(dtr["SOLUONG"].ToString()), int.Parse(dtr["DONGIA"].ToString()), dtr["GIANHAP"].ToString(), dtr["TIENTRA"].ToString(), dtr["HSD"].ToString(), dtr["KMAI"].ToString(), i);
                                }
                            }
                            DataTable TABLE_SAU = (DataTable)gridControl1.DataSource;

                            for (int i = 0; i < TABLE_SAU.Rows.Count; i++)
                            {
                                DataTable dtname = ctlNCC.GETDATA("select TENMH from MATHANG where MAMH='" + TABLE_SAU.Rows[0]["MAMH"].ToString() + "'");
                                TABLE_SAU.Rows[i]["TENMH"] = dtname.Rows[0][0].ToString();
                            }


                            DataTable TABLE_TRUOC = ctlNCC.GETDATA("SELECT MATHANG.MAMH,TENMH,SOLUONGNHAP AS SOLUONG,KMAI FROM MATHANG, TRACHITIETHDN WHERE MATHANG.MAMH=TRACHITIETHDN.MAMH AND MAHDN='" + txtMaHD.Text + "'");

                            PublicVariable.TMPtring = "";
                            frmsuahd SUAhd = new frmsuahd();
                            SUAhd.MAHD = txtMaHD.Text;
                            SUAhd.LISTTRUOC = TABLE_TRUOC;
                            SUAhd.LISTSAU = TABLE_SAU;

                            SUAhd.ShowDialog();
                            if (PublicVariable.TMPtring == "")
                            {
                                return;
                            }
                            ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRANHAP);
                            PublicVariable.SQL_TRANHAP = "";
                            MessageBox.Show("Bạn Đã Sửa Thành Công");
                        }
                        
                        Create_new();
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message);
                }
            }

        }

        private void Update_Delete_Gridview()
        {
            dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            gridControl2.DataSource = ctlNCC.GETtraHOADONNHAP(dtoNCC);
        }

        private void loadGiaoDich()
        {
            dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            gridControl2.DataSource = ctlNCC.GETtraHOADONNHAP(dtoNCC);
        }
        public void createHoadon()
        {

        } 
        ArrayList list1 = new ArrayList();
        private void btXemTruoc_Click(object sender, EventArgs e)
        {
          
        }
        public void insert_HoadonChitiet(string mahdn, string lohang, String mamh, Double SoLuong, int DonGia, string GIANHAP, string TIENTRA, string HSD, String KMAI, int STT)
        {
            try
            {
                dtoNCC.MAHDN = mahdn;
                dtoNCC.LOHANG = lohang;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGNHAP = SoLuong;
                dtoNCC.KMAI = KMAI;
                dtoNCC.GIATRANHAP = DonGia;
                dtoNCC.TIENTRA = TIENTRA;
                dtoNCC.GIANHAP = Convert.ToInt32(GIANHAP); 
                HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                dtoNCC.HSD = HSD;
                

                string SQL = "SELECT MAX(ID) FROM traCHITIETHDN WHERE MAHDN='" + mahdn + "'";
                dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1+STT;
                if (dt.Rows[0][0].ToString() != "")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1+STT;
                }

                ctlNCC.INSERTtraCTHOADONNHAP(dtoNCC);

            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitiet(string mahdn, int ID, String mamh, Double SoLuong, int DonGia, string GIANHAP, string TIENTRA, string HSD, String KMAI)
        {
            try
            {
                dtoNCC.MAHDN = mahdn;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGNHAP = SoLuong;
                dtoNCC.GIATRANHAP = DonGia;
                dtoNCC.TIENTRA = TIENTRA;
                dtoNCC.GIANHAP = Convert.ToInt32(GIANHAP);
                HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                dtoNCC.HSD = HSD;
                dtoNCC.ID = ID;
                dtoNCC.KMAI = KMAI;


                ctlNCC.UPDATEtraCTHOADONNHAP(dtoNCC);
          
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }

        private void cbotientra_EditValueChanged(object sender, EventArgs e)
        {

        }
        double conlai,thanhtien,tientra;


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
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    string ten = "Trả hàng cho nhà cung cấp";
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETtraCTHOADONNHAP(txtMaHD.Text);

                    In rep = new In(dt, "", "", double.Parse(cbotientra.Text), 0, double.Parse(txtthanhtien.Text), txtMaHD.Text,ten);
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

        public void loadmahdn()
        {
            txtMaHD.Text = connect.sTuDongDienMatraHoaDonNhap(txtMaHD.Text);
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
            
            DataRow dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if(dtr!=null)
                if (dtr["TENMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "TENMH")
                    {
                        //

                        string SMAMH = dtr["TENMH"].ToString();
                        int index = SMAMH.IndexOf("_");
                        string MAMH = SMAMH.Substring(0, index);
                        string LOHANG = SMAMH.Substring(index + 1, SMAMH.Length - index - 1);
                        DataTable dtmh = ctlNCC.GETMATHANG_TRANCC(MAMH, LOHANG);
                        string mamh = dtmh.Rows[0]["MAMH"].ToString();
                        dtr["MAMH"] = mamh;
                        dtr["_LOHANG"] = dtmh.Rows[0]["LOHANG"].ToString();
                        dtr["SOLUONG"] = "0";
                        dtr["KMAI"] = "0";
                        dtr["DONGIA"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        dtr["GIANHAP"] = dtmh.Rows[0]["GIANHAP"];
                        dtr["HSD"] = dtmh.Rows[0]["HSD"];
                        //dtr["TENMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                        dtr["TIENTRA"] = "0";
                    }
                    else if (e.Column.FieldName.ToString() == "SOLUONG")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["SOLUONG"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["DONGIA"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTRA"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["SOLUONG"] = "0";
                            dtr["KMAI"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTRA"] = "0";
                        }
                    }
                    else if (e.Column.FieldName.ToString() == "DONGIA")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["DONGIA"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["DONGIA"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTRA"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["SOLUONG"] = "0";
                            dtr["KMAI"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTRA"] = "0";
                        }

                    }
                    else if (e.Column.FieldName.ToString() == "_HSD")
                    {
                        string NGAY = dtr["_HSD"].ToString();
                        if (NGAY.Length > 10)
                            dtr["_HSD"] = NGAY.Substring(0, 10);
                    }
                    else if (e.Column.FieldName.ToString() == "TIENTRA")
                    {

                        gettotal();
                    }
                   
                }
                

            //"MAMH"));
           // dt.Columns.Add(new DataColumn("TENMH"));
        }

        private void gridCTHOADON_RowcountChanged(object sender, EventArgs e)
        {
            gettotal();
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
                    bool isNum = Double.TryParse(dtr["TIENTRA"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            tienchuack = Convert.ToInt32(total);
            total = total - Convert.ToInt32(cktien.Value);
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
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
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
                if (hitInfo.InRow && isdelete)
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
            
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PublicVariable.SQL_TRANHAP = "";
                int focusrow = gridCTHOADON.FocusedRowHandle;
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if (dtr != null)
                {
                    String sID = dtr["ID"].ToString();
                    if (sID != "")
                    {
                        if (XOA == "False")
                        {
                            MessageBox.Show("KHÔNG CÓ QUYỀN ");
                            return;
                        }
                        string SQLNGAY = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime , TENMH FROM MATHANG WHERE MAMH='" + dtr["MAMH"].ToString() + "' ";
                        DataTable dtn = ctlNCC.GETDATA(SQLNGAY);
                        if (txtNgay.Text != dtn.Rows[0][0].ToString())
                        {
                            MessageBox.Show("Không phải hóa đơn hôm nay nên không thể xóa, chỉ có thể xóa hóa đơn trong ngày  ");
                            return;
                        }
                        PublicVariable.TMPtring = "";
                        frmxoahd xhd = new frmxoahd();
                        xhd.MAHD = txtMaHD.Text;
                        xhd.MAMH = dtr["MAMH"].ToString();
                        xhd.TENMH = dtn.Rows[0]["TENMH"].ToString();
                        xhd.SOLUONG = dtr["SOLUONG"].ToString();
                        xhd.ShowDialog();
                        if (PublicVariable.TMPtring == "")
                        {
                            return;
                        }


                        ctlNCC.DELETEtraCTHOADONNHAP(txtMaHD.Text, Convert.ToInt32(sID), dtr["MAMH"].ToString(), dtr["_LOHANG"].ToString(), dtr["SOLUONG"].ToString(), dtr["KMAI"].ToString());
                        //ctlNCC.UPDATE_KHOHANG_NX(dtr["MAMH"].ToString(), dtr["_LOHANG"].ToString(), "0", "-" + dtr["SOLUONG"].ToString(), "0", "0");
                        PublicVariable.TMPtring = "";
                        
                    }
                    else
                    {
                        gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);

                        gettotal();

                        dtoNCC.MANCC = txtMANCC.Text;
                        dtoNCC.TENNCC = cboTenNCC.Text;
                        dtoNCC.SDT = txtSoDT.Text;
                        dtoNCC.FAX = txtFax.Text;
                        dtoNCC.EMAIL = txtEmail.Text;
                        dtoNCC.GHICHU = txtghichu.Text;
                        dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDN = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                        return;
                    }
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);

                    gettotal();

                    dtoNCC.MANCC = txtMANCC.Text;
                    dtoNCC.TENNCC = cboTenNCC.Text;
                    dtoNCC.SDT = txtSoDT.Text;
                    dtoNCC.FAX = txtFax.Text;
                    dtoNCC.EMAIL = txtEmail.Text;
                    dtoNCC.GHICHU = txtghichu.Text;
                    dtoNCC.NGAYNHAP = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDN = txtMaHD.Text;
                    dtoNCC.CKTIEN = cktien.Value.ToString();
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                    dtoNCC.TYPE = "1";
                    ctlNCC.UPDATEtraHOADONNHAP(dtoNCC);
                    if (sID != "")
                    {
                        ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRANHAP);
                    }
                    PublicVariable.SQL_TRANHAP = "";
                    MessageBox.Show("Bạn Đã Xóa Thành Công");
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
            
            loadgridPHIEUNHAP();
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            loadgridSANPHAM();
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
            string SQL = String.Format("SELECT convert(varchar,T1.NGAYNHAP,103) as NGAYNHAP ,T1.MAHDN ,T2.MANV,T2.TENNV ,T1.TIENPHAITRA,T1.GHICHU ,T1.CKTIEN,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO,IDNHAP FROM (SELECT * FROM TRAHOADONNHAP WHERE MAHDN='{0}' AND MAKHO='{1}' ) AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV", MAHDN, PublicVariable.MAKHO);
            DataTable DT = ctlNCC.GETDATA(SQL);
            txtnhanvienlap.Text = DT.Rows[0]["TENNV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
            txtghichu.Text = DT.Rows[0]["GHICHU"].ToString();
            IDNHAP = DT.Rows[0]["IDNHAP"].ToString();

            int _cktien = Convert.ToInt32(DT.Rows[0]["CKTIEN"].ToString());
            cktien.Value = _cktien;
            double thanhtien = tienchuack;
            if (_cktien > 0)
            {
                ckphantram.Value = Convert.ToDecimal(_cktien / thanhtien * 100);
            }
            else
            {
                ckphantram.Value = 0;
                cktien.Value = 0;

            }

            gettotal();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XEM");
                return;
            }
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            btLuu.Enabled = false;
            isdelete = false;
            cboTenNCC.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
      
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string MANCC = ctlNCC.GETMANCCfromtraMHDN(dtr["MAHDN"].ToString());
            View_phieunhap(dtr["MAHDN"].ToString());
            txtNgay.Text = dtr["NGAYNHAP"].ToString();
            loadgridNhacCungCap(MANCC);
            Load_TTNCC();
            loadGrid_sanpham(txtMaHD.Text);
            
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN SỬA");
                return;
            }
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            btLuu.Enabled=true;
            isdelete = false;
            cboTenNCC.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
   
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string MANCC = ctlNCC.GETMANCCfromtraMHDN(dtr["MAHDN"].ToString());
            View_phieunhap(dtr["MAHDN"].ToString());
            txtNgay.Text = dtr["NGAYNHAP"].ToString();
            loadgridNhacCungCap(MANCC);
            Load_TTNCC();
            loadGrid_sanpham(txtMaHD.Text);
           
          //  loadGrid_sanpham();
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

        private void gridCTHOADON_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            int RowCount = view.RowCount;

            if (view.FocusedColumn.FieldName == "TENMH" && CountRowTBEdit > 0)
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

        private void tongsanpham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridTONGSANPHAM();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl3.DataSource;
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                Inhd rep = new Inhd(printtable, 9);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridViewSANPHAM)
            {
                Inhd rep = new Inhd(printtable, 10);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridViewTONGSANPHAM)
            {
                Inhd rep = new Inhd(printtable, 11);
                rep.ShowPreviewDialog();
            }
           /*
            // gridControl3.ShowPrintPreview();
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



        private void loadgrid()
        {
            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }

            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                loadgridPHIEUNHAP();
            }
            else if (gridControl3.MainView == gridViewSANPHAM)
            {
                loadgridSANPHAM();
            }
            else if (gridControl3.MainView == gridViewTONGSANPHAM)
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
                    XtraMessageBox.Show("Vui lòng điền mã hóa đơn nhập");
                   // txtMaHD.Focus();
                    return;
                }
               
            String SQL = "Select mahdn From hoadonnhap where mahdn='" + txtMaHD.Text + "' and makho='"+PublicVariable.MAKHO+"'";
            DataTable dt = ctlNCC.GETDATA(SQL);
            if (dt.Rows.Count <= 0)
            {
                txtMaHD.Text = "";
                XtraMessageBox.Show("Không có mã hóa đơn này");
                //txtMaHD.Focus();
                return;
            }

            loadGrid_sanpham(txtMaHD.Text);
       
            
            loadgridCTHOADON();
        }

        private void txtMaHD_Validated(object sender, EventArgs e)
        {
            kiemtramahd();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            deDongTab();
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

        private void printableComponentLink1_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Hàng trả Công Ty Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }
        private void cbotientra_Validated(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
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
            if (_cktien > 0)
            {
                ckphantram.Value = Convert.ToDecimal(_cktien / thanhtien * 100);
            }
            else
            {
                ckphantram.Value = 0;
                cktien.Value = 0;

            }
            thanhtien = thanhtien - _cktien;
            txtthanhtien.Text = thanhtien.ToString();
            if (cbotientra.Text != "")
            {
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void cbotientra_Validated_1(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XÓA");
                return;
            }
            gridCTHOADON.OptionsBehavior.ReadOnly = true;
            btLuu.Enabled = false;
            isdelete = true;
            cboTenNCC.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
 
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string MANCC = ctlNCC.GETMANCCfromtraMHDN(dtr["MAHDN"].ToString());
            View_phieunhap(dtr["MAHDN"].ToString());
            txtNgay.Text = dtr["NGAYNHAP"].ToString();
            loadgridNhacCungCap(MANCC);
            Load_TTNCC();
            loadGrid_sanpham(txtMaHD.Text);
            
        }


  
    }
}