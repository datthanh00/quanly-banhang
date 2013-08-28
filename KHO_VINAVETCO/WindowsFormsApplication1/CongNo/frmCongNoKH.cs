﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;

namespace WindowsFormsApplication1
{
    public partial class frmCongNoKH : DevExpress.XtraEditors.XtraForm
    {
        public frmCongNoKH()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public int iNgonNgu;
        Ctrl_Tien CTR = new Ctrl_Tien();
        public void loadGetAll_CONGNO()
        {
            dt = CTR.GETALLcongno_kh();
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridcongnokh;
        }
        public void loadGetAllPHIEUTHU()
        {
            string NGAYBD = dateTu1.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string NGAYKT = dateDen1.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);

            dt = CTR.GETALLPHIEUTHU_ctrl(NGAYBD, NGAYKT);
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridphieuthu;
        }
        public void loadGetAllHOADON()
        {
            string NGAYBD = dateTu1.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string NGAYKT = dateDen1.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);

            dt = CTR.GETALLHOADON_ctrl(NGAYBD, NGAYKT);
            gridControl1.DataSource = dt;
            gridControl1.MainView = gridhoadon;
        }
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
      
        private void frmCongNoKH_Load(object sender, EventArgs e)
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

            loadGetAll_CONGNO();
            load_congno();


        }
        public string smaKH,stenkh;
        public string scongno;
        public string sMahdx;
        public string smpt;
        public string smahdx;
        public string stientra;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                
                DataRow dtr = gridcongnokh.GetDataRow(e.RowHandle);
                sMahdx = dtr["MAHDX"].ToString();
                smaKH = dtr["MAKH"].ToString();
                scongno = dtr["CONLAI"].ToString();
                //dt = CTR.get1pthdx_ctrl(dtr[0].ToString());
                //gridControl2.DataSource = dt;
            }
            catch 
            {

               // MessageBox.Show(ex.Message);
            }
        }
        public string sMaNV, sTenNV;

        public void load_congno()
        {
            
        

            panel_congno.Visible = true;
            panel_phieuchi.Visible = false;

      
            groupControl_congno.Dock = System.Windows.Forms.DockStyle.Fill;

            gridcongnokh.ExpandAllGroups();
        }
        public void load_phieuthu()
        {
            panel_congno.Visible = false;
            panel_phieuchi.Visible = true;
         
        }
        private void btThutien_Click(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            loadfrm_thutien();
        }
        public void loadfrm_thutien()
        {
            FrmThuTien frm = new FrmThuTien();
            if (this.smaKH == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 hóa đơn để thu tiền");
                }
                else
                    XtraMessageBox.Show("You must select a bill to get money");

            }
            else
            {
                frm.Nhan = "Them";
                frm.TENKH = stenkh;
                frm.Tienno = scongno;
                frm.iNgonNgu = this.iNgonNgu;
                frm.sMaNV = sMaNV;
                frm.sTenNV = sTenNV;
                frm.MaKH = smaKH;
             
                frm.ShowDialog();
                loadGetAll_CONGNO();
                //loadctkh();
                load_congno();
            }
        }
        private void btneditthutien_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            FrmThuTien frm = new FrmThuTien();
            if (this.smpt == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu thu để sửa lại số tiền vừa trả");
                }
                else
                    XtraMessageBox.Show("You must select a bill to update paid money!!!");

            }
            else
            {
                string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYTHU FROM PHIEUTHU WHERE MAPT='" + smpt + "')>(SELECT NGAY FROM KHOASO WHERE ID=6)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASO WHERE ID=6) AS NGAY";
                CTL ctlKHOA = new CTL();
                DataTable DTKHOA = ctlKHOA.GETDATA(SQLKHOA);
                if (DTKHOA.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                    return;
                }
                frm.Nhan = "Sua";
                frm.MaPT = smpt;
                frm.HD = smahdx;
                frm.TIEN = stientra;
                frm.sMaNV = sMaNV;

                frm.Tienno = CTR.GETcongno_HDX(smahdx);
                frm.iNgonNgu = this.iNgonNgu;
                
                frm.sTenNV = sTenNV;
                frm.ShowDialog();
                loadGetAllPHIEUTHU();
                //loadctkh();
                load_phieuthu();
            }
        }
 

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                DataRow dtr = gridcongnokh.GetDataRow(hitInfo.RowHandle);
                smaKH = dtr["MAKH"].ToString();
                stenkh = dtr["TENKH"].ToString();
                scongno = dtr["CONGNO"].ToString();
                loadfrm_thutien();
            }
        }
        public void loadctkh()
        {
            //DataTable dt = new DataTable();
            dt = CTR.get1pthdx_ctrl(sMahdx);
           // gridControl2.DataSource = dt;
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barThuTien.Caption = Tien_VN.barThuTien.ToString();
            barSuaTien.Caption = Tien_VN.barSuaTien.ToString();
        
            colTenkhachhang.Caption = Tien_VN.colTênkháchhàng.ToString();
            
            barBtDong.Caption = Tien_VN.barstDong.ToString();
            colMakhachhang.Caption = Tien_VN.colMãkháchhàng.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barThuTien.Caption = Tien_EL.barThuTien.ToString();
            barSuaTien.Caption = Tien_EL.barSuaTien.ToString();
       
            colTenkhachhang.Caption = Tien_EL.colTênkháchhàng.ToString();

            colcongno.Caption = Tien_EL.colCònlại.ToString();
            
        
            barBtDong.Caption = Tien_EL.barstDong.ToString();
            colMakhachhang.Caption = Tien_EL.colMãkháchhàng.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void linkcongno_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            loadGetAll_CONGNO();
            load_congno();
        }

        private void linkphieuthu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int ingaybd = Convert.ToInt32(dateTu1.Text.Substring(6, 4)) + Convert.ToInt32(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu1.Text.Substring(0, 2)) * 365;
            int ingaykt = Convert.ToInt32(dateDen1.Text.Substring(6, 4)) + Convert.ToInt32(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen1.Text.Substring(0, 2)) * 365;
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

            loadGetAllPHIEUTHU();
            load_phieuthu();
        }

        private void btndelthutien_Click(object sender, EventArgs e)
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
            //gridControl1.ShowPrintPreview();
            //printableComponentLink1.CreateDocument();
           // printableComponentLink1.ShowPreview();
            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 12);
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
            //gridControl2.ShowPrintPreview();
            // printableComponentLink2.CreateDocument();
             //printableComponentLink2.ShowPreview();
             DataTable printtable = (DataTable)gridControl1.DataSource;
             Inhd rep = new Inhd(printtable, 13);
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
                loadGetAll_CONGNO();
            }
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAll_CONGNO();
            }
        }

        private void dateTu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllPHIEUTHU();
            }
        }

        private void dateDen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadGetAllPHIEUTHU();
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
            string reportHeader = "Công nợ khách hàng Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink2_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink2_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Thu Tiền khách Hàng Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int ingaybd = Convert.ToInt32(dateTu1.Text.Substring(6, 4)) + Convert.ToInt32(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu1.Text.Substring(0, 2)) * 365;
            int ingaykt = Convert.ToInt32(dateDen1.Text.Substring(6, 4)) + Convert.ToInt32(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen1.Text.Substring(0, 2)) * 365;
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }

            loadGetAllHOADON();
            load_phieuthu();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int ingaybd = Convert.ToInt32(dateTu1.Text.Substring(6, 4)) + Convert.ToInt32(dateTu1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateTu1.Text.Substring(0, 2)) * 365;
            int ingaykt = Convert.ToInt32(dateDen1.Text.Substring(6, 4)) + Convert.ToInt32(dateDen1.Text.Substring(3, 2)) * 31 + Convert.ToInt32(dateDen1.Text.Substring(0, 2)) * 365;
            if (ingaybd > ingaykt)
            {
                MessageBox.Show("ngày kết thúc phải nhỏ hơn ngày bắt đầu");
                return;
            }
            if (gridControl1.MainView == gridhoadon)
            {
                loadGetAllHOADON();
            }
            else
            {
                loadGetAllPHIEUTHU();
            }
            load_phieuthu();
        }



        private void gridphieuthu_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            FrmThuTien frm = new FrmThuTien();
            if (this.smpt == null)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn 1 phiếu thu để sửa lại số tiền vừa trả");
                }
                else
                    XtraMessageBox.Show("You must select a bill to update paid money!!!");

            }
            else
            {
                string SQLKHOA = "SELECT CASE WHEN (SELECT NGAYTHU FROM PHIEUTHU WHERE MAPT='" + smpt + "')>(SELECT NGAY FROM KHOASO WHERE ID=6)  THEN 0 ELSE 1 END, (SELECT CONVERT(VARCHAR,NGAY,103)  FROM KHOASO WHERE ID=6) AS NGAY";
                CTL ctlKHOA = new CTL();
                DataTable DTKHOA = ctlKHOA.GETDATA(SQLKHOA);
                if (DTKHOA.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("HỆ THỐNG ĐÃ KHÓA SỔ ĐẾN NGÀY: " + DTKHOA.Rows[0]["NGAY"].ToString() + " NÊN BẠN KHÔNG THỂ CHỈNH SỬA ĐƯỢC NỮA");
                    return;
                }
                frm.Nhan = "Sua";
                frm.MaPT = smpt;
                frm.TIEN = scongno;
                frm.sMaNV = sMaNV;

                frm.Tienno = CTR.GETcongno_KH(smaKH);
                frm.iNgonNgu = this.iNgonNgu;
                frm.TENKH = stenkh;
                frm.MaKH = smaKH;
                frm.sTenNV = sTenNV;
                frm.ShowDialog();
                loadGetAllPHIEUTHU();
                //loadctkh();
                load_phieuthu();
            }
        }

        private void gridphieuthu_Click(object sender, EventArgs e)
        {

            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                DataRow dtr = gridphieuthu.GetDataRow(hitInfo.RowHandle);
                smaKH = dtr["MAKH"].ToString();
                stenkh = dtr["TENKH"].ToString();
                scongno = dtr["SOTIEN"].ToString();
                smpt = dtr["MAPT"].ToString();
            }
        }

        private void gridcongnokh_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitInfo = view.CalcHitInfo(pt);
            if (hitInfo.InRow)
            {
                DataRow dtr = gridcongnokh.GetDataRow(hitInfo.RowHandle);
                smaKH = dtr["MAKH"].ToString();
                stenkh = dtr["TENKH"].ToString();
                scongno = dtr["CONGNO"].ToString();
                loadfrm_thutien();
            }
        }




        

      

       
    }
}