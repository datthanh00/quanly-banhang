﻿namespace WindowsFormsApplication1
{
    partial class ThemMatHang
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
            this.cbNhomHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.calKLDVT = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtgiamua = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtmota = new DevExpress.XtraEditors.TextEdit();
            this.lbmota = new DevExpress.XtraEditors.LabelControl();
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btThemKhuVuc = new DevExpress.XtraEditors.SimpleButton();
            this.cbthue = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbDvt = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbDVT = new DevExpress.XtraEditors.LabelControl();
            this.lbmathue = new DevExpress.XtraEditors.LabelControl();
            this.lbtenmh = new DevExpress.XtraEditors.LabelControl();
            this.lbtinhtrang = new DevExpress.XtraEditors.LabelControl();
            this.lbmamh = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.lbCHUY = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.lbnhomhang = new DevExpress.XtraEditors.LabelControl();
            this.colmathue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsothue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmadvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtquycach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calKLDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiamua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbthue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquycach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNhomHang
            // 
            this.cbNhomHang.EditValue = "";
            this.cbNhomHang.Location = new System.Drawing.Point(129, 72);
            this.cbNhomHang.Name = "cbNhomHang";
            this.cbNhomHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNhomHang.Properties.DisplayMember = "MANH";
            this.cbNhomHang.Properties.NullText = "";
            this.cbNhomHang.Properties.ValueMember = "TENNHOMHANG";
            this.cbNhomHang.Properties.View = this.gridLookUpEdit1View;
            this.cbNhomHang.Size = new System.Drawing.Size(100, 20);
            this.cbNhomHang.TabIndex = 2;
            this.cbNhomHang.Validated += new System.EventHandler(this.cbNhomHang_Validated);
            this.cbNhomHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNhomHang_KeyPress);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmanh,
            this.colten});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtquycach);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.calKLDVT);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.txtmota);
            this.panelControl1.Controls.Add(this.lbmota);
            this.panelControl1.Controls.Add(this.checkTT);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.btThemKhuVuc);
            this.panelControl1.Controls.Add(this.cbthue);
            this.panelControl1.Controls.Add(this.cbDvt);
            this.panelControl1.Controls.Add(this.lbDVT);
            this.panelControl1.Controls.Add(this.lbmathue);
            this.panelControl1.Controls.Add(this.lbtenmh);
            this.panelControl1.Controls.Add(this.lbtinhtrang);
            this.panelControl1.Controls.Add(this.lbmamh);
            this.panelControl1.Controls.Add(this.txtMaMH);
            this.panelControl1.Controls.Add(this.txtTenMH);
            this.panelControl1.Controls.Add(this.lbCHUY);
            this.panelControl1.Controls.Add(this.labelControl19);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.cbNhomHang);
            this.panelControl1.Controls.Add(this.btLuu);
            this.panelControl1.Controls.Add(this.btDong);
            this.panelControl1.Controls.Add(this.lbnhomhang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(620, 347);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // calKLDVT
            // 
            this.calKLDVT.Location = new System.Drawing.Point(427, 102);
            this.calKLDVT.Name = "calKLDVT";
            this.calKLDVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calKLDVT.Properties.Mask.EditMask = "N0";
            this.calKLDVT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.calKLDVT.Size = new System.Drawing.Size(136, 20);
            this.calKLDVT.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(297, 106);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(98, 13);
            this.labelControl9.TabIndex = 163;
            this.labelControl9.Text = "Khối lượng theo ĐVT";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(408, 106);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 162;
            this.labelControl8.Text = "(*)";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtgiamua);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(20, 175);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(543, 70);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.TabStop = true;
            this.groupControl1.Text = "Thông tin giao dịch";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "(*)";
            // 
            // txtgiamua
            // 
            this.txtgiamua.Location = new System.Drawing.Point(111, 34);
            this.txtgiamua.Name = "txtgiamua";
            this.txtgiamua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtgiamua.Properties.Mask.EditMask = "N0";
            this.txtgiamua.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtgiamua.Size = new System.Drawing.Size(124, 20);
            this.txtgiamua.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giá Mua:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(111, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 160;
            this.labelControl4.Text = "(*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(109, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 13);
            this.labelControl3.TabIndex = 159;
            this.labelControl3.Text = "(*)";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(410, 76);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 157;
            this.labelControl14.Text = "(*)";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(128, 102);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(127, 20);
            this.txtmota.TabIndex = 6;
            this.txtmota.EditValueChanged += new System.EventHandler(this.txtmota_EditValueChanged);
            this.txtmota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbthue_KeyPress);
            // 
            // lbmota
            // 
            this.lbmota.Location = new System.Drawing.Point(22, 106);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(32, 13);
            this.lbmota.TabIndex = 153;
            this.lbmota.Text = "Mô Tả ";
            // 
            // checkTT
            // 
            this.checkTT.EditValue = true;
            this.checkTT.Location = new System.Drawing.Point(129, 135);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Kích Hoạt";
            this.checkTT.Size = new System.Drawing.Size(82, 19);
            this.checkTT.TabIndex = 8;
            this.checkTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkTT_KeyPress);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.BackgroundImage = global::Quanlykho.Properties.Resources.add;
            this.simpleButton3.Image = global::Quanlykho.Properties.Resources.plus;
            this.simpleButton3.Location = new System.Drawing.Point(538, 73);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(25, 19);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "simpleButton1";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // btThemKhuVuc
            // 
            this.btThemKhuVuc.Appearance.ForeColor = System.Drawing.Color.White;
            this.btThemKhuVuc.Appearance.Options.UseForeColor = true;
            this.btThemKhuVuc.BackgroundImage = global::Quanlykho.Properties.Resources.add;
            this.btThemKhuVuc.Image = global::Quanlykho.Properties.Resources.plus;
            this.btThemKhuVuc.Location = new System.Drawing.Point(538, 135);
            this.btThemKhuVuc.Name = "btThemKhuVuc";
            this.btThemKhuVuc.Size = new System.Drawing.Size(24, 19);
            this.btThemKhuVuc.TabIndex = 10;
            this.btThemKhuVuc.Text = "simpleButton1";
            this.btThemKhuVuc.Click += new System.EventHandler(this.btThemKhuVuc_Click_1);
            // 
            // cbthue
            // 
            this.cbthue.Location = new System.Drawing.Point(427, 134);
            this.cbthue.Name = "cbthue";
            this.cbthue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbthue.Properties.DisplayMember = "MATH";
            this.cbthue.Properties.NullText = "";
            this.cbthue.Properties.ValueMember = "SOTHUE";
            this.cbthue.Properties.View = this.gridView2;
            this.cbthue.Size = new System.Drawing.Size(111, 20);
            this.cbthue.TabIndex = 9;
            this.cbthue.EditValueChanged += new System.EventHandler(this.cbthue_EditValueChanged);
            this.cbthue.Validated += new System.EventHandler(this.cbthue_Validated);
            this.cbthue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbthue_KeyPress);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmathue,
            this.colsothue});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cbDvt
            // 
            this.cbDvt.Location = new System.Drawing.Point(427, 72);
            this.cbDvt.Name = "cbDvt";
            this.cbDvt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDvt.Properties.DisplayMember = "MADVT";
            this.cbDvt.Properties.NullText = "";
            this.cbDvt.Properties.ValueMember = "DONVITINH";
            this.cbDvt.Properties.View = this.gridView1;
            this.cbDvt.Size = new System.Drawing.Size(111, 20);
            this.cbDvt.TabIndex = 4;
            this.cbDvt.EditValueChanged += new System.EventHandler(this.cbDvt_EditValueChanged);
            this.cbDvt.Validated += new System.EventHandler(this.cbDvt_Validated);
            this.cbDvt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDvt_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmadvt,
            this.coldvt});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lbDVT
            // 
            this.lbDVT.Location = new System.Drawing.Point(315, 76);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(52, 13);
            this.lbDVT.TabIndex = 140;
            this.lbDVT.Text = "Đơn vị tính";
            // 
            // lbmathue
            // 
            this.lbmathue.Enabled = false;
            this.lbmathue.Location = new System.Drawing.Point(316, 138);
            this.lbmathue.Name = "lbmathue";
            this.lbmathue.Size = new System.Drawing.Size(41, 13);
            this.lbmathue.TabIndex = 136;
            this.lbmathue.Text = "Mã Thuế";
            // 
            // lbtenmh
            // 
            this.lbtenmh.Location = new System.Drawing.Point(25, 9);
            this.lbtenmh.Name = "lbtenmh";
            this.lbtenmh.Size = new System.Drawing.Size(66, 13);
            this.lbtenmh.TabIndex = 135;
            this.lbtenmh.Text = "Tên mặt hàng";
            // 
            // lbtinhtrang
            // 
            this.lbtinhtrang.Location = new System.Drawing.Point(22, 138);
            this.lbtinhtrang.Name = "lbtinhtrang";
            this.lbtinhtrang.Size = new System.Drawing.Size(49, 13);
            this.lbtinhtrang.TabIndex = 139;
            this.lbtinhtrang.Text = "Tình trạng";
            // 
            // lbmamh
            // 
            this.lbmamh.Location = new System.Drawing.Point(22, 39);
            this.lbmamh.Name = "lbmamh";
            this.lbmamh.Size = new System.Drawing.Size(62, 13);
            this.lbmamh.TabIndex = 138;
            this.lbmamh.Text = "Mã mặt hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(129, 35);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(125, 20);
            this.txtMaMH.TabIndex = 0;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(131, 5);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(432, 20);
            this.txtTenMH.TabIndex = 1;
            this.txtTenMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMH_KeyPress);
            // 
            // lbCHUY
            // 
            this.lbCHUY.Location = new System.Drawing.Point(176, 260);
            this.lbCHUY.Name = "lbCHUY";
            this.lbCHUY.Size = new System.Drawing.Size(246, 13);
            this.lbCHUY.TabIndex = 53;
            this.lbCHUY.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(153, 260);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 52;
            this.labelControl19.Text = "(*)";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.BackgroundImage = global::Quanlykho.Properties.Resources.add;
            this.simpleButton2.Image = global::Quanlykho.Properties.Resources.plus;
            this.simpleButton2.Location = new System.Drawing.Point(229, 73);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 19);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "simpleButton1";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btLuu.Location = new System.Drawing.Point(175, 289);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(95, 38);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close2;
            this.btDong.Location = new System.Drawing.Point(297, 289);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(98, 38);
            this.btDong.TabIndex = 13;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // lbnhomhang
            // 
            this.lbnhomhang.Location = new System.Drawing.Point(22, 76);
            this.lbnhomhang.Name = "lbnhomhang";
            this.lbnhomhang.Size = new System.Drawing.Size(65, 13);
            this.lbnhomhang.TabIndex = 0;
            this.lbnhomhang.Text = "Nhà cung cấp";
            // 
            // colmathue
            // 
            this.colmathue.Caption = "Mã Thuế";
            this.colmathue.FieldName = "MATH";
            this.colmathue.Name = "colmathue";
            this.colmathue.Visible = true;
            this.colmathue.VisibleIndex = 0;
            // 
            // colsothue
            // 
            this.colsothue.Caption = "Số Thuế";
            this.colsothue.FieldName = "SOTHUE";
            this.colsothue.Name = "colsothue";
            this.colsothue.Visible = true;
            this.colsothue.VisibleIndex = 1;
            // 
            // colmadvt
            // 
            this.colmadvt.Caption = "Mã DVT";
            this.colmadvt.FieldName = "MADVT";
            this.colmadvt.Name = "colmadvt";
            this.colmadvt.Visible = true;
            this.colmadvt.VisibleIndex = 0;
            // 
            // coldvt
            // 
            this.coldvt.Caption = "Đơn Vị Tính";
            this.coldvt.FieldName = "DONVITINH";
            this.coldvt.Name = "coldvt";
            this.coldvt.Visible = true;
            this.coldvt.VisibleIndex = 1;
            // 
            // colmanh
            // 
            this.colmanh.FieldName = "MANCC";
            this.colmanh.Name = "colmanh";
            this.colmanh.Visible = true;
            this.colmanh.VisibleIndex = 0;
            // 
            // colten
            // 
            this.colten.Caption = "gridColumn2";
            this.colten.FieldName = "TENNCC";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 1;
            // 
            // txtquycach
            // 
            this.txtquycach.Location = new System.Drawing.Point(425, 36);
            this.txtquycach.Name = "txtquycach";
            this.txtquycach.Size = new System.Drawing.Size(138, 20);
            this.txtquycach.TabIndex = 164;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(319, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 165;
            this.labelControl5.Text = "Quy Cách";
            // 
            // ThemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 347);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sửa Mặt Hàng";
            this.Load += new System.EventHandler(this.ThemMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calKLDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiamua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbthue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquycach.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cbNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.LabelControl lbnhomhang;
       //// private XUAT_NHAPTONDataSet25 xUAT_NHAPTONDataSet25;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet25TableAdapters.KHOTableAdapter kHOTableAdapter;
       // private XUAT_NHAPTONDataSet26 xUAT_NHAPTONDataSet26;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet26TableAdapters.NHOMHANGTableAdapter nHOMHANGTableAdapter;
       // private XUAT_NHAPTONDataSet27 xUAT_NHAPTONDataSet27;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet27TableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
       // private XUAT_NHAPTONDataSet31 xUAT_NHAPTONDataSet31;
       // private WindowsFormsApplication1.XUAT_NHAPTONDataSet31TableAdapters.THUETableAdapter tHUETableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl lbCHUY;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraGrid.Columns.GridColumn colmanh;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraEditors.CheckEdit checkTT;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btThemKhuVuc;
        private DevExpress.XtraEditors.GridLookUpEdit cbthue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colmathue;
        private DevExpress.XtraGrid.Columns.GridColumn colsothue;
        private DevExpress.XtraEditors.GridLookUpEdit cbDvt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmadvt;
        private DevExpress.XtraGrid.Columns.GridColumn coldvt;
        private DevExpress.XtraEditors.LabelControl lbDVT;
        private DevExpress.XtraEditors.LabelControl lbmathue;
        private DevExpress.XtraEditors.LabelControl lbtenmh;
        private DevExpress.XtraEditors.LabelControl lbtinhtrang;
        private DevExpress.XtraEditors.LabelControl lbmamh;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.LabelControl lbmota;
        private DevExpress.XtraEditors.TextEdit txtmota;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CalcEdit calKLDVT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit txtgiamua;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtquycach;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}