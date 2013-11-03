namespace WindowsFormsApplication1
{
    partial class frmDoiMatKhau
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtPassXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtPassCu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbMatKhauCu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbXacNhan = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbMatKhauMoi = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMatKhauCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMatKhauMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btLuu);
            this.layoutControl1.Controls.Add(this.btDong);
            this.layoutControl1.Controls.Add(this.txtPassMoi);
            this.layoutControl1.Controls.Add(this.txtPassXacNhan);
            this.layoutControl1.Controls.Add(this.txtPassCu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(365, 128);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykho.Properties.Resources.check;
            this.btLuu.Location = new System.Drawing.Point(139, 84);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(105, 30);
            this.btLuu.StyleController = this.layoutControl1;
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "simpleButton2";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close4;
            this.btDong.Location = new System.Drawing.Point(248, 84);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(105, 30);
            this.btDong.StyleController = this.layoutControl1;
            this.btDong.TabIndex = 7;
            this.btDong.Text = "simpleButton1";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Location = new System.Drawing.Point(126, 36);
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.Properties.PasswordChar = '*';
            this.txtPassMoi.Size = new System.Drawing.Size(227, 20);
            this.txtPassMoi.StyleController = this.layoutControl1;
            this.txtPassMoi.TabIndex = 6;
            this.txtPassMoi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassMoi_Validating);
            // 
            // txtPassXacNhan
            // 
            this.txtPassXacNhan.Location = new System.Drawing.Point(126, 60);
            this.txtPassXacNhan.Name = "txtPassXacNhan";
            this.txtPassXacNhan.Properties.PasswordChar = '*';
            this.txtPassXacNhan.Size = new System.Drawing.Size(227, 20);
            this.txtPassXacNhan.StyleController = this.layoutControl1;
            this.txtPassXacNhan.TabIndex = 5;
            // 
            // txtPassCu
            // 
            this.txtPassCu.Location = new System.Drawing.Point(126, 12);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.Properties.PasswordChar = '*';
            this.txtPassCu.Size = new System.Drawing.Size(227, 20);
            this.txtPassCu.StyleController = this.layoutControl1;
            this.txtPassCu.TabIndex = 4;
            this.txtPassCu.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassCu_Validating);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbMatKhauCu,
            this.lbXacNhan,
            this.lbMatKhauMoi,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(365, 128);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.Control = this.txtPassCu;
            this.lbMatKhauCu.CustomizationFormText = "Mật khẩu cũ";
            this.lbMatKhauCu.Location = new System.Drawing.Point(0, 0);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(345, 24);
            this.lbMatKhauCu.Text = "Mật khẩu cũ";
            this.lbMatKhauCu.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lbXacNhan
            // 
            this.lbXacNhan.Control = this.txtPassXacNhan;
            this.lbXacNhan.CustomizationFormText = "layoutControlItem2";
            this.lbXacNhan.Location = new System.Drawing.Point(0, 48);
            this.lbXacNhan.Name = "lbXacNhan";
            this.lbXacNhan.Size = new System.Drawing.Size(345, 24);
            this.lbXacNhan.Text = "Xác nhận mật khẩu mới";
            this.lbXacNhan.TextSize = new System.Drawing.Size(110, 13);
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.Control = this.txtPassMoi;
            this.lbMatKhauMoi.CustomizationFormText = "layoutControlItem3";
            this.lbMatKhauMoi.Location = new System.Drawing.Point(0, 24);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(345, 24);
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            this.lbMatKhauMoi.TextSize = new System.Drawing.Size(110, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(127, 36);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btDong;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(236, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 36);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btLuu;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(127, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(109, 36);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 128);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMatKhauCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbMatKhauMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPassMoi;
        private DevExpress.XtraEditors.TextEdit txtPassXacNhan;
        private DevExpress.XtraEditors.TextEdit txtPassCu;
        private DevExpress.XtraLayout.LayoutControlItem lbMatKhauCu;
        private DevExpress.XtraLayout.LayoutControlItem lbXacNhan;
        private DevExpress.XtraLayout.LayoutControlItem lbMatKhauMoi;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}