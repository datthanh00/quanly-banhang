namespace WindowsFormsApplication1
{
    partial class Themlohangtondau
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
            this.cbmathang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbhsd = new DevExpress.XtraEditors.DateEdit();
            this.txtlohang = new DevExpress.XtraEditors.TextEdit();
            this.lbmota = new DevExpress.XtraEditors.LabelControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.lbnhomhang = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new DevExpress.XtraEditors.CalcEdit();
            this.txtgiamua = new DevExpress.XtraEditors.CalcEdit();
            this.txtgiaban = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmathang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbhsd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbhsd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlohang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiamua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmathang
            // 
            this.cbmathang.EditValue = "";
            this.cbmathang.Location = new System.Drawing.Point(97, 16);
            this.cbmathang.Name = "cbmathang";
            this.cbmathang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmathang.Properties.DisplayMember = "MANH";
            this.cbmathang.Properties.NullText = "";
            this.cbmathang.Properties.ValueMember = "TENNHOMHANG";
            this.cbmathang.Properties.View = this.gridLookUpEdit1View;
            this.cbmathang.Size = new System.Drawing.Size(267, 20);
            this.cbmathang.TabIndex = 3;
            this.cbmathang.EditValueChanged += new System.EventHandler(this.cbmathang_EditValueChanged);
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
            // colmanh
            // 
            this.colmanh.Caption = "Mã Hàng";
            this.colmanh.FieldName = "MAMH";
            this.colmanh.Name = "colmanh";
            this.colmanh.Visible = true;
            this.colmanh.VisibleIndex = 0;
            // 
            // colten
            // 
            this.colten.Caption = "Mặt Hàng";
            this.colten.FieldName = "TENMH";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtgiaban);
            this.panelControl1.Controls.Add(this.txtgiamua);
            this.panelControl1.Controls.Add(this.txtsoluong);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbhsd);
            this.panelControl1.Controls.Add(this.txtlohang);
            this.panelControl1.Controls.Add(this.lbmota);
            this.panelControl1.Controls.Add(this.cbmathang);
            this.panelControl1.Controls.Add(this.btLuu);
            this.panelControl1.Controls.Add(this.btDong);
            this.panelControl1.Controls.Add(this.lbnhomhang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 316);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 163;
            this.labelControl2.Text = "Số Lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 161;
            this.labelControl1.Text = "Hạn Sử Dụng:";
            // 
            // cbhsd
            // 
            this.cbhsd.EditValue = new System.DateTime(2010, 11, 27, 23, 39, 42, 143);
            this.cbhsd.Location = new System.Drawing.Point(97, 94);
            this.cbhsd.Name = "cbhsd";
            this.cbhsd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbhsd.Properties.Mask.EditMask = "";
            this.cbhsd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cbhsd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbhsd.Size = new System.Drawing.Size(267, 20);
            this.cbhsd.TabIndex = 160;
            // 
            // txtlohang
            // 
            this.txtlohang.Location = new System.Drawing.Point(97, 55);
            this.txtlohang.Name = "txtlohang";
            this.txtlohang.Size = new System.Drawing.Size(267, 20);
            this.txtlohang.TabIndex = 4;
            // 
            // lbmota
            // 
            this.lbmota.Location = new System.Drawing.Point(21, 58);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(43, 13);
            this.lbmota.TabIndex = 153;
            this.lbmota.Text = "Lô Hàng:";
            // 
            // btLuu
            // 
            this.btLuu.Image = global::WindowsFormsApplication1.Properties.Resources.save1;
            this.btLuu.Location = new System.Drawing.Point(115, 256);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(95, 38);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::WindowsFormsApplication1.Properties.Resources.close2;
            this.btDong.Location = new System.Drawing.Point(237, 256);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(98, 38);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // lbnhomhang
            // 
            this.lbnhomhang.Location = new System.Drawing.Point(21, 19);
            this.lbnhomhang.Name = "lbnhomhang";
            this.lbnhomhang.Size = new System.Drawing.Size(50, 13);
            this.lbnhomhang.TabIndex = 2;
            this.lbnhomhang.Text = "Mặt Hàng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 165;
            this.labelControl4.Text = "Giá Mua:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 167;
            this.labelControl5.Text = "Giá Bán:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(97, 133);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsoluong.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtsoluong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsoluong.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtsoluong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsoluong.Size = new System.Drawing.Size(267, 20);
            this.txtsoluong.TabIndex = 168;
            // 
            // txtgiamua
            // 
            this.txtgiamua.Location = new System.Drawing.Point(97, 172);
            this.txtgiamua.Name = "txtgiamua";
            this.txtgiamua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtgiamua.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtgiamua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtgiamua.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtgiamua.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtgiamua.Size = new System.Drawing.Size(267, 20);
            this.txtgiamua.TabIndex = 169;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(97, 211);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtgiaban.Properties.DisplayFormat.FormatString = "{0:0,0}";
            this.txtgiaban.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtgiaban.Properties.EditFormat.FormatString = "{0:0,0}";
            this.txtgiaban.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtgiaban.Size = new System.Drawing.Size(267, 20);
            this.txtgiaban.TabIndex = 170;
            // 
            // Themlohangtondau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 316);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Themlohangtondau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Lô Hàng Tồn Đầu";
            this.Load += new System.EventHandler(this.ThemMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbmathang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbhsd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbhsd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlohang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiamua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cbmathang;
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
        private DevExpress.XtraGrid.Columns.GridColumn colmanh;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraEditors.LabelControl lbmota;
        private DevExpress.XtraEditors.TextEdit txtlohang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit cbhsd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CalcEdit txtgiaban;
        private DevExpress.XtraEditors.CalcEdit txtgiamua;
        private DevExpress.XtraEditors.CalcEdit txtsoluong;
    }
}