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
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuc()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaKV(txtma.Text);
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
        public string MAKHUVUC, TENKHUVUC, GHICHU, TINHTRANG;
        public int kiemtra;
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMAKV.Text = LamVN.MAKV.ToString();
            lbTENKV.Text = LamVN.TENKV.ToString();
            lbGHICHU.Text = LamVN.GHICHU.ToString();
            lbTINHTRANG.Text = LamVN.TINHTRANG.ToString();
           lbCHUY.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMAKV.Text = LamEL.MAKV.ToString();
            lbTENKV.Text = LamEL.TENKV.ToString();
            lbGHICHU.Text = LamEL.GHICHU.ToString();
            lbTINHTRANG.Text = LamEL.TINHTRANG.ToString();
            lbCHUY.Text = LamEL.CHUY.ToString();               
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString(); checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            this.Text = "Form Insert Areas";
        }
        private void frmThemKhuVuc_Load(object sender, EventArgs e)
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
                txtma.Text = MAKHUVUC;
                txtten.Text = TENKHUVUC;
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
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    bool KT;
                    if (checkTT.Checked)
                    {
                        KT = true;

                    }
                    else
                    {
                        KT = false;
                    }



                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Khu Vực");
                        txtten.Focus();
                        return;
                    }
                    else if (txtma.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Mã Khu Vực");
                        txtma.Focus();
                        return;
                    }
                    //else if (cmbtinhtrang.Text == "")
                    //{
                    //    XtraMessageBox.Show("Vui Lòng Chọn Tình Trạng ", "Thông Báo");

                    //}
                    if (kiemtra == 1)
                    {
                        DTO.MAKV = txtma.Text;
                        DTO.TENKV = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.INSERTKHUVUC(DTO);
                        XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                        this.Close();
                    }
                    else
                    {
                        DTO.MAKV = txtma.Text;
                        DTO.TENKV = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.UPDATEKHUVUC(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }

                }
                else
                {
                    bool KT;
                    if (checkTT.Checked)
                    {
                        KT = true;

                    }
                    else
                    {
                        KT = false;
                    }


                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter Area Name");
                        txtten.Focus();
                        return;
                    }
                    else if (txtma.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter Area ID");
                        txtma.Focus();
                        return;
                    }
                    //else if (cmbtinhtrang.Text == "")
                    //{
                    //    XtraMessageBox.Show("Vui Lòng Chọn Tình Trạng ", "Thông Báo");

                    //}
                    if (kiemtra == 1)
                    {
                        DTO.MAKV = txtma.Text;
                        DTO.TENKV = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.INSERTKHUVUC(DTO);
                        XtraMessageBox.Show("You Added Successful");
                        this.Close();
                    }
                    else
                    {
                        DTO.MAKV = txtma.Text;
                        DTO.TENKV = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;
                        DTO.TINHTRANG = KT;
                        CTL.UPDATEKHUVUC(DTO);
                        XtraMessageBox.Show("You Edited Successful");
                        this.Close();
                    }

                }
           
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                
                btluu_Click(null, null);
            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}