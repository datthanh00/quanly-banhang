namespace WindowsFormsApplication1
{
    partial class frmThemNoptientruoc
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
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.Checkncc = new DevExpress.XtraEditors.CheckEdit();
            this.Checkkh = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboTenNCC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.cbotientra = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotientra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(163, 156);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 6;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(33, 156);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 5;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // Checkncc
            // 
            this.Checkncc.Location = new System.Drawing.Point(166, 10);
            this.Checkncc.Name = "Checkncc";
            this.Checkncc.Properties.Caption = "Nhà Cung Cấp";
            this.Checkncc.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.Checkncc.Properties.RadioGroupIndex = 1;
            this.Checkncc.Size = new System.Drawing.Size(140, 18);
            this.Checkncc.TabIndex = 2;
            this.Checkncc.TabStop = false;
            this.Checkncc.CheckedChanged += new System.EventHandler(this.Checkncc_CheckedChanged);
            // 
            // Checkkh
            // 
            this.Checkkh.EditValue = true;
            this.Checkkh.Location = new System.Drawing.Point(40, 10);
            this.Checkkh.Name = "Checkkh";
            this.Checkkh.Properties.Caption = "Khách Hàng";
            this.Checkkh.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.Checkkh.Properties.RadioGroupIndex = 1;
            this.Checkkh.Size = new System.Drawing.Size(82, 18);
            this.Checkkh.TabIndex = 1;
            this.Checkkh.CheckedChanged += new System.EventHandler(this.Checkkh_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "KH-NCC:";
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.Location = new System.Drawing.Point(61, 42);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenNCC.Properties.NullText = "";
            this.cboTenNCC.Properties.PopupSizeable = false;
            this.cboTenNCC.Properties.View = this.gridView3;
            this.cboTenNCC.Size = new System.Drawing.Size(252, 20);
            this.cboTenNCC.TabIndex = 3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã";
            this.gridColumn3.FieldName = "MADOITUONG";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "KH-NCC";
            this.gridColumn4.FieldName = "TENDOITUONG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(8, 72);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(39, 13);
            this.labelControl17.TabIndex = 56;
            this.labelControl17.Text = "Số Tiền:";
            // 
            // cbotientra
            // 
            this.cbotientra.Location = new System.Drawing.Point(61, 68);
            this.cbotientra.Name = "cbotientra";
            this.cbotientra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbotientra.Properties.Mask.EditMask = "n0";
            this.cbotientra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cbotientra.Size = new System.Drawing.Size(252, 20);
            this.cbotientra.TabIndex = 4;
            // 
            // frmThemNoptientruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 231);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.cbotientra);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cboTenNCC);
            this.Controls.Add(this.Checkncc);
            this.Controls.Add(this.Checkkh);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemNoptientruoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tiền Trả Trước";
            this.Load += new System.EventHandler(this.frmThemKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Checkncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotientra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.CheckEdit Checkncc;
        private DevExpress.XtraEditors.CheckEdit Checkkh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cboTenNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.CalcEdit cbotientra;
    }
}