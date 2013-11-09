using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using DevExpress.XtraEditors;
using Quanlykho;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemThue : Form
    {
        public frmThemThue()
        {
            InitializeComponent();
        }
        public int kiemtra;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        ketnoi connect = new ketnoi();
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MATH, SOTHUE;
        public int ingonngu;
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaThue(txtma.Text);
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingonngu == 0)
                {
                    if (txtsothue.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Số Thuế");
                        txtsothue.Focus();
                        return;
                    }
                    else if (Convert.ToInt64(txtsothue.Value) < 0)
                    {
                        MessageBox.Show("Số Thuế phải lớn hơn hoặc bằng 0");
                        txtsothue.Value = 0;
                        return;
                    }

                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MATH = txtma.Text;
                        DTO.SOTHUE = Convert.ToInt64(txtsothue.Value).ToString();
                        try
                        {
                            CTL.INSERTTHUE(DTO);
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

                        DTO.MATH = txtma.Text;
                        DTO.SOTHUE = Convert.ToInt64(txtsothue.Value).ToString();

                        CTL.UPDATETHUE(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }
                }
                else
                {
                    if (txtsothue.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter The Number Of Tax");

                    }
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MATH = txtma.Text;
                        DTO.SOTHUE = Convert.ToInt64(txtsothue.Text).ToString();
                        try
                        {
                            CTL.INSERTTHUE(DTO);
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

                        DTO.MATH = txtma.Text;
                        DTO.SOTHUE = Convert.ToInt64(txtsothue.Text).ToString();

                        CTL.UPDATETHUE(DTO);
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
        //public int ingonngu;
        public void LoadTV()
        {
            ingonngu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbma.Text = LamVN.MATH.ToString();
            lbten.Text = LamVN.SOTHUE.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            ingonngu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbma.Text = LamEL.MATH.ToString();
            lbten.Text = LamEL.SOTHUE.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            this.Text = "Form Insert Tax";
        }
        private void frmThemThue_Load(object sender, EventArgs e)
        {
            if (ingonngu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            }
            if (kiemtra == 0)
            {
                txtma.Text = MATH;
                txtsothue.Text = SOTHUE;
            }
            else
            {
                loadma();
            }
            
          
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);

            }
        }

        private void txtsothue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);

            }
        }
    }
}
