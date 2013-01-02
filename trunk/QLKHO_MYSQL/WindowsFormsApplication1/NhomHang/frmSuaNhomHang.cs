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
    public partial class frmSuaNhomHang : DevExpress.XtraEditors.XtraForm
    {
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MANH, TENNH, GHICHU;
        public frmSuaNhomHang()
        {
            InitializeComponent();
        }

        private void frmSuaNhomHang_Load(object sender, EventArgs e)
        {
            txtma.Text = MANH;
            txtten.Text = TENNH;
            txtghichu.Text = GHICHU;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Tên Khu Vực");

            }

            else if (txtghichu.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Ghi Chú ", "Thông Báo");

            }
            else
            {
                //try
                //{

                DTO.MANH = txtma.Text;
                DTO.TENNHOMHANG = txtten.Text;

                DTO.GHICHU = txtghichu.Text;

                CTL.UPDATENHOMHANG(DTO);
                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();
             
            }
        }
    }
}