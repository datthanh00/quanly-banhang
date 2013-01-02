using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmSuaDVT : DevExpress.XtraEditors.XtraForm
    {
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MADVT, DONVITINH;
        public frmSuaDVT()
        {
            InitializeComponent();
        }

        private void frmSuaDVT_Load(object sender, EventArgs e)
        {
            txtma.Text = MADVT;
            txtten.Text = DONVITINH;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {

            if (txtten.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Đơn Vị Tính");

            }
           
           
            else
            {
                //try
                //{

                DTO.MADVT = txtma.Text;
                DTO.DONVITINH = txtten.Text;
                CTL.UPDATEDVT(DTO);
               
                
                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();
               
            }
        }
    }
}