﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Globalization;
using System.Threading;
using DevExpress.XtraPrinting;
using Quanlykho;


namespace WindowsFormsApplication1
{
    public partial class frmTonKhoNgay : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKhoNgay()
        {

            InitializeComponent();

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        public frmMain frm;

        public int iNgonNgu;
      
        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            //frm.LoadVI += new frmMain.Translate(loadcbVietNam);
            frm.LoadVI += new frmMain.Translate(loadReSVN);
            frm.LoadEN += new frmMain.Translate(loadReSEG);
            
            if (iNgonNgu == 0)
            {
                
                loadReSVN();
               

            }
            else
            {

                loadReSEG();
               
            }
            load_cbhanghoa();
            dateTu.Text = DateTime.Now.ToString("dd/MM/yyy");

            if (!PublicVariable.isKHOILUONG)
            {
                advBandedGridView3.Columns["KLTONDAU"].Visible = false;
                advBandedGridView3.Columns["KLNHAP"].Visible = false;
                advBandedGridView3.Columns["KLTRANHAP"].Visible = false;
                advBandedGridView3.Columns["KLXUAT"].Visible = false;
                advBandedGridView3.Columns["KLTRAXUAT"].Visible = false;
                advBandedGridView3.Columns["KLTONCUOI"].Visible = false;
            }
            //CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            //CultureInfo ci = new CultureInfo("en-IE");
            ////Thay đổi vài thuộc tính tùy thích
            //ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            //ci.DateTimeFormat.LongTimePattern = "hh:mm:ss";
            //ci.NumberFormat.CurrencyDecimalSeparator = ",";
            //ci.NumberFormat.CurrencyGroupSeparator = ".";

        }
        private void load_cbhanghoa()
        {
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            cbsanpham.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbsanpham.Properties.DisplayMember = "TENMH";
            cbsanpham.Properties.ValueMember = "MAMH";
            cbsanpham.Properties.View.BestFitColumns();
            //cbsanpham.Properties.PopupFormWidth = 200;
            cbsanpham.Properties.DataSource = ctr1.dtGetsanpham2();
            gridsanpham.BestFitColumns();

            cbncc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbncc.Properties.DisplayMember = "TENNCC";
            cbncc.Properties.ValueMember = "MANCC";
            cbncc.Properties.View.BestFitColumns();
            cbncc.Properties.PopupFormWidth = 300;
            cbncc.Properties.DataSource = ctr1.dtGetNCC();

        }

        private void loadReSVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resVietNam.btXem.ToString();
   
           // colNgay.Caption = resVietNam.colNgay.ToString();
            colMa.Caption = resVietNam.colMa.ToString();
            colDonViTInh.Caption = resVietNam.colDonViTInh.ToString();
            colHangHoa.Caption = resVietNam.colHangHoa.ToString();
            colSLDau.Caption = resVietNam.SoLuong.ToString();
            //colThanhTienDau.Caption = resVietNam.TongCong.ToString();
            colSLNhap.Caption = resVietNam.SoLuong.ToString();
            //colThanhTienNhap.Caption = resVietNam.TongCong.ToString();
            colSLXuat.Caption = resVietNam.SoLuong.ToString();
            //colThanhTienXuat.Caption = resVietNam.TongCong.ToString();
            colSLTOn.Caption = resVietNam.SoLuong.ToString();
            colThanhTienTOn.Caption = resVietNam.TongCong.ToString();
            gridThongTin.Caption = resVietNam.gridThongTin.ToString();
            gridDauKi.Caption = resVietNam.gridDauKi.ToString();
            gridCuoiKi.Caption = resVietNam.gridCuoiKi.ToString();
            gridNhapKho.Caption = resVietNam.gridNhapKho.ToString();
            gridXuatKho.Caption = resVietNam.gridXuatKho.ToString();
      
            btIn.Text = resVietNam.btIn.ToString();
            btXuat.Text = resVietNam.btXuat.ToString();
          //  lbTu.Text = resVietNam.NgayBD.ToString();
            //lbDen.Text = resVietNam.NgayKT.ToString();
            //colMaKho.Caption = resVietNam.MaKho.ToString();
           // colTen.Caption = resVietNam.TenKho.ToString();

        }

        private void loadReSEG()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resEngLand.btXem.ToString();
            //colNgay.Caption = resEngLand.colNgay.ToString();
            colMa.Caption = resEngLand.colMa.ToString();
            colDonViTInh.Caption = resEngLand.colDonViTInh.ToString();
            colHangHoa.Caption = resEngLand.colHangHoa.ToString();
            colSLDau.Caption = resEngLand.SoLuong.ToString();
            //colThanhTienDau.Caption = resEngLand.TongCong.ToString();
            colSLNhap.Caption = resEngLand.SoLuong.ToString();
            //colThanhTienNhap.Caption = resEngLand.TongCong.ToString();
            colSLXuat.Caption = resEngLand.SoLuong.ToString();
            //colThanhTienXuat.Caption = resEngLand.TongCong.ToString();
            colSLTOn.Caption = resEngLand.SoLuong.ToString();
            colThanhTienTOn.Caption = resEngLand.TongCong.ToString();
            gridThongTin.Caption = resEngLand.gridThongTin.ToString();
            gridDauKi.Caption = resEngLand.gridDauKi.ToString();
            gridCuoiKi.Caption = resEngLand.gridCuoiKi.ToString();
            gridNhapKho.Caption = resEngLand.gridNhapKho.ToString();
            gridXuatKho.Caption = resEngLand.gridXuatKho.ToString();
            btIn.Text = resEngLand.btIn.ToString();
            btXuat.Text = resEngLand.btXuat.ToString();
            //lbTu.Text = resEngLand.NgayBD.ToString();
            //lbDen.Text = resEngLand.NgayKT.ToString();
            //colMaKho.Caption = resEngLand.MaKho.ToString();
            //colTen.Caption = resEngLand.TenKho.ToString();
        }
        clDTO dto = new clDTO();
        Boolean _isfilter = false;
        private void loadGird(Boolean ISFILTER)
        {
            string NGAYBD = dateTu.Text;
            dto.NGAYBD = NGAYBD;
            dto.ISFILTER = false;

            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;
            dto.ISFILTER = ISFILTER;
            String SQL = "select count(mamh) from TONKHOTT WHERE NGAY='" + NGAYBD + "' AND MAKHO='" + PublicVariable.MAKHO + "'";
            CTL ctlNCC = new CTL();
            DataTable   dt=ctlNCC.GETDATA(SQL);

            SQL="SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
            DataTable dt2=ctlNCC.GETDATA(SQL);
           
            if (dt.Rows[0][0].ToString() != "0" || dt2.Rows[0][0].ToString() == dateTu.Text)
            {
                gridControl2.MainView = advBandedGridView3;
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

                SQL = "select count(mamh) from TONKHOTT WHERE NGAY='" + NGAYBD + "' AND MAKHO='" + PublicVariable.MAKHO + "'";

                dt = ctlNCC.GETDATA(SQL);
        
                if (dt.Rows[0][0].ToString() != "0")
                {
                    //INSERT CAP NHAT THEM MAT HANG CHUA CO TRONG TON KHO NGAY
                    //SQL = "INSERT INTO  [TONKHOTT] ([NGAY],[MAMH],[TONKHONGAY],[MAKHO]) SELECT convert(varchar,GETDATE(),101) AS NGAY, MAMH,SOLUONGMH,'" + PublicVariable.MAKHO + "' AS MAKHO FROM MATHANG  WHERE MAMH NOT IN(SELECT MAMH FROM TONKHOTT WHERE NGAY='" + NGAYBD + "' AND MAKHO='" + PublicVariable.MAKHO + "') AND MAMH  IN (SELECT MAMH FROM TONKHO WHERE NGAY='" + NGAYBD + "' AND MAKHO='" + PublicVariable.MAKHO + "') ";
                    
                    ctlNCC.executeNonQuery(SQL);

                    // LAY TON KHO NGAY DA CO TRONG TONKHONGAY
                    gridControl2.DataSource = ctr.getTonKhoTTngay(dto);
                }
                else
                {
                    // LAY TON KHO NGAY CHUA CO TRONG TONKHONGAY
                    gridControl2.DataSource = ctr.getTonKhoTTngay2(dto);
                }


                advBandedGridView3.BestFitColumns();
                //dt = ctr.getTonKho(dto);
                if (!PublicVariable.isKHOILUONG)
                {
                    advBandedGridView3.Columns["KLTONDAU"].Visible = false;
                    advBandedGridView3.Columns["KLNHAP"].Visible = false;
                    advBandedGridView3.Columns["KLTRANHAP"].Visible = false;
                    advBandedGridView3.Columns["KLXUAT"].Visible = false;
                    advBandedGridView3.Columns["KLTRAXUAT"].Visible = false;
                    advBandedGridView3.Columns["KLTONCUOI"].Visible = false;
                }

                if (ISFILTER)
                {
                    _isfilter = true;
                }
                else
                {
                    _isfilter = false;
                }
   
            }
            else
            {
                MessageBox.Show("ngày này không có dữ liệu");
            }

            
        }

        DataTable dt = new DataTable();
      

        clCtrl ctr = new clCtrl();
                        
                       
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           loadGird(false);

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            CTL ctltk = new CTL();
            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            string SQL = "select count(mamh) from TONKHOTT WHERE NGAY=convert(varchar,GETDATE(),101) AND MAKHO='" + PublicVariable.MAKHO + "' ";

            DataTable dt = ctltk.GETDATA(SQL);
            if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Bạn phải lưu trước khi in");
               return;
            }

          
            DataTable printtable = (DataTable)gridControl2.DataSource;
            int sohd = 0;
            if (_isfilter)
            {
                sohd = 24;
            }
            else
            {
                sohd = 17;
            }
            Inhd rep = new Inhd(printtable, sohd);
            rep.ShowPreviewDialog();
        }

   
        public void loadMesagebox()
        {
            if (iNgonNgu == 0)
            {
                MessageBox.Show("Vui long chọn đúng thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Please select wrong information", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void cbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
                CTL ctltk = new CTL();
                string NGAYBD = dateTu.Text;
                NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
                string SQL = "select count(mamh) from TONKHOTT WHERE NGAY='" + NGAYBD + "' AND MAKHO='" + PublicVariable.MAKHO + "' ";

                DataTable dt = ctltk.GETDATA(SQL);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("Bạn phải lưu trước khi xuất");
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
                    gridControl2.ExportToXls(saveFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                DevComponents.DotNetBar.MessageBoxEx.Show("Da ton tai ten");
            }
        }
        public delegate void Closeform();
        public Closeform TatForm;
       
        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
          //  TatForm();
        }

        private void dateTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dateDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
         
        }

        private void dateTu_TextChanged(object sender, EventArgs e)
        {
            if (dateTu.Text.Length>10)
            {
                dateTu.Text = "01/01/1990";
            }
        }

      

        private void glKhoHang_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                loadGird(false);
            }
            catch (Exception)
            {

                loadMesagebox();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            string NGAYBD = dateTu.Text;
            CTL ctlNCC = new CTL();
            string SQL="";
            SQL="SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
            DataTable dt=ctlNCC.GETDATA(SQL);

            DataRow dtr1 = advBandedGridView3.GetDataRow(0);
            if (dtr1 == null)
            {
                MessageBox.Show("vui lòng nhấn nút xem trước khi lưu");
                return;
            }
            if (dtr1["NGAY"].ToString() == dt.Rows[0][0].ToString())
            {
                NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
                string CHENHLECH, ISINSERT;
                int count = 0;

                for (int i = 0; i < advBandedGridView3.DataRowCount; i++)
                {
                    SQL = "";
                    for (int j = 0; j < 20 && i < advBandedGridView3.DataRowCount; j++)
                    {
                        DataRow dtr = advBandedGridView3.GetDataRow(i);
                        CHENHLECH = dtr["CHENHLECH"].ToString();
                        ISINSERT = dtr["ISINSERT"].ToString();

                        if (CHENHLECH != "0.000")
                        {
                            if (ISINSERT != "0.000")
                            {
                                count = 1;
                                SQL = SQL + " \r\nGO\r\n UPDATE  [TONKHOTT] SET TONKHONGAY=" + dtr["TONTT"].ToString() + " WHERE MAMH='" + dtr["MAMH"].ToString() + "' AND NGAY='" + NGAYBD + "' ";
                            }
                            else
                            {
                                count = 1;
                                SQL = SQL + " \r\nGO\r\n INSERT INTO  [TONKHOTT] ([NGAY],[MAMH],[TONKHONGAY],[MAKHO]) VALUES (convert(varchar,GETDATE(),101),'" + dtr["MAMH"].ToString() + "'," + dtr["TONTT"].ToString() + ",'" + PublicVariable.MAKHO + "')";
                            }
                        }
                        i++;
                    }
                    i--;

                    if (SQL != "")
                    {
                        ctlNCC.executeNonQuery2(SQL);
                    }
                }
                
               
                if (count == 0)
                {
                    SQL = "SELECT * FROM TONKHOTT WHERE NGAY=convert(varchar,GETDATE(),101) ";
                    dt = ctlNCC.GETDATA(SQL);
                    if(dt.Rows.Count==0)
                    {
                    DataRow dtr = advBandedGridView3.GetDataRow(0);
                    SQL = "INSERT INTO  [TONKHOTT] ([NGAY],[MAMH],[TONKHONGAY],[MAKHO]) VALUES (convert(varchar,GETDATE(),101),'" + dtr["MAMH"].ToString() + "'," + dtr["TONTT"].ToString() + ",'" + PublicVariable.MAKHO + "')";
                    ctlNCC.executeNonQuery2(SQL);
                    }
                }
                loadGird(false);
                MessageBox.Show("Đã lưu tồn kho thực tế ngày hôm nay");
            }
            else
            {
                MessageBox.Show("Không phải ngày hôm nay nên không thể chỉnh sửa");
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
            string reportHeader = "Báo Cáo Tồn Kho ngày kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void advBandedGridView3_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            DataRow dtr = advBandedGridView3.GetDataRow(advBandedGridView3.FocusedRowHandle);

            if (dtr != null)
            {
                if (e.Column.FieldName.ToString() == "TONTT")
                {
                    try
                    {
                        double tontt = Convert.ToDouble(dtr["TONTT"].ToString());
                        if (tontt < 0)
                        {
                            MessageBox.Show("Tồn Thực tế không thể nhỏ hơn 0");
                            dtr["TONTT"] = "0";
                        }
                        else
                        {
                            dtr["CHENHLECH"] = (Convert.ToDouble(dtr["TONTT"].ToString()) - Convert.ToDouble(dtr["TONCUOI"].ToString())).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tồn thực tế phải là số");
                        dtr["TONTT"] = "0";
                        return;
                    }
                }
            }
        }


        private void frmTonKhoNgay_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void Btnfilter_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           loadGird(true);
           
        }

  
        
    }
}