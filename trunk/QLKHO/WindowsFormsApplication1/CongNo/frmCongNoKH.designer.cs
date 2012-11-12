namespace WindowsFormsApplication1
{
    partial class frmCongNoKH
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãhóađơnxuất = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênkháchhàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãkháchhàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnphảitrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCònlại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gETONEPTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhânviên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãhóađơnxuất1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàythu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barThuTien = new DevExpress.XtraBars.BarButtonItem();
            this.barSuaTien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETONEPTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1171, 186);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãhóađơnxuất,
            this.colTênkháchhàng,
            this.colMãkháchhàng,
            this.colTiềnphảitrả,
            this.colTiềnđãtrả,
            this.colCònlại});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTênkháchhàng, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMãhóađơnxuất
            // 
            this.colMãhóađơnxuất.FieldName = "Mã hóa đơn xuất";
            this.colMãhóađơnxuất.Name = "colMãhóađơnxuất";
            this.colMãhóađơnxuất.Visible = true;
            this.colMãhóađơnxuất.VisibleIndex = 0;
            // 
            // colTênkháchhàng
            // 
            this.colTênkháchhàng.FieldName = "Tên khách hàng";
            this.colTênkháchhàng.Name = "colTênkháchhàng";
            this.colTênkháchhàng.Visible = true;
            this.colTênkháchhàng.VisibleIndex = 1;
            // 
            // colMãkháchhàng
            // 
            this.colMãkháchhàng.FieldName = "Mã khách hàng";
            this.colMãkháchhàng.Name = "colMãkháchhàng";
            this.colMãkháchhàng.Visible = true;
            this.colMãkháchhàng.VisibleIndex = 1;
            // 
            // colTiềnphảitrả
            // 
            this.colTiềnphảitrả.DisplayFormat.FormatString = "0,0";
            this.colTiềnphảitrả.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnphảitrả.FieldName = "Tiền phải trả";
            this.colTiềnphảitrả.Name = "colTiềnphảitrả";
            this.colTiềnphảitrả.SummaryItem.DisplayFormat = "Tổng tiền phải tra:{0:0,0 vnđ}";
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
            this.colTiềnđãtrả.SummaryItem.DisplayFormat = "Tổng tiền đã trả:{0:0,0 vnđ}";
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
            this.colCònlại.SummaryItem.DisplayFormat = "Tổng tiền còn nợ:{0:0,0 vnđ}";
            this.colCònlại.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCònlại.Visible = true;
            this.colCònlại.VisibleIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1175, 209);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Công nợ Khách Hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 251);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1175, 242);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Tiền thu Khách hàng";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.gETONEPTBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1171, 219);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gETONEPTBindingSource1
            // 
            this.gETONEPTBindingSource1.DataMember = "GETONEPT";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếuthu,
            this.colMãnhânviên,
            this.colMãhóađơnxuất1,
            this.colNgàythu,
            this.colTiềnđãtrả1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colMãphiếuthu
            // 
            this.colMãphiếuthu.FieldName = "Mã phiếu thu";
            this.colMãphiếuthu.Name = "colMãphiếuthu";
            this.colMãphiếuthu.Visible = true;
            this.colMãphiếuthu.VisibleIndex = 0;
            // 
            // colMãnhânviên
            // 
            this.colMãnhânviên.FieldName = "Mã nhân viên";
            this.colMãnhânviên.Name = "colMãnhânviên";
            this.colMãnhânviên.Visible = true;
            this.colMãnhânviên.VisibleIndex = 1;
            // 
            // colMãhóađơnxuất1
            // 
            this.colMãhóađơnxuất1.FieldName = "Mã hóa đơn xuất";
            this.colMãhóađơnxuất1.Name = "colMãhóađơnxuất1";
            this.colMãhóađơnxuất1.Visible = true;
            this.colMãhóađơnxuất1.VisibleIndex = 2;
            // 
            // colNgàythu
            // 
            this.colNgàythu.FieldName = "Ngày thu";
            this.colNgàythu.Name = "colNgàythu";
            this.colNgàythu.Visible = true;
            this.colNgàythu.VisibleIndex = 3;
            // 
            // colTiềnđãtrả1
            // 
            this.colTiềnđãtrả1.DisplayFormat.FormatString = "0,0";
            this.colTiềnđãtrả1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnđãtrả1.FieldName = "Tiền đã trả";
            this.colTiềnđãtrả1.Name = "colTiềnđãtrả1";
            this.colTiềnđãtrả1.SummaryItem.DisplayFormat = "{0:0,0 vnđ}";
            this.colTiềnđãtrả1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTiềnđãtrả1.Visible = true;
            this.colTiềnđãtrả1.VisibleIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barThuTien,
            this.barSuaTien,
            this.barBtDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barThuTien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSuaTien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barThuTien
            // 
            this.barThuTien.Caption = "Thu tiền";
            this.barThuTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.barThuTien.Id = 0;
            this.barThuTien.Name = "barThuTien";
            this.barThuTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThuTien_ItemClick);
            // 
            // barSuaTien
            // 
            this.barSuaTien.Caption = "Sửa tiền thêm";
            this.barSuaTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.barSuaTien.Id = 1;
            this.barSuaTien.Name = "barSuaTien";
            this.barSuaTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSuaTien_ItemClick);
            // 
            // barBtDong
            // 
            this.barBtDong.Caption = "Đóng";
            this.barBtDong.Glyph = global::WindowsFormsApplication1.Properties.Resources.close;
            this.barBtDong.Id = 2;
            this.barBtDong.Name = "barBtDong";
            this.barBtDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1175, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 493);
            this.barDockControlBottom.Size = new System.Drawing.Size(1175, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1175, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // frmCongNoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 493);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongNoKH";
            this.Text = "frmCongNoKH";
            this.Load += new System.EventHandler(this.frmCongNoKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETONEPTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barThuTien;
        private DevExpress.XtraBars.BarButtonItem barSuaTien;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnxuất;
        private DevExpress.XtraGrid.Columns.GridColumn colTênkháchhàng;
        private DevExpress.XtraGrid.Columns.GridColumn colMãkháchhàng;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnphảitrả;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả;
        private DevExpress.XtraGrid.Columns.GridColumn colCònlại;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet3TableAdapters.GETONEPTTableAdapter gETONEPTTableAdapter;
        private System.Windows.Forms.BindingSource gETONEPTBindingSource1;
       // private XUAT_NHAPTONDataSet4 xUAT_NHAPTONDataSet4;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếuthu;
        private DevExpress.XtraGrid.Columns.GridColumn colMãnhânviên;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnxuất1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàythu;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả1;
        private DevExpress.XtraBars.BarButtonItem barBtDong;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet4TableAdapters.GETONEPTTableAdapter gETONEPTTableAdapter1;
    }
}