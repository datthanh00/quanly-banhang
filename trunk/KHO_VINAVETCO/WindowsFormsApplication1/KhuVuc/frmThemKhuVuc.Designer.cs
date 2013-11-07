namespace WindowsFormsApplication1
{
    partial class frmThemKhuVuc
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
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lbGHICHU = new DevExpress.XtraEditors.LabelControl();
            this.lbTENKV = new DevExpress.XtraEditors.LabelControl();
            this.lbMAKV = new DevExpress.XtraEditors.LabelControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.lbTINHTRANG = new DevExpress.XtraEditors.LabelControl();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.lbCHUY = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(98, 62);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(192, 20);
            this.txtghichu.TabIndex = 3;
            this.txtghichu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtghichu_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(78, 38);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 21;
            this.labelControl14.Text = "(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(78, 12);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "(*)";
            // 
            // lbGHICHU
            // 
            this.lbGHICHU.Location = new System.Drawing.Point(13, 69);
            this.lbGHICHU.Name = "lbGHICHU";
            this.lbGHICHU.Size = new System.Drawing.Size(37, 13);
            this.lbGHICHU.TabIndex = 17;
            this.lbGHICHU.Text = "Ghi Chú";
            // 
            // lbTENKV
            // 
            this.lbTENKV.Location = new System.Drawing.Point(13, 40);
            this.lbTENKV.Name = "lbTENKV";
            this.lbTENKV.Size = new System.Drawing.Size(33, 13);
            this.lbTENKV.TabIndex = 26;
            this.lbTENKV.Text = "Tên KV";
            this.lbTENKV.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // lbMAKV
            // 
            this.lbMAKV.Location = new System.Drawing.Point(13, 12);
            this.lbMAKV.Name = "lbMAKV";
            this.lbMAKV.Size = new System.Drawing.Size(29, 13);
            this.lbMAKV.TabIndex = 19;
            this.lbMAKV.Text = "Mã KV";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(98, 35);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(192, 20);
            this.txtten.TabIndex = 2;
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            // 
            // lbTINHTRANG
            // 
            this.lbTINHTRANG.Location = new System.Drawing.Point(13, 96);
            this.lbTINHTRANG.Name = "lbTINHTRANG";
            this.lbTINHTRANG.Size = new System.Drawing.Size(51, 13);
            this.lbTINHTRANG.TabIndex = 46;
            this.lbTINHTRANG.Text = "Tình Trạng";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(98, 9);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(192, 20);
            this.txtma.TabIndex = 1;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtma_KeyPress);
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
            // lbCHUY
            // 
            this.lbCHUY.Location = new System.Drawing.Point(58, 137);
            this.lbCHUY.Name = "lbCHUY";
            this.lbCHUY.Size = new System.Drawing.Size(246, 13);
            this.lbCHUY.TabIndex = 51;
            this.lbCHUY.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(35, 137);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 50;
            this.labelControl19.Text = "(*)";
            // 
            // checkTT
            // 
            this.checkTT.EditValue = true;
            this.checkTT.Location = new System.Drawing.Point(96, 94);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Kích Hoạt";
            this.checkTT.Size = new System.Drawing.Size(82, 18);
            this.checkTT.TabIndex = 4;
            this.checkTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkTT_KeyPress);
            // 
            // frmThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 231);
            this.ControlBox = false;
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.lbCHUY);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.lbTINHTRANG);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lbGHICHU);
            this.Controls.Add(this.lbTENKV);
            this.Controls.Add(this.lbMAKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thông Tin Khu Vực";
            this.Load += new System.EventHandler(this.frmThemKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lbGHICHU;
        private DevExpress.XtraEditors.LabelControl lbTENKV;
        private DevExpress.XtraEditors.LabelControl lbMAKV;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl lbTINHTRANG;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.LabelControl lbCHUY;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.CheckEdit checkTT;
    }
}