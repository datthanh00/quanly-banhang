using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using System.Globalization;
using System.Threading;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1
{
    public partial class frmThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        /*_______________________________________________________________
         |                *   Doan Ngoc Anh   *                          |
         |                 Thống kê doanh thu                            |
         |_______________________________________________________________|
         */
        string dateNgayBD, dateNgayKT;
        string baocaotype = "";
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        DataTable tb = new DataTable();
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        
        public void vLucLoad()
        {
            
            if (iNgonNgu==0)
            {
                xtraTabPage5.Text = "Chọn Thông Kê Doanh Thu";
            }
            if (iNgonNgu==1)
            {
                xtraTabPage5.Text = "Select sales statistics";
            }
            
        }
        private void loadVN()
        {
            iNgonNgu = 0;
            xtraTabPage5.Text = "Chọn Thông Kê Doanh Thu";

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
          /*  colTongDanhThu.Caption = resVietNam.colTongDanhThu.ToString();
            colKhucVuc.Caption = resVietNam.colTenKhuVuc.ToString();
            ColTenKhachHang.Caption = resVietNam.colKhachHang.ToString();
            colNgayXuat.Caption = resVietNam.colNgay.ToString();
           */ 
            btXem.Text = resVietNam.btXem.ToString();
            btXuatDuLieu.Text = resVietNam.btXuat.ToString();
            btIn.Text = resVietNam.btIn.ToString();
            btDong.Text = resVietNam.btDong.ToString();
            linkTheoNam.Caption = resVietNam.linkTheoNam.ToString();
            linkTheoThang.Caption = resVietNam.linkTheoThang.ToString();
            linkTheoQui.Caption = resVietNam.linkTheoQui.ToString();
            linkTheoNgay.Caption = resVietNam.linkTheoNgay.ToString();
          
            dockChucNang.Text = resVietNam.nvaChucNang.ToString();
            lbTu.Text = resVietNam.NgayBD.ToString();
            lbDen.Text = resVietNam.NgayKT.ToString();

        }
        public void loadEN()
        {
            iNgonNgu = 1;
            xtraTabPage5.Text = "Select sales statistics";

             CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resEngLand.btXem.ToString();
            btXuatDuLieu.Text = resEngLand.btXuat.ToString();
            btIn.Text = resEngLand.btIn.ToString();
            btDong.Text = resEngLand.btDong.ToString();
            linkTheoNam.Caption = resEngLand.linkTheoNam.ToString();
            linkTheoThang.Caption = resEngLand.linkTheoThang.ToString();
            linkTheoQui.Caption = resEngLand.linkTheoQui.ToString();
            linkTheoNgay.Caption = resEngLand.linkTheoNgay.ToString();
            dockChucNang.Text = resEngLand.nvaChucNang.ToString();
            lbTu.Text = resEngLand.NgayBD.ToString();
            lbDen.Text = resEngLand.NgayKT.ToString(); 
        }

        public void load_cbthoigian()
        {
            cbThoiGian.Properties.Items.Add("Hôm nay");
            cbThoiGian.Properties.Items.Add("Tháng này");
            cbThoiGian.Properties.Items.Add("Năm này");
            cbThoiGian.Properties.Items.Add("Tháng 1");
            cbThoiGian.Properties.Items.Add("Tháng 2");
            cbThoiGian.Properties.Items.Add("Tháng 3");
            cbThoiGian.Properties.Items.Add("Tháng 4");
            cbThoiGian.Properties.Items.Add("Tháng 5");
            cbThoiGian.Properties.Items.Add("Tháng 6");
            cbThoiGian.Properties.Items.Add("Tháng 7");
            cbThoiGian.Properties.Items.Add("Tháng 8");
            cbThoiGian.Properties.Items.Add("Tháng 9");
            cbThoiGian.Properties.Items.Add("Tháng 10");
            cbThoiGian.Properties.Items.Add("Tháng 11");
            cbThoiGian.Properties.Items.Add("Tháng 12");
            cbThoiGian.SelectedIndex = 1;
        }

        public void loadNgay()
        {
            switch (cbThoiGian.SelectedIndex)
            {

                case 0:
                    {
                        dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
                        dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");

                        break;
                    }
                case 1:
                    {
                        dateDen.Text = "31/" + DateTime.Now.ToString("MM/yyy");
                        dateTu.Text = "01/" + DateTime.Now.ToString("MM/yyy");

                        break;
                    }
                case 2:
                    {
                        dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 3:
                    {
                        dateDen.Text = "31/01/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 4:
                    {
                        dateDen.Text = "28/02/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/02/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 5:
                    {
                        dateDen.Text = "31/03/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/03/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 6:
                    {
                        dateDen.Text = "30/04/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/04/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 7:
                    {
                        dateDen.Text = "31/05/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/05/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 8:
                    {
                        dateDen.Text = "30/06/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/06/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 9:
                    {
                        dateDen.Text = "31/07/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/07/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 10:
                    {
                        dateDen.Text = "31/08/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/08/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 11:
                    {
                        dateDen.Text = "30/09/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/09/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 12:
                    {
                        dateDen.Text = "31/10/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/10/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 13:
                    {
                        dateDen.Text = "30/11/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/11/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 14:
                    {
                        dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/12/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 15:
                    {

                        dateDen.Text = DateTime.Now.ToString("yyy/MM/dd");

                        dateTu.Text = DateTime.Now.ToString("yyy/MM/dd");

                        break;
                    }

            }

        }

        public void load()
        {
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dateNgayBD = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dateNgayKT = NGAYKT;

            dto.NGAYBD = dateNgayBD;
            dto.NGAYKT = dateNgayKT;

            int ingaybd = Convert.ToInt32(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu.Text.Substring(0, 2));
            int ingaykt = Convert.ToInt32(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt32(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }

            if (isxemclick == false)
            {
                gridControl6.DataSource = null;
                return;
            }
            
            if (baocaotype == "MH_NGAY")
            {
               gridControl6.DataSource = ctr.getcpmuahangngay(dto);
            }
            else if (baocaotype == "MH_NCC")
            {
                if (cbncc.Text != "")
                {
                    dto.MANCC = gridncc.GetFocusedRowCellValue("MANCC").ToString();
                    gridncc.ClearSelection();
                    cbncc.Text = "";
                }
                else
                {
                    dto.MANCC = "";
                }
                gridControl6.DataSource = ctr.getcpmuahangncc(dto);
            }
            else if (baocaotype == "BH_NGAY")
            {
                gridControl6.DataSource = ctr.getDoanhThungay(dto);
            }
            else if (baocaotype == "BH_KH")
            {
                if (cbkhachhang.Text != "")
                {
                    dto.MAKH = gridkhachhang.GetFocusedRowCellValue("MAKH").ToString();
                    gridkhachhang.ClearSelection();
                    cbkhachhang.Text = "";
                }
                else
                {
                    dto.MAKH = "";
                }

                gridControl6.DataSource = ctr.getDoanhThukh(dto);
            }
            else if (baocaotype == "DS_NV")
            {
                gridControl6.DataSource = ctr.getDoanhsonv(dto);
            }
            else if (baocaotype == "BH_SP")
            {
                if (cbsanpham.Text != "")
                {
                    dto.MAMH = gridsanpham.GetFocusedRowCellValue("MAMH").ToString();
                    gridsanpham.ClearSelection();
                    cbsanpham.Text = "";
                }
                else
                {
                    dto.MAMH = "";
                }

                gridControl6.DataSource = ctr.getDoanhsosp(dto);
            }
            else if (baocaotype == "MH_SP")
            {
                if (cbsanpham.Text != "")
                {
                    dto.MAMH = gridsanpham.GetFocusedRowCellValue("MAMH").ToString();
                    gridsanpham.ClearSelection();
                    cbsanpham.Text = "";
                }
                else
                {
                    dto.MAMH = "";
                }

                gridControl6.DataSource = ctr.getcpmuahangsp(dto);

            }
            else if (baocaotype == "BH_TRANCC")
            {
                if (cbncc.Text != "")
                {
                    dto.MANCC = gridncc.GetFocusedRowCellValue("MANCC").ToString();
                    gridncc.ClearSelection();
                    cbncc.Text = "";
                }
                else
                {
                    dto.MANCC = "";
                }
                gridControl6.DataSource = ctr.getDoanhThuTRANCC(dto);
            }
            else if (baocaotype == "MH_KHTRA")
            {
                if (cbkhachhang.Text != "")
                {
                    dto.MAKH = gridkhachhang.GetFocusedRowCellValue("MAKH").ToString();
                    gridkhachhang.ClearSelection();
                    cbkhachhang.Text = "";
                }
                else
                {
                    dto.MAKH = "";
                }

                gridControl6.DataSource = ctr.getcpmuahang_KHTRA(dto);
            }

        }
        private void load_cbhanghoa()
        {
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            cbsanpham.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbsanpham.Properties.DisplayMember = "TENMH";
            cbsanpham.Properties.ValueMember = "MAMH";
            cbsanpham.Properties.View.BestFitColumns();
            cbsanpham.Properties.PopupFormWidth = 300;
            cbsanpham.Properties.DataSource = ctr1.dtGetsanpham2();

            cbncc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbncc.Properties.DisplayMember = "TENNCC";
            cbncc.Properties.ValueMember = "MANCC";
            cbncc.Properties.View.BestFitColumns();
            //cbncc.Properties.PopupFormWidth = 200;
            cbncc.Properties.DataSource = ctr1.dtGetNCC();
            gridsanpham.BestFitColumns();

            cbkhachhang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbkhachhang.Properties.DisplayMember = "TENKH";
            cbkhachhang.Properties.ValueMember = "MAKH";
            cbkhachhang.Properties.View.BestFitColumns();
            cbkhachhang.Properties.PopupFormWidth = 300;
            cbkhachhang.Properties.DataSource = ctr1.dtGetKH();

        }
        
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {


            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEN);
            
            load_cbthoigian();
            vLucLoad();
             if (iNgonNgu==0)
             {
                 loadVN();
             }
             if (iNgonNgu==1)
             {
                 loadEN();
             }
             load_cbhanghoa();
             lbloc.Text = "";
             cbkhachhang.Visible = false;
             cbncc.Visible = false;
             cbsanpham.Visible = false;
             dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        bool isxemclick = false;
        
        private void simpleButton21_Click(object sender, EventArgs e)
        {
            try
            {

                isxemclick = true;
                
                load();
                isxemclick = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Vui long chon thong tin");
            }
           
        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            //gridControl6.ShowPrintPreview();
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName!="")
                {
                     gridControl6.ExportToXls(saveFileDialog1.FileName );
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Da ton tai ten");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            //gridControl6.ShowPrintPreview();
           /* if (gridView1.RowCount > 0)
            {
                reportBaoCaoDoanhThu rep = new reportBaoCaoDoanhThu(tb, iNgonNgu);
                rep.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Dữ liệu không có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            * */

            DataTable printtable = (DataTable)gridControl6.DataSource;
            if (gridControl6.MainView == grid_MUAHANG_NGAY)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 0);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_MUAHANG_NCC)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 1);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_MUAHANG_KHACHHANGTRA)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 2);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_BANHANG_NGAY)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 3);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_BANHANG_KHACHHANG)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 4);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_BANHANG_TRANCC)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 5);
                rep.ShowPreviewDialog();
            }
            if (gridControl6.MainView == grid_BANHANG_NHANVIEN)
            {
                Inhdoanhthu rep = new Inhdoanhthu(printtable, 6);
                rep.ShowPreviewDialog();
            }

           // printableComponentLink1.CreateDocument();
           // printableComponentLink1.ShowPreview();
        }

        private void cbThoiGian_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadNgay();
        }

        private void NBI_MH_ngay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "MH_NGAY";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_MUAHANG_NGAY;
        
            //gridView4.Columns.Clear();
            load();
            lbloc.Text = "";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = false;
        }

        private void NBI_MH_NCC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "MH_NCC";
            gridControl6.DataSource = null;
            //gridView4.Columns.Clear();
            gridControl6.MainView = grid_MUAHANG_NCC;

            load();
            lbloc.Text = "Nhà cung cấp";
            cbkhachhang.Visible = false;
            cbncc.Visible = true;
            cbsanpham.Visible = false;

            if (!PublicVariable.isKHOILUONG)
            {
                grid_MUAHANG_NCC.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void NBI_BH_ngay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "BH_NGAY";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_BANHANG_NGAY;
            load();
            lbloc.Text = "";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = false;
        }

        private void NBI_BH_KH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "BH_KH";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_BANHANG_KHACHHANG;
            load();
            lbloc.Text = "Khách Hàng";
            cbkhachhang.Visible = true;
            cbncc.Visible = false;
            cbsanpham.Visible = false;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_BANHANG_KHACHHANG.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void NBI_DS_NV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "DS_NV";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_BANHANG_NHANVIEN;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_BANHANG_NHANVIEN.Columns["KHOILUONG"].Visible = false;
            }
            load();
            lbloc.Text = "";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = false;
        }

        private void NBI_BH_SP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "BH_TRANCC";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_BANHANG_TRANCC;
            load();
            lbloc.Text = "Sản phẩm";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = true;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_BANHANG_TRANCC.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void BANHANG_SANPHAM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "BH_SP";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_BANHANG_SANPHAM;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_BANHANG_SANPHAM.Columns["KHOILUONG"].Visible = false;
            }
            load();
            lbloc.Text = "Sản phẩm";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = true;
        }


        private void NBI_MH_SP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            baocaotype = "MH_KHTRA";
            gridControl6.DataSource = null;
            gridControl6.MainView = grid_MUAHANG_KHACHHANGTRA;
            load();
            lbloc.Text = "Sản phẩm";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = true;
            if (!PublicVariable.isKHOILUONG)
            {
                grid_MUAHANG_KHACHHANGTRA.Columns["KHOILUONG"].Visible = false;
            }
        }

        private void muahang_sanpham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

   
            baocaotype = "MH_SP";
            gridControl6.DataSource = null;
            gridControl6.MainView = gridMUAHANG_SANPHAM;
            if (!PublicVariable.isKHOILUONG)
            {
                gridMUAHANG_SANPHAM.Columns["KLNHAP"].Visible = false;
                gridMUAHANG_SANPHAM.Columns["KLTRAXUAT"].Visible = false;
            }
            load();
            lbloc.Text = "Sản phẩm";
            cbkhachhang.Visible = false;
            cbncc.Visible = false;
            cbsanpham.Visible = true;
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Báo Cáo Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

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