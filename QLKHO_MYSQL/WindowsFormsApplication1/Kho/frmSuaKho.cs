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
    public partial class frmSuaKho : DevExpress.XtraEditors.XtraForm
    {
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string Nhan;
       public string MAKHO, TENKHO, MANV, DIACHI, SDTB, DTDD, NGUOILIENHE, FAX, GHICHU, TINHTRANG;       
        public frmSuaKho()
        {
            InitializeComponent();
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
            if (txtmakho.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Mã Kho");

            }
            else if (txtmanv.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Mã Nhân Viên");

            }
            else if (cmbtinhtrang.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Tình Trạng ", "Thông Báo");

            }
            else
            {
                //try
                //{

                DTO.MAKHO = txtmakho.Text;
                DTO.MANV = txtmanv.Text;
                DTO.TENKHO = txttenkho.Text;
                DTO.DIACHI = txtdiachi.Text;
                DTO.SDTB = txtsodtB.Text;
                DTO.DTDD = txtsodtDD.Text;
                DTO.NGUOILH = txtnguoiLH.Text;
                DTO.FAX = txtfax.Text;
                DTO.GHICHU = txtghichu.Text;
                DTO.TINHTRANG = KT;
                CTL.UPDATEKHO(DTO);
                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Có lỗi xảy ra");
                //}
            }
        }

        private void frmSuaKho_Load(object sender, EventArgs e)
        {
            txtmakho.Text = MACHUYEN;
            txtmanv.Text = MANV;
            txtnguoiLH.Text = NGUOILIENHE;
            txtsodtB.Text = SDTB;
            txtsodtDD.Text = DTDD;
            txttenkho.Text = TENKHO;
            txtdiachi.Text = DIACHI;
            txtfax.Text = FAX;
            txtghichu.Text = GHICHU;
            cmbtinhtrang.Text = TINHTRANG;
           // this.kHOTableAdapter.Fill(this.xUAT_NHAPTONDataSet4.KHO);


        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}