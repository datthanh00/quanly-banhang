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
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace WindowsFormsApplication1
{
    public partial class frmhangtondau : DevExpress.XtraEditors.XtraForm
    {
        public frmhangtondau()
        {
            InitializeComponent();
        }
        
   
        string LoaiTG = "";
        string LoaiHT = "";
       
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();

        
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void frmThongKeTongHop_Load(object sender, EventArgs e)
        {

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(loadcbVietNam);
            ////frm.LoadVI += new frmMain.Translate(loadGird);
            
            frm.LoadEN += new frmMain.Translate(loadcbEgLish);
            //frm.LoadEN += new frmMain.Translate(loadReSEG);

            if (iNgonNgu == 0)
            {
                loadReSVN1();
                loadcbVietNam();
            }
            else
            {
                loadReSEG1();
                loadcbEgLish();
            } 
            vload();
        
            loadngonngu();
         
            if (!PublicVariable.isKHOILUONG)
            {
                gridView1.Columns["KHOILUONG"].Visible = false;
            }

            if (!PublicVariable.isTONTHUCTE)
            {
                gridView1.Columns["LOHANG"].Visible = false;
                gridView1.Columns["HSD"].Visible = false;
            }

            Load_mathang();
        }

        private void loadReSVN1()
        {
            
            btin.Text = resVietNam.btIn.ToString();
            BtXuatdulieu.Text = resVietNam.btXuat.ToString();
            btdong.Text = resVietNam.btDong.ToString();
           
        }

        private void loadReSEG1()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
           btin.Text = resEngLand.btIn.ToString();
           BtXuatdulieu.Text = resEngLand.btXuat.ToString();
           btdong.Text = resEngLand.btDong.ToString();
        }
     


        private void loadngonngu()
        {
            if (iNgonNgu == 0)
            {
                loadcbVietNam();

            }
            else
            {
                loadcbEgLish();
                loadgirdenglish();

            }
        }

        private void loadgirdenglish()
        {

           
        }


        public void loadcbEgLish()
        {
            

        }
        public void loadcbVietNam()
        {
           
        }
  
        public void load()
        {
            //dto.NGAY_BD = DateTime.Parse(dateNgayBD);
            //dto.NGAY_KT = DateTime.Parse(dateNgayKT);
            dto.Loai_TG = LoaiTG;
            dto.Loai_HT = LoaiHT;

        }



        private void vload()
        {
            if (iNgonNgu == 0)
            {
                xtraTabPage3.Text = "Chọn Loại Thống Kê Mặt Hàng";
            }
            else
            {
                xtraTabPage3.Text = "STATISTICAL ITEMS REPORT";
            }
        }




        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (SMAMH == "" || SMAMH==null)
            {
                MessageBox.Show("VUI LÒNG CHỌN MẶT HÀNG CẦN SỬA ");
                return;
            }
            try
            {

                Themlohangtondau sua = new Themlohangtondau();
                sua.iNgonNgu = iNgonNgu; sua.kiemtra = 0;
                sua.SMAMH = SMAMH;
                sua.SLOHANG = SLOHANG;
                sua.SHSD = SHSD;
                sua.SSOLUONG = SSOLUONG;
                sua.SGIAMUA = SGIAMUA;
                sua.ShowDialog();
                Load_mathang();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
         }



        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
        private void Load_mathang()
        {

            gridControl1.DataSource = ctr.getondauky_mathang();
        }
        

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 16);
            rep.ShowPreviewDialog();
        }


        private void cbHienThiBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void BtXuatdulieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls";
                saveFileDialog1.Title = "Save an File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    gridControl1.ExportToXls(saveFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                DevComponents.DotNetBar.MessageBoxEx.Show("Đã Tồn Tại Tên");
            }

        }


        private void cmbloaihienthi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Báo Cáo Tồn Phân Lô Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;

                contextMenuStrip1.Show(view.GridControl, e.Point);
            }
        }

        private void xoalohangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XÓA ");
                return;
            }

            if (XtraMessageBox.Show("Bạn Có Muốn Xóa Lô Hàng Này Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridView1.FocusedRowHandle;
                DataRow dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dtr != null)
                {
                    String sMAMH = dtr["MAMH"].ToString();
                    String sLOHANG = dtr["LOHANG"].ToString();
                    if (sMAMH != "")
                    {
                       ctr.DELETE_LOHANGTONDAU(sMAMH, sLOHANG);
                    }
                }
            }
            Load_mathang();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            Themlohangtondau frm = new Themlohangtondau();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
            Load_mathang();
        }

        private void cbncc_Validated(object sender, EventArgs e)
        {
            Load_mathang();
        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                if (PublicVariable.SUA == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN");
                    return;
                }
                try
                {
                    Themlohangtondau sua = new Themlohangtondau();
                    sua.iNgonNgu = iNgonNgu; sua.kiemtra = 0;
                    sua.SMAMH = SMAMH;
                    sua.SLOHANG = SLOHANG;
                    sua.SHSD = SHSD;
                    sua.SSOLUONG = SSOLUONG;
                    sua.SGIAMUA = SGIAMUA;
                    sua.ShowDialog();
                    Load_mathang();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
        string SMAMH,SLOHANG,SHSD,SSOLUONG,SGIAMUA;
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                try
                {
                    DataTable dt = new DataTable();
                    DataRow dtr = gridView1.GetDataRow(e.RowHandle);
                    SMAMH = dtr["MAMH"].ToString();

                    SLOHANG = dtr["LOHANG"].ToString();

                    SHSD = dtr["HSD"].ToString();

                    SSOLUONG = dtr["SOLUONG"].ToString();
                    SGIAMUA = dtr["GIAMUA"].ToString();

                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.Message);
                }
            }
        }




    }
}
        
       
    
