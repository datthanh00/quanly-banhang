namespace WindowsFormsApplication1
{
    partial class frmSuaBoPhan
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbtinhtrang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtinhtrang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(83, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 97;
            this.labelControl4.Text = "(*)";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(105, 19);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(192, 20);
            this.txtma.TabIndex = 96;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(105, 45);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(192, 20);
            this.txtten.TabIndex = 92;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(83, 46);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 90;
            this.labelControl14.Text = "(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(83, 20);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 88;
            this.labelControl12.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 87;
            this.labelControl7.Text = "Tình Trạng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "Tên Bộ Phận";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 89;
            this.labelControl1.Text = "Mã Bộ Phận";
            // 
            // cmbtinhtrang
            // 
            this.cmbtinhtrang.Location = new System.Drawing.Point(105, 76);
            this.cmbtinhtrang.Name = "cmbtinhtrang";
            this.cmbtinhtrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbtinhtrang.Properties.Items.AddRange(new object[] {
            "Kích Hoạt",
            "Chưa Kích Hoạt"});
            this.cmbtinhtrang.Size = new System.Drawing.Size(192, 20);
            this.cmbtinhtrang.TabIndex = 98;
            // 
            // btDong
            // 
            this.btDong.Image = global::WindowsFormsApplication1.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(154, 111);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 95;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::WindowsFormsApplication1.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(24, 111);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 94;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // frmSuaBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 165);
            this.Controls.Add(this.cmbtinhtrang);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmSuaBoPhan";
            this.Text = "frmSuaBoPhan";
            this.Load += new System.EventHandler(this.frmSuaBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtinhtrang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbtinhtrang;
    }
}