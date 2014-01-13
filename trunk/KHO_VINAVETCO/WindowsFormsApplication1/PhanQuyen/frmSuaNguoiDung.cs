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

namespace WindowsFormsApplication1
{
    public partial class frmSuaNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNguoiDung()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        public string tennv, manv, tendangnh, stinhtrang, mabp,tenbp;
        private void frmSuaNguoiDung_Load(object sender, EventArgs e)
        { loadGLVaiTro();
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else
            {
                loadEN();
            }
            txtma.Text = manv;
            txtten.Text = tennv;
            gridLookUpEdit1.Text = mabp;

            txttendangnhap.Text = tendangnh;

            txtma.Properties.ReadOnly = true;
            txtten.Properties.ReadOnly = true;
            txttendangnhap.Properties.ReadOnly = true;

        }
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            layoutControlItem4.Text = LamVN.USERNAME.ToString();
            layoutControlItem1.Text = LamVN.TENNV.ToString();
            layoutControlItem2.Text = LamVN.MANV.ToString();
            layoutControlItem3.Text = LamVN.TENBP.ToString();
            btDong.Text = LamVN.DONG.ToString();
            btLuu.Text = LamVN.LUU.ToString();
            this.Text = "Sửa người dùng";
            colMABP.Caption = LamVN.MABP.ToString();
            colTenBP.Caption = LamVN.TENBP.ToString();
        }
        public void loadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            layoutControlItem4.Text = LamEL.USERNAME.ToString();
            layoutControlItem1.Text = LamEL.TENNV.ToString();
            layoutControlItem2.Text = LamEL.MANV.ToString();
            layoutControlItem3.Text = LamEL.TENBP.ToString();
            btDong.Text = LamEL.DONG.ToString();
            btLuu.Text = LamEL.LUU.ToString();
            this.Text = "Edit user";
            colMABP.Caption = LamEL.MABP.ToString();
            colTenBP.Caption = LamEL.TENBP.ToString();

        }

        private void loadGLVaiTro()
        {
            gridLookUpEdit1.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            gridLookUpEdit1.Properties.DisplayMember = "TENBOPHAN";
            gridLookUpEdit1.Properties.ValueMember = "MABP";
            gridLookUpEdit1.Properties.View.BestFitColumns();
            gridLookUpEdit1.Properties.PopupFormWidth = 300;
            gridLookUpEdit1.Properties.DataSource = ctr.getBoPhan();
        }

        public int iNgonNgu;
    
        private void btLuu_Click(object sender, EventArgs e)
        {
            dto.MANV = txtma.Text;
            dto.MABOPHAN = mabp;
            ctr.SuaNguoiDung(dto);
            this.Refresh();
            if (iNgonNgu == 1)
            {
                MessageBox.Show("Update sucessfully");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
            }
            this.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookUpEdit1_Validated(object sender, EventArgs e)
        {
            try
            {
                mabp = gBoPhan.GetFocusedRowCellValue("MABP").ToString();
            }
            catch
            {

            }
        }

    }
}