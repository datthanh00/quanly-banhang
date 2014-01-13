namespace WindowsFormsApplication1
{
    partial class frmSuaNguoiDung
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
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.txttendangnhap = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gBoPhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttendangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Thông tin bắt buộc";
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup6.Size = new System.Drawing.Size(267, 222);
            this.layoutControlGroup6.Text = "Thông tin bắt buộc";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btLuu);
            this.layoutControl1.Controls.Add(this.btDong);
            this.layoutControl1.Controls.Add(this.txttendangnhap);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.layoutControl1.Controls.Add(this.txtten);
            this.layoutControl1.Controls.Add(this.txtma);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(336, 155);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykho.Properties.Resources.check;
            this.btLuu.Location = new System.Drawing.Point(108, 108);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(105, 30);
            this.btLuu.StyleController = this.layoutControl1;
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "simpleButton1";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close4;
            this.btDong.Location = new System.Drawing.Point(217, 108);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(105, 30);
            this.btDong.StyleController = this.layoutControl1;
            this.btDong.TabIndex = 6;
            this.btDong.Text = "simpleButton2";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(88, 60);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(236, 20);
            this.txttendangnhap.StyleController = this.layoutControl1;
            this.txttendangnhap.TabIndex = 3;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(88, 84);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.View = this.gBoPhan;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(236, 20);
            this.gridLookUpEdit1.StyleController = this.layoutControl1;
            this.gridLookUpEdit1.TabIndex = 4;
            this.gridLookUpEdit1.Validated += new System.EventHandler(this.gridLookUpEdit1_Validated);
            // 
            // gBoPhan
            // 
            this.gBoPhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenBP,
            this.colMABP});
            this.gBoPhan.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gBoPhan.Name = "gBoPhan";
            this.gBoPhan.OptionsBehavior.Editable = false;
            this.gBoPhan.OptionsBehavior.SmartVertScrollBar = false;
            this.gBoPhan.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gBoPhan.OptionsView.ShowGroupPanel = false;
            // 
            // colTenBP
            // 
            this.colTenBP.Caption = "gridColumn1";
            this.colTenBP.FieldName = "TENBOPHAN";
            this.colTenBP.Name = "colTenBP";
            this.colTenBP.Visible = true;
            this.colTenBP.VisibleIndex = 0;
            // 
            // colMABP
            // 
            this.colMABP.Caption = "gridColumn2";
            this.colMABP.FieldName = "MABP";
            this.colMABP.Name = "colMABP";
            this.colMABP.Visible = true;
            this.colMABP.VisibleIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(88, 36);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(236, 20);
            this.txtten.StyleController = this.layoutControl1;
            this.txtten.TabIndex = 2;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(88, 12);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(236, 20);
            this.txtma.StyleController = this.layoutControl1;
            this.txtma.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.simpleSeparator1,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(336, 155);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtten;
            this.layoutControlItem1.CustomizationFormText = "Tên nhân viên";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem1.Text = "Tên nhân viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridLookUpEdit1;
            this.layoutControlItem3.CustomizationFormText = "Chức vụ";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem3.Text = "Chức vụ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txttendangnhap;
            this.layoutControlItem4.CustomizationFormText = "Tên đăng nhập";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem4.Text = "Tên đăng nhập";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(96, 39);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(314, 96);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 39);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btDong;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(205, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(109, 39);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btLuu;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(96, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(109, 39);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtma;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem2.Text = "Mã nhân viên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // frmSuaNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 155);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSuaNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Người Dùng";
            this.Load += new System.EventHandler(this.frmSuaNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txttendangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.TextEdit txttendangnhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gBoPhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBP;
        private DevExpress.XtraGrid.Columns.GridColumn colMABP;
    }
}