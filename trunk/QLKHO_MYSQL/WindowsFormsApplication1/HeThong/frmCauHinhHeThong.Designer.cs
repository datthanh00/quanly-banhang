namespace WindowsFormsApplication1
{
    partial class frmCauHinhHeThong
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTenMayChu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tab = new DevExpress.XtraTab.XtraTabControl();
            this.listnetwork = new DevExpress.XtraTab.XtraTabPage();
            this.listBoxnetwork = new DevExpress.XtraEditors.ListBoxControl();
            this.listLocal = new DevExpress.XtraTab.XtraTabPage();
            this.listBoxLocal = new DevExpress.XtraEditors.ListBoxControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenMayChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.tab.SuspendLayout();
            this.listnetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxnetwork)).BeginInit();
            this.listLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(300, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cấu Hình Hệ Thống";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(285, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Máy Chủ";
            // 
            // cbTenMayChu
            // 
            this.cbTenMayChu.Location = new System.Drawing.Point(359, 74);
            this.cbTenMayChu.Name = "cbTenMayChu";
            this.cbTenMayChu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenMayChu.Size = new System.Drawing.Size(127, 20);
            this.cbTenMayChu.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(359, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tài Khoản SQL Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(359, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tài Khoản Windows";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(285, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(359, 157);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(127, 20);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(285, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mật Khẩu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(285, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tên Dữ Liệu";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Location = new System.Drawing.Point(359, 211);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDatabase.Size = new System.Drawing.Size(127, 20);
            this.cbDatabase.TabIndex = 2;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::WindowsFormsApplication1.Properties.Resources.close4;
            this.simpleButton4.Location = new System.Drawing.Point(412, 250);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 35);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Đóng";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.simpleButton3.Location = new System.Drawing.Point(300, 250);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 35);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Thực Hiện";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::WindowsFormsApplication1.Properties.Resources.refresh1;
            this.simpleButton2.Location = new System.Drawing.Point(492, 208);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(26, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::WindowsFormsApplication1.Properties.Resources.refresh1;
            this.simpleButton1.Location = new System.Drawing.Point(492, 71);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tab
            // 
            this.tab.Location = new System.Drawing.Point(12, 29);
            this.tab.Name = "tab";
            this.tab.SelectedTabPage = this.listnetwork;
            this.tab.Size = new System.Drawing.Size(265, 256);
            this.tab.TabIndex = 11;
            this.tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.listLocal,
            this.listnetwork});
            this.tab.Click += new System.EventHandler(this.tab_Click);
            // 
            // listnetwork
            // 
            this.listnetwork.Controls.Add(this.listBoxnetwork);
            this.listnetwork.Name = "listnetwork";
            this.listnetwork.Size = new System.Drawing.Size(258, 228);
            this.listnetwork.Text = "Mạng lan";
            // 
            // listBoxnetwork
            // 
            this.listBoxnetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxnetwork.Location = new System.Drawing.Point(0, 0);
            this.listBoxnetwork.Name = "listBoxnetwork";
            this.listBoxnetwork.Size = new System.Drawing.Size(258, 228);
            this.listBoxnetwork.TabIndex = 0;
            this.listBoxnetwork.SelectedIndexChanged += new System.EventHandler(this.listBoxnetwork_SelectedIndexChanged);
            // 
            // listLocal
            // 
            this.listLocal.Controls.Add(this.listBoxLocal);
            this.listLocal.Name = "listLocal";
            this.listLocal.Size = new System.Drawing.Size(258, 228);
            this.listLocal.Text = "Mạng nội bộ";
            // 
            // listBoxLocal
            // 
            this.listBoxLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLocal.Location = new System.Drawing.Point(0, 0);
            this.listBoxLocal.Name = "listBoxLocal";
            this.listBoxLocal.Size = new System.Drawing.Size(258, 228);
            this.listBoxLocal.TabIndex = 1;
            this.listBoxLocal.SelectedIndexChanged += new System.EventHandler(this.listBoxLocal_SelectedIndexChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(359, 183);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(127, 20);
            this.txtMatKhau.TabIndex = 5;
            // 
            // frmCauHinhHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.cbTenMayChu);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Xmas 2008 Blue";
            this.Name = "frmCauHinhHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu Hình Hệ Thống";
            this.Load += new System.EventHandler(this.frmCauHinhHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbTenMayChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.tab.ResumeLayout(false);
            this.listnetwork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxnetwork)).EndInit();
            this.listLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbTenMayChu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraTab.XtraTabControl tab;
        private DevExpress.XtraTab.XtraTabPage listnetwork;
        private DevExpress.XtraTab.XtraTabPage listLocal;
        private DevExpress.XtraEditors.ListBoxControl listBoxnetwork;
        private DevExpress.XtraEditors.ListBoxControl listBoxLocal;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
    }
}