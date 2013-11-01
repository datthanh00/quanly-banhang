namespace WindowsFormsApplication1
{
    partial class frmThemNhomHang
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
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lbghichu = new DevExpress.XtraEditors.LabelControl();
            this.lbten = new DevExpress.XtraEditors.LabelControl();
            this.lbma = new DevExpress.XtraEditors.LabelControl();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lbchuy = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(141, 12);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(192, 20);
            this.txtma.TabIndex = 85;
            this.txtma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtma_KeyPress);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(141, 65);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(192, 20);
            this.txtghichu.TabIndex = 1;
            this.txtghichu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtghichu_KeyPress);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(141, 38);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(192, 20);
            this.txtten.TabIndex = 0;
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseBackColor = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(119, 39);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 13);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "(*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(119, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(14, 13);
            this.labelControl12.TabIndex = 77;
            this.labelControl12.Text = "(*)";
            // 
            // lbghichu
            // 
            this.lbghichu.Location = new System.Drawing.Point(35, 72);
            this.lbghichu.Name = "lbghichu";
            this.lbghichu.Size = new System.Drawing.Size(37, 13);
            this.lbghichu.TabIndex = 76;
            this.lbghichu.Text = "Ghi Chú";
            // 
            // lbten
            // 
            this.lbten.Location = new System.Drawing.Point(35, 43);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(76, 13);
            this.lbten.TabIndex = 80;
            this.lbten.Text = "Tên Nhóm Hàng";
            // 
            // lbma
            // 
            this.lbma.Location = new System.Drawing.Point(37, 15);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(72, 13);
            this.lbma.TabIndex = 78;
            this.lbma.Text = "Mã Nhóm Hàng";
            // 
            // btDong
            // 
            this.btDong.Image = global::WindowsFormsApplication1.Properties.Resources.close__2_;
            this.btDong.Location = new System.Drawing.Point(193, 124);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(123, 40);
            this.btDong.TabIndex = 3;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::WindowsFormsApplication1.Properties.Resources.save1;
            this.btluu.Location = new System.Drawing.Point(63, 124);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(124, 40);
            this.btluu.TabIndex = 2;
            this.btluu.Text = "Lưu";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(47, 100);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(14, 13);
            this.labelControl19.TabIndex = 87;
            this.labelControl19.Text = "(*)";
            // 
            // lbchuy
            // 
            this.lbchuy.Location = new System.Drawing.Point(70, 100);
            this.lbchuy.Name = "lbchuy";
            this.lbchuy.Size = new System.Drawing.Size(246, 13);
            this.lbchuy.TabIndex = 88;
            this.lbchuy.Text = "Xin Vui Lòng Nhập Những Thông Tin Bắt Buộc Nhập ";
            // 
            // frmThemNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 176);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.lbchuy);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.lbghichu);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThemNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sửa Nhóm Hàng";
            this.Load += new System.EventHandler(this.frmThemNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lbghichu;
        private DevExpress.XtraEditors.LabelControl lbten;
        private DevExpress.XtraEditors.LabelControl lbma;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lbchuy;

    }
}