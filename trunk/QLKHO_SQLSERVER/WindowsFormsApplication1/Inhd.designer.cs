namespace WindowsFormsApplication1
{
    partial class Inhd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


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
            this.gridCTHOADON = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.resTENMATHANG = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lbGiamDoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNguoiLap = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgayThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKeToanTruong = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lbngaylap = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbFax = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDienThoai = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiaChi = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resTENMATHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1,
            this.lbGiamDoc,
            this.lbKi2,
            this.lbNguoiLap,
            this.lbKi1,
            this.lbNgayThang,
            this.lbKi,
            this.lbKeToanTruong});
            this.Detail.HeightF = 460F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(641.6667F, 176.5417F);
            this.winControlContainer1.WinControl = this.gridControl1;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridCTHOADON;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.resTENMATHANG,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(616, 169);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCTHOADON});
            // 
            // gridCTHOADON
            // 
            this.gridCTHOADON.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridCTHOADON.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCTHOADON.GridControl = this.gridControl1;
            this.gridCTHOADON.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", null, "")});
            this.gridCTHOADON.Name = "gridCTHOADON";
            this.gridCTHOADON.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridCTHOADON.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridCTHOADON.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridCTHOADON.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridCTHOADON.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridCTHOADON.OptionsDetail.AutoZoomDetail = true;
            this.gridCTHOADON.OptionsSelection.InvertSelection = true;
            this.gridCTHOADON.OptionsView.EnableAppearanceEvenRow = true;
            this.gridCTHOADON.OptionsView.EnableAppearanceOddRow = true;
            this.gridCTHOADON.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridCTHOADON.OptionsView.RowAutoHeight = true;
            this.gridCTHOADON.OptionsView.ShowFooter = true;
            this.gridCTHOADON.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // resTENMATHANG
            // 
            this.resTENMATHANG.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.resTENMATHANG.AutoHeight = false;
            this.resTENMATHANG.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resTENMATHANG.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "Product Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "Ma")});
            this.resTENMATHANG.DisplayMember = "TENMH";
            this.resTENMATHANG.DropDownRows = 10;
            this.resTENMATHANG.MaxLength = 1000000000;
            this.resTENMATHANG.Name = "resTENMATHANG";
            this.resTENMATHANG.NullText = "Chon";
            this.resTENMATHANG.PopupWidth = 220;
            this.resTENMATHANG.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.resTENMATHANG.ValueMember = "MAMH";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Mask.EditMask = "c";
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            this.repositoryItemCalcEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "p";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.MaxLength = 100000;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.repositoryItemLookUpEdit1.ValueMember = "MAMH";
            // 
            // lbGiamDoc
            // 
            this.lbGiamDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamDoc.LocationFloat = new DevExpress.Utils.PointFloat(621.875F, 408.3333F);
            this.lbGiamDoc.Name = "lbGiamDoc";
            this.lbGiamDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbGiamDoc.SizeF = new System.Drawing.SizeF(77.08342F, 23.00002F);
            this.lbGiamDoc.StylePriority.UseFont = false;
            this.lbGiamDoc.Text = "Giám đốc";
            // 
            // lbKi2
            // 
            this.lbKi2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi2.LocationFloat = new DevExpress.Utils.PointFloat(596.875F, 433.3333F);
            this.lbKi2.Name = "lbKi2";
            this.lbKi2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi2.SizeF = new System.Drawing.SizeF(121.8751F, 23F);
            this.lbKi2.StylePriority.UseFont = false;
            this.lbKi2.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(122.9167F, 408.3333F);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNguoiLap.SizeF = new System.Drawing.SizeF(109.3749F, 23.00002F);
            this.lbNguoiLap.StylePriority.UseFont = false;
            this.lbNguoiLap.Text = "Người lập";
            // 
            // lbKi1
            // 
            this.lbKi1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi1.LocationFloat = new DevExpress.Utils.PointFloat(296.875F, 433.3333F);
            this.lbKi1.Name = "lbKi1";
            this.lbKi1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi1.SizeF = new System.Drawing.SizeF(120.8334F, 23F);
            this.lbKi1.StylePriority.UseFont = false;
            this.lbKi1.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.LocationFloat = new DevExpress.Utils.PointFloat(559.375F, 370.8333F);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayThang.SizeF = new System.Drawing.SizeF(143.75F, 22.99998F);
            this.lbNgayThang.StylePriority.UseFont = false;
            this.lbNgayThang.Text = "Ngày... Tháng...Năm...";
            // 
            // lbKi
            // 
            this.lbKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi.LocationFloat = new DevExpress.Utils.PointFloat(122.9167F, 433.3333F);
            this.lbKi.Name = "lbKi";
            this.lbKi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi.SizeF = new System.Drawing.SizeF(120.8333F, 23F);
            this.lbKi.StylePriority.UseFont = false;
            this.lbKi.Text = "(Kí ghi rỏ họ tên)";
            // 
            // lbKeToanTruong
            // 
            this.lbKeToanTruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeToanTruong.LocationFloat = new DevExpress.Utils.PointFloat(296.875F, 408.3333F);
            this.lbKeToanTruong.Name = "lbKeToanTruong";
            this.lbKeToanTruong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKeToanTruong.SizeF = new System.Drawing.SizeF(120.8334F, 23.00002F);
            this.lbKeToanTruong.StylePriority.UseFont = false;
            this.lbKeToanTruong.Text = "Kế toán trưởng";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbngaylap,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.lbFax,
            this.xrLabel4,
            this.lbDienThoai,
            this.lbDiaChi});
            this.TopMargin.HeightF = 144F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbngaylap
            // 
            this.lbngaylap.AutoWidth = true;
            this.lbngaylap.LocationFloat = new DevExpress.Utils.PointFloat(102.0833F, 100F);
            this.lbngaylap.Multiline = true;
            this.lbngaylap.Name = "lbngaylap";
            this.lbngaylap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbngaylap.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbngaylap.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.AutoWidth = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 100F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.Text = "Ngày Lập:";
            // 
            // xrLabel2
            // 
            this.xrLabel2.AutoWidth = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(225F, 66.00002F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(77.08334F, 66.00002F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(99.99998F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // lbFax
            // 
            this.lbFax.LocationFloat = new DevExpress.Utils.PointFloat(187.5F, 66.00002F);
            this.lbFax.Name = "lbFax";
            this.lbFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbFax.SizeF = new System.Drawing.SizeF(34.37497F, 23F);
            this.lbFax.Text = "Fax:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.AutoWidth = true;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(2.083302F, 10F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(530.2086F, 33.00001F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 66.00002F);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDienThoai.SizeF = new System.Drawing.SizeF(77.08333F, 23F);
            this.lbDienThoai.Text = "Điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.LocationFloat = new DevExpress.Utils.PointFloat(2.083302F, 43.00002F);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiaChi.SizeF = new System.Drawing.SizeF(530.2086F, 23F);
            this.lbDiaChi.Text = "lbDiaChi";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Inhd
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(43, 48, 144, 100);
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resTENMATHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lbFax;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai;
        private DevExpress.XtraReports.UI.XRLabel lbDiaChi;
        private DevExpress.XtraReports.UI.XRLabel lbKi2;
      //  private XUAT_NHAPTONDataSet3 xuaT_NHAPTONDataSet3;
        //  private WindowsFormsApplication1.XUAT_NHAPTONDataSet3TableAdapters.THONGTINCTTableAdapter tHONGTINCTTableAdapter1;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCTHOADON;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resTENMATHANG;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraReports.UI.XRLabel lbGiamDoc;
        private DevExpress.XtraReports.UI.XRLabel lbNguoiLap;
        private DevExpress.XtraReports.UI.XRLabel lbKi1;
        private DevExpress.XtraReports.UI.XRLabel lbNgayThang;
        private DevExpress.XtraReports.UI.XRLabel lbKi;
        private DevExpress.XtraReports.UI.XRLabel lbKeToanTruong;
        private DevExpress.XtraReports.UI.XRLabel lbngaylap;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
