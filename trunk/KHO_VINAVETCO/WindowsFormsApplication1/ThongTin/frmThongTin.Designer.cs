namespace WindowsFormsApplication1
{
    partial class frmThongTin
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
            this.lbTenDonVI = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lbDT = new DevExpress.XtraEditors.LabelControl();
            this.lbFax = new DevExpress.XtraEditors.LabelControl();
            this.lbWeb = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.lbMaSoThue = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtDT = new DevExpress.XtraEditors.TextEdit();
            this.txtWeb = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtMaST = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lbDiDong = new DevExpress.XtraEditors.LabelControl();
            this.txtDiDong = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenDonVI
            // 
            this.lbTenDonVI.Location = new System.Drawing.Point(45, 26);
            this.lbTenDonVI.Name = "lbTenDonVI";
            this.lbTenDonVI.Size = new System.Drawing.Size(50, 13);
            this.lbTenDonVI.TabIndex = 0;
            this.lbTenDonVI.Text = "Tên đơn vị";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Location = new System.Drawing.Point(46, 52);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(32, 13);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbDT
            // 
            this.lbDT.Location = new System.Drawing.Point(46, 78);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(49, 13);
            this.lbDT.TabIndex = 0;
            this.lbDT.Text = "Điện thoại";
            // 
            // lbFax
            // 
            this.lbFax.Location = new System.Drawing.Point(45, 128);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(18, 13);
            this.lbFax.TabIndex = 0;
            this.lbFax.Text = "Fax";
            // 
            // lbWeb
            // 
            this.lbWeb.Location = new System.Drawing.Point(45, 154);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(39, 13);
            this.lbWeb.TabIndex = 0;
            this.lbWeb.Text = "Website";
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(46, 180);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(24, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbMaSoThue
            // 
            this.lbMaSoThue.Location = new System.Drawing.Point(46, 209);
            this.lbMaSoThue.Name = "lbMaSoThue";
            this.lbMaSoThue.Size = new System.Drawing.Size(53, 13);
            this.lbMaSoThue.TabIndex = 0;
            this.lbMaSoThue.Text = "Mã số thuế";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.simpleButton1.Location = new System.Drawing.Point(130, 228);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Đồng ý";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(129, 23);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(372, 20);
            this.txtten.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(129, 125);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(181, 20);
            this.txtFax.TabIndex = 5;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(129, 49);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(372, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(129, 75);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(181, 20);
            this.txtDT.TabIndex = 3;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(129, 151);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(181, 20);
            this.txtWeb.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMaST
            // 
            this.txtMaST.Location = new System.Drawing.Point(129, 202);
            this.txtMaST.Name = "txtMaST";
            this.txtMaST.Size = new System.Drawing.Size(181, 20);
            this.txtMaST.TabIndex = 8;
            this.txtMaST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaST_KeyPress);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(339, 78);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(162, 120);
            this.pictureEdit1.TabIndex = 3;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // lbDiDong
            // 
            this.lbDiDong.Location = new System.Drawing.Point(46, 102);
            this.lbDiDong.Name = "lbDiDong";
            this.lbDiDong.Size = new System.Drawing.Size(36, 13);
            this.lbDiDong.TabIndex = 0;
            this.lbDiDong.Text = "Di động";
            // 
            // txtDiDong
            // 
            this.txtDiDong.EditValue = "";
            this.txtDiDong.Location = new System.Drawing.Point(129, 99);
            this.txtDiDong.Name = "txtDiDong";
            this.txtDiDong.Size = new System.Drawing.Size(181, 20);
            this.txtDiDong.TabIndex = 4;
            this.txtDiDong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiDong_KeyPress);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::WindowsFormsApplication1.Properties.Resources.close4;
            this.simpleButton2.Location = new System.Drawing.Point(223, 228);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Kết thúc";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 263);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtMaST);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.txtDiDong);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbMaSoThue);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbWeb);
            this.Controls.Add(this.lbDiDong);
            this.Controls.Add(this.lbFax);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenDonVI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin công ty";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTenDonVI;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl lbDT;
        private DevExpress.XtraEditors.LabelControl lbFax;
        private DevExpress.XtraEditors.LabelControl lbWeb;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl lbMaSoThue;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtDT;
        private DevExpress.XtraEditors.TextEdit txtWeb;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtMaST;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lbDiDong;
        private DevExpress.XtraEditors.TextEdit txtDiDong;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}