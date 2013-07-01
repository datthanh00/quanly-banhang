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
            }

            MABG = txtMaBG.Text;

        }
       
        private void btLuu_Click(object sender, EventArgs e)
        {
            
            if (isthem)
            {
            int COUNTSTART = 0;
            START_EXCUTIVE:
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

                string SQLstart = "SELECT ACTIVE FROM MAHDARRAY WHERE TYPE='BG' AND MAKHO='" + PublicVariable.MAKHO + "'";
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
                DTO.MABG = txtMaBG.Text;
                connect.ACTIVEINSERT("BG");

                CTL.addBanggia(DTO);
                connect.UNACTIVEINSERT("BG");
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