namespace WindowsFormsApplication1
{
    partial class frmKhoiPhuc
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
            this.lbChonTapTinh = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTapTin = new DevExpress.XtraEditors.TextEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btKhoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTapTin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChonTapTinh
            // 
            this.lbChonTapTinh.Location = new System.Drawing.Point(41, 20);
            this.lbChonTapTinh.Name = "lbChonTapTinh";
            this.lbChonTapTinh.Size = new System.Drawing.Size(59, 13);
            this.lbChonTapTinh.TabIndex = 0;
            this.lbChonTapTinh.Text = "Chọn tập tin";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(419, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(57, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = ".  .  .";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTapTin
            // 
            this.txtTapTin.Location = new System.Drawing.Point(119, 17);
            this.txtTapTin.Name = "txtTapTin";
            this.txtTapTin.Properties.ReadOnly = true;
            this.txtTapTin.Size = new System.Drawing.Size(276, 20);
            this.txtTapTin.TabIndex = 1;
            // 
            // btDong
            // 
            this.btDong.Image = global::Quanlykho.Properties.Resources.close4;
            this.btDong.Location = new System.Drawing.Point(302, 55);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(93, 34);
            this.btDong.TabIndex = 4;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btKhoiPhuc
            // 
            this.btKhoiPhuc.Image = global::Quanlykho.Properties.Resources.undo;
            this.btKhoiPhuc.Location = new System.Drawing.Point(175, 55);
            this.btKhoiPhuc.Name = "btKhoiPhuc";
            this.btKhoiPhuc.Size = new System.Drawing.Size(101, 34);
            this.btKhoiPhuc.TabIndex = 3;
            this.btKhoiPhuc.Text = "Khôi phục";
            this.btKhoiPhuc.Click += new System.EventHandler(this.btKhoiPhuc_Click);
            // 
            // frmKhoiPhuc
            // 
            this.ClientSize = new System.Drawing.Size(557, 101);
            this.Controls.Add(this.txtTapTin);
            this.Controls.Add(this.btKhoiPhuc);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbChonTapTinh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKhoiPhuc";
            this.Text = "Khôi phục";
            this.Load += new System.EventHandler(this.frmKhoiPhuc_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhoiPhuc_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtTapTin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbChonTapTinh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtTapTin;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btKhoiPhuc;
    }
}