namespace WindowsFormsApplication1
{
    partial class frmThemDVT
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
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lbDVT = new DevExpress.XtraEditors.LabelControl();
            this.lbmaDVT = new DevExpress.XtraEditors.LabelControl();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lbchuy = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(89, 10);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(192, 20);
            this.txtma.TabIndex = 1;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtma_KeyPress);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(89, 36);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(192, 20);
            this.txtten.TabIndex = 2;
            this.txtten.Validating += new System.ComponentModel.CancelEventHandler(this.txtten_Validating);
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(67, 39);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(67, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "(*)";
            // 
            // lbDVT
            // 
            this.lbDVT.Location = new System.Drawing.Point(8, 41);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(54, 13);
            this.lbDVT.TabIndex = 0;
            this.lbDVT.Text = "Đơn Vị Tính";
            // 
            // lbmaDVT
            // 
            this.lbmaDVT.Location = new System.Drawing.Point(10, 13);
            this.lbmaDVT.Name = "lbmaDVT";
            this.lbmaDVT.Size = new System.Drawing.Size(37, 13);
            this.lbmaDVT.TabIndex = 0;
            this.lbmaDVT.Text = "Mã ĐVT";
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(138, 100);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 4;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(8, 100);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(9, 72);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 125;
            this.labelControl19.Text = "(*)";
            // 
            // lbchuy
            // 
            this.lbchuy.Location = new System.Drawing.Point(32, 72);
            this.lbchuy.Name = "lbchuy";
            this.lbchuy.Size = new System.Drawing.Size(246, 13);
            this.lbchuy.TabIndex = 126;
            this.lbchuy.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmThemDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 168);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.lbchuy);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lbDVT);
            this.Controls.Add(this.lbmaDVT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm DVT";
            this.Load += new System.EventHandler(this.frmThemDVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lbDVT;
        private DevExpress.XtraEditors.LabelControl lbmaDVT;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lbchuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;

    }
}