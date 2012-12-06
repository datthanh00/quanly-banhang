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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuchi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhânviên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãhóađơnnhập1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàychi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCnncc = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãhóađơnnhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênnhàcungcấp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhàcungcấp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnphảitrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCònlại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barTraTien = new DevExpress.XtraBars.BarSubItem();
            this.barSuaTien = new DevExpress.XtraBars.BarSubItem();
            this.barBtDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCnncc)).BeginInit();
            this.groupCnncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(0, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1290, 201);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Tiền trả Nhà cung cấp";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1286, 178);
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
            // groupCnncc
            // 
            this.groupCnncc.Controls.Add(this.gridControl1);
            this.groupCnncc.Location = new System.Drawing.Point(0, 249);
            this.groupCnncc.Name = "groupCnncc";
            this.groupCnncc.Size = new System.Drawing.Size(1288, 261);
            this.groupCnncc.TabIndex = 4;
            this.groupCnncc.Text = "Công nợ Nhà Cung cấp";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1284, 238);
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
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 42);
            this.barDockControlTop.Size = new System.Drawing.Size(1292, 67);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(329, 209);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barTraTien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSuaTien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barTraTien
            // 
            this.barTraTien.Caption = "Trả tiền";
            this.barTraTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.barTraTien.Id = 0;
            this.barTraTien.Name = "barTraTien";
            this.barTraTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTraTien_ItemClick);
            // 
            // barSuaTien
            // 
            this.barSuaTien.Caption = "Sửa tiền đã trả";
            this.barSuaTien.Glyph = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.barSuaTien.Id = 1;
            this.barSuaTien.Name = "barSuaTien";
            this.barSuaTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSuaTien_ItemClick);
            // 
            // barBtDong
            // 
            this.barBtDong.Caption = "Đóng";
            this.barBtDong.Glyph = global::WindowsFormsApplication1.Properties.Resources.close1;
            this.barBtDong.Id = 3;
            this.barBtDong.Name = "barBtDong";
            this.barBtDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1292, 42);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 469);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1292, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 469);
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
            // frmCongNoNcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 511);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupCnncc);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongNoNcc";
            this.Text = "frmCongNoNcc";
            this.Load += new System.EventHandler(this.frmCongNoNcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCnncc)).EndInit();
            this.groupCnncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupCnncc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
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
    }
}