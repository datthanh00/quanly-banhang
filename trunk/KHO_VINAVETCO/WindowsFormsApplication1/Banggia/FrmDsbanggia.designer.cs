namespace WindowsFormsApplication1
{
    partial class FrmDsbanggia
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
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.barXóa = new DevExpress.XtraBars.BarButtonItem();
            this.barsua = new DevExpress.XtraBars.BarButtonItem();
            this.barstDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàythu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCtDetails = new System.Windows.Forms.GroupBox();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupCtDetails.SuspendLayout();
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
            this.barsua,
            this.barstDong,
            this.barXóa,
            this.btnthem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barXóa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barstDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Glyph = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btnthem.Id = 3;
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // barXóa
            // 
            this.barXóa.Caption = "Xóa";
            this.barXóa.Glyph = global::WindowsFormsApplication1.Properties.Resources.close3;
            this.barXóa.Id = 2;
            this.barXóa.Name = "barXóa";
            this.barXóa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barXóa_ItemClick);
            // 
            // barsua
            // 
            this.barsua.Caption = "Sửa";
            this.barsua.Glyph = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.barsua.Id = 0;
            this.barsua.Name = "barsua";
            this.barsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barsua_ItemClick);
            // 
            // barstDong
            // 
            this.barstDong.Caption = "Đóng";
            this.barstDong.Glyph = global::WindowsFormsApplication1.Properties.Resources.cancel;
            this.barstDong.Id = 1;
            this.barstDong.Name = "barstDong";
            this.barstDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barstDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(832, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 366);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(832, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 366);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(826, 338);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếuthu,
            this.colNgàythu,
            this.colTiềnđãtrả});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMãphiếuthu
            // 
            this.colMãphiếuthu.Caption = "Mã Bảng Giá";
            this.colMãphiếuthu.FieldName = "MABG";
            this.colMãphiếuthu.Name = "colMãphiếuthu";
            this.colMãphiếuthu.Visible = true;
            this.colMãphiếuthu.VisibleIndex = 0;
            // 
            // colNgàythu
            // 
            this.colNgàythu.Caption = "Tên Bảng Giá";
            this.colNgàythu.FieldName = "TENBG";
            this.colNgàythu.Name = "colNgàythu";
            this.colNgàythu.Visible = true;
            this.colNgàythu.VisibleIndex = 1;
            // 
            // colTiềnđãtrả
            // 
            this.colTiềnđãtrả.Caption = "Ghi Chú";
            this.colTiềnđãtrả.FieldName = "GHICHI";
            this.colTiềnđãtrả.Name = "colTiềnđãtrả";
            this.colTiềnđãtrả.Visible = true;
            this.colTiềnđãtrả.VisibleIndex = 2;
            // 
            // groupCtDetails
            // 
            this.groupCtDetails.Controls.Add(this.gridControl1);
            this.groupCtDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCtDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCtDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupCtDetails.Location = new System.Drawing.Point(0, 48);
            this.groupCtDetails.Name = "groupCtDetails";
            this.groupCtDetails.Size = new System.Drawing.Size(832, 360);
            this.groupCtDetails.TabIndex = 41;
            this.groupCtDetails.TabStop = false;
            this.groupCtDetails.Text = "Danh Sách Bảng Giá";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In";
            this.barButtonItem1.Glyph = global::WindowsFormsApplication1.Properties.Resources.close3;
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "In";
            this.barButtonItem2.Glyph = global::WindowsFormsApplication1.Properties.Resources.close3;
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmDsbanggia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 408);
            this.Controls.Add(this.groupCtDetails);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDsbanggia";
            this.Text = "Danh Sách Bảng Giá";
            this.Load += new System.EventHandler(this.FrmDsbanggia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupCtDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barsua;
        private DevExpress.XtraBars.BarButtonItem barstDong;
        private DevExpress.XtraBars.BarButtonItem barXóa;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private System.Windows.Forms.GroupBox groupCtDetails;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếuthu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàythu;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet5TableAdapters.GETONEPTTableAdapter gETONEPTTableAdapter;
    }
}