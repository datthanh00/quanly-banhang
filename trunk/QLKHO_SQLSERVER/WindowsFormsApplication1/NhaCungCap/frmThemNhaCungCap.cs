using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Globalization;
using System.Threading;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm 
    {
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            //if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
                this.Close();
            //}
        }
        DTO DTO = new DTO();
        CTL CTRL = new CTL();
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MANCC, MAKV, TENNCC, DIACHI, MASOTHUE, SOTAIKHOAN, NGANHANG, SDT, EMAIL, FAX, WEBSITE, TINHTRANG;
        public int kiemtra;

        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMANCC.Text = LamVN.MANCC.ToString();
            lbMAKHUVUC.Text = LamVN.TENKV.ToString();
            lbTENNCC.Text = LamVN.TENNCC.ToString();
            lbDIACHI.Text = LamVN.DIACHI.ToString();
            lbMASOTHUE.Text = LamVN.MASOTHUE.ToString();
            lbsotaikhoan.Text = LamVN.SOTAIKHOAN.ToString();
            lbnganhang.Text = LamVN.NGANHANG.ToString();
            lbsodt.Text = LamVN.SDT.ToString();
            lbemail.Text = LamVN.EMAIL.ToString();
            lbfax.Text = LamVN.FAX.ToString();
            lbwebsite.Text = LamVN.WEBSITE.ToString();
            lbtinhtrang.Text = LamVN.TINHTRANG.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();
            colMAKV.Caption = LamVN.MAKV.ToString();
            colTENKHUVUC.Caption = LamVN.TENKV.ToString();
            colGHICHU.Caption = LamVN.GHICHU.ToString();
            colTINHTRANG.Caption = LamVN.TINHTRANG.ToString();
        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMANCC.Text = LamEL.MANCC.ToString();
            lbMAKHUVUC.Text = LamEL.MAKV.ToString();
            lbTENNCC.Text = LamEL.TENNCC.ToString();
            lbDIACHI.Text = LamEL.DIACHI.ToString();
            lbMASOTHUE.Text = LamEL.MASOTHUE.ToString();
            lbsotaikhoan.Text = LamEL.SOTAIKHOAN.ToString();
            lbnganhang.Text = LamEL.NGANHANG.ToString();
            lbsodt.Text = LamEL.SDT.ToString();
            lbemail.Text = LamEL.EMAIL.ToString();
            lbfax.Text = LamEL.FAX.ToString();
            lbwebsite.Text = LamEL.WEBSITE.ToString();
            lbtinhtrang.Text = LamEL.TINHTRANG.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            colMAKV.Caption = LamEL.MAKV.ToString();
            colTENKHUVUC.Caption = LamEL.TENKV.ToString();
            colGHICHU.Caption = LamEL.GHICHU.ToString();
            colTINHTRANG.Caption = LamEL.TINHTRANG.ToString(); checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            this.Text = "Form Insert Update Provider";
        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet3.KHUVUC' table. You can move, or remove it, as needed.
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            }
            //this.kHUVUCTableAdapter.Fill(this.xUAT_NHAPTONDataSet3.KHUVUC);

            if (kiemtra == 0)
            {
                loadgirdlookupKV();
                txtma.Text = MANCC;
                cmbmaKV.Text = MAKV;
                txtten.Text = TENNCC;
                txtdiachi.Text = DIACHI;
                txtmasothue.Text = MASOTHUE;
                txtsotaikhoan.Text = SOTAIKHOAN;
                txtnganhang.Text = NGANHANG;
                txtsodt.Text = SDT;
                txtemail.Text = EMAIL;
                txtfax.Text = FAX;
                txtwebsite.Text = WEBSITE;
                if (TINHTRANG == "True")
                {
                    checkTT.Checked = true;
                }
                else
                {
                    checkTT.Checked = false;
                }
            }
            else
            {
                loadgirdlookupKV();
                loadma();
            }



        }

        ketnoi connect = new ketnoi();
        DataView dvdropdow;
        public void loadgirdlookupKV()
        {

            cmbmaKV.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cmbmaKV.Properties.DataSource = dvdropdow;
            cmbmaKV.Properties.DisplayMember = "TENKV";
            cmbmaKV.Properties.ValueMember = "MAKV";
            cmbmaKV.Properties.View.BestFitColumns();
            cmbmaKV.Properties.PopupFormWidth = 300;
            cmbmaKV.Properties.DataSource = CTRL.GETKHUVUC();


        }
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaNCC(txtma.Text);
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    string KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }


                    if (cmbmaKV.Properties.ValueMember.ToString() == "")
                    {
                        XtraMessageBox.Show("Vui Lòng Chọn Khu Vực ", "Thông Báo");
                        cmbmaKV.Focus();
                        return;

                    }
                    else if (txtma.Text == "")
                    {
                        XtraMessageBox.Show("Vui Lòng Nhập Mã Nhà Cung Cấp", "Thông Báo");
                        txtma.Focus();
                        return;
                    }
                    else if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Vui Lòng Nhập Nhà Cung Cấp", "Thông Báo");
                        txtten.Focus();
                        return;
                    }



                    //else if (cmbmaKV.Text == "")
                    //{
                    //    XtraMessageBox.Show("Vui lòng Chọn Tên Khu Vực");

                    //}
                    if (kiemtra == 1)
                    {
                        DTO.MANCC = txtma.Text;
                        DTO.MAKV = gridLookUpEdit1View.GetFocusedRowCellValue("MAKV").ToString();
                        DTO.TENNCC = txtten.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.SOTAIKHOAN = txtsotaikhoan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.SDT = txtsodt.Text;
                        DTO.EMAIL = txtemail.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.INSERTNHACC(DTO);
                        XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                        this.Close();
                    }


                    else
                    {
                        DTO.MANCC = txtma.Text;
                        DTO.MAKV = gridLookUpEdit1View.GetFocusedRowCellValue("MAKV").ToString();
                        DTO.TENNCC = txtten.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.SOTAIKHOAN = txtsotaikhoan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.SDT = txtsodt.Text;
                        DTO.EMAIL = txtemail.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.UPDATENHACC(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();

                    }


                }
                else
                {
                    string KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }


                    if (cmbmaKV.Properties.ValueMember.ToString() == "")
                    {
                        XtraMessageBox.Show("Please Choose Area ", "Warming");
                        cmbmaKV.Focus();
                        return;
                    }
                    else if (txtma.Text == "")
                    {
                        XtraMessageBox.Show("Please Insert Provider ID", "Warming");
                        txtma.Focus();
                        return;
                    }
                    else if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Please Insert The Name of Provider", "Warming");
                        txtten.Focus();
                        return;
                    }



                    //else if (cmbmaKV.Text == "")
                    //{
                    //    XtraMessageBox.Show("Vui lòng Chọn Tên Khu Vực");

                    //}
                    if (kiemtra == 1)
                    {
                        DTO.MANCC = txtma.Text;
                        DTO.MAKV = gridLookUpEdit1View.GetFocusedRowCellValue("MAKV").ToString();
                        DTO.TENNCC = txtten.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.SOTAIKHOAN = txtsotaikhoan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.SDT = txtsodt.Text;
                        DTO.EMAIL = txtemail.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.INSERTNHACC(DTO);
                        XtraMessageBox.Show("You Added Sucessfull");
                        this.Close();
                    }


                    else
                    {
                        DTO.MANCC = txtma.Text;
                        DTO.MAKV = gridLookUpEdit1View.GetFocusedRowCellValue("MAKV").ToString();
                        DTO.TENNCC = txtten.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.MASOTHUE = txtmasothue.Text;
                        DTO.SOTAIKHOAN = txtsotaikhoan.Text;
                        DTO.NGANHANG = txtnganhang.Text;
                        DTO.SDT = txtsodt.Text;
                        DTO.EMAIL = txtemail.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.WEBSITE = txtwebsite.Text;
                        DTO.TINHTRANG = KT;
                        CTRL.UPDATENHACC(DTO);
                        XtraMessageBox.Show("You Edited Sucessfull");
                        this.Close();

                    }


                }
            
         
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc th = new frmThemKhuVuc();
            th.iNgonNgu = iNgonNgu;
            th.kiemtra = 1;
            th.ShowDialog();
            loadgirdlookupKV();
          //  this.kHUVUCTableAdapter.Fill(this.xUAT_NHAPTONDataSet3.KHUVUC);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void cmbmaKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtmasothue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }

        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtsotaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtnganhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void txtwebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                simpleButton1_Click(null, null);

            }
        }

        
    }
}