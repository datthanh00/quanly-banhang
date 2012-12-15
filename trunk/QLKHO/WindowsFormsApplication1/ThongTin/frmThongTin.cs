using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using WindowsFormsApplication1.Class_ManhCuong;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        clDTO dto = new clDTO();
        clCtrl ctr = new clCtrl();
        //byte[] imageData; 
        Loadingggg ld = new Loadingggg();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                ld.CreateWaitDialog();
                ld.SetWaitDialogCaption("Đang lưu thông tin công ty - Vui Lòng Chờ");
                MemoryStream ms = new MemoryStream();
                if (pictureEdit1.Image!=null)
                {
               //      pictureEdit1.Image.Save(ms, pictureEdit1.Image.RawFormat);
               // imageData = ms.GetBuffer();
                ms.Close();
                }
              
                dto.MACT = "1";
                dto.TENCT = txtten.Text;
                dto.DIACHI = txtDiaChi.Text;
                dto.SDT = txtDT.Text;
                dto.FAX = txtFax.Text;
                dto.MOBILE = txtDiDong.Text;
                dto.EMAIL = txtEmail.Text;
               // dto.LOGO = ""; //imageData;
                dto.MASOTHUE = txtMaST.Text;
                dto.WEBSITE = txtWeb.Text;
                ld.simpleCloseWait();
                ctr.updateThongTinCT(dto);
                
                MessageBox.Show("Cập nhập thành công"); ld.simpleCloseWait();
                this.Close();
               
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);

            }
           
        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbTenDonVI.Text = "Tên công ty";
            lbEmail.Text = LamVN.EMAIL.ToString();
            lbDiDong.Text = LamVN.DTDD.ToString();
            lbFax.Text = LamVN.FAX.ToString();
            lbDT.Text = LamVN.SDT.ToString();
            lbMaSoThue.Text = LamVN.MASOTHUE.ToString();
            lbWeb.Text = LamVN.WEBSITE.ToString();
            lbDiaChi.Text = LamVN.DIACHI.ToString();
            simpleButton2.Text = LamVN.DONG.ToString();
            simpleButton1.Text = LamVN.LUU.ToString();
            this.Text = "Thông tin Cửa Hàng";
        }
        public void loadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbTenDonVI.Text = "Company name";
            lbEmail.Text = LamEL.EMAIL.ToString();
            lbDiDong.Text = LamEL.DTDD.ToString();
            lbFax.Text = LamEL.FAX.ToString();
            lbDT.Text = LamEL.SDT.ToString();
            lbMaSoThue.Text = LamEL.MASOTHUE.ToString();
            lbWeb.Text = LamEL.WEBSITE.ToString();
            lbDiaChi.Text = LamEL.DIACHI.ToString();
            simpleButton2.Text = LamEL.DONG.ToString();
            simpleButton1.Text = LamEL.LUU.ToString();
            this.Text = "Company Infomation";


        }
        public int iNgonNgu;
        Image newImage;
        private void frmThongTin_Load(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    loadVN();
                }
                else
                {
                    loadEN();
                }

                DataTable tb = new DataTable();
                dto.MACT = "1";
                tb = ctr.getTTCTy(dto);
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtten.Text = tb.Rows[i]["TENCT"].ToString();
                    txtDiaChi.Text = tb.Rows[i]["diachi"].ToString();
                    txtFax.Text = tb.Rows[i]["FAX"].ToString();
                    txtDT.Text = tb.Rows[i]["SDT"].ToString();
                    txtDiDong.Text = tb.Rows[i]["MOBILE"].ToString();
                    txtEmail.Text = tb.Rows[i]["EMAIL"].ToString();
                    txtMaST.Text = tb.Rows[i]["MASOTHUE"].ToString();
                    txtWeb.Text = tb.Rows[i]["WEBSITE"].ToString();
                    pictureEdit1.Image = Image.FromFile(tb.Rows[i]["logo"].ToString());

                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           

        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDiDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}