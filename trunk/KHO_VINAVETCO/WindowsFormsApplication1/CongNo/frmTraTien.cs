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

            if (double.Parse(txtSoTienTra.Text) > double.Parse(txtSoTienNo.Text) && Nhan != "Sua")
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
            else if (double.Parse(txtSoTienTra.Text) > double.Parse(txtSoTienNo.Text) && double.Parse(txtSoTienTra.Text) > double.Parse(TIEN) && Nhan == "Sua")
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
                dto.SoTienDaTra = long.Parse(string.Format("{0:0}", double.Parse(txtSoTienTra.Text)));
                dto.Mahoadonnhap = txttenncc.Text;
                //dto.SoTienDaTra = double.Parse(txtSoTienTra.Text);
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
                if (double.Parse(txtSoTienTra.Text) == 0)
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
                dto.SoTienDaTra = long.Parse(string.Format("{0:0}", double.Parse(txtSoTienTra.Text)));
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
            double bTienNo = double.Parse(string.Format("{0:0}", txtSoTienNo.Text));
            double bTienTra = double.Parse(txtSoTienTra.Text);
            txtSoTienNo.Text = string.Format("{0:N0}", bTienNo - bTienTra);
        }


        private void txtSoTienNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTienNo.Text == "")
                {
                    txtSoTienNo.Text = "0";
                }
                else
                {
                    txtSoTienNo.Text = string.Format("{0:N0}", double.Parse(txtSoTienNo.Text));
                    txtSoTienNo.SelectionStart = txtSoTienNo.Text.Length;
                }
            }
            catch (Exception ex) { DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message); }
        }

        private void barSTluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
        }
        

        private void txtSoTienTra_TextChanged_1(object sender, EventArgs e)
        {/*
            try
            {
                if (txtSoTienTra.Text == "")
                {
                    txtSoTienTra.Text = "0";
                }
                else
                {
                    txtSoTienTra.Text = string.Format("{0:N0}", double.Parse(txtSoTienTra.Text));
                    txtSoTienTra.SelectionStart = txtSoTienTra.Text.Length;
                }
            }
            catch (Exception ex) { DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message); }
           */
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_VN.barSTluu.ToString();
            barstDong.Caption = Tien_VN.barstDong.ToString();
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
            barstDong.Caption = Tien_EL.barstDong.ToString();
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