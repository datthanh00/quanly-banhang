namespace WindowsFormsApplication1
{
    partial class frmxoahd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lbPhanMem = new DevExpress.XtraEditors.LabelControl();
            this.txtlydo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 258);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(443, 60);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kết thúc";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::WindowsFormsApplication1.Properties.Resources.close4;
            this.simpleButton1.Location = new System.Drawing.Point(285, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 31);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đóng và không xóa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::WindowsFormsApplication1.Properties.Resources.save1;
            this.simpleButton2.Location = new System.Drawing.Point(69, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 31);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Xóa và in hóa đơn";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lbPhanMem
            // 
            this.lbPhanMem.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanMem.Appearance.Options.UseFont = true;
            this.lbPhanMem.Location = new System.Drawing.Point(33, 12);
            this.lbPhanMem.Name = "lbPhanMem";
            this.lbPhanMem.Size = new System.Drawing.Size(378, 23);
            this.lbPhanMem.TabIndex = 4;
            this.lbPhanMem.Text = "Bạn Có Chắc Muốn Xóa Mặt hàng này Không";
            // 
            // txtlydo
            // 
            // 
            // 
            // 
            this.txtlydo.Border.Class = "TextBoxBorder";
            this.txtlydo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlydo.Location = new System.Drawing.Point(12, 84);
            this.txtlydo.Multiline = true;
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(412, 138);
            this.txtlydo.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Lý Do Xóa Mặt Hàng Này:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 234);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(195, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Lưu ý chỉ xóa được mặt hàng trong ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 232);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 24);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "*";
            // 
            // frmxoahd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 318);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtlydo);
            this.Controls.Add(this.lbPhanMem);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmxoahd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongTinNhom";
            this.Load += new System.EventHandler(this.frmxoahd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbPhanMem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlydo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}