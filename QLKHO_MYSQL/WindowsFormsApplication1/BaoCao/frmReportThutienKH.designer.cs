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
            this.xuaT_NHAPTONTTCT1 = new WindowsFormsApplication1.XUAT_NHAPTONTTCT();
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
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lbKhachHang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNTN = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgLap = new DevExpress.XtraReports.UI.XRLabel();
            this.tHONGTINCTTableAdapter = new WindowsFormsApplication1.XUAT_NHAPTONTTCTTableAdapters.THONGTINCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).BeginInit();
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
            this.gridControl1.DataSource = this.xuaT_NHAPTONTTCT1;
            this.gridControl1.Location = new System.Drawing.Point(1, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 171);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xuaT_NHAPTONTTCT1
            // 
            this.xuaT_NHAPTONTTCT1.DataSetName = "XUAT_NHAPTONTTCT";
            this.xuaT_NHAPTONTTCT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lbDT,
            this.xrPictureBox1});
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
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.FAX")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(500F, 78.20829F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 26.12503F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.DIACHI")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(270.8333F, 42.04167F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // lbDiachi
            // 
            this.lbDiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(159.375F, 42.04167F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.Text = "Đỉa chỉ";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.SDT")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(270.8333F, 81.33332F);
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
            this.xrLbCt.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "THONGTINCT.TENCT")});
            this.xrLbCt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrLbCt.LocationFloat = new DevExpress.Utils.PointFloat(175F, 0F);
            this.xrLbCt.Name = "xrLbCt";
            this.xrLbCt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLbCt.SizeF = new System.Drawing.SizeF(258.3333F, 42.04167F);
            this.xrLbCt.StylePriority.UseFont = false;
            this.xrLbCt.StylePriority.UseTextAlignment = false;
            this.xrLbCt.Text = "xrLbCt";
            this.xrLbCt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbDT
            // 
            this.lbDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbDT.LocationFloat = new DevExpress.Utils.PointFloat(159.375F, 81.33332F);
            this.lbDT.Name = "lbDT";
            this.lbDT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDT.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbDT.StylePriority.UseFont = false;
            this.lbDT.Text = "Số điện thoại";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "THONGTINCT.LOGO")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(142.7083F, 107.4584F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbKhachHang,
            this.lbNTN,
            this.lbNgLap});
            this.BottomMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.LocationFloat = new DevExpress.Utils.PointFloat(525F, 23.54164F);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbKhachHang.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // lbNTN
            // 
            this.lbNTN.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 23.54164F);
            this.lbNTN.Name = "lbNTN";
            this.lbNTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNTN.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNTN.Text = "lbNTN";
            // 
            // lbNgLap
            // 
            this.lbNgLap.LocationFloat = new DevExpress.Utils.PointFloat(254.1667F, 23.54164F);
            this.lbNgLap.Name = "lbNgLap";
            this.lbNgLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgLap.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNgLap.Text = "lbNgLap";
            // 
            // tHONGTINCTTableAdapter
            // 
            this.tHONGTINCTTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportThutienKH
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.tHONGTINCTTableAdapter;
            this.DataMember = "THONGTINCT";
            this.DataSource = this.xuaT_NHAPTONTTCT1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 191, 100);
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuaT_NHAPTONTTCT1)).EndInit();
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
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
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
        private DevExpress.XtraReports.UI.XRLabel lbKhachHang;
        private DevExpress.XtraReports.UI.XRLabel lbNTN;
        private DevExpress.XtraReports.UI.XRLabel lbNgLap;
        private XUAT_NHAPTONTTCT xuaT_NHAPTONTTCT1;
        private DevExpress.XtraReports.UI.XRLabel lbDT;
        private WindowsFormsApplication1.XUAT_NHAPTONTTCTTableAdapters.THONGTINCTTableAdapter tHONGTINCTTableAdapter;
    }
}
