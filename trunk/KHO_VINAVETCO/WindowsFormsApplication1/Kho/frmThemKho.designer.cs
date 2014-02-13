namespace WindowsFormsApplication1
{
    partial class frmThemKho
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
            this.lbMakho = new DevExpress.XtraEditors.LabelControl();
            this.lbTenkho = new DevExpress.XtraEditors.LabelControl();
            this.txtmakho = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lbchuy = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.lbnguoilienhe = new DevExpress.XtraEditors.LabelControl();
            this.txtnguoiLH = new DevExpress.XtraEditors.TextEdit();
            this.lbtinhtrang = new DevExpress.XtraEditors.LabelControl();
            this.lbfax = new DevExpress.XtraEditors.LabelControl();
            this.lbsodtdd = new DevExpress.XtraEditors.LabelControl();
            this.txtfax = new DevExpress.XtraEditors.TextEdit();
            this.txtsodtDD = new DevExpress.XtraEditors.TextEdit();
            this.lbdiachi = new DevExpress.XtraEditors.LabelControl();
            this.txttenkho = new DevExpress.XtraEditors.TextEdit();
            this.lbsosdtban = new DevExpress.XtraEditors.LabelControl();
            this.txtsodtB = new DevExpress.XtraEditors.TextEdit();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiLH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodtDD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodtB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMakho
            // 
            this.lbMakho.Location = new System.Drawing.Point(8, 56);
            this.lbMakho.Name = "lbMakho";
            this.lbMakho.Size = new System.Drawing.Size(35, 13);
            this.lbMakho.TabIndex = 0;
            this.lbMakho.Text = "Mã Kho";
            // 
            // lbTenkho
            // 
            this.lbTenkho.Location = new System.Drawing.Point(8, 25);
            this.lbTenkho.Name = "lbTenkho";
            this.lbTenkho.Size = new System.Drawing.Size(39, 13);
            this.lbTenkho.TabIndex = 0;
            this.lbTenkho.Text = "Tên Kho";
            // 
            // txtmakho
            // 
            this.txtmakho.Enabled = false;
            this.txtmakho.Location = new System.Drawing.Point(87, 53);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(107, 20);
            this.txtmakho.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.checkTT);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.lbchuy);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtghichu);
            this.groupControl1.Controls.Add(this.lbnguoilienhe);
            this.groupControl1.Controls.Add(this.txtnguoiLH);
            this.groupControl1.Controls.Add(this.lbtinhtrang);
            this.groupControl1.Controls.Add(this.lbfax);
            this.groupControl1.Controls.Add(this.lbsodtdd);
            this.groupControl1.Controls.Add(this.txtfax);
            this.groupControl1.Controls.Add(this.txtsodtDD);
            this.groupControl1.Controls.Add(this.lbdiachi);
            this.groupControl1.Controls.Add(this.lbMakho);
            this.groupControl1.Controls.Add(this.txttenkho);
            this.groupControl1.Controls.Add(this.lbsosdtban);
            this.groupControl1.Controls.Add(this.txtsodtB);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtmakho);
            this.groupControl1.Controls.Add(this.lbTenkho);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(480, 302);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Thông Tin Kho";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 207);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Chức Năng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(87, 229);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(336, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "HSD--BARCODE--TONNHAPXUATNGAYFULL--KHOILUONG--BANGGIA--";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "(*)";
            // 
            // checkTT
            // 
            this.checkTT.EditValue = true;
            this.checkTT.Location = new System.Drawing.Point(85, 259);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Kích Hoạt";
            this.checkTT.Size = new System.Drawing.Size(82, 18);
            this.checkTT.TabIndex = 9;
            this.checkTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkTT_KeyPress);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(40, 282);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 0;
            this.labelControl19.Text = "(*)";
            // 
            // lbchuy
            // 
            this.lbchuy.Location = new System.Drawing.Point(63, 282);
            this.lbchuy.Name = "lbchuy";
            this.lbchuy.Size = new System.Drawing.Size(246, 13);
            this.lbchuy.TabIndex = 0;
            this.lbchuy.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseBackColor = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(65, 257);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(14, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "(*)";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(63, 56);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(14, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "(*)";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(87, 205);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(344, 20);
            this.txtghichu.TabIndex = 8;
            this.txtghichu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtghichu_KeyPress);
            // 
            // lbnguoilienhe
            // 
            this.lbnguoilienhe.Location = new System.Drawing.Point(8, 138);
            this.lbnguoilienhe.Name = "lbnguoilienhe";
            this.lbnguoilienhe.Size = new System.Drawing.Size(66, 13);
            this.lbnguoilienhe.TabIndex = 0;
            this.lbnguoilienhe.Text = "Người Liên Hệ";
            // 
            // txtnguoiLH
            // 
            this.txtnguoiLH.Location = new System.Drawing.Point(87, 138);
            this.txtnguoiLH.Name = "txtnguoiLH";
            this.txtnguoiLH.Size = new System.Drawing.Size(344, 20);
            this.txtnguoiLH.TabIndex = 6;
            this.txtnguoiLH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnguoiLH_KeyPress);
            // 
            // lbtinhtrang
            // 
            this.lbtinhtrang.Location = new System.Drawing.Point(8, 257);
            this.lbtinhtrang.Name = "lbtinhtrang";
            this.lbtinhtrang.Size = new System.Drawing.Size(51, 13);
            this.lbtinhtrang.TabIndex = 0;
            this.lbtinhtrang.Text = "Tình Trạng";
            // 
            // lbfax
            // 
            this.lbfax.Location = new System.Drawing.Point(8, 168);
            this.lbfax.Name = "lbfax";
            this.lbfax.Size = new System.Drawing.Size(18, 13);
            this.lbfax.TabIndex = 0;
            this.lbfax.Text = "Fax";
            this.lbfax.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // lbsodtdd
            // 
            this.lbsodtdd.Location = new System.Drawing.Point(8, 110);
            this.lbsodtdd.Name = "lbsodtdd";
            this.lbsodtdd.Size = new System.Drawing.Size(44, 13);
            this.lbsodtdd.TabIndex = 0;
            this.lbsodtdd.Text = "Số ĐTDĐ";
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(87, 168);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(100, 20);
            this.txtfax.TabIndex = 7;
            this.txtfax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfax_KeyPress);
            // 
            // txtsodtDD
            // 
            this.txtsodtDD.Location = new System.Drawing.Point(87, 110);
            this.txtsodtDD.Name = "txtsodtDD";
            this.txtsodtDD.Size = new System.Drawing.Size(344, 20);
            this.txtsodtDD.TabIndex = 5;
            this.txtsodtDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodtDD_KeyPress);
            // 
            // lbdiachi
            // 
            this.lbdiachi.Location = new System.Drawing.Point(204, 56);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(34, 13);
            this.lbdiachi.TabIndex = 0;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // txttenkho
            // 
            this.txttenkho.Location = new System.Drawing.Point(87, 25);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(344, 20);
            this.txttenkho.TabIndex = 1;
            this.txttenkho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenkho_KeyPress);
            // 
            // lbsosdtban
            // 
            this.lbsosdtban.Location = new System.Drawing.Point(8, 81);
            this.lbsosdtban.Name = "lbsosdtban";
            this.lbsosdtban.Size = new System.Drawing.Size(50, 13);
            this.lbsosdtban.TabIndex = 0;
            this.lbsosdtban.Text = "Số ĐT Bàn";
            // 
            // txtsodtB
            // 
            this.txtsodtB.Location = new System.Drawing.Point(87, 81);
            this.txtsodtB.Name = "txtsodtB";
            this.txtsodtB.Size = new System.Drawing.Size(344, 20);
            this.txtsodtB.TabIndex = 4;
            this.txtsodtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodtB_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(244, 53);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(187, 20);
            this.txtdiachi.TabIndex = 3;
            this.txtdiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiachi_KeyPress);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(264, 308);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(97, 308);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 10;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // frmThemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 367);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Kho";
            this.Load += new System.EventHandler(this.frmThemKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmakho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiLH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodtDD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodtB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.LabelControl lbMakho;
        private DevExpress.XtraEditors.LabelControl lbTenkho;
        private DevExpress.XtraEditors.TextEdit txtmakho;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbdiachi;
        private DevExpress.XtraEditors.TextEdit txttenkho;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.LabelControl lbsosdtban;
        private DevExpress.XtraEditors.TextEdit txtsodtB;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.LabelControl lbnguoilienhe;
        private DevExpress.XtraEditors.TextEdit txtnguoiLH;
        private DevExpress.XtraEditors.LabelControl lbtinhtrang;
        private DevExpress.XtraEditors.LabelControl lbfax;
        private DevExpress.XtraEditors.LabelControl lbsodtdd;
        private DevExpress.XtraEditors.TextEdit txtfax;
        private DevExpress.XtraEditors.TextEdit txtsodtDD;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        //private XUAT_NHAPTONDataSet29 xUAT_NHAPTONDataSet29;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet29TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        //private XUAT_NHAPTONDataSet30 xUAT_NHAPTONDataSet30;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet30TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lbchuy;
        private DevExpress.XtraEditors.CheckEdit checkTT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}