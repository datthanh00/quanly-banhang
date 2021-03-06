﻿namespace WindowsFormsApplication1
{
    partial class FrmThuTien
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
            this.barSTluu = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupCtInFo = new DevExpress.XtraEditors.GroupControl();
            this.txtSoTienNo = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbNV = new DevExpress.XtraEditors.LabelControl();
            this.lbNgaylap = new DevExpress.XtraEditors.LabelControl();
            this.lbPT = new DevExpress.XtraEditors.LabelControl();
            this.lbTienno = new DevExpress.XtraEditors.LabelControl();
            this.lbTratien = new DevExpress.XtraEditors.LabelControl();
            this.txtenkh = new DevExpress.XtraEditors.TextEdit();
            this.txtNV = new DevExpress.XtraEditors.TextEdit();
            this.txtPT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienTra = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).BeginInit();
            this.groupCtInFo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).BeginInit();
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
            this.barIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIn_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 216);
            this.barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 174);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(832, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 174);
            // 
            // groupCtInFo
            // 
            this.groupCtInFo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupCtInFo.Appearance.Options.UseBackColor = true;
            this.groupCtInFo.Controls.Add(this.txtSoTienNo);
            this.groupCtInFo.Controls.Add(this.labelControl1);
            this.groupCtInFo.Controls.Add(this.lbNV);
            this.groupCtInFo.Controls.Add(this.lbNgaylap);
            this.groupCtInFo.Controls.Add(this.lbPT);
            this.groupCtInFo.Controls.Add(this.lbTienno);
            this.groupCtInFo.Controls.Add(this.lbTratien);
            this.groupCtInFo.Controls.Add(this.txtenkh);
            this.groupCtInFo.Controls.Add(this.txtNV);
            this.groupCtInFo.Controls.Add(this.txtPT);
            this.groupCtInFo.Controls.Add(this.dtNgayThu);
            this.groupCtInFo.Controls.Add(this.txtSoTienTra);
            this.groupCtInFo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCtInFo.Location = new System.Drawing.Point(0, 42);
            this.groupCtInFo.Name = "groupCtInFo";
            this.groupCtInFo.Size = new System.Drawing.Size(832, 154);
            this.groupCtInFo.TabIndex = 5;
            this.groupCtInFo.Text = "Thông tin thu tiền";
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Location = new System.Drawing.Point(101, 100);
            this.txtSoTienNo.MenuManager = this.barManager1;
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienNo.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtSoTienNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienNo.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtSoTienNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienNo.Properties.Mask.EditMask = "n0";
            this.txtSoTienNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSoTienNo.Properties.ReadOnly = true;
            this.txtSoTienNo.Size = new System.Drawing.Size(252, 20);
            this.txtSoTienNo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Khách Hàng:";
            // 
            // lbNV
            // 
            this.lbNV.Location = new System.Drawing.Point(514, 104);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(52, 13);
            this.lbNV.TabIndex = 0;
            this.lbNV.Text = "Nhân viên:";
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Location = new System.Drawing.Point(519, 67);
            this.lbNgaylap.Name = "lbNgaylap";
            this.lbNgaylap.Size = new System.Drawing.Size(48, 13);
            this.lbNgaylap.TabIndex = 0;
            this.lbNgaylap.Text = "Ngày thu:";
            // 
            // lbPT
            // 
            this.lbPT.Location = new System.Drawing.Point(514, 32);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(49, 13);
            this.lbPT.TabIndex = 0;
            this.lbPT.Text = "Phiếu thu:";
            // 
            // lbTienno
            // 
            this.lbTienno.Location = new System.Drawing.Point(10, 104);
            this.lbTienno.Name = "lbTienno";
            this.lbTienno.Size = new System.Drawing.Size(52, 13);
            this.lbTienno.TabIndex = 0;
            this.lbTienno.Text = "Số tiền nợ:";
            // 
            // lbTratien
            // 
            this.lbTratien.Location = new System.Drawing.Point(11, 67);
            this.lbTratien.Name = "lbTratien";
            this.lbTratien.Size = new System.Drawing.Size(56, 13);
            this.lbTratien.TabIndex = 0;
            this.lbTratien.Text = "Số tiền thu:";
            // 
            // txtenkh
            // 
            this.txtenkh.Location = new System.Drawing.Point(101, 28);
            this.txtenkh.Name = "txtenkh";
            this.txtenkh.Properties.DisplayFormat.FormatString = "0,0";
            this.txtenkh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtenkh.Properties.Mask.EditMask = "n0";
            this.txtenkh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtenkh.Properties.ReadOnly = true;
            this.txtenkh.Size = new System.Drawing.Size(298, 20);
            this.txtenkh.TabIndex = 0;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(595, 100);
            this.txtNV.MenuManager = this.barManager1;
            this.txtNV.Name = "txtNV";
            this.txtNV.Properties.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(167, 20);
            this.txtNV.TabIndex = 0;
            // 
            // txtPT
            // 
            // 
            // 
            // 
            this.txtPT.Border.Class = "TextBoxBorder";
            this.txtPT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPT.Location = new System.Drawing.Point(595, 28);
            this.txtPT.Name = "txtPT";
            this.txtPT.ReadOnly = true;
            this.txtPT.Size = new System.Drawing.Size(165, 21);
            this.txtPT.TabIndex = 0;
            // 
            // dtNgayThu
            // 
            this.dtNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThu.Enabled = false;
            this.dtNgayThu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThu.Location = new System.Drawing.Point(595, 62);
            this.dtNgayThu.Name = "dtNgayThu";
            this.dtNgayThu.Size = new System.Drawing.Size(167, 23);
            this.dtNgayThu.TabIndex = 0;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(101, 63);
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
            this.txtSoTienTra.Size = new System.Drawing.Size(252, 20);
            this.txtSoTienTra.TabIndex = 1;
            // 
            // FrmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 216);
            this.Controls.Add(this.groupCtInFo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmThuTien";
            this.Text = "Phiếu Thu";
            this.Load += new System.EventHandler(this.FrmThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtInFo)).EndInit();
            this.groupCtInFo.ResumeLayout(false);
            this.groupCtInFo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barSTluu;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraEditors.GroupControl groupCtInFo;
        private System.Windows.Forms.DateTimePicker dtNgayThu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPT;
        private DevExpress.XtraEditors.TextEdit txtNV;
        private DevExpress.XtraEditors.CalcEdit txtSoTienTra;
        private DevExpress.XtraEditors.TextEdit txtenkh;
        private DevExpress.XtraEditors.LabelControl lbNgaylap;
        private DevExpress.XtraEditors.LabelControl lbPT;
        private DevExpress.XtraEditors.LabelControl lbTienno;
        private DevExpress.XtraEditors.LabelControl lbTratien;
        private DevExpress.XtraEditors.LabelControl lbNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txtSoTienNo;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet5TableAdapters.GETONEPTTableAdapter gETONEPTTableAdapter;
    }
}