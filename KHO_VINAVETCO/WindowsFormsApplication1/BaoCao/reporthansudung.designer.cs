namespace WindowsFormsApplication1
{
    partial class reporthansudung
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmamhathang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhomhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenmathang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.coltendonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colhansudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colthanhtiennhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthanhtienxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colhinhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.coltinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colgiamua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colsongayhethan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbNgayThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKeToanTruong = new DevExpress.XtraReports.UI.XRLabel();
            this.lbGiamDoc = new DevExpress.XtraReports.UI.XRLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1,
            this.lbNgayThang,
            this.lbKeToanTruong,
            this.lbGiamDoc,
            this.lbNguoiLap});
            this.Detail.HeightF = 252F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(795.0001F, 157.375F);
            this.winControlContainer1.WinControl = this.gridControl1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemCalcEdit2,
            this.repositoryItemCalcEdit3,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(763, 151);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmamhathang,
            this.coltennhomhang,
            this.coltenmathang,
            this.colthue,
            this.coltendonvi,
            this.colsoluong,
            this.colhansudung,
            this.colthanhtiennhap,
            this.colgiaban,
            this.colthanhtienxuat,
            this.colmota,
            this.colhinhanh,
            this.coltinhtrang,
            this.colgiamua,
            this.colsongayhethan});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(846, 478, 216, 178);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PreviewFieldName = "Báo Cáo Doanh Thu";
            // 
            // colmamhathang
            // 
            this.colmamhathang.Caption = "Mã Mặt Hàng";
            this.colmamhathang.FieldName = "MAMH";
            this.colmamhathang.Name = "colmamhathang";
            this.colmamhathang.OptionsColumn.AllowEdit = false;
            this.colmamhathang.Width = 66;
            // 
            // coltennhomhang
            // 
            this.coltennhomhang.Caption = "Tên Nhóm Hàng";
            this.coltennhomhang.FieldName = "tennhomhang";
            this.coltennhomhang.Name = "coltennhomhang";
            this.coltennhomhang.Visible = true;
            this.coltennhomhang.VisibleIndex = 0;
            this.coltennhomhang.Width = 71;
            // 
            // coltenmathang
            // 
            this.coltenmathang.Caption = "Tên Mặt Hàng";
            this.coltenmathang.FieldName = "TENMH";
            this.coltenmathang.Name = "coltenmathang";
            this.coltenmathang.OptionsColumn.AllowEdit = false;
            this.coltenmathang.Visible = true;
            this.coltenmathang.VisibleIndex = 1;
            this.coltenmathang.Width = 91;
            // 
            // colthue
            // 
            this.colthue.Caption = "Số Thuế";
            this.colthue.ColumnEdit = this.repositoryItemCalcEdit2;
            this.colthue.FieldName = "SOTHUE";
            this.colthue.Name = "colthue";
            this.colthue.Visible = true;
            this.colthue.VisibleIndex = 2;
            this.colthue.Width = 52;
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // coltendonvi
            // 
            this.coltendonvi.Caption = "Tên Đơn Vị ";
            this.coltendonvi.FieldName = "DONVITINH";
            this.coltendonvi.Name = "coltendonvi";
            this.coltendonvi.OptionsColumn.AllowEdit = false;
            this.coltendonvi.Visible = true;
            this.coltendonvi.VisibleIndex = 3;
            this.coltendonvi.Width = 65;
            // 
            // colsoluong
            // 
            this.colsoluong.Caption = "Số Lượng";
            this.colsoluong.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colsoluong.FieldName = "SOLUONGMH";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.OptionsColumn.AllowEdit = false;
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 4;
            this.colsoluong.Width = 44;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colhansudung
            // 
            this.colhansudung.Caption = "Hạn Sử Dụng";
            this.colhansudung.ColumnEdit = this.repositoryItemDateEdit1;
            this.colhansudung.FieldName = "HANSUDUNG";
            this.colhansudung.Name = "colhansudung";
            this.colhansudung.OptionsColumn.AllowEdit = false;
            this.colhansudung.Visible = true;
            this.colhansudung.VisibleIndex = 9;
            this.colhansudung.Width = 97;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colthanhtiennhap
            // 
            this.colthanhtiennhap.Caption = "Thành Tiền Nhập";
            this.colthanhtiennhap.FieldName = "thanhtien";
            this.colthanhtiennhap.Name = "colthanhtiennhap";
            this.colthanhtiennhap.OptionsColumn.AllowEdit = false;
            this.colthanhtiennhap.SummaryItem.DisplayFormat = "Tổng:{0:0,0 vnđ}";
            this.colthanhtiennhap.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colthanhtiennhap.Visible = true;
            this.colthanhtiennhap.VisibleIndex = 6;
            this.colthanhtiennhap.Width = 67;
            // 
            // colgiaban
            // 
            this.colgiaban.Caption = "Giá Bán";
            this.colgiaban.FieldName = "GIABAN";
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.OptionsColumn.AllowEdit = false;
            this.colgiaban.Visible = true;
            this.colgiaban.VisibleIndex = 7;
            this.colgiaban.Width = 50;
            // 
            // colthanhtienxuat
            // 
            this.colthanhtienxuat.Caption = "Thành Tiền Xuất";
            this.colthanhtienxuat.FieldName = "thanhtienban";
            this.colthanhtienxuat.Name = "colthanhtienxuat";
            this.colthanhtienxuat.SummaryItem.DisplayFormat = "Tổng :{0:0,0 vnđ}";
            this.colthanhtienxuat.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colthanhtienxuat.ToolTip = "Tổng Tiền Bán";
            this.colthanhtienxuat.Visible = true;
            this.colthanhtienxuat.VisibleIndex = 8;
            this.colthanhtienxuat.Width = 97;
            // 
            // colmota
            // 
            this.colmota.Caption = "Mô Tả";
            this.colmota.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.colmota.FieldName = "MOTA";
            this.colmota.Name = "colmota";
            this.colmota.Width = 57;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            // 
            // colhinhanh
            // 
            this.colhinhanh.Caption = "Hình Ảnh";
            this.colhinhanh.ColumnEdit = this.repositoryItemImageEdit1;
            this.colhinhanh.FieldName = "PICTURE";
            this.colhinhanh.Name = "colhinhanh";
            this.colhinhanh.Width = 70;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // coltinhtrang
            // 
            this.coltinhtrang.Caption = "Tình Trạng";
            this.coltinhtrang.ColumnEdit = this.repositoryItemCheckEdit1;
            this.coltinhtrang.FieldName = "Tinhtrang";
            this.coltinhtrang.Name = "coltinhtrang";
            this.coltinhtrang.OptionsColumn.AllowEdit = false;
            this.coltinhtrang.Width = 89;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colgiamua
            // 
            this.colgiamua.Caption = "Giá Mua";
            this.colgiamua.ColumnEdit = this.repositoryItemCalcEdit3;
            this.colgiamua.FieldName = "GIAMUA";
            this.colgiamua.Name = "colgiamua";
            this.colgiamua.Visible = true;
            this.colgiamua.VisibleIndex = 5;
            this.colgiamua.Width = 51;
            // 
            // repositoryItemCalcEdit3
            // 
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            // 
            // colsongayhethan
            // 
            this.colsongayhethan.Caption = "Số Ngày Hết Hạn";
            this.colsongayhethan.FieldName = "SONGAYHETHANH";
            this.colsongayhethan.Name = "colsongayhethan";
            this.colsongayhethan.Visible = true;
            this.colsongayhethan.VisibleIndex = 10;
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.LocationFloat = new DevExpress.Utils.PointFloat(575.0417F, 170.5F);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayThang.SizeF = new System.Drawing.SizeF(143.75F, 22.99998F);
            this.lbNgayThang.StylePriority.UseFont = false;
            this.lbNgayThang.Text = "Ngày... Tháng...Năm...";
            // 
            // lbKeToanTruong
            // 
            this.lbKeToanTruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeToanTruong.LocationFloat = new DevExpress.Utils.PointFloat(302.1249F, 193.4999F);
            this.lbKeToanTruong.Name = "lbKeToanTruong";
            this.lbKeToanTruong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKeToanTruong.SizeF = new System.Drawing.SizeF(120.8334F, 23.00002F);
            this.lbKeToanTruong.StylePriority.UseFont = false;
            this.lbKeToanTruong.Text = "Kế toán trưởng";
            // 
            // lbGiamDoc
            // 
            this.lbGiamDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamDoc.LocationFloat = new DevExpress.Utils.PointFloat(615.6665F, 193.4999F);
            this.lbGiamDoc.Name = "lbGiamDoc";
            this.lbGiamDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbGiamDoc.SizeF = new System.Drawing.SizeF(77.08342F, 23.00002F);
            this.lbGiamDoc.StylePriority.UseFont = false;
            this.lbGiamDoc.Text = "Giám đốc";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(43.79173F, 193.4999F);
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
            this.lbBaoCaoDoanhThu.Text = "Báo Cáo Hạn Sử Dụng";
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
            // reporthansudung
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.tHONGTINCTTableAdapter;
            this.DataMember = "THONGTINCT";
            this.DataSource = this.xuaT_NHAPTONTTCT1;
            this.Margins = new System.Drawing.Printing.Margins(15, 30, 203, 100);
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).EndInit();
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
        private DevExpress.XtraReports.UI.XRLabel lbGiamDoc;
        private DevExpress.XtraReports.UI.XRLabel lbNguoiLap;
        private DevExpress.XtraReports.UI.XRLabel lbFax;
        private DevExpress.XtraReports.UI.XRLabel lbDiaChi;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai;
      
        private WindowsFormsApplication1.XUAT_NHAPTONTTCTTableAdapters.THONGTINCTTableAdapter tHONGTINCTTableAdapter;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmamhathang;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhomhang;
        private DevExpress.XtraGrid.Columns.GridColumn coltenmathang;
        private DevExpress.XtraGrid.Columns.GridColumn colthue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn coltendonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colhansudung;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhtiennhap;
        private DevExpress.XtraGrid.Columns.GridColumn colgiaban;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhtienxuat;
        private DevExpress.XtraGrid.Columns.GridColumn colmota;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colhinhanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coltinhtrang;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colgiamua;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colsongayhethan;
    }
}
