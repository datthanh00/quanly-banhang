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

namespace WindowsFormsApplication1.KHtra
{
    public partial class frmKHtra : DevExpress.XtraEditors.XtraForm
    {
        public frmKHtra()
        {
            InitializeComponent();
        }
        int CountRowTBEdit = 0;
        DataView dtvKH = new DataView();
        DataView dtvNhanVien = new DataView();
        DataView dtvMH = new DataView();
        DataView dtvDVT = new DataView();
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        DataTable tbsanpham;
        public void loadgridKhachHang()
        {
            
        }
        public void loadgridKhachHang(string MAKH)
        {
           

        }
        public void Load_MAHD()
        {
            string sql = "SELECT MAX(MAHDX) FROM HOADONXUAT";
            DataTable dt = ctlNCC.GETDATA(sql);

            if (dt.Rows[0][0].ToString() == "")
            {
                tbmahdx.Properties.Items.Add("Chưa có HDX");
            }
            else
            {
                string smahd = dt.Rows[0][0].ToString();
                int maxnum = Convert.ToInt32(smahd.Substring(5, 5));

                for (int i = 1; i < maxnum; i++)
                {
                    if (i < 10)
                    {
                        tbmahdx.Properties.Items.Add("MAHDX0000" + i.ToString());
                    }
                    else if (i < 100)
                    {
                        tbmahdx.Properties.Items.Add("MAHDX000" + i.ToString());
                    }
                    else if (i < 1000)
                    {
                        tbmahdx.Properties.Items.Add("MAHDX00" + i.ToString());
                    }
                    else if (i < 10000)
                    {
                        tbmahdx.Properties.Items.Add("MAHDX0" + i.ToString());
                    }
                    else
                    {
                        tbmahdx.Properties.Items.Add("MAHDX" + i.ToString());
                    }
                }
            }
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
            dt.Columns.Add(new DataColumn("_SoLuong"));
            dt.Columns.Add(new DataColumn("_DonGia"));
            //dt.Columns.Add(new DataColumn("_Thue"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
            gridControl1.DataSource = dt;
            CountRowTBEdit = 0;

        }
        public void loadgridCTHOADON(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETtraCTHOADONXUAT(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;


            DevExpress.XtraGrid.StyleFormatCondition condition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            condition1.Appearance.BackColor = Color.LightBlue;
            condition1.Appearance.Options.UseBackColor = true;
            condition1.Condition = FormatConditionEnum.Expression;
            condition1.Expression = "[ID] >0";
            gridCTHOADON.FormatConditions.Add(condition1);

        }
        public void loadGrid_sanpham(string MAHDX)
        {
            tbsanpham = ctlNCC.GETMMHX(MAHDX);
            Grid_sanpham.DataSource = tbsanpham;
            Grid_sanpham.DisplayMember = "TENMH";
            Grid_sanpham.ValueMember = "MAMH";
            Grid_sanpham.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        public int iNgonNgu;
        public frmMain frm;
        public string sTenNV, sMaNV;
     
        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
           

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           // cbotientra.Text = "0";
            loadgridKhachHang();
            loadgridNhanVien();
           // loaddridmathang();
           // loaddridDVT();
           // loadgridthue();
            loadmahdx();
            loadgridCTHOADON();
           // loadGrid_sanpham();
            cboNhanVienLap.Text = sMaNV;
            Load_panel_create();
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");
            Load_MAHD();
        }

        private void cboTenKH_Validated(object sender, EventArgs e)
        {

            LOAD_TTKH();
        }
        public void LOAD_TTKH()
        {
           
           
        }

        public void loadgridNhanVien()
        {
            cboNhanVienLap.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboNhanVienLap.Properties.DataSource = dtvNhanVien;
            cboNhanVienLap.Properties.DisplayMember = "TENNV";
            cboNhanVienLap.Properties.ValueMember = "MANV";
            cboNhanVienLap.Properties.View.BestFitColumns();
            cboNhanVienLap.Properties.PopupFormWidth = 300;
            cboNhanVienLap.Properties.DataSource = ctlNCC.GETNV();
            dtoNCC.MANV = gridNV.GetFocusedRowCellValue("MANV").ToString();
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
            //kiemtramahd();
            try
            {
                if (tbmahdx.Text =="")
                {
                    XtraMessageBox.Show("Vui lòng điền mã hóa đơn xuất");
                    tbmahdx.Focus();
                    return;
                }
                else
                {

                    String SQL = "Select mahdx,MAKH From hoadonxuat where mahdx='" + tbmahdx.Text + "' and makho='" + PublicVariable.MAKHO + "'";
                    DataTable dt = ctlNCC.GETDATA(SQL);
                    if (dt.Rows.Count <= 0)
                    {
                        XtraMessageBox.Show("Không có mã hóa đơn này");
                        tbmahdx.Focus();
                        return;
                    }

            dtoNCC.MAKH = dt.Rows[0]["MAKH"].ToString();
            dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.TIENPHAITRA = int.Parse(txtthanhtien.Text);
            dtoNCC.MAHDX = txtMaHD.Text;
            if (cbotientra.Text == "")
            {
                cbotientra.Text = "0";
            }
            dtoNCC.GHICHU= textBoxX1.Text;
             
            dtoNCC.TIENDATRA = int.Parse(cbotientra.Text);
           
            int rowcount = gridCTHOADON.DataRowCount;
            if (rowcount == 0)
            {
                XtraMessageBox.Show("Hãy chọn một sản phẩm trước khi lưu");
                return;
            }

            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = gridCTHOADON.GetDataRow(i);
                int soluongtra = Convert.ToInt32(dtr["_SoLuong"].ToString());
                int soluongxuat = 0;
                for (int j = 0; j < tbsanpham.Rows.Count; j++)
                {
                    if (tbsanpham.Rows[j]["MAMH"].ToString() == dtr["_MaMH"].ToString())
                    {
                        soluongxuat = soluongxuat + Convert.ToInt32(tbsanpham.Rows[j]["soluongxuat"].ToString());
                    }
                }
                if (soluongxuat < soluongtra)
                {
                    MessageBox.Show("Mã hàng này: " + dtr["_MaMH"].ToString() + " không được trả nhiều hơn so với hóa đơn");
                    return;
                }
            }

            bool isINSERTHOADONXUAT = ctlNCC.isINSERTtraHOADONXUAT(dtoNCC.MAHDX);
            if (isINSERTHOADONXUAT)
            {
                if (PublicVariable.THEM == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                }

                dtoNCC.IsUPDATE = false;
                ctlNCC.INSERTtraHOADONXUAT(dtoNCC);
                //insert hoa don chi tiet
                
                for (int i = 0; i < rowcount; i++)
                {
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                    insert_HoadonChitietxuat(txtMaHD.Text, dtr["_MaMH"].ToString(), int.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                }
            }
            else
            {
                
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                
                dtoNCC.IsUPDATE = true;
                ctlNCC.UPDATEtraHOADONXUAT(dtoNCC);
          
                for (int i = 0; i < rowcount; i++)
                {
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                    String sID = dtr["ID"].ToString();

                    if (sID != "")
                    {
                        update_HoadonChitietxuat(txtMaHD.Text, Convert.ToInt32(sID), dtr["_MaMH"].ToString(), int.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
                    }
                    else
                    {
                        insert_HoadonChitietxuat(txtMaHD.Text, dtr["_MaMH"].ToString(), int.Parse(dtr["_SoLuong"].ToString()), int.Parse(dtr["_DonGia"].ToString()));
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
      
        private void loadGiaoDich()
        {
            dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
            dtoNCC.MAKHO = PublicVariable.MAKHO;
            gridControl2.DataSource = ctlNCC.GETtraHOADONXUAT(dtoNCC);
        }
        double conlai, thanhtien, tientra;
        private void cbotientra_TextChanged(object sender, EventArgs e)
        {
            thanhtien = double.Parse(txtthanhtien.Text);
            tientra = double.Parse(cbotientra.Text);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }
        public void insert_HoadonChitietxuat(string mahdx, String mamh, int SoLuong, int DonGia)
        {
            try
            {
                string SQL = "SELECT ID,soluongxuat FROM CHITIETHDX WHERE MAHDX='" + tbmahdx.Text + "' AND MAMH='" + mamh + "' AND SOLUONGXUAT >=" + SoLuong;
                DataTable dt = ctlNCC.GETDATA(SQL);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Số lượng mã hàng: " + mamh + " này không dược lớn hơn số lượng xuất ");
                    return;
                }

                int soluongupdate = Convert.ToInt32(dt.Rows[0]["soluongxuat"].ToString()) - SoLuong;
                dtoNCC.MAHDX = tbmahdx.Text;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = soluongupdate;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                ctlNCC.UPDATECTHOADONXUAT(dtoNCC);


                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                 SQL = "SELECT MAX(ID) FROM traCHITIETHDX WHERE MAHDX='" + mahdx + "'";
                 dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1;
                if (dt.Rows[0][0].ToString() != "")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                }
               
                ctlNCC.INSERTtraCTHOADONXUAT(dtoNCC);
      
                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitietxuat(string mahdx,int ID, String mamh, int SoLuong, int DonGia)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                dtoNCC.ID = ID;
                
                ctlNCC.UPDATEtraCTHOADONXUAT(dtoNCC);

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
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            try
            {
                if (gridCTHOADON.RowCount > 0)
                {
                    string ten = "Khách trả hàng";
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETtraCTHOADONXUAT(txtMaHD.Text);
                    Inxuat rep = new Inxuat(dt, "", "",cbotientra.Text, "", txtthanhtien.Text, txtMaHD.Text,ten);
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
            txtMaHD.Text = connect.sTuDongDienMatraHoaDonXuat(txtMaHD.Text);
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
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Create_new();
            
        }
        public void Create_new()
        {
                  
            txtMaHD.Text = "";
            txtNgayXuat.Text = DateTime.Now.ToString("yyy/MM/dd");
            tbmahdx.Text = "";
            txtconLai.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "";


            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData();

            loadgridCTHOADON();
        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (PublicVariable.THEM == "False")
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
        private void tongsanpham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadgridTONGSANPHAM();
        }
        public void loadgridPHIEUXUAT()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;
            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) AS NGAYXUAT,T1.MAHDX ,T1.TENKH ,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA)AS TONGTIEN ,T1.GHICHU  FROM (select t9.*,t8.tenkh from TRAHOADONXUAT   as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDX DESC";
            
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView4;
            gridControl3.DataSource = TBS;
            gridView4.RefreshData();
            gridControl3.RefreshDataSource();
            gridView4.BestFitColumns();

        }
        public void loadgridSANPHAM()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dtoNCC.NGAYBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dtoNCC.NGAYKT = NGAYKT;

            Load_panel_filter();
            string SQL = "SELECT convert(varchar,T3.NGAYXUAT,103) AS NGAYXUAT,T3.TENKH ,T3.MAHDX , T3.MAMH , T4.TENMH ,T3.SOLUONGXUAT ,T3.GIATIEN,soluongxuat*giatien AS THANHTIEN,TENNCC, GHICHU   FROM (select T2.NGAYXUAT,T1.MAHDX,T1.MAMH,T1.SOLUONGXUAT,T1.GIATIEN,GHICHU,t2.tenkh FROM (SELECT * FROM TRACHITIETHDX ) AS T1 INNER JOIN (select t9.ngayxuat,t9.mahdx,t9.makh,t8.tenkh,GHICHU from TRAHOADONXUAT  as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDX =T2.MAHDX) as T3 INNER JOIN (SELECT TENMH,MAMH,TENNCC FROM MATHANG,NHACUNGCAP WHERE NHACUNGCAP.MANCC=MATHANG.MANCC) AS T4 ON T3.MAMH =T4.MAMH";
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView1;
            gridControl3.DataSource = TBS;
            //gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridView1.ExpandAllGroups();
            gridView1.RefreshData();
            gridControl3.RefreshDataSource();
            gridView1.BestFitColumns();
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
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC,KLDVT, DONVITINH, sum(SOLUONGXUAT) as SOLUONGXUAT, GIATIEN, SUM(SOLUONGXUAT*GIATIEN) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,(select MAMH,SOLUONGXUAT, GIATIEN FROM TRACHITIETHDX, TRAHOADONXUAT WHERE TRACHITIETHDX.MAHDX=TRAHOADONXUAT.MAHDX AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as TRACHITIETHDX WHERE MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=TRACHITIETHDX.MAMH AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC, DONVITINH,GIATIEN,KLDVT";
           

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridView3;
            gridControl3.DataSource = TBS;
            
            gridView3.RefreshData();
            gridControl3.RefreshDataSource();
        }

        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
            if (dtr != null)
                if (dtr["_TenMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "_TenMH")
                    {
                        DataTable dtmh = ctlNCC.GETMATHANG(dtr["_TenMH"].ToString());
                        dtr["_MaMH"] = dtmh.Rows[0]["MAMH"];
                        dtr["_SoLuong"] = "0";
                        dtr["_DonGia"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        //dtr["_TenMH"] = dtmh.Rows[0]["TENMH"];
                        dtr["_Total"] = "0";
                    }
                    else
                    {
                        int Num;
                        bool isNum = int.TryParse(dtr["_SoLuong"].ToString(), out Num);
                        if (isNum)
                        {
                            int total = int.Parse(dtr["_DonGia"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["_SoLuong"] = "0";
                            dtr["_Total"] = "0";
                        }
                    }
                }
        }

        private void gridCTHOADON_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridCTHOADON.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int focusrow=gridCTHOADON.FocusedRowHandle;
                    DataRow dtr = dtr = gridCTHOADON.GetDataRow(focusrow);

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
            int total = 0;
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                if (dtr != null)
                {
                    int Num;
                    bool isNum = int.TryParse(dtr["_Total"].ToString(), out Num);
                    if (isNum)
                    {
                        total += Num;
                    }
                }
            }
            txtthanhtien.Text = total.ToString();
            //MessageBox.Show(total.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridCTHOADON.FocusedRowHandle;
                DataRow dtr = dtr = gridCTHOADON.GetDataRow(focusrow);
                if (dtr != null)
                {
                    String sID = dtr["ID"].ToString();
                    if (sID != "")
                    {
                        ctlNCC.DELETEtraCTHOADONXUAT(txtMaHD.Text, Convert.ToInt32(sID));
                    }
                   // bool isinsert = ctlNCC.ISINSERTCTHOADONXUAT(txtMaHD.Text, focusrow+1);

                   // if (!isinsert)
                    //    ctlNCC.DELETECTHOADONXUAT(txtMaHD.Text, focusrow+1);

                    // GridView view = sender as GridView;
                    // view.DeleteRow(view.FocusedRowHandle);
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                }
            }
        }
        public void View_phieuxuat(string MAHDX)
        {
            loadgridCTHOADON(MAHDX);

            txtMaHD.Text = MAHDX;
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) ,T1.MAHDX ,T2.MANV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO FROM (SELECT * FROM traHOADONXUAT WHERE MAHDX='" + MAHDX + "' AND  MAKHO='" + PublicVariable.MAKHO + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV";
            DataTable DT = ctlNCC.GETDATA(SQL);
            cboNhanVienLap.Text = DT.Rows[0]["MANV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

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
            string MAKH = ctlNCC.GETMAKHfromtraMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
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
            string MAKH = ctlNCC.GETMAKHfromMHDX(dtr["Mã Hóa Đơn"].ToString());
            View_phieuxuat(dtr["Mã Hóa Đơn"].ToString());
            txtNgayXuat.Text = dtr["NGÀY XUẤT"].ToString();
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

        private void btXem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            loadgrid();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            gridControl3.ShowPrintPreview();
        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
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

        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadgrid();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadgrid();
            }
        }


        private void loadgrid()
        {
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

 

        private void tbmahdx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                kiemtramahd();
            }
        }
        public void kiemtramahd()
        {
            if (tbmahdx.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền mã hóa đơn xuất");
                //tbmahdx.Focus();
                return;
            }

            String SQL = "Select mahdx From hoadonxuat where mahdx='" + tbmahdx.Text + "' and makho='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlNCC.GETDATA(SQL);
            if (dt.Rows.Count <= 0)
            {
                tbmahdx.Text = "";
                XtraMessageBox.Show("Không có mã hóa đơn này");
                //tbmahdx.Focus();
                return;
            }

            loadGrid_sanpham(tbmahdx.Text);
            loadgridCTHOADON();
            
        }

        private void tbmahdx_Validated(object sender, EventArgs e)
        {
            kiemtramahd();
        }



   

    }
}