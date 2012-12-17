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
        string sLoaiThoiGian = "";
        string sTheHien;
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        DataTable tb = new DataTable();
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        private void linkTheoThang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (iNgonNgu==0)
            {
                cbHienThiBatDau.Text = "Chọn tháng";
                cbHienThiKeThuc.Text = "Chọn tháng";
                cbNam.Text = "Chọn năm";
                xtraTabPage5.Text = "Doanh thu theo tháng";
            }
            if (iNgonNgu == 1)
            {
                cbHienThiBatDau.Text = "Select month";
                cbHienThiKeThuc.Text = "Select month";
                cbNam.Text = "Select year";
                xtraTabPage5.Text = "By month";
            }
            
            pnThangNam.Visible = true;
            pnThoiGian.Visible = false;
            cbHienThiKeThuc.Visible = true;
            cbNam.Visible = true;
            lbNam.Visible = true;
            lbDen.Visible = true;
            lbTu.Visible = true;
            cbNam.Properties.Items.Clear();
            cbHienThiBatDau.Properties.Items.Clear();
            cbHienThiKeThuc.Properties.Items.Clear();
            for (int i = 1; i < 13; i++)
            {
                cbHienThiBatDau.Properties.Items.Add(i.ToString());
                cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            }
            for (int i = 2005; i < DateTime.Now.Year + 1; i++)
            {
                cbNam.Properties.Items.Add(i.ToString());
            }
            sLoaiThoiGian = "";
            dateNgayBD = DateTime.Now.ToShortDateString();
            dateNgayKT = DateTime.Now.ToShortDateString();
            load();
            sLoaiThoiGian = "THANG";
        }
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
            pnThangNam.Visible = false;
            pnThoiGian.Visible = false;
            
        }
        private void loadVN()
        {
            iNgonNgu = 0;
            xtraTabPage5.Text = "Chọn Thông Kê Doanh Thu";

            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colTongDanhThu.Caption = resVietNam.colTongDanhThu.ToString();
            colKhucVuc.Caption = resVietNam.colTenKhuVuc.ToString();
            ColTenKhachHang.Caption = resVietNam.colKhachHang.ToString();
            colNgayXuat.Caption = resVietNam.colNgay.ToString();
            btXem.Text = resVietNam.btXem.ToString();
            btXuatDuLieu.Text = resVietNam.btXuat.ToString();
            btIn.Text = resVietNam.btIn.ToString();
            btDong.Text = resVietNam.btDong.ToString();
              linkTheoNam.Caption = resVietNam.linkTheoNam.ToString();
              linkTheoThang.Caption = resVietNam.linkTheoThang.ToString();
              linkTheoQui.Caption = resVietNam.linkTheoQui.ToString();
            linkTheoNgay.Caption = resVietNam.linkTheoNgay.ToString();
            navBarKhachHang.Caption = resVietNam.navBarKhachHang.ToString();
            dockChucNang.Text = resVietNam.nvaChucNang.ToString();
            lbTu.Text = resVietNam.NgayBD.ToString();
            lbDen.Text = resVietNam.NgayKT.ToString();
            lbtu1.Text = resVietNam.NgayBD.ToString();
            lbDen1.Text = resVietNam.NgayKT.ToString();
            lbNam.Text = resVietNam.lbNam.ToString();
        }
        public void loadEN()
        {
            iNgonNgu = 1;
            xtraTabPage5.Text = "Select sales statistics";

             CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colTongDanhThu.Caption = resEngLand.colTongDanhThu.ToString();
            colKhucVuc.Caption = resEngLand.colTenKhuVuc.ToString();
            ColTenKhachHang.Caption = resEngLand.colKhachHang.ToString();
            colNgayXuat.Caption = resEngLand.colNgay.ToString();
            btXem.Text = resEngLand.btXem.ToString();
            btXuatDuLieu.Text = resEngLand.btXuat.ToString();
            btIn.Text = resEngLand.btIn.ToString();
            btDong.Text = resEngLand.btDong.ToString();
            linkTheoNam.Caption = resEngLand.linkTheoNam.ToString();
            linkTheoThang.Caption = resEngLand.linkTheoThang.ToString();
            linkTheoQui.Caption = resEngLand.linkTheoQui.ToString();
            linkTheoNgay.Caption = resEngLand.linkTheoNgay.ToString();
            navBarKhachHang.Caption = resEngLand.navBarKhachHang.ToString();
            dockChucNang.Text = resEngLand.nvaChucNang.ToString();
            lbTu.Text = resEngLand.NgayBD.ToString();
            lbDen.Text = resEngLand.NgayKT.ToString();
            lbtu1.Text = resEngLand.NgayBD.ToString();
            lbDen1.Text = resEngLand.NgayKT.ToString();
            lbNam.Text = resEngLand.lbNam.ToString();
          

            
        }
        private void linkTheoNam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (iNgonNgu==0)
            {
                cbHienThiBatDau.Text = "Chọn năm";
                cbHienThiKeThuc.Text = "Chọn năm";
                xtraTabPage5.Text = "Doanh thu theo năm";
            }
            if (iNgonNgu == 1)
            {
                cbHienThiBatDau.Text = "Select year";
                cbHienThiKeThuc.Text = "Select year";
                xtraTabPage5.Text = "By year";
            }
            cbNam.Visible = false;
            lbNam.Visible = false;
            lbTu.Visible = true;
            pnThangNam.Visible = true;
            pnThoiGian.Visible = false;
            cbHienThiKeThuc.Visible = true;
            lbDen.Visible = true;
            cbHienThiBatDau.Properties.Items.Clear();
            cbHienThiKeThuc.Properties.Items.Clear();
            
            for (int i = 2005; i < DateTime.Now.Year + 1; i++)
            {
                cbHienThiBatDau.Properties.Items.Add(i.ToString());
                cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            }
            sLoaiThoiGian = "";
            dateNgayBD = DateTime.Now.ToShortDateString();
            dateNgayKT = DateTime.Now.ToShortDateString();
            load();
            sLoaiThoiGian = "NAM";
        }

    

        void linkTheoKhuVuc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (iNgonNgu==0)
            {
                dateBD.Text = "Chọn ngày";
                dateKetThuc.Text = "Chọn ngày";
                xtraTabPage5.Text = "Doanh thu theo Ngày";
            }
            if (iNgonNgu == 1)
            {
                dateBD.Text = "Select date";
                dateKetThuc.Text = "Select date";
                xtraTabPage5.Text = "By date";
            }
            
            
            pnThoiGian.Visible = true;
            pnThangNam.Visible = false;
            sLoaiThoiGian = "";
            dateNgayBD = DateTime.Now.ToShortDateString() ;
            dateNgayKT = DateTime.Now.ToShortDateString() ;
            load();
            sLoaiThoiGian = "NGAY";
        }

        public void load()
        {
            dto.NGAYBD = dateNgayBD;
            dto.NGAYKT = dateNgayKT;
            dto.LOAITG = sLoaiThoiGian;
            gridControl6.MainView = gridView1;
            gridControl6.DataSource = ctr.getDoanhThu(dto);
            //tb = ctr.getDoanhThu(dto);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (iNgonNgu==0)
            {
                cbHienThiBatDau.Text = "Chọn quí";
                cbHienThiKeThuc.Text = "Chọn năm";
                xtraTabPage5.Text = "Doanh thu theo quí";
            }
            if (iNgonNgu==1)
            {

                cbHienThiBatDau.Text = "Select Quarterly";
                cbHienThiKeThuc.Text = "Select year";
                xtraTabPage5.Text = "By Quarterly";
            }
           
            sTheHien = "thoigian";
            pnThangNam.Visible = true;
            pnThoiGian.Visible = false;
            cbHienThiKeThuc.Visible = true;
            lbNam.Visible = false;
            cbNam.Visible = false;
            lbDen.Visible = false;
            lbTu.Visible = false;
            cbHienThiBatDau.Properties.Items.Clear();
            cbHienThiKeThuc.Properties.Items.Clear();
            if (DateTime.Now.Month > 4)
            {
                for (int i = 1; i <= (12 / 3) ; i++)
                {
                    cbHienThiBatDau.Properties.Items.Add(i.ToString());
                }
            }
            for (int i = 2005; i < DateTime.Now.Year + 1; i++)
            {
                cbHienThiKeThuc.Properties.Items.Add(i.ToString());
            }
            sLoaiThoiGian = "";
            dateNgayBD = DateTime.Now.ToString("yyy/MM/dd");
            dateNgayKT = DateTime.Now.ToString("yyy/MM/dd");
            load();
            sLoaiThoiGian = "QUI";
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEN);
             vLucLoad();
             if (iNgonNgu==0)
             {
                 loadVN();
             }
             if (iNgonNgu==1)
             {
                 loadEN();
             }
             
        }
        
       
        
        private void simpleButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (sLoaiThoiGian == "THANG")
                {

                    dateNgayBD = cbNam.Text + "/" + cbHienThiBatDau.Text + "/01";
                    dateNgayKT = cbNam.Text + "/" + cbHienThiKeThuc.Text + "/01";
                    load();
                    return;
                }
                if (sLoaiThoiGian == "NGAY")
                {
                    string NGAYBD = dateBD.Text;
                    NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
                    dateNgayBD = NGAYBD;

                    string NGAYKT = dateKetThuc.Text;
                    NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
                    dateNgayKT = NGAYKT;

                    
                    
                    load();
                    return;
                }
                if (sLoaiThoiGian == "NAM")
                {
                    dateNgayBD = cbHienThiBatDau.Text + "/01/01";
                    dateNgayKT = cbHienThiKeThuc.Text + "/01/01";
                    load();
                    return;
                }
                if (sLoaiThoiGian == "QUI")
                {
                    switch (cbHienThiBatDau.Text.Trim())
                    {
                        case "1":
                            dateNgayBD = (cbHienThiKeThuc.Text + "/01/01");
                            dateNgayKT = (cbHienThiKeThuc.Text+ "/03/31");
                            break;
                        case "2":
                            dateNgayBD = (cbHienThiKeThuc.Text + "/04/01" );
                            dateNgayKT = (cbHienThiKeThuc.Text + "/06/30" );
                            break;
                        case "3":
                            dateNgayBD = (cbHienThiKeThuc.Text + "/07/01" );
                            dateNgayKT = (cbHienThiKeThuc.Text + "/90/30" );
                            break;

                        default:
                            dateNgayBD = (cbHienThiKeThuc.Text + "/10/01" );
                            dateNgayKT = (cbHienThiKeThuc.Text + "/12/31" );
                            break;
                    }
                    load();
                    return;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui long chon thong tin");
            }
           
        }

        private void btXuatDuLieu_Click(object sender, EventArgs e)
        {
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
            if (gridView1.RowCount > 0)
            {
                reportBaoCaoDoanhThu rep = new reportBaoCaoDoanhThu(tb, iNgonNgu);
                rep.ShowPreviewDialog();
            }
            else
            {
                XtraMessageBox.Show("Dữ liệu không có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btxuatexcel_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl6_Click(object sender, EventArgs e)
        {

        }

        private void dateBD_EditValueChanged(object sender, EventArgs e)
        {

        }

      
        
    }
}