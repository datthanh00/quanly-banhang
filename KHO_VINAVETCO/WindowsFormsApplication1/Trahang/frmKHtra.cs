using System;
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

namespace WindowsFormsApplication1.KHtra
{
    public partial class frmKHtra : DevExpress.XtraEditors.XtraForm
    {
        public frmKHtra()
        {
            InitializeComponent();
        }
        int CountRowTBEdit = 0;
     
        Boolean isdelete = false, isnhap = true;
        DataView dtvKH = new DataView();
        DataView dtvNhanVien = new DataView();
        DataView dtvMH = new DataView();
        DataView dtvDVT = new DataView();
        DTO dtoNCC = new DTO();
        CTL ctlNCC = new CTL();
        string IDNHAP = "0";
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
            dt.Columns.Add(new DataColumn("MAMH"));
            dt.Columns.Add(new DataColumn("TENMH"));
            dt.Columns.Add(new DataColumn("_HSD"));
            dt.Columns.Add(new DataColumn("SOLUONG"));
            dt.Columns.Add(new DataColumn("KMAI"));
            dt.Columns.Add(new DataColumn("DONGIA"));
            dt.Columns.Add(new DataColumn("_DVT"));
            dt.Columns.Add(new DataColumn("_Total"));
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("TIENTHU"));
            dt.Columns.Add(new DataColumn("LOHANG"));
            gridControl1.DataSource = dt;
            CountRowTBEdit = 0;

            gridCTHOADON.Columns["DONGIA"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["_Total"].ColumnEdit = this.repositoryItemTextEdit1;
            gridCTHOADON.Columns["TIENTHU"].ColumnEdit = this.repositoryItemTextEdit1;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            if (!PublicVariable.isHSD)
            {
                gridCTHOADON.Columns["_HSD"].Visible = false;
 
            }
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
        public void loadgridCTHOADONTAM(string MHDX)
        {
            DataTable dt = new DataTable();
            dt = ctlNCC.GETCTHOADONXUATTAM(MHDX);
            gridControl1.DataSource = dt;

            CountRowTBEdit = dt.Rows.Count;

        }
        public void loadGrid_sanpham()
        {
            if (PublicVariable.isBANGGIA)
            {
                Grid_sanpham.DataSource = ctlNCC.GETMMH_BG(txtmakh.Text);
            }
            else
            {
                Grid_sanpham.DataSource = ctlNCC.GETMMH();
            }
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
            cktien.Text = "0";
            ckphantram.Text = "0";
            txtthanhtien.Text = "0";
            Create_new();
            gridControl2.DataSource = ctlNCC.GETCTHOADONXUATTAM();
            if (!PublicVariable.isKHOILUONG)
            {
                gridViewSANPHAM.Columns["KHOILUONG"].Visible = false;
                gridViewTONGSANPHAM.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void cboTenKH_Validated(object sender, EventArgs e)
        {
            LOAD_TTKH();
            loadgridCTHOADON();
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
            if (XtraMessageBox.Show("Bạn có muốn Lưu Vào Hóa Đơn Khách Hàng Trả Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtmakh.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng chọn Mã Khách Hàng");
                    }
                    else
                    {
                      
                        PublicVariable.SQL_TRAXUAT = "";
                        dtoNCC.MAKH = txtmakh.Text;
                        dtoNCC.TENKH = cboTenKH.Text;
                        dtoNCC.DIACHI = txtDiachi.Text;
                        dtoNCC.SDT = txtSDT.Text;
                        dtoNCC.CKTIEN = cktien.Value.ToString();
                        
                        dtoNCC.TIENPHAITRA = Convert.ToInt32(txtthanhtien.Value);
                        dtoNCC.MAHDX = txtMaHD.Text;
                        if (cbotientra.Text == "")
                        {
                            cbotientra.Text = "0";
                        }
                        dtoNCC.GHICHU = txtghichu.Text;
                        dtoNCC.TIENDATRA = Convert.ToInt32(cbotientra.Value);
                        dtoNCC.TYPE = "1";
                        int rowcount = gridCTHOADON.DataRowCount;


                        if (rowcount == 0)
                        {
                            XtraMessageBox.Show("Hãy chọn một sản phẩm trước khi lưu");
                            return;
                        }
                       
                 
         
                        if (PublicVariable.isHSD)
                        {
                            string SQL1 = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                            DataTable dttime = ctlNCC.GETDATA(SQL1);
                            String timenow = dttime.Rows[0][0].ToString();

                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = gridCTHOADON.GetDataRow(i);
                                //insert_HoadonChitiet(txtMaHD.Text, dtr["MAMH"].ToString(), Convert.ToDouble(dtr["SOLUONG"].ToString()), Convert.ToInt32(dtr["DONGIA"].ToString()));
                                if (dtr["_HSD"].ToString() == "")
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " Chưa có Hạn Sử Dụng ");
                                    return;
                                }
                                else if (DateTime.Parse(timenow) >= DateTime.Parse(dtr["_HSD"].ToString()))
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " Hạn Sử Dụng Quá Ngắn ");
                                    return;
                                }
                                DateTime time = DateTime.Parse(dtr["_HSD"].ToString());
                            }
                        }

                        for (int i = 0; i < rowcount; i++)
                        {
                            DataRow dtr = gridCTHOADON.GetDataRow(i);
                            //insert_HoadonChitiet(txtMaHD.Text, dtr["MAMH"].ToString(), Convert.ToDouble(dtr["SOLUONG"].ToString()), Convert.ToInt32(dtr["DONGIA"].ToString()));
                            if (dtr["SOLUONG"].ToString() == "")
                            {
                                MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " Số lượng quá ít ");
                                return;
                            }
                            else
                            {
                                Double soluong = Convert.ToDouble(dtr["SOLUONG"].ToString());
                                if (soluong <= 0)
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " Số lượng quá ít ");
                                    return;
                                }
                            }
                            for (int j = i + 1; j < rowcount; j++)
                            {
                                DataRow dtr2 = gridCTHOADON.GetDataRow(j);
                                if (dtr["MAMH"].ToString() == dtr2["MAMH"].ToString())
                                {
                                    MessageBox.Show("Mã Hàng:" + dtr["MAMH"].ToString() + " Không được nhập nhiều lần ");
                                    return;
                                }
                            }
                        }
                        dtoNCC.NGAYNHAP = "convert(varchar,getDate(),101)";
                        if (PublicVariable.isUSE_COMPUTERDATE)
                        {
                            dtoNCC.NGAYNHAP = "'" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
                        }
                        dtoNCC.NGAYXUAT = dtoNCC.NGAYNHAP;

                        
                            

                        if (isnhap)
                        {
                            if (THEM == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                                return;
                            }

                        
                            dtoNCC.IsUPDATE = false;
                            dtoNCC.IDNHAP = ctlNCC.getIDNHAP();
                            
                            //insert hoa don chi tiet
                            
                            loadmahdx();
                            dtoNCC.MAHDX = txtMaHD.Text;
                           
                            ctlNCC.INSERTtraHOADONXUAT(dtoNCC);
                            try
                            {
                                ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRAXUAT);
                                PublicVariable.SQL_TRAXUAT = "";
                            }
                            catch
                            {
                                MessageBox.Show("Vui lòng thử lưu lại");
                                return;
                            }
                      
                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                string HSD = "";

                                HSD = dtr["_HSD"].ToString();
                                if (HSD.Length > 5)
                                {
                                    HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                                }
                                insert_HoadonChitietxuat(txtMaHD.Text, dtr["MAMH"].ToString(), Convert.ToDouble(dtr["SOLUONG"].ToString()), Convert.ToInt32(dtr["DONGIA"].ToString()), Convert.ToInt32(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString(), i);
                            }
                            ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRAXUAT);
                            PublicVariable.SQL_TRAXUAT = "";
                     
                            MessageBox.Show("Bạn Đã Thêm Thành Công");
                        }
                        else
                        {
                            
                            if (PublicVariable.SUA == "False")
                            {
                                MessageBox.Show("KHÔNG CÓ QUYỀN SỬA HÓA ĐƠN");
                                return;
                            }
                            PublicVariable.TMPlog = "";
                            dtoNCC.IsUPDATE = true;
                            dtoNCC.IDNHAP = IDNHAP;
                            ctlNCC.UPDATEtraHOADONXUAT(dtoNCC);
                            int MAXID = Convert.ToInt32(ctlNCC.getmaxidTRAXUAT(txtMaHD.Text));
                            for (int i = 0; i < rowcount; i++)
                            {
                                DataRow dtr = dtr = gridCTHOADON.GetDataRow(i);
                                String sID = dtr["ID"].ToString();

                                if (sID != "")
                                {
                                    update_HoadonChitietxuat(txtMaHD.Text, Convert.ToInt32(sID), dtr["MAMH"].ToString(), dtr["LOHANG"].ToString(), Convert.ToDouble(dtr["SOLUONG"].ToString()), Convert.ToInt32(dtr["DONGIA"].ToString()), Convert.ToInt32(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString());
                                }
                                else
                                {
                                    insert_HoadonChitietxuat(txtMaHD.Text, dtr["MAMH"].ToString(), Convert.ToDouble(dtr["SOLUONG"].ToString()), Convert.ToInt32(dtr["DONGIA"].ToString()), Convert.ToInt32(dtr["TIENTHU"].ToString()), dtr["_HSD"].ToString(), dtr["KMAI"].ToString(),MAXID+ i);
                                }
                            }
                            DataTable TABLE_SAU = (DataTable)gridControl1.DataSource;

                            for (int i = 0; i < TABLE_SAU.Rows.Count; i++)
                            {
                                DataTable dtname = ctlNCC.GETDATA("select TENMH from MATHANG where MAMH='" + TABLE_SAU.Rows[0]["MAMH"].ToString() + "'");
                                TABLE_SAU.Rows[i]["TENMH"] = dtname.Rows[0][0].ToString();
                            }

                            DataTable TABLE_TRUOC = ctlNCC.GETDATA("SELECT MATHANG.MAMH,TENMH,SOLUONGXUAT AS SOLUONG,KMAI FROM MATHANG, TRACHITIETHDX WHERE MATHANG.MAMH=TRACHITIETHDX.MAMH AND MAHDX='" + txtMaHD.Text + "'");

                            PublicVariable.TMPtring = "";
                            frmsuahd SUAhd = new frmsuahd();
                            SUAhd.MAHD = txtMaHD.Text;
                            SUAhd.LISTTRUOC = TABLE_TRUOC;
                            SUAhd.LISTSAU = TABLE_SAU;

                            SUAhd.ShowDialog();
                            if (PublicVariable.TMPtring == "")
                            {
                                return;
                            }
                            ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRAXUAT);
                            ctlNCC.executeNonQuery("INSERT INTO [LOG]([MAHD],[LOG],[LYDO]) VALUES('" + txtMaHD.Text + "',N'" + PublicVariable.TMPlog + "',N'" + PublicVariable.TMPtring + "') ");
                            
                            PublicVariable.SQL_TRAXUAT = "";
                            MessageBox.Show("Bạn Đã Sửa Thành Công");
                        }






                        loadGiaoDich();
                       
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

        public void insert_HoadonChitietxuat(string mahdx, String mamh, Double SoLuong, int DonGia, int tienthu, string HSD, String KMAI,int STT)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;
                
                dtoNCC.GIABAN = DonGia.ToString();
                dtoNCC.TIENTHU = tienthu;
                HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                dtoNCC.HSD = HSD;
                dtoNCC.KMAI = KMAI;
                string SQL = "SELECT MAX(ID) FROM traCHITIETHDX WHERE MAHDX='" + mahdx + "'";
                DataTable dt = ctlNCC.GETDATA(SQL);
                dtoNCC.ID = 1+STT;
                if (dt.Rows[0][0].ToString() != "")
                {
                    dtoNCC.ID = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1 + STT;
                }

                if (PublicVariable.isHSD)
                {
                    dtoNCC.LOHANG = txtlohang.Text;
                }
                else
                {
                    dtoNCC.LOHANG = PublicVariable.LOHANG;
                }

                ctlNCC.INSERTtraCTHOADONXUAT(dtoNCC);
      
                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu"+ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }
        public void update_HoadonChitietxuat(string mahdx, int ID, String mamh, string LOHANG, Double SoLuong, int DonGia, int tienthu, string HSD, String KMAI)
        {
            try
            {
                dtoNCC.MAHDX = mahdx;
                dtoNCC.MAMH = mamh;
                dtoNCC.SOLUONGXUAT = SoLuong;
                dtoNCC.GIATIEN = DonGia;

                if (PublicVariable.isHSD)
                {
                    dtoNCC.LOHANG = txtlohang.Text;
                }
                else
                {
                    dtoNCC.LOHANG = PublicVariable.LOHANG;
                }
                dtoNCC.GIABAN = DonGia.ToString();
                HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                dtoNCC.HSD = HSD;
                dtoNCC.ID = ID;
                dtoNCC.KMAI = KMAI;
                dtoNCC.TIENTHU = tienthu;
                
                ctlNCC.UPDATEtraCTHOADONXUAT(dtoNCC);

                //ctlNCC.INSERTCTHOADONXUAT(dtoNCC);
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu"+ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { }
        }

      
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
                    string ten = "Khách trả hàng";
                    DataTable dt = new DataTable();
                    dt = ctlNCC.GETTRACTHOADONXUATIN(txtMaHD.Text);
                    Inxuat rep = new Inxuat(dt, cboTenKH.Text, txtDiachi.Text, cbotientra.Value.ToString(), txtconLai.Value.ToString(), txtthanhtien.Value.ToString(),cktien.Value.ToString(), txtMaHD.Text, ten);
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
            isnhap = true;
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            txtmakh.Text = "";
            cboTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";           
            txtMaHD.Text = "";
            txtNgayXuat.Text = DateTime.Now.ToString("yyy/MM/dd");
            txtNo.Text = "0";
            txtconLai.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "0";
            txtNo.Text = "0";
            txtconLai.Text = "0";

           
            btLuu.Enabled = true;
            cboTenKH.Enabled = true;
            txtghichu.Text = "";
            cktien.Text = "0";
            ckphantram.Text = "0";
            cbotientra.Text = "0";
            txtthanhtien.Text = "0";
            txtconLai.Text = "0";
            cbotientra.Properties.ReadOnly = false;
            txtlohang.ReadOnly = false;
            ckphantram.Properties.ReadOnly = false;
            cktien.Properties.ReadOnly = false;
            loadmahdx();
            gridControl1.DataSource = null;
            gridCTHOADON.RefreshData();
            loadgridKhachHang();
            Grid_sanpham.DataSource = null;
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
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) AS NGAYXUAT,T1.MAHDX ,T1.TENKH ,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA)AS TONGTIEN ,T1.GHICHU  FROM (select t9.*,t8.tenkh from TRAHOADONXUAT   as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  TYPE=1 AND t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV ORDER BY T1.MAHDX DESC";
            
            

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewPHIEUTRA;
            gridControl3.DataSource = TBS;
            gridViewPHIEUTRA.RefreshData();
            gridControl3.RefreshDataSource();
            gridViewPHIEUTRA.BestFitColumns();

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
            string SQL = "SELECT convert(varchar,T3.NGAYXUAT,103) AS NGAYXUAT,T3.TENKH ,T3.MAHDX , T3.MAMH , T4.TENMH ,T3.SOLUONGXUAT,KMAI,T3.SOLUONGXUAT*kldvt as KHOILUONG ,T3.GIATIEN,soluongxuat*giatien AS THANHTIEN,TIENTHU,TENNCC, GHICHU,LOHANG   FROM (select T2.NGAYXUAT,T1.MAHDX,T1.MAMH,T1.SOLUONGXUAT,KMAI,T1.GIABAN AS GIATIEN,GHICHU,TIENTHU,LOHANG,t2.tenkh FROM (SELECT * FROM TRACHITIETHDX ) AS T1 INNER JOIN (select t9.ngayxuat,t9.mahdx,t9.makh,t8.tenkh,GHICHU from TRAHOADONXUAT  as t9  INNER JOIN khachhang as t8 on t9.makh=t8.makh WHERE  TYPE=1 AND t9.MAKHO='" + PublicVariable.MAKHO + "' AND NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') AS T2 ON T1.MAHDX =T2.MAHDX) as T3 INNER JOIN (SELECT TENMH,MAMH,TENNCC,KLDVT FROM MATHANG,NHACUNGCAP WHERE NHACUNGCAP.MANCC=MATHANG.MANCC) AS T4 ON T3.MAMH =T4.MAMH";
      
            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewSANPHAM;
            gridControl3.DataSource = TBS;
            //gridView4.Columns["Mã Hóa Đơn"].Group();
            //gridView4.Columns["Mã Hóa Đơn"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridViewSANPHAM.ExpandAllGroups();
            gridViewSANPHAM.RefreshData();
            gridControl3.RefreshDataSource();
            gridViewSANPHAM.BestFitColumns();
            
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

            //String SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC,KLDVT, DONVITINH, sum(TRAXUAT) as SOLUONGXUAT,TONKHO.GIAXUAT AS GIATIEN,SUM(TIENTHU) AS TIENTHU, SUM(TRAXUAT*TONKHO.GIAXUAT) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,TONKHO WHERE MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND  MATHANG.MAKHO='" + PublicVariable.MAKHO + "' AND TRAXUAT>0 AND TONKHO.NGAY BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "' group by MATHANG.MAMH, TENMH, TENNCC,KLDVT, DONVITINH,TONKHO.GIAXUAT";
            string SQL = "SELECT MATHANG.MAMH, TENMH, TENNCC, KLDVT, DONVITINH,LOHANG,sum(SOLUONGXUAT*KLDVT) AS KHOILUONG,sum(KMAI) as KMAI, sum(SOLUONGXUAT) as SOLUONGXUAT, GIATIEN,SUM(TIENTHU) AS TIENTHU, SUM(SOLUONGXUAT*GIATIEN) AS TONGTIEN FROM MATHANG,NHACUNGCAP,DONVITINH,(select MAMH,SOLUONGXUAT,KMAI, GIABAN AS GIATIEN,TIENTHU,LOHANG FROM TRACHITIETHDX,TRAHOADONXUAT WHERE TYPE=1 AND TRACHITIETHDX.MAHDX=TRAHOADONXUAT.MAHDX AND  NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as TRACHITIETHDX WHERE MATHANG.MANCC=NHACUNGCAP.MANCC  AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=TRACHITIETHDX.MAMH AND MATHANG.MAKHO='" + PublicVariable.MAKHO + "' group by mathang.MAMH,TENMH, TENNCC, DONVITINH,GIATIEN,KLDVT,LOHANG ";

            DataTable TBS = ctlNCC.GETDATA(SQL);
            gridControl3.MainView = gridViewTONGSANPHAM;
            gridControl3.DataSource = TBS;
            
            gridViewTONGSANPHAM.RefreshData();
            gridControl3.RefreshDataSource();
            if (!PublicVariable.isKHOILUONG)
            {
                gridViewTONGSANPHAM.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void gridCTHOADON_CellValuedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = gridCTHOADON.GetDataRow(gridCTHOADON.FocusedRowHandle);
            if (dtr != null)
                if (dtr["TENMH"].ToString() != "")
                {
                    if (e.Column.FieldName.ToString() == "TENMH")
                    {
                        string SMAMH = dtr["TENMH"].ToString();
                        int index = SMAMH.IndexOf("_");
                        string MAMH = SMAMH.Substring(0, index);
                        string LOHANG = SMAMH.Substring(index + 1, SMAMH.Length - index - 1);
                        for (int i = 0; i < gridCTHOADON.DataRowCount; i++)
                        {
                            DataRow dtr2 = gridCTHOADON.GetDataRow(i);
                            if (dtr2["MAMH"].ToString() == MAMH && dtr2["LOHANG"].ToString() == LOHANG)
                            {
                                if (PublicVariable.isHSD)
                                {
                                    MessageBox.Show("Mặt hàng với lô hàng này đã nhận trả bên trên rồi");
                                }
                                else
                                {
                                    MessageBox.Show("Mặt hàng này đã nhận trả bên trên rồi");
                                }
                                return;
                            }
                        }
                        DataTable dtmh = ctlNCC.GETMATHANG_KHTRA(MAMH, LOHANG, txtmakh.Text);
                        dtr["MAMH"] = dtmh.Rows[0]["MAMH"];
                        dtr["SOLUONG"] = "0";
                        dtr["KMAI"] = "0";
                        try
                        {
                            dtr["_HSD"] = "";
                        }
                        catch { }
                        dtr["DONGIA"] = dtmh.Rows[0]["GIABAN"];
                        //dtr["_Thue"] = dtmh.Rows[0]["SOTHUE"];
                        dtr["_DVT"] = dtmh.Rows[0]["DONVITINH"];
                        dtr["_Total"] = "0";
                        dtr["TIENTHU"] = "0";
                        dtr["LOHANG"] = dtmh.Rows[0]["LOHANG"];
                    }
                    else if (e.Column.FieldName.ToString() == "SOLUONG")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["SOLUONG"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Convert.ToDouble(dtr["DONGIA"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["SOLUONG"] = "0";
                            dtr["KMAI"] = "0";
                            dtr["_Total"] = "0";
                            dtr["TIENTHU"] = "0";
                        }
                    }
                    else if (e.Column.FieldName.ToString() == "_HSD")
                    {
                        string NGAY = dtr["_HSD"].ToString();
                        if (NGAY.Length > 10)
                            dtr["_HSD"] = NGAY.Substring(0, 10);
                    }
                    else if (e.Column.FieldName.ToString() == "DONGIA")
                    {
                        Double Num;
                        bool isNum = Double.TryParse(dtr["DONGIA"].ToString(), out Num);
                        if (isNum)
                        {
                            Double total = Convert.ToDouble(dtr["DONGIA"].ToString()) * Num;
                            dtr["_Total"] = total.ToString();
                            dtr["TIENTHU"] = total.ToString();
                            gettotal();
                        }
                        else
                        {
                            dtr["DONGIA"] = "0";
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
                DataRow dtr = gridCTHOADON.GetDataRow(hitInfo.RowHandle);
                if (dtr != null)
                {
                    String sID = "";

                    try
                    {
                        sID = dtr["ID"].ToString();
                    }
                    catch { }
                    if (!isdelete && sID != "")
                    {
                        return;
                    }
                }
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip1.Show(view.GridControl, e.Point);
            }
        }
        private int tienchuack = 0;
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
            tienchuack = Convert.ToInt32(total);
            if (total == 0)
            {
                cktien.Value = 0;
                ckphantram.Value = 0;
            }
            total = total - Convert.ToInt32(cktien.Value);
            txtthanhtien.Text = total.ToString();
            if (cbotientra.Text != "")
            {
                thanhtien = Convert.ToDouble(txtthanhtien.Value);
                tientra = Convert.ToDouble(cbotientra.Value);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gridCTHOADON.FocusedRowHandle < 0)
            {
                return;
            }
            PublicVariable.SQL_TRAXUAT = "";
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
                        MessageBox.Show("KHÔNG CÓ QUYỀN XÓA ");
                        return;
                    }
                    if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    PublicVariable.TMPlog = "";
                    string SMAMH = dtr["TENMH"].ToString();
                    int index = SMAMH.IndexOf("_");
                    string LOHANG = SMAMH.Substring(index + 1, SMAMH.Length - index - 1);
                    String SQL = "Select TONKHO from KHOHANG where mamh='" + dtr["MAMH"].ToString() + "' AND LOHANG='" + LOHANG + "'";


                    DataTable dt = ctlNCC.GETDATA(SQL);
                    Double SOLUONGXUATHT = Convert.ToDouble(dtr["SOLUONG"].ToString()) + Convert.ToDouble(dtr["KMAI"].ToString());
                    if (SOLUONGXUATHT > Convert.ToDouble(dt.Rows[0]["TONKHO"].ToString()))
                    {
                        MessageBox.Show("Mặt hàng trong Lô Hàng này đã Xuất nên không thể xóa  ");
                        return;
                    }

                    string SQLNGAY = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime , TENMH FROM MATHANG WHERE MAMH='" + dtr["MAMH"].ToString() + "' ";
                    DataTable dtn = ctlNCC.GETDATA(SQLNGAY);
                    if (txtNgayXuat.Text != dtn.Rows[0][0].ToString())
                    {
                        MessageBox.Show("Không phải hóa đơn hôm nay nên không thể xóa, chỉ có thể xóa hóa đơn trong ngày  ");
                        return;
                    }

                    PublicVariable.TMPtring = "";
                    frmxoahd xhd = new frmxoahd();
                    xhd.MAHD = txtMaHD.Text;
                    xhd.MAMH = dtr["MAMH"].ToString();
                    xhd.TENMH = dtn.Rows[0]["TENMH"].ToString();
                    xhd.SOLUONG = dtr["SOLUONG"].ToString();
                    xhd.ShowDialog();
                    if (PublicVariable.TMPtring == "")
                    {
                        return;
                    }


                    ctlNCC.DELETEtraCTHOADONXUAT(txtMaHD.Text, Convert.ToInt32(sID), dtr["MAMH"].ToString(), dtr["LOHANG"].ToString(), dtr["SOLUONG"].ToString(), dtr["KMAI"].ToString());
                    // ctlNCC.UPDATE_KHOHANG_NX(dtr["MAMH"].ToString(), "1", "0", "0", "0", (-soluonghientai).ToString());
                    // PublicVariable.TMPtring = "";


                }
                else
                {
                    gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                    gettotal();

                    dtoNCC.MAKH = txtmakh.Text;
                    dtoNCC.TENKH = cboTenKH.Text;
                    dtoNCC.DIACHI = txtDiachi.Text;
                    dtoNCC.SDT = txtSDT.Text;

                    // dtoNCC.WEBSITE = txtWeb.Text;
                    dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                    dtoNCC.TIENPHAITRA = Convert.ToInt32(txtthanhtien.Value);
                    dtoNCC.MAHDX = txtMaHD.Text;
                    if (cbotientra.Text == "")
                    {
                        cbotientra.Text = "0";
                    }
                    dtoNCC.GHICHU = txtghichu.Text;

                    dtoNCC.TIENDATRA = Convert.ToInt32(cbotientra.Value);
                    return;
                }
                gridCTHOADON.DeleteRow(gridCTHOADON.FocusedRowHandle);
                gettotal();
                dtoNCC.MANV = sMaNV;
                dtoNCC.MAKH = txtmakh.Text;
                dtoNCC.TENKH = cboTenKH.Text;
                dtoNCC.DIACHI = txtDiachi.Text;
                dtoNCC.SDT = txtSDT.Text;
                dtoNCC.CKTIEN = cktien.Value.ToString();
                // dtoNCC.WEBSITE = txtWeb.Text;
                dtoNCC.NGAYXUAT = DateTime.Now.ToString("yyy/MM/dd");
                dtoNCC.TIENPHAITRA = Convert.ToInt32(txtthanhtien.Value);
                dtoNCC.MAHDX = txtMaHD.Text;
                if (cbotientra.Text == "")
                {
                    cbotientra.Text = "0";
                }
                dtoNCC.GHICHU = txtghichu.Text;
                dtoNCC.TYPE = "1";
                dtoNCC.TIENDATRA = Convert.ToInt32(cbotientra.Value);

                ctlNCC.UPDATEtraHOADONXUAT(dtoNCC);
                if (sID != "")
                {
                    ctlNCC.EXCUTE_SQL2(PublicVariable.SQL_TRAXUAT);
                    ctlNCC.executeNonQuery("INSERT INTO [LOG]([MAHD],[LOG],[LYDO]) VALUES('" + txtMaHD.Text + "',N'" + PublicVariable.TMPlog + "',N'" + PublicVariable.TMPtring + "') ");

                }
                PublicVariable.SQL_TRAXUAT = "";
                MessageBox.Show("Bạn Đã Xóa Thành Công");

            }

        }
        public void View_phieuxuat(string MAHDX)
        {
            loadgridCTHOADON(MAHDX);

            txtMaHD.Text = MAHDX;
            string SQL = "SELECT convert(varchar,T1.NGAYXUAT,103) ,T1.MAHDX ,T2.MANV,T2.TENNV ,T1.TIENPHAITRA ,T1.TIENDATRA ,(T1.TIENPHAITRA - T1.TIENDATRA) TIENNO,GHICHU,CKTIEN,IDNHAP FROM (SELECT * FROM traHOADONXUAT WHERE MAHDX='" + MAHDX + "' AND  MAKHO='" + PublicVariable.MAKHO + "') AS T1 INNER JOIN NHANVIEN AS T2 ON T1.MANV =T2.MANV";
            DataTable DT = ctlNCC.GETDATA(SQL);
            txtnhanvienlap.Text = DT.Rows[0]["TENNV"].ToString();
            txtthanhtien.Text = DT.Rows[0]["TIENPHAITRA"].ToString();
            cbotientra.Text = DT.Rows[0]["TIENDATRA"].ToString();
            txtconLai.Text = DT.Rows[0]["TIENNO"].ToString();
            IDNHAP = DT.Rows[0]["IDNHAP"].ToString();
            txtghichu.Text = DT.Rows[0]["GHICHU"].ToString();

            int _cktien = Convert.ToInt32(DT.Rows[0]["CKTIEN"].ToString());
            cktien.Value = _cktien;
            double thanhtien = tienchuack;
            if (_cktien > 0 && thanhtien > 0)
            {
                ckphantram.Value = Convert.ToDecimal(_cktien / thanhtien * 100);
            }
            else
            {
                ckphantram.Value = 0;
                cktien.Value = 0;

            }

            gettotal();
        }
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            btLuu.Enabled = false;
            isnhap = false;
            isdelete = false;
            cboTenKH.Enabled = false;
            cbotientra.Properties.ReadOnly = true;
            txtlohang.ReadOnly = true;
            Load_panel_create();
            loadgridCTHOADON();
            DataRow dtr;
 
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                if (gridViewPHIEUTRA.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                if (gridViewSANPHAM.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string MAKH = ctlNCC.GETMAKHfromtraMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
            loadGrid_sanpham();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            DataRow dtr;

            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                if (gridViewPHIEUTRA.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                if (gridViewSANPHAM.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYXUAT FROM TRAHOADONXUAT WHERE MAHDX='" + dtr["MAHDX"].ToString() + "')>(SELECT NGAY FROM KHOASO WHERE ID=7)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASO WHERE ID=7) AS NGAY";
            DataTable DTKHOA = ctlNCC.GETDATA(SQLKHOA);
            if (DTKHOA.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                return;
            }
            gridCTHOADON.OptionsBehavior.ReadOnly = false;
            btLuu.Enabled = true;
            isnhap = false;
            isdelete = false;
            cboTenKH.Enabled = false;
            cbotientra.Properties.ReadOnly = true;
            txtlohang.ReadOnly = true;
            Load_panel_create();
            loadgridCTHOADON();
           
            string MAKH = ctlNCC.GETMAKHfromtraMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
            loadGrid_sanpham();
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

            if (view.FocusedColumn.FieldName == "TENMH" && CountRowTBEdit > 0)
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
            if (XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            loadgrid();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl3.DataSource;
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                Inhd rep = new Inhd(printtable, 6);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridViewSANPHAM)
            {
                Inhd rep = new Inhd(printtable, 7);
                rep.ShowPreviewDialog();
            }
            if (gridControl3.MainView == gridViewTONGSANPHAM)
            {
                Inhd rep = new Inhd(printtable, 8);
                rep.ShowPreviewDialog();
            }
           // gridControl3.ShowPrintPreview();
            /*
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
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
            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }

            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                loadgridPHIEUXUAT();
            }
            else if (gridControl3.MainView == gridViewSANPHAM)
            {
                loadgridSANPHAM();
            }
            else if (gridControl3.MainView == gridViewTONGSANPHAM)
            {
                loadgridTONGSANPHAM();
            }
        }

 

        private void txtMaHD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                kiemtramahd();
            }
        }
        public void kiemtramahd()
        {
            if (txtMaHD.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền mã hóa đơn xuất");
                //txtMaHD.Focus();
                return;
            }

            String SQL = "Select mahdx From hoadonxuat where mahdx='" + txtMaHD.Text + "' and makho='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlNCC.GETDATA(SQL);
            if (dt.Rows.Count <= 0)
            {
                txtMaHD.Text = "";
                XtraMessageBox.Show("Không có mã hóa đơn này");
                //txtMaHD.Focus();
                return;
            }

            loadGrid_sanpham();
            loadgridCTHOADON();
            
        }

        private void txtMaHD_Validated(object sender, EventArgs e)
        {
            kiemtramahd();
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

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Khách Hàng Trả Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

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

        private void ckphantram_Validated(object sender, EventArgs e)
        {
            Double thanhtien = tienchuack;
            int _cktien = Convert.ToInt32(thanhtien * Convert.ToDouble(ckphantram.Value) / 100);
            thanhtien = thanhtien - _cktien;
            txtthanhtien.Text = thanhtien.ToString();
            cktien.Value = _cktien;
            if (cbotientra.Text != "")
            {
                tientra = Convert.ToDouble(cbotientra.Value);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }
        }

        private void cktien_Validated(object sender, EventArgs e)
        {
            Double thanhtien = tienchuack;
            int _cktien = Convert.ToInt32(cktien.Value);
            if (_cktien > 0 && thanhtien > 0)
            {
                ckphantram.Value = Convert.ToDecimal(_cktien / thanhtien * 100);
            }
            else
            {
                ckphantram.Value = 0;
                cktien.Value = 0;

            }
            thanhtien = thanhtien - _cktien;
            txtthanhtien.Text = thanhtien.ToString();
            if (cbotientra.Text != "")
            {
                tientra = Convert.ToDouble(cbotientra.Value);
                conlai = thanhtien - tientra;
                txtconLai.Text = conlai.ToString();
            }

        }

        private void cbotientra_Validated(object sender, EventArgs e)
        {
            thanhtien = Convert.ToDouble(txtthanhtien.Value);
            tientra = Convert.ToDouble(cbotientra.Value);
            conlai = thanhtien - tientra;
            txtconLai.Text = conlai.ToString();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XÓA");
                return;
            }
            DataRow dtr;
            if (gridControl3.MainView == gridViewPHIEUTRA)
            {
                if (gridViewPHIEUTRA.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewPHIEUTRA.GetDataRow(gridViewPHIEUTRA.FocusedRowHandle);
            }
            else
            {
                if (gridViewSANPHAM.FocusedRowHandle < 0)
                {
                    return;
                }
                dtr = gridViewSANPHAM.GetDataRow(gridViewSANPHAM.FocusedRowHandle);
            }
            if (dtr == null)
            {
                return;
            }
            string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYXUAT FROM TRAHOADONXUAT WHERE MAHDX='" + dtr["MAHDX"].ToString() + "')>(SELECT NGAY FROM KHOASO WHERE ID=7)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASO WHERE ID=7) AS NGAY";
            DataTable DTKHOA = ctlNCC.GETDATA(SQLKHOA);
            if (DTKHOA.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                return;
            }
            gridCTHOADON.OptionsBehavior.ReadOnly = true;
            btLuu.Enabled = false;
            isnhap = false;
            isdelete = true;
            cboTenKH.Enabled = false;
            cbotientra.Properties.ReadOnly = true;
            txtlohang.ReadOnly = true;
            ckphantram.Properties.ReadOnly = true;
            cktien.Properties.ReadOnly = true;
            Load_panel_create();
            loadgridCTHOADON();
        
      
            
            string MAKH = ctlNCC.GETMAKHfromtraMHDX(dtr["MAHDX"].ToString());
            View_phieuxuat(dtr["MAHDX"].ToString());
            txtNgayXuat.Text = dtr["NGAYXUAT"].ToString();
            loadgridKhachHang(MAKH);
            LOAD_TTKH();
            loadGrid_sanpham();
        }

    }
}