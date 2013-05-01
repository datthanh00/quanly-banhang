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
        DataView dvdropdow;


        public void loadgirdlookupMATHANG()
        {

            cbmathang.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbmathang.Properties.DataSource = dvdropdow;
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
            else if (cbhsd.Text == "")
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
            }else if (txtgiamua.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền giá mua ");
                txtgiamua.Focus();
                return;
            }else if (txtgiaban.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền giá bán ");
                txtgiaban.Focus();
                return;
            }
            

            dto.MAMH = gridLookUpEdit1View.GetFocusedRowCellValue("MAMH").ToString();
            dto.LOHANG = txtlohang.Text;
            dto.HSD = cbhsd.Text;
            dto.HSD = dto.HSD.Substring(6, 4) + "/" + dto.HSD.Substring(3, 2) + "/" + dto.HSD.Substring(0, 2);
            dto.SOLUONGMH =txtsoluong.Value.ToString();
            dto.GIAMUA = txtgiamua.Value.ToString();
            dto.GIABAN = txtgiamua.Value.ToString();

            ctl.addlohangtondau(dto);
            XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
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