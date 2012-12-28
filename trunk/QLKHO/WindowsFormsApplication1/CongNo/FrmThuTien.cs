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
        public string Nhan;
        public string MaChuyen;
        public string MaKH;
        public string Tienno;
        public string MaPT;
        public string TIEN;
        public string HD;
        public string sMaNV,sTenNV;
        private void barSTluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
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
                //dt = Ctrl_Tien.MAPT_ctrl();
                //textBoxX1.Text = dt.Rows[0]["mapt"].ToString();
                txtPT.Text = connect.sTuDongDienMapt(txtPT.Text);
                txtMahd.Text = MaChuyen;
                txtSoTienNo.Text = Tienno;
                txtSoTienTra.Text = Tienno;
            }
            else
            {
                txtMahd.Text = HD;
                txtPT.Text = MaPT;
                txtSoTienNo.Text = Tienno;
                txtSoTienTra.Text = TIEN;
            }
            loadctkh();
        }
        public void loadctkh()
        {
            //DataTable dt = new DataTable();
            dt = Ctrl_Tien.get1pthdx_ctrl(txtMahd.Text);
            gridControl1.DataSource = dt;
        }
        public void Luu()
        {
            if (double.Parse(txtSoTienTra.Text) == 0)
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập số tiền trả");
                }
                else
                    XtraMessageBox.Show("You haven't type debt money yet!!!");

            }
            else if (double.Parse(txtSoTienTra.Text) > double.Parse(txtSoTienNo.Text)&&Nhan != "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                }
                else
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");

            }
            else if (double.Parse(txtSoTienTra.Text) > double.Parse(txtSoTienNo.Text) && double.Parse(txtSoTienTra.Text) > double.Parse(TIEN) && Nhan == "Sua")
            {
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Số tiền trả không thể lớn hơn số tiền nợ");
                }
                else
                    XtraMessageBox.Show("Pay money is not bigger than debt money!!!");

            }
            else if (Nhan == "Sua")
            {
                PHIEUTHU_DTO dto = new PHIEUTHU_DTO();
                dto.MaPhieuThu = txtPT.Text;
                dto.NhanVien = sMaNV;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.Mahoadonxuat = txtMahd.Text;
                dto.SoTienDaTra = double.Parse(txtSoTienTra.Text);

                Ctrl_Tien.SUAPHIEUTHU_ctrl(dto);
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
                PHIEUTHU_DTO dto = new PHIEUTHU_DTO();
                dto.MaPhieuThu = txtPT.Text;
                dto.NhanVien = sMaNV;
                dto.NgayThu = DateTime.Parse(dtNgayThu.Value.ToShortDateString());
                dto.SoTienDaTra = long.Parse(string.Format("{0:0}", double.Parse(txtSoTienTra.Text)));
                dto.Mahoadonxuat = txtMahd.Text;

                Ctrl_Tien.THEM_PHIEUTHU_ctrl(dto);
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bạn đã lưu thành công");
                }
                else
                    XtraMessageBox.Show("Saved Successful!");
                barSTluu.Enabled = false;
                vCapNhatSoTienNo();
            }
            loadctkh();

        }
        private void vCapNhatSoTienNo()
        {
            double bTienNo = double.Parse(string.Format("{0:0}", txtSoTienNo.Text));
            double bTienTra = double.Parse(txtSoTienTra.Text);
            txtSoTienNo.Text = string.Format("{0:N0}", bTienNo - bTienTra);
        }

        private void txtSoTienTra_TextChanged(object sender, EventArgs e)
        {
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
                else
                {
                    txtSoTienNo.Text = string.Format("{0:N0}", double.Parse(txtSoTienNo.Text));
                    txtSoTienNo.SelectionStart = txtSoTienNo.Text.Length;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
        }

        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_VN.barSTluu.ToString();
            barstDong.Caption = Tien_VN.barstDong.ToString();
            barIn.Caption = Tien_VN.barIn.ToString();
            lbhdx.Text = Tien_VN.lbhdx.ToString();
            lbNgaylap.Text = Tien_VN.lbNgaylap.ToString();
            lbNV.Text = Tien_VN.lbNV.ToString();
            lbPT.Text = Tien_VN.lbPT.ToString();
            lbTratien.Text = Tien_VN.lbTratien.ToString();
            lbTienno.Text = Tien_VN.lbTienno.ToString();
            colMãhóađơnxuất.Caption = Tien_VN.colMãhóađơnxuất.ToString();
            colMãnhânviên.Caption = Tien_VN.colMãnhânviên.ToString();
            colMãphiếuthu.Caption = Tien_VN.colMãphiếuthu.ToString();
            colNgàythu.Caption = Tien_VN.colNgàythu.ToString();
            colTiềnđãtrả.Caption = Tien_VN.colTiềnđãtrả.ToString();
            groupCtDetails.Text = Tien_VN.groupCtDetails.ToString();
            groupCtInFo.Text = Tien_VN.groupCtInFo.ToString();
        }
        public void loadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            barSTluu.Caption = Tien_EL.barSTluu.ToString();
            barstDong.Caption = Tien_EL.barstDong.ToString();
            barIn.Caption = Tien_EL.barIn.ToString();
            lbhdx.Text = Tien_EL.lbhdx.ToString();
            lbNgaylap.Text = Tien_EL.lbNgaylap.ToString();
            lbNV.Text = Tien_EL.lbNV.ToString();
            lbPT.Text = Tien_EL.lbPT.ToString();
            lbTratien.Text = Tien_EL.lbTratien.ToString();
            lbTienno.Text = Tien_EL.lbTienno.ToString();
            colMãhóađơnxuất.Caption = Tien_EL.colMãhóađơnxuất.ToString();
            colMãnhânviên.Caption = Tien_EL.colMãnhânviên.ToString();
            colMãphiếuthu.Caption = Tien_EL.colMãphiếuthu.ToString();
            colNgàythu.Caption = Tien_EL.colNgàythu.ToString();
            colTiềnđãtrả.Caption = Tien_EL.colTiềnđãtrả.ToString();
            groupCtDetails.Text = Tien_EL.groupCtDetails.ToString();
            groupCtInFo.Text = Tien_EL.groupCtInFo.ToString();
        }
        public string rMapt,rHdx,rTientra,rTienno,rNgaythu,rNv;
        private void barIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                frmReportThutienKH re = new frmReportThutienKH(dt, this.iNgonNgu, txtPT.Text, txtMahd.Text,  txtSoTienTra.Text, txtSoTienNo.Text, dtNgayThu.Text,txtNV.Text);
                re.ShowPreviewDialog();
            }
            else 
            {
                if (iNgonNgu==0)
                {
                    XtraMessageBox.Show("Dữ liệu không có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    XtraMessageBox.Show("Data is null", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
 
        private void txtSoTienTra_TextChanged_1(object sender, EventArgs e)
        {
            /*try
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
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
             */
        }



        private void barstDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}