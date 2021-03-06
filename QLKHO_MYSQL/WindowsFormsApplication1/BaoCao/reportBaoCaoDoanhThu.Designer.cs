namespace WindowsFormsApplication1
{
    partial class reportBaoCaoDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbNgayThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKeToanTruong = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbGiamDoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNguoiLap = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lbBaoCaoDoanhThu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbFax = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiaChi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDienThoai = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xuaT_NHAPTONTTCT1 = new WindowsFormsApplication1.XUAT_NHAPTONTTCT();
            this.tHONGTINCTTableAdapter = new WindowsFormsApplication1.XUAT_NHAPTONTTCTTableAdapters.THONGTINCTTableAdapter();
            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhucVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongDanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1,
            this.lbNgayThang,
            this.lbKeToanTruong,
            this.lbKi2,
            this.lbKi1,
            this.lbGiamDoc,
            this.lbKi,
            this.lbNguoiLap});
            this.Detail.HeightF = 252F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.LocationFloat = new DevExpress.Utils.PointFloat(565.6667F, 128.125F);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayThang.SizeF = new System.Drawing.SizeF(143.75F, 22.99998F);
            this.lbNgayThang.StylePriority.UseFont = false;
            this.lbNgayThang.Text = "Ngày... Tháng...Năm...";
            // 
            // lbKeToanTruong
            // 
            this.lbKeToanTruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeToanTruong.LocationFloat = new DevExpress.Utils.PointFloat(302.1249F, 167.4583F);
            this.lbKeToanTruong.Name = "lbKeToanTruong";
            this.lbKeToanTruong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKeToanTruong.SizeF = new System.Drawing.SizeF(120.8334F, 23.00002F);
            this.lbKeToanTruong.StylePriority.UseFont = false;
            this.lbKeToanTruong.Text = "Kế toán trưởng";
            // 
            // lbKi2
            // 
            this.lbKi2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi2.LocationFloat = new DevExpress.Utils.PointFloat(595.8749F, 190.4583F);
            this.lbKi2.Name = "lbKi2";
            this.lbKi2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi2.SizeF = new System.Drawing.SizeF(121.8751F, 23F);
            this.lbKi2.StylePriority.UseFont = false;
            this.lbKi2.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbKi1
            // 
            this.lbKi1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi1.LocationFloat = new DevExpress.Utils.PointFloat(302.1249F, 190.4583F);
            this.lbKi1.Name = "lbKi1";
            this.lbKi1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi1.SizeF = new System.Drawing.SizeF(120.8334F, 23F);
            this.lbKi1.StylePriority.UseFont = false;
            this.lbKi1.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbGiamDoc
            // 
            this.lbGiamDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamDoc.LocationFloat = new DevExpress.Utils.PointFloat(620.8749F, 167.4583F);
            this.lbGiamDoc.Name = "lbGiamDoc";
            this.lbGiamDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbGiamDoc.SizeF = new System.Drawing.SizeF(77.08342F, 23.00002F);
            this.lbGiamDoc.StylePriority.UseFont = false;
            this.lbGiamDoc.Text = "Giám đốc";
            // 
            // lbKi
            // 
            this.lbKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi.LocationFloat = new DevExpress.Utils.PointFloat(32.33331F, 190.4583F);
            this.lbKi.Name = "lbKi";
            this.lbKi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi.SizeF = new System.Drawing.SizeF(120.8333F, 23F);
            this.lbKi.StylePriority.UseFont = false;
            this.lbKi.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(43.79173F, 167.4583F);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNguoiLap.SizeF = new System.Drawing.SizeF(109.3749F, 23.00002F);
            this.lbNguoiLap.StylePriority.UseFont = false;
            this.lbNguoiLap.Text = "Người lập";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbBaoCaoDoanhThu,
            this.xrPictureBox1,
            this.xrLabel2,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel5,
            this.lbFax,
            this.lbDiaChi,
            this.lbDienThoai});
            this.TopMargin.HeightF = 203F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbBaoCaoDoanhThu
            // 
            this.lbBaoCaoDoanhThu.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
            this.lbBaoCaoDoanhThu.LocationFloat = new DevExpress.Utils.PointFloat(168.75F, 112.9166F);
            this.lbBaoCaoDoanhThu.Name = "lbBaoCaoDoanhThu";
            this.lbBaoCaoDoanhThu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbBaoCaoDoanhThu.SizeF = new System.Drawing.SizeF(430.2083F, 56.5834F);
            this.lbBaoCaoDoanhThu.StylePriority.UseFont = false;
            this.lbBaoCaoDoanhThu.StylePriority.UseTextAlignment = false;
            this.lbBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            this.lbBaoCaoDoanhThu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "THONGTINCT.LOGO")});
            this.xrPictureBox1.ImageUrl = "C:\\Users\\BamBi\\Desktop\\Doancuoi\\DoanCuoi\\Resources\\doanhthu.png";
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(17.7083F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(151.0417F, 136.1667F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AutoWidth = true;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.FAX")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(437.5F, 75F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel4
            // 
            this.xrLabel4.AutoWidth = true;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.TENCT")});
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(264.5833F, 12.5F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(284.375F, 48.625F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.SDT")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(262.5F, 75F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(99.99998F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.DIACHI")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(262.5F, 50F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(99.99998F, 23F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // lbFax
            // 
            this.lbFax.LocationFloat = new DevExpress.Utils.PointFloat(403.125F, 75F);
            this.lbFax.Name = "lbFax";
            this.lbFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbFax.SizeF = new System.Drawing.SizeF(34.37497F, 23F);
            this.lbFax.Text = "Fax:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.LocationFloat = new DevExpress.Utils.PointFloat(185.4167F, 50F);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiaChi.SizeF = new System.Drawing.SizeF(77.08333F, 23F);
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.LocationFloat = new DevExpress.Utils.PointFloat(185.4167F, 75F);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDienThoai.SizeF = new System.Drawing.SizeF(77.08333F, 23F);
            this.lbDienThoai.Text = "Điện thoại:";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xuaT_NHAPTONTTCT1
            // 
            this.xuaT_NHAPTONTTCT1.DataSetName = "XUAT_NHAPTONTTCT";
            this.xuaT_NHAPTONTTCT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGTINCTTableAdapter
            // 
            this.tHONGTINCTTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl6
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl6.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl6.Location = new System.Drawing.Point(3, 3);
            this.gridControl6.MainView = this.gridView1;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.Size = new System.Drawing.Size(783, 99);
            this.gridControl6.TabIndex = 1;
            this.gridControl6.UseEmbeddedNavigator = true;
            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayXuat,
            this.ColTenKhachHang,
            this.colKhucVuc,
            this.colTongDanhThu});
            this.gridView1.GridControl = this.gridControl6;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tên khách hàng", this.colTongDanhThu, "(Tổng doanh thu:  {0,0 vnđ})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Tên Khách hàng", this.colNgayXuat, "Count")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NGAYXUAT";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.Visible = true;
            this.colNgayXuat.VisibleIndex = 0;
            // 
            // ColTenKhachHang
            // 
            this.ColTenKhachHang.Caption = "Tên Khách hàng";
            this.ColTenKhachHang.FieldName = "Tên Khách hàng";
            this.ColTenKhachHang.Name = "ColTenKhachHang";
            this.ColTenKhachHang.SummaryItem.DisplayFormat = "Tổng số : {0}";
            this.ColTenKhachHang.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.ColTenKhachHang.Visible = true;
            this.ColTenKhachHang.VisibleIndex = 2;
            // 
            // colKhucVuc
            // 
            this.colKhucVuc.Caption = "Tên khu vực";
            this.colKhucVuc.FieldName = "TENKV";
            this.colKhucVuc.Name = "colKhucVuc";
            this.colKhucVuc.Visible = true;
            this.colKhucVuc.VisibleIndex = 1;
            // 
            // colTongDanhThu
            // 
            this.colTongDanhThu.Caption = "Tổng doanh thu";
            this.colTongDanhThu.DisplayFormat.FormatString = "0,0 vnđ";
            this.colTongDanhThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongDanhThu.FieldName = "TongDoanhThu";
            this.colTongDanhThu.Name = "colTongDanhThu";
            this.colTongDanhThu.SummaryItem.DisplayFormat = "Tổng cộng={0:0,0 vnđ}";
            this.colTongDanhThu.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTongDanhThu.Visible = true;
            this.colTongDanhThu.VisibleIndex = 3;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999974F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(815.4167F, 103.625F);
            this.winControlContainer1.WinControl = this.gridControl6;
            // 
            // reportBaoCaoDoanhThu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.tHONGTINCTTableAdapter;
            this.DataMember = "THONGTINCT";
            this.DataSource = this.xuaT_NHAPTONTTCT1;
            this.Margins = new System.Drawing.Printing.Margins(15, 15, 203, 100);
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lbBaoCaoDoanhThu;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet3TableAdapters.THONGTINCTTableAdapter thongtinctTableAdapter1;
        // private XUAT_NHAPTONDataSet3 xuaT_NHAPTONDataSet31;
        private DevExpress.XtraReports.UI.XRLabel lbNgayThang;
        private DevExpress.XtraReports.UI.XRLabel lbKeToanTruong;
        private DevExpress.XtraReports.UI.XRLabel lbKi2;
        private DevExpress.XtraReports.UI.XRLabel lbKi1;
        private DevExpress.XtraReports.UI.XRLabel lbGiamDoc;
        private DevExpress.XtraReports.UI.XRLabel lbKi;
        private DevExpress.XtraReports.UI.XRLabel lbNguoiLap;
        private DevExpress.XtraReports.UI.XRLabel lbFax;
        private DevExpress.XtraReports.UI.XRLabel lbDiaChi;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai;
        private XUAT_NHAPTONTTCT xuaT_NHAPTONTTCT1;
        private WindowsFormsApplication1.XUAT_NHAPTONTTCTTableAdapters.THONGTINCTTableAdapter tHONGTINCTTableAdapter;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colKhucVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTongDanhThu;
    }
}
