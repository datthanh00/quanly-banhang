using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Globalization;
using System.Threading;
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class ThemBanggia : DevExpress.XtraEditors.XtraForm
    {
        public ThemBanggia()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();
        public Boolean isthem;
        public String MABG, TENBG, GHICHU;
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        public void loadma()
        {
            txtMaBG.Text = connect.sTuDongDienMaBG(txtMaBG.Text);
        }
       
       
        
        private void ThemMatHang_Load(object sender, EventArgs e)
        {

            if (MABG == "")
            {
                loadma();
                MABG = txtMaBG.Text;
            }
            else
            {
                txtMaBG.Text = MABG;
                txttenbg.Text = TENBG;
                txtghichu.Text = GHICHU;

            }

            

        }
       
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (isthem)
            {
                loadma();
                if (PublicVariable.THEM == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                }
                if (txtMaBG.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng điền Mã Bảng Giá");
                    txtMaBG.Focus();
                    return;
                }
                if (txttenbg.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng điền Tên Bảng Giá");
                    txttenbg.Focus();
                    return;
                }

                DTO.GHICHU = txtghichu.Text;
                DTO.MABG = txtMaBG.Text;
                DTO.TENBG = txttenbg.Text;

                try
                {
                    CTL.addBanggia(DTO);
                }
                catch
                {
                    XtraMessageBox.Show("Vui Lòng Thử Lại");
                    return;
                }

                XtraMessageBox.Show("Đã thêm bảng giá");
                this.Close();

            }
            else
            {
                if (PublicVariable.SUA == "False")
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN ");
                    return;
                }
                if (txtMaBG.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng điền Mã Bảng Giá");
                    txtMaBG.Focus();
                    return;
                }
                if (txttenbg.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng điền Tên Bảng Giá");
                    txttenbg.Focus();
                    return;
                }

                DTO.GHICHU = txtghichu.Text;
                DTO.MABG = txtMaBG.Text;
                DTO.TENBG = txttenbg.Text;

                CTL.updateBanggia(DTO);
                this.Close();
            }
          
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}