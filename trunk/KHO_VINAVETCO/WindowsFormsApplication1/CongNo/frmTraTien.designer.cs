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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbNV = new DevExpress.XtraEditors.LabelControl();
            this.lbNgaylap = new DevExpress.XtraEditors.LabelControl();
            this.lbPC = new DevExpress.XtraEditors.LabelControl();
            this.lbTienno = new DevExpress.XtraEditors.LabelControl();
            this.lbTratien = new DevExpress.XtraEditors.LabelControl();
            this.txttenncc = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSTluu = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtNV = new DevExpress.XtraEditors.TextEdit();
            this.txtPC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienTra = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).BeginInit();
            this.groupCtInFo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCtInFo
            // 
            this.groupCtInFo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupCtInFo.Appearance.Options.UseBackColor = true;
            this.groupCtInFo.Controls.Add(this.labelControl1);
            this.groupCtInFo.Controls.Add(this.lbNV);
            this.groupCtInFo.Controls.Add(this.lbNgaylap);
            this.groupCtInFo.Controls.Add(this.lbPC);
            this.groupCtInFo.Controls.Add(this.lbTienno);
            this.groupCtInFo.Controls.Add(this.lbTratien);
            this.groupCtInFo.Controls.Add(this.txttenncc);
            this.groupCtInFo.Controls.Add(this.txtSoTienNo);
            this.groupCtInFo.Controls.Add(this.txtNV);
            this.groupCtInFo.Controls.Add(this.txtPC);
            this.groupCtInFo.Controls.Add(this.dtNgayThu);
            this.groupCtInFo.Controls.Add(this.txtSoTienTra);
            this.groupCtInFo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtInFo.Location = new System.Drawing.Point(0, 42);
            this.groupCtInFo.Name = "groupCtInFo";
            this.groupCtInFo.Size = new System.Drawing.Size(829, 165);
            this.groupCtInFo.TabIndex = 6;
            this.groupCtInFo.Text = "Thông tin Chi tiền";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Nhà Cung Cấp:";
            // 
            // lbNV
            // 
            this.lbNV.Location = new System.Drawing.Point(517, 111);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(52, 13);
            this.lbNV.TabIndex = 47;
            this.lbNV.Text = "Nhân viên:";
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Location = new System.Drawing.Point(519, 72);
            this.lbNgaylap.Name = "lbNgaylap";
            this.lbNgaylap.Size = new System.Drawing.Size(45, 13);
            this.lbNgaylap.TabIndex = 47;
            this.lbNgaylap.Text = "Ngày chi:";
            // 
            // lbPC
            // 
            this.lbPC.Location = new System.Drawing.Point(518, 33);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(46, 13);
            this.lbPC.TabIndex = 47;
            this.lbPC.Text = "Phiếu chi:";
            // 
            // lbTienno
            // 
            this.lbTienno.Location = new System.Drawing.Point(11, 111);
            this.lbTienno.Name = "lbTienno";
            this.lbTienno.Size = new System.Drawing.Size(52, 13);
            this.lbTienno.TabIndex = 47;
            this.lbTienno.Text = "Số tiền nợ:";
            // 
            // lbTratien
            // 
            this.lbTratien.Location = new System.Drawing.Point(12, 72);
            this.lbTratien.Name = "lbTratien";
            this.lbTratien.Size = new System.Drawing.Size(55, 13);
            this.lbTratien.TabIndex = 47;
            this.lbTratien.Text = "Số tiền Chi:";
            // 
            // txttenncc
            // 
            this.txttenncc.Enabled = false;
            this.txttenncc.Location = new System.Drawing.Point(131, 29);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Properties.Mask.EditMask = "n0";
            this.txttenncc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttenncc.Properties.ReadOnly = true;
            this.txttenncc.Size = new System.Drawing.Size(351, 20);
            this.txttenncc.TabIndex = 46;
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Enabled = false;
            this.txtSoTienNo.Location = new System.Drawing.Point(131, 107);
            this.txtSoTienNo.MenuManager = this.barManager1;
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtSoTienNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienNo.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtSoTienNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienNo.Properties.Mask.EditMask = "n0";
            this.txtSoTienNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoTienNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoTienNo.Properties.ReadOnly = true;
            this.txtSoTienNo.Size = new System.Drawing.Size(246, 20);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSTluu
            // 
            this.barSTluu.Caption = "Lưu";
            this.barSTluu.Glyph = global::Quanlykho.Properties.Resources.save1;
            this.barSTluu.Id = 0;
            this.barSTluu.Name = "barSTluu";
            this.barSTluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSTluu_ItemClick);
            // 
            // barIn
            // 
            this.barIn.Caption = "In";
            this.barIn.Glyph = global::Quanlykho.Properties.Resources.printer1;
            this.barIn.Id = 2;
            this.barIn.Name = "barIn";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 207);
            this.barDockControlBottom.Size = new System.Drawing.Size(829, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 165);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(829, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 165);
            // 
            // txtNV
            // 
            this.txtNV.Enabled = false;
            this.txtNV.Location = new System.Drawing.Point(621, 107);
            this.txtNV.MenuManager = this.barManager1;
            this.txtNV.Name = "txtNV";
            this.txtNV.Properties.ReadOnly = true;
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
            this.txtPC.Location = new System.Drawing.Point(622, 29);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(165, 21);
            this.txtPC.TabIndex = 43;
            // 
            // dtNgayThu
            // 
            this.dtNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThu.Enabled = false;
            this.dtNgayThu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThu.Location = new System.Drawing.Point(622, 71);
            this.dtNgayThu.Name = "dtNgayThu";
            this.dtNgayThu.Size = new System.Drawing.Size(165, 23);
            this.dtNgayThu.TabIndex = 40;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(131, 68);
            this.txtSoTienTra.MenuManager = this.barManager1;
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienTra.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtSoTienTra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienTra.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtSoTienTra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienTra.Properties.Mask.EditMask = "n0";
            this.txtSoTienTra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoTienTra.Size = new System.Drawing.Size(246, 20);
            this.txtSoTienTra.TabIndex = 44;
            this.txtSoTienTra.TextChanged += new System.EventHandler(this.txtSoTienTra_TextChanged_1);
            // 
            // frmTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 207);
            this.Controls.Add(this.groupCtInFo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTraTien";
            this.Text = "Phiếu Chi";
            this.Load += new System.EventHandler(this.frmTraTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).EndInit();
            this.groupCtInFo.ResumeLayout(false);
            this.groupCtInFo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCtInFo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPC;
        private System.Windows.Forms.DateTimePicker dtNgayThu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barSTluu;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraEditors.TextEdit txtNV;
        private DevExpress.XtraEditors.CalcEdit txtSoTienTra;
        private DevExpress.XtraEditors.TextEdit txttenncc;
        private DevExpress.XtraEditors.TextEdit txtSoTienNo;
        private DevExpress.XtraEditors.LabelControl lbPC;
        private DevExpress.XtraEditors.LabelControl lbTienno;
        private DevExpress.XtraEditors.LabelControl lbTratien;
        private DevExpress.XtraEditors.LabelControl lbNgaylap;
        private DevExpress.XtraEditors.LabelControl lbNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}