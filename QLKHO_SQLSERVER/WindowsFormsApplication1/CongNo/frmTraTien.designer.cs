namespace WindowsFormsApplication1
{
    partial class frmTraTien
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
            this.groupCtInFo = new DevExpress.XtraEditors.GroupControl();
            this.lbNV = new DevExpress.XtraEditors.LabelControl();
            this.lbNgaylap = new DevExpress.XtraEditors.LabelControl();
            this.lbPC = new DevExpress.XtraEditors.LabelControl();
            this.lbTienno = new DevExpress.XtraEditors.LabelControl();
            this.lbTratien = new DevExpress.XtraEditors.LabelControl();
            this.lbhdn = new DevExpress.XtraEditors.LabelControl();
            this.txtMahd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSTluu = new DevExpress.XtraBars.BarButtonItem();
            this.barstDong = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtNV = new DevExpress.XtraEditors.TextEdit();
            this.txtPC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienTra = new DevExpress.XtraEditors.CalcEdit();
            this.groupCtDetails = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuchi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhânviên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãhóađơnnhập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàychi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).BeginInit();
            this.groupCtInFo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).BeginInit();
            this.groupCtDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCtInFo
            // 
            this.groupCtInFo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupCtInFo.Appearance.Options.UseBackColor = true;
            this.groupCtInFo.Controls.Add(this.lbNV);
            this.groupCtInFo.Controls.Add(this.lbNgaylap);
            this.groupCtInFo.Controls.Add(this.lbPC);
            this.groupCtInFo.Controls.Add(this.lbTienno);
            this.groupCtInFo.Controls.Add(this.lbTratien);
            this.groupCtInFo.Controls.Add(this.lbhdn);
            this.groupCtInFo.Controls.Add(this.txtMahd);
            this.groupCtInFo.Controls.Add(this.txtSoTienNo);
            this.groupCtInFo.Controls.Add(this.txtNV);
            this.groupCtInFo.Controls.Add(this.txtPC);
            this.groupCtInFo.Controls.Add(this.dtNgayThu);
            this.groupCtInFo.Controls.Add(this.txtSoTienTra);
            this.groupCtInFo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtInFo.Location = new System.Drawing.Point(0, 42);
            this.groupCtInFo.Name = "groupCtInFo";
            this.groupCtInFo.Size = new System.Drawing.Size(829, 170);
            this.groupCtInFo.TabIndex = 6;
            this.groupCtInFo.Text = "Thông tin trả tiền";
            // 
            // lbNV
            // 
            this.lbNV.Location = new System.Drawing.Point(358, 117);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(52, 13);
            this.lbNV.TabIndex = 47;
            this.lbNV.Text = "Nhân viên:";
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Location = new System.Drawing.Point(358, 77);
            this.lbNgaylap.Name = "lbNgaylap";
            this.lbNgaylap.Size = new System.Drawing.Size(45, 13);
            this.lbNgaylap.TabIndex = 47;
            this.lbNgaylap.Text = "Ngày chi:";
            // 
            // lbPC
            // 
            this.lbPC.Location = new System.Drawing.Point(358, 30);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(46, 13);
            this.lbPC.TabIndex = 47;
            this.lbPC.Text = "Phiếu chi:";
            // 
            // lbTienno
            // 
            this.lbTienno.Location = new System.Drawing.Point(10, 117);
            this.lbTienno.Name = "lbTienno";
            this.lbTienno.Size = new System.Drawing.Size(52, 13);
            this.lbTienno.TabIndex = 47;
            this.lbTienno.Text = "Số tiền nợ:";
            // 
            // lbTratien
            // 
            this.lbTratien.Location = new System.Drawing.Point(10, 77);
            this.lbTratien.Name = "lbTratien";
            this.lbTratien.Size = new System.Drawing.Size(54, 13);
            this.lbTratien.TabIndex = 47;
            this.lbTratien.Text = "Số tiền trả:";
            // 
            // lbhdn
            // 
            this.lbhdn.Location = new System.Drawing.Point(10, 31);
            this.lbhdn.Name = "lbhdn";
            this.lbhdn.Size = new System.Drawing.Size(71, 13);
            this.lbhdn.TabIndex = 47;
            this.lbhdn.Text = "Hóa đơn nhập:";
            // 
            // txtMahd
            // 
            this.txtMahd.Enabled = false;
            this.txtMahd.Location = new System.Drawing.Point(132, 29);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Properties.Mask.EditMask = "n0";
            this.txtMahd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMahd.Size = new System.Drawing.Size(200, 20);
            this.txtMahd.TabIndex = 46;
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Enabled = false;
            this.txtSoTienNo.Location = new System.Drawing.Point(132, 113);
            this.txtSoTienNo.MenuManager = this.barManager1;
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Properties.Mask.EditMask = "n0";
            this.txtSoTienNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoTienNo.Size = new System.Drawing.Size(200, 20);
            this.txtSoTienNo.TabIndex = 46;
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
            this.barSTluu,
            this.barstDong,
            this.barIn});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSTluu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barstDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSTluu
            // 
            this.barSTluu.Caption = "Lưu";
            this.barSTluu.Glyph = global::WindowsFormsApplication1.Properties.Resources.save1;
            this.barSTluu.Id = 0;
            this.barSTluu.Name = "barSTluu";
            this.barSTluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSTluu_ItemClick);
            // 
            // barstDong
            // 
            this.barstDong.Caption = "Đóng";
            this.barstDong.Glyph = global::WindowsFormsApplication1.Properties.Resources.close;
            this.barstDong.Id = 1;
            this.barstDong.Name = "barstDong";
            this.barstDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barstDong_ItemClick);
            // 
            // barIn
            // 
            this.barIn.Caption = "In";
            this.barIn.Glyph = global::WindowsFormsApplication1.Properties.Resources.printer1;
            this.barIn.Id = 2;
            this.barIn.Name = "barIn";
            this.barIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(829, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Size = new System.Drawing.Size(829, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(829, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(489, 113);
            this.txtNV.MenuManager = this.barManager1;
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(165, 20);
            this.txtNV.TabIndex = 45;
            // 
            // txtPC
            // 
            // 
            // 
            // 
            this.txtPC.Border.Class = "TextBoxBorder";
            this.txtPC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPC.Enabled = false;
            this.txtPC.Location = new System.Drawing.Point(489, 29);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(165, 21);
            this.txtPC.TabIndex = 43;
            // 
            // dtNgayThu
            // 
            this.dtNgayThu.CustomFormat = "dddd dd/MM/yyyy";
            this.dtNgayThu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThu.Location = new System.Drawing.Point(489, 75);
            this.dtNgayThu.Name = "dtNgayThu";
            this.dtNgayThu.Size = new System.Drawing.Size(165, 23);
            this.dtNgayThu.TabIndex = 40;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(132, 75);
            this.txtSoTienTra.MenuManager = this.barManager1;
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienTra.Properties.Mask.EditMask = "n0";
            this.txtSoTienTra.Size = new System.Drawing.Size(200, 20);
            this.txtSoTienTra.TabIndex = 44;
            this.txtSoTienTra.TextChanged += new System.EventHandler(this.txtSoTienTra_TextChanged_1);
            // 
            // groupCtDetails
            // 
            this.groupCtDetails.Controls.Add(this.gridControl1);
            this.groupCtDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCtDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCtDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupCtDetails.Location = new System.Drawing.Point(0, 212);
            this.groupCtDetails.Name = "groupCtDetails";
            this.groupCtDetails.Size = new System.Drawing.Size(829, 249);
            this.groupCtDetails.TabIndex = 41;
            this.groupCtDetails.TabStop = false;
            this.groupCtDetails.Text = "Chi tiết";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(823, 227);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếuchi,
            this.colMãnhânviên,
            this.colMãhóađơnnhập,
            this.colNgàychi,
            this.colTiềnđãtrả});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colMãphiếuchi
            // 
            this.colMãphiếuchi.Caption = "Mã Phiếu Chi";
            this.colMãphiếuchi.FieldName = "MAPC";
            this.colMãphiếuchi.Name = "colMãphiếuchi";
            this.colMãphiếuchi.Visible = true;
            this.colMãphiếuchi.VisibleIndex = 0;
            // 
            // colMãnhânviên
            // 
            this.colMãnhânviên.Caption = "Mã Nhân Viên";
            this.colMãnhânviên.FieldName = "MANV";
            this.colMãnhânviên.Name = "colMãnhânviên";
            this.colMãnhânviên.Visible = true;
            this.colMãnhânviên.VisibleIndex = 1;
            // 
            // colMãhóađơnnhập
            // 
            this.colMãhóađơnnhập.Caption = "Mã Hóa Đơn Nhập";
            this.colMãhóađơnnhập.FieldName = "MAHDN";
            this.colMãhóađơnnhập.Name = "colMãhóađơnnhập";
            this.colMãhóađơnnhập.Visible = true;
            this.colMãhóađơnnhập.VisibleIndex = 2;
            // 
            // colNgàychi
            // 
            this.colNgàychi.Caption = "Ngày Chi";
            this.colNgàychi.FieldName = "NGAYCHI";
            this.colNgàychi.Name = "colNgàychi";
            this.colNgàychi.Visible = true;
            this.colNgàychi.VisibleIndex = 3;
            // 
            // colTiềnđãtrả
            // 
            this.colTiềnđãtrả.Caption = "Tiền Đã Trả";
            this.colTiềnđãtrả.DisplayFormat.FormatString = "0,0";
            this.colTiềnđãtrả.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiềnđãtrả.FieldName = "TIENDATRA";
            this.colTiềnđãtrả.Name = "colTiềnđãtrả";
            this.colTiềnđãtrả.Visible = true;
            this.colTiềnđãtrả.VisibleIndex = 4;
            // 
            // frmTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.groupCtInFo);
            this.Controls.Add(this.groupCtDetails);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTraTien";
            this.Text = "frmTraTien";
            this.Load += new System.EventHandler(this.frmTraTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).EndInit();
            this.groupCtInFo.ResumeLayout(false);
            this.groupCtInFo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).EndInit();
            this.groupCtDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtInFo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPC;
        private System.Windows.Forms.GroupBox groupCtDetails;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker dtNgayThu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barSTluu;
        private DevExpress.XtraBars.BarButtonItem barstDong;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếuchi;
        private DevExpress.XtraGrid.Columns.GridColumn colMãnhânviên;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnnhập;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàychi;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả;
        private DevExpress.XtraEditors.TextEdit txtNV;
        private DevExpress.XtraEditors.CalcEdit txtSoTienTra;
        private DevExpress.XtraEditors.TextEdit txtMahd;
        private DevExpress.XtraEditors.TextEdit txtSoTienNo;
        private DevExpress.XtraEditors.LabelControl lbPC;
        private DevExpress.XtraEditors.LabelControl lbTienno;
        private DevExpress.XtraEditors.LabelControl lbTratien;
        private DevExpress.XtraEditors.LabelControl lbhdn;
        private DevExpress.XtraEditors.LabelControl lbNgaylap;
        private DevExpress.XtraEditors.LabelControl lbNV;
    }
}