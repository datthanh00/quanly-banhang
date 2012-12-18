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
          
            dockChucNang.Text = resVietNam.nvaChucNang.ToString();
            lbTu.Text = resVietNam.NgayBD.ToString();
            lbDen.Text = resVietNam.NgayKT.ToString();

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
            dockChucNang.Text = resEngLand.nvaChucNang.ToString();
            lbTu.Text = resEngLand.NgayBD.ToString();
            lbDen.Text = resEngLand.NgayKT.ToString(); 
        }

        public void load_cbthoigian()
        {
            cbThoiGian.Properties.Items.Add("Hôm nay");
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
                        dateDen.Text = DateTime.Now.ToString("yyy/MM/dd");
                        dateTu.Text = DateTime.Now.ToString("yyy/MM/dd");

                        break;
                    }
                case 1:
                    {
                        dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 2:
                    {
                        dateDen.Text = "31/01/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/01/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 3:
                    {
                        dateDen.Text = "28/02/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/02/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 4:
                    {
                        dateDen.Text = "31/03/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/03/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 5:
                    {
                        dateDen.Text = "30/04/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/04/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 6:
                    {
                        dateDen.Text = "31/05/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/05/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 7:
                    {
                        dateDen.Text = "30/06/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/06/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 8:
                    {
                        dateDen.Text = "31/07/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/07/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 9:
                    {
                        dateDen.Text = "31/08/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/08/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 10:
                    {
                        dateDen.Text = "30/09/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/09/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 11:
                    {
                        dateDen.Text = "31/10/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/10/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 12:
                    {
                        dateDen.Text = "30/11/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/11/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 13:
                    {
                        dateDen.Text = "31/12/" + DateTime.Now.Year.ToString();
                        dateTu.Text = "01/12/" + DateTime.Now.Year.ToString();
                        break;
                    }
                case 14:
                    {

                        dateDen.Text = DateTime.Now.ToString("yyy/MM/dd");

                        dateTu.Text = DateTime.Now.ToString("yyy/MM/dd");

                        break;
                    }

            }

        }

        public void load()
        {
            dto.NGAYBD = dateNgayBD;
            dto.NGAYKT = dateNgayKT;

            gridControl6.MainView = gridView1;
            gridControl6.DataSource = ctr.getDoanhThu(dto);
            //tb = ctr.getDoanhThu(dto);
        }

   
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
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
             
        }
        
       
        
        private void simpleButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string NGAYBD = dateTu.Text;
                NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
                dateNgayBD = NGAYBD;

                string NGAYKT = dateDen.Text;
                NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
                dateNgayKT = NGAYKT;

                
                load();
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

        private void cbThoiGian_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadNgay();
        }



      
        
    }
}