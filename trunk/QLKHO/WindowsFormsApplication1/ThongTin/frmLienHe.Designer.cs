namespace WindowsFormsApplication1
{
    partial class frmLienHe
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lbThanhVien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::WindowsFormsApplication1.Properties.Resources.close4;
            this.simpleButton2.Location = new System.Drawing.Point(245, 253);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Kết thúc";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lbThanhVien
            // 
            this.lbThanhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhVien.Appearance.Options.UseFont = true;
            this.lbThanhVien.Location = new System.Drawing.Point(95, 30);
            this.lbThanhVien.Name = "lbThanhVien";
            this.lbThanhVien.Size = new System.Drawing.Size(422, 25);
            this.lbThanhVien.TabIndex = 7;
            this.lbThanhVien.Text = "Phần mềm quản lý kho cửa hàng Tuấn Hạnh";
            this.lbThanhVien.Click += new System.EventHandler(this.lbThanhVien_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(90, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Thuộc bản quyền của Tác giả :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(258, 179);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Phone: 0907 093 902";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(258, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Nguyễn Đạt Thành";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(258, 133);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(147, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Email : datthanh39@gmail.com";
            // 
            // frmLienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 296);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbThanhVien);
            this.Controls.Add(this.simpleButton2);
            this.Name = "frmLienHe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLienHe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl lbThanhVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;


    }
}