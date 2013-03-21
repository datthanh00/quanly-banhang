namespace WindowsFormsApplication1
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barThem = new DevExpress.XtraBars.BarButtonItem();
            this.barXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barSua = new DevExpress.XtraBars.BarButtonItem();
            this.barNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.barXuat1 = new DevExpress.XtraBars.BarButtonItem();
            this.barNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barThem1 = new DevExpress.XtraBars.BarButtonItem();
            this.girdcontrol = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTAIKHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGANHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEBSITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYAHOO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
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
            this.barStaticItem1,
            this.barThem,
            this.barXoa,
            this.barSua,
            this.barNapLai,
            this.barIn,
            this.barXuat1,
            this.barNhap,
            this.barThoat,
            this.barThem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.ShowFullMenusAfterDelay = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(87, 140);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barNapLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barXuat1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // barThem
            // 
            resources.ApplyResources(this.barThem, "barThem");
            this.barThem.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.barThem.Id = 1;
            this.barThem.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.barThem.Name = "barThem";
            this.barThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThem_ItemClick);
            // 
            // barXoa
            // 
            resources.ApplyResources(this.barXoa, "barXoa");
            this.barXoa.Glyph = global::WindowsFormsApplication1.Properties.Resources.close1;
            this.barXoa.Id = 2;
            this.barXoa.Name = "barXoa";
            this.barXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barSua
            // 
            resources.ApplyResources(this.barSua, "barSua");
            this.barSua.Glyph = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.barSua.Id = 3;
            this.barSua.Name = "barSua";
            this.barSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barNapLai
            // 
            resources.ApplyResources(this.barNapLai, "barNapLai");
            this.barNapLai.Glyph = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.barNapLai.Id = 4;
            this.barNapLai.Name = "barNapLai";
            this.barNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barIn
            // 
            resources.ApplyResources(this.barIn, "barIn");
            this.barIn.Glyph = global::WindowsFormsApplication1.Properties.Resources.printer1;
            this.barIn.Id = 5;
            this.barIn.Name = "barIn";
            this.barIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btIn_ItemClick);
            // 
            // barXuat1
            // 
            resources.ApplyResources(this.barXuat1, "barXuat1");
            this.barXuat1.Glyph = global::WindowsFormsApplication1.Properties.Resources.export;
            this.barXuat1.Id = 6;
            this.barXuat1.Name = "barXuat1";
            this.barXuat1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barNhap
            // 
            resources.ApplyResources(this.barNhap, "barNhap");
            this.barNhap.Glyph = global::WindowsFormsApplication1.Properties.Resources.excel;
            this.barNhap.Id = 7;
            this.barNhap.Name = "barNhap";
            this.barNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhap_ItemClick);
            // 
            // barThoat
            // 
            resources.ApplyResources(this.barThoat, "barThoat");
            this.barThoat.Glyph = global::WindowsFormsApplication1.Properties.Resources.close2;
            this.barThoat.Id = 8;
            this.barThoat.Name = "barThoat";
            this.barThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barDockControlTop
            // 
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            // 
            // barDockControlBottom
            // 
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            // 
            // barDockControlLeft
            // 
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            // 
            // barDockControlRight
            // 
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            // 
            // barStaticItem1
            // 
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barThem1
            // 
            resources.ApplyResources(this.barThem1, "barThem1");
            this.barThem1.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.barThem1.Id = 9;
            this.barThem1.Name = "barThem1";
            // 
            // girdcontrol
            // 
            resources.ApplyResources(this.girdcontrol, "girdcontrol");
            this.girdcontrol.MainView = this.gridView1;
            this.girdcontrol.MenuManager = this.barManager1;
            this.girdcontrol.Name = "girdcontrol";
            this.girdcontrol.UseEmbeddedNavigator = true;
            this.girdcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.girdcontrol.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMAKV,
            this.gridColumn1,
            this.colSOTAIKHOAN,
            this.colNGANHANG,
            this.colMASOTHUE,
            this.colDIACHI,
            this.colSDT,
            this.colFAX,
            this.colWEBSITE,
            this.colYAHOO,
            this.colSKYPE,
            this.colTINHTRANG,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.girdcontrol;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMAKH
            // 
            resources.ApplyResources(this.colMAKH, "colMAKH");
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            // 
            // colTENKH
            // 
            resources.ApplyResources(this.colTENKH, "colTENKH");
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            // 
            // colMAKV
            // 
            resources.ApplyResources(this.colMAKV, "colMAKV");
            this.colMAKV.FieldName = "TENKV";
            this.colMAKV.Name = "colMAKV";
            this.colMAKV.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "TENNV";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colSOTAIKHOAN
            // 
            resources.ApplyResources(this.colSOTAIKHOAN, "colSOTAIKHOAN");
            this.colSOTAIKHOAN.FieldName = "SOTAIKHOAN";
            this.colSOTAIKHOAN.Name = "colSOTAIKHOAN";
            this.colSOTAIKHOAN.OptionsColumn.AllowEdit = false;
            // 
            // colNGANHANG
            // 
            resources.ApplyResources(this.colNGANHANG, "colNGANHANG");
            this.colNGANHANG.FieldName = "NGANHANG";
            this.colNGANHANG.Name = "colNGANHANG";
            this.colNGANHANG.OptionsColumn.AllowEdit = false;
            // 
            // colMASOTHUE
            // 
            resources.ApplyResources(this.colMASOTHUE, "colMASOTHUE");
            this.colMASOTHUE.FieldName = "MASOTHUE";
            this.colMASOTHUE.Name = "colMASOTHUE";
            this.colMASOTHUE.OptionsColumn.AllowEdit = false;
            // 
            // colDIACHI
            // 
            resources.ApplyResources(this.colDIACHI, "colDIACHI");
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            // 
            // colSDT
            // 
            resources.ApplyResources(this.colSDT, "colSDT");
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            // 
            // colFAX
            // 
            resources.ApplyResources(this.colFAX, "colFAX");
            this.colFAX.FieldName = "FAX";
            this.colFAX.Name = "colFAX";
            this.colFAX.OptionsColumn.AllowEdit = false;
            // 
            // colWEBSITE
            // 
            resources.ApplyResources(this.colWEBSITE, "colWEBSITE");
            this.colWEBSITE.FieldName = "WEBSITE";
            this.colWEBSITE.Name = "colWEBSITE";
            this.colWEBSITE.OptionsColumn.AllowEdit = false;
            // 
            // colYAHOO
            // 
            resources.ApplyResources(this.colYAHOO, "colYAHOO");
            this.colYAHOO.FieldName = "YAHOO";
            this.colYAHOO.Name = "colYAHOO";
            this.colYAHOO.OptionsColumn.AllowEdit = false;
            // 
            // colSKYPE
            // 
            resources.ApplyResources(this.colSKYPE, "colSKYPE");
            this.colSKYPE.FieldName = "SKYPE";
            this.colSKYPE.Name = "colSKYPE";
            this.colSKYPE.OptionsColumn.AllowEdit = false;
            // 
            // colTINHTRANG
            // 
            resources.ApplyResources(this.colTINHTRANG, "colTINHTRANG");
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.OptionsColumn.AllowEdit = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "MAKV";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "MANV";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // frmKhachHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.girdcontrol);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barXoa;
        private DevExpress.XtraBars.BarButtonItem barSua;
        private DevExpress.XtraBars.BarButtonItem barNapLai;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraBars.BarButtonItem barXuat1;
        private DevExpress.XtraBars.BarButtonItem barNhap;
        private DevExpress.XtraBars.BarButtonItem barThoat;
        private DevExpress.XtraGrid.GridControl girdcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraBars.BarButtonItem barThem1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTAIKHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGANHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colMASOTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX;
        private DevExpress.XtraGrid.Columns.GridColumn colWEBSITE;
        private DevExpress.XtraGrid.Columns.GridColumn colYAHOO;
        private DevExpress.XtraGrid.Columns.GridColumn colSKYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}