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
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class FrmThuTienncc : DevExpress.XtraEditors.XtraForm
    {
        public FrmThuTienncc()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        THEMPHIEUTHU_DTO pt = new THEMPHIEUTHU_DTO();
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public string Nhan,Type;
        public string MaChuyen;
        public string Mancc,TENNCC;
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
                txtenkh.Text = TENNCC;
      
                txtSoTienTra.Text = Tienno;
            }
            else
            {
                txtenkh.Text = TENNCC;
                txtPT.Text = MaPT;

                txtSoTienTra.Text = (-Convert.ToInt64(TIEN)).ToString();
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
            if (Nhan == "Sua")
            {
                if (PublicVariable.SUA == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                }
                PHIEUTHU_DTO dto = new PHIEUTHU_DTO();
                dto.MaPhieuThu = txtPT.Text;
                dto.NhanVien = sMaNV;
                dto.MaDoituong = Mancc;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.Mahoadonxuat = txtenkh.Text;
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                if (dto.Mahoadonxuat == "CONGNODAUKY")
                {
                    dto.Mahoadonxuat = Mancc;
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
                if (PublicVariable.THEM == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                }
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
                dto.MaDoituong = Mancc;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.SoTienDaTra = Convert.ToInt64(txtSoTienTra.Value);
                dto.Mahoadonxuat = txtenkh.Text;

                if (dto.Mahoadonxuat == "CONGNODAUKY")
                {
                    dto.Mahoadonxuat = Mancc;
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

            Int64 bTienTra = Convert.ToInt64(txtSoTienTra.Value);
    
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

            groupCtInFo.Text = Tien_EL.groupCtInFo.ToString();
        }
        public string rMapt,rHdx,rTientra,rTienno,rNgaythu,rNv;

        private void barstDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
        }

    }
}