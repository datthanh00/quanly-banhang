using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Globalization;
using System.Threading;
using Quanlykho;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class Themlohangtondau : DevExpress.XtraEditors.XtraForm
    {
        public Themlohangtondau()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public int iNgonNgu;
        public string SMAMH, SLOHANG, SHSD, SSOLUONG, SGIAMUA;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            btLuu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();
           // colghichu.Caption = LamVN.GHICHU.ToString();
            colmanh.Caption = LamVN.MANH.ToString();
            colten.Caption = LamVN.TENNHOMHANG.ToString();
        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbmota.Text = LamEL.MOTA.ToString();

            btLuu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
           // colghichu.Caption = LamEL.GHICHU.ToString();
            colmanh.Caption = LamEL.MANH.ToString();
            colten.Caption = LamEL.TENNHOMHANG.ToString();
            this.Text = "Form Insert && Update Products";
        }
        public string MANHOMHANG, MANCC, TENMATHANG, MAMH, DVT, TINHTRANG, HINHANH, MASOTHUE, SOLUONG, MOTA, MAKHO, MADVT,KLDVT;
      


        public void loadgirdlookupMATHANG()
        {

            cbmathang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbmathang.Properties.DisplayMember = "TENMH";
            cbmathang.Properties.ValueMember = "MAMH";
            cbmathang.Properties.View.BestFitColumns();
            cbmathang.Properties.PopupFormWidth = 300;
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            cbmathang.Properties.DataSource = ctr1.dtGetsanpham2();
        }

        public string sBoPhan;
        private void ThemMatHang_Load(object sender, EventArgs e)
        {

            if (iNgonNgu == 1)
            {
                LoadEL();
            }
            else 
            {
                LoadTV();


            }

                
            loadgirdlookupMATHANG();
            cbmathang.Text = SMAMH;
            txtlohang.Text = SLOHANG;
            cbhsd.Text = SHSD;
            txtsoluong.Text = SSOLUONG;
            txtgiamua.Text = SGIAMUA;
        }

        DTO dto = new DTO();
        CTL ctl = new CTL();
        
        public int kiemtra;
        private void btLuu_Click(object sender, EventArgs e)
        {

            if (cbmathang.Text == "")
            {
                XtraMessageBox.Show("Vui lòng Nhập Tên Mặt Hàng");
                cbmathang.Focus();
                return;
            }

            else if (txtlohang.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Lô Hàng ");
                txtlohang.Focus();
                return;
            }
            else if (cbhsd.Text == "" || cbhsd.Text == "0001/01/01")
            {
                XtraMessageBox.Show("Vui lòng Nhập Hạn Dùng");
                cbmathang.Focus();
                return;
            }
         

            else if (txtsoluong.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền Số lượng ");
                txtsoluong.Focus();
                return;
            }
            else if (Convert.ToInt64(txtsoluong.Value) < 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn hoặc bằng 0");
                txtsoluong.Value = 0;
                return;
            }
            else if (txtgiamua.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền giá mua ");
                txtgiamua.Focus();
                return;
            }
            else if (Convert.ToInt64(txtgiamua.Value) < 0)
            {
                MessageBox.Show("Giá Mua phải lớn hơn hoặc bằng 0");
                txtgiamua.Value = 0;
                return;
            }
            

            dto.MAMH = SMAMH;
            dto.LOHANG = SLOHANG;
            dto.HSD = cbhsd.Text;
            dto.HSD = dto.HSD.Substring(6, 4) + "/" + dto.HSD.Substring(3, 2) + "/" + dto.HSD.Substring(0, 2);
            dto.SOLUONGMH =Convert.ToDecimal(txtsoluong.Value).ToString();
            dto.GIAMUA = Convert.ToInt64(txtgiamua.Value).ToString();
            
            double TONKHO=0, TONDAUMIN=0;
            DataTable DT1;
            string SQL;

            SQL = "SELECT TONKHO FROM TONDAUKHOHANG WHERE MAMH='" + SMAMH + "' AND LOHANG='" + SLOHANG + "'";
            DT1 = ctl.GETDATA(SQL);
            if (DT1.Rows.Count > 0)
            {
                TONKHO = Convert.ToDouble(DT1.Rows[0][0].ToString());

                SQL = "SELECT (-(SELECT CASE WHEN NHAP IS NULL THEN 0 ELSE NHAP END) + (SELECT CASE WHEN XUAT IS NULL THEN 0 ELSE XUAT END)+ (SELECT CASE WHEN TRANHAP IS NULL THEN 0 ELSE TRANHAP END) - (SELECT CASE WHEN TRAXUAT IS NULL THEN 0 ELSE TRAXUAT END)) FROM(SELECT (SELECT SUM(NHAPXUAT) FROM TONKHO WHERE MANHAPXUAT='N' AND MAMH='" + SMAMH + "' AND LOHANG='" +  SLOHANG + "') AS NHAP,  (SELECT -SUM(NHAPXUAT) FROM TONKHO WHERE MANHAPXUAT='X' AND MAMH='" + SMAMH + "' AND LOHANG='" +  SLOHANG + "') AS XUAT, (SELECT -SUM(NHAPXUAT) FROM TONKHO WHERE MANHAPXUAT='TN' AND MAMH='" + SMAMH + "' AND LOHANG='" +  SLOHANG + "') AS TRANHAP,(SELECT SUM(NHAPXUAT) FROM TONKHO WHERE MANHAPXUAT='TX' AND MAMH='" + SMAMH + "' AND LOHANG='" +  SLOHANG + "') AS TRAXUAT) AS T1";
                DT1 = ctl.GETDATA(SQL);
            
                if (DT1.Rows[0][0].ToString() != "")
                {
                    TONDAUMIN = Convert.ToDouble(DT1.Rows[0][0].ToString());
                }

                double SOLUONGMH1= Convert.ToDouble(dto.SOLUONGMH); 

                if(TONDAUMIN>SOLUONGMH1)
                {
                     XtraMessageBox.Show("Tồn đầu không thể nhỏ hơn: "+TONDAUMIN.ToString());
                     return;
                }

                dto.CHENHLECH = (SOLUONGMH1 - TONKHO).ToString();
                ctl.UPDATElohangtondau(dto);
                XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
            }
            this.Close();
        }


        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmathang_EditValueChanged(object sender, EventArgs e)
        {
            dto.MAMH = gridLookUpEdit1View.GetFocusedRowCellValue("MAMH").ToString();
        }




        
      
    }
}