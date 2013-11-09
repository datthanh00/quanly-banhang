using System;
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
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmTraTien : DevExpress.XtraEditors.XtraForm
    {
        public frmTraTien()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public string Nhan,Type;
        public string MaChuyen;
        public string MaNcc,TENNCC;
        public string Tienno;
        public string MaPC;
        public string TIEN;
        public string HD;
        public string sMaNV, sTenNV;
        Ctrl_Tien CTR = new Ctrl_Tien();


        private void frmTraTien_Load(object sender, EventArgs e)
        {
            txtNV.Text = sTenNV;
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            if (Nhan == "Them")
            {

                DataTable dt = new DataTable();
                //dt = CTR.MAPT_ctrl();
                //textBoxX1.Text = dt.Rows[0]["mapt"].ToString();
                //loadmatutang();
                txtPC.Text = connect.sTuDongDienMapc(txtPC.Text);
                txttenncc.Text = TENNCC;
                txtSoTienNo.Text = Tienno;

                txtSoTienTra.Text = Tienno;
            }
            else
            {
                txttenncc.Text = TENNCC;
                txtPC.Text = MaPC;
                txtSoTienNo.Text = Tienno;
                txtSoTienTra.Text = TIEN;
            }
          
        }
        public void Luu()
        {

            if (Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(txtSoTienNo.Value) && Nhan != "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");
                }
            }
            else if (Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(txtSoTienNo.Value) && Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(TIEN) && Nhan == "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");
                    return;
                }

            }
            else if (txtSoTienTra.Text == "")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập số tiền trả");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("You haven't type debt money yet!!!");
                    return;
                }
            }
            
            if (Nhan == "Sua")
            {
                PHIEUCHI_DTO dto = new PHIEUCHI_DTO();
                dto.MaPhieuChi = txtPC.Text;
                dto.NhanVien = sMaNV;
                dto.MaDoituong = MaNcc;
                dto.NgayChi = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                dto.Mahoadonnhap = txttenncc.Text;
                //dto.SoTienDaTra = Int64.Parse(txtSoTienTra.Text);
                if (dto.Mahoadonnhap=="CONGNODAUKY")
                {
                    dto.Mahoadonnhap=MaNcc;
                }
                CTR.SUAPHIEUCHI(dto);
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn đã lưu thành công");
                }
                else
                    XtraMessageBox.Show("Saved Successful!");
                barSTluu.Enabled = false;
                //vCapNhatSoTienNo();
            }
            else
            {
                if (Convert.ToInt64(txtSoTienTra.Value) == 0)
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Bạn chưa nhập số tiền trả");
                    }
                    else
                        XtraMessageBox.Show("You haven't type debt money yet!!!");
                    return;
                }
                PHIEUCHI_DTO dto = new PHIEUCHI_DTO();//may lam form nao za tratien uh nhacc hay khach hang frncorm chhinh dau
                dto.MaPhieuChi = txtPC.Text;
                dto.NhanVien = sMaNV;
                dto.MaDoituong = MaNcc;
                dto.NgayChi = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                dto.Mahoadonnhap = txttenncc.Text;
                if (dto.Mahoadonnhap=="CONGNODAUKY")
                {
                    dto.Mahoadonnhap=MaNcc;
                }

                txtPC.Text = connect.sTuDongDienMapc(txtPC.Text);
                dto.MaPhieuChi = txtPC.Text;

                try
                {
                    CTR.THEM_PHIEUCHI_ctrl(dto);
                }
                catch
                {
                    XtraMessageBox.Show("Vui Lòng Thử Lại");
                    return;
                }
         
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn đã lưu thành công");
                }
                else
                    XtraMessageBox.Show("Saved Successful!");
                barSTluu.Enabled = false;
                vCapNhatSoTienNo();
            }
      

        }
        private void vCapNhatSoTienNo()
        {
            Int64 bTienNo = Convert.ToInt64(txtSoTienNo.Value);
            Int64 bTienTra = Convert.ToInt64(txtSoTienTra.Value);
            txtSoTienNo.Text = (bTienNo - bTienTra).ToString();
        }


        private void txtSoTienNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTienNo.Text == "")
                {
                    txtSoTienNo.Text = "0";
                }
           
            }
            catch (Exception ex) { DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message); }
        }

        private void barSTluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
            this.Close();
        }
        


        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_VN.barSTluu.ToString();
  
            barIn.Caption = Tien_VN.barIn.ToString();
           
            lbTienno.Text = Tien_VN.lbTienno.ToString();
            lbTratien.Text = Tien_VN.lbTratien.ToString();
            lbPC.Text = Tien_VN.lbPC.ToString();
            lbNgaylap.Text = Tien_VN.lbNgaylap.ToString();
            lbNV.Text = Tien_VN.lbNV.ToString();
          

            groupCtInFo.Text = Tien_VN.groupCtInFo.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_EL.barSTluu.ToString();
          
            barIn.Caption = Tien_EL.barIn.ToString();
           
            lbTienno.Text = Tien_EL.lbTienno.ToString();
            lbTratien.Text = Tien_EL.lbTratien.ToString();
            lbPC.Text = Tien_EL.lbPC.ToString();
            lbNgaylap.Text = Tien_EL.lbNgaylap.ToString();
            lbNV.Text = Tien_EL.lbNV.ToString();
            groupCtInFo.Text = Tien_EL.groupCtInFo.ToString();
        }

        public string rMapc, rHdn, rTientra, rTienno, rNgaychi, rNv;
       

        private void barstDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

   

        
    }
}