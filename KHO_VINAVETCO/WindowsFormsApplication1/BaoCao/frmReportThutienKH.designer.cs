namespace WindowsFormsApplication1
{
    partial class frmReportThutienKH
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãphiếuthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãnhânviên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMãhóađơnxuất = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàythu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiềnđãtrả = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienno = new DevExpress.XtraReports.UI.XRLabel();
            this.tientra = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTienno = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTientra = new DevExpress.XtraReports.UI.XRLabel();
            this.ngay = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.NhanVien = new DevExpress.XtraReports.UI.XRLabel();
            this.lbMaNV = new DevExpress.XtraReports.UI.XRLabel();
            this.lbMaPT = new DevExpress.XtraReports.UI.XRLabel();
            this.lbMahdx = new DevExpress.XtraReports.UI.XRLabel();
            this.phieuthu = new DevExpress.XtraReports.UI.XRLabel();
            this.hdx = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lbFax = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiachi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbTieude1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLbCt = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDT = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lbKi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbttinphai = new DevExpress.XtraReports.UI.XRLabel();
            this.lbingiua = new DevExpress.XtraReports.UI.XRLabel();
            this.lbintrai = new DevExpress.XtraReports.UI.XRLabel();
            this.lbKi2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgayThang = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1,
            this.tienno,
            this.tientra,
            this.lbTienno,
            this.lbTientra,
            this.ngay,
            this.lbNgay,
            this.NhanVien,
            this.lbMaNV,
            this.lbMaPT,
            this.lbMahdx,
            this.phieuthu,
            this.hdx});
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Detail.HeightF = 293F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 98.00002F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(615F, 178F);
            this.winControlContainer1.WinControl = this.gridControl1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 171);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãphiếuthu,
            this.colMãnhânviên,
            this.colMãhóađơnxuất,
            this.colNgàythu,
            this.colTiềnđãtrả});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colMãphiếuthu
            // 
            this.colMãphiếuthu.FieldName = "Mã phiếu thu";
            this.colMãphiếuthu.Name = "colMãphiếuthu";
            this.colMãphiếuthu.Visible = true;
            this.colMãphiếuthu.VisibleIndex = 0;
            // 
            // colMãnhânviên
            // 
            this.colMãnhânviên.FieldName = "Mã nhân viên";
            this.colMãnhânviên.Name = "colMãnhânviên";
            this.colMãnhânviên.Visible = true;
            this.colMãnhânviên.VisibleIndex = 1;
            // 
            // colMãhóađơnxuất
            // 
            this.colMãhóađơnxuất.FieldName = "Mã hóa đơn xuất";
            this.colMãhóađơnxuất.Name = "colMãhóađơnxuất";
            this.colMãhóađơnxuất.Visible = true;
            this.colMãhóađơnxuất.VisibleIndex = 2;
            // 
            // colNgàythu
            // 
            this.colNgàythu.FieldName = "Ngày thu";
            this.colNgàythu.Name = "colNgàythu";
            this.colNgàythu.Visible = true;
            this.colNgàythu.VisibleIndex = 3;
            // 
            // colTiềnđãtrả
            // 
            this.colTiềnđãtrả.FieldName = "Tiền đã trả";
            this.colTiềnđãtrả.Name = "colTiềnđãtrả";
            this.colTiềnđãtrả.Visible = true;
            this.colTiềnđãtrả.VisibleIndex = 4;
            // 
            // tienno
            // 
            this.tienno.LocationFloat = new DevExpress.Utils.PointFloat(175F, 73.00002F);
            this.tienno.Name = "tienno";
            this.tienno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tienno.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // tientra
            // 
            this.tientra.LocationFloat = new DevExpress.Utils.PointFloat(175F, 48.00002F);
            this.tientra.Name = "tientra";
            this.tientra.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tientra.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // lbTienno
            // 
            this.lbTienno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTienno.LocationFloat = new DevExpress.Utils.PointFloat(50F, 73.00002F);
            this.lbTienno.Name = "lbTienno";
            this.lbTienno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTienno.SizeF = new System.Drawing.SizeF(112.5F, 23F);
            this.lbTienno.StylePriority.UseFont = false;
            this.lbTienno.Text = "Tiền nợ";
            // 
            // lbTientra
            // 
            this.lbTientra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTientra.LocationFloat = new DevExpress.Utils.PointFloat(50F, 48.00002F);
            this.lbTientra.Name = "lbTientra";
            this.lbTientra.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTientra.SizeF = new System.Drawing.SizeF(112.5F, 23F);
            this.lbTientra.StylePriority.UseFont = false;
            this.lbTientra.Text = "Tiền trả";
            // 
            // ngay
            // 
            this.ngay.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
            this.ngay.Name = "ngay";
            this.ngay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ngay.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // lbNgay
            // 
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNgay.LocationFloat = new DevExpress.Utils.PointFloat(400F, 0F);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgay.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNgay.StylePriority.UseFont = false;
            this.lbNgay.Text = "Ngày lập";
            // 
            // NhanVien
            // 
            this.NhanVien.LocationFloat = new DevExpress.Utils.PointFloat(500F, 25F);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.NhanVien.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // lbMaNV
            // 
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMaNV.LocationFloat = new DevExpress.Utils.PointFloat(400F, 25F);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbMaNV.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbMaNV.StylePriority.UseFont = false;
            this.lbMaNV.Text = "Nhân Viên";
            // 
            // lbMaPT
            // 
            this.lbMaPT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMaPT.LocationFloat = new DevExpress.Utils.PointFloat(50F, 25F);
            this.lbMaPT.Name = "lbMaPT";
            this.lbMaPT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbMaPT.SizeF = new System.Drawing.SizeF(112.5F, 23.00002F);
            this.lbMaPT.StylePriority.UseFont = false;
            this.lbMaPT.Text = "Mã phiếu thu";
            // 
            // lbMahdx
            // 
            this.lbMahdx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbMahdx.LocationFloat = new DevExpress.Utils.PointFloat(50F, 0F);
            this.lbMahdx.Name = "lbMahdx";
            this.lbMahdx.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbMahdx.SizeF = new System.Drawing.SizeF(112.5F, 23F);
            this.lbMahdx.StylePriority.UseFont = false;
            this.lbMahdx.Text = "Mã Hóa đơn xuất";
            // 
            // phieuthu
            // 
            this.phieuthu.LocationFloat = new DevExpress.Utils.PointFloat(175F, 25F);
            this.phieuthu.Name = "phieuthu";
            this.phieuthu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.phieuthu.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // hdx
            // 
            this.hdx.LocationFloat = new DevExpress.Utils.PointFloat(175F, 0F);
            this.hdx.Name = "hdx";
            this.hdx.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.hdx.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbFax,
            this.xrLabel3,
            this.xrLabel6,
            this.lbDiachi,
            this.xrLabel2,
            this.xrLbTieude1,
            this.xrLbCt,
            this.lbDT});
            this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TopMargin.HeightF = 191F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseFont = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbFax
            // 
            this.lbFax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbFax.LocationFloat = new DevExpress.Utils.PointFloat(389.5833F, 78.20832F);
            this.lbFax.Name = "lbFax";
            this.lbFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbFax.SizeF = new System.Drawing.SizeF(99.99997F, 26.12499F);
            this.lbFax.StylePriority.UseFont = false;
            this.lbFax.Text = "Fax";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(500F, 78.2083F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 26.12503F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(101.0417F, 42.04168F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(548.9582F, 23F);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // lbDiachi
            // 
            this.lbDiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(1.041698F, 42.04168F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.Text = "Đỉa chỉ";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(270.8333F, 79.77081F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLbTieude1
            // 
            this.xrLbTieude1.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLbTieude1.LocationFloat = new DevExpress.Utils.PointFloat(144.7916F, 121.7917F);
            this.xrLbTieude1.Name = "xrLbTieude1";
            this.xrLbTieude1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLbTieude1.SizeF = new System.Drawing.SizeF(327.0834F, 44.625F);
            this.xrLbTieude1.StylePriority.UseFont = false;
            this.xrLbTieude1.StylePriority.UseTextAlignment = false;
            this.xrLbTieude1.Text = "Công nợ Khách Hàng";
            this.xrLbTieude1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLbCt
            // 
            this.xrLbCt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrLbCt.LocationFloat = new DevExpress.Utils.PointFloat(1.041698F, 0F);
            this.xrLbCt.Name = "xrLbCt";
            this.xrLbCt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLbCt.SizeF = new System.Drawing.SizeF(648.9583F, 42.04167F);
            this.xrLbCt.StylePriority.UseFont = false;
            this.xrLbCt.StylePriority.UseTextAlignment = false;
            this.xrLbCt.Text = "xrLbCt";
            this.xrLbCt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbDT
            // 
            this.lbDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbDT.LocationFloat = new DevExpress.Utils.PointFloat(159.375F, 79.77081F);
            this.lbDT.Name = "lbDT";
            this.lbDT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDT.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbDT.StylePriority.UseFont = false;
            this.lbDT.Text = "Số điện thoại";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbNgayThang,
            this.lbKi,
            this.lbKi1,
            this.lbttinphai,
            this.lbingiua,
            this.lbintrai,
            this.lbKi2});
            this.BottomMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbKi
            // 
            this.lbKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75F);
            this.lbKi.Name = "lbKi";
            this.lbKi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbKi.StylePriority.UseFont = false;
            this.lbKi.StylePriority.UseTextAlignment = false;
            this.lbKi.Text = "(Kí ghi rỏ họ tên)";
            this.lbKi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbKi1
            // 
            this.lbKi1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi1.LocationFloat = new DevExpress.Utils.PointFloat(254.9999F, 75F);
            this.lbKi1.Name = "lbKi1";
            this.lbKi1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi1.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbKi1.StylePriority.UseFont = false;
            this.lbKi1.StylePriority.UseTextAlignment = false;
            this.lbKi1.Text = "(Kí ghi rỏ họ tên)";
            this.lbKi1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbttinphai
            // 
            this.lbttinphai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbttinphai.LocationFloat = new DevExpress.Utils.PointFloat(509.9998F, 50F);
            this.lbttinphai.Name = "lbttinphai";
            this.lbttinphai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbttinphai.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbttinphai.StylePriority.UseFont = false;
            this.lbttinphai.StylePriority.UseTextAlignment = false;
            this.lbttinphai.Text = "Giám đốc";
            this.lbttinphai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbingiua
            // 
            this.lbingiua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbingiua.LocationFloat = new DevExpress.Utils.PointFloat(254.9999F, 50F);
            this.lbingiua.Name = "lbingiua";
            this.lbingiua.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbingiua.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbingiua.StylePriority.UseFont = false;
            this.lbingiua.StylePriority.UseTextAlignment = false;
            this.lbingiua.Text = "Kế toán trưởng";
            this.lbingiua.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbintrai
            // 
            this.lbintrai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbintrai.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
            this.lbintrai.Name = "lbintrai";
            this.lbintrai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbintrai.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbintrai.StylePriority.UseFont = false;
            this.lbintrai.StylePriority.UseTextAlignment = false;
            this.lbintrai.Text = "Người lập";
            this.lbintrai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbKi2
            // 
            this.lbKi2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKi2.LocationFloat = new DevExpress.Utils.PointFloat(509.9998F, 75F);
            this.lbKi2.Name = "lbKi2";
            this.lbKi2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKi2.SizeF = new System.Drawing.SizeF(140F, 20F);
            this.lbKi2.StylePriority.UseFont = false;
            this.lbKi2.StylePriority.UseTextAlignment = false;
            this.lbKi2.Text = "(Kí ghi rỏ họ tên)";
            this.lbKi2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.LocationFloat = new DevExpress.Utils.PointFloat(435.6672F, 10F);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayThang.SizeF = new System.Drawing.SizeF(207.3328F, 22.99994F);
            this.lbNgayThang.StylePriority.UseFont = false;
            this.lbNgayThang.Text = "Ngày ........ Tháng ........ Năm 201.....";
            // 
            // frmReportThutienKH
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 97, 191, 100);
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lbFax;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lbDiachi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLbTieude1;
        private DevExpress.XtraReports.UI.XRLabel xrLbCt;
        private DevExpress.XtraReports.UI.XRLabel ngay;
        private DevExpress.XtraReports.UI.XRLabel lbNgay;
        private DevExpress.XtraReports.UI.XRLabel NhanVien;
        private DevExpress.XtraReports.UI.XRLabel lbMaNV;
        private DevExpress.XtraReports.UI.XRLabel lbMaPT;
        private DevExpress.XtraReports.UI.XRLabel phieuthu;
        private DevExpress.XtraReports.UI.XRLabel tienno;
        private DevExpress.XtraReports.UI.XRLabel tientra;
        private DevExpress.XtraReports.UI.XRLabel lbTienno;
        private DevExpress.XtraReports.UI.XRLabel lbTientra;
        private DevExpress.XtraReports.UI.XRLabel lbMahdx;
        private DevExpress.XtraReports.UI.XRLabel hdx;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãphiếuthu;
        private DevExpress.XtraGrid.Columns.GridColumn colMãnhânviên;
        private DevExpress.XtraGrid.Columns.GridColumn colMãhóađơnxuất;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàythu;
        private DevExpress.XtraGrid.Columns.GridColumn colTiềnđãtrả;
        private DevExpress.XtraReports.UI.XRLabel lbDT;
        private DevExpress.XtraReports.UI.XRLabel lbKi;
        private DevExpress.XtraReports.UI.XRLabel lbKi1;
        private DevExpress.XtraReports.UI.XRLabel lbttinphai;
        private DevExpress.XtraReports.UI.XRLabel lbingiua;
        private DevExpress.XtraReports.UI.XRLabel lbintrai;
        private DevExpress.XtraReports.UI.XRLabel lbKi2;
        private DevExpress.XtraReports.UI.XRLabel lbNgayThang;
    }
}
