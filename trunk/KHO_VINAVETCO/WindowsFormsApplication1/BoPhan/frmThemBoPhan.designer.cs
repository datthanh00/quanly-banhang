namespace WindowsFormsApplication1
{
    partial class frmThemBoPhan
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
            this.lbTINHTRANG = new DevExpress.XtraEditors.LabelControl();
            this.lbTENBP = new DevExpress.XtraEditors.LabelControl();
            this.lbMABP = new DevExpress.XtraEditors.LabelControl();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lbchuy = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(105, 13);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(192, 20);
            this.txtma.TabIndex = 1;
            this.txtma.Validating += new System.ComponentModel.CancelEventHandler(this.txtma_Validating);
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtma_KeyPress);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(105, 39);
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
            this.labelControl14.Location = new System.Drawing.Point(83, 40);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 102;
            this.labelControl14.Text = "(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(83, 14);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 100;
            this.labelControl12.Text = "(*)";
            // 
            // lbTINHTRANG
            // 
            this.lbTINHTRANG.Location = new System.Drawing.Point(5, 73);
            this.lbTINHTRANG.Name = "lbTINHTRANG";
            this.lbTINHTRANG.Size = new System.Drawing.Size(51, 13);
            this.lbTINHTRANG.TabIndex = 99;
            this.lbTINHTRANG.Text = "Tình Trạng";
            // 
            // lbTENBP
            // 
            this.lbTENBP.Location = new System.Drawing.Point(5, 44);
            this.lbTENBP.Name = "lbTENBP";
            this.lbTENBP.Size = new System.Drawing.Size(60, 13);
            this.lbTENBP.TabIndex = 103;
            this.lbTENBP.Text = "Tên Bộ Phận";
            // 
            // lbMABP
            // 
            this.lbMABP.Location = new System.Drawing.Point(7, 16);
            this.lbMABP.Name = "lbMABP";
            this.lbMABP.Size = new System.Drawing.Size(56, 13);
            this.lbMABP.TabIndex = 100;
            this.lbMABP.Text = "Mã Bộ Phận";
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(154, 135);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 5;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(24, 135);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 4;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(8, 107);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 123;
            this.labelControl19.Text = "(*)";
            // 
            // lbchuy
            // 
            this.lbchuy.Location = new System.Drawing.Point(31, 107);
            this.lbchuy.Name = "lbchuy";
            this.lbchuy.Size = new System.Drawing.Size(246, 13);
            this.lbchuy.TabIndex = 124;
            this.lbchuy.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // checkTT
            // 
            this.checkTT.EditValue = true;
            this.checkTT.Location = new System.Drawing.Point(105, 70);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Kích Hoạt";
            this.checkTT.Size = new System.Drawing.Size(82, 19);
            this.checkTT.TabIndex = 3;
            // 
            // frmThemBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.lbchuy);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lbTINHTRANG);
            this.Controls.Add(this.lbTENBP);
            this.Controls.Add(this.lbMABP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Bộ Phận";
            this.Load += new System.EventHandler(this.frmThemBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbTINHTRANG;
        private DevExpress.XtraEditors.LabelControl lbTENBP;
        private DevExpress.XtraEditors.LabelControl lbMABP;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lbchuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.CheckEdit checkTT;
    }
}