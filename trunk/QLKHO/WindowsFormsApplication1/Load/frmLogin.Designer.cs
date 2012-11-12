﻿namespace WindowsFormsApplication1
{
    partial class frmLogin
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
            this.lbTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.lbMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.lbDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.checkNho = new DevExpress.XtraEditors.CheckEdit();
            this.btDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btKetThuc = new DevExpress.XtraEditors.SimpleButton();
            this.btTuyChon = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(100, 85);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(68, 13);
            this.lbTenTaiKhoan.TabIndex = 1;
            this.lbTenTaiKhoan.Text = "Tên Tài Khoản";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Location = new System.Drawing.Point(100, 111);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(45, 13);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(176, 82);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(158, 20);
            this.txtTenTaiKhoan.TabIndex = 0;
            this.txtTenTaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenTaiKhoan_Validating);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(176, 108);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(158, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Tag = "*";
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Appearance.Options.UseFont = true;
            this.lbDangNhap.Location = new System.Drawing.Point(166, 35);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(124, 31);
            this.lbDangNhap.TabIndex = 1;
            this.lbDangNhap.Text = "Đăng Nhập";
            // 
            // checkNho
            // 
            this.checkNho.Location = new System.Drawing.Point(148, 134);
            this.checkNho.Name = "checkNho";
            this.checkNho.Properties.Caption = "Nhớ Tài Khoản Và Mật Khẩu";
            this.checkNho.Size = new System.Drawing.Size(159, 18);
            this.checkNho.TabIndex = 2;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(190, 169);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btKetThuc
            // 
            this.btKetThuc.Location = new System.Drawing.Point(271, 169);
            this.btKetThuc.Name = "btKetThuc";
            this.btKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btKetThuc.TabIndex = 4;
            this.btKetThuc.Text = "Kết Thúc";
            this.btKetThuc.Click += new System.EventHandler(this.btKetThuc_Click);
            // 
            // btTuyChon
            // 
            this.btTuyChon.Location = new System.Drawing.Point(12, 169);
            this.btTuyChon.Name = "btTuyChon";
            this.btTuyChon.Size = new System.Drawing.Size(75, 23);
            this.btTuyChon.TabIndex = 5;
            this.btTuyChon.Text = "Tùy Chọn";
            this.btTuyChon.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Xmas 2008 Blue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.security;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 196);
            this.ControlBox = false;
            this.Controls.Add(this.btTuyChon);
            this.Controls.Add(this.btKetThuc);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.checkNho);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Tài Khoản";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lbMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lbDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.CheckEdit checkNho;
        private DevExpress.XtraEditors.SimpleButton btDangNhap;
        private DevExpress.XtraEditors.SimpleButton btKetThuc;
        private DevExpress.XtraEditors.SimpleButton btTuyChon;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}