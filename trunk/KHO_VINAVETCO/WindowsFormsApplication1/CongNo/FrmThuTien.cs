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
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class FrmThuTien : DevExpress.XtraEditors.XtraForm
    {
        public FrmThuTien()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        THEMPHIEUTHU_DTO pt = new THEMPHIEUTHU_DTO();
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public string Nhan,Type;
        public string MaChuyen;
        public string MaKH,TENKH;
        public string Tienno;
        public string MaPT;
        public string TIEN;
        public string HD;
        public string sMaNV,sTenNV;
        Ctrl_Tien CTR = new Ctrl_Tien();
        private void barSTluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
            this.Close();
        }

        private void FrmThuTien_Load(object sender, EventArgs e)
        {

            txtNV.Text=sTenNV;
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
                loadEL();
            if (Nhan == "Them")
            {
                
                DataTable dt = new DataTable();
     
                txtPT.Text = connect.sTuDongDienMapt(txtPT.Text);
                txtenkh.Text = TENKH;
                txtSoTienNo.Text = Tienno;
                txtSoTienTra.Text = Tienno;
            }
            else
            {
                txtenkh.Text = TENKH;
                txtPT.Text = MaPT;
                txtSoTienNo.Text = Tienno;
                txtSoTienTra.Text = TIEN;
            }
         
        }
     
        public void Luu()
        {
            if (txtSoTienTra.Text == "")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập số tiền trả");
                }
                else
                    XtraMessageBox.Show("You haven't type debt money yet!!!");
                return;
            }
            else if (Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(txtSoTienNo.Value) && Nhan != "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                }
                else
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");
                return;
            }
            else if (Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(txtSoTienNo.Value) && Convert.ToInt64(txtSoTienTra.Value) > Convert.ToInt64(TIEN) && Nhan == "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                }
                else
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");
                return;
            }
            else if (Nhan == "Sua")
            {
                PHIEUTHU_DTO dto = new PHIEUTHU_DTO();
                dto.MaPhieuThu = txtPT.Text;
                dto.NhanVien = sMaNV;
                dto.MaDoituong = MaKH;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.Mahoadonxuat = txtenkh.Text;
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                if (dto.Mahoadonxuat == "CONGNODAUKY")
                {
                    dto.Mahoadonxuat = MaKH;
                }
                try
                {
                    CTR.SUAPHIEUTHU_ctrl(dto);
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
                PHIEUTHU_DTO dto = new PHIEUTHU_DTO();
                dto.MaPhieuThu = txtPT.Text;
                dto.NhanVien = sMaNV;
                dto.MaDoituong = MaKH;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                dto.Mahoadonxuat = txtenkh.Text;

                if (dto.Mahoadonxuat == "CONGNODAUKY")
                {
                    dto.Mahoadonxuat = MaKH;
                }
                
                txtPT.Text=connect.sTuDongDienMapt(txtPT.Text);
                dto.MaPhieuThu = txtPT.Text;

                try
                {
                    CTR.THEM_PHIEUTHU_ctrl(dto);
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
            Int64 bTienNo = Convert.ToInt64( txtSoTienNo.Value);
            Int64 bTienTra = Convert.ToInt64(txtSoTienTra.Value);
            txtSoTienNo.Text = (bTienNo - bTienTra).ToString();
        }

        private void txtSoTienTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTienTra.Text == "")
                {
                    txtSoTienTra.Text = "0";
                }
 
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
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
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
        }

        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_VN.barSTluu.ToString();

            barIn.Caption = Tien_VN.barIn.ToString();
   
            lbNgaylap.Text = Tien_VN.lbNgaylap.ToString();
            lbNV.Text = Tien_VN.lbNV.ToString();
            lbPT.Text = Tien_VN.lbPT.ToString();
            lbTratien.Text = Tien_VN.lbTratien.ToString();
            lbTienno.Text = Tien_VN.lbTienno.ToString();
   

            groupCtInFo.Text = Tien_VN.groupCtInFo.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_EL.barSTluu.ToString();
        
            barIn.Caption = Tien_EL.barIn.ToString();
     
            lbNgaylap.Text = Tien_EL.lbNgaylap.ToString();
            lbNV.Text = Tien_EL.lbNV.ToString();
            lbPT.Text = Tien_EL.lbPT.ToString();
            lbTratien.Text = Tien_EL.lbTratien.ToString();
            lbTienno.Text = Tien_EL.lbTienno.ToString();
   

            groupCtInFo.Text = Tien_EL.groupCtInFo.ToString();
        }
        public string rMapt,rHdx,rTientra,rTienno,rNgaythu,rNv;

 



        private void barstDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}