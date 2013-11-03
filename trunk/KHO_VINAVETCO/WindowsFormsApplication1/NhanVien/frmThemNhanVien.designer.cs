namespace WindowsFormsApplication1
{
    partial class frmThemNhanVien
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
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lbchuy = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtmanv = new DevExpress.XtraEditors.TextEdit();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.txttennv = new DevExpress.XtraEditors.TextEdit();
            this.lbsodt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lbdiachi = new DevExpress.XtraEditors.LabelControl();
            this.lbngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lbtennv = new DevExpress.XtraEditors.LabelControl();
            this.lbsocmnd = new DevExpress.XtraEditors.LabelControl();
            this.lbmanv = new DevExpress.XtraEditors.LabelControl();
            this.cmbdate = new DevExpress.XtraEditors.DateEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtsoCMND = new DevExpress.XtraEditors.CalcEdit();
            this.txtsdt = new DevExpress.XtraEditors.CalcEdit();
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            this.lbtinhtrang = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(417, 107);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 55;
            this.labelControl19.Text = "(*)";
            // 
            // lbchuy
            // 
            this.lbchuy.Location = new System.Drawing.Point(437, 107);
            this.lbchuy.Name = "lbchuy";
            this.lbchuy.Size = new System.Drawing.Size(246, 13);
            this.lbchuy.TabIndex = 56;
            this.lbchuy.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl18.Appearance.Options.UseBackColor = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(435, 43);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(14, 13);
            this.labelControl18.TabIndex = 54;
            this.labelControl18.Text = "(*)";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(110, 12);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(228, 20);
            this.txtmanv.TabIndex = 0;
            this.txtmanv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmanv_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(110, 40);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(228, 20);
            this.txtdiachi.TabIndex = 2;
            this.txtdiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiachi_KeyPress);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(455, 9);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(228, 20);
            this.txttennv.TabIndex = 1;
            this.txttennv.EditValueChanged += new System.EventHandler(this.txttennv_EditValueChanged);
            this.txttennv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttennv_KeyPress);
            // 
            // lbsodt
            // 
            this.lbsodt.Location = new System.Drawing.Point(354, 43);
            this.lbsodt.Name = "lbsodt";
            this.lbsodt.Size = new System.Drawing.Size(66, 13);
            this.lbsodt.TabIndex = 31;
            this.lbsodt.Text = "Số Điện Thoại";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(435, 14);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 29;
            this.labelControl14.Text = "(*)";
            this.labelControl14.Click += new System.EventHandler(this.labelControl14_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(90, 15);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "(*)";
            // 
            // lbdiachi
            // 
            this.lbdiachi.Location = new System.Drawing.Point(8, 43);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(34, 13);
            this.lbdiachi.TabIndex = 28;
            this.lbdiachi.Text = "Địa Chỉ";
            this.lbdiachi.Click += new System.EventHandler(this.lbdiachi_Click);
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.Location = new System.Drawing.Point(8, 73);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(48, 13);
            this.lbngaysinh.TabIndex = 24;
            this.lbngaysinh.Text = "Ngày Sinh";
            this.lbngaysinh.Click += new System.EventHandler(this.lbngaysinh_Click);
            // 
            // lbtennv
            // 
            this.lbtennv.Location = new System.Drawing.Point(353, 14);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(69, 13);
            this.lbtennv.TabIndex = 34;
            this.lbtennv.Text = "Tên Nhân Viên";
            this.lbtennv.Click += new System.EventHandler(this.lbtennv_Click);
            // 
            // lbsocmnd
            // 
            this.lbsocmnd.Location = new System.Drawing.Point(353, 73);
            this.lbsocmnd.Name = "lbsocmnd";
            this.lbsocmnd.Size = new System.Drawing.Size(44, 13);
            this.lbsocmnd.TabIndex = 35;
            this.lbsocmnd.Text = "Số CMND";
            // 
            // lbmanv
            // 
            this.lbmanv.Location = new System.Drawing.Point(8, 15);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(65, 13);
            this.lbmanv.TabIndex = 30;
            this.lbmanv.Text = "Mã Nhân Viên";
            // 
            // cmbdate
            // 
            this.cmbdate.EditValue = new System.DateTime(2012, 11, 13, 0, 0, 0, 0);
            this.cmbdate.Location = new System.Drawing.Point(110, 70);
            this.cmbdate.Name = "cmbdate";
            this.cmbdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbdate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cmbdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbdate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.cmbdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbdate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.cmbdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbdate.Size = new System.Drawing.Size(228, 20);
            this.cmbdate.TabIndex = 4;
            this.cmbdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdate_KeyPress);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(401, 139);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 7;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykho.Properties.Resources.save1;
            this.btLuu.Location = new System.Drawing.Point(248, 139);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(124, 40);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // txtsoCMND
            // 
            this.txtsoCMND.Location = new System.Drawing.Point(455, 70);
            this.txtsoCMND.Name = "txtsoCMND";
            this.txtsoCMND.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsoCMND.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtsoCMND.Size = new System.Drawing.Size(228, 20);
            this.txtsoCMND.TabIndex = 5;
            this.txtsoCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoCMND_KeyPress);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(455, 35);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtsdt.Size = new System.Drawing.Size(228, 20);
            this.txtsdt.TabIndex = 57;
            // 
            // checkTT
            // 
            this.checkTT.Location = new System.Drawing.Point(108, 104);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Kích Hoạt";
            this.checkTT.Size = new System.Drawing.Size(82, 19);
            this.checkTT.TabIndex = 140;
            // 
            // lbtinhtrang
            // 
            this.lbtinhtrang.Location = new System.Drawing.Point(7, 107);
            this.lbtinhtrang.Name = "lbtinhtrang";
            this.lbtinhtrang.Size = new System.Drawing.Size(49, 13);
            this.lbtinhtrang.TabIndex = 141;
            this.lbtinhtrang.Text = "Tình trạng";
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 195);
            this.Controls.Add(this.checkTT);
            this.Controls.Add(this.lbtinhtrang);
            this.Controls.Add(this.cmbdate);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.lbchuy);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.lbsodt);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.lbsocmnd);
            this.Controls.Add(this.lbmanv);
            this.Controls.Add(this.txtsoCMND);
            this.Controls.Add(this.txtsdt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sửa Nhân Viên";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lbchuy;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtmanv;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.TextEdit txttennv;
        private DevExpress.XtraEditors.LabelControl lbsodt;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lbdiachi;
        private DevExpress.XtraEditors.LabelControl lbngaysinh;
        private DevExpress.XtraEditors.LabelControl lbtennv;
        private DevExpress.XtraEditors.LabelControl lbsocmnd;
        private DevExpress.XtraEditors.LabelControl lbmanv;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet13TableAdapters.BOPHANTableAdapter bOPHANTableAdapter;
        //private XUAT_NHAPTONDataSet15 xUAT_NHAPTONDataSet15;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet15TableAdapters.BOPHANTableAdapter bOPHANTableAdapter1;
        //private XUAT_NHAPTONDataSet16 xUAT_NHAPTONDataSet16;
        //private WindowsFormsApplication1.XUAT_NHAPTONDataSet16TableAdapters.BOPHANTableAdapter bOPHANTableAdapter2;
        private DevExpress.XtraEditors.DateEdit cmbdate;
        //private XUAT_NHAPTONDataSet15 xuaT_NHAPTONDataSet151;
        //private XUAT_NHAPTONDataSet16 xuaT_NHAPTONDataSet161;
        private DevExpress.XtraEditors.CalcEdit txtsoCMND;
        private DevExpress.XtraEditors.CalcEdit txtsdt;
        private DevExpress.XtraEditors.CheckEdit checkTT;
        private DevExpress.XtraEditors.LabelControl lbtinhtrang;
    }
}