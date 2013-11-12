namespace WindowsFormsApplication1
{
    partial class frmMatHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barThem = new DevExpress.XtraBars.BarButtonItem();
            this.barXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barSua = new DevExpress.XtraBars.BarButtonItem();
            this.barNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.barXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barThem,
            this.barXoa,
            this.barSua,
            this.barNapLai,
            this.barIn,
            this.barXuat,
            this.barNhap});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barThem
            // 
            this.barThem.Caption = "Thêm";
            this.barThem.Glyph = global::Quanlykho.Properties.Resources.add;
            this.barThem.Id = 0;
            this.barThem.Name = "barThem";
            this.barThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThem_ItemClick);
            // 
            // barXoa
            // 
            this.barXoa.Caption = "Xóa";
            this.barXoa.Glyph = global::Quanlykho.Properties.Resources.close;
            this.barXoa.Id = 1;
            this.barXoa.Name = "barXoa";
            this.barXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barXoa_ItemClick);
            // 
            // barSua
            // 
            this.barSua.Caption = "Sửa";
            this.barSua.Glyph = global::Quanlykho.Properties.Resources.edit2;
            this.barSua.Id = 2;
            this.barSua.Name = "barSua";
            this.barSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSua_ItemClick);
            // 
            // barNapLai
            // 
            this.barNapLai.Caption = "Nạp Lại";
            this.barNapLai.Glyph = global::Quanlykho.Properties.Resources.refresh;
            this.barNapLai.Id = 3;
            this.barNapLai.Name = "barNapLai";
            this.barNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNapLai_ItemClick);
            // 
            // barIn
            // 
            this.barIn.Caption = "In";
            this.barIn.Glyph = global::Quanlykho.Properties.Resources.printer1;
            this.barIn.Id = 4;
            this.barIn.Name = "barIn";
            this.barIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIn_ItemClick);
            // 
            // barXuat
            // 
            this.barXuat.Caption = "Xuất Dữ Liệu";
            this.barXuat.Glyph = global::Quanlykho.Properties.Resources.export;
            this.barXuat.Id = 5;
            this.barXuat.Name = "barXuat";
            this.barXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barXuat_ItemClick);
            // 
            // barNhap
            // 
            this.barNhap.Caption = "Nhập Dữ Liệu";
            this.barNhap.Glyph = global::Quanlykho.Properties.Resources.excel;
            this.barNhap.Id = 6;
            this.barNhap.Name = "barNhap";
            this.barNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhap_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 465);
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1234, 423);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1228, 417);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colMATH,
            this.colMANH,
            this.colTENMH,
            this.colMADVT,
            this.colSOLUONGMH,
            this.gridColumn3,
            this.colMOTA,
            this.colMAKHO,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTENMH, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã Mặt Hàng";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 99;
            // 
            // colMATH
            // 
            this.colMATH.Caption = "Mã Thuế";
            this.colMATH.FieldName = "MATH";
            this.colMATH.Name = "colMATH";
            this.colMATH.OptionsColumn.AllowEdit = false;
            this.colMATH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMATH.Width = 99;
            // 
            // colMANH
            // 
            this.colMANH.Caption = "Mã Nhóm Hàng";
            this.colMANH.FieldName = "MANH";
            this.colMANH.Name = "colMANH";
            this.colMANH.OptionsColumn.AllowEdit = false;
            this.colMANH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMANH.Width = 106;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Mặt Hàng";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 199;
            // 
            // colMADVT
            // 
            this.colMADVT.Caption = "Đơn Vị Tính";
            this.colMADVT.FieldName = "DONVITINH";
            this.colMADVT.Name = "colMADVT";
            this.colMADVT.OptionsColumn.AllowEdit = false;
            this.colMADVT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMADVT.Visible = true;
            this.colMADVT.VisibleIndex = 2;
            this.colMADVT.Width = 166;
            // 
            // colSOLUONGMH
            // 
            this.colSOLUONGMH.Caption = "Số Lượng Mặt Hàng";
            this.colSOLUONGMH.DisplayFormat.FormatString = "{0:0.##}";
            this.colSOLUONGMH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONGMH.FieldName = "SOLUONGMH";
            this.colSOLUONGMH.Name = "colSOLUONGMH";
            this.colSOLUONGMH.OptionsColumn.AllowEdit = false;
            this.colSOLUONGMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSOLUONGMH.SummaryItem.DisplayFormat = "{0:0.##}";
            this.colSOLUONGMH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSOLUONGMH.Visible = true;
            this.colSOLUONGMH.VisibleIndex = 5;
            this.colSOLUONGMH.Width = 177;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá Mua";
            this.gridColumn3.DisplayFormat.FormatString = "{0:0,0}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "GIAMUA";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 139;
            // 
            // colMOTA
            // 
            this.colMOTA.Caption = "Mô Tả";
            this.colMOTA.FieldName = "MOTA";
            this.colMOTA.Name = "colMOTA";
            this.colMOTA.OptionsColumn.AllowEdit = false;
            this.colMOTA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMOTA.Visible = true;
            this.colMOTA.VisibleIndex = 6;
            this.colMOTA.Width = 205;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Công Ty";
            this.gridColumn2.FieldName = "TENNCC";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 138;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã CTY";
            this.gridColumn1.FieldName = "MANCC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Width = 133;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Theo ĐVT";
            this.gridColumn4.FieldName = "KLDVT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Width = 204;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 465);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMatHang";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMatHang_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        //private XUAT_NHAPTONDataSet20 xUAT_NHAPTONDataSet20;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet20TableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barThem;
        private DevExpress.XtraBars.BarButtonItem barXoa;
        private DevExpress.XtraBars.BarButtonItem barSua;
        private DevExpress.XtraBars.BarButtonItem barNapLai;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraBars.BarButtonItem barXuat;
        private DevExpress.XtraBars.BarButtonItem barNhap;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMATH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMADVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
      //  private XUAT_NHAPTONDataSet32 xUAT_NHAPTONDataSet32;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet32TableAdapters.MATHANGTableAdapter mATHANGTableAdapter1;
        //private XUAT_NHAPTONDataSet37 xUAT_NHAPTONDataSet37;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet37TableAdapters.MATHANGTableAdapter mATHANGTableAdapter2;
    }
}