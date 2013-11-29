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
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemKho : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKho()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public void loadma()
        {
            txtmakho.Text = connect.sTuDongDienMaKho(txtmakho.Text);
        }
   

        private void btDong_Click(object sender, EventArgs e)
        {
            //if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
                this.Close();
            //}
        }
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string Nhan;
        public string MAKHO, TENKHO, MANV, DIACHI, SDTB, DTDD, NGUOILIENHE, FAX, GHICHU, TINHTRANG;
        public int kiemtra;
        private void btluu_Click(object sender, EventArgs e)
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

                    if (txtmakho.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Mã Kho");
                        txtmakho.Focus();
                        return;
                    }
                    else if (txttenkho.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Kho");
                        txttenkho.Focus();
                        return;
                    }
                    //else if (cmbtinhtrang.Text == "")
                    //{
                    //    XtraMessageBox.Show("Vui Lòng Chọn Tình Trạng ", "Thông Báo");
                    //    return;
                    //}
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MAKHO = txtmakho.Text;
                        
                        if (DTO.MAKHO.Length == 4)
                        {
                            DTO.CODEKHO = "0" + DTO.MAKHO.Substring(3, 1);
                        }
                        else
                        {
                            DTO.CODEKHO = DTO.MAKHO.Substring(3, 2);
                        }
                        DTO.TENKHO = txttenkho.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.SDTB = txtsodtB.Text;
                        DTO.DTDD = txtsodtDD.Text;
                        DTO.NGUOILH = txtnguoiLH.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        try
                        {
                            CTL.INSERTKHO(DTO);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Vui Lòng Thử Lại");
                            return;
                        }
                        
                        XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                        this.Close();
                    }
                    else
                    {
                        DTO.MAKHO = txtmakho.Text;
        
                        DTO.TENKHO = txttenkho.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.SDTB = txtsodtB.Text;
                        DTO.DTDD = txtsodtDD.Text;
                        DTO.NGUOILH = txtnguoiLH.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.UPDATEKHO(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }
                }
                else
                {
                    string  KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }

                    if (txtmakho.Text == "")
                    {
                        XtraMessageBox.Show("Please Insert Store ID", "Warming");
                        txtmakho.Focus();
                        return;
                    }

                    //else if (cmbtinhtrang.Text == "")
                    //{
                    //    XtraMessageBox.Show("Please Choose Status ", "Warming");

                    //}
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MAKHO = txtmakho.Text;

                        DTO.TENKHO = txttenkho.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.SDTB = txtsodtB.Text;
                        DTO.DTDD = txtsodtDD.Text;
                        DTO.NGUOILH = txtnguoiLH.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;

                        try
                        {
                            CTL.INSERTKHO(DTO);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Try again");
                            return;
                        }
                        XtraMessageBox.Show("You Added Succeesful");
                        this.Close();
                    }
                    else
                    {
                        DTO.MAKHO = txtmakho.Text;
                        DTO.TENKHO = txttenkho.Text;
                        DTO.DIACHI = txtdiachi.Text;
                        DTO.SDTB = txtsodtB.Text;
                        DTO.DTDD = txtsodtDD.Text;
                        DTO.NGUOILH = txtnguoiLH.Text;
                        DTO.FAX = txtfax.Text;
                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.UPDATEKHO(DTO);
                        XtraMessageBox.Show("You Edited Succeesful");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
          
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMakho.Text = LamVN.MAKHO.ToString();
            lbTenkho.Text = LamVN.TENKHO.ToString();
            lbdiachi.Text = LamVN.DIACHI.ToString();
            lbsodtdd.Text = LamVN.SDT.ToString();
            lbsosdtban.Text = LamVN.SDTB.ToString();
            lbnguoilienhe.Text = LamVN.NGUOILIENHE.ToString();
            lbfax.Text = LamVN.FAX.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
           // lbghichu.Text = LamVN.GHICHU.ToString();
            lbtinhtrang.Text = LamVN.TINHTRANG.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMakho.Text = LamEL.MAKHO.ToString();
            lbTenkho.Text = LamEL.TENKHO.ToString();
            lbdiachi.Text = LamEL.DIACHI.ToString();
            lbsodtdd.Text = LamEL.SDT.ToString();
            lbsosdtban.Text = LamEL.SDTB.ToString();
            lbnguoilienhe.Text = LamEL.NGUOILIENHE.ToString();
            lbfax.Text = LamEL.FAX.ToString();
           // lbghichu.Text = LamEL.GHICHU.ToString();
            lbtinhtrang.Text = LamEL.TINHTRANG.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString(); checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            
            this.Text = "Form Insert Store";
        }
        private void frmThemKho_Load(object sender, EventArgs e)
        {
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            }
            if (kiemtra == 0)
            {
                txtmakho.Text = MACHUYEN;
                txtnguoiLH.Text = NGUOILIENHE;
                txtsodtB.Text = SDTB;
                txtsodtDD.Text = DTDD;
                txttenkho.Text = TENKHO;
                txtdiachi.Text = DIACHI;
                txtfax.Text = FAX;
                txtghichu.Text = GHICHU;
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
                loadma();
            }
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet30.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter1.Fill(this.xUAT_NHAPTONDataSet30.NHANVIEN);
            //// TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet29.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.xUAT_NHAPTONDataSet29.NHANVIEN);
           
        }

        private void btThemKhuVuc_Click(object sender, EventArgs e)
        {
            frmThemNhanVien th = new frmThemNhanVien();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
           // this.nHANVIENTableAdapter1.Fill(this.xUAT_NHAPTONDataSet30.NHANVIEN);
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmanv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txttenkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtsodtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtsodtDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtnguoiLH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }

        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }

        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtmanv_Validated(object sender, EventArgs e)
        {

        }

    }
}