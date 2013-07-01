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
//////using WindowsFormsApplication1.class_TungLam;
using DevExpress.XtraEditors.DXErrorProvider;

namespace WindowsFormsApplication1
{
    public partial class frmThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public void loadma()
        {
            txtma.Text = connect.sTuDongDienMaBP(txtma.Text);
        }
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        public string MABP, TENBOPHAN;
        public string  TINHTRANG;       
        public int kiemtra;
        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (iNgonNgu == 0)
                {
                    String  KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }


                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Vui lòng Nhập Tên Bộ Phận");
                        txtten.Focus();
                        return;
                    }


                    //else
                    //{
                    if (kiemtra == 1)
                    {
                        int COUNTSTART = 0;
                    START_EXCUTIVE:
                        DTO.MABP = txtma.Text;
                        DTO.TENBOPHAN = txtten.Text;
                        DTO.TINHTRANG = KT;

                        
                        string SQLstart = "SELECT ACTIVE FROM MAHDARRAY WHERE TYPE='BP' AND MAKHO='" + PublicVariable.MAKHO + "'";
                        DataTable DTstart = connect.getdata(SQLstart);
                        if (DTstart.Rows.Count>0)
                        if (DTstart.Rows[0][0].ToString() == "True" && COUNTSTART < 20)
                        {
                            COUNTSTART = COUNTSTART + 1;
                            connect.dealTimer();
                            if (COUNTSTART == 19)
                            {
                                MessageBox.Show("CHƯA THÊM ĐƯỢC VUI LÒNG THỬ LẠI ");
                                return;
                            }
                            goto START_EXCUTIVE;
                           
                        }
                        loadma();
                        DTO.MABP = txtma.Text;
                        connect.ACTIVEINSERT("BP");
                        CTL.INSERTBOPHAN(DTO);
                        connect.UNACTIVEINSERT("BP");
                        XtraMessageBox.Show("Bạn Đã Thêm Thành Công");
                        this.Close();
                    }
                    else
                    {
                        DTO.MABP = txtma.Text;
                        DTO.TENBOPHAN = txtten.Text;
                        DTO.TINHTRANG = KT;
                        CTL.UPDATEBOPHAN(DTO);
                        XtraMessageBox.Show("Bạn Đã Sửa Thành Công");
                        this.Close();
                    }
                }
                else
                {
                    String  KT;
                    if (checkTT.Checked)
                    {
                        KT = "True";

                    }
                    else
                    {
                        KT = "False";
                    }

                    if (txtten.Text == "")
                    {
                        XtraMessageBox.Show("Please Enter Posittion Name");
                        txtten.Focus();
                        return;
                    }


                    else
                    {
                        if (kiemtra == 1)
                        {
                            DTO.MABP = txtma.Text;
                            DTO.TENBOPHAN = txtten.Text;

                            DTO.TINHTRANG = KT;
                            CTL.INSERTBOPHAN(DTO);
                            XtraMessageBox.Show("You Added Successful", "Warming");
                            this.Close();
                        }
                        else
                        {

                            DTO.MABP = txtma.Text;
                            DTO.TENBOPHAN = txtten.Text;
                            DTO.TINHTRANG = KT;
                            CTL.UPDATEBOPHAN(DTO);
                            XtraMessageBox.Show("You Edited Successful", "Warming");
                            this.Close();
                        }

                    }
                }
            }
            catch  
            {

                 
            }
           
            
            
        }

        private void btDong_Click(object sender, EventArgs e)
        {
             this.Close();
            
        }
        public int iNgonNgu;
        public void LoadTV()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMABP.Text = LamVN.MABP.ToString();
            lbTENBP.Text = LamVN.TENBP.ToString();
            lbTINHTRANG.Text = LamVN.TINHTRANG.ToString();
            lbchuy.Text = LamVN.CHUY.ToString();
            btluu.Text = LamVN.LUU.ToString();
            btDong.Text = LamVN.DONG.ToString();
           
        }
        public void LoadEL()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            lbMABP.Text = LamEL.MABP.ToString();
            lbTENBP.Text = LamEL.TENBP.ToString();
            lbTINHTRANG.Text = LamEL.TINHTRANG.ToString();
            lbchuy.Text = LamEL.CHUY.ToString();
            btluu.Text = LamEL.LUU.ToString();
            btDong.Text = LamEL.DONG.ToString();
            checkTT.Text = LamEL.CHECKTINHTRANG.ToString();
            this.Text = "Isert Infomation Posibility";
        }
        private void frmThemBoPhan_Load(object sender, EventArgs e)
        {
            if (iNgonNgu == 1)
            {
                LoadEL();


            }
            else
            {
                LoadTV();


            } 
           
            if (kiemtra==0)
            {
                txtma.Text = MABP;
                txtten.Text = TENBOPHAN;
                if (TINHTRANG =="True")
                {
                    checkTT.Checked = true;
                }
                else
                {
                    checkTT.Checked = false;
                }
                //checkTT.Checked = TINHTRANG;
            }
            else
            {
                loadma();
            }
        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
               
                btluu_Click(null,null);
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
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "Vui lòng Nhập Thông Tin", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }
            else 
            {
                if (control.Text == null || control.Text.Trim().Length == 0) dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical);
                else dxErrorProvider1.SetError(control, "");
            }
        }
        private void txtma_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtten_Validating(object sender, CancelEventArgs e)
        {
            

        }
    }
}