using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmCongNoNcc : DevExpress.XtraEditors.XtraForm
    {
        public frmCongNoNcc()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public string smaNcc,STENNCC,STYPE;
        public string sTienno;
        public string sMahdn;
        public string smpc;
        public string smahdn;
        public string stientra;
        public string sMaNV, sTenNV;
        Ctrl_Tien CTR = new Ctrl_Tien();
        public void loadGetAllHDN()
        {
          
            //dt = CTR.GETALLHDn_ctrl();
            dt = CTR.GETALLcongno_ncc();
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridcongno;
        }
        public void loadGetAllphieuchi()
        {
            string NGAYBD = dateTu1.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string NGAYKT = dateDen1.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);

            //dt = CTR.GETALLHDn_ctrl();
            dt = CTR.Getall_phieuchi_Dao( NGAYBD,  NGAYKT);
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridphieuchi;
        }
        public void loadGetAllhoadon()
        {
            string NGAYBD = dateTu1.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string NGAYKT = dateDen1.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);

            //dt = CTR.GETALLHDn_ctrl();
            dt = CTR.Getall_hoadon_Dao(NGAYBD, NGAYKT);
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridhoadon;
        }
        public void loadctncc()
        {
            dt = CTR.get1pthdn_ctrl(sMahdn);
            gridControl1.DataSource = dt;
        }
         public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
      
        private void frmCongNoNcc_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEL);
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();

            dateDen1.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu1.Text = "01/" + DateTime.Now.ToString("MM/yyy");
            dateDen.Text = DateTime.Now.ToString("dd/MM/yyy");
            dateTu.Text = "01/" + DateTime.Now.ToString("MM/yyy");
            loadGetAllHDN();
            load_congno();
        }
        public void load_congno()
        {
            panel_congno.Visible = true;
            panel_phieuchi.Visible = false;
            panelhoadon.Visible = false;
            gridcongno.ExpandAllGroups();
        }

        public void load_phieuchi()
        {
            panel_congno.Visible = false;
            panel_phieuchi.Visible = true;
            panelhoadon.Visible = false;
            gridphieuchi.ExpandAllGroups();
        }
        public void load_hoadon()
        {
            panel_congno.Visible = false;
            panel_phieuchi.Visible = false;
            panelhoadon.Visible = true;
            gridhoadon.ExpandAllGroups();
            if (ISHANGHOA)
            {
                Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
                cbncc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
                cbncc.Properties.DisplayMember = "TENNCC";
                cbncc.Properties.ValueMember = "MANCC";
                cbncc.Properties.View.BestFitColumns();
                cbncc.Properties.PopupFormWidth = 300;
                cbncc.Properties.DataSource = ctr1.dtGetNCC();
            }
        }
       
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
                if (hitInfo.RowHandle>=0)
                {
                    DataRow dtr = gridcongno.GetDataRow(hitInfo.RowHandle);
                    sMahdn = dtr["MAHDN"].ToString();
                    smaNcc = dtr["MANCC"].ToString();
                    sTienno = dtr["CONLAI"].ToString();
                    loadfrm_tratien();
                }
        }

        
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                DataRow dtr = gridcongno.GetDataRow(e.RowHandle);
                sMahdn = dtr["MAHDN"].ToString();
                smaNcc = dtr["MANCC"].ToString();
                sTienno = dtr["CONLAI"].ToString();

            }
            catch
            {
                //XtraMessageBox.Show(ex.Message);

            }
            
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barTraTien.Caption = Tien_VN.barTraTien.ToString();
            barSuaTien.Caption = Tien_VN.barSuaTien.ToString();
            
            //colTênnhânviên.Caption = Tien_VN.colTênnhanvien.ToString();

            barBtDong.Caption = Tien_VN.barstDong.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barTraTien.Caption = Tien_EL.barTraTien.ToString();
            barSuaTien.Caption = Tien_EL.barSuaTien.ToString();
            //colTênnhânviên.Caption = Tien_EL.colTênnhanvien.ToString();

            barBtDong.Caption = Tien_EL.barstDong.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btTratien_Click(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            loadfrm_tratien();
        }
        public void loadsua_phieuTHU()
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            FrmThuTienncc frm = new FrmThuTienncc();
            if (this.smpc == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu thu để sửa lại số tiền vừa trả");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("You must select a bill to update paid money!!!");
                    return;
                }

            }
            else
            {
                string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYTHU FROM PHIEUTHU WHERE MAPT='" + smpc + "')>(SELECT NGAY FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5) AS NGAY,(SELECT TINHTRANG  FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5) AS TINHTRANG,(SELECT ISEDITTODAY FROM BOPHAN WHERE MABP=(SELECT MABP FROM NHANVIEN WHERE MANV='" + sMaNV + "')) AS ISEDITTODAY,(SELECT CONVERT(VARCHAR,GETDATE(),103)) AS HOMNAY,(SELECT CONVERT(VARCHAR,NGAYTHU,103) FROM PHIEUTHU WHERE MAPT='" + smpc + "') AS NGAYHD";
                CTL ctlKHOA = new CTL();
                DataTable DTKHOA = ctlKHOA.GETDATA(SQLKHOA);
                if (DTKHOA.Rows[0]["ISEDITTODAY"].ToString() == "True")
                {
                    string TODAY = DateTime.Now.ToString("dd/MM/yyyy");
                    if (DTKHOA.Rows[0]["NGAYHD"].ToString() != DTKHOA.Rows[0]["HOMNAY"].ToString())
                    {
                        MessageBox.Show("KHÔNG PHẢI HÓA ĐƠN HÔM NAY NÊN BẠN KHÔNG THỂ CHỈNH SỬA");
                        return;
                    }

                }
                else
                {
                    if (DTKHOA.Rows[0][0].ToString() == "1" && DTKHOA.Rows[0]["TINHTRANG"].ToString() == "True")
                    {
                        MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                        return;
                    }
                }
                frm.Nhan = "Sua";
                frm.MaPT = smpc;
                frm.Mancc = smaNcc;
                frm.TENNCC = STENNCC;
                frm.TIEN = stientra;
                frm.sMaNV = sMaNV;

                frm.Tienno = "0";
                frm.iNgonNgu = this.iNgonNgu;

                frm.sTenNV = sTenNV;
                frm.ShowDialog();
                loadGetAllphieuchi();
                load_phieuchi();
            }
        }
        public void loadsua_phieuchi()
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frmTraTien frm = new frmTraTien();
            if (this.smpc == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu chi để sửa tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");
            }
            else
            {
                string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYCHI FROM PHIEUCHI WHERE MAPC='" + smpc + "')>(SELECT NGAY FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5) AS NGAY,(SELECT TINHTRANG  FROM KHOASOTHEOKHO WHERE MAKHO='" + PublicVariable.MAKHO + "' AND ID=5) AS TINHTRANG,(SELECT ISEDITTODAY FROM BOPHAN WHERE MABP=(SELECT MABP FROM NHANVIEN WHERE MANV='" + sMaNV + "')) AS ISEDITTODAY,(SELECT CONVERT(VARCHAR,GETDATE(),103)) AS HOMNAY,(SELECT CONVERT(VARCHAR,NGAYCHI,103) FROM PHIEUCHI WHERE MAPC='" + smpc + "') AS NGAYHD";
                CTL ctlKHOA = new CTL();
                DataTable DTKHOA = ctlKHOA.GETDATA(SQLKHOA);
                if (DTKHOA.Rows[0]["ISEDITTODAY"].ToString() == "True")
                {
                    string TODAY = DateTime.Now.ToString("dd/MM/yyyy");
                    if (DTKHOA.Rows[0]["NGAYHD"].ToString() != DTKHOA.Rows[0]["HOMNAY"].ToString())
                    {
                        MessageBox.Show("KHÔNG PHẢI HÓA ĐƠN HÔM NAY NÊN BẠN KHÔNG THỂ CHỈNH SỬA");
                        return;
                    }

                }
                else
                {
                    if (DTKHOA.Rows[0][0].ToString() == "1" && DTKHOA.Rows[0]["TINHTRANG"].ToString() == "True")
                    {
                        MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                        return;
                    }
                }

                frm.Nhan = "Sua";
                frm.MaPC = smpc;
                frm.MaNcc = smaNcc;
                frm.TENNCC = STENNCC;
                frm.TIEN = stientra;
                frm.sMaNV = sMaNV;

                frm.Tienno = CTR.GETcongno_NCC(smaNcc);
                frm.sTenNV = sTenNV;


                frm.iNgonNgu = this.iNgonNgu;
                frm.ShowDialog();
                loadGetAllphieuchi();
                load_phieuchi();
                //loadctncc();
            }
        }
        public void loadfrm_thutien()
        {
            FrmThuTienncc frm = new FrmThuTienncc();
            if (this.smaNcc == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 hóa đơn để thu tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");

                return;
            }
            else
            {
                frm.Nhan = "Them";
                frm.Type = "2";
                frm.TENNCC = STENNCC;
                frm.Tienno = "0";
                frm.iNgonNgu = this.iNgonNgu;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;
                frm.Mancc = smaNcc;

                frm.ShowDialog();
                loadGetAllHDN();
                load_congno();
            }
        }
        public void loadfrm_tratien()
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmTraTien frm = new frmTraTien();
            if (this.smaNcc == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 hóa đơn để thu tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");
                return;
            }
            else
            {
                frm.Nhan = "Them";
                frm.Type = "1";
                frm.TENNCC = STENNCC;
                frm.MaNcc = smaNcc;
                frm.Tienno = sTienno;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;

                frm.iNgonNgu = this.iNgonNgu;
                frm.ShowDialog();
                //loadctncc();
                loadGetAllHDN();
                load_congno();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dtr1 = gridphieuchi.GetDataRow(e.RowHandle);
                smpc = dtr1["MAPC"].ToString();
               // smaNcc = dtr1["MANCC"].ToString();
                smahdn = dtr1["MAHDN"].ToString();
                stientra = dtr1["TIENDATRA"].ToString();
            }
            catch
            {
                //XtraMessageBox.Show(ex.Message);

            }
        }
        private void bt_edittratien_Click(object sender, EventArgs e)
        {
            if (STYPE != null)
            {
                if (STYPE == "PC")
                {
                    loadsua_phieuchi();
                }
                else
                {
                    loadsua_phieuTHU();
                }
            }
        }
        Boolean ISHANGHOA = false;
        private void linkcongno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ISHANGHOA = false;
            CBKH_MANCC = "";
            loadGetAllHDN();
            load_congno();
        }

        private void linkphieuchi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Int64 ingaybd = Convert.ToInt64(dateTu1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu1.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen1.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }
            ISHANGHOA = false;
            CBKH_MANCC = "";
            loadGetAllphieuchi();
            load_phieuchi();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           // gridControl1.ShowPrintPreview();
            //printableComponentLink1.CreateDocument();
            //printableComponentLink1.ShowPreview();
            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 14);
            rep.ShowPreviewDialog();
        }

        private void btXuat_Click(object sender, EventArgs e)
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
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 15);
            rep.ShowPreviewDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
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
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }

        }

        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllHDN();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllHDN();
            }
        }

        private void dateTu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllphieuchi();
            }
        }

        private void dateDen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllphieuchi();
            }
        }

        private void printableComponentLink1_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Công Nợ Công TY Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink2_CreateReportFooterArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink2_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {

            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Trả Nợ Công Ty Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Int64 ingaybd = Convert.ToInt64(dateTu1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu1.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen1.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

                loadGetAllphieuchi();
   
            load_phieuchi();
        }

        private void linkhoadon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Int64 ingaybd = Convert.ToInt64(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

            loadGetAllhoadon();
            ISHANGHOA = false;
            CBKH_MANCC = "";
            load_hoadon();
        }

        private void gridcongno_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle>=0)
            {
                DataRow dtr = gridcongno.GetDataRow(hitInfo.RowHandle);
                STENNCC = dtr["TENNCC"].ToString();
                smaNcc = dtr["MANCC"].ToString();
                sTienno = dtr["CONGNO"].ToString();
                loadfrm_tratien();
            }
        }

        private void gridphieuchi_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle>=0)
            {
                if (STYPE != null)
                {
                    if (STYPE == "PC")
                    {
                        loadsua_phieuchi();
                    }
                    else
                    {
                        loadsua_phieuTHU();
                    }
                }
            }

            
            
        }

        private void gridcongno_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle>=0)
            {
                DataRow dtr = gridcongno.GetDataRow(hitInfo.RowHandle);
                STENNCC = dtr["TENNCC"].ToString();
                smaNcc = dtr["MANCC"].ToString();
                sTienno = dtr["CONGNO"].ToString();
            }
        }

        private void gridphieuchi_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.RowHandle>=0)
            {
                DataRow dtr = gridphieuchi.GetDataRow(hitInfo.RowHandle);
                smpc = dtr["MAPC"].ToString();
                STENNCC = dtr["TENNCC"].ToString();
                smaNcc = dtr["MANCC"].ToString();
                stientra = dtr["SOTIEN"].ToString();
                STYPE = dtr["TYPE"].ToString();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn Nhận Tiền Từ Nhà Cung Cấp để Tăng Công Nợ NCC?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loadfrm_thutien();
            }
        }

        private void simpleButton8_Click_1(object sender, EventArgs e)
        {
            Int64 ingaybd = Convert.ToInt64(dateTu1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu1.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen1.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen1.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }
            loadGetAllhoadon();

            load_hoadon();
        }

        private void simpleButton8_Click_2(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            Int64 ingaybd = Convert.ToInt64(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

            

            load_hoadon();
            if (ISHANGHOA)
            {
                loadGetAllMATHANG();
            }
            else
            {
                loadGetAllhoadon();
            }
        }

        private void simpleButton9_Click_1(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 22);
            rep.ShowPreviewDialog();
        }

        private void simpleButton10_Click_1(object sender, EventArgs e)
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
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }
        }

        private void simpleButton11_Click_1(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void frmCongNoNcc_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void panelhoadon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Int64 ingaybd = Convert.ToInt64(dateTu.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateTu.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateTu.Text.Substring(0, 2));
            Int64 ingaykt = Convert.ToInt64(dateDen.Text.Substring(6, 4)) * 365 + Convert.ToInt64(dateDen.Text.Substring(3, 2)) * 31 + Convert.ToInt64(dateDen.Text.Substring(0, 2));
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }
            ISHANGHOA = true;
            CBKH_MANCC = "";
            load_hoadon();
            
            loadGetAllMATHANG();
        }

        public void loadGetAllMATHANG()
        {

            string NGAYBD = dateTu1.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string NGAYKT = dateDen1.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            string MANCC = "";
            dt = null;
            //dt = CTR.GETALLHDn_ctrl();
            if (CBKH_MANCC != "")
            {
                dt = CTR.Getall_MATHANGNCC(NGAYBD, NGAYKT, CBKH_MANCC);
            }
            gridControl1.DataSource = dt;
            gridControl1.MainView = MATHANG;
            if (!PublicVariable.isKHOILUONG)
            {
                MATHANG.Columns["KHOILUONG"].Visible = false;
            }
            MATHANG.ExpandAllGroups();
        }
        string CBKH_MANCC = "";
        

        private void cbncc_Validated(object sender, EventArgs e)
        {
            CBKH_MANCC = gridncc.GetFocusedRowCellValue("MANCC").ToString();
        }
    }
}