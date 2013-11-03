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
using DevExpress.XtraEditors.DXErrorProvider;
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmThemDVT : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDVT()
        {
            InitializeComponent();
        }
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        ketnoi connect = new ketnoi();
        public int kiemtra;
        
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MADVT, DONVITINH;
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaDVT(txtma.Text);
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbmaDVT.Text = LamVN.MADVT.ToString();
            lbDVT.Text = LamVN.DVT.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();

        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbmaDVT.Text = LamEL.MADVT.ToString();
            lbDVT.Text = LamEL.DVT.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            this.Text = "Form Insert Unit";
        }
        private void frmThemDVT_Load(object sender, EventArgs e)
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
                txtma.Text = MADVT;
                txtten.Text = DONVITINH;
            }
            else
            {
                loadma();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           
          
            //if (txtma.Text == "")
            //{
            //    XtraMessageBox.Show("Vui lòng Nhập Mã ĐVT");

            if (iNgonNgu == 0)
            {
                if (txtten.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng Nhập Tên ĐVT");
                    txtten.Focus();
                    return;
                }
                else
                {
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MADVT = txtma.Text;
                        DTO.DONVITINH = txtten.Text;

                        try
                        {
                            CTL.INSERTDVT(DTO);
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
                        DTO.MADVT = txtma.Text;
                        DTO.DONVITINH = txtten.Text;
                        CTL.UPDATEDVT(DTO);


                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }

                }
            }
            else 
            {
                if (txtten.Text == "")
                {
                    XtraMessageBox.Show("Please Insert into the Name of Units");
                    txtten.Focus();
                    return;
                }
                else
                {
                    if (kiemtra == 1)
                    {
                        loadma();
                        DTO.MADVT = txtma.Text;
                        DTO.DONVITINH = txtten.Text;

                        try
                        {
                            CTL.INSERTDVT(DTO);
                        }
                        catch
                        {
                            XtraMessageBox.Show("try again");
                            return;
                        }
                        
                        
                        XtraMessageBox.Show("You Added Sucessfull");
                        this.Close();
                    }
                    else
                    {
                        DTO.MADVT = txtma.Text;
                        DTO.DONVITINH = txtten.Text;
                        CTL.UPDATEDVT(DTO);


                        XtraMessageBox.Show("You Edited Sucessfull");
                        this.Close();
                    }

                }
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

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }
        private void Validate_EmptyStringRule(BaseEdit control)
        {
            if (iNgonNgu == 0)
            {
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "Vui lòng Nhập Tên Bộ Phận", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }
            else
            {
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }

        }

        private void txtten_Validating(object sender, CancelEventArgs e)
        {
            //Validate_EmptyStringRule(sender as BaseEdit);
            //txtten.Focus();
            //return;
        }

    }
}