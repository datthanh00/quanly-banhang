namespace WindowsFormsApplication1
{
    partial class frmKetso
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.lbTenFile = new DevExpress.XtraEditors.LabelControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Image = global::Quanlykho.Properties.Resources.check;
            this.btLuu.Location = new System.Drawing.Point(158, 83);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(102, 34);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Kết Sổ";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close4;
            this.btDong.Location = new System.Drawing.Point(294, 83);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(102, 34);
            this.btDong.TabIndex = 3;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // lbTenFile
            // 
            this.lbTenFile.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbTenFile.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbTenFile.Appearance.Options.UseFont = true;
            this.lbTenFile.Appearance.Options.UseForeColor = true;
            this.lbTenFile.Location = new System.Drawing.Point(12, 25);
            this.lbTenFile.Name = "lbTenFile";
            this.lbTenFile.Size = new System.Drawing.Size(293, 16);
            this.lbTenFile.TabIndex = 16;
            this.lbTenFile.Text = "BẠN PHẢI BACKUP DỮ LIỆU TRƯỚC KHI KẾT SỔ.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 93);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sao Lưu Dữ Liệu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(370, 16);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "KHI KẾT SỔ HÀNG TỒN KHO VÀ CÔNG NỢ SẼ TRỞ VỀ ĐẦU KÌ.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(340, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "GHI CHÚ: KẾT SỔ LÀ XÓA TOÀN BỘ DỮ LIỆU PHÁT SINH";
            // 
            // frmKetso
            // 
            this.ClientSize = new System.Drawing.Size(432, 142);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbTenFile);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKetso";
            this.Text = "Kết Sổ & Sao Lưu Dữ Liệu";
            this.Load += new System.EventHandler(this.frmSaoLuu_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKetso_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        // private System.Windows.Forms.Timer ticker;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.LabelControl lbTenFile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}