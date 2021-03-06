﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.XtraEditors.DXErrorProvider;
using WindowsFormsApplication1.Class_ManhCuong;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1.HoaDonXuat
{
    public partial class frmHoaDonXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDonXuat()
        {
            InitializeComponent();
        }
        int CountRowTBEdit = 0;
        string mahdtam = "";
   
        DataView dtvKH = new DataView();
        DataView dtvNhanVien = new DataView();
        DataView dtvMH = new DataView();
        DataView dtvDVT = new DataView();
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        public void loadgridKhachHang()
        {
            cboTenKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenKH.Properties.DataSource = dtvKH;
            cboTenKH.Properties.DisplayMember = "TENKH";
            cboTenKH.Properties.ValueMember = "MAKH";
            cboTenKH.Properties.View.BestFitColumns();
            cboTenKH.Properties.PopupFormWidth = 300;
            DataTable dt = ctlNCC.GETKHACHHANG();
            cboTenKH.Properties.DataSource = dt;
           // dtoNCC.MANCC = gridKH1.GetFocusedRowCellValue("TENKH").ToString();
  
        }
        public void loadgridKhachHang(string MAKH)
        {
            cboTenKH.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenKH.Properties.DataSource = dtvKH;
            cboTenKH.Properties.DisplayMember = "TENKH";
            cboTenKH.Properties.ValueMember = "MAKH";
            cboTenKH.Properties.View.BestFitColumns();
            cboTenKH.Properties.PopupFormWidth = 300;
            DataTable dt = ctlNCC.GETKHACHHANG(MAKH);
            cboTenKH.Properties.DataSource = dt;
            if (dt.Rows.Count > 0)
            cboTenKH.Text = dt.Rows[0]["MAKH"].ToString();

        }
        public void Load_panel_create()
        {
            Panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            panel_Grid.Visible = false;
            panel_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Create.Visible = true;
            panel_info.Visible = true;
            panel_tool.Visible = true;
        }
        public void Load_panel_filter()
        {
            Panel_filter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            panel_Grid.Visible = true;
            panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_Create.Visible = false;
            panel_info.Visible = false;
            panel_tool.Visible = false;
        }
        public void loadgridCTHOADON()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("_MaMH"));
            dt.Columns.Add(new DataColumn("_TenMH"));
            dt.Columns.Add(new DataColumn("_LOHANG"));
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("_DonGia"));
            //dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("TIENTHU"));
            gridControl1.DataSource = dt;
            CountRowTBEdit = 0;

            gridCTHOADON.Columns["_DonGia"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["_Total"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["TIENTHU"].ColumnEdit = this.repositoryItemTextEdit1;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;

            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["_LOHANG"].Visible = false;
            }
        }
        public void loadgridCTHOADON(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETCTHOADONXUAT(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;


            DevExpress.XtraGrid.StyleFormatCondition condition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            condition1.Appearance.BackColor = Color.LightBlue;
            condition1.Appearance.Options.UseBackColor = true;
            condition1.Condition = FormatConditionEnum.Expression;
            condition1.Expression = "[ID] >0";
            gridCTHOADON.FormatConditions.Add(condition1);

        }
        public void loadgridCTHOADONTAM(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETCTHOADONXUATTAM(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;

        }
        public void loadGrid_sanpham()
        {
            Grid_sanpham.DataSource = ctlNCC.GETMMH();
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "LOHANG";
           
            Grid_sanpham.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public int iNgonNgu;
        public frmMain frm;
        public string sTenNV, sMaNV;
        public string THEM, XOA, SUA, IN, XEM;
    
        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            XEM = PublicVariable.XEM;
            THEM = PublicVariable.THEM;
            XOA = PublicVariable.XOA;
            SUA = PublicVariable.SUA;
            IN = PublicVariable.IN;

            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                this.Close();
                return;
            }
            if (PublicVariable.isUSE_COMPUTERDATE)
            {
                MessageBox.Show("Bạn đang sử dụng hệ thống ngày tháng của máy tính");
              
            }
            
           // cbotientra.Text = "0";
            loadgridKhachHang();
            loadgridNhanVien();
           // loaddridmathang();
           // loaddridDVT();
           // loadgridthue();
            loadmahdx();
            loadgridCTHOADON();
            loadGrid_sanpham();
         
            Load_panel_create();
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");

            gridControl2.DataSource = ctlNCC.GETCTHOADONXUATTAM();
        }

        private void cboTenKH_Validated(object sender, EventArgs e)
        {

            LOAD_TTKH();
            loadGrid_sanpham();
        }
        public void LOAD_TTKH()
        {
            DataRow rowselect = gridKH1.GetFocusedDataRow();

            if (rowselect != null)
            {
                txtmakh.Text = gridKH1.GetFocusedRowCellValue("MAKH").ToString();
                txtSDT.Text = gridKH1.GetFocusedRowCellValue("SDT").ToString();
                txtDiachi.Text = gridKH1.GetFocusedRowCellValue("DIACHI").ToString();
                dtoNCC.MAKH = txtmakh.Text;  
                DataTable tblayno = ctlNCC.LAYTIENNOKH(dtoNCC);
                if (tblayno.Rows.Count > 0)
                {
                    txtNo.Text = tblayno.Rows[0]["TIENNO"].ToString();
                }
                else
                {
                    txtNo.Text = "0";
                }
            }
        }
       
        public void loadgridNhanVien()
        {
            dtoNCC.MANV = sMaNV;
            txtnhanvienlap.Text = sTenNV;
        }
 
        ArrayList list1 = new ArrayList();
        
        private void Validate_LessThanMinRule(BaseEdit control, Decimal min)
        {
            if (!(control.EditValue is Decimal)) return;
            if ((Decimal)control.EditValue < min) dxErrorProvider1.SetError(control, "Please enter a greater value than " + min.ToString(), ErrorType.Warning);
            else dxErrorProvider1.SetError(control, "");
        }

        private void cboSL_Validating(object sender, CancelEventArgs e)
        {
            Validate_LessThanMinRule(sender as BaseEdit, 0);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Lưu Vào Hóa Đơn Xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtmakh.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng chọn Mã Khách Hàng");
                    }
                    else
                    {

                        dtoNCC.MAKH = txtmakh.Text;
                        dtoNCC.TENKH = cboTenKH.Text;
                        dtoNCC.DIACHI = txtDiachi.Text;
                        dtoNCC.SDT = txtSDT.Text;
                        // dtoNCC.WEBSITE = txtWeb.Text;
                        dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDX = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.GHICHU = textBoxX1.Text;

                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                        int rowcount = gridCTHOADON.DataRowCount;
                        if (rowcount == 0)
                        {
                            XtraMessageBox.Show("Hãy chọn một sản phẩm trước khi lưu");
                            return;
                        }

                        bool isINSERTHOADONXUAT = ctlNCC.isINSERTHOADONXUAT(dtoNCC.MAHDX);
                        if (isINSERTHOADONXUAT)
                        {
                            if (THEM == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                                return;
                            }


                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = gridCTHOADON.GetDataRow(i);

                               
                                string SQL = "select TONKHO from KHOHANG where MAMH='" + dtr["_MaMH"].ToString() + "' AND LOHANG='" + dtr["_LOHANG"].ToString() + "'";
                                DataTable dt = ctlNCC.GETDATA(SQL);

                                if (dt.Rows.Count > 0)
                                {
                                    Double slton = Convert.ToDouble(dt.Rows[0]["TONKHO"].ToString());
                                    Double SOLUONG=Convert.ToDouble(dtr["_SoLuong"].ToString());
                                    if (SOLUONG<=0)
                                    {
                                        System.Windows.Forms.MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " KHÔNG THỂ XUẤT <=0");

                                        return;
                                    }
                                    if (slton <SOLUONG )
                                    {
                                        System.Windows.Forms.MessageBox.Show("Mã Hàng:" + dtr["_MaMH"].ToString() + " Không đủ số lượng để xuất");

                                        return;
                                    }
                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("Chưa có mã hàng:" + dtr["_MaMH"].ToString() + " trong kho");
                                    return;
                                }
                            }



                            dtoNCC.IsUPDATE = false;
                            ctlNCC.INSERTHOADONXUAT(dtoNCC);
                            //insert hoa don chi tiet

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = gridCTHOADON.GetDataRow(i);

                                insert_HoadonChitietxuat(txtMaHD.Text, dtr["_LOHANG"].ToString(), dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()));
                            }
                        }
                        else
                        {
                            if (SUA == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                                return;
                            }
                            if (PublicVariable.TATCA == "False")
                            {
                                MessageBox.Show("TRÙNG MÃ HÓA ĐƠN");
                                return;
                            }
                            dtoNCC.IsUPDATE = true;
                            ctlNCC.UPDATEHOADONXUAT(dtoNCC);

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                String sID = dtr["ID"].ToString();

                                if (sID != "")
                                {
                                    update_HoadonChitietxuat(txtMaHD.Text, dtr["_LOHANG"].ToString(), Convert.ToInt32(sID), dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()));
                                }
                                else
                                {
                                    insert_HoadonChitietxuat(txtMaHD.Text, dtr["_LOHANG"].ToString(), dtr["_MaMH"].ToString(), Double.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()), int.Parse(dtr["TIENTHU"].ToString()));
                                }
                            }


                        }






                        loadGiaoDich();
                        MessageBox.Show("Bạn Đã Thêm Thành Công");
                        Create_new();

                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
      
        private void loadGiaoDich()
        {
            dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            
        }
        double conlai, thanhtien, tientra;
        private void cbotientra_TextChanged(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }
        public void insert_HoadonChitietxuat(string mahdx, string lohang, String mamh, Double SoLuong, int DonGia,int tienthu)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.LOHANG = lohang;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.TIENTHU = tienthu;
                string SQL = "SELECT MAX(ID) FROM CHITIETHDX WHERE MAHDX='" + mahdx + "'";
                DataTable dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1;
                if (dt.Rows[0][0].ToString()!="")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                }
           
                ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
      
                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitietxuat(string mahdx,string lohang,int ID, String mamh, Double SoLuong, int DonGia,int tienthu)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.LOHANG = lohang;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.ID = ID;
                dtoNCC.TIENTHU = tienthu;
                ctlNCC.UPDATECTHOADONXUAT(dtoNCC);

                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }

        int kiemtra;
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmThemKhachHang tkh = new frmThemKhachHang();
           // tkh.iNgonNgu = iNgonNgu;
            tkh.kiemtra = 1;
            tkh.ShowDialog();
            loadgridKhachHang();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETCTHOADONXUATIN(txtMaHD.Text);
                    Inxuat rep = new Inxuat(dt, cboTenKH.Text, txtDiachi.Text,cbotientra.Text, txtNo.Text, txtthanhtien.Text, txtMaHD.Text,"");
                    rep.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Chưa có CT nào");
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
           
            
         
        }
        ketnoi connect = new ketnoi();
        public void loadmahdx()
        {
            txtMaHD.Text = connect.sTuDongDienMaHoaDonXuat(txtMaHD.Text);
            txtNgayXuat.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btAddMH_Click(object sender, EventArgs e)
        {
            ThemMatHang frm = new ThemMatHang();
           // frm.iNgonNgu = iNgonNgu;
            frm.kiemtra = 1;
           // frm.sBoPhan = sMaBP;
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Create_new();
            
        }
        public void Create_new()
        {
            txtmakh.Text = "";
            cboTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";           
            txtMaHD.Text = "";
            txtNgayXuat.Text = DateTime.Now.ToString("yyy/MM/dd");
            txtNo.Text = "0";
            txtconLai.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "";
            mahdtam = "";
            btLuu.Enabled = true;

            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData();

            loadgridCTHOADON();
        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Load_panel_create();
            Create_new();
            loadgridCTHOADON();
        }

        private void linkTheoHoaDon_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            loadgridPHIEUXUAT();
        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            loadgridSANPHAM();
        }

        private void tongxuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridTONGSANPHAM();
        }
 

        public void loadgridPHIEUXUAT( )
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) AS NGAYXUAT,T1.MAHDX ,T1.TENKH ,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA)AS TONGTIEN ,T1.GHICHU  FROM (select t9.*,t8.tenkh from hoadonxuat as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  T9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDX DESC";
            
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView4;
            gridControl3.DataSource = TBS;
            gridView4.RefreshData();
            gridControl3.RefreshDataSource();
            gridView4.BestFitColumns();

        }
        public void loadgridSANPHAM( )
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T3.NGAYXUAT,103) AS NGAYXUAT,TENNCC,T3.TENKH ,T3.MAHDX , T3.MAMH , T4.TENMH ,T3.SOLUONGXUAT ,T3.SOLUONGXUAT*KLDVT as KHOILUONG,T3.GIATIEN,soluongxuat*giatien AS THANHTIEN,TIENTHU, GHICHU   FROM (select T2.NGAYXUAT,TIENTHU,T1.MAHDX,T1.MAMH,T1.SOLUONGXUAT,T1.GIATIEN,GHICHU,t2.tenkh FROM (SELECT * FROM CHITIETHDX ) AS T1 INNER JOIN (select t9.ngayxuat,t9.mahdx,t9.makh,t8.tenkh,GHICHU from hoadonxuat  as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  T9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDX =T2.MAHDX) as T3 INNER JOIN (select TENMH,TENNCC,MAMH,KLDVT FROM MATHANG,NHACUNGCAP WHERE MATHANG.MANCC=NHACUNGCAP.MANCC) AS T4 ON T3.MAMH =T4.MAMH";
            
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView1;
            gridControl3.DataSource = TBS;
            //gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridView1.ExpandAllGroups();
            gridView1.RefreshData();
            gridControl3.RefreshDataSource();
            gridView1.BestFitColumns();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView1.Columns["KHOILUONG"].Visible = false;
            }

        }
        public void loadgridTONGSANPHAM()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC, KLDVT, DONVITINH, sum(SOLUONGXUAT) as SOLUONGXUAT, GIATIEN,SUM(TIENTHU) AS TIENTHU,SUM(SOLUONGXUAT*KLDVT) AS KHOILUONG, SUM(SOLUONGXUAT*GIATIEN) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,(select MAMH,SOLUONGXUAT, GIATIEN,TIENTHU FROM CHITIETHDX WHERE  NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as CHITIETHDX WHERE MATHANG.MANCC=NHACUNGCAP.MANCC  AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=CHITIETHDX.MAMH AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC, DONVITINH,GIATIEN,KLDVT ";
           
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView3;
            gridControl3.DataSource = TBS;
           // gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
           // gridView3.ExpandAllGroups();
            gridView3.RefreshData();
            gridControl3.RefreshDataSource();
            if (!PublicVariable.isKHOILUONG)
            {
                gridView3.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
            if (dtr != null)
                if (dtr["_TenMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "_TenMH")
                    {
                        string SMAMH = dtr["_TenMH"].ToString();
                        int index = SMAMH.IndexOf("_");
                        string MAMH = SMAMH.Substring(0,index);
                        string LOHANG = SMAMH.Substring(index+1,SMAMH.Length-index-1);
                        DataTable dtmh = ctlNCC.GETMATHANG(MAMH,LOHANG);
                        dtr["_MaMH"] = dtmh.Rows[0]["MAMH"];
                        dtr["_LOHANG"] = dtmh.Rows[0]["LOHANG"];
                        dtr["_SoLuong"] = "0";
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        //dtr["_TenMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                        dtr["TIENTHU"] = "0";
                    }
                    else if (e.Column.FieldName.ToString() == "_DonGia")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_DonGia"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_DonGia"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTHU"] = "0";
                        }

                    }
                    else if (e.Column.FieldName.ToString() == "_SoLuong")
           
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["_SoLuong"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Double.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_SoLuong"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTHU"] = "0";
                        }
                    }
                    else if (e.Column.FieldName.ToString() == "TIENTHU")
                    {
                        
                            gettotal();
                    }
                }
        }

        private void gridCTHOADON_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridCTHOADON.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                DataRow dtr1 = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
                if (dtr1["ID"].ToString() != "")
                {
                    return;
                }

                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int focusrow=gridCTHOADON.FocusedRowHandle;
                    DataRow dtr  = gridCTHOADON.GetDataRow(focusrow);

                    //bool isinsert = ctlNCC.ISINSERTCTHOADONXUAT(txtMaHD.Text, focusrow+1);

                    //if (!isinsert)
                    //    ctlNCC.DELETECTHOADONXUAT(txtMaHD.Text, focusrow+1);

                    GridView view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                }
            }
        }

        private void gridCTHOADON_RowcountChanged(object sender, EventArgs e)
        {
            gettotal();
        }

        private void gridCTHOADON_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip1.Show(view.GridControl, e.Point);
            }
        }
        public void gettotal()
        {
            int rowcount = gridCTHOADON.RowCount;
            Double total = 0;
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                if (dtr != null)
                {
                    Double Num;
                    bool isNum = Double.TryParse(dtr["TIENTHU"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            txtthanhtien.Text = total.ToString();

            if (cbotientra.Text != "")
            {
                thanhtien = double.Parse(txtthanhtien.Text);
                tientra = double.Parse(cbotientra.Text);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridCTHOADON.FocusedRowHandle;
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(focusrow);
                if (dtr != null)
                {
                    String sID = "";

                    try
                    {
                        sID = dtr["ID"].ToString();
                    }
                    catch { }


                    if (sID != "")
                    {
                        if (XOA == "False")
                        {
                            MessageBox.Show("KHÔNG CÓ QUYỀN ");
                            return;
                        }
                        string SQLNGAY = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                        DataTable dtn = ctlNCC.GETDATA(SQLNGAY);
                        if (txtNgayXuat.Text != dtn.Rows[0][0].ToString() && !PublicVariable.isUSE_COMPUTERDATE)
                        {
                            MessageBox.Show("Không phải hóa đơn hôm nay nên không thể xóa, chỉ có thể xóa hóa đơn trong ngày  ");
                            return;
                        }

                        PublicVariable.TMPtring = "";
                        frmxoahd xhd = new frmxoahd();
                        xhd.MAHD = txtMaHD.Text;
                        xhd.MAMH = dtr["_MaMH"].ToString();
                        xhd.TENMH = dtr["_TenMH"].ToString();

                        xhd.ShowDialog();
                        if (PublicVariable.TMPtring == "")
                        {
                            return;
                        }
                        

                        ctlNCC.DELETECTHOADONXUAT(txtMaHD.Text, Convert.ToInt32(sID));
                        ctlNCC.UPDATE_KHOHANG_NX(dtr["_MaMH"].ToString(), dtr["_LOHANG"].ToString(), "0", "0", "-" + dtr["_SoLuong"].ToString(), "0");
                        PublicVariable.TMPtring = "";
                    }
                    else
                    {
                        gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                        gettotal();

                        dtoNCC.MAKH = txtmakh.Text;
                        dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                        dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                        dtoNCC.MAHDX = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.GHICHU = textBoxX1.Text;

                        dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
                        return;
                    }
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                    gettotal();

                    dtoNCC.MAKH = txtmakh.Text;
                    dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
                    dtoNCC.MAHDX = txtMaHD.Text;
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.GHICHU = textBoxX1.Text;

                    dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);

                    ctlNCC.UPDATEHOADONXUAT(dtoNCC);
                }
            }
        }
        public void View_phieuxuat(string MAHDX)
        {
            loadgridCTHOADON(MAHDX);
            txtMaHD.Text = MAHDX;
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) ,T1.MAHDX ,T2.MANV,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO FROM (SELECT * FROM HOADONXUAT WHERE MAHDX='" + MAHDX + "' AND  MAKHO='" + PublicVariable.MAKHO + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV";
            DataTable DT = ctlNCC.GETDATA(SQL);
            txtnhanvienlap.Text = DT.Rows[0]["TENNV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            btLuu.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
            if (gridControl3.MainView == gridView4)
            {
                dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            }
            else
            {
                dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            }
            string MAKH = ctlNCC.GETMAKHfromMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
           // loadGrid_sanpham();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            btLuu.Enabled = false;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
            if (gridControl3.MainView == gridView4)
            {
                dtr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            }
            else
            {
                dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            }
            string MAKH = ctlNCC.GETMAKHfromMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
        }

        private void gridView4_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip2.Show(view.GridControl, e.Point);
            }
        }

        private void pnThangNam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridCTHOADON_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            int RowCount = view.RowCount;

            if (view.FocusedColumn.FieldName == "_TenMH" && CountRowTBEdit > 0)
            {
                int rowfocus = view.FocusedRowHandle;
                if (rowfocus >= 0)
                {
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(rowfocus);

                    String sID = dtr["ID"].ToString();
                    if (sID != "")
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl3.DataSource;
            if (gridControl3.MainView == gridView4)
            {
                Inhd rep = new Inhd(printtable, 3);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridView1)
            {
                Inhd rep = new Inhd(printtable, 4);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridView3)
            {
                Inhd rep = new Inhd(printtable, 5);
                rep.ShowPreviewDialog();
            }

           // gridControl3.ShowPrintPreview();

            /*gridView1.Columns["MAHDX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
            gridView1.Columns["MAHDX"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
             * */
        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                gridControl3.ExportToXls(saveFileDialog1.FileName);
            }
        }

        

        private void linkIntheomathang_Click(object sender, EventArgs e)
        {
            ArrayList array1 = new ArrayList();
            if (gridControl3.MainView == gridView4)
            {
                int[] row = gridView4.GetSelectedRows();
                for (int i = 0; i < row.Length; i++)
                {
                    DataRow dtr = gridView4.GetDataRow(row[i]);
                    array1.Add(dtr["MAHDX"].ToString());
                }
            }
            if (gridControl3.MainView == gridView1)
            {
                int[] row = gridView1.GetSelectedRows();
                for (int i = 0; i < row.Length; i++)
                {
                    DataRow dtr = gridView1.GetDataRow(row[i]);
                    string mahdn = dtr["MAHDX"].ToString();
                    if (array1.Contains(dtr["MAHDX"].ToString()) == false)
                    {
                        array1.Add(mahdn);
                    }
                }

              
            }
           
            String SQL1 = "";
            if (array1.Count == 1)
            {
                SQL1 = SQL1 + " AND CHITIETHDX.MAHDX='" + array1[0].ToString() + "' ";
            }
            else
            {
                for (int i = 0; i < array1.Count; i++)
                {
                    if (i == 0)
                    {
                        SQL1 = SQL1 + " AND (CHITIETHDX.MAHDX='" + array1[i].ToString() + "' ";
                    }
                    else if (i == array1.Count - 1)
                    {
                        SQL1 = SQL1 + " OR CHITIETHDX.MAHDX='" + array1[i].ToString() + "') ";
                    }
                    else
                    {
                        SQL1 = SQL1 + " OR CHITIETHDX.MAHDX='" + array1[i].ToString() + "' ";
                    }
                }
            }

            string SQL = "SELECT CHITIETHDX.MAHDX,convert(varchar,HOADONXUAT.NGAYXUAT,103) as NGAYXUAT ,TENKH,TENMH,DONVITINH,SOLUONGXUAT,GIATIEN,GIATIEN*SOLUONGXUAT AS THANHTIEN  FROM CHITIETHDX, HOADONXUAT,KHACHHANG, (SELECT MATHANG.MAMH,TENMH, DONVITINH FROM DONVITINH, MATHANG WHERE MATHANG.MADVT=DONVITINH.MADVT) AS DONVITINH WHERE CHITIETHDX.MAHDX=HOADONXUAT.MAHDX AND HOADONXUAT.MAKH=KHACHHANG.MAKH AND CHITIETHDX.MAMH=DONVITINH.MAMH " + SQL1;
            DataTable dt1 = ctlNCC.GETDATA(SQL);
            SQL = "SELECT MATHANG.MAMH,convert(varchar,HOADONXUAT.NGAYXUAT,103) as NGAYXUAT, TENMH, SUM(SOLUONGXUAT) AS SOLUONGXUAT, GIATIEN FROM CHITIETHDX, MATHANG, DONVITINH,HOADONXUAT WHERE MATHANG.MADVT=DONVITINH.MADVT AND  HOADONXUAT.MAHDX=CHITIETHDX.MAHDX AND MATHANG.MAMH=CHITIETHDX.MAMH " + SQL1 + " GROUP BY MATHANG.MAMH,HOADONXUAT.NGAYXUAT, TENMH,GIATIEN";
            DataTable dt2 = ctlNCC.GETDATA(SQL);
            Inhdnhap rep = new Inhdnhap(dt1);
            rep.ShowPreviewDialog();

            Inhdxuat rep2 = new Inhdxuat(dt2);
            rep2.ShowPreviewDialog();  
        }

        private void loadgrid()
        {
            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải Lớn hơn ngày bắt đầu");
                return;
            }

            if (gridControl3.MainView == gridView4)
            {
                loadgridPHIEUXUAT();
            }
            else if (gridControl3.MainView == gridView1)
            {
                loadgridSANPHAM();
            }
            else if (gridControl3.MainView == gridView3)
            {
                loadgridTONGSANPHAM();
            }
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            loadgrid();
        }
        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                loadgrid();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                loadgrid();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
            dtr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            mahdtam = dtr["MAHDX"].ToString();
            loadgridCTHOADONTAM(dtr["MAHDX"].ToString());

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridView2.FocusedRowHandle;
                DataRow dtr = dtr = gridView2.GetDataRow(focusrow);
                if (dtr != null)
                {
                    ctlNCC.DELETECTHOADONXUATTAM(dtr["MAHDX"].ToString());
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);
                }
            }
            loadgridCTHOADON();
        }

        private void gridView2_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip3.Show(view.GridControl, e.Point);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string thanhtien="0";
            if(txtthanhtien.Text!=""){
                thanhtien=txtthanhtien.Text;
            }
            
            if (mahdtam == "")
            {
                mahdtam = connect.sTuDongDienMaHoaDonXuattam(txtMaHD.Text);
            }
            String SQL = "DELETE FROM [CHITIETHDXTAM] WHERE MAHDX='" + mahdtam + "'";
            ctlNCC.executeNonQuery(SQL);
            for (int i = 0; i < gridCTHOADON.DataRowCount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                SQL = "INSERT INTO [CHITIETHDXTAM] ([MAHDX],[MAMH],[LOHANG],[SOLUONGXUAT],[GIATIEN],[TONGGIATIEN],[MAKHO],[TIENTHU]) VALUES ( '" + mahdtam + "','" + dtr["_MaMH"].ToString() + "','" + dtr["_LOHANG"].ToString() + "'," + dtr["_SoLuong"].ToString() + "," + dtr["_DonGia"].ToString() + "," + thanhtien + ",'" + PublicVariable.MAKHO + "'," + dtr["TIENTHU"].ToString() + ")";
                ctlNCC.executeNonQuery(SQL);
            }
            gridControl2.DataSource = ctlNCC.GETCTHOADONXUATTAM();
           // mahdtam = "";
            MessageBox.Show("Đã Lưu Tạm Hóa Đơn");
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Báo Cáo Xuất Hàng Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }


    


    }
}