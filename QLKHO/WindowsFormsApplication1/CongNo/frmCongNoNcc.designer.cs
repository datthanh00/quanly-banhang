namespace WindowsFormsApplication1
{
    partial class frmCongNoNcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongNoNcc));
            this.groupControl_phieuchi = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuchi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhânviên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãhóađơnnhập1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàychi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_congno = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãhóađơnnhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênnhàcungcấp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhàcungcấp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnphảitrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCònlại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barTraTien = new DevExpress.XtraBars.BarSubItem();
            this.barSuaTien = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barBtDong = new DevExpress.XtraBars.BarButtonItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarKhachHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.linkcongno = new DevExpress.XtraNavBar.NavBarItem();
            this.linkphieuchi = new DevExpress.XtraNavBar.NavBarItem();
            this.linkTheoTuan = new DevExpress.XtraNavBar.NavBarItem();
            this.panel_congno = new DevExpress.XtraEditors.PanelControl();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btTratien = new DevExpress.XtraEditors.SimpleButton();
            this.panel_phieuchi = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_phieuchi)).BeginInit();
            this.groupControl_phieuchi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_congno)).BeginInit();
            this.groupControl_congno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_congno)).BeginInit();
            this.panel_congno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_phieuchi)).BeginInit();
            this.panel_phieuchi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_phieuchi
            // 
            this.groupControl_phieuchi.Controls.Add(this.gridControl2);
            this.groupControl_phieuchi.Location = new System.Drawing.Point(203, 113);
            this.groupControl_phieuchi.Name = "groupControl_phieuchi";
            this.groupControl_phieuchi.Size = new System.Drawing.Size(1086, 229);
            this.groupControl_phieuchi.TabIndex = 5;
            this.groupControl_phieuchi.Text = "Tiền trả Nhà cung cấp";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 22);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1082, 205);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếuchi,
            this.colMãnhânviên,
            this.colMãhóađơnnhập1,
            this.colNgàychi,
            this.colTiềnđãtrả1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colMãphiếuchi
            // 
            this.colMãphiếuchi.DisplayFormat.FormatString = "0,0";
            this.colMãphiếuchi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMãphiếuchi.FieldName = "Mã phiếu chi";
            this.colMãphiếuchi.Name = "colMãphiếuchi";
            this.colMãphiếuchi.Visible = true;
            this.colMãphiếuchi.VisibleIndex = 0;
            // 
            // colMãnhânviên
            // 
            this.colMãnhânviên.FieldName = "Mã nhân viên";
            this.colMãnhânviên.Name = "colMãnhânviên";
            this.colMãnhânviên.Visible = true;
            this.colMãnhânviên.VisibleIndex = 1;
            // 
            // colMãhóađơnnhập1
            // 
            this.colMãhóađơnnhập1.FieldName = "Mã hóa đơn nhập";
            this.colMãhóađơnnhập1.Name = "colMãhóađơnnhập1";
            this.colMãhóađơnnhập1.Visible = true;
            this.colMãhóađơnnhập1.VisibleIndex = 2;
            // 
            // colNgàychi
            // 
            this.colNgàychi.FieldName = "Ngày chi";
            this.colNgàychi.Name = "colNgàychi";
            this.colNgàychi.Visible = true;
            this.colNgàychi.VisibleIndex = 3;
            // 
            // colTiềnđãtrả1
            // 
            this.colTiềnđãtrả1.DisplayFormat.FormatString = "0,0";
            this.colTiềnđãtrả1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnđãtrả1.FieldName = "Tiền đã trả";
            this.colTiềnđãtrả1.Name = "colTiềnđãtrả1";
            this.colTiềnđãtrả1.Visible = true;
            this.colTiềnđãtrả1.VisibleIndex = 4;
            // 
            // groupControl_congno
            // 
            this.groupControl_congno.Controls.Add(this.gridControl1);
            this.groupControl_congno.Location = new System.Drawing.Point(200, 272);
            this.groupControl_congno.Name = "groupControl_congno";
            this.groupControl_congno.Size = new System.Drawing.Size(1082, 239);
            this.groupControl_congno.TabIndex = 4;
            this.groupControl_congno.Text = "Công nợ Nhà Cung cấp";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1078, 215);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãhóađơnnhập,
            this.colTênnhàcungcấp,
            this.colMãnhàcungcấp,
            this.colTiềnphảitrả,
            this.colTiềnđãtrả,
            this.colCònlại});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1072, 507, 208, 170);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTênnhàcungcấp, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMãhóađơnnhập
            // 
            this.colMãhóađơnnhập.FieldName = "Mã hóa đơn nhập";
            this.colMãhóađơnnhập.Name = "colMãhóađơnnhập";
            this.colMãhóađơnnhập.Visible = true;
            this.colMãhóađơnnhập.VisibleIndex = 0;
            // 
            // colTênnhàcungcấp
            // 
            this.colTênnhàcungcấp.FieldName = "Tên nhà cung cấp";
            this.colTênnhàcungcấp.Name = "colTênnhàcungcấp";
            this.colTênnhàcungcấp.Visible = true;
            this.colTênnhàcungcấp.VisibleIndex = 1;
            // 
            // colMãnhàcungcấp
            // 
            this.colMãnhàcungcấp.FieldName = "Mã nhà cung cấp";
            this.colMãnhàcungcấp.Name = "colMãnhàcungcấp";
            this.colMãnhàcungcấp.Visible = true;
            this.colMãnhàcungcấp.VisibleIndex = 1;
            // 
            // colTiềnphảitrả
            // 
            this.colTiềnphảitrả.DisplayFormat.FormatString = "0,0";
            this.colTiềnphảitrả.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnphảitrả.FieldName = "Tiền phải trả";
            this.colTiềnphảitrả.Name = "colTiềnphảitrả";
            this.colTiềnphảitrả.SummaryItem.DisplayFormat = "Tổng tiền chi:{0:0,0 vnđ}";
            this.colTiềnphảitrả.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTiềnphảitrả.Visible = true;
            this.colTiềnphảitrả.VisibleIndex = 2;
            // 
            // colTiềnđãtrả
            // 
            this.colTiềnđãtrả.DisplayFormat.FormatString = "0,0";
            this.colTiềnđãtrả.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnđãtrả.FieldName = "Tiền đã trả";
            this.colTiềnđãtrả.Name = "colTiềnđãtrả";
            this.colTiềnđãtrả.SummaryItem.DisplayFormat = "Tiền đã chi:{0:0,0 vnđ}";
            this.colTiềnđãtrả.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTiềnđãtrả.Visible = true;
            this.colTiềnđãtrả.VisibleIndex = 3;
            // 
            // colCònlại
            // 
            this.colCònlại.DisplayFormat.FormatString = "0,0";
            this.colCònlại.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCònlại.FieldName = "Còn lại";
            this.colCònlại.Name = "colCònlại";
            this.colCònlại.OptionsColumn.ReadOnly = true;
            this.colCònlại.SummaryItem.DisplayFormat = "Tổng tiền Còn nợ:{0:0,0 vnđ}";
            this.colCònlại.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCònlại.Visible = true;
            this.colCònlại.VisibleIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barTraTien,
            this.barSuaTien,
            this.barEditItem1,
            this.barBtDong});
            this.barManager1.MaxItemId = 4;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            // 
            // barDockControl1
            // 
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1292, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Size = new System.Drawing.Size(1292, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1292, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // barTraTien
            // 
            this.barTraTien.Caption = "Trả tiền";
            this.barTraTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.barTraTien.Id = 0;
            this.barTraTien.Name = "barTraTien";
            // 
            // barSuaTien
            // 
            this.barSuaTien.Caption = "Sửa tiền đã trả";
            this.barSuaTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.barSuaTien.Id = 1;
            this.barSuaTien.Name = "barSuaTien";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barBtDong
            // 
            this.barBtDong.Caption = "Đóng";
            this.barBtDong.Glyph = global::WindowsFormsApplication1.Properties.Resources.close1;
            this.barBtDong.Id = 3;
            this.barBtDong.Name = "barBtDong";
            this.barBtDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("0fe777e2-c866-4865-a672-0f7d63a7d325");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 511);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 483);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarKhachHang;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarKhachHang});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.linkTheoTuan,
            this.linkphieuchi,
            this.linkcongno});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 191;
            this.navBarControl1.Size = new System.Drawing.Size(194, 483);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarKhachHang
            // 
            this.navBarKhachHang.Caption = "";
            this.navBarKhachHang.Expanded = true;
            this.navBarKhachHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkcongno),
            new DevExpress.XtraNavBar.NavBarItemLink(this.linkphieuchi)});
            this.navBarKhachHang.Name = "navBarKhachHang";
            // 
            // linkcongno
            // 
            this.linkcongno.Caption = "Công Nợ Nhà Cung Cấp";
            this.linkcongno.Name = "linkcongno";
            this.linkcongno.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkcongno.SmallImage")));
            this.linkcongno.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.linkcongno_LinkClicked);
            // 
            // linkphieuchi
            // 
            this.linkphieuchi.Caption = "Phiếu Chi Nhà Cung Cấp";
            this.linkphieuchi.Name = "linkphieuchi";
            this.linkphieuchi.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkphieuchi.SmallImage")));
            this.linkphieuchi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.linkphieuchi_LinkClicked);
            // 
            // linkTheoTuan
            // 
            this.linkTheoTuan.Caption = "Theo Tuần";
            this.linkTheoTuan.Name = "linkTheoTuan";
            this.linkTheoTuan.SmallImage = ((System.Drawing.Image)(resources.GetObject("linkTheoTuan.SmallImage")));
            // 
            // panel_congno
            // 
            this.panel_congno.Controls.Add(this.btDong);
            this.panel_congno.Controls.Add(this.btTratien);
            this.panel_congno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_congno.Location = new System.Drawing.Point(200, 0);
            this.panel_congno.Name = "panel_congno";
            this.panel_congno.Size = new System.Drawing.Size(1092, 59);
            this.panel_congno.TabIndex = 11;
            // 
            // btDong
            // 
            this.btDong.Image = global::WindowsFormsApplication1.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(120, 8);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 42);
            this.btDong.TabIndex = 0;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btTratien
            // 
            this.btTratien.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btTratien.Location = new System.Drawing.Point(6, 8);
            this.btTratien.Name = "btTratien";
            this.btTratien.Size = new System.Drawing.Size(103, 42);
            this.btTratien.TabIndex = 0;
            this.btTratien.Text = "Trả Tiền";
            this.btTratien.Click += new System.EventHandler(this.btTratien_Click);
            // 
            // panel_phieuchi
            // 
            this.panel_phieuchi.Controls.Add(this.simpleButton1);
            this.panel_phieuchi.Controls.Add(this.simpleButton2);
            this.panel_phieuchi.Controls.Add(this.simpleButton3);
            this.panel_phieuchi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_phieuchi.Location = new System.Drawing.Point(200, 59);
            this.panel_phieuchi.Name = "panel_phieuchi";
            this.panel_phieuchi.Size = new System.Drawing.Size(1092, 59);
            this.panel_phieuchi.TabIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::WindowsFormsApplication1.Properties.Resources.close__2_;
            this.simpleButton1.Location = new System.Drawing.Point(290, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.btDong_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.simpleButton2.Location = new System.Drawing.Point(120, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(159, 42);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Sửa Trả Tiền";
            this.simpleButton2.Click += new System.EventHandler(this.bt_edittratien_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::WindowsFormsApplication1.Properties.Resources.close3;
            this.simpleButton3.Location = new System.Drawing.Point(6, 8);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 42);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Xóa Trả Tiền";
            // 
            // frmCongNoNcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 511);
            this.Controls.Add(this.panel_phieuchi);
            this.Controls.Add(this.panel_congno);
            this.Controls.Add(this.groupControl_phieuchi);
            this.Controls.Add(this.groupControl_congno);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongNoNcc";
            this.Text = "frmCongNoNcc";
            this.Load += new System.EventHandler(this.frmCongNoNcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_phieuchi)).EndInit();
            this.groupControl_phieuchi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_congno)).EndInit();
            this.groupControl_congno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_congno)).EndInit();
            this.panel_congno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_phieuchi)).EndInit();
            this.panel_phieuchi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_phieuchi;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl_congno;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarSubItem barTraTien;
        private DevExpress.XtraBars.BarSubItem barSuaTien;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnnhập;
        private DevExpress.XtraGrid.Columns.GridColumn colTênnhàcungcấp;
        private DevExpress.XtraGrid.Columns.GridColumn colMãnhàcungcấp;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnphảitrả;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả;
        private DevExpress.XtraGrid.Columns.GridColumn colCònlại;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếuchi;
        private DevExpress.XtraGrid.Columns.GridColumn colMãnhânviên;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnnhập1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàychi;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả1;
        private DevExpress.XtraBars.BarButtonItem barBtDong;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panel_congno;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btTratien;
        private DevExpress.XtraEditors.PanelControl panel_phieuchi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarKhachHang;
        private DevExpress.XtraNavBar.NavBarItem linkcongno;
        private DevExpress.XtraNavBar.NavBarItem linkphieuchi;
        private DevExpress.XtraNavBar.NavBarItem linkTheoTuan;
    }
}