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


namespace WindowsFormsApplication1
{
    public partial class frmBaoCaoTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoTonKho()
        {

            InitializeComponent();

        }

        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        public frmMain frm;

        public int iNgonNgu;
      
        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            

            if (PublicVariable.XEM == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frm.LoadVI += new frmMain.Translate(loadcbVietNam);
            ////frm.LoadVI += new frmMain.Translate(loadGird);
        
            frm.LoadVI += new frmMain.Translate(loadReSVN);
            frm.LoadEN += new frmMain.Translate(loadcbEgLish);
            frm.LoadEN += new frmMain.Translate(loadReSEG);
            
            
            //loadgirdlookup();
            
            if (iNgonNgu == 0)
            {
                
                loadReSVN();
                loadcbVietNam();

            }
            else
            {

                loadReSEG();
                loadcbEgLish();
            } 
           // loadGird();
        }
        DataView dvdropdow;
        private void loadReSVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resVietNam.btXem.ToString();
            colNhomHang.Caption = resVietNam.colNhomHang.ToString();
            colNhomHang.Caption = resVietNam.colNhomHang.ToString();
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
            btDong.Text = resVietNam.btDong.ToString();
            btIn.Text = resVietNam.btIn.ToString();
            btXuat.Text = resVietNam.btXuat.ToString();
            lbTu.Text = resVietNam.NgayBD.ToString();
            lbDen.Text = resVietNam.NgayKT.ToString();
            //colMaKho.Caption = resVietNam.MaKho.ToString();
           // colTen.Caption = resVietNam.TenKho.ToString();

        }

        private void loadReSEG()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btXem.Text = resEngLand.btXem.ToString();
            colNhomHang.Caption = resEngLand.colNhomHang.ToString();
            colNhomHang.Caption = resEngLand.colNhomHang.ToString();
           // colNgay.Caption = resEngLand.colNgay.ToString();
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
            btDong.Text = resEngLand.btDong.ToString();
            btIn.Text = resEngLand.btIn.ToString();
            btXuat.Text = resEngLand.btXuat.ToString();
            lbTu.Text = resEngLand.NgayBD.ToString();
            lbDen.Text = resEngLand.NgayKT.ToString();
           // colMaKho.Caption = resEngLand.MaKho.ToString();
           // colTen.Caption = resEngLand.TenKho.ToString();
        }
        clDTO dto = new clDTO();

        private void loadGird()
        {
            
           // dto.MAKHO = gView.GetFocusedRowCellValue("MAKHO").ToString();
            

            string NGAYBD = dateTu.Text;
            NGAYBD = NGAYBD.Substring(6, 4) + "/" + NGAYBD.Substring(3, 2) + "/" + NGAYBD.Substring(0, 2);
            dto.NGAYBDKHO = NGAYBD;

            string NGAYKT = dateDen.Text;
            NGAYKT = NGAYKT.Substring(6, 4) + "/" + NGAYKT.Substring(3, 2) + "/" + NGAYKT.Substring(0, 2);
            dto.NGAYKTKHO = NGAYKT;
        
            gridControl2.MainView = advBandedGridView3;
            gridControl2.DataSource = ctr.getTonKho(dto);
            //dt = ctr.getTonKho(dto);
            
        }

        DataTable dt = new DataTable();
      

        clCtrl ctr = new clCtrl();
        //private void loadCBKho()
        //{
        //    cbKho.DisplayMember = "tenkho";
        //    cbKho.ValueMember = "makho";
        //    cbKho.DataSource = ctr.getallKho();
        //    cbKho.SelectedIndex = 0;
        //}
        public void loadcbEgLish()
        {
            cbThoiGian.Properties.Items.Clear();
            cbThoiGian.Properties.Items.Add("Today");
            cbThoiGian.Properties.Items.Add("This Month");
            cbThoiGian.Properties.Items.Add("This Year");
            cbThoiGian.Properties.Items.Add("Jannuary");
            cbThoiGian.Properties.Items.Add("February");
            cbThoiGian.Properties.Items.Add("March");
            cbThoiGian.Properties.Items.Add("April");
            cbThoiGian.Properties.Items.Add("May");
            cbThoiGian.Properties.Items.Add("June");
            cbThoiGian.Properties.Items.Add("July");
            cbThoiGian.Properties.Items.Add("August");
            cbThoiGian.Properties.Items.Add("September");
            cbThoiGian.Properties.Items.Add("October");
            cbThoiGian.Properties.Items.Add("November");
            cbThoiGian.Properties.Items.Add("December");
            cbThoiGian.SelectedIndex = 1;
        }
        public void loadcbVietNam()
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
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {

                loadGird();
            }
            catch (Exception)
            {
                loadMesagebox();

            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "0")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
           /* if (advBandedGridView3.RowCount > 0)
            {
                reportTonKhoSoLuongGiaTri rep = new reportTonKhoSoLuongGiaTri(dt, iNgonNgu, PublicVariable.MAKHO, dateTu.Text, dateDen.Text);
                rep.ShowPreviewDialog();
            }
            else
            {
                if (iNgonNgu == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MessageBox.Show("Data null", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }


            }
            */
            gridControl2.ShowPrintPreview();
        }

        private void cbThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadNgay();
                
            }
            catch ( Exception)
            {
                loadMesagebox();
                
            }
            
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
            if (PublicVariable.IN == "0")
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
                loadGird();
            }
            catch (Exception)
            {

                loadMesagebox();
            }
        }

        
    }
}