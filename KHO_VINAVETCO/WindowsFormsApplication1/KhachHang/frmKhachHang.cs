﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
////using WindowsFormsApplication1.class_TungLam;


namespace WindowsFormsApplication1
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string sTenKH;
        string sMaKH;

        string sSoTaiKhoan;

        public string SSoTaiKhoan
        {
            get { return sSoTaiKhoan; }
            set { sSoTaiKhoan = value; }
        }
        string sNganHang;

        public string SNganHang
        {
            get { return sNganHang; }
            set { sNganHang = value; }
        }
        string sMaST;

        public string SMaST
        {
            get { return sMaST; }
            set { sMaST = value; }
        }
        string sDiaChi;

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }
        string sSDT;

        public string SSDT
        {
            get { return sSDT; }
            set { sSDT = value; }
        }
        string sSofax;

        public string SSofax
        {
            get { return sSofax; }
            set { sSofax = value; }
        }
        string sWebsite;
    
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
           
        public string TenKH { get { return sTenKH; } set { sTenKH = value; } }
        public string MaKH { get { return sMaKH; } set { sMaKH = value; } }
        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
             frmThemKhachHang tkh = new frmThemKhachHang();
             tkh.iNgonNgu = iNgonNgu;
             tkh.kiemtra = 1;
             tkh.ShowDialog();
             LOADDANHSACHKHACHHANG();
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        //private bool thoat = false;
        string sma, sten,sbidanh, smakv, smanv, smabg, sdiachi, ssoTK, snganhang, smasothue, sfax, syahoo, snickskype, stinhtrang,stientratruoc,schietkhau;
        public string stennhanvien, smanhanvien; 
        DTO DTO = new DTO();
        CTL ctl= new CTL();
        public string fsten;
       
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            if (sma == null || sma == "")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Xóa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Delete !!!!!!!!");
                }

            }
            else if (iNgonNgu == 0)
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có chắc xóa thông tin khách hàng " + sten + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {

                    DTO.MAKH = sma;
                    Boolean isdeletekh = ctl.isDELETEKHACHHANG(DTO);
                    if (!isdeletekh)
                    {
                        MessageBox.Show("Khách hàng Có Hóa Đơn bạn không thể xóa");
                        return;
                    }
                    try
                    {
                        ctl.DELETEKHACHHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do khách hàng đang có hóa đơn hoặc công nợ đầu kỳ");
                        return;
                    }
                    LOADDANHSACHKHACHHANG();
                    sma = "";

                    sten = "";
                    sbidanh = "";
                    stientratruoc = "";
                    schietkhau = "";
                    smakv = "";

                    ssoTK = "";
                    snganhang = "";
                    smasothue = "";
                    sdiachi = "";
                    sSDT = "";
                    sfax = "";
                    sWebsite = "";
                    syahoo = "";
                    snickskype = "";
                    stinhtrang = "";
                }
            }
            else
            {
                DialogResult a = DevComponents.DotNetBar.MessageBoxEx.Show(" Are You Sure To Delete Infomation about Custommer :   " + sten + " ???", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {


                    DTO.MAKH = sma;
                    Boolean isdeletekh = ctl.isDELETEKHACHHANG(DTO);
                    if (!isdeletekh)
                    {
                        MessageBox.Show("Custommer is used you can not delete");
                        return;
                    }
                    try
                    {
                        ctl.DELETEKHACHHANG(DTO);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa do khách hàng đang có hóa đơn");
                        return;
                    }
                    LOADDANHSACHKHACHHANG();
                    sma = "";

                    sten = "";
                    sbidanh = "";
                    smakv = "";

                    ssoTK = "";
                    snganhang = "";
                    smasothue = "";
                    sdiachi = "";
                    sSDT = "";
                    sfax = "";
                    sWebsite = "";
                    syahoo = "";
                    snickskype = "";
                    stinhtrang = "";
                    stientratruoc = "";
                    schietkhau = "";
                }
            }
           
        }

        
        
        private void LOADDANHSACHKHACHHANG()
        {
            girdcontrol.MainView = gridViewKHACHHANG;
            girdcontrol.DataSource = ctl.GETDANHSACHKH();
            gridViewKHACHHANG.BestFitColumns();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deDongTab();
           
        }
       
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            LOADDANHSACHKHACHHANG();
        }
        public int iNgonNgu;
        
        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            girdcontrol.ShowPrintPreview();
        }

       

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            if (saveFileDialog1.FileName!="")
            {
                girdcontrol.ExportToXls(saveFileDialog1.FileName); 
            }
            
        }

        // string sma,sten;
       // public string ma;

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dtr = gridViewKHACHHANG.GetDataRow(e.RowHandle);
                sma = dtr["MAKH"].ToString();
                
                sten = dtr["TENKH"].ToString();
                sbidanh = dtr["BIDANH"].ToString();
                smakv = dtr["MAKV"].ToString();

                ssoTK = dtr["SOTAIKHOAN"].ToString();
                snganhang = dtr["NGANHANG"].ToString();
                smasothue = dtr["MASOTHUE"].ToString();
                sdiachi = dtr["DIACHI"].ToString();
                sSDT = dtr["SDT"].ToString();
                sfax = dtr["FAX"].ToString();
                sWebsite = dtr["WEBSITE"].ToString();
                syahoo = dtr["YAHOO"].ToString();
                snickskype = dtr["SKYPE"].ToString();
                stinhtrang = dtr["TINHTRANG"].ToString();
                smanv= dtr["MANV"].ToString();
                smabg = dtr["MABG"].ToString();
                stientratruoc = dtr["TIENTRATRUOC"].ToString();
                schietkhau = dtr["CHIETKHAU"].ToString();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
   
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemKhachHang sua = new frmThemKhachHang();
            sua.iNgonNgu = iNgonNgu;
            sua.kiemtra = 0;
            sua.MACHUYEN = sma;
            sua.TenKH = sten;
            sua.BiDanh = sbidanh;
            sua.sMaKV = smakv;
            sua.sMaNV = smanv;
            sua.sMaBG = smabg;
            sua.SOTK = ssoTK;
            sua.NGANHANG = snganhang;
            sua.MASOTHUE = smasothue;
            sua.DIACHI = sdiachi;
            sua.SDT = sSDT;
            sua.FAX = sfax;
            sua.WEBSITE = sWebsite;
            sua.YAHOO = syahoo;
            sua.SKYPE = snickskype;
            sua.TINHTRANG = stinhtrang;
            sua.TIENTRATRUOC = stientratruoc;
            sua.CHIETKHAU = schietkhau;
            if (sma == null||sma =="")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                }
                if (iNgonNgu == 1)
                {
                    XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                }

            }
            else
            {
                sua.ShowDialog();
                LOADDANHSACHKHACHHANG();

            }
            //sua.machuyen = sma;
            

            //LoadfrmSua();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            LOADDANHSACHKHACHHANG();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            try
            {
                if (sma == null || sma == "")
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Cần Sửa !!!!!!!!!!");
                    }
                    if (iNgonNgu == 1)
                    {
                        XtraMessageBox.Show("Please Select Infomation Need To Edit !!!!!!!!");
                    }

                }
                else
                {
                    frmThemKhachHang sua = new frmThemKhachHang();
                    sua.iNgonNgu = iNgonNgu; sua.kiemtra = 0;
                    sua.MACHUYEN = sma;
                    sua.TenKH = sten;
                    sua.BiDanh = sbidanh;
                    sua.sMaKV = smakv;
                    sua.sMaNV = smanv;
                    sua.sMaBG = smabg;
                    sua.SOTK = ssoTK;
                    sua.NGANHANG = snganhang;
                    sua.MASOTHUE = smasothue;
                    sua.DIACHI = sdiachi;
                    sua.SDT = sSDT;
                    sua.FAX = sfax;
                    sua.WEBSITE = sWebsite;
                    sua.YAHOO = syahoo;
                    sua.SKYPE = snickskype;
                    sua.TINHTRANG = stinhtrang;
                    sua.TIENTRATRUOC = stientratruoc;
                    sua.CHIETKHAU = schietkhau;
                    sua.ShowDialog();
                    
                    LOADDANHSACHKHACHHANG();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

        }

        private void barNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dskh= new DataTable();
           // Inbbbg inbb = new Inbbbg(dskh);
           // inbb.ShowPreviewDialog();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string SQL = "";
            CTL ctlNCC = new CTL();
            string TENCTY, TENNV, SDTNV, TENKH, DTKH, DIACHIKH;
            
            
            SQL = "SELECT TENCT FROM THONGTINCT";
            DataTable TBGETTT = ctlNCC.GETDATA(SQL);
            TENCTY = TBGETTT.Rows[0][0].ToString();
            TENNV = stennhanvien;

            SQL = "SELECT SDT FROM NHANVIEN WHERE MANV='"+smanhanvien+"'";
            TBGETTT = ctlNCC.GETDATA(SQL);
            SDTNV = TBGETTT.Rows[0][0].ToString();
           


            DataTable DTNCC= new DataTable("SDKHACHHANG");
            DTNCC.Columns.Add("NOIDUNG");
            for (int i = 0; i < gridViewKHACHHANG.DataRowCount; i++)
            {
                DataRow dtr = gridViewKHACHHANG.GetDataRow(i);
                int SLIN = Convert.ToInt32(dtr["SLIN"].ToString());
                if (SLIN > 0)
                {
                    SQL = "SELECT TENKH,DIACHI,SDT FROM KHACHHANG WHERE MAKH='" + dtr["MAKH"].ToString() + "'";
                    TBGETTT = ctlNCC.GETDATA(SQL);
                    TENKH = TBGETTT.Rows[0][0].ToString();
                    DIACHIKH = TBGETTT.Rows[0][1].ToString();
                    DTKH = TBGETTT.Rows[0][2].ToString();

                    for (int J = 0; J < SLIN; J++)
                    {
                        DataRow RNGUOIGUI = DTNCC.NewRow();
                        RNGUOIGUI[0] = "NGƯỜI GỬI:";
                        DTNCC.Rows.Add(RNGUOIGUI);

                        DataRow RNHANVIEN = DTNCC.NewRow();
                        RNHANVIEN[0] = TENNV + " nhân viên " + TENCTY;
                        DTNCC.Rows.Add(RNHANVIEN);

                        DataRow RSDTNV = DTNCC.NewRow();
                        RSDTNV[0] = "ĐIỆN THOẠI: " + SDTNV;
                        DTNCC.Rows.Add(RSDTNV);

                        DataRow RNGUOINHAN = DTNCC.NewRow();
                        RNGUOINHAN[0] = "NGƯỜI NHẬN:";
                        DTNCC.Rows.Add(RNGUOINHAN);

                        DataRow RKHACHHANG = DTNCC.NewRow();
                        RKHACHHANG[0] = "CỬA HÀNG THUỐC THÚ Y " +TENKH ;
                        DTNCC.Rows.Add(RKHACHHANG);

                        DataRow RDCKH = DTNCC.NewRow();
                        RDCKH[0] = "ĐIẠ CHỈ: " + DIACHIKH;
                        DTNCC.Rows.Add(RDCKH);

                        DataRow RDTKH = DTNCC.NewRow();
                        RDTKH[0] = "ĐIỆN THOẠI: " + DTKH;
                        DTNCC.Rows.Add(RDTKH);

                        DataRow RLUUY = DTNCC.NewRow();
                        RLUUY[0] = "lƯU Ý: hàng dễ vỡ xin nhẹ tay - hàng đã thanh toán tiền cước - giao tận nơi";
                        DTNCC.Rows.Add(RLUUY);

                        DataRow RBLANK = DTNCC.NewRow();
                        RBLANK[0] = "";
                        DTNCC.Rows.Add(RBLANK);
                    }
                }

            }

            InBBBG rep = new InBBBG(DTNCC);
            rep.ShowPreviewDialog();

        }
       
    }
}
