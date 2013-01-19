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
            this.button4 = new System.Windows.Forms.Button();
            this.cbTable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mo = new System.Windows.Forms.OpenFileDialog();
            this.txtsql = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button5 = new System.Windows.Forms.Button();
            this.btncomputerdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btncomputerdate);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cbTable);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.excel;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(359, 20);
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
            this.cbTable.Size = new System.Drawing.Size(100, 20);
            this.cbTable.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(498, 21);
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
            this.button2.Location = new System.Drawing.Point(213, 20);
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
            this.txtsql.Location = new System.Drawing.Point(16, 436);
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
            this.button5.Location = new System.Drawing.Point(735, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 43);
            this.button5.TabIndex = 36;
            this.button5.Text = "Truy Vấn SQL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btncomputerdate
            // 
            this.btncomputerdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btncomputerdate.Image = global::WindowsFormsApplication1.Properties.Resources.check;
            this.btncomputerdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncomputerdate.Location = new System.Drawing.Point(680, 20);
            this.btncomputerdate.Name = "btncomputerdate";
            this.btncomputerdate.Size = new System.Drawing.Size(122, 30);
            this.btncomputerdate.TabIndex = 40;
            this.btncomputerdate.Text = "COMPUTER DATE";
            this.btncomputerdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncomputerdate.UseVisualStyleBackColor = true;
            this.btncomputerdate.Click += new System.EventHandler(this.btncomputerdate_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 506);
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
            this.ResumeLayout(false);

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
    }
}