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
    public partial class frmSuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MAKHUVUC,TENKHUVUC,GHICHU, TINHTRANG;       
        public frmSuaKhuVuc()
        {
            InitializeComponent();
        }

        private void frmSuaKhuVuc_Load(object sender, EventArgs e)
        {
            txtma.Text = MAKHUVUC;
            txtten.Text = TENKHUVUC;
            txtghichu.Text = GHICHU;
            cmbtinhtrang.Text = TINHTRANG;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            bool KT;
            if (cmbtinhtrang.Text == "Kích Hoạt")
            {
                KT = true;

            }
            else
            {
                KT = false;
            }


            if (txtten.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Tên Khu Vực");

            }
            else if (txtma.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Mã Khu Vực");

            }
            else if (cmbtinhtrang.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Tình Trạng ", "Thông Báo");

            }
            else
            {
                //try
                //{

                DTO.MAKV = txtma.Text;
                DTO.TENKV = txtten.Text;

                DTO.GHICHU = txtghichu.Text;
                DTO.TINHTRANG = KT;
                CTL.UPDATEKHUVUC(DTO);
                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Có lỗi xảy ra");
                //}
            }

        }
    }
}