namespace WindowsFormsApplication1
{
    partial class frmSaoLuu
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
            this.txtTenFile = new DevExpress.XtraEditors.TextEdit();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.lbTenFile = new DevExpress.XtraEditors.LabelControl();
            this.lbDuongDan = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenFile
            // 
            this.txtTenFile.Location = new System.Drawing.Point(129, 11);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(160, 20);
            this.txtTenFile.TabIndex = 14;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(129, 47);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(160, 20);
            this.txtDuongDan.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(302, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(37, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = ".  .  .";
            this.simpleButton1.ToolTip = "Select file";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.btLuu.Location = new System.Drawing.Point(129, 86);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(77, 34);
            this.btLuu.TabIndex = 15;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = global::WindowsFormsApplication1.Properties.Resources.close4;
            this.btDong.Location = new System.Drawing.Point(237, 86);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(81, 34);
            this.btDong.TabIndex = 15;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // lbTenFile
            // 
            this.lbTenFile.Location = new System.Drawing.Point(57, 18);
            this.lbTenFile.Name = "lbTenFile";
            this.lbTenFile.Size = new System.Drawing.Size(42, 13);
            this.lbTenFile.TabIndex = 16;
            this.lbTenFile.Text = "Tên file :";
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.Location = new System.Drawing.Point(57, 54);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(54, 13);
            this.lbDuongDan.TabIndex = 16;
            this.lbDuongDan.Text = "Đường dẫn";
            // 
            // frmSaoLuu
            // 
            this.ClientSize = new System.Drawing.Size(432, 142);
            this.Controls.Add(this.lbDuongDan);
            this.Controls.Add(this.lbTenFile);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSaoLuu";
            this.Text = "Sao lưu";
            this.Load += new System.EventHandler(this.frmSaoLuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        // private System.Windows.Forms.Timer ticker;
        private DevExpress.XtraEditors.TextEdit txtTenFile;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.LabelControl lbTenFile;
        private DevExpress.XtraEditors.LabelControl lbDuongDan;
    }
}