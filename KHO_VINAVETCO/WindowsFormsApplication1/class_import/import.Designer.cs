namespace WindowsFormsApplication1.class_import
{
    partial class import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(import));
            this.tientrinh = new System.Windows.Forms.ProgressBar();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncomputerdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbTable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mo = new System.Windows.Forms.OpenFileDialog();
            this.txtsql = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button5 = new System.Windows.Forms.Button();
            this.cboTenNCC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtsoluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button6 = new System.Windows.Forms.Button();
            this.txtlohang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbmathue = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEDITMAHD = new System.Windows.Forms.Button();
            this.checkTT = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tientrinh
            // 
            this.tientrinh.Location = new System.Drawing.Point(11, 400);
            this.tientrinh.Name = "tientrinh";
            this.tientrinh.Size = new System.Drawing.Size(872, 19);
            this.tientrinh.TabIndex = 5;
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(11, 64);
            this.luoi.Name = "luoi";
            this.luoi.RowTemplate.Height = 23;
            this.luoi.Size = new System.Drawing.Size(872, 330);
            this.luoi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkTT);
            this.groupBox1.Controls.Add(this.btncomputerdate);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cbTable);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btncomputerdate
            // 
            this.btncomputerdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btncomputerdate.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.btncomputerdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncomputerdate.Location = new System.Drawing.Point(739, 20);
            this.btncomputerdate.Name = "btncomputerdate";
            this.btncomputerdate.Size = new System.Drawing.Size(122, 30);
            this.btncomputerdate.TabIndex = 40;
            this.btncomputerdate.Text = "COMPUTER DATE";
            this.btncomputerdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncomputerdate.UseVisualStyleBackColor = true;
            this.btncomputerdate.Click += new System.EventHandler(this.btncomputerdate_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.excel;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(530, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 30);
            this.button4.TabIndex = 39;
            this.button4.Text = "Export excell";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbTable
            // 
            this.cbTable.Location = new System.Drawing.Point(107, 26);
            this.cbTable.Name = "cbTable";
            this.cbTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTable.Size = new System.Drawing.Size(171, 20);
            this.cbTable.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(652, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 37;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(386, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "Lưu Vào Database";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "Mở Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mo
            // 
            this.mo.FileName = "openFileDialog1";
            // 
            // txtsql
            // 
            // 
            // 
            // 
            this.txtsql.Border.Class = "TextBoxBorder";
            this.txtsql.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsql.Location = new System.Drawing.Point(16, 427);
            this.txtsql.Multiline = true;
            this.txtsql.Name = "txtsql";
            this.txtsql.Size = new System.Drawing.Size(533, 52);
            this.txtsql.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(577, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 43);
            this.button5.TabIndex = 36;
            this.button5.Text = "Truy Vấn SQL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.Location = new System.Drawing.Point(16, 492);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenNCC.Properties.NullText = "";
            this.cboTenNCC.Properties.PopupSizeable = false;
            this.cboTenNCC.Properties.View = this.gridView3;
            this.cboTenNCC.Size = new System.Drawing.Size(262, 20);
            this.cboTenNCC.TabIndex = 37;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Mặt Hàng";
            this.gridColumn3.FieldName = "MAMH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Mặt Hàng";
            this.gridColumn4.FieldName = "TENMH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số Lượng";
            this.gridColumn1.FieldName = "SOLUONGMH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // txtsoluong
            // 
            // 
            // 
            // 
            this.txtsoluong.Border.Class = "TextBoxBorder";
            this.txtsoluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsoluong.Location = new System.Drawing.Point(331, 488);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(90, 21);
            this.txtsoluong.TabIndex = 38;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Image = global::WindowsFormsApplication1.Properties.Resources.edit2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(577, 485);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 33);
            this.button6.TabIndex = 39;
            this.button6.Text = "UPDATE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtlohang
            // 
            // 
            // 
            // 
            this.txtlohang.Border.Class = "TextBoxBorder";
            this.txtlohang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlohang.Location = new System.Drawing.Point(476, 488);
            this.txtlohang.Name = "txtlohang";
            this.txtlohang.Size = new System.Drawing.Size(90, 21);
            this.txtlohang.TabIndex = 40;
            // 
            // lbmathue
            // 
            this.lbmathue.Enabled = false;
            this.lbmathue.Location = new System.Drawing.Point(286, 495);
            this.lbmathue.Name = "lbmathue";
            this.lbmathue.Size = new System.Drawing.Size(38, 13);
            this.lbmathue.TabIndex = 137;
            this.lbmathue.Text = "SL thêm";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(426, 495);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 138;
            this.labelControl1.Text = "Lo Hang";
            // 
            // btnEDITMAHD
            // 
            this.btnEDITMAHD.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEDITMAHD.Image = global::WindowsFormsApplication1.Properties.Resources.undo;
            this.btnEDITMAHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDITMAHD.Location = new System.Drawing.Point(750, 485);
            this.btnEDITMAHD.Name = "btnEDITMAHD";
            this.btnEDITMAHD.Size = new System.Drawing.Size(108, 33);
            this.btnEDITMAHD.TabIndex = 139;
            this.btnEDITMAHD.Text = "EDIT MAHD";
            this.btnEDITMAHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDITMAHD.UseVisualStyleBackColor = true;
            this.btnEDITMAHD.Click += new System.EventHandler(this.btnEDITMAHD_Click);
            // 
            // checkTT
            // 
            this.checkTT.EditValue = true;
            this.checkTT.Location = new System.Drawing.Point(291, 26);
            this.checkTT.Name = "checkTT";
            this.checkTT.Properties.Caption = "Update";
            this.checkTT.Size = new System.Drawing.Size(82, 19);
            this.checkTT.TabIndex = 41;
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 568);
            this.Controls.Add(this.btnEDITMAHD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbmathue);
            this.Controls.Add(this.txtlohang);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.cboTenNCC);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtsql);
            this.Controls.Add(this.tientrinh);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "import";
            this.Text = "import";
            this.Load += new System.EventHandler(this.import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar tientrinh;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog mo;
        private DevExpress.XtraEditors.ComboBoxEdit cbTable;
        private System.Windows.Forms.Button button4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsql;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btncomputerdate;
        private DevExpress.XtraEditors.GridLookUpEdit cboTenNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsoluong;
        private System.Windows.Forms.Button button6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtlohang;
        private DevExpress.XtraEditors.LabelControl lbmathue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnEDITMAHD;
        private DevExpress.XtraEditors.CheckEdit checkTT;
    }
}