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
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }
        DTO DTO = new DTO();
        CTL CTL = new CTL();
        DAO DAO = new DAO();
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string MANV, MABP, USERNAME, PASSWORD, CHUCVU, TENNV, DIACHI, SCMND, SDT, TINHTRANG, NGAYSINH;
      //  public DateTime NGAYSINH;

       
        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet19.BOPHAN' table. You can move, or remove it, as needed.
           // this.bOPHANTableAdapter.Fill(this.xUAT_NHAPTONDataSet19.BOPHAN);
            // TODO: This line of code loads data into the 'xUAT_NHAPTONDataSet14.BOPHAN' table. You can move, or remove it, as needed.
           // this.bOPHANTableAdapter1.Fill(this.xUAT_NHAPTONDataSet14.BOPHAN);
            txtmanv.Text = MANV;
            txttennv.Text = TENNV;
            cmbphongban.Text = MABP;
            txtuser.Text = USERNAME;
            txtpass.Text = PASSWORD;
            cmbchucvu.Text = CHUCVU;
            txtdiachi.Text = DIACHI;
            cmbdate.Text = NGAYSINH;
            txtsoCMND.Text = SCMND;
            txtsdt.Text = SDT;
            cmbtinhtrang.Text = TINHTRANG;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            bool KT;
            if (cmbtinhtrang.Text == "Kích Hoạt")
            {
                KT = true; ;

            }
            else
            {
                KT = false;
            }


            if (txttennv.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Tên Nhân Viên ");

            }
            else if (txtuser.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Tên Đăng Nhập Vào");

            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu Vào ");
                txtpass.Focus();
            }
            else if (txtpass.Text != txtmatma1.Text)
            {
                MessageBox.Show("Mã xác nhận không chính xác");
                txtmatma1.SelectAll();
                txtmatma1.Focus();
            }
            else if (cmbchucvu.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Chức Vụ ");

            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập SĐT");

            }
            else if (cmbtinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Tình Trạng ");

            }
            else if (cmbphongban.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Phòng Ban ");

            }
            else
            {
                //try
                //{


                DTO.MANV = txtmanv.Text;
                DTO.MABP = cmbphongban.Text;

                DTO.USERNAME = txtuser.Text;
                DTO.PASSWORD = txtpass.Text;
                DTO.CHUCVU = cmbchucvu.Text;
                DTO.TENNV = txttennv.Text;
                DTO.DIACHI = txtdiachi.Text;
                DTO.NGAYSINH = cmbdate.Text;
                DTO.SCMND = txtsoCMND.Text;
                DTO.SDT = txtsdt.Text;
                DTO.TINHTRANG = KT;
                CTL.UPDATENHANVIEN(DTO);

                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();

            }
        }

        private void btDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}