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
    public partial class frmThemNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhomHang()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaNhomHang(txtma.Text);
        }
        public int kiemtra;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MANH, TENNH, GHICHU;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        private void btDong_Click(object sender, EventArgs e)
        {
            //if (DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            //{
                this.Close();
            //}
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbma.Text = LamVN.MANH.ToString();
            lbten.Text = LamVN.TENNHOMHANG.ToString();
            lbghichu.Text = LamVN.GHICHU.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbma.Text = LamEL.MANH.ToString();
            lbten.Text = LamEL.TENNHOMHANG.ToString();
            lbghichu.Text = LamEL.GHICHU.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            this.Text = "Form Insert && Update Group Products";
        }
        private void frmThemNhomHang_Load(object sender, EventArgs e)
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
                txtma.Text = MANH;
                txtten.Text = TENNH;
                txtghichu.Text = GHICHU;
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
                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Nhóm Hàng");
                        txtten.Focus();
                        return;
                    }

              
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MANH = txtma.Text;
                        DTO.TENNHOMHANG = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;

                        try
                        {
                            CTL.INSERTNHOMHANG(DTO);
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
                        
                        DTO.MANH = txtma.Text;
                        DTO.TENNHOMHANG = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;

                        CTL.UPDATENHOMHANG(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }
                }
                else
                {
                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter The Name Of Area", "Warming");
                        txtten.Focus();
                        return;
                    }

   
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MANH = txtma.Text;
                        DTO.TENNHOMHANG = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;

                        try
                        {
                            CTL.INSERTNHOMHANG(DTO);
                        }
                        catch
                        {
                            XtraMessageBox.Show("try again");
                            return;
                        }
                        XtraMessageBox.Show("You Added Successful");
                        this.Close();
                    }
                    else
                    {

                        DTO.MANH = txtma.Text;
                        DTO.TENNHOMHANG = txtten.Text;

                        DTO.GHICHU = txtghichu.Text;

                        CTL.UPDATENHOMHANG(DTO);
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
    }
}