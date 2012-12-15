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
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
       

        DataTable dt = new DataTable();
        public string MANV, MABP, USERNAME, PASSWORD, CHUCVU, TENNV, DIACHI, NGAYSINH, SCMND, SDT, TINHTRANG;
        ketnoi connect = new ketnoi();
        public int kiemtra;
        public void loadma()
        {
            txtmanv.Text = connect.sTuDongDienMaNV(txtmanv.Text);
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
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
                txtmanv.Text = MANV;
                txttennv.Text = TENNV;

                txtdiachi.Text = DIACHI;
                cmbdate.Text = NGAYSINH;
                txtsoCMND.Text = SCMND;
                txtsdt.Text = SDT;
            }
            else
            {
                loadma();
            }


        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbmanv.Text = LamVN.MANV.ToString();
            lbtennv.Text = LamVN.TENNV.ToString();
            lbdiachi.Text = LamVN.DIACHI.ToString();
            lbngaysinh.Text = LamVN.NGAYSINH.ToString();
            lbsocmnd.Text = LamVN.SCMND.ToString();
            lbsodt.Text = LamVN.SDT.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btLuu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbmanv.Text = LamEL.MANV.ToString();
            lbtennv.Text = LamEL.TENNV.ToString();
            lbdiachi.Text = LamEL.DIACHI.ToString();
            lbngaysinh.Text = LamEL.NGAYSINH.ToString();
            lbsocmnd.Text = LamEL.SCMND.ToString();
            lbsodt.Text = LamEL.SDT.ToString();
           // lbtinhtrang.Text = LamEL.TINHTRANG.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();// checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            this.Text = "Form Insert && Update Employee";
        }
        string cackitudacbiet = @"!@#$%^&*()_+|~<>,.?/\=";
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    string KT;
                    if (TINHTRANG=="False")
                    {
                        KT = "False";
                    }
                    else
                    {
                        KT = "True";
                    }
                    if (txttennv.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Nhân Viên ");
                        txttennv.Focus();
                        return;

                    }
                    else if (txttennv.Text.IndexOfAny(cackitudacbiet.ToCharArray()) != -1)
                    {
                        XtraMessageBox.Show("Tên Nhân Viên không được chứa kí tự đặc biệt!");
                        txttennv.Focus();
                        return;
                    }
                    else if (txtsdt.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập SĐT");
                        txtsdt.Focus();
                        return;
                    }
                    else if (txtsdt.Text.Length < 6 || txtsdt.Text.Length > 13)
                    {
                        XtraMessageBox.Show("Số điện thoại phải nằm trong khoản từ 6 số tới 12 số");
                        txtsdt.Focus();
                        return;
                    }
                    else if (cmbdate.Text.Length < 10 )
                    {
                        XtraMessageBox.Show("ngày sinh không đúng phải theo định dạng dd/mm/yyyy");
                        txtsdt.Focus();
                        return;
                    }

                    else
                    {
                        if (kiemtra == 1)
                        {

                            DTO.MANV = txtmanv.Text;

                            DTO.TENNV = txttennv.Text;
                            DTO.DIACHI = txtdiachi.Text;
                            string ngaysinh = cmbdate.Text;
                            ngaysinh = ngaysinh.Substring(6, 4) + "/" + ngaysinh.Substring(3, 2) + "/" + ngaysinh.Substring(0, 2);
                            DTO.NGAYSINH = ngaysinh;
                            DTO.SCMND = txtsoCMND.Text;
                            DTO.SDT = txtsdt.Text;
                            DTO.TINHTRANG = "False";
                            CTL.INSERTNHANVIEN(DTO);


                            XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                            this.Close();

                        }
                        else
                        {
                            DTO.MANV = txtmanv.Text;

                            DTO.TENNV = txttennv.Text;
                            DTO.DIACHI = txtdiachi.Text;
                            string ngaysinh = cmbdate.Text;
                            ngaysinh = ngaysinh.Substring(6, 4) + "/" + ngaysinh.Substring(3, 2) + "/" + ngaysinh.Substring(0, 2);
                            DTO.NGAYSINH = ngaysinh;
                            DTO.SCMND = txtsoCMND.Text;
                            DTO.SDT = txtsdt.Text;
                            DTO.TINHTRANG =KT ;
                            CTL.UPDATENHANVIEN(DTO);

                            XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                            this.Close();

                        }
                    }
                }
                else
                {
                    string KT;
                   
                    if (TINHTRANG == "False")
                    {
                        KT = "False";

                    }
                    else
                    {
                        KT = "True";
                    }
                    if (txttennv.Text == "")
                    {

                        XtraMessageBox.Show("please Enter The Name of Employee ");
                        txttennv.Focus();
                        return;
                    }
                    else if (txttennv.Text.IndexOfAny(cackitudacbiet.ToCharArray()) != -1)
                    {
                        XtraMessageBox.Show("The Name of Employee donn't Have Special Characters!");
                        return;
                    }
                    else if (txtsdt.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter Number Phone", "Warming");
                        txtsdt.Focus();
                        return;
                    }
                    else if (txtsdt.Text.Length < 6 || txtsdt.Text.Length > 13)
                    {
                        XtraMessageBox.Show("Please Enter Number Phone From 6 -> 12 Nunber", "Warming");

                    }

                    else
                    {
                        if (kiemtra == 1)
                        {

                            DTO.MANV = txtmanv.Text;

                            DTO.TENNV = txttennv.Text;
                            DTO.DIACHI = txtdiachi.Text;
                            string ngaysinh = cmbdate.Text;
                            ngaysinh = ngaysinh.Substring(6, 4) + "/" + ngaysinh.Substring(3, 2) + "/" + ngaysinh.Substring(0, 2);
                            DTO.NGAYSINH = ngaysinh;
                            DTO.SCMND = txtsoCMND.Text;
                            DTO.SDT = txtsdt.Text;
                            DTO.TINHTRANG = "False";
                            CTL.INSERTNHANVIEN(DTO);


                            XtraMessageBox.Show("You Added Successful");
                            this.Close();

                        }
                        else
                        {
                            DTO.MANV = txtmanv.Text;

                            DTO.TENNV = txttennv.Text;
                            DTO.DIACHI = txtdiachi.Text;
                            string ngaysinh = cmbdate.Text;
                            ngaysinh = ngaysinh.Substring(6, 4) + "/" + ngaysinh.Substring(3, 2) + "/" + ngaysinh.Substring(0, 2);
                            DTO.NGAYSINH = ngaysinh;
                            DTO.SCMND = txtsoCMND.Text;
                            DTO.SDT = txtsdt.Text;
                            DTO.TINHTRANG = KT;
                            CTL.UPDATENHANVIEN(DTO);

                            XtraMessageBox.Show("You Edited Successful");
                            this.Close();

                        }
                    }
                }
           
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            //if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
                this.Close();
            //}
        }

        private void txtpass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmThemBoPhan th = new frmThemBoPhan();
            th.kiemtra = 1;
            th.iNgonNgu = iNgonNgu;
            th.ShowDialog();
        }

        private void txttennv_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void lbtennv_Click(object sender, EventArgs e)
        {

        }

        private void lbngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void txtsdt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbtinhtrang_Click(object sender, EventArgs e)
        {

        }

        private void lbdiachi_Click(object sender, EventArgs e)
        {

        }

        private void txtmanv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txttennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txtdiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void cmbdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void txtsoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btLuu_Click(null, null);

            }
        }
    }
}