﻿namespace WindowsFormsApplication1
{
    partial class frmDonViTinh
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
            this.colMADVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barIn,
            this.barNapLai,
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
            this.barNapLai.Id = 4;
            this.barNapLai.Name = "barNapLai";
            this.barNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNapLai_ItemClick);
            // 
            // barIn
            // 
            this.barIn.Caption = "In";
            this.barIn.Glyph = global::Quanlykho.Properties.Resources.printer1;
            this.barIn.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(815, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 440);
            this.barDockControlBottom.Size = new System.Drawing.Size(815, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(815, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 398);
            this.panelControl1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 392);
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
            this.colMADVT,
            this.colDONVITINH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMADVT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colMADVT
            // 
            this.colMADVT.Caption = "Mã ĐVT";
            this.colMADVT.FieldName = "MADVT";
            this.colMADVT.Name = "colMADVT";
            this.colMADVT.OptionsColumn.AllowEdit = false;
            this.colMADVT.OptionsColumn.ReadOnly = true;
            this.colMADVT.Visible = true;
            this.colMADVT.VisibleIndex = 0;
            // 
            // colDONVITINH
            // 
            this.colDONVITINH.Caption = "Đơn Vị Tính";
            this.colDONVITINH.FieldName = "DONVITINH";
            this.colDONVITINH.Name = "colDONVITINH";
            this.colDONVITINH.OptionsColumn.AllowEdit = false;
            this.colDONVITINH.Visible = true;
            this.colDONVITINH.VisibleIndex = 1;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 440);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDonViTinh";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDonViTinh_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private XUAT_NHAPTONDataSet11 xUAT_NHAPTONDataSet11;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet11TableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barThem;
        private DevExpress.XtraBars.BarButtonItem barXoa;
        private DevExpress.XtraBars.BarButtonItem barSua;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraBars.BarButtonItem barNapLai;
        private DevExpress.XtraBars.BarButtonItem barXuat;
        private DevExpress.XtraBars.BarButtonItem barNhap;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVITINH;

    }
}